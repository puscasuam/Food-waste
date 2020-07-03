
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IGenericRepository<Product> _productRepo;
        private readonly IGenericRepository<DietType> _productDietRepo;
        private readonly IGenericRepository<ProductType> _productTypeRepo;

        public ProductsController(IGenericRepository<Product> productRepo, IGenericRepository<DietType> productDietRepo, 
            IGenericRepository<ProductType> productTypeRepo) 
        {
            _productRepo = productRepo;
            _productDietRepo = productDietRepo;
            _productTypeRepo = productTypeRepo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts() 
        {
            var spec = new ProductsWithTypesAndDietsTypesSpecification();

            var products = await _productRepo.ListAsync(spec);

            return Ok(products);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var spec = new ProductsWithTypesAndDietsTypesSpecification(id);

            return await _productRepo.GetEntityWithSpec(spec);
        }

        [HttpGet("diets")]
        public async Task<ActionResult<IReadOnlyList<DietType>>> GetDietTypes()
        {
            return Ok(await _productDietRepo.ListAllAsync());
        }

        [HttpGet("types")]
        public async Task<ActionResult<IReadOnlyList<ProductType>>> GetProductTypes()
        {
            return Ok(await _productTypeRepo.ListAllAsync());
        }
    }
}