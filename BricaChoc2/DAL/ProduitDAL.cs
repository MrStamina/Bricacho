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
    public class ProduitDAL
    {
        public int AddProduit(Produit prod)
        {

            using (DbConnection oConnection = Connection.GetConnectionMySQL())
            {
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = "add_produit";
                    oCommand.CommandType = CommandType.StoredProcedure;
                    oCommand.Parameters.Clear();
                    AffectParam(prod, oCommand);
                    DbParameter dbp = oCommand.CreateParameter();
                    dbp.DbType = DbType.Int32;
                    dbp.Direction = ParameterDirection.Output;
                    oCommand.Parameters.Add(dbp);
                    
                    try
                    {
                        int n = oCommand.ExecuteNonQuery();
                        if (n != 1)
                            throw new DaoExceptionAfficheMessage
                                ("L'opération d'insertion n'a pas été réalisée");
                        else
                            return (int)dbp.Value;
                    
                    }
                    catch(DbException de)
                    {
                        throw new DaoExceptionAfficheMessage
                            ("Une erreur s'est produite sur la base : \n"
                                    + de.Message, de);
                    }


                }
            }
        }

        public void AffectParam(Produit prod, DbCommand oCommand)
        {
            // Cpu Produit
            DbParameter odbp1 = oCommand.CreateParameter();
            odbp1.DbType = DbType.Int32;
            odbp1.Direction = ParameterDirection.Input;
            odbp1.ParameterName = "cpu_Produit";
            odbp1.Value = prod.Cpu;
            oCommand.Parameters.Add(odbp1);
            //Nom produit
            DbParameter odbp2 = oCommand.CreateParameter();
            odbp2.DbType = DbType.String;
            odbp2.Direction = ParameterDirection.Input;
            odbp2.ParameterName = "nom_Produit";
            odbp2.Value = prod.Nom_Produit;
            oCommand.Parameters.Add(odbp2);
            //Description produit
            DbParameter odbp3 = oCommand.CreateParameter();
            odbp3.DbType = DbType.String;
            odbp3.Direction = ParameterDirection.Input;
            odbp3.ParameterName = "desc_produit";
            odbp3.Value = prod.Description;
            oCommand.Parameters.Add(odbp3);
            //PrixUnitaire
            DbParameter odbp5 = oCommand.CreateParameter();
            odbp5.DbType = DbType.Double;
            odbp5.Direction = ParameterDirection.Input;
            odbp5.ParameterName = "prix_Unit";
            odbp5.Value = prod.Prix_Unitaire;
            oCommand.Parameters.Add(odbp5);
            //Categorie produit
            DbParameter odbp4 = oCommand.CreateParameter();
            odbp4.DbType = DbType.Int32;
            odbp4.Direction = ParameterDirection.Input;
            odbp4.ParameterName = "id_Cat_Prod";
            odbp4.Value = prod.Categorie.Id_Categorie;
            oCommand.Parameters.Add(odbp4);


        }
    }

}
