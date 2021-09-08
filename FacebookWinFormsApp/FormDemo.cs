using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookApp.ControlVisitor;

namespace FacebookApp
{
    public partial class FormDemo : Form
    {
        public FormDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnablerVisitor concreteEnableVisitor = new EnablerVisitor();
            concreteEnableVisitor.VisitToEnable(button2);
        }
    }
}
