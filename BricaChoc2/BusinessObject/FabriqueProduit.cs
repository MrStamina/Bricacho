using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class FabriqueProduit 
    {
        public Produit CreerProduit(int cpu, Categorie_Produit cat, string nom, string desc, double pu)
        {
            return new Produit(  cpu,  nom, cat, desc, pu);
        }
    }

