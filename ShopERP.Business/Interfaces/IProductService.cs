using ShopERP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopERP.Business.Interfaces
{
    public interface IProductService
    {
        void Create(Product product);
        void Remove(int proId);
    }
}
