using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHM_Catalogue
{
    public partial class Form_Produit : Form
    {
        Catalogue cata;
        public Form_Produit()
        {
            InitializeComponent();
        }
        public Form_Produit(Catalogue cat)
        {
            cata = cat;
            InitializeComponent();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            
            //Random randCpu = new Random();
            //FabriqueProduit fabProd = new FabriqueProduit();

            //cata.addProduit(fabProd.CreerProduit(randCpu.Next(99), textBoxNomProd.Text, textBoxDescription_Prod.Text, Convert.ToDouble(textBoxPrix_Unitaire.Text), Convert.ToInt32(numericUpDownQuantite.Value)));
            //this.Close();            
        }
    }
}
