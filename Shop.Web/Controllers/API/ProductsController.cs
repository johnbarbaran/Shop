﻿namespace Shop.Web.Controllers.API
{    
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Data;

    [Route("api/[Controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ProductsController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository)
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
