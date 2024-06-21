using ShopERP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopERP.Business.Interfaces
{
    public interface IShopService
    {
        void Create(Shop shop);
        void Remove(int Id);
        void AddProduct(int pProductId, int shopId);
        void AddEmployee(int employeeId, int shopId);
        List<Shop> GetAll();

    }
}
