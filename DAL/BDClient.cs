using CliniqueVeterinaire.Metier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniqueVeterinaire.Data
{
    public class BDClient
    {
        /// <summary>
        /// retourne le client correspondant à la position en paramètre
        /// en tenant compte du filtre de recherche
        /// </summary>
        /// <param name="position">position du client en base</param>
        /// <param name="filtre">filtre de recherche par nom</param>
        /// <returns>un client et la liste de ses animaux</returns>
        public static Client GetClient(int position, String filtre)
        {
            Client client;
            List<Animal> listeAnimaux = new List<Animal>();
            IDbConnection cnx = null;

            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();

                // si un champ est null, on récupère une chaîne vide
                cmd.CommandText = "SELECT * FROM " +
                    "(SELECT " +
                    "RowNum = ROW_NUMBER() OVER (ORDER BY NomClient), " +
                    "CodeClient, NomClient, " +
                    "PrenomClient, COALESCE(Adresse1,'') adresse1, " +
                    "COALESCE(Adresse2,'') adresse2, " +
                    "COALESCE(CodePostal,'') codepostal, COALESCE(Ville,'') ville " +
                    "FROM clients WHERE archive = 0 AND NomClient LIKE @filtre + '%') sousRequete " +
                    "WHERE RowNum = @position;";

                // les paramètres
                BDOutils.AddParameter(cmd, "@position", position + 1, DbType.Int32);
                // pour le filtre éventuel par nom :
                BDOutils.AddParameter(cmd, "@filtre", filtre, DbType.String);

                cnx.Open();

                IDataReader resultats = cmd.ExecuteReader();

                if (resultats.Read())
                {
                    Guid code = Guid.Empty;
                    String nom = null, prenom = null, adresse1 = null, adresse2 = null, codepostal = null, ville = null;

                    // on récupère les valeurs :
                    code = resultats.GetGuid(1);
                    nom = resultats.GetString(2);
                    prenom = resultats.GetString(3);
                    adresse1 = resultats.GetString(4);
                    adresse2 = resultats.GetString(5);
                    codepostal = resultats.GetString(6);
                    ville = resultats.GetString(7);

                    // on crée le client
                    client = new Client(code, nom, prenom, adresse1, adresse2, codepostal, ville);

                    resultats.Close();
                    resultats = null;
                }
                else
                {
                    throw new ApplicationException("Il n'y a pas de client à cette position.");
                }

                // si on a trouvé un client, on recherche ses animaux
                // si le champ "tatouage" est null, on récupère une chaîne vide
                cmd.CommandText = "Select codeanimal,nomanimal,sexe,couleur,race,espece, " +
                                  "COALESCE(tatouage,'') " +
                                  "FROM animaux " +
                                  "WHERE archive = 0 AND codeClient = @codeClient;";

                BDOutils.AddParameter(cmd, "@codeClient", client.Code, DbType.Guid);

                resultats = cmd.ExecuteReader();

                while (resultats.Read())
                {
                    Guid codeAnimal = Guid.Empty;
                    String nomAnimal = null, sexe = null, couleur = null,
                        race = null, espece = null, tatouage = null;

                    // on récupère les valeurs :
                    codeAnimal = resultats.GetGuid(0);
                    nomAnimal = resultats.GetString(1);
                    sexe = resultats.GetString(2);
                    couleur = resultats.GetString(3);
                    race = resultats.GetString(4);
                    espece = resultats.GetString(5);
                    tatouage = resultats.GetString(6);

                    listeAnimaux.Add(new Animal(codeAnimal, nomAnimal, sexe, couleur, new Race(race, espece), tatouage));
                }

                resultats.Close();

                // on ajoute la liste des animaux au client
                client.ListeAnimaux = listeAnimaux;

                resultats.Close();
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }

            return client;
        }

        /// <summary>
        /// archive le client en paramètre (champ archive prend la valeur "1")
        /// </summary>
        /// <param name="codeClient"></param>
        public static void ArchivageClient(Guid codeClient)
        {
            IDbConnection cnx = null;

            try
            {
                // on ne fait l'archivage que si le client
                // n'a pas de factures impayées
                if (!facturesClientImpayees(codeClient))
                {
                    cnx = BDOutils.GetConnexion();
                    IDbCommand cmd = cnx.CreateCommand();
                    // on archive le client :
                    cmd.CommandText = "update clients set archive = 1 where codeClient = @codeClient;";

                    // paramètre
                    BDOutils.AddParameter(cmd, "@codeClient", codeClient, DbType.Guid);

                    cnx.Open();

                    cmd.ExecuteNonQuery();

                    // on archive également les animaux du client
                    cmd.CommandText = "update animaux set archive = 1 where codeClient = @codeClient;";
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    throw new ApplicationException("Archivage impossible. Le client a des " +
                                            "factures non payées.");
                }

            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }
        }

        /// <summary>
        /// vérifie si le client a des factures impayées
        /// </summary>
        /// <param name="codeClient">client dont on veut vérifier l'état des factures</param>
        /// <returns>vrai si le client a au moins une facture impayée, faux sinon</returns>
        private static bool facturesClientImpayees(Guid codeClient)
        {
            IDbConnection cnx = null;
            bool facturesImpayees = false;

            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();
                // est-ce que le client a des factures impayées ?
                cmd.CommandText = "SELECT COUNT(numfacture) FROM factures " +
                                  "WHERE codeClient = @codeClient " +
                                  "AND etat != 2;";

                // paramètre
                BDOutils.AddParameter(cmd, "@codeClient", codeClient, DbType.Guid);

                cnx.Open();

                int nbFacturesImpayes = (int)cmd.ExecuteScalar();

                if (nbFacturesImpayes > 0)
                {
                    facturesImpayees = true;
                }

                return facturesImpayees;
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }
        }

        /// <summary>
        /// permet de récupérer le nombre de clients NON ARCHIVES
        /// </summary>
        /// <param name="filtreRecherche">filtre de recherche par nom dont on tient compte</param>
        /// <returns>le nombre de clients trouvés</returns>
        public static int NbClients(String filtreRecherche)
        {
            IDbConnection cnx = null;
            int nbClients;

            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM clients " +
                                  "WHERE archive = 0 AND " +
                                  "nomClient LIKE @filtre + '%';";

                // le paramètre (filtre) :
                BDOutils.AddParameter(cmd, "@filtre", filtreRecherche, DbType.String);

                cnx.Open();
                nbClients = (int)cmd.ExecuteScalar();
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }

            return nbClients;
        }

        /// <summary>
        /// ajoute en BDD le client en paramètre
        /// </summary>
        /// <param name="c"></param>
        public static void AjoutClient(Client c)
        {
            IDbConnection cnx = null;
            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();
                // on ajoute le client, en utilisant la procédure stockée :
                cmd.CommandText = "ajout_client";
                cmd.CommandType = CommandType.StoredProcedure;

                // paramètres :
                BDOutils.AddParameter(cmd, "@nom", c.Nom, DbType.String);
                BDOutils.AddParameter(cmd, "@prenom", c.Prenom, DbType.String);
                BDOutils.AddParameter(cmd, "@add", c.Adresse1, DbType.String);
                BDOutils.AddParameter(cmd, "@add2", c.Adresse2, DbType.String);
                BDOutils.AddParameter(cmd, "@cp", c.CodePostal, DbType.String);
                BDOutils.AddParameter(cmd, "@ville", c.Ville, DbType.String);
                BDOutils.AddParameter(cmd, "@tel", "", DbType.String);
                BDOutils.AddParameter(cmd, "@ass", "", DbType.String);
                BDOutils.AddParameter(cmd, "@mail", "", DbType.String);
                BDOutils.AddParameter(cmd, "@arch", 0, DbType.Boolean);

                cnx.Open();

                cmd.ExecuteNonQuery();
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }
        }

        /// <summary>
        /// renvoie la position en base du client en paramètre
        /// lorsque la liste des clients (non archivés) est triée par nom
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int GetPositionClient(Client c, String filtreRecherche)
        {
            IDbConnection cnx = null;
            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "SELECT rownum FROM " +
	                                 "(SELECT " +
	                                    "RowNum = ROW_NUMBER() OVER (ORDER BY NomClient), " +
	                                    "CodeClient, NomClient, " +
	                                    "PrenomClient, COALESCE(Adresse1,'') adresse1, COALESCE(Adresse2,'') adresse2, " +
	                                    "COALESCE(CodePostal,'') codePostal, COALESCE(Ville,'') ville " +
                                        "FROM clients WHERE archive = 0 " +
                                        "AND NomClient LIKE @filtre + '%') sousRequete " +
                                  "WHERE nomClient = @nom AND prenomClient = @prenom " +
                                  "AND adresse1 = @add AND adresse2 = @add2 " +
                                  "AND codepostal = @cp AND ville = @ville;";

                // paramètres :
                BDOutils.AddParameter(cmd, "@filtre", filtreRecherche, DbType.String);
                BDOutils.AddParameter(cmd, "@nom", c.Nom, DbType.String);
                BDOutils.AddParameter(cmd, "@prenom", c.Prenom, DbType.String);
                BDOutils.AddParameter(cmd, "@add", c.Adresse1, DbType.String);
                BDOutils.AddParameter(cmd, "@add2", c.Adresse2, DbType.String);
                BDOutils.AddParameter(cmd, "@cp", c.CodePostal, DbType.String);
                BDOutils.AddParameter(cmd, "@ville", c.Ville, DbType.String);

                cnx.Open();

                Int64 pos = (Int64)cmd.ExecuteScalar(); 

                return (int) pos;
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }
        }

        public static List<Race> GetRace()
        {
            IDbConnection cnx = null;
            List<Race> ListRace = new List<Race>();

            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "Select * FROM races;";
                cnx.Open();
                IDataReader reader = cmd.ExecuteReader();
                String race, espece;


                while (reader.Read())
                {
                    race = reader.GetString(0);
                    espece = reader.GetString(1);
                    ListRace.Add(new Race(race, espece));
                }

                reader.Close();
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }

            return ListRace;
        }

        //Cette méthode permet d'ajouter un animal en base de données
        public static void AjoutAnimal(Animal nouvelAnimal, Client client)
        {
            IDbConnection cnx = null;

            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();

                cmd.CommandText = "ajout_animal";
                cmd.CommandType = CommandType.StoredProcedure;

                //Ajout des paramètres necessaires à l'execution de la procédure stockée dans la base
                BDOutils.AddParameter(cmd, "@nomclient", client.Nom, DbType.String);
                BDOutils.AddParameter(cmd, "@prenomclient", client.Prenom, DbType.String);
                BDOutils.AddParameter(cmd, "@nomani", nouvelAnimal.NomAnimal, DbType.String);
                BDOutils.AddParameter(cmd, "@sexe", nouvelAnimal.Sexe, DbType.String);
                BDOutils.AddParameter(cmd, "@couleur", nouvelAnimal.Couleur, DbType.String);
                BDOutils.AddParameter(cmd, "@espece", nouvelAnimal.Race.Espece, DbType.String);
                BDOutils.AddParameter(cmd, "@race", nouvelAnimal.Race.Races, DbType.String);
                BDOutils.AddParameter(cmd, "@archive", 0, DbType.Int32);

                cnx.Open();

                cmd.ExecuteNonQuery();
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }

        }

        //Cette méthode permet de mettre à jour les informations relatives à un animal en base de données 
        public static void ModifierAnimal(Animal nouvelAnimal, Client Client, string code)
        {
            IDbConnection cnx = null;
            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "UPDATE Animaux SET NomAnimal = @Nomanimal, Sexe = @sexe, Couleur =@couleur,Race=@race,Espece =@espece,Tatouage=@tatouage"
                                        + " where CodeAnimal = @codeanimal";

                BDOutils.AddParameter(cmd, "@Nomanimal", nouvelAnimal.NomAnimal, DbType.String);
                BDOutils.AddParameter(cmd, "@sexe", nouvelAnimal.Sexe, DbType.String);
                BDOutils.AddParameter(cmd, "@couleur", nouvelAnimal.Couleur, DbType.String);
                BDOutils.AddParameter(cmd, "@race", nouvelAnimal.Race.Races, DbType.String);
                BDOutils.AddParameter(cmd, "@espece", nouvelAnimal.Race.Espece, DbType.String);
                BDOutils.AddParameter(cmd, "@tatouage", nouvelAnimal.Tatouage, DbType.String);
                BDOutils.AddParameter(cmd, "@codeanimal", code, DbType.String);

                cnx.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }
        }

        public static void ArchiverAnimal(string codeAnimal)
        {
            IDbConnection cnx = null;
            int verifFacture;
            Guid code = new Guid(codeAnimal);

            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();

                cmd.CommandText = "SELECT COUNT(*) FACTURES_IMPAYEES FROM Consultations INNER JOIN Factures "
                                   + "on Consultations.NumFacture = Factures.NumFacture"
                                   + " WHERE CodeAnimal = @codeanimal AND Factures.Etat != 2;";

                BDOutils.AddParameter(cmd, "@codeanimal", code, DbType.Guid);

                cnx.Open();

                //On vérifie si l'animal est liée à une facture impayée...si oui on lance une exception
                verifFacture = (int)cmd.ExecuteScalar();

                if (verifFacture >= 1)
                {
                    throw new ApplicationException("Archivage impossible car il existe des factures impayées liées à cet animal");
                }

                //on procède à l'archivage de l'animal en cours

                cmd.CommandText = "UPDATE Animaux SET archive = 1 WHERE CodeAnimal = @codeanimal;";
                cmd.ExecuteNonQuery();
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }

        }

        /// <summary>
        /// retourne la liste des clients non archivés
        /// classés par nom
        /// </summary>
        /// <returns></returns>
        public static List<Client> GetClients()
        {
            IDbConnection cnx = null;
            String nom, prenom;
            Guid codeClient;
            List<Client> listeClients = new List<Client>();

            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "SELECT CodeClient, NomClient, PrenomClient " +
                                  "FROM clients WHERE archive = 0 " +
                                  "ORDER BY NomClient";

                cnx.Open();

                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    codeClient = reader.GetGuid(0);
                    nom = reader.GetString(1);
                    prenom = reader.GetString(2);

                    listeClients.Add(new Client(codeClient, nom, prenom));
                }

                reader.Close();
                return listeClients;
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }
        }

        /// <summary>
        /// retourne la liste des animaux non archivés
        /// du client en paramètre (classés par nom)
        /// </summary>
        /// <returns></returns>
        public static List<Animal> GetAnimaux(Client client)
        {
            IDbConnection cnx = null;
            String nomAnimal, tatouage;
            Guid codeAnimal;
            List<Animal> listeAnimaux = new List<Animal>();

            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "SELECT CodeAnimal, NomAnimal,COALESCE(tatouage,'') FROM animaux " +
                                  "WHERE archive = 0 AND CodeClient = @codeClient " +
                                  "ORDER BY NomAnimal;";

                BDOutils.AddParameter(cmd, "@codeClient", client.Code, DbType.Guid);

                cnx.Open();

                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    codeAnimal = reader.GetGuid(0);
                    nomAnimal = reader.GetString(1);
                    tatouage = reader.GetString(2);

                    listeAnimaux.Add(new Animal(codeAnimal, nomAnimal,tatouage));
                }

                reader.Close();
                return listeAnimaux;
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }
        }

        //public static Animal GetAnimal()
        //{
        //    IDbConnection cnx = null;
        //    Animal animalrecup = null;
        //    cnx = BDOutils.GetConnexion();
        //    IDbCommand cmd = cnx.CreateCommand();

        //    cmd.CommandText = "Select codeanimal,nomanimal,sexe,couleur,race,espece, " +
        //                          "COALESCE(tatouage,'') " +
        //                          "FROM animaux where codeanimal = '377BC5DE-F7FF-4112-834D-B5FE88311DC0';";
        //    cnx.Open();

        //    IDataReader reader = cmd.ExecuteReader();

        //    Guid code;
        //    string nom, couleur, tatouage, race, espece, sex;
        //    if (reader.Read())
        //    {
        //        code = reader.GetGuid(0);
        //        nom = reader.GetString(1);
        //        sex = reader.GetString(2);
        //        couleur = reader.GetString(3);
        //        race = reader.GetString(4);
        //        espece = reader.GetString(5);
        //        tatouage = reader.GetString(6);

        //        Race races = new Race(race, espece);

        //        animalrecup = new Animal(code, nom, sex, couleur, races, tatouage);
        //    }

        //    return animalrecup;
        //}


        public static void Ajouttatouage(string p, Guid codeanimal)
        {
            IDbConnection cnx = BDOutils.GetConnexion();
            IDbCommand cmd = cnx.CreateCommand();
            cmd.CommandText = "UPDATE Animaux SET tatouage = @tatouage WHERE Codeanimal = @codeanimal;";

            BDOutils.AddParameter(cmd, "@tatouage", p, DbType.String);
            BDOutils.AddParameter(cmd, "@codeanimal", codeanimal, DbType.Guid);

            cnx.Open();
            cmd.ExecuteNonQuery();
            BDOutils.FermerConnexion(cnx);
        }

        /// <summary>
        /// retourne la position en base de l'animal en paramètre
        /// parmi l'ensemble des animaux non archivés du client
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int GetPositionAnimal(Animal an, Client cl)
        {
            IDbConnection cnx = null;
            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();
                // on ne connait pas l'id de l'animal, on utilise ses caractéristiques
                cmd.CommandText = "SELECT rownum FROM " +
                                    "(SELECT " +
                                        "RowNum = ROW_NUMBER() OVER (ORDER BY NomAnimal), * " +
                                        "FROM Animaux " +
                                        "WHERE CodeClient = @codeClient " +
                                        "AND archive = 0) sousRequete " +
                                    "WHERE NomAnimal = @nomAnimal AND " +
                                    "Sexe = @genre AND Couleur = @couleur " +
                                    "AND Race = @race;";

                // paramètres :
                BDOutils.AddParameter(cmd, "@codeClient", cl.Code, DbType.Guid);
                BDOutils.AddParameter(cmd, "@nomAnimal", an.NomAnimal, DbType.String);
                BDOutils.AddParameter(cmd, "@genre", an.Sexe, DbType.String);
                BDOutils.AddParameter(cmd, "@couleur", an.Couleur, DbType.String);
                BDOutils.AddParameter(cmd, "@race", an.Race.Races, DbType.String);

                cnx.Open();

                Int64 pos = (Int64)cmd.ExecuteScalar();

                return (int)pos;
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }
        }


        /// <summary>
        /// retourne la liste des clients dont les animaux ont un rappel de vaccin
        /// classés par nom
        /// </summary>
        /// <returns></returns>
        public static List<Client> GetClientsRappelVaccin()
        {
            IDbConnection cnx = null;
            String nom, prenom;
            Guid codeClient;
            List<Client> listeClients = new List<Client>();

            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "SELECT CodeClient, NomClient, PrenomClient " +
                                  "FROM clients WHERE archive = 0 " +
                                  "ORDER BY NomClient";

                cnx.Open();

                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    codeClient = reader.GetGuid(0);
                    nom = reader.GetString(1);
                    prenom = reader.GetString(2);

                    listeClients.Add(new Client(codeClient, nom, prenom));
                }

                reader.Close();
                return listeClients;
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }
        }

        /// <summary>
        /// Méthode permettant de récuperer dans la base uniquement les clients possédant des animaux ayant besoin d'un rappel dans les 15 jours...
        /// </summary>
        /// <returns></returns>
        public static List<Client> ClientRappel()
        {
            IDbConnection cnx = null;
            String nom, prenom;
            Guid codeclient;
            List<Client> listeClients = new List<Client>();

            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "SELECT DISTINCT nomclient,Prenomclient,codeclient FROM ("+
"SELECT Clients.codeclient,nomclient,Prenomclient,nomanimal,DateConsultation,(DATEADD(MONTH,12,DateConsultation))-15 depart,PeriodeValidite,GETDATE() dateJour FROM Clients INNER JOIN Animaux ON Clients.CodeClient = Animaux.CodeClient " +
                                           "INNER JOIN Consultations ON Consultations.CodeAnimal = Animaux.CodeAnimal "+
                                           "INNER JOIN LignesConsultations ON LignesConsultations.CodeConsultation = Consultations.CodeConsultation "+
                                           "INNER JOIN Baremes ON Baremes.CodeGroupement = LignesConsultations.CodeGroupement AND Baremes.DateVigueur = LignesConsultations.DateVigueur "+
                                           "INNER JOIN Vaccins ON Vaccins.CodeVaccin = Baremes.CodeVaccin) sousrequete "+
                                            "WHERE depart > dateJour;";

                cnx.Open();

                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nom = reader.GetString(0);
                    prenom = reader.GetString(1);
                    codeclient = reader.GetGuid(2);

                    listeClients.Add(new Client(codeclient,nom, prenom));
                }

                reader.Close();
                return listeClients;
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }
        }


        public static List<Animal> AnimauxRappel(Client client)
        {
            IDbConnection cnx = null;
            String nom;
            Guid codeanimal;
            List<Animal> listeAnimaux = new List<Animal>();

            try
            {
                cnx = BDOutils.GetConnexion();
                IDbCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "SELECT DISTINCT nomanimal,code FROM (" +
"SELECT Clients.CodeClient codec,nomanimal,Consultations.codeanimal code,DateConsultation,(DATEADD(MONTH,12,DateConsultation))-15 depart,PeriodeValidite,GETDATE() dateJour FROM Clients INNER JOIN Animaux ON Clients.CodeClient = Animaux.CodeClient " +
                                           "INNER JOIN Consultations ON Consultations.CodeAnimal = Animaux.CodeAnimal " +
                                           "INNER JOIN LignesConsultations ON LignesConsultations.CodeConsultation = Consultations.CodeConsultation " +
                                           "INNER JOIN Baremes ON Baremes.CodeGroupement = LignesConsultations.CodeGroupement AND Baremes.DateVigueur = LignesConsultations.DateVigueur " +
                                           "INNER JOIN Vaccins ON Vaccins.CodeVaccin = Baremes.CodeVaccin) sousrequete " +
                                            "WHERE depart > dateJour AND codec = @codeclient;";
                cnx.Open();

                BDOutils.AddParameter(cmd,"@codeclient",client.Code,DbType.Guid);

                IDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nom = reader.GetString(0);
                    codeanimal =reader.GetGuid(1);
                    listeAnimaux.Add(new Animal(codeanimal,nom));
                }

                reader.Close();
                return listeAnimaux;
            }
            finally
            {
                BDOutils.FermerConnexion(cnx);
            }
        }

    }
}
