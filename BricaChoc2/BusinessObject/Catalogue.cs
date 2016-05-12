using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public  class Catalogue
  {
        public Catalogue()
        {
            lesProduits = new List<Produit>();
        }

        List<Produit> lesProduits;

        public List<Produit> LesProduits
        {
            get { return lesProduits; }
        }

        public  List<Produit> GetAllProduit()
        {
            List<Produit> listprod = new List<Produit>();
            listprod = LesProduits;
            return listprod;

        }

        public void addProduit(Produit prod)
        {
            LesProduits.Add(prod);
           
        }
        
        public void exempleProd()
        {
            FabriqueProduit fabprod = new FabriqueProduit();
            addProduit(fabprod.CreerProduit(125789, "Camembert", "portion 250g", 1.78, 152));
            addProduit(fabprod.CreerProduit(125788, "Comté", "portion 250g", 3.78, 52));
            addProduit(fabprod.CreerProduit(125787, "Roquefort", "portion 250g", 2.8, 72));
        }

       
        //public void afficherCatalogue()
        //{      
        //    foreach (Produit prod in lesProduits)
        //    {
        //        Console.WriteLine(prod);
        //    }
        //}

        public void delProduit(Produit prod)
        {
            lesProduits.Remove(prod);

        }
    }

