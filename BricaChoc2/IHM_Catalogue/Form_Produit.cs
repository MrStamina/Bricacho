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
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Drawing.Text;
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
            initialisation();
            
           
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if(comboBoxCatProd.SelectedItem !=null)
            {
                
                prodMan = new ProduitManager();
                Produit prod = new Produit(Convert.ToInt32(textBoxCpu.Text), textBoxNomProd.Text, (Categorie_Produit)comboBoxCatProd.SelectedItem,
                    textBoxDescription_Prod.Text, Convert.ToDouble(textBoxPrix_Unitaire.Text));
                try
                {
                   if(prodMan.AddProduit(prod) == true)
                    {
                        MessageBox.Show("Le produit a été ajouté");
                    }
                 
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
            string barcode = textBoxCpu.Text;
            Bitmap bitmap = new Bitmap(barcode.Length * 30, 150);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Font oFont = new System.Drawing.Font("Code EAN13", 60);
                PointF point = new PointF(2f, 2f);
                SolidBrush black = new SolidBrush(Color.Black);
                SolidBrush white = new SolidBrush(Color.White);
                graphics.FillRectangle(white, 0, 0, bitmap.Width, bitmap.Height);
                graphics.DrawString("*" + barcode + "*", oFont, black, point);

            }
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);
                pictureBoxCodeBarre.Image = bitmap;
                pictureBoxCodeBarre.Height = bitmap.Height;
                pictureBoxCodeBarre.Width = bitmap.Width;
            }
        }

        private void initialisation()
        {
            try
            {
                categorieProduitBindingSource.DataSource = cata.ChargerLesCategorie();
            }
            catch (DaoExceptionAfficheMessage deaf)
            {
                MessageBox.Show(deaf.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            comboBoxCatProd.SelectedItem = null;
        }
    }
}
