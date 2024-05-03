using shop_mvvm.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace shop_mvvm.ViewModels 
{
    internal class MenuViewModel : ViewModelBase
    {
        private bool _isAdmin;
        private ObservableCollection<Product> _ProductsList;


        public ObservableCollection<Product> ProductsList
        {
            get => _ProductsList;
            set => this.RaiseAndSetIfChanged(ref _ProductsList, value);
        }

       
        
        public bool isAdmin
        {
            get => _isAdmin;
            set => this.RaiseAndSetIfChanged(ref _isAdmin, value);
        }
        
        public MenuViewModel()
        {

        }

    }
}
