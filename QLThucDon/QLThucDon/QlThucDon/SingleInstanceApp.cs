using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlThucDon
{
    class SingleInstanceApp : WindowsFormsApplicationBase
    {
        FormMain frmMain = new FormMain();
        public SingleInstanceApp()
        {
        }
        public SingleInstanceApp(Form f)
        {
            //set IsSingleInstance property to true to make the application  
            base.IsSingleInstance = true;
            //set MainForm of the application. 
            this.frmMain = f;
        }
    }
}
