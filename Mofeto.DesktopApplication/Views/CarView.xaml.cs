
using System.Windows.Controls;

using Mofeto.DesktopApplication.ViewModels;

namespace Mofeto.DesktopApplication.Views
{
    /// <summary>
    /// Interaktionslogik für CarView.xaml
    /// </summary>
    public partial class CarView : UserControl
    {
        public CarView()
        {
            InitializeComponent();
            DataContext = new CarViewModel();
        }
    }
}
