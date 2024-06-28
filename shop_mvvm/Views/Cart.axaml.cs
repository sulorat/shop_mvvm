using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Interactivity;
using shop_mvvm.Models;
using shop_mvvm.ViewModels;
namespace shop_mvvm.Views
{
    public partial class Cart : Window
    {
        public Cart(object selected)
        {
            InitializeComponent();
            DataContext = new CartViewModel(selected);

        }
        
        private void ToMain(object? sender, RoutedEventArgs e)
        {
            Menu menu = new();
            
            menu.Show();

            this.Close();
        }
    }
}
