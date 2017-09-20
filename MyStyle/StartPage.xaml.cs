using ActiproSoftware.Windows.Controls.Docking;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using MyStyle.Command;
using MyStyle.Control;
using MyStyle.Windows;

namespace MyStyle
{
    /// <summary>
    /// StartPage.xaml 的互動邏輯
    /// </summary>
    public partial class StartPage : Window
    {
        public ObservableCollection<PageStyle> PageStyleList = new ObservableCollection<PageStyle>();
        private static PageStyle SelectedPageStyle = null;
        public StartPage()
        {
            InitializeComponent();
            MyDockSiteManager.GetInstance().StyleEnum = StyleEnum.Dark01;
            MyStyle.Command.MyStyleManager.GetInstance();
            this.Title = this.Title + "  V-" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            MyDockSiteManager.GetInstance().CreateDockSite("Demo");
            var temp = Application.Current.Resources;

            PageStyleList.Add(new PageStyle("Normal", "预设"));
            PageStyleList.Add(new PageStyle("Dark01", "深色01"));
            PageStyleList.Add(new PageStyle("Light01", "浅色01"));
            PageStyleList.Add(new PageStyle("Aero.NormalColor", "Aero.NormalColor"));
            PageStyleList.Add(new PageStyle("Aero2.NormalColor", "Aero2.NormalColor"));
            PageStyleList.Add(new PageStyle("AeroLite.NormalColor", "AeroLite.NormalColor"));
            PageStyleList.Add(new PageStyle("Classic", "Classic"));
            PageStyleList.Add(new PageStyle("Generic", "Generic"));
            PageStyleList.Add(new PageStyle("Luna.Homestead", "Luna.Homestead"));
            PageStyleList.Add(new PageStyle("Luna.Metallic", "Luna.Metallic"));
            PageStyleList.Add(new PageStyle("Luna.NormalColor", "Luna.NormalColor"));
            PageStyleList.Add(new PageStyle("Royale.NormalColor", "Royale.NormalColor"));
            cbStyleName.DisplayMemberPath = "Value";
            cbStyleName.SelectedValuePath = "Key";
            cbStyleName.ItemsSource = PageStyleList;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PageStyle selobj = (PageStyle)cbStyleName.SelectedItem;
                string stylekey = selobj.Key;
                DemoPage win = new DemoPage(stylekey);
                win.Show();
            }
            catch (Exception ex)
            {
            }

        }
        


        //    private void btn_DockTest_Click(object sender, RoutedEventArgs e)
        //    {
        //        NewDock();
        //    }

        private void btn_DockTest_Click(object sender, RoutedEventArgs e)
        {
            PageStyle selobj = (PageStyle)cbStyleName.SelectedItem;
            string stylekey = selobj.Key;
            MyUserControl frm = new MyUserControl(stylekey);
            string title = "DockDemo";
            OpenonDock(frm, title);
        }

        private void OpenonDock(UserControl frm, string title)
        {
            try
            {
                frm.Width = Double.NaN;
                frm.Height = Double.NaN;
                frm.VerticalAlignment = System.Windows.VerticalAlignment.Stretch;
                frm.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
                frm.Tag = Guid.NewGuid().ToString();
            }
            catch (Exception ex)
            {
            }
            NewDock(frm, title);
        }

        public void NewDock(UserControl frm, string title)
        {
            try
            {
                ToolWindow toolwindows = new ToolWindow(true);
                toolwindows.Title = title;
                toolwindows.Content = frm;
                toolwindows.Style = (Style)frm.Resources["ToolWindow"];
                MyDockSiteManager.GetInstance().GetDockSite("Demo").ToolWindows.Add(toolwindows);
                System.Drawing.Point pt = System.Windows.Forms.Control.MousePosition;
                Point pt2 = new Point((pt.X - 32), (pt.Y + 8));
                toolwindows.Float(pt2, new Size(850, 650));
            }
            catch (Exception ex)
            {
            }
        }

        private void cbStyleName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedPageStyle = (PageStyle)cbStyleName.SelectedItem;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //MyStyle.GetInstance().SetColor();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FuturesQuotes frm = new FuturesQuotes();
            OpenonDock(frm, "期权报价");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            CommodityQuotes frm = new CommodityQuotes();
            OpenonDock(frm, "商品报价");
        }
    }


    public class PageStyle
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public PageStyle(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
