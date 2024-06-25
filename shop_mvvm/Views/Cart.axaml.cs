using System.Collections.ObjectModel;
using Avalonia.Controls;
using shop_mvvm.Models;
using shop_mvvm.ViewModels;
namespace shop_mvvm.Views
{
    public partial class Cart : Window
    {
        public Cart(ObservableCollection<Product> selected)
        {
            InitializeComponent();
            DataContext = new CartViewModel(selected);

        }
    }
}
