namespace HolaMundoGit
{
    partial class VentanaJuan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaJuan));
            this.lbl_formularioJuan = new System.Windows.Forms.Label();
            this.pb_Juan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Juan)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_formularioJuan
            // 
            this.lbl_formularioJuan.AutoSize = true;
            this.lbl_formularioJuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formularioJuan.Location = new System.Drawing.Point(90, 9);
            this.lbl_formularioJuan.Name = "lbl_formularioJuan";
            this.lbl_formularioJuan.Size = new System.Drawing.Size(646, 69);
            this.lbl_formularioJuan.TabIndex = 0;
            this.lbl_formularioJuan.Text = "Hola, soy el único Juan";
            // 
            // pb_Juan
            // 
            this.pb_Juan.Image = ((System.Drawing.Image)(resources.GetObject("pb_Juan.Image")));
            this.pb_Juan.Location = new System.Drawing.Point(273, 119);
            this.pb_Juan.Name = "pb_Juan";
            this.pb_Juan.Size = new System.Drawing.Size(267, 308);
            this.pb_Juan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Juan.TabIndex = 1;
            this.pb_Juan.TabStop = false;
            // 
            // VentanaJuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_Juan);
            this.Controls.Add(this.lbl_formularioJuan);
            this.Name = "VentanaJuan";
            this.Text = "VentanaJuan";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Juan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_formularioJuan;
        private System.Windows.Forms.PictureBox pb_Juan;
    }
}