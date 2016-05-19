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
        Catalogue cat;
       
        public Form_Catalogue()
        {
            initialisation();           
            
        }

        private void buttonDisplayCat_Click(object sender, EventArgs e)
        {
            lesProduitsBindingSource.DataSource = null;            
            lesProduitsBindingSource.DataSource = cat.LesProduits;
            dataGridView1.Refresh();            
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
            cat = new Catalogue();
            
            
            try
            {
                cat = catman.ChargerCatalogue();                
                lesProduitsBindingSource.DataSource = cat.LesProduits;
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

        

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            Produit prod = new Produit();
            List<Produit> listprod = new List<Produit>();
            if (radioButtonCpu.Checked)
            {
                prod = catman.RechercherProduitbyCpu(Convert.ToInt32(textBoxRecherche.Text));
                lesProduitsBindingSource.DataSource = prod;
            }
            else if (radioButtonNom.Checked)
            {
                prod = catman.RechercherProduitByName(textBoxRecherche.Text);
                lesProduitsBindingSource.DataSource = prod;
            }
                
            else if (radioButtonPrix.Checked)
            {
                listprod = catman.RechercherProduitByPrix(Convert.ToDouble(textBoxRecherche.Text));
                lesProduitsBindingSource.DataSource = listprod;
            }                
            else if(radioButtonCat.Checked)
            {
                listprod = catman.RechercherProduitByCategorie((Categorie_Produit)comboBoxCategorie.SelectedItem);
                lesProduitsBindingSource.DataSource = listprod;
            }

                dataGridView1.Visible = true;
            
            
        }

        private void radioButtonCpu_CheckedChanged(object sender, EventArgs e)
        {
            buttonRechercher.Visible = true;
            textBoxRecherche.Visible = true;


        }

        private void radioButtonNom_CheckedChanged(object sender, EventArgs e)
        {
            buttonRechercher.Visible = true;
            textBoxRecherche.Visible = true;
        }

        private void radioButtonPrix_CheckedChanged(object sender, EventArgs e)
        {
            buttonRechercher.Visible = true;
            textBoxRecherche.Visible = true;
        }

        private void radioButtonCat_CheckedChanged(object sender, EventArgs e)
        {
            buttonRechercher.Visible = true;
            comboBoxCategorie.Visible = true;
            textBoxRecherche.Visible = false;
            comboBoxCategorie.SelectedItem = null;
        }
    }


}
