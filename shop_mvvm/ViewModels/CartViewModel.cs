using shop_mvvm.Models;
using System.Collections.ObjectModel;

namespace shop_mvvm.ViewModels
{


    internal class CartViewModel : MenuViewModel
    {
        private ObservableCollection<Product> _cartList = new();
        
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

        public CartViewModel(ObservableCollection<Product> selected)
        {
            _cartList = selected;
        }

      
    }
    


   
}
