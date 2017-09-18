using ActiproSoftware.Windows.Controls.Docking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFDemo.Command
{
    public class MyDockSite : DockSite
    {

        public MyDockSite() : base()
        { }
        protected override ActiproSoftware.Windows.Controls.Docking.Primitives.IRaftingWindow CreateRaftingWindow(RaftingHost raftingHost)
        {
            ActiproSoftware.Windows.Controls.Docking.Primitives.IRaftingWindow win = base.CreateRaftingWindow(raftingHost);
            ((Window)win).ShowInTaskbar = true;
            ToolWindow tw = win as ToolWindow;
            return win;
        }
    }
}
