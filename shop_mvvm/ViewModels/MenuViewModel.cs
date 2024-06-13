using shop_mvvm.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using DynamicData;
using Avalonia.Controls;
using DynamicData.Binding;

namespace shop_mvvm.ViewModels 
{
    internal class MenuViewModel : ViewModelBase
    {
        private ObservableCollection<Product> _searchResults;
        private string _searchText;
        private static ObservableCollection<Product> _selectedProducts;
        private bool _isAdmin;
        private static ObservableCollection<Product> _ProductsList = new();

       

        public static ObservableCollection<Product> ProductsList
        {
            get => _ProductsList;
            set => _ProductsList = value;
        }

        public static ObservableCollection<Product> SelectedProducts
        {
            get => _selectedProducts;
            set => _selectedProducts = value;
        }

        public bool isAdmin
        {
            get => _isAdmin;
            set => this.RaiseAndSetIfChanged(ref _isAdmin, value);
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
                var filteredItems = ProductsList.Where(i => i.ProductName.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                                     i.ProductDescription.Contains(searchText, StringComparison.OrdinalIgnoreCase));
                SearchResults = new ObservableCollection<Product>(filteredItems);
            }
        }


        public MenuViewModel()
        {
            
        SearchResults = _ProductsList;
        }

    }
}
