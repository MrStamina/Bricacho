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
        CatalogueDAL catDal = new CatalogueDAL();
        Catalogue cat = new Catalogue();
        public Catalogue ChargerCatalogue()
        {
            
            cat = catDal.GetAllProduits();
            return cat;

        }

        public List<Categorie_Produit> ChargerLesCategorie()
        {
            Categorie_ProduitDAL catProdDal = new Categorie_ProduitDAL();
            List<Categorie_Produit> listCatProd = catProdDal.GetAllCategorie();
            return listCatProd;
        }

        public Produit RechercherProduitbyCpu(int cpu)
        {
            Produit prod = cat.LesProduits.First(a => a.Cpu == cpu);
            return prod;
        }

        public Produit RechercherProduitByName(string nom)
        {
            Produit prod = cat.LesProduits.First(a => a.Nom_Produit == nom);
            return prod;
        }
    }
}
