using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using DAL.Exceptions;

namespace DAL
{
   public class Categorie_ProduitDAL
    {
        public List<Categorie_Produit> GetAllCategorie()
        {
            using (DbConnection oConnection = Connection.GetConnectionMySQL())
            {
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = "SELECT * FROM bricachoc.categorieproduit";
                    try
                    {
                        DbDataReader dbRdr = oCommand.ExecuteReader();
                        List<Categorie_Produit> listCatProd = new List<Categorie_Produit>();
                        while(dbRdr.Read())
                        {
                            
                            int idCat = dbRdr.GetInt32(0);
                            string libelleCat = dbRdr.GetString(1);
                            Categorie_Produit catprod = new Categorie_Produit(idCat,libelleCat);
                            listCatProd.Add(catprod);
                        }
                        dbRdr.Close();
                        return listCatProd;
                    }
                    catch (DbException de)
                    {
                        throw new DaoExceptionAfficheMessage
                             ("Une erreur s'est produite sur la base : \n" + de.Message, de);
                    }
                }
            }
                
           
       
        }
    }
}
