using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyStyle.Windows
{
    /// <summary>
    /// CommodityQuotes.xaml 的互動邏輯
    /// </summary>
    public partial class CommodityQuotes : MyControl
    {
        public CommodityQuotes()
        {
            InitializeComponent();
        }

        private void RadioButton_HM_Checked(object sender, RoutedEventArgs e)
        {
            Image_HM.Visibility = Visibility.Visible;
            Image_K.Visibility = Visibility.Collapsed;
        }

        private void RadioButton_K_Checked(object sender, RoutedEventArgs e)
        {
            Image_HM.Visibility = Visibility.Collapsed;
            Image_K.Visibility = Visibility.Visible;
        }
    }
}
