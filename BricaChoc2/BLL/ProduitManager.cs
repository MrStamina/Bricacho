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
        public int AddProduit(Produit prod) 
        {
            ProduitDAL prodDal = new ProduitDAL();
            return prodDal.AddProduit(prod);
        }

        public void updateProduit(Produit prod)
        {

        }

        public void delProduit(Produit prod)
        {

        }

    }
}
