using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Exceptions;

namespace IHM_Catalogue
{
    public partial class Form_Produit : Form
    {
        CatalogueManager cata;
        ProduitManager prodMan;
        public Form_Produit()
        {
            InitializeComponent();
        }
        public Form_Produit(CatalogueManager cat)
        {
            cata = cat;
            InitializeComponent();
            
            try
            {
                categorieProduitBindingSource.DataSource = cata.ChargerLesCategorie();
            }
            catch(DaoExceptionAfficheMessage deaf)
            {
                MessageBox.Show(deaf.Message);
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            comboBoxCatProd.SelectedItem = null;
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if(comboBoxCatProd.SelectedItem !=null)
            {
                int codeProduit = 0;
                prodMan = new ProduitManager();
                Produit prod = new Produit(codeProduit, Convert.ToInt32(textBoxCpu.Text), textBoxNomProd.Text, (Categorie_Produit)comboBoxCatProd.SelectedItem,
                    textBoxDescription_Prod.Text, Convert.ToDouble(textBoxPrix_Unitaire.Text));
                try
                {
                  codeProduit = prodMan.AddProduit(prod);
                  prod.IdProduit = codeProduit;
                }
                catch (DaoExceptionAfficheMessage def)
                {
                    MessageBox.Show(def.Message);
                }
                catch (Exception se)
                {
                    MessageBox.Show(se.Message);
                }
            }
             
        }

        private void buttonCreer_Click(object sender, EventArgs e)
        {
            GenerateBarcode genbar = new GenerateBarcode();
            genbar.Show();
        }

        private void initialisation()
        {

        }
    }
}
