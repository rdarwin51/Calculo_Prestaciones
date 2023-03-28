using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcule_Prest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        presdtacalc ps = new presdtacalc();
        private void Form1_Load(object sender, EventArgs e)
        {
            ps.Recup_Dep(cb_dep);
        }

        void llenar_comboM()
        {
            
        }
    }

}
