using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookApp.ControlVisitor
{
    interface IControlVisitor
    {
        void VisitToEnable(Control i_Ctrl);
        void VisitToDisable(Control i_Ctrl);
    }
}

