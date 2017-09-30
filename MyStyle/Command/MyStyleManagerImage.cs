﻿using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace MyStyle.Command
{
    public partial class MyCurrentStyleManager
    {
        #region Image
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


        public static ImageSource ImageTreeViewExpanded;
        public static ImageSource ImageTreeViewCollapsed;
        #endregion

        public void SetDefalutFalshImage()
        {

        }

        public void SetFalshImage()
        {
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


            ImageTreeViewExpanded = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/TreeView_DownArrow.png"));
            ImageTreeViewCollapsed = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/MyStyle;component/Image/TreeView_RightArrow.png"));

        }

    }
}
