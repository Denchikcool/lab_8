using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using diagram_8_lab.Models.Serializers;
using diagram_8_lab.ViewModels;
using diagram_8_lab.Views;

namespace diagram_8_lab
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
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel()
                    {
                        SaverLoaderFactoryCollection = new ISaverLoaderFactory[]
                        {
                            new XMLSaverLoaderFactory(),
                            new JSONSaverLoaderFactory(),
                            new YAMLSaverLoaderFactory(),
                        }
                    }

                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
