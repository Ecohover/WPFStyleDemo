using MyStyle.Feature;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// OptionViewDataGrid.xaml 的互動邏輯
    /// </summary>
    public partial class OptionViewDataGrid : MyControl
    {
        public Option option;
        public static object lockobj = new object();
        public Guid ID;
        public OptionViewDataGrid()
        {
            ID = Guid.NewGuid();
            SetResourceReference(System.Windows.Controls.Control.StyleProperty, typeof(MyControl));
            InitializeComponent();
            SetStyle();
            SetOption();


            ScrollViewer scroll = (ScrollViewer)LeftCallDataGrid.Template.FindName("DG_ScrollViewer1", LeftCallDataGrid);
            if (scroll != null) ScrollSynchronizer.AddToVerticalScrollGroup(ID.ToString(), scroll);
            scroll = (ScrollViewer)CenterHeadDataGrid.Template.FindName("DG_ScrollViewer", CenterHeadDataGrid);
            if (scroll != null) ScrollSynchronizer.AddToVerticalScrollGroup(ID.ToString(), scroll);
            scroll = (ScrollViewer)RightPutDataGrid.Template.FindName("DG_ScrollViewer", RightPutDataGrid);
            if (scroll != null) ScrollSynchronizer.AddToVerticalScrollGroup(ID.ToString(), scroll);
        }
        ~OptionViewDataGrid()
        {
            ScrollViewer scroll = (ScrollViewer)LeftCallDataGrid.Template.FindName("DG_ScrollViewer", LeftCallDataGrid);
            if (scroll != null) ScrollSynchronizer.RemoveFromVerticalScrollGroup(ID.ToString(), scroll);
            scroll = (ScrollViewer)CenterHeadDataGrid.Template.FindName("DG_ScrollViewer", CenterHeadDataGrid);
            if (scroll != null) ScrollSynchronizer.RemoveFromVerticalScrollGroup(ID.ToString(), scroll);
            scroll = (ScrollViewer)RightPutDataGrid.Template.FindName("DG_ScrollViewer", RightPutDataGrid);
            if (scroll != null) ScrollSynchronizer.RemoveFromVerticalScrollGroup(ID.ToString(), scroll);
        }
        private void SetStyle()
        {
            try
            {
                //LeftCallDataGrid.Style = grid.Resources["LeftDataGrid"] as Style;
                //LeftCallDataGrid.RowStyle = grid.Resources["LeftDataGridRow"] as Style;
                //CenterHeadDataGrid.Style = grid.Resources["CenterDataGrid"] as Style;
                //CenterHeadDataGrid.RowStyle = grid.Resources["CenterDataGridRow"] as Style;
                //RightPutDataGrid.Style = grid.Resources["RightDataGrid"] as Style;
                //RightPutDataGrid.RowStyle = grid.Resources["RightDataGridRow"] as Style;


            }
            catch (Exception ex)
            {

            }
        }

        public ScrollViewer GetScrollViewer(UIElement element)
        {
            if (element == null) return null;

            ScrollViewer retour = null;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(element) && retour == null; i++)
            {
                if (VisualTreeHelper.GetChild(element, i) is ScrollViewer)
                {
                    retour = (ScrollViewer)(VisualTreeHelper.GetChild(element, i));
                }
                else
                {
                    retour = GetScrollViewer(VisualTreeHelper.GetChild(element, i) as UIElement);
                }
            }
            return retour;
        }

        private void SetOption()
        {
            option = new Option();
            LeftCallDataGrid.ItemsSource = option.OptionPrices;
            CenterHeadDataGrid.ItemsSource = option.OptionPrices;
            RightPutDataGrid.ItemsSource = option.OptionPrices;
        }
    }


    public class Option
    {
        public List<OptionPrice> OptionPrices { get; set; }
        public Option()
        {
            OptionPrices = new List<OptionPrice>();
            double baseprice = 10000;
            for (int i = 0; i < 30; i++)
            {
                OptionPrice temp = new OptionPrice(baseprice + i * 500);
                OptionPrices.Add(temp);
            }

        }
    }

    public class OptionPrice
    {
        public double TragePrice { get; set; }
        public string DisplayTragePrice { get; set; }
        public List<Contract> Contracts { get; set; }

        public OptionPrice(double price)
        {
            DateTime basemonth = DateTime.Now;
            double baseprice = 500.00;
            Contracts = new List<Contract>();
            TragePrice = price;
            DisplayTragePrice = TragePrice.ToString("F2");

            for (int i = 0; i < 6; i++)
            {
                string month = basemonth.AddMonths(i).ToString("yyyyHH");
                Contract contract = new Contract(month, baseprice + i * 10, ContractType.Call);
                Contracts.Add(contract);
                contract = new Contract(month, baseprice - i * 10, ContractType.Put);
                Contracts.Add(contract);
            }
        }
    }

    public class Contract
    {
        public string Month { get; set; }
        public double ContractPrice { get; set; }
        public ContractType Type { get; set; }

        public Contract(string month, double price, ContractType type)
        {
            Month = month;
            ContractPrice = price;
            Type = type;
        }
    }

    public enum ContractType
    {
        Call,
        Put
    }
}
