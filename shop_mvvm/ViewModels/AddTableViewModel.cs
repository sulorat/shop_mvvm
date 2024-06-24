using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia;
using shop_mvvm.Models;
using shop_mvvm.ViewModels;

namespace shop_mvvm.ViewModels 
{


    internal class AddTableViewModel : MenuViewModel
    {
        private string _name;
        private string _description;
        private double _price;
        private int _count;
        private int _productId;
        private bool _available_in_stock;


        public int ProductId
        {
            get => _productId;
            set => _productId = MenuViewModel.ProductsList.Count + 1;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public double Price
        {
            get => _price;
            set
            {
                _price = Math.Round(value, 2);
            }
        }

        public int Count
        {
            get => _count;
            set => _count = value; 
        }

        public bool Available_in_stock()
        {
            if(Count>0)
                return true;
            else    
                return false;
        }

        public void AddProduct()
        
        
        
        {

            ProductsList.Add(new Product(ProductId, Name, Description, Price, Count));
        }

    }
}
