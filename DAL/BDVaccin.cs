using CliniqueVeterinaire.Metier;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniqueVeterinaire.Data
{
    public class BDVaccin
    {

        /// <summary>
        /// retourne la liste des vaccins non archivés
        /// (classés par nom)
        /// </summary>
        /// <returns></returns>
        public static List<Vaccin> GetVaccins()
        {
            IDbConnection cnx = null;
            Guid codeVaccin;
            String nomVaccin;
            int qteStock, periodeValidite;
            List<Vaccin> listeVaccins = new List<Vaccin>();

            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "SELECT codeVaccin, nomVaccin, " +
                                  "quantiteStock, periodeValidite " +
                                  "FROM Vaccins " +
                                  "WHERE archive = 0 " +
                                  "ORDER BY nomVaccin;";

                cnx.Open();

                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    codeVaccin = reader.GetGuid(0);
                    nomVaccin = reader.GetString(1);
                    qteStock = reader.GetInt32(2);
                    periodeValidite = reader.GetInt32(3);

                    listeVaccins.Add(new Vaccin(codeVaccin, nomVaccin, qteStock, periodeValidite));
                }

                reader.Close();
                return listeVaccins;
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }
        }

        /// <summary>
        /// met à jour en base la quantité en stock du vaccin en paramètre
        /// </summary>
        /// <param name="vaccin">vaccin à mettre à jour</param>
        /// <param name="nouvelleQte">nouvelle qté en stock</param>
        public static void MiseAJourStockVaccin(Vaccin vaccin, int nouvelleQte)
        {
            // on vérifie que la nouvelle quantité est correcte
            if (nouvelleQte <= vaccin.QuantiteStock)
            {
                throw new ApplicationException("La nouvelle quantité doit être " +
                                                "supérieure à l'ancienne.");
            }

            IDbConnection cnx = null;

            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();

                cmd.CommandText = "UPDATE Vaccins " +
                                  "SET QuantiteStock = @qte " +
                                  "WHERE CodeVaccin = @code;";

                // paramètre
                BDOutils.AddParameter(cmd, "@qte", nouvelleQte, DbType.Int32);
                BDOutils.AddParameter(cmd, "@code", vaccin.Code, DbType.Guid);

                cnx.Open();

                cmd.ExecuteNonQuery();
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }
        }

        /// <summary>
        /// génère un fichier csv avec les vaccins à commander
        /// </summary>
        /// <param name="nomFichier">fichier dans lequel les données seront enregistrées</param>
        /// <param name="nomDesVaccinsACder">liste des noms de vaccins à commander</param>
        public static void GenererCsv(string nomFichier, List<String> nomDesVaccinsACder)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(nomFichier, false); // écrasera le fichier s'il existe

                sw.WriteLine("nom;quantite");

                for (int i = 0; i < nomDesVaccinsACder.Count; i++)
                {
                    sw.WriteLine(nomDesVaccinsACder[i]);
                }
            }
            catch
            {
                throw new ApplicationException("L'enregistrement du fichier n'a pas pu être effectué.");
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }

        public static void MettreAjourStock(List<LigneConsultation> listeVaccinAMettreAJour)
        {
            int i = 0;
            Guid[] listCodeVaccin = new Guid[listeVaccinAMettreAJour.Count];
            IDbConnection cnx = null;

            cnx = BDOutils.GetConnexion();
            IDbCommand cmd = cnx.CreateCommand();

            //Avant d'effectuer la mise a jour il faut récupérer les codes vaccins correspondants
            cmd.CommandText = "SELECT codevaccin FROM Baremes WHERE typeacte = @typeacte AND Libelle = @libelle;";

            cnx.Open();

            foreach (LigneConsultation ligne in listeVaccinAMettreAJour)
	        {
                //A chaque fois qu'on passe dans la boucle on supprime les parametre pour les mettre ensuite à jour
                 cmd.Parameters.Clear();
		         BDOutils.AddParameter(cmd,"@typeacte",ligne.Type,DbType.String);
                 BDOutils.AddParameter(cmd,"@libelle",ligne.Libelle,DbType.String);

                 listCodeVaccin[i] = (Guid)cmd.ExecuteScalar();
                 i++;
	        }

            //Maintenant que l'on a récupéré tous les codes vaccins coreespondant, on peut effectuer la mise a jour via une instruction UPDATE

            cmd.CommandText = "UPDATE Vaccins SET QuantiteStock = QuantiteStock - 1 WHERE codevaccin = @codeVaccin;";

            for (int j = 0; j < listCodeVaccin.Length; j++)
            {
                 cmd.Parameters.Clear();
		         BDOutils.AddParameter(cmd,"@codeVaccin",listCodeVaccin[j],DbType.Guid);

                 cmd.ExecuteNonQuery();
            }
           
        }
    }
}
