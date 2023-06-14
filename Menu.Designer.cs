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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button1 = new System.Windows.Forms.Button();
            this.pb_Migue = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Migue)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pb_Migue
            // 
            this.pb_Migue.Image = ((System.Drawing.Image)(resources.GetObject("pb_Migue.Image")));
            this.pb_Migue.Location = new System.Drawing.Point(304, 179);
            this.pb_Migue.Name = "pb_Migue";
            this.pb_Migue.Size = new System.Drawing.Size(191, 119);
            this.pb_Migue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Migue.TabIndex = 1;
            this.pb_Migue.TabStop = false;
            this.pb_Migue.Click += new System.EventHandler(this.pb_Migue_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_Migue);
            this.Controls.Add(this.button1);
            this.Name = "Menu";
            this.Text = "Menu Hola Mundo GIT";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Migue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pb_Migue;
    }
}

