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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFDemo.Control
{
    /// <summary>
    /// DemoUserControl.xaml 的互動邏輯
    /// </summary>
    public partial class DemoUserControl : UserControl
    {
        public string StyleName { get; set; }

        public DemoUserControl(string style)
        {
            UpdateStyle(style);
            InitializeComponent();
            UpdateComdoBox();
            UpdatDataGrid();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

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
                StyleName = style;
            }
            catch (Exception ex)
            {

            }
        }
        private void UpdatDataGrid()
        {
            ObservableCollection<DataGridData> list = new ObservableCollection<DataGridData>();

            list.Add(new DataGridData("A", true));
            list.Add(new DataGridData("B", true));
            list.Add(new DataGridData("C", false));
            list.Add(new DataGridData("D", true));
            list.Add(new DataGridData("E", true));
            list.Add(new DataGridData("F", true));
            list.Add(new DataGridData("G", false));
            list.Add(new DataGridData("H", false));
            list.Add(new DataGridData("I", true));
            list.Add(new DataGridData("J", true));
            list.Add(new DataGridData("K", false));

            gridtest.ItemsSource = list;
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
            cbStyleName2.ItemsSource = cmbList;
            cbStyleName3.ItemsSource = cmbList;
            cbStyleName4.ItemsSource = cmbList;
        }
    }
}
