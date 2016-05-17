namespace IHM_Catalogue
{
    partial class GenerateBarcode
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
            this.buttonGenerer = new System.Windows.Forms.Button();
            this.textBoxTextaGenerer = new System.Windows.Forms.TextBox();
            this.pictureBoxCodeBarre = new System.Windows.Forms.PictureBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCodeBarre)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerer
            // 
            this.buttonGenerer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerer.Location = new System.Drawing.Point(292, 32);
            this.buttonGenerer.Name = "buttonGenerer";
            this.buttonGenerer.Size = new System.Drawing.Size(166, 60);
            this.buttonGenerer.TabIndex = 0;
            this.buttonGenerer.Text = "Generer";
            this.buttonGenerer.UseVisualStyleBackColor = true;
            this.buttonGenerer.Click += new System.EventHandler(this.buttonGenerer_Click);
            // 
            // textBoxTextaGenerer
            // 
            this.textBoxTextaGenerer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTextaGenerer.Location = new System.Drawing.Point(37, 49);
            this.textBoxTextaGenerer.Name = "textBoxTextaGenerer";
            this.textBoxTextaGenerer.Size = new System.Drawing.Size(249, 29);
            this.textBoxTextaGenerer.TabIndex = 1;
            this.textBoxTextaGenerer.TextChanged += new System.EventHandler(this.textBoxTextaGenerer_TextChanged);
            // 
            // pictureBoxCodeBarre
            // 
            this.pictureBoxCodeBarre.Location = new System.Drawing.Point(45, 146);
            this.pictureBoxCodeBarre.Name = "pictureBoxCodeBarre";
            this.pictureBoxCodeBarre.Size = new System.Drawing.Size(366, 85);
            this.pictureBoxCodeBarre.TabIndex = 2;
            this.pictureBoxCodeBarre.TabStop = false;
            // 
            // GenerateBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 321);
            this.Controls.Add(this.pictureBoxCodeBarre);
            this.Controls.Add(this.textBoxTextaGenerer);
            this.Controls.Add(this.buttonGenerer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "GenerateBarcode";
            this.Text = "GenerateBarcode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCodeBarre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerer;
        private System.Windows.Forms.TextBox textBoxTextaGenerer;
        private System.Windows.Forms.PictureBox pictureBoxCodeBarre;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}