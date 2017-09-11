using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPFDemo.Control
{
    public class MyControl<T> : UserControl
        where T : UserControl
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
            SearchTextBox obj = (SearchTextBox)dependencyObject;
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
                    NewTextBox.Style = mystyles["SearchTextBox"] as Style;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
