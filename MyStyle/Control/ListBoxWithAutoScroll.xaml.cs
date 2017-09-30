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
    /// ListBoxWithAutoScroll.xaml 的互動邏輯
    /// </summary>
    public partial class ListBoxWithAutoScroll : ListBox
    {

        public ListBoxWithAutoScroll()
        {
            //SetResourceReference(System.Windows.Controls.Control.StyleProperty, typeof(ListBox));
            InitializeComponent();
            SetStyle();
        }
        private void SetStyle()
        {
            try
            {
                this.Style = this.Resources["ListBoxWithAutoScroll"] as Style;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
