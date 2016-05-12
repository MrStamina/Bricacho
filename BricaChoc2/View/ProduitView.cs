using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
     public class ProduitView
    {
         public void createProduit()
        {
            //Saisie d'un CPU
            Console.WriteLine("Saisir CPU : ");
            int cpu = int.Parse(Console.ReadLine());

            //Saisie d'un nom

            Console.WriteLine("Saisir le nom du produit : ");
            string nom_Prod = Console.ReadLine();

            //Description,

            Console.WriteLine("Saisir une description :");
            string desc_Prod = Console.ReadLine();

            // Prix unitaire
            Console.WriteLine("Saisir Prix unitaire :");
            double pu = double.Parse(Console.ReadLine());

            //Quantité

            Console.WriteLine("Saisir Quantité");
            int qte_Prod = int.Parse(Console.ReadLine());

            Produit prod = new Produit();
            prod.Cpu = cpu;
            prod.Nom_Produit = nom_Prod;
            prod.Description = desc_Prod;
            prod.Prix_Unitaire = pu;
            prod.Quantite = qte_Prod;

            ProduitBLL prodBll = new ProduitBLL();
            prodBll.addCatalogue(prod);
        }
    }
}
