using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // loosely coupled    --- düşük/zayıf bağımlılık
        // naming convention  --- isimlendirme standardı
        // IoC - Container    --- Inversion of Control // değişimin kontrolü 

        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]

        public IActionResult GetAll()
        {

            // IProductService productService = new ProductService(new EfProductDal());

            var result = _productService.GetAll();

            if (result.Success)
            {
                return Ok(result); // Ok 200
            }
            return BadRequest(result); // BadRequest 400

        }

        [HttpGet("getbyid")]

        public IActionResult GetById(int id)
        {
            var result2 = _productService.GetById(id);
            if (result2.Success)
            {
                return Ok(result2);
            }
            return BadRequest(result2);
        }

        [HttpPost("add")]

        public IActionResult Post(Product product)
        {
            var result3 = _productService.Add(product);
            if (result3.Success)
            {
                return Ok(result3);

            }
            return BadRequest(result3);
        }
    }
}
