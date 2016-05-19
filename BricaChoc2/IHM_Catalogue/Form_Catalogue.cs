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
using DAL.Exceptions;


namespace IHM_Catalogue
{
    public partial class Form_Catalogue : Form
    {
        CatalogueManager catman;
       
        public Form_Catalogue()
        {
            initialisation();           
            
        }

        private void buttonDisplayCat_Click(object sender, EventArgs e)
        {

            dataGridView1.Visible = true;
        }

        private void buttonCreateProduit_Click(object sender, EventArgs e)
        {
            Form_Produit frmProd = new Form_Produit(catman);
            frmProd.Show();
        }

        private void initialisation()
        {
            InitializeComponent();
            catman = new CatalogueManager();
            try
            {
                lesProduitsBindingSource.DataSource = catman.ChargerCatalogue().LesProduits;
                categorieProduitBindingSource.DataSource = catman.ChargerLesCategorie();
            }
            catch (DaoExceptionAfficheMessage deaf)
            {
                MessageBox.Show(deaf.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonCpu_CheckedChanged(object sender, EventArgs e)
        {
            buttonRechercher.Visible = true;
            textBoxRecherche.Visible = true;
            
            
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            Produit prod = new Produit();
            prod = catman.RechercherProduitbyCpu(Convert.ToInt32(textBoxRecherche.Text));
            dataGridView1.Visible = true;
            lesProduitsBindingSource.DataSource = prod;
            
        }
    }


}
