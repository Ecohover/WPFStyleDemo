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
    /// CommodityQuotesLivePanel.xaml 的互動邏輯
    /// </summary>
    public partial class CommodityQuotesLivePanel : MyControl
    {
        DisplayModels DisplayModels = new DisplayModels();
        public CommodityQuotesLivePanel()
        {
            InitializeComponent();
            LeftDataGrid.ItemsSource = DisplayModels.LeftList;
            RightDataGrid.ItemsSource = DisplayModels.RightList;
        }
        
    }

    public class DisplayModels
    {
        public List<DisplayModel> LeftList = new List<DisplayModel>();
        public List<DisplayModel> RightList = new List<DisplayModel>();

        public DisplayModels()
        {
            LeftList.Add(new DisplayModel("NewPrice", "最新", "1234"));
            LeftList.Add(new DisplayModel("NowHand", "现手", "10"));
            LeftList.Add(new DisplayModel("AllHand", "总手", "20"));
            LeftList.Add(new DisplayModel("Storage", "持仓", "104"));
            LeftList.Add(new DisplayModel("DailyChange", "日增", "1.11"));


            LeftList.Add(new DisplayModel("Outside", "外盘", "1234"));
            LeftList.Add(new DisplayModel("OutsideProportion", "比例", "50%"));
            LeftList.Add(new DisplayModel("Inside", "内盘", "1234"));
            LeftList.Add(new DisplayModel("InsideProportion", "比例", "50%"));
            LeftList.Add(new DisplayModel("Lever", "杠杆", "1.11"));


            RightList.Add(new DisplayModel("NewPrice", "涨跌", "10%"));
            RightList.Add(new DisplayModel("NowHand", "连跌", "5%"));
            RightList.Add(new DisplayModel("AllHand", "开盘", "25"));
            RightList.Add(new DisplayModel("Storage", "最高", "26"));
            RightList.Add(new DisplayModel("DailyChange", "最低", "24"));


            RightList.Add(new DisplayModel("Outside", "结算价", "10000"));
            RightList.Add(new DisplayModel("OutsideProportion", "昨收", "24.5"));
            RightList.Add(new DisplayModel("Inside", "昨结", "100"));
            RightList.Add(new DisplayModel("InsideProportion", "涨停", "28"));
            RightList.Add(new DisplayModel("Lever", "跌停", "22"));

        }

    }

    public class DisplayModel
    {
        public string Key { set; get; }
        public string Name { set; get; }
        public string Value { set; get; }

        public DisplayModel(string key, string name , string value)
        {
            Key = key;
            Name = name;
            Value = value;
        }
    }



}
