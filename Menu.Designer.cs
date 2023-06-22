namespace HolaMundoGit
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
            this.btn_Cris = new System.Windows.Forms.Button();
            this.btnGonzalo = new System.Windows.Forms.Button();
            this.btnPaco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Migue
            // 
            this.btn_Migue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Migue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Migue.Location = new System.Drawing.Point(1022, 602);
            this.btn_Migue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Migue.Name = "btn_Migue";
            this.btn_Migue.Size = new System.Drawing.Size(160, 72);
            this.btn_Migue.TabIndex = 0;
            this.btn_Migue.Text = "Migue";
            this.btn_Migue.UseVisualStyleBackColor = false;
            this.btn_Migue.Click += new System.EventHandler(this.btn_Migue_Click);
            // 
            // btn_Dani
            // 
            this.btn_Dani.Location = new System.Drawing.Point(495, 331);
            this.btn_Dani.Name = "btn_Dani";
            this.btn_Dani.Size = new System.Drawing.Size(192, 97);
            this.btn_Dani.TabIndex = 1;
            this.btn_Dani.Text = "Dani";
            this.btn_Dani.UseVisualStyleBackColor = true;
            this.btn_Dani.Click += new System.EventHandler(this.btn_Dani_Click);
            // 
            // btn_Juan
            // 
            this.btn_Juan.Location = new System.Drawing.Point(1026, 492);
            this.btn_Juan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Juan.Name = "btn_Juan";
            this.btn_Juan.Size = new System.Drawing.Size(154, 78);
            this.btn_Juan.TabIndex = 2;
            this.btn_Juan.Text = "Juan";
            this.btn_Juan.UseVisualStyleBackColor = true;
            this.btn_Juan.Click += new System.EventHandler(this.btn_Juan_Click);
            // 
            // button_Esperanza
            // 
            this.button_Esperanza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_Esperanza.Location = new System.Drawing.Point(921, 254);
            this.button_Esperanza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Esperanza.Name = "button_Esperanza";
            this.button_Esperanza.Size = new System.Drawing.Size(178, 83);
            this.button_Esperanza.TabIndex = 3;
            this.button_Esperanza.Text = "Esperanza";
            this.button_Esperanza.UseVisualStyleBackColor = false;
            this.button_Esperanza.Click += new System.EventHandler(this.button_Esperanza_Click);
            // 
            // btn_Cris
            // 
            this.btn_Cris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Cris.Location = new System.Drawing.Point(63, 108);
            this.btn_Cris.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cris.Name = "btn_Cris";
            this.btn_Cris.Size = new System.Drawing.Size(212, 94);
            this.btn_Cris.TabIndex = 4;
            this.btn_Cris.Text = "Cristi";
            this.btn_Cris.UseVisualStyleBackColor = false;
            this.btn_Cris.Click += new System.EventHandler(this.btn_Cris_Click);
            // 
            // btnGonzalo
            // 
            this.btnGonzalo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGonzalo.Location = new System.Drawing.Point(495, 18);
            this.btnGonzalo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGonzalo.Name = "btnGonzalo";
            this.btnGonzalo.Size = new System.Drawing.Size(192, 85);
            this.btnGonzalo.TabIndex = 5;
            this.btnGonzalo.Text = "Gonzalo";
            this.btnGonzalo.UseVisualStyleBackColor = false;
            this.btnGonzalo.Click += new System.EventHandler(this.btnGonzalo_Click);
            // 
            // btnPaco
            // 
            this.btnPaco.Location = new System.Drawing.Point(88, 516);
            this.btnPaco.Name = "btnPaco";
            this.btnPaco.Size = new System.Drawing.Size(176, 64);
            this.btnPaco.TabIndex = 6;
            this.btnPaco.Text = "Paco";
            this.btnPaco.UseVisualStyleBackColor = true;
            this.btnPaco.Click += new System.EventHandler(this.btnPaco_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnPaco);
            this.Controls.Add(this.btnGonzalo);
            this.Controls.Add(this.btn_Cris);
            this.Controls.Add(this.button_Esperanza);
            this.Controls.Add(this.btn_Juan);
            this.Controls.Add(this.btn_Dani);
            this.Controls.Add(this.btn_Migue);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.Text = "Menu Hola Mundo GIT";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Migue;
        private System.Windows.Forms.Button btn_Dani;
        private System.Windows.Forms.Button btn_Juan;
        private System.Windows.Forms.Button button_Esperanza;
        private System.Windows.Forms.Button btn_Cris;
        private System.Windows.Forms.Button btnGonzalo;
        private System.Windows.Forms.Button btnPaco;
    }
}

