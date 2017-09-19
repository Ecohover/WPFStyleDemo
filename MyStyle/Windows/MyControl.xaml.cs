using log4net;
using MyStyle.Command;
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

namespace MyStyle.Windows
{
    /// <summary>
    /// DefultUserControl.xaml 的互動邏輯
    /// </summary>
    public class MyControl : UserControl
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(MyControl));
        public string StyleName { get; set; }
        public string UserControlStyleName { get; set; }


        public MyControl()
        {
            StyleName = MyDockSiteManager.GetInstance().StyleEnum.ToString();
            UpdateStyle(StyleName);
        }


        private void UpdateStyle(string style)
        {
            ResourceDictionary mystyles;
            Logger.Debug(" UpdateStyle style = " + style);
            try
            {
                if (!style.Equals("Normal"))
                {
                    mystyles = new ResourceDictionary();
                    mystyles.Source = new Uri($"/MyStyle;component/Resource/{style}.xaml", UriKind.RelativeOrAbsolute);
                    this.Resources = mystyles;
                    UserControlStyleName = "UserControl";
                    this.Style = mystyles[UserControlStyleName] as Style;
                }
                StyleName = style;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message.ToString());
            }
        }

    }
}
