using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicData.Binding;
using shop_mvvm.Models;
using System.Collections.ObjectModel;
using System.Collections.Generic; 

namespace shop_mvvm.ViewModels
{


    internal class CartViewModel
    {
        private ObservableCollection<Product> _cartList;

        public ObservableCollection<Product> CartList
        {
            get => _cartList;
            set => _cartList = MenuViewModel.SelectedProducts;

        }
    }
    


   
}
