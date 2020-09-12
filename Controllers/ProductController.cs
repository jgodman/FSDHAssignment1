using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FSDHAssignment1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FSDHAssignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
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


            return null;
        }


    }
}