﻿using System;
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
    }
}
