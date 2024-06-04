using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_mvvm.Models
{
    public class Product
    {
        //public string productsImagePath {  get; set; }
        public int ProductId { get; set; } 
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public float ProductPrice { get; set; }
        public int ProductCount { get; set; }
        //public string ProductManufacturer { get; set; }


        public Product(int productId, string productName, string productDescription, float productPrice, int productCount)
        {
            ProductId = productId;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductPrice = productPrice;
            ProductCount = productCount;
        }
    }

    
}
