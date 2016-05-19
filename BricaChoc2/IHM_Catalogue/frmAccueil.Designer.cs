namespace IHM_Catalogue
{
    partial class frmAccueil
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidentifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initialiserLaCaisseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initialiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.géreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterCatalogueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.initialiserLaCaisseToolStripMenuItem,
            this.géreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sidentifierToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.connexionToolStripMenuItem.Text = "Connexion";
            // 
            // sidentifierToolStripMenuItem
            // 
            this.sidentifierToolStripMenuItem.Name = "sidentifierToolStripMenuItem";
            this.sidentifierToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sidentifierToolStripMenuItem.Text = "S\'identifier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // initialiserLaCaisseToolStripMenuItem
            // 
            this.initialiserLaCaisseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initialiserToolStripMenuItem});
            this.initialiserLaCaisseToolStripMenuItem.Name = "initialiserLaCaisseToolStripMenuItem";
            this.initialiserLaCaisseToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.initialiserLaCaisseToolStripMenuItem.Text = "Démarrer Caisse";
            // 
            // initialiserToolStripMenuItem
            // 
            this.initialiserToolStripMenuItem.Name = "initialiserToolStripMenuItem";
            this.initialiserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.initialiserToolStripMenuItem.Text = "Initialiser";
            // 
            // géreToolStripMenuItem
            // 
            this.géreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterCatalogueToolStripMenuItem,
            this.gérerLesProduitsToolStripMenuItem});
            this.géreToolStripMenuItem.Name = "géreToolStripMenuItem";
            this.géreToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.géreToolStripMenuItem.Text = "Gestion Catalogue";
            // 
            // consulterCatalogueToolStripMenuItem
            // 
            this.consulterCatalogueToolStripMenuItem.Name = "consulterCatalogueToolStripMenuItem";
            this.consulterCatalogueToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.consulterCatalogueToolStripMenuItem.Text = "Consulter Catalogue";
            // 
            // gérerLesProduitsToolStripMenuItem
            // 
            this.gérerLesProduitsToolStripMenuItem.Name = "gérerLesProduitsToolStripMenuItem";
            this.gérerLesProduitsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.gérerLesProduitsToolStripMenuItem.Text = "Gérer les Produits";
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 377);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAccueil";
            this.Text = "Acceuil Caisse";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sidentifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initialiserLaCaisseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initialiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem géreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterCatalogueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesProduitsToolStripMenuItem;
    }
}