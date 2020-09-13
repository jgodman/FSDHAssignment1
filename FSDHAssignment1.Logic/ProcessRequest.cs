using FHSDAssignment1.IData;
using FSDHAssignment1.Model;
using System;
using System.Collections.Generic;

namespace FSDHAssignment1.Logic
{
    public class ProcessRequest
    {


        public static List<RetailProduct> GetProducts(IRepository<RetailProduct> repository, string query)
        {
            return repository.GetDataByQuery(query);
        }
    }
}
