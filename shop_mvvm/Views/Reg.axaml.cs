using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using shop_mvvm.ViewModels;
using System.Threading;

namespace shop_mvvm;

public partial class Window1 : Window
{
    public Window1()
    {
        InitializeComponent();
    }

    private void ToMainWindowReg(object? sender, RoutedEventArgs e)
    {
        MenuViewModel menuModel = new MenuViewModel();
        Menu menu = new Menu();

        string _name = Name.Text.ToLower();

        string _password = Password.Text.ToLower();

        if (_name =="admin"&& _password=="admin")
        {
            menuModel.isAdmin = true;
        }
        menu.Show();

        this.Close();
    }



}