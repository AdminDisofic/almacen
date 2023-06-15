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
        //comentario
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Cris_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cristina ha estado aquí");
        }
    }
}
