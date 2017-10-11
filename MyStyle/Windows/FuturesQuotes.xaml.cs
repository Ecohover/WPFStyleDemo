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
using MyStyle.Control;

namespace MyStyle.Windows
{
    /// <summary>
    /// FuturesQuotes.xaml 的互動邏輯
    /// </summary>
    public partial class FuturesQuotes : MyControl
    {
        public FuturesQuotes()
            :base()
        {
            InitializeComponent();
            UpdateComboBox();
        }

        private void UpdateComboBox()
        {
            UpdateBroker();
            UpdateCommodity();
            UpdateMonth();
        }
        private void UpdateBroker()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("000", "---选择交易所---");
            dic.Add("001", "上海证券交易所");
            dic.Add("002", "中国金融期货交易所");
            dic.Add("003", "上海期货交易所");
            dic.Add("004", "大连商品交易所");
            dic.Add("005", "郑州交易所");
            cbBroker.ItemsSource = dic;
            cbBroker.DisplayMemberPath = "Value";
            cbBroker.SelectedIndex = 0;

        }
        private void UpdateCommodity()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("000", "---选择商品---");
            dic.Add("001", "510050");
            dic.Add("002", "510051");
            dic.Add("003", "510052");
            dic.Add("004", "510053");
            dic.Add("005", "510054");
            dic.Add("006", "510055");
            dic.Add("007", "510056");
            dic.Add("008", "510057");
            dic.Add("009", "510058");
            dic.Add("010", "510059");
            cbCommodity.ItemsSource = dic;
            cbCommodity.DisplayMemberPath = "Value";
            cbCommodity.SelectedIndex = 0;
        }
        private void UpdateMonth()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("000", "---选择月份---");
            dic.Add("001", "1月");
            dic.Add("002", "2月");
            dic.Add("003", "4月");
            dic.Add("004", "6月");
            dic.Add("005", "9月");
            dic.Add("006", "12月");
            cbMonth.ItemsSource = dic;
            cbMonth.DisplayMemberPath = "Value";
            cbMonth.SelectedIndex = 0;

        }
    }
}
