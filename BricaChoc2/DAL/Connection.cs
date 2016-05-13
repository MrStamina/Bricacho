using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using DAL.Exceptions;

namespace DAL
{
    public class Connection
    {
        static public DbConnection GetConnectionSqlServer()
        {
            
                ConnectionStringSettings oConfig = ConfigurationManager.ConnectionStrings["ConBricachoc"];
           
            
            if (oConfig == null)
                throw new DaoExceptionFinAppli("La base est inaccessible, l'application va se fermer, veuillez recommencez ultèrieurement: \n" + "La chaine de connexion est introuvable");
            else
            {
                DbProviderFactory oFabrique = DbProviderFactories.GetFactory(oConfig.ProviderName);
                DbConnection oConnection = oFabrique.CreateConnection();
                oConnection.ConnectionString = oConfig.ConnectionString;
                try
                {
                    oConnection.Open();
                    return oConnection;
                }
                catch (DbException dbe)
                {
                    throw new DaoExceptionFinAppli("Connexion à la base impossible", dbe);
                }
            }

        }

        static public DbConnection GetConnectionMySQL()
        {
            ConnectionStringSettings oConfig = ConfigurationManager.ConnectionStrings["ConBricachocMySQL"];
            if (oConfig == null)
                throw new DaoExceptionFinAppli("La base est inaccessible, l'application va se fermer, veuillez recommencez ultèrieurement: \n" + "La chaine de connexion est introuvable");
            else
            {
                DbProviderFactory oFabrique = DbProviderFactories.GetFactory(oConfig.ProviderName);
                DbConnection oConnection = oFabrique.CreateConnection();
                oConnection.ConnectionString = oConfig.ConnectionString;
                try
                {
                    oConnection.Open();
                    return oConnection;
                }
                catch (DbException dbe)
                {
                    throw new DaoExceptionFinAppli("Connexion à la base impossible", dbe);
                }
            }
        
        }
    }
}
