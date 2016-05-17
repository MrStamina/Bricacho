namespace IHM_Catalogue
{
    partial class Form_Produit
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
            this.components = new System.ComponentModel.Container();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.textBoxNomProd = new System.Windows.Forms.TextBox();
            this.comboBoxCatProd = new System.Windows.Forms.ComboBox();
            this.textBoxDescription_Prod = new System.Windows.Forms.TextBox();
            this.textBoxPrix_Unitaire = new System.Windows.Forms.TextBox();
            this.labelNom_Prod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.categorieProduitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxCpu = new System.Windows.Forms.TextBox();
            this.labelCpu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categorieProduitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(274, 112);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 0;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(274, 159);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(75, 23);
            this.buttonModifier.TabIndex = 1;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            // 
            // buttonCreer
            // 
            this.buttonCreer.Location = new System.Drawing.Point(274, 208);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(100, 23);
            this.buttonCreer.TabIndex = 2;
            this.buttonCreer.Text = "Creer Code Barre";
            this.buttonCreer.UseVisualStyleBackColor = true;
            this.buttonCreer.Click += new System.EventHandler(this.buttonCreer_Click);
            // 
            // textBoxNomProd
            // 
            this.textBoxNomProd.Location = new System.Drawing.Point(108, 46);
            this.textBoxNomProd.MaxLength = 30;
            this.textBoxNomProd.Name = "textBoxNomProd";
            this.textBoxNomProd.Size = new System.Drawing.Size(121, 20);
            this.textBoxNomProd.TabIndex = 3;
            // 
            // comboBoxCatProd
            // 
            this.comboBoxCatProd.DataSource = this.categorieProduitBindingSource;
            this.comboBoxCatProd.DisplayMember = "Nom_Categorie";
            this.comboBoxCatProd.FormattingEnabled = true;
            this.comboBoxCatProd.Location = new System.Drawing.Point(108, 159);
            this.comboBoxCatProd.Name = "comboBoxCatProd";
            this.comboBoxCatProd.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCatProd.TabIndex = 4;
            // 
            // textBoxDescription_Prod
            // 
            this.textBoxDescription_Prod.Location = new System.Drawing.Point(108, 213);
            this.textBoxDescription_Prod.MaxLength = 250;
            this.textBoxDescription_Prod.Multiline = true;
            this.textBoxDescription_Prod.Name = "textBoxDescription_Prod";
            this.textBoxDescription_Prod.Size = new System.Drawing.Size(121, 58);
            this.textBoxDescription_Prod.TabIndex = 5;
            // 
            // textBoxPrix_Unitaire
            // 
            this.textBoxPrix_Unitaire.Location = new System.Drawing.Point(108, 309);
            this.textBoxPrix_Unitaire.Name = "textBoxPrix_Unitaire";
            this.textBoxPrix_Unitaire.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrix_Unitaire.TabIndex = 6;
            // 
            // labelNom_Prod
            // 
            this.labelNom_Prod.AutoSize = true;
            this.labelNom_Prod.Location = new System.Drawing.Point(12, 49);
            this.labelNom_Prod.Name = "labelNom_Prod";
            this.labelNom_Prod.Size = new System.Drawing.Size(65, 13);
            this.labelNom_Prod.TabIndex = 8;
            this.labelNom_Prod.Text = "Nom Produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Categorie Produit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Prix unitaire";
            // 
            // categorieProduitBindingSource
            // 
            this.categorieProduitBindingSource.DataSource = typeof(Categorie_Produit);
            // 
            // textBoxCpu
            // 
            this.textBoxCpu.Location = new System.Drawing.Point(108, 98);
            this.textBoxCpu.MaxLength = 30;
            this.textBoxCpu.Name = "textBoxCpu";
            this.textBoxCpu.Size = new System.Drawing.Size(121, 20);
            this.textBoxCpu.TabIndex = 12;
            // 
            // labelCpu
            // 
            this.labelCpu.AutoSize = true;
            this.labelCpu.Location = new System.Drawing.Point(13, 104);
            this.labelCpu.Name = "labelCpu";
            this.labelCpu.Size = new System.Drawing.Size(26, 13);
            this.labelCpu.TabIndex = 13;
            this.labelCpu.Text = "Cpu";
            // 
            // Form_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 418);
            this.Controls.Add(this.labelCpu);
            this.Controls.Add(this.textBoxCpu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNom_Prod);
            this.Controls.Add(this.textBoxPrix_Unitaire);
            this.Controls.Add(this.textBoxDescription_Prod);
            this.Controls.Add(this.comboBoxCatProd);
            this.Controls.Add(this.textBoxNomProd);
            this.Controls.Add(this.buttonCreer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonValider);
            this.Name = "Form_Produit";
            this.Text = "Form_Produit";
            ((System.ComponentModel.ISupportInitialize)(this.categorieProduitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.TextBox textBoxNomProd;
        private System.Windows.Forms.ComboBox comboBoxCatProd;
        private System.Windows.Forms.TextBox textBoxDescription_Prod;
        private System.Windows.Forms.TextBox textBoxPrix_Unitaire;
        private System.Windows.Forms.Label labelNom_Prod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource categorieProduitBindingSource;
        private System.Windows.Forms.TextBox textBoxCpu;
        private System.Windows.Forms.Label labelCpu;
    }
}