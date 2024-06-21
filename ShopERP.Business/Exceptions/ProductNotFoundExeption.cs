using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopERP.Business.Exceptions
{
    public class ProductNotFoundExeption : Exception
    {
        public ProductNotFoundExeption()
        {
        }

        public ProductNotFoundExeption(string? message) : base(message)
        {
        }
    }
}
