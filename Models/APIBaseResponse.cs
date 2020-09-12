using System;
using System.Collections.Generic;
using System.Text;

namespace FSDHAssignment1.Models
{
    /// <summary>
    /// This is the base response class for all API calls that will be made.
    /// </summary>
    public class APIBaseResponse
    {
        /// <summary>
        /// This field indicates if the request was fulfilled successfully. If its value is <code>false</code>,
        /// then the Message field will contain the reason it failed.
        /// </summary>
        public bool IsSuccessful { get; set; }
        /// <summary>
        /// This field usually indicates the reason the request made is not successful.
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// This field will contain the data for any request when one is required.
        /// </summary>
        public object Data { get; set; }
    }
}
