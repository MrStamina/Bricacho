using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace IHM_Catalogue
{
    public partial class Form_Catalogue : Form
    {
        CatalogueManager catman;
       
        public Form_Catalogue()
        {
            InitializeComponent();
            catman = new CatalogueManager();
           
            lesProduitsBindingSource.DataSource = catman.ChargerCatalogue().LesProduits;
            categorieProduitBindingSource.DataSource = catman.ChargerLesCategorie();

           
            
        }

        private void buttonDisplayCat_Click(object sender, EventArgs e)
        {

            dataGridView1.Visible = true;
        }

        private void buttonCreateProduit_Click(object sender, EventArgs e)
        {
            //Form_Produit frmProd = new Form_Produit(cat);
            //frmProd.Show();
        }
    }
}
