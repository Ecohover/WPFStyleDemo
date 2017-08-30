using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// SearchTextBox.xaml 的互動邏輯
    /// </summary>
    public partial class SearchTextBox : UserControl
    {

        [Description("Test text displayed in the textbox"), Category("Data")]
        public string StyleName
        {
            set { SetStyle(value); }
        }
        private void SetStyle(string style)
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
            }
            catch (Exception ex)
            {

            }
        }
        public SearchTextBox()
        {
            
            InitializeComponent();
        }
    }
}
