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
        Menu menu = new Menu()
        {
            DataContext = ViewModels.RegViewMod
        };

        reg.Show();

        this.Close();
    }



}