using Avalonia.Controls;
using Avalonia.Interactivity;
using shop_mvvm.Models;
using shop_mvvm.ViewModels;
using System;

namespace shop_mvvm.Views
{
    public partial class AddTble : Window
    {
        
        public AddTble()
        {
            MenuViewModel menuViewModel = new MenuViewModel();

            AddTableViewModel addTableViewModel = new AddTableViewModel();

            InitializeComponent(); 
            
            DataContext = addTableViewModel;
          
        }
        

        private void Adding(object? sender, RoutedEventArgs e)
        {
            Menu menu = new();
            
            menu.Show();

            this.Close();
        }
    }
}
