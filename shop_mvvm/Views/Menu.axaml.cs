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
        DataContext = new MenuViewModel();

    }

    private void ToAdd(object? sender, RoutedEventArgs e)
    {
        new AddTble().Show();

        this.Close();
    }

    private void ToCart(object? sender, RoutedEventArgs e)
    {
        Cart cart = new();


        cart.Show();

        this.Close();

       
    }

    
   
    
}