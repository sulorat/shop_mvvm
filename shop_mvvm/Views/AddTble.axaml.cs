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
            menuViewModel.ProductsList.Add(new Product {ProductId=1,ProductName=Name.Text, ProductDescription= Descrription.Text, ProductPrice = Convert.ToSingle(Price.Text), ProductCount= Convert.ToInt32(Count.Text)});

            Menu menu = new Menu();

            menu.Show();

            this.Close();
        }
    }
}
