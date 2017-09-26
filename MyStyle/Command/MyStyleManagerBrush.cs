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
    public partial class MyStyleManager
    {
        #region Brush
        public static Brush BrushWindowBackgrond;
        public static Brush BrushWindowTitleBackgrond;
        public static Brush BrushWindowForeground;
        public static Brush BrushWindowBorderBrush;

        public static Brush BrushEvenTriggerLevel1;
        public static Brush BrushEvenTriggerLevel2;

        public static Brush BrushScrollBarNormal;
        public static Brush BrushScrollBarMouseOver;
        public static Brush BrushScrollBarClick;

        public static Brush BrushTabControlItemSelected;
        public static Brush BrushTabControlItemNormal;

        public static Brush BrushGridBackGroundGray;
        public static Brush BrushGridForeColorYellow;
        public static Brush BrushGridForeColorWhite;
        public static Brush BrushGridForeColorRed;


        public static Brush BrushButtonGreen;
        public static Brush BrushButtonRed;
        public static Brush BrushButtonBlue;


        public static Brush BrushListBoxNormal;
        public static Brush BrushListBoxClick;


        public static Brush BrushFlashOrederSetting;
        public static Brush BrushFlashEnterTactics;
        public static Brush BrushFlashExitTactics;

        #endregion

        public void SetBrushColor()
        {
            BrushWindowBackgrond = GetSolidColorBrush("#FF1D1E26");
            BrushWindowTitleBackgrond = GetSolidColorBrush("#FF222C36");
            BrushWindowForeground = GetSolidColorBrush("#FFFFFFFF");
            BrushWindowBorderBrush = GetSolidColorBrush("#FF6B727C");

            BrushGridBackGroundGray = GetSolidColorBrush("#FF384959");
            BrushGridForeColorYellow = GetSolidColorBrush("#FFFAE808");
            BrushGridForeColorWhite = GetSolidColorBrush("#FFFFFFFF");
            BrushGridForeColorRed = GetSolidColorBrush("#FFFF3838");

            BrushTabControlItemSelected = GetSolidColorBrush("#FF47627C");

            BrushListBoxNormal = GetSolidColorBrush("#FF4773A2");
            BrushListBoxClick = GetSolidColorBrush("#FF628EBD");



            BrushFlashOrederSetting = GetSolidColorBrush("#FF4773A2");
            BrushFlashEnterTactics = GetSolidColorBrush("#FF628EBD");
            BrushFlashExitTactics = GetSolidColorBrush("#FF0B57A2");




            GradientStopCollection stops;

            stops = new GradientStopCollection
            {
                GetGradientStop("#FF0FC8CA", 0),
                GetGradientStop("#FF109ED7", 1)
            };
            BrushEvenTriggerLevel1 = GetLinearGradientBrush(
                    new System.Windows.Point(0, 0),
                    new System.Windows.Point(0, 1),
                    stops);

            stops = new GradientStopCollection
            {
                GetGradientStop("#990FC8CA", 0),
                GetGradientStop("#99109ED7", 1)
            };
            BrushEvenTriggerLevel2 = GetLinearGradientBrush(
                    new System.Windows.Point(0, 0),
                    new System.Windows.Point(0, 1),
                    stops);

            stops = new GradientStopCollection
            {
                GetGradientStop("#FF109CD8", 0),
                GetGradientStop("#FF0FC8CA", 1)
            };
            BrushScrollBarNormal = GetLinearGradientBrush(
                    new System.Windows.Point(0, 0),
                    new System.Windows.Point(0, 1),
                    stops);

            stops = new GradientStopCollection
            {
                GetGradientStop("#FF4BB7E6", 0),
                GetGradientStop("#FF82E9EA", 1)
            };
            BrushScrollBarMouseOver = GetLinearGradientBrush(
                    new System.Windows.Point(0, 0),
                    new System.Windows.Point(0, 1),
                    stops);

            stops = new GradientStopCollection
            {
                GetGradientStop("#FF104DD8", 0),
                GetGradientStop("#FF0FB2CA", 1)
            };
            BrushScrollBarClick = GetLinearGradientBrush(
                    new System.Windows.Point(0, 0),
                    new System.Windows.Point(0, 1),
                    stops);

            stops = new GradientStopCollection
            {
                GetGradientStop("#FFACC4CE", 0),
                GetGradientStop("#FFA2B5BD", 1)
            };

            BrushTabControlItemNormal = GetLinearGradientBrush(
                    new System.Windows.Point(0, 0),
                    new System.Windows.Point(0, 1),
                    stops);

            stops = new GradientStopCollection
            {
                GetGradientStop("#FF8DEA99", 0),
                GetGradientStop("#FF5EC43D", 1)
            };

            BrushButtonGreen = GetLinearGradientBrush(
                    new System.Windows.Point(0, 0),
                    new System.Windows.Point(0, 1),
                    stops); stops = new GradientStopCollection
            {
                GetGradientStop("#FFEC5F6F", 0),
                GetGradientStop("#FFFF8580", 1)
            };

            BrushButtonRed = GetLinearGradientBrush(
                    new System.Windows.Point(0, 0),
                    new System.Windows.Point(0, 1),
                    stops); stops = new GradientStopCollection
            {
                GetGradientStop("#FF0FC8CA", 0),
                GetGradientStop("#FF109ED7", 1)
            };

            BrushButtonBlue = GetLinearGradientBrush(
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

    }
}
