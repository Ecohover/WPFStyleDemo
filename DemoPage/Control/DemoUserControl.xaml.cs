using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPFDemo.Control
{
    /// <summary>
    /// DemoUserControl.xaml 的互動邏輯
    /// </summary>
    public partial class DemoUserControl : UserControl
    {
        public string StyleName { get; set; }

        public DemoUserControl(string style)
        {
            UpdateStyle(style);
            InitializeComponent();
        }
        

        private void UpdateStyle(string style)
        {
            ResourceDictionary mystyles;
            try
            {
                if (!style.Equals("Normal"))
                {
                    mystyles = new ResourceDictionary();
                    mystyles.Source = new Uri($"/WPFDemo;component/Resource/{style}.xaml", UriKind.RelativeOrAbsolute);
                    this.Resources = mystyles;
                    this.Style = mystyles[style] as Style;
                }
                StyleName = style;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
