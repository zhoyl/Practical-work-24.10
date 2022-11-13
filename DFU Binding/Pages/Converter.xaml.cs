using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for ElementName.xaml
    /// </summary>
    public partial class Converter : Page
    {
        public Converter()
        {
            InitializeComponent();
        }

    }


    class Base64Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                return Base64Encode((string)value);
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                if (value is string)
                {
                    return Base64Decode((string)value);
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return value;
        }

        public static string Base64Encode(string text)
        {
            return System.Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
        }

        public static string Base64Decode(string text)
        {
            return Encoding.UTF8.GetString(System.Convert.FromBase64String(text));
        }
    }
}
