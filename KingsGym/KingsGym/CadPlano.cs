using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingsGym
{
    public partial class frmCadPlano : Form
    {
        public frmCadPlano()
        {
            InitializeComponent();
        }

        private void btnFechar2_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            this.Hide();
            home.Show();
        }
    }
}
