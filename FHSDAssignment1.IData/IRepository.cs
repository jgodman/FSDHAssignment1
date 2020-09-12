using System;
using System.Collections.Generic;

namespace FHSDAssignment1.IData
{


    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        /// <summary>
        /// This creates a model pattern for all inserts.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Save(TEntity data);
        /// <summary>
        /// This creates a pattern for all updates
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Update(int ID, TEntity data);
        /// <summary>
        /// This creates a pattern for all simple fetches. It uses a dictionary to fetch the data with
        /// the key-value pairs in the dictionary ANDed. This is just for simple-straight-forward
        /// queries
        /// </summary>
        /// <returns></returns>
        public List<TEntity> GetData(Dictionary<string, object> fieldNameDataPair);
        /// <summary>
        /// This creates a pattern for all complex data fetches that may require multiple combination of
        /// operations.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public List<TEntity> GetDataByQuery(string query);
        /// <summary>
        /// This is meant to ensure that all resources deployed in implementing the data access
        /// class is released. It is written this way so that all implementations follow the disposable
        /// pattern.
        /// </summary>
        /*public void Dispose()
        {
            Dispose(true);
        }
        public abstract void Dispose(bool disposing);*/
    }
}
