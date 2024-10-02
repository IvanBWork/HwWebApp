using HwWebApp.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwWebApp.Repositories
{
    public interface IProductGroupRepository
    {
        int AddProductGroup(ProductGroupDto group);
        List<ProductGroupDto> GetAllProductGroups();
        ProductGroupDto DeleteProductGroup(string name);
    }
}
