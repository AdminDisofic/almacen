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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Esperanza));
            this.label1 = new System.Windows.Forms.Label();
            this.Picture_Box_Esperanza = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Box_Esperanza)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(488, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo formulario Esperanza";
            // 
            // Picture_Box_Esperanza
            // 
            this.Picture_Box_Esperanza.Image = ((System.Drawing.Image)(resources.GetObject("Picture_Box_Esperanza.Image")));
            this.Picture_Box_Esperanza.Location = new System.Drawing.Point(493, 238);
            this.Picture_Box_Esperanza.Name = "Picture_Box_Esperanza";
            this.Picture_Box_Esperanza.Size = new System.Drawing.Size(285, 178);
            this.Picture_Box_Esperanza.TabIndex = 1;
            this.Picture_Box_Esperanza.TabStop = false;
            // 
            // Form_Esperanza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 969);
            this.Controls.Add(this.Picture_Box_Esperanza);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form_Esperanza";
            this.Text = "Form_Esperanza";
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Box_Esperanza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Picture_Box_Esperanza;
    }
}