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
            this.SuspendLayout();
            // 
            // btn_Migue
            // 
            this.btn_Migue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Migue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Migue.Location = new System.Drawing.Point(908, 481);
            this.btn_Migue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Migue.Name = "btn_Migue";
            this.btn_Migue.Size = new System.Drawing.Size(143, 58);
            this.btn_Migue.TabIndex = 0;
            this.btn_Migue.Text = "Migue";
            this.btn_Migue.UseVisualStyleBackColor = false;
            this.btn_Migue.Click += new System.EventHandler(this.btn_Migue_Click);
            // 
            // btn_Dani
            // 
            this.btn_Dani.Location = new System.Drawing.Point(440, 265);
            this.btn_Dani.Name = "btn_Dani";
            this.btn_Dani.Size = new System.Drawing.Size(170, 77);
            this.btn_Dani.TabIndex = 1;
            this.btn_Dani.Text = "Dani";
            this.btn_Dani.UseVisualStyleBackColor = true;
            this.btn_Dani.Click += new System.EventHandler(this.btn_Dani_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_Dani);
            this.Controls.Add(this.btn_Migue);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.Text = "Menu Hola Mundo GIT";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Migue;
        private System.Windows.Forms.Button btn_Dani;
    }
}

