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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            pnlRegistrar.Height = 0;
            pnlLogin.Location = new Point(174, 12);
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlRegistrar.Height = pnlLogin.Height;
            pnlLogin.Location = new Point(174, 12);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            pnlRegistrar.Height = 0;
            pnlLogin.Location = new Point(174, 12);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmCadPlano cadplano = new frmCadPlano();
            this.Hide();
            cadplano.Show();
        }
    }
}
