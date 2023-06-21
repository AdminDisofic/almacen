namespace HolaMundoGit
{
    partial class VentanaDani
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
            this.lbl_dani = new System.Windows.Forms.Label();
            this.btn_raro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_dani
            // 
            this.lbl_dani.AutoSize = true;
            this.lbl_dani.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dani.Location = new System.Drawing.Point(43, 143);
            this.lbl_dani.Name = "lbl_dani";
            this.lbl_dani.Size = new System.Drawing.Size(675, 46);
            this.lbl_dani.TabIndex = 0;
            this.lbl_dani.Text = "ESTAS EN LA VENTANA DE DANI!!";
            // 
            // btn_raro
            // 
            this.btn_raro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_raro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_raro.Location = new System.Drawing.Point(324, 351);
            this.btn_raro.Name = "btn_raro";
            this.btn_raro.Size = new System.Drawing.Size(77, 66);
            this.btn_raro.TabIndex = 1;
            this.btn_raro.Text = "??";
            this.btn_raro.UseVisualStyleBackColor = false;
            this.btn_raro.Click += new System.EventHandler(this.btn_raro_Click);
            // 
            // VentanaDani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_raro);
            this.Controls.Add(this.lbl_dani);
            this.Name = "VentanaDani";
            this.Text = "VentanaDani";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaDani_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dani;
        private System.Windows.Forms.Button btn_raro;
    }
}