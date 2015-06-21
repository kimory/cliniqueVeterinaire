using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CliniqueVeterinaire.Metier;
using System.Data;
using System.ComponentModel;
using Microsoft.VisualBasic;

namespace CliniqueVeterinaire.Data
{
    public class BDVeterinaire
    {
        public static void AjoutVeto(String nom, String motPasse)
        {
            // on ne fait pas l'ajout en base si un vétérinaire porte déjà ce nom
            if (VerifNomExistant(nom))
            {
                throw new ApplicationException("Le vétérinaire " + nom + " existe déjà.");
            }

            Boolean archive = false;
            IDbConnection cnx = null;

            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "ajout_veterinaire";
                cmd.CommandType = CommandType.StoredProcedure; // procédure stockée

                // paramètres :
                BDOutils.AddParameter(cmd, "@nomveto", nom, DbType.String);
                BDOutils.AddParameter(cmd, "@motpasse", motPasse, DbType.String);
                BDOutils.AddParameter(cmd, "@archive", archive, DbType.Boolean);

                cnx.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }
        }

        public static BindingList<Veterinaire> GetVetos()
        {
            IDbConnection cnx = null;
            String nom, motPasse;
            Guid codeVeto;
            BindingList<Veterinaire> listeVetos = new BindingList<Veterinaire>();

            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();
                // on récupère les vétérinaires non archivés, classés par nom :
                cmd.CommandText = "SELECT * FROM veterinaires WHERE archive = 0 ORDER BY NomVeto;";

                cnx.Open();

                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    codeVeto = reader.GetGuid(0);
                    nom = reader.GetString(1);
                    motPasse = reader.GetString(2);

                    listeVetos.Add(new Veterinaire(codeVeto, nom, motPasse));
                }

                reader.Close();
                return listeVetos;
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }
        }

        /// <summary>
        /// vérifie si un vétérinaire en base porte le nom
        /// passé en paramètre, quelle que soit la casse
        /// </summary>
        /// <param name="nomVeto">nom dont on cherche une occurence en base</param>
        /// <returns>vrai si un vétérinaire de ce nom existe déjà, faux sinon</returns>
        private static bool VerifNomExistant(String nomVeto)
        {
            BindingList<Veterinaire> listeVetosExistants = GetVetos();

            bool vetTrouve = false;

            for (int i = 0 ; i < listeVetosExistants.Count && !vetTrouve ; i++)
            {
                if (listeVetosExistants[i].NomVeto.ToUpper().Equals(nomVeto.ToUpper()))
                {
                    vetTrouve = true;
                }
            }

            return vetTrouve;
        }

        public static void ArchivageVeto(Guid codeVeto)
        {
            IDbConnection cnx = null;

            try
            {
                // on ne fait l'archivage que si le vétérinaire n'a pas de
                // consultations prévues
                if (!IsVetoLinkedToConsultation(codeVeto))
                {
                    cnx = BDOutils.GetConnexion();
                    IDbCommand cmd = cnx.CreateCommand();
                    // on archive le vétérinaire :
                    cmd.CommandText = "update veterinaires set archive = 1 where codeVeto = @codeVeto;";

                    // paramètre
                    BDOutils.AddParameter(cmd, "@codeVeto", codeVeto, DbType.Guid);

                    cnx.Open();

                    cmd.ExecuteNonQuery();
                }
                else
                {
                    throw new ApplicationException("Archivage impossible. Le vétérinaire a des " +
                                            "consultations prévues.");
                }

            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }
        }

        private static bool IsVetoLinkedToConsultation(Guid codeVeto)
        {
            IDbConnection cnx = null;
            bool isLinked = false;

            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();
                // est-ce que le vétérinaire a des consultations prévues aujourd'hui ou plus tard ?
                cmd.CommandText = "SELECT COUNT(codeConsultation) FROM consultations " +
                                   "WHERE codeVeto = @codeVeto " +
                                   "AND dateConsultation >= GETDATE();";

                // paramètre
                BDOutils.AddParameter(cmd, "@codeVeto", codeVeto, DbType.Guid);

                cnx.Open();

                int nbConsultations = (int) cmd.ExecuteScalar();

                if (nbConsultations > 0)
                {
                    isLinked = true;
                }

                return isLinked;
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }
        }

        public static void ReinitialiserMotPasse(Guid codeVeto, String nouveauMotPasse)
        {
            IDbConnection cnx = null;

            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();
                // on met à jour le mot de passe du vétérinaire :
                cmd.CommandText = "update veterinaires set motPasse = @nouveauMdp where codeVeto = @codeVeto;";

                // paramètre
                BDOutils.AddParameter(cmd, "@nouveauMdp", nouveauMotPasse, DbType.String);
                BDOutils.AddParameter(cmd, "@codeVeto", codeVeto, DbType.Guid);

                cnx.Open();

                cmd.ExecuteNonQuery();

            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }
        }

        public static Veterinaire GetVeto()
        {
            IDbConnection cnx = null;
            string nomveto;
            Veterinaire veto = null;

            cnx = BDOutils.GetConnexion();
            IDbCommand cmd = cnx.CreateCommand();
            // on récupère les vétérinaires non archivés :
            cmd.CommandText = "SELECT * FROM veterinaires WHERE codeveto = 'EE8D4E04-C56B-4600-8327-95CEB98A1E6A';";

            cnx.Open();

            IDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                nomveto = reader.GetString(1);
                veto = new Veterinaire(nomveto);
            }

            return veto;
        }

        public static bool GetLogin(string nomVeto, string motpasse, out Guid codeVeto)
        {
            codeVeto = default(Guid);
            bool verif = false;
            IDbConnection cnx = BDOutils.GetConnexion();
            IDbCommand cmd = cnx.CreateCommand();

            cmd.CommandText = "SELECT COUNT(*), CodeVeto FROM Veterinaires " +
                              "WHERE NomVeto = @nomVeto " +
                              "AND MotPasse = @motPasse AND archive = 0 " +
                              "GROUP BY CodeVeto;";

            BDOutils.AddParameter(cmd, "@nomVeto", nomVeto, DbType.String);
            BDOutils.AddParameter(cmd, "@motPasse", motpasse, DbType.String);

            try
            {
                cnx.Open();
                //verif = ((int)cmd.ExecuteScalar() == 1);

                IDataReader reader = cmd.ExecuteReader();

                // on ne récupère les données que d'une seule ligne (if et non while)
                if (reader.Read())
                {
                    verif = ((int)reader.GetInt32(0) == 1);
                    codeVeto = reader.GetGuid(1);
                }
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }

            return verif;
        }
    }
}
