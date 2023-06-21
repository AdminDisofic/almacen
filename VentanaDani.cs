using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundoGit
{
    public partial class VentanaDani : Form
    {
        public VentanaDani()
        {
            InitializeComponent();
        }

        private void btn_raro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sabia que te mataba la curiosidad","Caíste en la trampa vellaco",MessageBoxButtons.OK,MessageBoxIcon.Question);
        }

        private void VentanaDani_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
