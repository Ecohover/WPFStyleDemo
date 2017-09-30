using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace MyStyle.Command
{
    public class MyResource : ResourceDictionary
    {
        private readonly ILog Logger = LogManager.GetLogger(typeof(MyResource));
        public StyleEnum StyleEnum = StyleEnum.Dark01;
        private static MyResource instance = null;
        private static ResourceDictionary Resources = new ResourceDictionary();
        private static object objLock = new object();
        public static MyResource GetInstance()
        {
            if (instance == null)
            {
                lock (objLock)
                {
                    if (instance == null) instance = new MyResource();
                }
            }
            return instance;
        }
        private MyResource()
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
                    resources.Source = new Uri($"/MyStyle;component/Resource/{style}.xaml", UriKind.RelativeOrAbsolute);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message.ToString());
            }
            return resources;
        }
        public ResourceDictionary SetResources(StyleEnum style)
        {
            Logger.Debug(" UpdateStyle style = " + style.ToString());
            try
            {
                if (!style.Equals("Normal"))
                {
                    Resources = new ResourceDictionary();
                    Resources.Source = new Uri($"/MyStyle;component/Resource/{style}.xaml", UriKind.RelativeOrAbsolute);
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
            Logger.Debug(" UpdateStyle style = " + StyleEnum.ToString());
            try
            {
                MyStyle.Command.MyCurrentStyleManager.GetInstance().ResetStyle();
                SetResources(StyleEnum);
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message.ToString());
            }
        }
    }
    public enum StyleEnum
    {
        Normal,
        Dark01
    }
}
