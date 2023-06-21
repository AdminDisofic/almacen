namespace HolaMundoGit
{
    partial class Form_Esperanza
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
            this.lbl_Esperanza = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Esperanza
            // 
            this.lbl_Esperanza.AutoSize = true;
            this.lbl_Esperanza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Esperanza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Esperanza.Location = new System.Drawing.Point(218, 133);
            this.lbl_Esperanza.Name = "lbl_Esperanza";
            this.lbl_Esperanza.Size = new System.Drawing.Size(276, 24);
            this.lbl_Esperanza.TabIndex = 0;
            this.lbl_Esperanza.Text = "Nuevo formulario de Esperanza";
            // 
            // Form_Esperanza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Esperanza);
            this.Name = "Form_Esperanza";
            this.Text = "Form_Esperanza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Esperanza;
    }
}