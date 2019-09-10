﻿namespace Shop.Web.Controllers.API
{
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Data;

    [Route("api/[Controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductsController( IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        // Lista de productos
        [HttpGet]
        public IActionResult GetProducts()
        {
            //return Ok( this.productRepository.GetAll());
            return Ok(this.productRepository.GetAllWithUsers());
        }

    }
}
