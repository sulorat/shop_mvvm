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
        Menu menu = new Menu();

        string _name = Name.Text.ToLower();

        string _password = Password.Text.ToLower();

        if (_name =="admin"&& _password=="admin")
        {
            MenuViewModel.isAdmin = true;
            MenuViewModel.isManager = false;
            MenuViewModel.isGuest = false;
        }
        else if(_password == "manager"&&_name=="manager")
        {
            MenuViewModel.isManager = true;
            MenuViewModel.isAdmin = false;
            MenuViewModel.isGuest = false;
        }
        else
        {
            MenuViewModel.isGuest = true;
            MenuViewModel.isAdmin = false;
            MenuViewModel.isManager = false;
        }
        menu.Show();

        this.Close();
    }



}