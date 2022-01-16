using Microsoft.AspNetCore.Mvc;
using RealShop.Service;

namespace RealShop.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get([FromRoute]int id)
        {
            var productService = new ProductService();

            var result = productService.GetById(id);

            return Ok(result);
        }
    }
}
