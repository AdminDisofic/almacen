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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Maryure));
            this.lbl_Maryure = new System.Windows.Forms.Label();
            this.pic_Maryure = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Maryure)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Maryure
            // 
            this.lbl_Maryure.AutoSize = true;
            this.lbl_Maryure.BackColor = System.Drawing.Color.White;
            this.lbl_Maryure.Location = new System.Drawing.Point(75, 65);
            this.lbl_Maryure.Name = "lbl_Maryure";
            this.lbl_Maryure.Size = new System.Drawing.Size(111, 13);
            this.lbl_Maryure.TabIndex = 0;
            this.lbl_Maryure.Text = "Formulario de Maryure";
            // 
            // pic_Maryure
            // 
            this.pic_Maryure.Image = ((System.Drawing.Image)(resources.GetObject("pic_Maryure.Image")));
            this.pic_Maryure.Location = new System.Drawing.Point(247, 70);
            this.pic_Maryure.Name = "pic_Maryure";
            this.pic_Maryure.Size = new System.Drawing.Size(294, 208);
            this.pic_Maryure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Maryure.TabIndex = 1;
            this.pic_Maryure.TabStop = false;
            // 
            // Form_Maryure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pic_Maryure);
            this.Controls.Add(this.lbl_Maryure);
            this.Name = "Form_Maryure";
            this.Text = "Form_Maryure";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Maryure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Maryure;
        private System.Windows.Forms.PictureBox pic_Maryure;
    }
}