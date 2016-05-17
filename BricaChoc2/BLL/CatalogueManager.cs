using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class CatalogueManager
    {
        public Catalogue ChargerCatalogue()
        {
            CatalogueDAL catDal = new CatalogueDAL();
            Catalogue cat = catDal.GetAllProduits();
            return cat;

        }

        public List<Categorie_Produit> ChargerLesCategorie()
        {
            Categorie_ProduitDAL catProdDal = new Categorie_ProduitDAL();
            List<Categorie_Produit> listCatProd = catProdDal.GetAllCategorie();
            return listCatProd;
        }

        public void RechercherProduit(int idProduit)
        {

        }

    }
}
