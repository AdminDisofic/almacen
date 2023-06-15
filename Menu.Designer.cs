namespace HolaMundoGit
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
            this.btn_Cris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Cris
            // 
            this.btn_Cris.Location = new System.Drawing.Point(49, 322);
            this.btn_Cris.Name = "btn_Cris";
            this.btn_Cris.Size = new System.Drawing.Size(163, 90);
            this.btn_Cris.TabIndex = 0;
            this.btn_Cris.Text = "Botón Cristina";
            this.btn_Cris.UseVisualStyleBackColor = true;
            this.btn_Cris.Click += new System.EventHandler(this.btn_Cris_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cris);
            this.Name = "Menu";
            this.Text = "Menu Hola Mundo GIT";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cris;
    }
}

