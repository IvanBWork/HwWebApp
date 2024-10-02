using HwWebApp.Dto;
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
    public class ProductGroupController : ControllerBase
    {
        private readonly IProductGroupRepository _repository;

        public ProductGroupController(IProductGroupRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("add_product_group")]
        public ActionResult<int> AddProductGroup(ProductGroupDto group)
        {
            try
            {
                return Ok(_repository.AddProductGroup(group));
            }
            catch (Exception ex) { return StatusCode(409, ex.Message); }
        }

        [HttpGet("get_all_product_groups")]
        public ActionResult<List<ProductGroupDto>> GetAllProductGroups()
        {
            try
            {
                return Ok(_repository.GetAllProductGroups());
            }
            catch (Exception ex) { return StatusCode(409, ex.Message); }
        }

        [HttpDelete("delete_product_group")]
        public ActionResult<ProductGroupDto> DeleteProductGroup(string name)
        {
            try
            {
                return Ok(_repository.DeleteProductGroup(name));
            }
            catch (Exception ex) { return StatusCode(409, ex.Message); }
        }
    }
}
