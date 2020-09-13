using FDSHAssignment1.Data.SQL;
using FHSDAssignment1.IData;
using FSDHAssignment1.Data.StaticRepository;
using FSDHAssignment1.Logic;
using FSDHAssignment1.Model;
using FSDHAssignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace FSDHAssignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly bool IsStaticRepo;
        public ProductController(IConfiguration configuration)
        {
            if (configuration["DataSourceType"] == "StaticRepository")
                IsStaticRepo = true;
        }

        [Route("api/Product/Add")]
        [HttpPost]
        public APIBaseResponse AddProduct([FromBody]ProductRequest request)
        {

            if (request == null)
            {
                return new APIBaseResponse
                {
                    Message = "Invalid data was received"
                };
            }

            if (string.IsNullOrWhiteSpace(request.ProductName) || request.MOQ < 1 ||
                request.Price <= 0)
            {
                return new APIBaseResponse
                {
                    Message = "We received an invalid request. Please ensure that you provide name, the MOQ and a price greater than 0 (zero)."
                };
            }

            IRepository<RetailProduct> productRepo = null;

            if (IsStaticRepo)
            {
                productRepo = new StaticRepository<RetailProduct>();
            }
            else
            {
                productRepo = new SQLRepository<RetailProduct>();
            }

            var products = ProcessRequest.GetProducts(productRepo, "select * from RetailProduct");

            return new APIBaseResponse
            {
                IsSuccessful = true,
                Data = products
            };
        }


    }
}