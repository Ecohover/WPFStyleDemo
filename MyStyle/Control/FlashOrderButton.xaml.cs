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

namespace MyStyle.Control
{
    /// <summary>
    /// FlashOrderButton.xaml 的互動邏輯
    /// </summary>
    public partial class FlashOrderButton : Button
    {

        private static void Callback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            FlashOrderButton obj = (FlashOrderButton)dependencyObject;
            obj.SetStyle();
        }

        private void SetStyle()
        {
            ResourceDictionary mystyles;
            try
            {
                this.Style = this.Resources["FlashOrderButton"] as Style;
            }
            catch (Exception ex)
            {

            }
        }
        public FlashOrderButton()
        {
            SetResourceReference(System.Windows.Controls.Control.StyleProperty, typeof(Button));
            InitializeComponent();
            SetStyle();
            this.Content = "闪电下单";
        }
    }
}
