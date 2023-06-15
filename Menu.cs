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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

     

        private void btn_Dani_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dani ha estado aquí");
        }

        private void btn_Migue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Migue ha estado aquí", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Juan_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Juan ha estado aquí");
        }
    }
}
