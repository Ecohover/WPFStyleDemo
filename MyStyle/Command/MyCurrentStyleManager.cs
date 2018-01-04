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
    public partial class MyCurrentStyleManager
    {
        private readonly ILog Logger = LogManager.GetLogger(typeof(MyDockSiteManager));
        
        private static MyCurrentStyleManager instance = null;
        private static object objLock = new object();
        public static MyCurrentStyleManager GetInstance()
        {
            if (instance == null)
            {
                lock (objLock)
                {
                    if (instance == null) instance = new MyCurrentStyleManager();
                }
            }
            return instance;
        }
        public void ResetStyle()
        {
            SetBrushColor();
            SetImage();
        }
        private MyCurrentStyleManager() :
            base()
        {
            //ResetStyle();
        }
    }
}
