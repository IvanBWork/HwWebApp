﻿using HwWebApp.Dto;
using HwWebApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("add_product")]
        public ActionResult<int> AddProduct(ProductDto product)
        {
            try
            {
                return Ok(_repository.AddProduct(product));
            }
            catch (Exception ex) { return StatusCode(409); }
        }

        [HttpGet("get_all_products")]
        public ActionResult<IEnumerable<ProductDto>> GetAllProducts()
        {
            return Ok(_repository.GetAllProducts());
        }

        [HttpDelete("delete_product")]
        public ActionResult<ProductDto> DeleteProduct(string name)
        {
            try
            {
                return Ok(_repository.DeleteProduct(name));
            }
            catch (Exception ex)
            {
                return StatusCode(409, ex.Message);
            }
        }

        [HttpGet("get_all_products_report")]
        public FileContentResult GetAllProductReport()
        {
            var content = _repository.GetCsv();
            var file = File(new System.Text.UTF8Encoding().
                GetBytes(content), "text/csv", "report.csv");

            return file;
        }
    }
}
