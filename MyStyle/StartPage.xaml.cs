using ActiproSoftware.Windows.Controls.Docking;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using MyStyle.Command;
using MyStyle.Control;


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
            MyStyleResource.GetInstance().StyleEnum = StyleEnum.Dark01;
            MyStyle.Command.MyCurrentStyleManager.GetInstance();
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
                //PageStyle selobj = (PageStyle)cbStyleName.SelectedItem;
                //string stylekey = selobj.Key;
                DemoPage win = new DemoPage("Normal");
                win.Show();
            }
            catch (Exception ex)
            {
            }

        }
        

        private void btn_DockTest_Click(object sender, RoutedEventArgs e)
        {
            PageStyle selobj = (PageStyle)cbStyleName.SelectedItem;
        }

        private void OpenonDock(UserControl frm, string title, Size size)
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
            NewDock(frm, title, size);
        }

        public void NewDock(UserControl frm, string title, Size size)
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
                toolwindows.Float(pt2, size);
            }
            catch (Exception ex)
            {
            }
        }

        private void cbStyleName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedPageStyle = (PageStyle)cbStyleName.SelectedItem;
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
