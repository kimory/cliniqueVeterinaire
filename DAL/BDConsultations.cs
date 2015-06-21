using CliniqueVeterinaire.Metier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniqueVeterinaire.Data
{
    public class BDConsultations
    {
        public static void AjoutConsultation(bool p, Consultation consul)
        {
            IDbConnection cnx = BDOutils.GetConnexion();
            IDbCommand cmd = cnx.CreateCommand();
            Guid codeConsultation = Guid.NewGuid();

            //on ajoute dans un premier temps la consultation...
            cmd.CommandText = "INSERT INTO Consultations(codeconsultation,dateconsultation,codeveto,codeanimal,commentaire,etat,archive) VALUES(@codeconsul,@dateconsul,@codeveto,@codeanimal,@commentaire,@etat,@archive);";

            BDOutils.AddParameter(cmd, "@codeconsul", codeConsultation, DbType.Guid);
            BDOutils.AddParameter(cmd, "@codeveto", consul.Veto.CodeVeto, DbType.Guid);
            BDOutils.AddParameter(cmd, "@dateconsul", consul.DateConsultation, DbType.DateTime);
            BDOutils.AddParameter(cmd, "@codeanimal", consul.Animal.CodeAnimal, DbType.Guid);
            BDOutils.AddParameter(cmd, "@commentaire", consul.Commentaire, DbType.String);
            BDOutils.AddParameter(cmd, "@etat", 1, DbType.Int32);
            BDOutils.AddParameter(cmd, "@archive", 0, DbType.Int32);

            try
            {
                cnx.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                //On ajoute ensuite les différentes lignes de consultation 

                cmd.CommandText = "INSERT INTO LignesConsultations(codeconsultation,numligne,codegroupement,datevigueur,prix,archive,rappelenvoye) VALUES (@codeconsul,@numligne,@codegroupement,@datevigueur,@prix,0,0);";

                foreach (LigneConsultation item in consul.ListeLigneConsultations)
                {
                    BDOutils.AddParameter(cmd, "@codeconsul", codeConsultation, DbType.Guid);
                    BDOutils.AddParameter(cmd, "@numligne", Guid.NewGuid(), DbType.Guid);
                    BDOutils.AddParameter(cmd, "@codegroupement", item.Barem.CodeGroupement, DbType.String);
                    BDOutils.AddParameter(cmd, "@datevigueur", item.Barem.DateVigueur, DbType.String);
                    BDOutils.AddParameter(cmd, "@prix", item.Prix, DbType.Decimal);

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }

        }

        #region Gestion des RDV dans le planning/agenda
        /// <summary>
        /// ajoute une entrée dans la table agenda
        /// (tel animal, tel jour, avec tel vétérinaire...)
        /// </summary>
        /// <param name="Consultation"></param>
        public static void AjoutEntreeAgenda(Consultation consul)
        {
            // on vérifie que la date est cohérente et que le 
            // vétérinaire choisi n'a pas déjà un rdv à cette date
            VerifRdvOk(consul.DateConsultation, consul.Veto);

            IDbConnection cnx = null;

            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();

                cmd.CommandText = "INSERT INTO Agendas VALUES(@codeVeto, @dateRdv, @codeAnimal)";

                // les paramètres :
                BDOutils.AddParameter(cmd, "@codeVeto", consul.Veto.CodeVeto, DbType.Guid);
                BDOutils.AddParameter(cmd, "@dateRdv", consul.DateConsultation, DbType.DateTime);
                BDOutils.AddParameter(cmd, "@codeAnimal", consul.Animal.CodeAnimal, DbType.Guid);

                cnx.Open();

                cmd.ExecuteNonQuery();
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }
        }

        /// <summary>
        /// vérifie que le RDV à enregistrer est conforme aux règles de gestion
        /// </summary>
        /// <param name="dateConsul"></param>
        private static void VerifRdvOk(DateTime dateConsul, Veterinaire veto)
        {
            // on ne peut enregistrer un rdv que pour le jour même (urgence...)
            // ou au-delà
            if (dateConsul < DateTime.Now.Date)
            {
                throw new ApplicationException("Vous ne pouvez pas enregistrer un RDV à une date passée.");
            }

            // on regarde si le vétérinaire choisi a déjà un rendez-vous pour cette date
            IDbConnection cnx = null;

            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();

                // on fait la vérification "à la minute près"
                // pour prévoir le cas où on clique 2 fois sur 
                // le bouton "urgence" pendant la même minute
                cmd.CommandText = "SELECT COUNT(*) FROM Agendas " +
                                  "WHERE CodeVeto = @codeVeto AND " +
                                  "DATEDIFF(MINUTE, DateRdv, @dateChoisie) = 0;";

                // les paramètres :
                BDOutils.AddParameter(cmd, "@codeVeto", veto.CodeVeto, DbType.Guid);

                //DateTime dateAVerifier = dateConsul.AddSeconds(-dateConsul.Second);

                BDOutils.AddParameter(cmd, "@dateChoisie", dateConsul, DbType.DateTime);

                cnx.Open();

                if ((int)cmd.ExecuteScalar() > 0)
                {
                    throw new ApplicationException(veto.NomVeto + " a déjà un " +
                                                   "RDV programmé à cette date.");
                }
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }
        }

        /// <summary>
        /// supprime un rdv dans l'agenda
        /// </summary>
        /// <param name="Consultation"></param>
        public static void SuppressionEntreeAgenda(Consultation consul)
        {
            IDbConnection cnx = null;

            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();

                cmd.CommandText = "DELETE FROM Agendas " +
                                  "WHERE CodeVeto = @codeVeto " +
                                  "AND CodeAnimal = @codeAnimal " +
                                  "AND DateRdv = @dateRdv;";

                // les paramètres :
                BDOutils.AddParameter(cmd, "@codeVeto", consul.Veto.CodeVeto, DbType.Guid);
                BDOutils.AddParameter(cmd, "@codeAnimal", consul.Animal.CodeAnimal, DbType.Guid);
                BDOutils.AddParameter(cmd, "@dateRdv", consul.DateConsultation, DbType.DateTime);

                cnx.Open();

                cmd.ExecuteNonQuery();
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }
        }
        #endregion

        /// <summary>
        /// retourne la liste des consultations d'un vétérinaire à une date donnée
        /// (dans l'ordre chronologique)
        /// </summary>
        /// <param name="Veterinaire"></param>
        /// <param name="dateConsultation"></param>
        public static List<Consultation> GetConsultations(Veterinaire Veterinaire, DateTime dateConsultation)
        {
            IDbConnection cnx = null;
            List<Consultation> listeConsultations = new List<Consultation>();
            DateTime dateHeureConsultation;
            Animal animal;
            Veterinaire veterinaire;
            Guid codeAnimal, codeVeto;
            String race;
            String nomClient, nomVeto, motPasseVeto, nomAnimal, sexeAnimal, couleur, espece, tatouage;

            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "SELECT DateRdv, (nomClient + ' ' + prenomClient) client, " +
                                "v.codeVeto, nomveto, motPasse, " +
                                "an.* " +
                                "FROM Veterinaires v INNER JOIN Agendas ag " +
                                "ON v.CodeVeto = ag.codeVeto " +
                                "INNER JOIN Animaux an " +
                                "ON ag.codeanimal = an.codeAnimal " +
                                "INNER JOIN Clients c " +
                                "ON an.CodeClient = c.codeClient " +
                                "WHERE v.codeVeto = @codeVeto " +
                                "AND DateRdv > @borneDate1 AND DateRdv < @borneDate2 " +
                                "ORDER BY DateRdv;";

                // paramètres
                BDOutils.AddParameter(cmd, "@codeVeto", Veterinaire.CodeVeto, DbType.Guid);
                // on utilise 2 bornes pour la date, par ex : on cherche les consultations
                // entre le 13/06 à minuit et le 14/06 à minuit
                // (la propriété Date permet d'obtenir la date "à minuit")
                BDOutils.AddParameter(cmd, "@borneDate1", dateConsultation.Date, DbType.DateTime);
                BDOutils.AddParameter(cmd, "@borneDate2", dateConsultation.AddDays(1).Date, DbType.DateTime);

                cnx.Open();

                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dateHeureConsultation = reader.GetDateTime(0);
                    nomClient = reader.GetString(1);

                    codeVeto = reader.GetGuid(2);
                    nomVeto = reader.GetString(3);
                    motPasseVeto = reader.GetString(4);

                    codeAnimal = reader.GetGuid(5);
                    nomAnimal = reader.GetString(6);
                    sexeAnimal = reader.GetString(7);

                    // la couleur peut ne pas être renseignée
                    if (reader.IsDBNull(8))
                    {
                        couleur = "";
                    }
                    else
                    {
                        couleur = reader.GetString(8);
                    }

                    race = reader.GetString(9);
                    espece = reader.GetString(10); // (on ne récupère pas la colonne 11)

                    // le tatouage peut ne pas être renseigné
                    if (reader.IsDBNull(12))
                    {
                        tatouage = "";
                    }
                    else
                    {
                        tatouage = reader.GetString(12);
                    }

                    animal = new Animal(codeAnimal, nomAnimal, sexeAnimal, couleur, new Race(race, espece), tatouage);

                    veterinaire = new Veterinaire(codeVeto, nomVeto, motPasseVeto);

                    listeConsultations.Add(new Consultation(dateHeureConsultation, nomClient, animal, veterinaire));
                }

                reader.Close();
                return listeConsultations;
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }
        }

        public static bool verifConsultationValidee(Consultation consulaverifier)
        {
            bool verif;
            IDbConnection cnx = BDOutils.GetConnexion();
            IDbCommand cmd = cnx.CreateCommand();

            cmd.CommandText = "SELECT count(*) FROM consultations WHERE codeveto = @codeveto AND codeanimal = @codeanimal AND DateConsultation =@dateconsultation AND etat IN (1,2) AND archive = 0;";

            BDOutils.AddParameter(cmd, "@codeveto", consulaverifier.Veto.CodeVeto, DbType.Guid);
            BDOutils.AddParameter(cmd, "@codeanimal", consulaverifier.Animal.CodeAnimal, DbType.Guid);
            BDOutils.AddParameter(cmd, "@dateconsultation", consulaverifier.DateConsultation, DbType.DateTime);

            cnx.Open();

            verif = ((int)cmd.ExecuteScalar() == 0);

            BDOutils.FermerConnexion(cnx);

            return verif;
        }

        public static List<Consultation> RechercheConsultations(Animal animal)
        {
            List<Consultation> Liste_Consultation = new List<Consultation>();
            List<LigneConsultation> Liste_LigneConsultation = new List<LigneConsultation>();

            IDbConnection cnx = BDOutils.GetConnexion();
            IDbConnection cnx2 = BDOutils.GetConnexion();
            IDbCommand cmd = cnx.CreateCommand();
            IDbCommand cmd2 = cnx2.CreateCommand();

            //On declare les variables necessaires pour construire nos objets
            DateTime dateconsul;
            String nomveto, commentaire;
            String typeacte, libelle;

            //Commande SQL pour ecupérer les infos liées aux consultations
            cmd.CommandText = "SELECT Dateconsultation,commentaire, nomveto, codeconsultation FROM Consultations " +
            "INNER JOIN Veterinaires ON Consultations.Codeveto = Veterinaires.codeveto WHERE codeanimal = @codeanimal;";

            BDOutils.AddParameter(cmd, "@codeanimal", animal.CodeAnimal, DbType.Guid);

            //Commande SQL pour récupérer les infos liées aux lignes de consultations
            cmd2.CommandText = "SELECT Typeacte,libelle FROM LignesConsultations INNER JOIN Baremes ON LignesConsultations.codegroupement = " +
            "Baremes.codegroupement AND LignesConsultations.datevigueur = Baremes.datevigueur WHERE codeconsultation = @codeconsul;";

            cnx.Open();
            cnx2.Open();
            //on execute la commande n°1 pour les consultations
            IDataReader reader1 = cmd.ExecuteReader();

            //on boucle pour construire l'ensemble des consultations trouvées dans la bases
            while (reader1.Read())
            {
                dateconsul = reader1.GetDateTime(0);
                commentaire = reader1.GetString(1);
                nomveto = reader1.GetString(2);
                //Liste_Consultation.Add(new Consultation(dateconsul, nomveto, commentaire));

                //On paramètre la seconde requête pour récupérer l'ensemble des lignes de consultations pour cette Consultation
                cmd2.Parameters.Clear();
                BDOutils.AddParameter(cmd2, "@codeconsul", reader1.GetGuid(3), DbType.Guid);
                IDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    typeacte = reader2.GetString(0);
                    libelle = reader2.GetString(1);
                    Liste_LigneConsultation.Add(new LigneConsultation(typeacte, libelle));
                }
                reader2.Close();
                Liste_Consultation.Add(new Consultation(dateconsul, nomveto, commentaire, Liste_LigneConsultation));
            }
            reader1.Close();

            BDOutils.FermerConnexion(cnx);
            BDOutils.FermerConnexion(cnx2);

            return Liste_Consultation;
        }

        public static List<Bareme> GetBareme()
        {
            IDbConnection cnx = null;
            List<Bareme> listeBareme = new List<Bareme>(); ;

            cnx = BDOutils.GetConnexion();
            IDbCommand cmd = cnx.CreateCommand();
            cmd.CommandText = "Select* FROM Baremes WHERE archive =0;";
            cnx.Open();
            IDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string libelle, type, codegroupement, datevigueur;
                double mini, maxi, fix;

                codegroupement = reader.GetString(0);
                datevigueur = reader.GetString(1);
                libelle = reader.GetString(3);
                type = reader.GetString(2);

                if (!reader.IsDBNull(5))
                {
                    mini = (double)reader.GetDecimal(5);
                }
                else
                {
                    mini = 0;
                }
                if (!reader.IsDBNull(6))
                {
                    maxi = (double)reader.GetDecimal(6);
                }
                else
                {
                    maxi = 0;
                }
                if (!reader.IsDBNull(4))
                {
                    fix = (double)reader.GetDecimal(4);
                }
                else
                {
                    fix = 0;
                }

                listeBareme.Add(new Bareme(codegroupement, datevigueur, type, libelle, mini, maxi, fix));
            }

            BDOutils.FermerConnexion(cnx);

            return listeBareme;
        }
    }
}
