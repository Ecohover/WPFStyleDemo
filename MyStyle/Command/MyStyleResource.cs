using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace MyStyle.Command
{
    public class MyStyleResource : ResourceDictionary
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(MyStyleResource));
        public StyleEnum StyleEnum = StyleEnum.Dark01;
        private static MyStyleResource instance = null;
        private static ResourceDictionary Resources = new ResourceDictionary();
        private static object objLock = new object();
        public static MyStyleResource GetInstance()
        {
            if (instance == null)
            {
                lock (objLock)
                {
                    if (instance == null) instance = new MyStyleResource();
                }
            }
            return instance;
        }

        private MyStyleResource()
        {
        }
        
        public ResourceDictionary GetMyResource()
        {
            return (ResourceDictionary)Resources;
        }

        public ResourceDictionary CloneMyResource()
        {
            return CloneMyResource(StyleEnum);
        }

        public ResourceDictionary CloneMyResource(StyleEnum style)
        {
            ResourceDictionary resources = new ResourceDictionary();
            try
            {
                if (!style.Equals("Normal"))
                {
                    resources.Source = new Uri($"pack://application:,,,/MyStyle;component/Resource/{style}.xaml", UriKind.RelativeOrAbsolute);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message.ToString());
            }
            return resources;
        }

        private ResourceDictionary SetResources(StyleEnum style)
        {
            Logger.Debug(" SetResources style = " + style.ToString());
            try
            {
                if (!style.Equals("Normal"))
                {
                    Resources = new ResourceDictionary();
                    Resources.Source = new Uri($"pack://application:,,,/MyStyle;component/Resource/{style}.xaml", UriKind.RelativeOrAbsolute);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message.ToString());
            }
            return Resources;
        }

        public void ResetResources()
        {
            Logger.Debug(" ResetResources style = " + StyleEnum.ToString());
            try
            {
                SetResources(StyleEnum);
                MyStyle.Command.MyCurrentStyleManager.GetInstance().ResetStyle();
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message.ToString());
            }
        }


        public static T GetControl<T>(StyleEnum style, Uri uri)
            where T : UserControl, new()
        {
            Logger.Debug("T GetControl<T>");
            T obj = default(T);
            try
            {
                if (style != StyleEnum.Normal)
                {
                    using (Stream stream = Application.GetResourceStream(uri).Stream)
                    {
                        object root = XamlReader.Load(stream);
                        obj = (T)root;
                        //obj.UpdateUserControlStyle(style);
                    }
                }
                else
                {
                    obj = new T();
                }
            }
            catch (Exception ex)
            {
                Logger.Debug(ex.Message.ToString());
            }
            return obj;
        }
        
    }
    public enum StyleEnum
    {
        Normal,
        Dark01
    }
}
