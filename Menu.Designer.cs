﻿namespace HolaMundoGit
{
    partial class Menu
    {
        // Kiko ha estado aquí
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Migue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Migue
            // 
            this.btn_Migue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Migue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Migue.Location = new System.Drawing.Point(681, 391);
            this.btn_Migue.Name = "btn_Migue";
            this.btn_Migue.Size = new System.Drawing.Size(107, 47);
            this.btn_Migue.TabIndex = 0;
            this.btn_Migue.Text = "Migue";
            this.btn_Migue.UseVisualStyleBackColor = false;
            this.btn_Migue.Click += new System.EventHandler(this.btn_Migue_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Migue);
            this.Name = "Menu";
            this.Text = "Menu Hola Mundo GIT";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Migue;
    }
}

