using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Threading;

namespace FSDHAssignment1.Utility
{
    public class Logger
    {

        
        private static readonly object _syncObject = new object();

        /// <summary>
        /// This is meant to create a file per class per day
        /// </summary>
        /// <param name="MethodName"></param>
        /// <param name="message"></param>
        /// <param name="callingClass"></param>
        public static void LogInfo(string MethodName, object message, object callingClass)
        {
            new Thread(() =>
            {

                lock (_syncObject)
                {
                    string logData = string.Empty;
                    try
                    {
                        string filename = string.Format("..//{0}_{1:dd-MMM-yyyy}.txt", callingClass.GetType().Name, DateTime.Now);
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine(LoggerModel.FormatMessage(MethodName, message == null ? "" : message.ToString()));

                        using (System.IO.StreamWriter str = new System.IO.StreamWriter(filename, true))
                        {
                            str.WriteLine(sb.ToString());
                        }
                    }
                    catch
                    {
                        System.Diagnostics.Trace.TraceInformation(logData);
                    }
                }

            }).Start();

        }


    }

    class LoggerModel
    {

        public static string FormatMessage(string logPath, string message, string logLevel = "Info")
        {
            return JsonConvert.SerializeObject(Instance(logPath, message, logLevel));
        }

        private static LoggerModel Instance(string logPath, string message, string logLevel)
        {
            var now = DateTime.Now;
            return new LoggerModel()
            {
                Date = now.ToString("yyyy-MM-dd"),
                Time = now.ToString("HH:mm:ss:ffffff"),
                LogLevel = logLevel,
                ThreadID = $"{Thread.CurrentThread.ManagedThreadId}",
                LogID = logPath,
                Message = message
            };
        }
        public string Date { get; set; }
        public string Time { get; set; }
        public string LogLevel { get; set; }
        public string ThreadID { get; set; }
        public string LogID { get; set; }
        public string Message { get; set; }
    }
}
