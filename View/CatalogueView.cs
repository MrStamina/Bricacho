using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;


namespace View
{
   public class CatalogueView
    {
        public void afficherCatalogue()
        {
            Catalogue cat = new Catalogue();
            List<Produit> listProd = cat.LesProduits;
            foreach (Produit x in listProd)
            {
                Console.WriteLine(x);
            }
        }
    }
}
