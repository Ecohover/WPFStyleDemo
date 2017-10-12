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

namespace MyStyle.Control
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
            MyResource.GetInstance().ResetResources();
            StyleName = MyResource.GetInstance().StyleEnum.ToString();
            UpdateStyle();
        }


        private void UpdateStyle()
        {
            Logger.Debug(" UpdateStyle style = " + StyleName);
            try
            {
                if (!StyleName.Equals("Normal"))
                {
                    this.Resources = MyResource.GetInstance().CloneMyResource((StyleEnum)Enum.Parse(typeof(StyleEnum), StyleName));
                    UserControlStyleName = "UserControl";
                    this.Style = this.Resources[UserControlStyleName] as Style;
                }
                StyleName = StyleName;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message.ToString());
            }
        }

    }
}
