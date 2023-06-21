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
            this.lbl_formularioJuan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_formularioJuan
            // 
            this.lbl_formularioJuan.AutoSize = true;
            this.lbl_formularioJuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formularioJuan.Location = new System.Drawing.Point(72, 150);
            this.lbl_formularioJuan.Name = "lbl_formularioJuan";
            this.lbl_formularioJuan.Size = new System.Drawing.Size(646, 69);
            this.lbl_formularioJuan.TabIndex = 0;
            this.lbl_formularioJuan.Text = "Hola, soy el único Juan";
            // 
            // VentanaJuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_formularioJuan);
            this.Name = "VentanaJuan";
            this.Text = "VentanaJuan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_formularioJuan;
    }
}