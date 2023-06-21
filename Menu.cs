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

        private void btn_Migue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola soy Migue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Dani_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Enhorabuena! Acabas de pulsar sobre el botón de Dani", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_Juan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola soy Juan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Esperanza_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola soy Esperanza", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPako_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola soy Pako", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
