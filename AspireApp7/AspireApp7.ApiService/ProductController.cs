using AspireApp7.ApiService.Data;
using AspireApp7.ApiService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspireApp7.ApiService
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataDbContext _context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public ProductController(DataDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var listodEmployees = await _context.Products.ToListAsync();
            return Ok(listodEmployees);
        }

        [HttpPost]
        public async Task<bool> AddProduct([FromBody] ProductRequest productrequest)
        {
            try
            {
                var products = new Product
                {
                    Name = productrequest.Name,
                    Price = productrequest.Price,
                    Description = productrequest.Description
                };

                await _context.Products.AddAsync(products);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw;
            }
            return true;
        }
    }
}
