using MyStyle.Command;
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
            DependencyProperty.Register("StyleName", typeof(string), typeof(SearchTextBox));
        public static readonly DependencyProperty MaskTextProperty =
            DependencyProperty.Register("MaskText", typeof(string), typeof(SearchTextBox), new FrameworkPropertyMetadata { PropertyChangedCallback = MaskTextCallback });

        private static void MaskTextCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            SearchTextBox obj = (SearchTextBox)d;
            if (obj.Text.Length == 0)
            {
                obj.Text = obj.MaskText;
            }
        }

        public bool UseGloablStyle { get; set; }


        public string StyleName
        {
            get { return (string)base.GetValue(StyleNameProperty); }
            set
            {
                base.SetValue(StyleNameProperty, value);
                this.SetStyle();
            }
        }

        public string MaskText
        {
            set
            {
                base.SetValue(MaskTextProperty, value);
            }
            get
            {

                return (string)base.GetValue(MaskTextProperty);
            }
        }

        

     
        public SearchTextBox()
        {
            UseGloablStyle = true;
            StyleName = MyStyle.Command.MyStyleResource.GetInstance().StyleEnum.ToString();
            Initial();
        }

        public void Initial()
        {
            InitializeComponent();
            this.SetStyle();

        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Text.Length == 0)
            {
                Text = MaskText;
            }
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Text == MaskText)
            {
                Text = string.Empty;
            }
        }
    }
}
