using shop_mvvm.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using DynamicData;

namespace shop_mvvm.ViewModels 
{
    internal class MenuViewModel : ViewModelBase
    {
        private bool _isAdmin;
        private ObservableCollection<Product> _ProductsList;

        public ObservableCollection<Product> ProductsList { get; } = new ObservableCollection<Product>()
        {
            //new Product() { ProductName = "Item 1" },
            //new Product() { ProductName = "Item 2" },
            //new Product() { ProductName = "Item 3" },
        };

        

        public bool isAdmin
        {
            get => _isAdmin;
            set => this.RaiseAndSetIfChanged(ref _isAdmin, value);
        }

        public MenuViewModel()
        {
            ProductsList.Add(new Product (1, "1232131", "dada", 3, 3000 ));
        }

    }
}
