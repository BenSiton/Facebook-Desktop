using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookApp.ControlVisitor
{
    public class EnablerVisitor : IControlVisitor
    {

        public void VisitToEnable(Control i_Ctrl)
        {
            i_Ctrl.Enabled = true;
        }

        public void VisitToDisable(Control i_Ctrl)
        {
            i_Ctrl.Enabled = false;
        }
    }
}
