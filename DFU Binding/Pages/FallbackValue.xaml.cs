using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DFU_Binding.Pages
{
    /// <summary>
    /// Interaction logic for TargetNullValue.xaml
    /// </summary>
    public partial class FallbackValue : Page
    {
        public FallbackValue()
        {
            InitializeComponent();
        }

        private void Value_MyText_Click(object sender, RoutedEventArgs e)
        {
            TargetLabel.DataContext = new List<object>() { "My text" };
        }

        private void Value_InvalidPath_Click(object sender, RoutedEventArgs e)
        {
            TargetLabel.DataContext = 123;
        }

        private void Value_Unset_Click(object sender, RoutedEventArgs e)
        {
            TargetLabel.DataContext = new List<object>() { DependencyProperty.UnsetValue };
        }
    }
}
