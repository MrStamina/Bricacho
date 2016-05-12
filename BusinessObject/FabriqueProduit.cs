using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class FabriqueProduit 
    {
        public Produit CreerProduit(int cpu, string nom, string desc, double pu, int qte)
        {
            return new Produit( cpu, nom, desc, pu, qte);
        }
    }

