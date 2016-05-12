using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BLL
{
    public class ProduitBLL
    {
        public void addCatalogue(Produit prod)
        {
            Catalogue cat = new Catalogue();
            cat.LesProduits.Add(prod);
        }

        public void updateProduit(Produit prod)
        {

        }

        public void delProduit(Produit prod)
        {

        }
    }
}
