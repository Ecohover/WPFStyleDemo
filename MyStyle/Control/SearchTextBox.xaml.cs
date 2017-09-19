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

namespace MyStyle.Control
{
    /// <summary>
    /// SearchTextBox.xaml 的互動邏輯
    /// </summary>
    public partial class SearchTextBox : TextBox
    {
        public static readonly DependencyProperty StyleNameProperty =
            DependencyProperty.Register("StyleName", typeof(string), typeof(SearchTextBox), new FrameworkPropertyMetadata { PropertyChangedCallback = Callback });

        public bool UseGloablStyle { get; set; }

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
            SearchTextBox obj = (SearchTextBox)dependencyObject;
            obj.SetStyle((string)args.NewValue);
        }

        private void SetStyle(string style)
        {
            ResourceDictionary mystyles;
            try
            {
                if (UseGloablStyle)
                {
                    if (!style.Equals("Normal") && !style.Equals(""))
                    {
                        mystyles = new ResourceDictionary();
                        mystyles.Source = new Uri($"/MyStyle;component/Resource/{style}.xaml", UriKind.RelativeOrAbsolute);
                        this.Resources = mystyles;
                        this.Style = mystyles["SearchTextBox"] as Style;
                    }
                }
                else
                {
                    this.Style = this.Resources["TextBox"] as Style;
                }

            }
            catch (Exception ex)
            {

            }
        }

     
        public SearchTextBox()
        {
            UseGloablStyle = false;
            Initial();
        }

        public void Initial()
        {
            InitializeComponent();
            SetStyle(StyleName);
            ResetText();
        }

        public void ResetText()
        {
            //Text = LanguageAide.LanguageSupport.GetString("String_flash_filterinfo");
            Text = "输入商品代码/名称";
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            Text = string.Empty;
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            ResetText();
        }
    }
}
