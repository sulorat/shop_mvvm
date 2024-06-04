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
        public void test()
        {
            
        }
        private void Adding(object? sender, RoutedEventArgs e)
        {
            menuViewModel.ProductsList.Add(new Product (1,Name.Text,Descrription.Text,Convert.ToSingle(Price.Text),Convert.ToInt32(Count.Text)));
            Console.WriteLine(menuViewModel.ProductsList.Count);
            Menu menu = new Menu();

            menu.Show(); 

            this.Close();
        }
    }
}
