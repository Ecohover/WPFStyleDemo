using System;
using System.Windows;
using System.Windows.Controls;

namespace MyStyle.Control
{
    /// <summary>
    /// OldTabControl.xaml 的互動邏輯
    /// </summary>
    public partial class OldTabControl : TabControl
    {
        public static readonly DependencyProperty StyleNameProperty =
               DependencyProperty.Register("StyleName", typeof(string), typeof(OldTabControl), new FrameworkPropertyMetadata { PropertyChangedCallback = Callback });

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
            OldTabControl obj = (OldTabControl)dependencyObject;
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
                    mystyles.Source = new Uri($"/MyStyle;component/Resource/{style}.xaml", UriKind.RelativeOrAbsolute);
                    this.Resources = mystyles;
                    this.Style = mystyles["OldTabControl"] as Style;
                }
            }
            catch (Exception ex)
            {

            }
        }
        public OldTabControl()
        {
            SetResourceReference(System.Windows.Controls.Control.StyleProperty, typeof(TabControl));
            InitializeComponent();
            SetStyle(StyleName);
        }
    }
}
