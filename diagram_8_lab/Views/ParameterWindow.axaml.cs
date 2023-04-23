using Avalonia.Controls;
using diagram_8_lab.ViewModels;

namespace diagram_8_lab.Views
{
    public partial class ParameterWindow : Window
    {
        public ParameterWindow()
        {
            InitializeComponent();
            DataContext = new ParameterWindowViewModel();
        }
    }
}
