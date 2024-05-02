using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using shop_mvvm.ViewModels;

namespace shop_mvvm
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new Window1
                {
                    DataContext = new RegViewModel(),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}