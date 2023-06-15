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
    public partial class pb_Juan : Form
    {
        public pb_Juan()
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

       
        private void pb_dani_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Que foto más bonita!");
        }

        private void pb_Migue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Que coche mas bonito", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Que foto más bonita");
        }
    }
}
