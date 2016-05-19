using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BLL
{
    public class ProduitManager
    {
        public bool AddProduit(Produit prod) 
        {
            ProduitDAL prodDal = new ProduitDAL();
            if (prodDal.AddProduit(prod))
                return true;
            else
                return false;
        }

        public bool updateProduit(Produit prod)
        {
            ProduitDAL prodDal = new ProduitDAL();
            if (prodDal.UpdProduit(prod))
                return true;
            else
                return false;

        }

        public bool delProduit(Produit prod)
        {
            ProduitDAL prodDal = new ProduitDAL();
            if (prodDal.DelProduit(prod))
                return true;
            else
                return false;
        }

    }
}
