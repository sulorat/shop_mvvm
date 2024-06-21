using Avalonia.Controls;
using Avalonia.Interactivity;
using shop_mvvm.ViewModels;
namespace shop_mvvm.Views
{
    public partial class Cart : Window
    {
        public Cart()
        {
            InitializeComponent();

            DataContext = new MenuViewModel();
            
        }
    }
}
