using ShopERP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopERP.Data.DAL
{
    public class ShopDataBase<T>
    {
        public static List<T> ShopData = new List<T>() ;
    }
}
