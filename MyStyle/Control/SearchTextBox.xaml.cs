﻿using System;
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
                    mystyles.Source = new Uri($"/MyStyle;component/Resource/{style}.xaml", UriKind.RelativeOrAbsolute);
                    this.Resources = mystyles;
                    this.Style = mystyles["SearchTextBox"] as Style;
                }
            }
            catch (Exception ex)
            {

            }
        }
        public SearchTextBox()
        {
            SetResourceReference(System.Windows.Controls.Control.StyleProperty, typeof(TextBox));
            InitializeComponent();
            SetStyle(StyleName);
            ResetText();
        }

        public void ResetText()
        {
            //Text = LanguageAide.LanguageSupport.GetString("String_flash_filterinfo");
        }
        
    }
}
