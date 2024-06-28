using shop_mvvm.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Controls;
using ReactiveUI;
using DynamicData;
using DynamicData.Binding;

namespace shop_mvvm.ViewModels 
{
    internal class MenuViewModel : ViewModelBase
    {
        private ObservableCollection<Product> _searchResults;
        private string _searchText;
        private static  bool _isManager;
        private static ObservableCollection<Product> _selectedProducts = new();
        private static bool _isAdmin;
        private static bool _isGuest;
        private static ObservableCollection<Product> _ProductsList = new();
        
       

        public static ObservableCollection<Product> ProductsList
        {
            get => _ProductsList;
            set => _ProductsList = value;
        }

        public  ObservableCollection<Product> SelectedProducts
        {
            get => _selectedProducts;
            set => _selectedProducts = value;
        }

        public static bool isAdmin
        {
            get => _isAdmin;
            set => _isAdmin = value;
        }

        public static bool isGuest
        {
            get => _isGuest;
            set => _isGuest = value;
        }
        public static bool isManager
        {
            get => _isManager;
            set => _isManager = value;
        }

        public ObservableCollection<Product> SearchResults
        {
            get { return _searchResults; }
            set { this.RaiseAndSetIfChanged(ref _searchResults, value); }
        }

       
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                this.RaiseAndSetIfChanged(ref _searchText, value);
                FilterItems(value);
            }
        }

        private void FilterItems(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                SearchResults = ProductsList; 
            }
            else
            {
                var filteredItems = ProductsList.Where(i => i.ProductName.Contains(searchText));
                SearchResults = new ObservableCollection<Product>(filteredItems);
            }
        }

    
        public void Deleting()
        {
            for (int i = 0; i < ProductsList.Count; i++)
            {
                foreach (var selectedProd in SelectedProducts.ToList())
                {
                    if (ProductsList[i].ProductName == selectedProd.ProductName)
                    {
                        ProductsList.RemoveAt(i);
                    }
                }
            }
        }
       
        
        public MenuViewModel()
        {
            
            SearchResults = _ProductsList;
        }

    }
}
