using ShopERP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopERP.Business.Interfaces
{
    public interface IEmployeeService
    {
        void Create(Employee employee);
        void Remove(int empId);


    }
}
