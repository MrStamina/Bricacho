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
                            int id = dbRdr.GetInt32(0);
                            int cpu = dbRdr.GetInt32(1);
                            string nom = dbRdr.GetString(2);
                            string des = (!dbRdr.IsDBNull(3)) ? dbRdr.GetString(3) : string.Empty;
                            double pu = dbRdr.GetDouble(4);
                            Categorie_Produit catProd = new Categorie_Produit() { Id_Categorie = dbRdr.GetInt32(5) };

                            Produit prod = new Produit(id, cpu,nom,catProd,des,pu);
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
