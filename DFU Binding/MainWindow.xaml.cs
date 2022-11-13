using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace DFU_Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _index = 0;
        private List<Page> _pages = new List<Page>()
        {
            new Pages.ElementName(),
            new Pages.FallbackValue(),
            new Pages.TargetNullValue(),
            new Pages.Path(),
            new Pages.Source(),
            new Pages.StringFormat(),
            new Pages.Mode(),
            new Pages.UpdateSourceTrigger(),
            new Pages.Delay(),
            new Pages.IsAsync(),
            new Pages.DataContext(),
            new Pages.Converter()
        };

        public MainWindow()
        {
            InitializeComponent();
            PageViewer.Content = _pages[_index];
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            _index++;
            _index = _index >= _pages.Count ? 0 : _index;
            PageViewer.Content = _pages[_index];
        }

        private void Prev_Click(object sender, RoutedEventArgs e)
        {
            _index--;
            _index = _index < 0 ? _pages.Count - 1 : _index;
            PageViewer.Content = _pages[_index];
        }
    }

}
