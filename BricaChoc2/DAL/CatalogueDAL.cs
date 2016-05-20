using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using DAL.Exceptions;

namespace DAL
{
    public class CatalogueDAL
    {
        public  Catalogue  GetAllProduits()
        {
            //plop
            Catalogue cat = new Catalogue();
            using (DbConnection oConnection = Connection.GetConnectionMySQL())
            {
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = "SELECT * FROM bricachoc.produit";

                    try
                    {
                        DbDataReader dbRdr = oCommand.ExecuteReader();
                        while (dbRdr.Read())
                        {
                            
                            int cpu = dbRdr.GetInt32(0);
                            string nom = dbRdr.GetString(1);
                            string des = (!dbRdr.IsDBNull(2)) ? dbRdr.GetString(2) : string.Empty;
                            double pu = dbRdr.GetDouble(3);
                            Categorie_Produit catProd = new Categorie_Produit() { Id_Categorie = dbRdr.GetInt32(4) };

                            Produit prod = new Produit(cpu,nom,catProd,des,pu);
                            cat.LesProduits.Add(prod); 

                        }
                        dbRdr.Close();
                        return cat;
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
