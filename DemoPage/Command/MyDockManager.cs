using ActiproSoftware.Windows.Controls.Docking;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFDemo.Command
{
    public class MyDockManager : DockSite
    {
        private readonly ILog Logger = LogManager.GetLogger(typeof(MyDockManager));

        private static MyDockManager instance = null;
        private static object objLock = new object();
        public static MyDockManager GetInstance()
        {
            if (instance == null)
            {
                lock (objLock)
                {
                    if (instance == null) instance = new MyDockManager();
                }
            }
            return instance;
        }
        private MyDockManager() :
            base()
        {
        }
        protected override ActiproSoftware.Windows.Controls.Docking.Primitives.IRaftingWindow CreateRaftingWindow(RaftingHost raftingHost)
        {
            ActiproSoftware.Windows.Controls.Docking.Primitives.IRaftingWindow win = base.CreateRaftingWindow(raftingHost);
            ((Window)win).ShowInTaskbar = true;
            ToolWindow tw = win as ToolWindow;
            return win;
        }
    }
}
