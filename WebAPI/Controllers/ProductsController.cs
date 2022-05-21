using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;

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

            Thread.Sleep(100);

            var result = _productService.GetAll();

            if (result.Success)
            {
                return Ok(result); // Ok 200
            }
            return BadRequest(result.Message); // BadRequest 400

        }

        [HttpGet("getbyid")]

        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getallbycategoryid")]

        public IActionResult GetAllByCategoryId(int categoryId)
        {
            var result = _productService.GetAllByCategory(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("productdto")]

        public IActionResult GetProductDto()
        {
            var result = _productService.GetProductDetails();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]

        public IActionResult Post(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result.Message);
        }
    }
}
