using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace MyStyle.Command
{
    public static class ExtensionMethods
    {

        public static void ReConnectVariables(this FrameworkElement feobj)
        {
            Type tType = feobj.GetType();
            FieldInfo[] mInfos = tType.GetFields((BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance));
            foreach (FieldInfo mInfo in mInfos)
            {
                object obj = feobj.FindName(mInfo.Name);
                if (obj != null && obj.GetType() == mInfo.FieldType)
                {
                    mInfo.SetValue(feobj, obj);
                }
            }
        }
        public static T CreateFrameworkElement<T>(this FrameworkElement obj) where T : FrameworkElement, new()
        {
            T control = null;
            try
            {
                Stream stream = XamlManager.GetInstance().GetXamlStream(typeof(T));

                if (stream != null)
                {
                    object root = System.Windows.Markup.XamlReader.Load(stream);
                    control = (T)root;
                    control.ReConnectVariables();
                }
                else
                {
                    control = new T();
                }
            }
            catch (Exception ex)
            { }
            return control;
        }
        public static void SetStyle(this FrameworkElement obj)
        {
            ResourceDictionary mystyles;
            try
            {
                if (MyStyle.Command.MyStyleResource.GetInstance().StyleEnum.Equals(MyStyle.Command.StyleEnum.Normal)) return;
                mystyles = MyStyleResource.GetInstance().GetMyResource();
                obj.Resources.MergedDictionaries.Add(mystyles);
            }
            catch (Exception ex)
            {
            }
        }

        public static void SetStyle(this FrameworkElement obj, StyleEnum style)
        {
            ResourceDictionary mystyles;
            try
            {
                if (style.Equals(MyStyle.Command.StyleEnum.Normal)) return;
                mystyles = MyStyleResource.GetInstance().CloneMyResource(style);
                obj.Resources.MergedDictionaries.Add(mystyles);
            }
            catch (Exception ex)
            {
            }
        }

        public static void SetStyle(this FrameworkElement obj, StyleEnum style, string stylename)
        {
            ResourceDictionary mystyles;
            try
            {
                if (style.Equals(MyStyle.Command.StyleEnum.Normal)) return;
                mystyles = MyStyleResource.GetInstance().CloneMyResource(style);
                obj.Resources.MergedDictionaries.Add(mystyles);
                obj.Style = (Style)obj.FindResource(stylename);
            }
            catch (Exception ex)
            {
            }
        }

        public static void SetStyle(this FrameworkElement obj, string stylename)
        {
            ResourceDictionary mystyles;
            try
            {
                if (MyStyle.Command.MyStyleResource.GetInstance().StyleEnum.Equals(MyStyle.Command.StyleEnum.Normal)) return;
                mystyles = MyStyleResource.GetInstance().GetMyResource();
                obj.Resources.MergedDictionaries.Add(mystyles);
                obj.Style = (Style)obj.FindResource(stylename);
            }
            catch (Exception ex)
            {
            }
        }
        public static void SetUserControlStyle(this UserControl usercontrol, StyleEnum style)
        {
            ResourceDictionary mystyles;
            try
            {
                if (!style.Equals(MyStyle.Command.StyleEnum.Normal))
                {
                    mystyles = MyStyleResource.GetInstance().GetMyResource();
                    usercontrol.Resources.MergedDictionaries.Add(mystyles);
                    //usercontrol.Style = usercontrol.Resources["UserControl"] as Style;
                }
            }
            catch (Exception ex)
            {
            }
        }

        public static void SetWindowStyle(this Window window, StyleEnum style)
        {
            ResourceDictionary mystyles;
            try
            {
                if (!style.Equals(MyStyle.Command.StyleEnum.Normal))
                {
                    mystyles = MyStyleResource.GetInstance().GetMyResource();
                    window.Resources.MergedDictionaries.Add(mystyles);
                    window.Style = window.Resources["Window"] as Style;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private static void SetUserControlStyle(this System.Windows.Controls.Control control, string style, string type)
        {

            ResourceDictionary mystyles;
            try
            {
                if (!style.Equals(MyStyle.Command.StyleEnum.Normal))
                {
                    mystyles = MyStyleResource.GetInstance().CloneMyResource((StyleEnum)System.Enum.Parse(typeof(StyleEnum), style));
                    control.Resources.MergedDictionaries.Add(mystyles);
                    control.Style = control.Resources[type] as Style;
                }
            }
            catch (Exception ex)
            {
            }
        }

        public static ScrollViewer GetScrollViewer(this System.Windows.Controls.Control grid)
        {
            ScrollViewer objResult = null;
            try
            {
                FieldInfo[] gridfinfos = grid.GetType().GetFields((BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance));
                var varScrollViewers = gridfinfos
                    .Where(w => w.FieldType == typeof(ScrollViewer))
                    .Select(s => s).ToArray();
                if (varScrollViewers.Count() != 1) return null;
                objResult = (ScrollViewer)varScrollViewers[0].GetValue(grid);
            }
            catch (Exception ex)
            {
            }
            return objResult;
        }

        public static ScrollBar GetScrollBar(this System.Windows.Controls.Control grid, Orientation orientation)
        {
            ScrollBar objResult = null;
            try
            {
                FieldInfo[] gridfinfos = grid.GetType().GetFields((BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance));
                var varScrollViewers = gridfinfos
                    .Where(w => w.FieldType == typeof(ScrollViewer))
                    .Select(s => s).ToArray();
                if (varScrollViewers.Count() != 1) return null;
                ScrollViewer tempScrollViewer = (ScrollViewer)varScrollViewers[0].GetValue(grid);
                FieldInfo[] tempScrollViewerfinfos = tempScrollViewer.GetType().GetFields((BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance));
                var varScrollBars = gridfinfos
                    .Where(w => w.FieldType == typeof(ScrollBar))
                    .Where(w => ((ScrollBar)w.GetValue(null)).Orientation == orientation)
                    .Select(s => s).ToArray();
                if (varScrollBars.Count() <= 0) return null;
                objResult = (ScrollBar)varScrollBars[0].GetValue(tempScrollViewer);
            }
            catch (Exception ex)
            {
            }
            return objResult;
        }

    }
}
