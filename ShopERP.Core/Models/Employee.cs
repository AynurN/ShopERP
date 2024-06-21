using ShopERP.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopERP.Core.Models
{
    public class Employee:ShopBase
    {
        private  double _salary;
        private static int id;
        public string Surname { get; set; }
        public double Salary {
        get 
            { return _salary; }
            set {
                if (_salary >= Shop?.MinSalary)
                    _salary = value;
            }
        
        }
        public RoleType RoleType{ get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Shop? Shop{ get; set; }
        public Employee(string name, string surname, double salary, RoleType role, string username, string pass)
        {
            ++id;
            ID = id;
            Name = name;
            Salary = salary;
            RoleType = role;
            Username = username;
            Password = pass;
            Surname = surname;

        }
        public override string ToString()
        {
            return $"ID:{ID}, Name:{Name}, Surname:{Surname}, Role:{RoleType}, Username:{Username}, Password:{Password}, Shop:{Shop?.Name}";
        }
    }
}
