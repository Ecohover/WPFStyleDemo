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

namespace WPFDemo.Control
{
    /// <summary>
    /// DataGridCheckBox.xaml 的互動邏輯
    /// </summary>
    public partial class DataGridCheckBox : UserControl
    {
        public static readonly DependencyProperty StyleNameProperty =
            DependencyProperty.Register("StyleName", typeof(string), typeof(SearchTextBox), new FrameworkPropertyMetadata { PropertyChangedCallback = Callback });

        public string StyleName
        {
            get { return (string)base.GetValue(StyleNameProperty); }
            set
            {
                base.SetValue(StyleNameProperty, value);
                SetStyle(value);
            }
        }
        private static void Callback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            DataGridCheckBox obj = (DataGridCheckBox)dependencyObject;
            obj.SetStyle((string)args.NewValue);
        }

        private void SetStyle(string style)
        {
            ResourceDictionary mystyles;
            try
            {
                if (!style.Equals("Normal") && !style.Equals(""))
                {
                    mystyles = new ResourceDictionary();
                    mystyles.Source = new Uri($"/WPFDemo;component/Resource/{style}.xaml", UriKind.RelativeOrAbsolute);
                    this.Resources = mystyles;
                    NewCheckBox.Style = mystyles["SearchTextBox"] as Style;
                }
            }
            catch (Exception ex)
            {

            }
        }
        public DataGridCheckBox()
        {
            InitializeComponent();
            SetStyle(StyleName);
        }
    }
}
