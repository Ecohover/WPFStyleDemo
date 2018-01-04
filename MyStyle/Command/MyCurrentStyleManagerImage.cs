using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MyStyle.Command
{
    public partial class MyCurrentStyleManager
    {
        #region Image

        public static ImageSource ImageIco;

        public static ImageSource ImageLogin;
        public static ImageSource ImageLidericon;

        public static ImageSource ImageFlashOrderDelete;
        public static ImageSource ImageFlashMITOrderDelete;
        public static ImageSource ImageFlashEye;
        public static ImageSource ImageFlashChart;
        public static ImageSource ImageFlashList;

        public static ImageSource ImageFlashLeftArrow;
        public static ImageSource ImageFlashRightArrow;
        public static ImageSource ImageFlashPreviousArrow;
        public static ImageSource ImageFlashNextArrow;
        public static ImageSource ImageFlashTool;

        public static ImageSource ImageFlashSetting;
        public static ImageSource ImageFlashTarget;
        public static ImageSource ImageFlashPin;
        public static ImageSource ImageFlashUnpin;
        public static ImageSource ImageFlashCenter;

        public static ImageSource ImageButtonWhiteSetting;
        public static ImageSource ImageButtonClose;


        public static ImageSource ImageTreeViewExpanded;
        public static ImageSource ImageTreeViewCollapsed;


        public static ImageSource ImageOptionTacticsR01;
        public static ImageSource ImageOptionTacticsR02;
        public static ImageSource ImageOptionTacticsR03;
        public static ImageSource ImageOptionTacticsR04;
        public static ImageSource ImageOptionTacticsR05;
        public static ImageSource ImageOptionTacticsR06;
        public static ImageSource ImageOptionTacticsR07;

        public static ImageSource ImageOptionTacticsG01;
        public static ImageSource ImageOptionTacticsG02;
        public static ImageSource ImageOptionTacticsG03;
        public static ImageSource ImageOptionTacticsG04;
        public static ImageSource ImageOptionTacticsG05;
        public static ImageSource ImageOptionTacticsG06;
        public static ImageSource ImageOptionTacticsG07;


        public static ImageSource ImageToolBackground;
        public static ImageSource ImageToolBackgroundLeft;
        public static ImageSource ImageToolBackgroundRight;


        public static ImageSource ImageToolClose;
        public static ImageSource ImageToolInfo;
        public static ImageSource ImageToolLinkGreen;
        public static ImageSource ImageToolLinkOrange;
        public static ImageSource ImageToolLinkRed;
        public static ImageSource ImageToolUpHide;

        public static ImageSource ImagePropertyGridArowDown;
        public static ImageSource ImagePropertyGridArowUp;
        public static ImageSource ImagePropertyGridSortLetter;
        public static ImageSource ImagePropertyGridSortTree;


        public static ImageSource ImageUpArrow;
        public static ImageSource ImageDownArrow;

        public static ImageSource ImageMaxRightArrow;
        public static ImageSource ImageMaxLeftArrow;
        public static ImageSource ImageRightArrow;
        public static ImageSource ImageLeftArrow;

        #endregion

        public void SetDefalutFalshImage()
        {

        }

        public void SetImage()
        {
            Logger.Debug("SetImage()");


            ImageLogin = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/Application/LiderLogin.png"));
            ImageLidericon = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/Application/Lidericon.ico"));

            ImageFlashOrderDelete = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/FlashOrder/Button_OrderDelete.png"));
            ImageFlashMITOrderDelete = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/FlashOrder/Button_MITDelete.png"));
            ImageFlashEye = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/FlashOrder/Button_Eye.png"));
            ImageFlashChart = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/FlashOrder/Button_Chart.png"));
            ImageFlashList = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/FlashOrder/Button_List.png"));

            ImageFlashLeftArrow = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/FlashOrder/Button_LeftArrow.png"));
            ImageFlashRightArrow = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/FlashOrder/Button_RightArrow.png"));
            ImageFlashPreviousArrow = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/FlashOrder/Button_PreviousArrow.png"));
            ImageFlashNextArrow = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/FlashOrder/Button_NextArrow.png"));
            ImageFlashTool = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/FlashOrder/Button_Tool.png"));

            ImageFlashSetting = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/FlashOrder/Button_Setting.png"));
            ImageFlashTarget = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/FlashOrder/Button_Target.png"));
            ImageFlashPin = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/FlashOrder/Button_Pin.png"));
            ImageFlashUnpin = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/FlashOrder/Button_Unpin.png"));
            ImageFlashCenter = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/FlashOrder/Button_Center.png"));

            ImageButtonWhiteSetting = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/Button_WhiteSetting.png"));

            ImageTreeViewExpanded = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/TreeView_DownArrow.png"));
            ImageTreeViewCollapsed = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/TreeView_RightArrow.png"));

            ImageButtonClose = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/Button_Close.png"));

            ImageOptionTacticsR01 = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/OptionTactics/R01.png"));
            ImageOptionTacticsR02 = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/OptionTactics/R02.png"));
            ImageOptionTacticsR03 = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/OptionTactics/R03.png"));
            ImageOptionTacticsR04 = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/OptionTactics/R04.png"));
            ImageOptionTacticsR05 = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/OptionTactics/R05.png"));
            ImageOptionTacticsR06 = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/OptionTactics/R06.png"));
            ImageOptionTacticsR07 = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/OptionTactics/R07.png"));


            ImageOptionTacticsG01 = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/OptionTactics/G01.png"));
            ImageOptionTacticsG02 = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/OptionTactics/G02.png"));
            ImageOptionTacticsG03 = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/OptionTactics/G03.png"));
            ImageOptionTacticsG04 = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/OptionTactics/G04.png"));
            ImageOptionTacticsG05 = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/OptionTactics/G05.png"));
            ImageOptionTacticsG06 = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/OptionTactics/G06.png"));
            ImageOptionTacticsG07 = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/OptionTactics/G07.png"));


            ImageToolBackground = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/ToolMenu/ToolBackground.png"));
            ImageToolBackgroundLeft = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/ToolMenu/ToolBackgroundLeft.png"));
            ImageToolBackgroundRight = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/ToolMenu/ToolBackgroundRight.png"));


            ImageToolUpHide = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/ToolMenu/ToolUpHide.png"));
            ImageToolClose = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/ToolMenu/ToolClose.png"));
            ImageToolInfo = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/ToolMenu/ToolInfo.png"));

            ImageToolLinkGreen = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/ToolMenu/ToolLinkGreen.png"));
            ImageToolLinkOrange = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/ToolMenu/ToolLinkOrange.png"));
            ImageToolLinkRed = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/ToolMenu/ToolLinkRed.png"));


            ImagePropertyGridArowDown = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/PropertyGrid/ArowDown.png"));
            ImagePropertyGridArowUp = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/PropertyGrid/ArowUp.png"));
            ImagePropertyGridSortLetter = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/PropertyGrid/SortLetter.png"));
            ImagePropertyGridSortTree = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/PropertyGrid/SortTree.png"));



            ImageMaxRightArrow = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/Button/Brtton_MaxRightArrow.png"));
            ImageMaxLeftArrow = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/Button/Brtton_MaxLeftArrow.png"));

            ImageUpArrow = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/Brtton/Brtton_UpArrow.png"));
            ImageDownArrow = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/Brtton/Button_DownArrow.png"));
            ImageRightArrow = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/Button/Button_RightArrow.png"));
            ImageLeftArrow = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/Button/Button_LeftArrow.png"));


        }

    }
}
