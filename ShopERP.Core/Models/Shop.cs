using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopERP.Core.Models
{
    public class Shop:ShopBase
    { private static int id;
        public double MinSalary { get; set; }
        public double Budget { get; set;}
       public  List<Employee> Employees= new List<Employee>();
       public List<Product> Products= new List<Product>();
        public Shop(string name, double min, double budget)
        {
            Name = name;
            MinSalary = min;
            ++id;
            ID=id;
        Budget = budget;
        }

        public override string ToString()
        {
            return $"ID:{ID}, Shop:{Name}, Budget:{Budget}, MinSalary:{MinSalary}";
        }
    }
}
