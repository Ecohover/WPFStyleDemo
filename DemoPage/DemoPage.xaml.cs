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

namespace WPFDemo
{
    /// <summary>
    /// DemoPage.xaml 的互動邏輯
    /// </summary>
    public partial class DemoPage : Window
    {
        public DemoPage(string style)
        {
            UpdateStyle(style);
            InitializeComponent();
            UpdateComdoBox();
        }

        private void UpdateStyle(string style)
        {
            ResourceDictionary mystyles;
            try
            {
                if (!style.Equals("Normal"))
                {
                    mystyles = new ResourceDictionary();
                    mystyles.Source = new Uri($"/WPFDemo;component/Resource/{style}.xaml", UriKind.RelativeOrAbsolute);
                    this.Resources = mystyles;
                    this.Style = mystyles[style] as Style;
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void UpdateComdoBox()
        {

            ObservableCollection<TestList> cmbList = new ObservableCollection<TestList>();


            cmbList.Add(new TestList("0", "C004-下拉式选单"));
            cmbList.Add(new TestList("1", "1"));
            cmbList.Add(new TestList("2", "2"));
            cmbList.Add(new TestList("3", "3"));
            cmbList.Add(new TestList("4", "4"));
            cmbList.Add(new TestList("5", "5"));
            cmbList.Add(new TestList("6", "6"));
            cmbList.Add(new TestList("7", "7"));
            cmbList.Add(new TestList("8", "8"));
            cmbList.Add(new TestList("9", "9"));
            cmbList.Add(new TestList("10", "10"));
            cmbList.Add(new TestList("11", "1"));
            cmbList.Add(new TestList("12", "2"));
            cmbList.Add(new TestList("13", "3"));
            cmbList.Add(new TestList("14", "4"));
            cmbList.Add(new TestList("15", "5"));
            cmbList.Add(new TestList("16", "6"));
            cmbList.Add(new TestList("17", "7"));
            cmbList.Add(new TestList("18", "8"));
            cmbList.Add(new TestList("19", "9"));
            cmbList.Add(new TestList("20", "10"));


            cbStyleName.DisplayMemberPath = "Value";
            cbStyleName.SelectedValuePath = "Key";
            cbStyleName.ItemsSource = cmbList;
        }

        private void PART_TITLEBAR_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void PART_CLOSE_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void PART_MAXIMIZE_RESTORE_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == System.Windows.WindowState.Normal)
            {
                this.WindowState = System.Windows.WindowState.Maximized;
            }
            else
            {
                this.WindowState = System.Windows.WindowState.Normal;
            }
        }

        private void PART_MINIMIZE_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Height += 10;
            this.Width += 10;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
    public class TestList
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public TestList(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
