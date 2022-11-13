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
    public partial class Path : Page
    {
        public Path()
        {
            InitializeComponent();
        }

        private void Value_Preset1_Click(object sender, RoutedEventArgs e)
        {
            TargetStack.DataContext = new List<object>() { "First value", "Second value", "Third value" };
        }

        private void Value_Preset2_Click(object sender, RoutedEventArgs e)
        {
            TargetStack.DataContext = new List<object>() { "Index: 0", "Index: 1", "Index: 2" };
        }

        private void Value_Preset3_Click(object sender, RoutedEventArgs e)
        {
            TargetStack.DataContext = new List<object>() { "Like", "it,", "please!" };
        }
    }
}
