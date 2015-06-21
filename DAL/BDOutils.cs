using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniqueVeterinaire.Data
{
    class BDOutils
    {
        internal static IDbConnection GetConnexion()
        {
            ConnectionStringSettings config = ConfigurationManager.ConnectionStrings["choix"];
            IDbConnection cnx =
                DbProviderFactories.GetFactory(config.ProviderName).CreateConnection();
            cnx.ConnectionString = config.ConnectionString;
            return cnx;
        }

        internal static void AddParameter(IDbCommand cmd, String nom, Object valeur,
                                            DbType type, int size = 0)
        {
            IDbDataParameter param = cmd.CreateParameter();
            param.ParameterName = nom;
            param.Value = valeur;
            param.DbType = type;
            cmd.Parameters.Add(param);
        }

        internal static void FermerConnexion(IDbConnection cnx)
        {
            // on passe ici dans tous les cas (on ferme la connexion si elle est ouverte)
            if (cnx != null && cnx.State != ConnectionState.Closed && cnx.State != ConnectionState.Broken)
                cnx.Close();
        }
    }
}
