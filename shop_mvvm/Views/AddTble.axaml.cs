using Avalonia.Controls;
using Avalonia.Interactivity;
using shop_mvvm.Models;
using shop_mvvm.ViewModels;
using System;

namespace shop_mvvm.Views
{
    public partial class AddTble : Window
    {
        MenuViewModel menuViewModel = new MenuViewModel();
        public AddTble()
        {
            InitializeComponent(); 
            
            DataContext = menuViewModel;

            
        }
        

        private void Adding(object? sender, RoutedEventArgs e)
        {
           
            Menu menu = new Menu();

            menu.Show(); 

            this.Close();
        }
    }
}
