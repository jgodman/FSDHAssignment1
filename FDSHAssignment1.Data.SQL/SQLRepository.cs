using FHSDAssignment1.IData;
using System;
using System.Collections.Generic;

namespace FDSHAssignment1.Data.SQL
{
    public class SQLRepository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        

        public List<TEntity> GetData(Dictionary<string, object> fieldNameDataPair)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetDataByQuery(string query)
        {
            throw new NotImplementedException();
        }

        public bool Save(TEntity data)
        {
            throw new NotImplementedException();
        }

        public bool Update(int ID, TEntity data)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {

        }

        public void Dispose()
        {
            Dispose(true);
        }

    }
}
