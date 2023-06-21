namespace HolaMundoGit
{
    partial class Form_Maryure
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
            this.lbl_frmMaryure = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_frmMaryure
            // 
            this.lbl_frmMaryure.AutoSize = true;
            this.lbl_frmMaryure.Location = new System.Drawing.Point(153, 104);
            this.lbl_frmMaryure.Name = "lbl_frmMaryure";
            this.lbl_frmMaryure.Size = new System.Drawing.Size(111, 13);
            this.lbl_frmMaryure.TabIndex = 0;
            this.lbl_frmMaryure.Text = "Formulario de Maryure";
            // 
            // Form_Maryure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_frmMaryure);
            this.Name = "Form_Maryure";
            this.Text = "Form_Maryure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_frmMaryure;
    }
}