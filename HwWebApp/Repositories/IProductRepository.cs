using HwWebApp.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwWebApp.Repositories
{
    public interface IProductRepository
    {
        int AddProduct(ProductDto product);
        IEnumerable<ProductDto> GetAllProducts();
        ProductDto DeleteProduct(string name);
        string GetCsv();
    }
}
