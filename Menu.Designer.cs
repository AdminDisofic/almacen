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
            this.btn_Dani = new System.Windows.Forms.Button();
            this.btn_Juan = new System.Windows.Forms.Button();
            this.button_Esperanza = new System.Windows.Forms.Button();
            this.btnPako = new System.Windows.Forms.Button();
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
            // btn_Dani
            // 
            this.btn_Dani.Location = new System.Drawing.Point(330, 215);
            this.btn_Dani.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Dani.Name = "btn_Dani";
            this.btn_Dani.Size = new System.Drawing.Size(128, 63);
            this.btn_Dani.TabIndex = 1;
            this.btn_Dani.Text = "Dani";
            this.btn_Dani.UseVisualStyleBackColor = true;
            this.btn_Dani.Click += new System.EventHandler(this.btn_Dani_Click);
            // 
            // btn_Juan
            // 
            this.btn_Juan.Location = new System.Drawing.Point(684, 320);
            this.btn_Juan.Name = "btn_Juan";
            this.btn_Juan.Size = new System.Drawing.Size(103, 51);
            this.btn_Juan.TabIndex = 2;
            this.btn_Juan.Text = "Juan";
            this.btn_Juan.UseVisualStyleBackColor = true;
            this.btn_Juan.Click += new System.EventHandler(this.btn_Juan_Click);
            // 
            // button_Esperanza
            // 
            this.button_Esperanza.Location = new System.Drawing.Point(614, 165);
            this.button_Esperanza.Name = "button_Esperanza";
            this.button_Esperanza.Size = new System.Drawing.Size(119, 54);
            this.button_Esperanza.TabIndex = 3;
            this.button_Esperanza.Text = "Esperanza";
            this.button_Esperanza.UseVisualStyleBackColor = true;
            this.button_Esperanza.Click += new System.EventHandler(this.button_Esperanza_Click);
            // 
            // btnPako
            // 
            this.btnPako.Location = new System.Drawing.Point(39, 404);
            this.btnPako.Name = "btnPako";
            this.btnPako.Size = new System.Drawing.Size(75, 23);
            this.btnPako.TabIndex = 4;
            this.btnPako.Text = "Pako";
            this.btnPako.UseVisualStyleBackColor = true;
            this.btnPako.Click += new System.EventHandler(this.btnPako_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPako);
            this.Controls.Add(this.button_Esperanza);
            this.Controls.Add(this.btn_Juan);
            this.Controls.Add(this.btn_Dani);
            this.Controls.Add(this.btn_Migue);
            this.Name = "Menu";
            this.Text = "Menu Hola Mundo GIT";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Migue;
        private System.Windows.Forms.Button btn_Dani;
        private System.Windows.Forms.Button btn_Juan;
        private System.Windows.Forms.Button button_Esperanza;
        private System.Windows.Forms.Button btnPako;
    }
}

