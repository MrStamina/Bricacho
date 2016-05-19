namespace IHM_Catalogue
{
    partial class Form_Catalogue
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonCreateProduit = new System.Windows.Forms.Button();
            this.buttonDisplayCat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cpuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categorieProduitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixUnitaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lesProduitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalogueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxRechercheProduit = new System.Windows.Forms.GroupBox();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.radioButtonCpu = new System.Windows.Forms.RadioButton();
            this.radioButtonNom = new System.Windows.Forms.RadioButton();
            this.radioButtonCat = new System.Windows.Forms.RadioButton();
            this.radioButtonPrix = new System.Windows.Forms.RadioButton();
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieProduitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesProduitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogueBindingSource)).BeginInit();
            this.groupBoxRechercheProduit.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreateProduit
            // 
            this.buttonCreateProduit.Location = new System.Drawing.Point(483, 27);
            this.buttonCreateProduit.Name = "buttonCreateProduit";
            this.buttonCreateProduit.Size = new System.Drawing.Size(133, 25);
            this.buttonCreateProduit.TabIndex = 0;
            this.buttonCreateProduit.Text = "Ajouter Produit";
            this.buttonCreateProduit.UseVisualStyleBackColor = true;
            this.buttonCreateProduit.Click += new System.EventHandler(this.buttonCreateProduit_Click);
            // 
            // buttonDisplayCat
            // 
            this.buttonDisplayCat.Location = new System.Drawing.Point(483, 71);
            this.buttonDisplayCat.Name = "buttonDisplayCat";
            this.buttonDisplayCat.Size = new System.Drawing.Size(133, 25);
            this.buttonDisplayCat.TabIndex = 2;
            this.buttonDisplayCat.Text = "AfficherCatalogue";
            this.buttonDisplayCat.UseVisualStyleBackColor = true;
            this.buttonDisplayCat.Click += new System.EventHandler(this.buttonDisplayCat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cpuDataGridViewTextBoxColumn,
            this.nomProduitDataGridViewTextBoxColumn,
            this.categorieDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.prixUnitaireDataGridViewTextBoxColumn,
            this.Modifier,
            this.Supprimer});
            this.dataGridView1.DataSource = this.lesProduitsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 173);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Name = "Modifier";
            this.Modifier.ReadOnly = true;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseColumnTextForButtonValue = true;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.ReadOnly = true;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // cpuDataGridViewTextBoxColumn
            // 
            this.cpuDataGridViewTextBoxColumn.DataPropertyName = "Cpu";
            this.cpuDataGridViewTextBoxColumn.HeaderText = "Cpu";
            this.cpuDataGridViewTextBoxColumn.Name = "cpuDataGridViewTextBoxColumn";
            this.cpuDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpuDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomProduitDataGridViewTextBoxColumn
            // 
            this.nomProduitDataGridViewTextBoxColumn.DataPropertyName = "Nom_Produit";
            this.nomProduitDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomProduitDataGridViewTextBoxColumn.Name = "nomProduitDataGridViewTextBoxColumn";
            this.nomProduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categorieDataGridViewTextBoxColumn
            // 
            this.categorieDataGridViewTextBoxColumn.DataPropertyName = "Categorie";
            this.categorieDataGridViewTextBoxColumn.DataSource = this.categorieProduitBindingSource;
            this.categorieDataGridViewTextBoxColumn.DisplayMember = "Nom_Categorie";
            this.categorieDataGridViewTextBoxColumn.HeaderText = "Categorie";
            this.categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            this.categorieDataGridViewTextBoxColumn.ReadOnly = true;
            this.categorieDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categorieDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.categorieDataGridViewTextBoxColumn.ValueMember = "Self";
            // 
            // categorieProduitBindingSource
            // 
            this.categorieProduitBindingSource.DataSource = typeof(Categorie_Produit);
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixUnitaireDataGridViewTextBoxColumn
            // 
            this.prixUnitaireDataGridViewTextBoxColumn.DataPropertyName = "Prix_Unitaire";
            this.prixUnitaireDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixUnitaireDataGridViewTextBoxColumn.Name = "prixUnitaireDataGridViewTextBoxColumn";
            this.prixUnitaireDataGridViewTextBoxColumn.ReadOnly = true;
            this.prixUnitaireDataGridViewTextBoxColumn.Width = 50;
            // 
            // lesProduitsBindingSource
            // 
            this.lesProduitsBindingSource.DataMember = "LesProduits";
            this.lesProduitsBindingSource.DataSource = this.catalogueBindingSource;
            // 
            // catalogueBindingSource
            // 
            this.catalogueBindingSource.DataSource = typeof(Catalogue);
            // 
            // groupBoxRechercheProduit
            // 
            this.groupBoxRechercheProduit.Controls.Add(this.comboBoxCategorie);
            this.groupBoxRechercheProduit.Controls.Add(this.radioButtonPrix);
            this.groupBoxRechercheProduit.Controls.Add(this.radioButtonCat);
            this.groupBoxRechercheProduit.Controls.Add(this.radioButtonNom);
            this.groupBoxRechercheProduit.Controls.Add(this.radioButtonCpu);
            this.groupBoxRechercheProduit.Controls.Add(this.buttonRechercher);
            this.groupBoxRechercheProduit.Controls.Add(this.textBoxRecherche);
            this.groupBoxRechercheProduit.Location = new System.Drawing.Point(21, 16);
            this.groupBoxRechercheProduit.Name = "groupBoxRechercheProduit";
            this.groupBoxRechercheProduit.Size = new System.Drawing.Size(310, 135);
            this.groupBoxRechercheProduit.TabIndex = 6;
            this.groupBoxRechercheProduit.TabStop = false;
            this.groupBoxRechercheProduit.Text = "Recherche de produit";
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Location = new System.Drawing.Point(172, 46);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(132, 20);
            this.textBoxRecherche.TabIndex = 1;
            this.textBoxRecherche.Visible = false;
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(191, 17);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(97, 23);
            this.buttonRechercher.TabIndex = 7;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Visible = false;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // radioButtonCpu
            // 
            this.radioButtonCpu.AutoSize = true;
            this.radioButtonCpu.Location = new System.Drawing.Point(15, 36);
            this.radioButtonCpu.Name = "radioButtonCpu";
            this.radioButtonCpu.Size = new System.Drawing.Size(63, 17);
            this.radioButtonCpu.TabIndex = 8;
            this.radioButtonCpu.TabStop = true;
            this.radioButtonCpu.Text = "Par Cpu";
            this.radioButtonCpu.UseVisualStyleBackColor = true;
            this.radioButtonCpu.CheckedChanged += new System.EventHandler(this.radioButtonCpu_CheckedChanged);
            // 
            // radioButtonNom
            // 
            this.radioButtonNom.AutoSize = true;
            this.radioButtonNom.Location = new System.Drawing.Point(15, 59);
            this.radioButtonNom.Name = "radioButtonNom";
            this.radioButtonNom.Size = new System.Drawing.Size(66, 17);
            this.radioButtonNom.TabIndex = 9;
            this.radioButtonNom.TabStop = true;
            this.radioButtonNom.Text = "Par Nom";
            this.radioButtonNom.UseVisualStyleBackColor = true;
            this.radioButtonNom.CheckedChanged += new System.EventHandler(this.radioButtonNom_CheckedChanged);
            // 
            // radioButtonCat
            // 
            this.radioButtonCat.AutoSize = true;
            this.radioButtonCat.Location = new System.Drawing.Point(15, 82);
            this.radioButtonCat.Name = "radioButtonCat";
            this.radioButtonCat.Size = new System.Drawing.Size(89, 17);
            this.radioButtonCat.TabIndex = 10;
            this.radioButtonCat.TabStop = true;
            this.radioButtonCat.Text = "Par Categorie";
            this.radioButtonCat.UseVisualStyleBackColor = true;
            this.radioButtonCat.CheckedChanged += new System.EventHandler(this.radioButtonCat_CheckedChanged);
            // 
            // radioButtonPrix
            // 
            this.radioButtonPrix.AutoSize = true;
            this.radioButtonPrix.Location = new System.Drawing.Point(15, 105);
            this.radioButtonPrix.Name = "radioButtonPrix";
            this.radioButtonPrix.Size = new System.Drawing.Size(61, 17);
            this.radioButtonPrix.TabIndex = 11;
            this.radioButtonPrix.TabStop = true;
            this.radioButtonPrix.Text = "Par Prix";
            this.radioButtonPrix.UseVisualStyleBackColor = true;
            this.radioButtonPrix.CheckedChanged += new System.EventHandler(this.radioButtonPrix_CheckedChanged);
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.DataSource = this.categorieProduitBindingSource;
            this.comboBoxCategorie.DisplayMember = "Nom_Categorie";
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.Location = new System.Drawing.Point(172, 78);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(132, 21);
            this.comboBoxCategorie.TabIndex = 12;
            this.comboBoxCategorie.Visible = false;
            // 
            // Form_Catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 379);
            this.Controls.Add(this.groupBoxRechercheProduit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDisplayCat);
            this.Controls.Add(this.buttonCreateProduit);
            this.Name = "Form_Catalogue";
            this.Text = "Catalogue";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieProduitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesProduitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogueBindingSource)).EndInit();
            this.groupBoxRechercheProduit.ResumeLayout(false);
            this.groupBoxRechercheProduit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateProduit;
        private System.Windows.Forms.Button buttonDisplayCat;
        private System.Windows.Forms.DataGridView dataGridView1;
     
        private System.Windows.Forms.BindingSource lesProduitsBindingSource;
        private System.Windows.Forms.BindingSource catalogueBindingSource;
        private System.Windows.Forms.BindingSource categorieProduitBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn categorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixUnitaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.GroupBox groupBoxRechercheProduit;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.RadioButton radioButtonPrix;
        private System.Windows.Forms.RadioButton radioButtonCat;
        private System.Windows.Forms.RadioButton radioButtonNom;
        private System.Windows.Forms.RadioButton radioButtonCpu;
        private System.Windows.Forms.ComboBox comboBoxCategorie;
    }
}

