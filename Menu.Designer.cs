﻿namespace HolaMundoGit
{
    partial class Menu
    {
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
            this.btn_Dani = new System.Windows.Forms.Button();
            this.btn_Migue = new System.Windows.Forms.Button();
            this.btn_Juan = new System.Windows.Forms.Button();
            this.pb_Migue = new System.Windows.Forms.PictureBox();
            this.pb_dani = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Migue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dani)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Dani
            // 
            this.btn_Dani.Location = new System.Drawing.Point(680, 286);
            this.btn_Dani.Name = "btn_Dani";
            this.btn_Dani.Size = new System.Drawing.Size(115, 74);
            this.btn_Dani.TabIndex = 0;
            this.btn_Dani.Text = "Dani";
            this.btn_Dani.UseVisualStyleBackColor = true;
            this.btn_Dani.Click += new System.EventHandler(this.btn_Dani_Click);
            // 
            // btn_Migue
            // 
            this.btn_Migue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Migue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Migue.Location = new System.Drawing.Point(681, 376);
            this.btn_Migue.Name = "btn_Migue";
            this.btn_Migue.Size = new System.Drawing.Size(107, 62);
            this.btn_Migue.TabIndex = 1;
            this.btn_Migue.Text = "Migue";
            this.btn_Migue.UseVisualStyleBackColor = false;
            this.btn_Migue.Click += new System.EventHandler(this.btn_Migue_Click);
            // 
            // btn_Juan
            // 
            this.btn_Juan.Location = new System.Drawing.Point(681, 202);
            this.btn_Juan.Name = "btn_Juan";
            this.btn_Juan.Size = new System.Drawing.Size(114, 63);
            this.btn_Juan.TabIndex = 2;
            this.btn_Juan.Text = "Juan";
            this.btn_Juan.UseVisualStyleBackColor = true;
            this.btn_Juan.Click += new System.EventHandler(this.btn_Juan_Click);
            // 
            // pb_Migue
            // 
            this.pb_Migue.Image = global::HolaMundoGit.Properties.Resources.Skylinne;
            this.pb_Migue.Location = new System.Drawing.Point(540, 376);
            this.pb_Migue.Name = "pb_Migue";
            this.pb_Migue.Size = new System.Drawing.Size(124, 62);
            this.pb_Migue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Migue.TabIndex = 4;
            this.pb_Migue.TabStop = false;
            this.pb_Migue.Click += new System.EventHandler(this.pb_Migue_Click);
            // 
            // pb_dani
            // 
            this.pb_dani.Image = global::HolaMundoGit.Properties.Resources.f117a045ea34b155d48ad62e8dee963c;
            this.pb_dani.Location = new System.Drawing.Point(540, 285);
            this.pb_dani.Name = "pb_dani";
            this.pb_dani.Size = new System.Drawing.Size(124, 74);
            this.pb_dani.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_dani.TabIndex = 3;
            this.pb_dani.TabStop = false;
            this.pb_dani.Click += new System.EventHandler(this.pb_dani_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_Migue);
            this.Controls.Add(this.pb_dani);
            this.Controls.Add(this.btn_Juan);
            this.Controls.Add(this.btn_Migue);
            this.Controls.Add(this.btn_Dani);
            this.Name = "Menu";
            this.Text = "Menu Hola Mundo GIT";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Migue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dani)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Dani;
        private System.Windows.Forms.Button btn_Migue;
        private System.Windows.Forms.Button btn_Juan;
        private System.Windows.Forms.PictureBox pb_dani;
        private System.Windows.Forms.PictureBox pb_Migue;
    }
}

