using ActiproSoftware.Windows.Controls.Docking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using WPFDemo.Control;

namespace WPFDemo
{
    /// <summary>
    /// StartPage.xaml 的互動邏輯
    /// </summary>
    public partial class StartPage : Window
    {
        public ObservableCollection<PageStyle> PageStyleList = new ObservableCollection<PageStyle>();

        public StartPage()
        {
            InitializeComponent();

            this.Title = this.Title + "  V-" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            var temp = Application.Current.Resources;

            PageStyleList.Add(new PageStyle("Normal", "预设"));
            PageStyleList.Add(new PageStyle("Dark01", "深色01"));
            PageStyleList.Add(new PageStyle("Light01", "浅色01"));
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
               // win.Show();
            }
            catch (Exception ex)
            {
            }

        }

        private void cbStyleName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        //    private void btn_DockTest_Click(object sender, RoutedEventArgs e)
        //    {
        //        NewDock();
        //    }
        //    public void NewDock()
        //    {
        //        DemoUserControl frm = null;
        //        try
        //        {
        //            PageStyle selobj = (PageStyle)cbStyleName.SelectedItem;
        //            string stylekey = selobj.Key;
        //            //frm.Width = Double.NaN;
        //            //frm.Height = Double.NaN;
        //            //frm.VerticalAlignment = System.Windows.VerticalAlignment.Stretch;
        //            //frm.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
        //            //frm.Tag = Guid.NewGuid().ToString();
        //            //frm = new DemoUserControl(stylekey);
        //        }
        //        catch (Exception ex)
        //        {
        //        }
        //        //DockingWindow toolwindows = new DockingWindow(true);
        //        //toolwindows.Title = "DemoDock";
        //        //toolwindows.Content = frm;
        //        //System.Drawing.Point pt = System.Windows.Forms.Control.MousePosition;
        //        //Point pt2 = new Point((pt.X - 32), (pt.Y + 8));
        //        //toolwindows.Float(pt2, new Size(800, 600));
        //    }
        private void btn_DockTest_Click(object sender, RoutedEventArgs e)
        {

          // DemoUserControl frm = null;
            try
            {
                //PageStyle selobj = (PageStyle)cbStyleName.SelectedItem;
                //string stylekey = selobj.Key;
                //frm.Width = Double.NaN;
                //frm.Height = Double.NaN;
                //frm.VerticalAlignment = System.Windows.VerticalAlignment.Stretch;
                //frm.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
                //frm.Tag = Guid.NewGuid().ToString();
                //frm = new DemoUserControl(stylekey);
            }
            catch (Exception ex)
            {
            }
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
