using ShopERP.Business.Exceptions;
using ShopERP.Business.Interfaces;
using ShopERP.Core.Models;
using ShopERP.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShopERP.Business.Implementations
{
    public class ProductService : IProductService
    {
        public void Create(Product product)
        {
            if (product != null)
            {
                ShopDataBase<Product>.ShopData.Add(product);
            }
            else
                throw new ProductNotFoundExeption("Product could not be found!");
        }

        public void Remove(int proId)
        {
            IShopService shopService = new ShopService();
          Product? searched= ShopDataBase<Product>.ShopData.Find(x=> x.ID==proId);
            if (searched != null)
            {
                Shop? shop = shopService.GetAll().Find(shop => shop.ID == searched.Shop?.ID);
                if (shop !=null)
                {
                    shop.Products.Remove(searched);
                }
                ShopDataBase<Product>.ShopData.Remove(searched);
            }
            else
                throw new ProductNotFoundExeption("Product could not be found!");

        }
    }
}
