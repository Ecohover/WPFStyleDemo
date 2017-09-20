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
        private readonly ILog Logger = LogManager.GetLogger(typeof(MyDockSiteManager));
        private Dictionary<string, MyStyleManager> AllStyle = new Dictionary<string, MyStyleManager>();
        
        private static MyStyleManager instance = null;
        private static object objLock = new object();
        public static MyStyleManager GetInstance()
        {
            if (instance == null)
            {
                lock (objLock)
                {
                    if (instance == null) instance = new MyStyleManager();
                }
            }
            return instance;
        }
        private MyStyleManager() :
            base()
        {
            SetBrushColor();
            SetFalshImage();
        }
    }
}
