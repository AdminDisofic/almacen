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
            VentanaMigue vMigue = new VentanaMigue();

            vMigue.Show();
        }

        private void btn_Dani_Click(object sender, EventArgs e)
        {
            VentanaDani dani = new VentanaDani();
            dani.Show();
            this.Hide();
        }

        private void btn_Juan_Click(object sender, EventArgs e)
        {
            VentanaJuan Juan = new VentanaJuan();
            Juan.Show();
            this.Hide();
        }

        private void button_Esperanza_Click(object sender, EventArgs e)
        {
            Form_Esperanza Esperanza= new Form_Esperanza();
            Esperanza.Show();
        }

        private void btn_Cris_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola soy Cristina", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnGonzalo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Enhorabuena! Acabas de pulsar sobre el botón de Gonzalo", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnPaco_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Enhorabuena! Acabas de pulsar sobre el botón de Paco", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
