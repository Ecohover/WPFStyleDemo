using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace MyStyle.Command
{
    public class MyColor
    {
        public static Brush WindowColorDark;
        public static Brush WindowColorLight;
        public static Brush WindowForeColor;
        public static Brush WindowColorGray;

        public static Brush ButtonClick;
        public static Brush ButtonClick60;

        public static Brush ScrollBarNormal;
        public static Brush ScrollBarMouseOver;
        public static Brush ScrollBarClick;

        public static Brush TabControlItemSelected;
        public static Brush TabControlItemNormal;


        private readonly ILog Logger = LogManager.GetLogger(typeof(MyDockSiteManager));

        private static MyColor instance = null;
        private static object objLock = new object();
        public static MyColor GetInstance()
        {
            if (instance == null)
            {
                lock (objLock)
                {
                    if (instance == null) instance = new MyColor();
                }
            }
            return instance;
        }
        private MyColor() :
            base()
        {
            WindowColorDark = GetSolidColorBrush("#FF1D1E26");
            WindowColorLight = GetSolidColorBrush("#FF222C36");
            WindowForeColor = GetSolidColorBrush("#FFFFFFFF");
            WindowColorGray = GetSolidColorBrush("#FF6B727C");
            TabControlItemSelected = GetSolidColorBrush("#FF47627C");

            GradientStopCollection stops;

            stops = new GradientStopCollection
            {
                GetGradientStop("#FF0FC8CA", 0),
                GetGradientStop("#FF109ED7", 1)
            };
            ButtonClick = GetLinearGradientBrush(
                    new System.Windows.Point(0, 0),
                    new System.Windows.Point(0, 1),
                    stops);

            stops = new GradientStopCollection
            {
                GetGradientStop("#990FC8CA", 0),
                GetGradientStop("#99109ED7", 1)
            };
            ButtonClick60 = GetLinearGradientBrush(
                    new System.Windows.Point(0, 0),
                    new System.Windows.Point(0, 1),
                    stops);

            stops = new GradientStopCollection
            {
                GetGradientStop("#FF109CD8", 0),
                GetGradientStop("#FF0FC8CA", 1)
            };
            ScrollBarNormal = GetLinearGradientBrush(
                    new System.Windows.Point(0, 0),
                    new System.Windows.Point(0, 1),
                    stops);

            stops = new GradientStopCollection
            {
                GetGradientStop("#FF4BB7E6", 0),
                GetGradientStop("#FF82E9EA", 1)
            };
            ScrollBarMouseOver = GetLinearGradientBrush(
                    new System.Windows.Point(0, 0),
                    new System.Windows.Point(0, 1),
                    stops);

            stops = new GradientStopCollection
            {
                GetGradientStop("#FF104DD8", 0),
                GetGradientStop("#FF0FB2CA", 1)
            };
            ScrollBarClick = GetLinearGradientBrush(
                    new System.Windows.Point(0, 0),
                    new System.Windows.Point(0, 1),
                    stops);

            stops = new GradientStopCollection
            {
                GetGradientStop("#FFACC4CE", 0),
                GetGradientStop("#FFA2B5BD", 1)
            };
            TabControlItemNormal = GetLinearGradientBrush(
                    new System.Windows.Point(0, 0),
                    new System.Windows.Point(0, 1),
                    stops);
        }

        private Brush GetLinearGradientBrush(System.Windows.Point StartPoint, System.Windows.Point EndPoint, GradientStopCollection Stops)
        {
            LinearGradientBrush objBrush = new LinearGradientBrush();
            try
            {
                objBrush.StartPoint = StartPoint;
                objBrush.EndPoint = EndPoint;
                objBrush.GradientStops = Stops;
            }
            catch
            {

            }
            return (Brush)objBrush;
        }

        private Brush GetSolidColorBrush(string ColorCode)
        {
            Brush objBrush = new SolidColorBrush();
            try
            {
                objBrush = (Brush)(new BrushConverter().ConvertFrom(ColorCode));
            }
            catch
            {

            }
            return objBrush;
        }

        public GradientStop GetGradientStop(string ColorCode, double Offset)
        {
            GradientStop objGradientStop = new GradientStop();
            try
            {
                objGradientStop = new GradientStop((Color)(new ColorConverter().ConvertFrom(ColorCode)), Offset);
            }
            catch
            {

            }
            return objGradientStop;

        }



        public void SetColor()
        {
            WindowColorDark = (Brush)(new BrushConverter().ConvertFrom("#FFFFFFFF"));
            WindowColorLight = (Brush)(new BrushConverter().ConvertFrom("#FFFFFFFF"));
            WindowForeColor = (Brush)(new BrushConverter().ConvertFrom("#FFFFFFFF"));
            WindowColorGray = (Brush)(new BrushConverter().ConvertFrom("#FFFFFFFF"));
        }


    }
}
