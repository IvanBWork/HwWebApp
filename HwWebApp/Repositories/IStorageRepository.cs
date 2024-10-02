using HwWebApp.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwWebApp.Repositories
{
    public interface IStorageRepository
    {
        int AddStorage(StorageDto storage);
        IEnumerable<StorageDto> GetStorages();
        StorageDto DeleteStorage(int productId);
    }
}
