using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia;
using shop_mvvm.Models;
using shop_mvvm.ViewModels;

namespace shop_mvvm.ViewModels
{
    
    
    internal class AddTableViewModel
    {

        MenuViewModel menu = new MenuViewModel();
        private string _name;
        private string _description;
        private float _price;
        private int _count;
        private int _productId;


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

        public float Price
        {
            get => _price;
            set => _price = value;  
        }

        public int Count
        {
            get => _count;
            set => _count = value;
        }

        public void AddProduct()
        {

            MenuViewModel.ProductsList.Add(new Product(ProductId, Name, Description, Price, Count));
        }

    }
}
