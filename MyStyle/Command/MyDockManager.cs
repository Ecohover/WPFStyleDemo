using ActiproSoftware.Windows.Controls.Docking;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyStyle.Command
{
    public class MyDockSiteManager
    { 
        private readonly ILog Logger = LogManager.GetLogger(typeof(MyDockSiteManager));
        public Dictionary<string, MyDockSite> DockSites = new Dictionary<string, MyDockSite>();

        private static MyDockSiteManager instance = null;
        private static object objLock = new object();
        public static MyDockSiteManager GetInstance()
        {
            if (instance == null)
            {
                lock (objLock)
                {
                    if (instance == null) instance = new MyDockSiteManager();
                }
            }
            return instance;
        }
        private MyDockSiteManager() 
        {
        }

        public void CreateDockSite(string name)
        {
            DockSites.Add(name, new MyDockSite());
        }

        public MyDockSite GetDockSite(string name)
        {
            MyDockSite Result = null;
            if (DockSites.ContainsKey(name)) Result = DockSites[name];
            return Result;
        }
        //protected override ActiproSoftware.Windows.Controls.Docking.Primitives.IRaftingWindow CreateRaftingWindow(RaftingHost raftingHost)
        //{
        //    ActiproSoftware.Windows.Controls.Docking.Primitives.IRaftingWindow win = base.CreateRaftingWindow(raftingHost);
        //    ((Window)win).ShowInTaskbar = true;
        //    ToolWindow tw = win as ToolWindow;
        //    return win;
        //}
    }
}
