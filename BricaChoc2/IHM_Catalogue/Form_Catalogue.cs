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
    public partial class Form_Catalogue : Form
    {
        Catalogue cat = new Catalogue();
        public Form_Catalogue()
        {
            InitializeComponent();
           

        }

        private void buttonDisplayCat_Click(object sender, EventArgs e)
        {

            catalogueBindingSource.DataSource = cat.GetAllProduit();
            
        }

        private void buttonCreateProduit_Click(object sender, EventArgs e)
        {
            Form_Produit frmProd = new Form_Produit(cat);
            frmProd.Show();
        }
    }
}
