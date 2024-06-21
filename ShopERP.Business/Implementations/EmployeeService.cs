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
    public class EmployeeService : IEmployeeService
    {
        public void Create(Employee employee)
        {

            if (employee != null)
            {
                ShopDataBase<Employee>.ShopData.Add(employee);
            }
            else
                throw new EmployeeNotFoundException("Employee could not be found!");
        }

        public void Remove(int empId)
        {
            IShopService shopService = new ShopService();
            Employee? searched = ShopDataBase<Employee>.ShopData.Find(x => x.ID == empId);
            if (searched != null)
            {
                Shop? shop = shopService.GetAll().Find(shop => shop.ID == searched.Shop?.ID);
                if (shop != null)
                {
                    shop.Employees.Remove(searched);
                }
                ShopDataBase<Employee>.ShopData.Remove(searched);
            }
            else
                throw new EmployeeNotFoundException("Employee could not be found!");
        }
    }
}
