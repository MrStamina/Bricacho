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
        public bool AddProduit(Produit prod)
        {

            using (DbConnection oConnection = Connection.GetConnectionMySQL())
            {
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = "add_produit";
                    oCommand.CommandType = CommandType.StoredProcedure;
                    oCommand.Parameters.Clear();
                    AffectParam(prod, oCommand);
                    
                    
                    try
                    {
                        int n = oCommand.ExecuteNonQuery();
                        if (n != 1)
                            throw new DaoExceptionAfficheMessage
                                ("L'opération d'insertion n'a pas été réalisée");
                        else
                            return true;
                    
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

        public bool DelProduit(Produit prod)
        {
            using (DbConnection oConnection = Connection.GetConnectionMySQL())
            {
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = "del_produit";
                    oCommand.CommandType = CommandType.StoredProcedure;
                    oCommand.Parameters.Clear();
                    DbParameter odp = oCommand.CreateParameter();
                    odp.DbType = DbType.Int32;
                    odp.Direction = ParameterDirection.Input;
                    odp.ParameterName = "cpu_prod";
                    odp.Value = prod.Cpu;
                    oCommand.Parameters.Add(odp);
                    try
                    {
                        int n = oCommand.ExecuteNonQuery();
                        if (n != 1)
                            throw new DaoExceptionAfficheMessage("La suppression a échoué");
                        return true;
                    }
                    catch (DbException ex)
                    {
                        throw new DaoExceptionAfficheMessage("La suppression a échoué : \n" + ex.Message, ex);
                    }
                }
            }
        }

        public bool UpdProduit(Produit prod)
        {
            using (DbConnection oConnection = Connection.GetConnectionMySQL())
            {
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = "upd_produit";
                    oCommand.CommandType = CommandType.StoredProcedure;
                    oCommand.Parameters.Clear();
                    AffectParam(prod, oCommand);

                    try
                    {
                        int n = oCommand.ExecuteNonQuery();
                        if (n != 1)
                            throw new DaoExceptionAfficheMessage
                                ("L'opération de modification n'a pas été réalisée");
                        else
                            return true;

                    }
                    catch (DbException de)
                    {
                        throw new DaoExceptionAfficheMessage
                            ("Une erreur s'est produite sur la base : \n"
                                    + de.Message, de);
                    }
                }
            }
        }

        private void AffectParam(Produit prod, DbCommand oCommand)
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
            if (prod.Description == string.Empty)
                odbp3.Value = null;
            else
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
