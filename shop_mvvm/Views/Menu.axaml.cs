using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using shop_mvvm.ViewModels;

namespace shop_mvvm;

public partial class Menu : Window
{
    public Menu()
    {
        InitializeComponent();
        DataContext = new MenuViewModel();

    }

    


}