using shop_mvvm.Models;
using System.Collections.ObjectModel;

namespace shop_mvvm.ViewModels
{


    internal class CartViewModel : MenuViewModel
    {
        private ObservableCollection<Product> _cartList = new();
        private string _productName;
        private double _productPrice;
        private double _productCount;
        public ObservableCollection<Product> CartList
        {
            
            get => _cartList;
            set
            {
                for (int i = 0; i < SelectedProducts.Count; i++)
                {
                    foreach (var selectedProd in SelectedProducts.ToList())
                    {
                        _cartList.Add(selectedProd);
                    }
                }
            }

        }

        public string _ProductName
        {
            get => _productName;
            set => _productName = value;
        }
        
        public double _ProductPrice
        {
            get => _productPrice;
            set => _productPrice = value;
        }
        
        public double _ProductCount
        {
            get => _productCount;
            set => _productCount = value;
        }

        public CartViewModel(object selected)
        {
            Product _product = (Product)selected;
            _productName = _product.ProductName;
            _productPrice = _product.ProductPrice;
            _productCount = _product.ProductCount;
            _cartList.Add(_product);
        }

      
    }
    


   
}
