using ShopERP.Business.Exceptions;
using ShopERP.Business.Interfaces;
using ShopERP.Core.Models;
using ShopERP.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopERP.Business.Implementations
{
    public class ShopService : IShopService
    {
        public void AddEmployee(int employeeId, int shopId)
        {
            Shop? searched = ShopDataBase<Shop>.ShopData.Find(x => x.ID == shopId);
            Employee? employee = ShopDataBase<Employee>.ShopData.Find(x => x.ID == employeeId);
            if (searched != null)
            {
                if (employee != null)
                {
                    searched.Employees.Add(employee);
                    employee.Shop = searched;
                }
                else throw new EmployeeNotFoundException("Employee could not be found!");
            }
            else throw new ShopNotFoundException("Shop could not be found!");

        }

        public void AddProduct(int pProductId, int shopId)
        {
            Shop? searched = ShopDataBase<Shop>.ShopData.Find(x => x.ID == shopId);
            Product? product=ShopDataBase<Product>.ShopData.Find(x=>x.ID == pProductId);
            if (searched != null)
            {
                if (product != null)
                {
                    searched.Products.Add(product);
                    product.Shop = searched;
                }
                else throw new ProductNotFoundExeption("Product could not be found!");
            }
            else throw new ShopNotFoundException("Shop could not be found!");


        }

        public void Create(Shop shop)
        {
            if (shop != null)
            {
                ShopDataBase<Shop>.ShopData.Add(shop);
            }
            else
                throw new ShopNotFoundException("Shop could not be found!");
            
        }

        public List<Shop> GetAll()
        {
            return ShopDataBase<Shop>.ShopData;
        }

        public void Remove(int Id)
        {
            Shop? searched=ShopDataBase<Shop>.ShopData.Find(x=> x.ID==Id);
            if(searched != null)
            {      
             foreach (var employee in ShopDataBase<Employee>.ShopData.FindAll(x => x.Shop?.ID==Id))
                {
                    employee.Shop = null;
                }
                searched.Employees.Clear();

                foreach (var product in ShopDataBase<Product>.ShopData.FindAll(x => x.Shop?.ID == Id))
                {
                    product.Shop = null;
                }
                searched.Products.Clear();
                ShopDataBase<Shop>.ShopData.Remove(searched);
            }
            
        }
    }
}
