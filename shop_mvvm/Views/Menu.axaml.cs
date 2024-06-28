using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using shop_mvvm.ViewModels;
using shop_mvvm.Models;
using shop_mvvm.Views;
using Avalonia.Interactivity;


namespace shop_mvvm;

public partial class Menu : Window
{
   
    public Menu()
    {
         InitializeComponent();
        if (MenuViewModel.isGuest == true)
        {
            AddBut.IsVisible = false;
            DeleteBut.IsVisible = false;
        }
        if (MenuViewModel.isManager == true)
        {
            ToCartBut.IsVisible = false;
            AddBut.IsVisible = false;
            DeleteBut.IsVisible = false;
        }
       
        DataContext = new MenuViewModel();

    }

    private void ToAdd(object? sender, RoutedEventArgs e)
    {
        new AddTble().Show();

        this.Close();
    }
    
    private void ToReg(object? sender, RoutedEventArgs e)
    {
        new Window1().Show();

        this.Close();
    }
    

    private void ToCart(object? sender, RoutedEventArgs e)
    {
        Window cart = new Cart(ProductsList.SelectedItem);
        
        cart.Show();

        this.Close();

       
    }

    
   
    
}