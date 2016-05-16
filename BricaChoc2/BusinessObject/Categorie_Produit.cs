using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class Categorie_Produit
    {
        public int Id_Categorie { get; set; }
        public string Nom_Categorie { get; set; }
        public Categorie_Produit(int id, string libelle)
         {
        this.Id_Categorie = id;
        this.Nom_Categorie = libelle;
         }
    public Categorie_Produit()
    {

    }
    public override bool Equals(Object obj)
    {

        return obj is Categorie_Produit && Id_Categorie == ((Categorie_Produit)obj).Id_Categorie;
    }
    public Categorie_Produit Self
    {
        get { return this; }
    }

    public override string ToString()
    {
        return base.ToString();
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}

