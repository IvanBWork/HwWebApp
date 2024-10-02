using HwWebApp.Dto;
using HwWebApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwWebApp.Graph.Query
{
    public class Query(IProductRepository productRepository)
    {
        public IEnumerable<ProductDto> GetProducts()
            => productRepository.GetAllProducts();

        public IEnumerable<ProductGroupDto> GetProductGroups([Service] IProductGroupRepository groupRepository)
            => groupRepository.GetAllProductGroups();

        public IEnumerable<StorageDto> GetStorages([Service] IStorageRepository storageRepository)
            => storageRepository.GetStorages();
    }
}
