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

        private static MyResource instance = null;
        private static ResourceDictionary Resource = new ResourceDictionary();
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

        public void SetMyResource(ResourceDictionary ResourceDictionary)
        {
            Resource = ResourceDictionary;
        }
        public ResourceDictionary GetMyResource()
        {
            return (ResourceDictionary)Resource;
        }
    }
}
