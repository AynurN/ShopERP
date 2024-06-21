using ShopERP.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopERP.Core.Models
{
    public class Product : ShopBase
    {
        private double _purchase;
        private double _sale;
        private static int id;
        public ProductType ProductType { get; set; }
        public int Count { get; set; }
        public double PurchasePrice { get { return _purchase; }
            set { if(PurchasePrice<=SalePrice)_purchase = value; }
        }
        public double SalePrice { get { return _sale; }
            set
            {
                if(_sale>=PurchasePrice) _sale = value;
            }
                }
        public Shop? Shop { get; set; }
        public Product(string name, ProductType product, int count, double purPrice, double salePrice) {
            Name= name;
            ProductType= product;
            PurchasePrice= purPrice;
            SalePrice= salePrice;
            ++id;
            ID= id;
        
        }

        public override string ToString()
        {
            return $"ID:{ID}, Product:{Name}, Type:{ProductType}, Count:{Count}, PurchasePrice:{PurchasePrice}, SalePrice:{SalePrice}, Shop:{Shop?.Name}";
        }
    }
}
