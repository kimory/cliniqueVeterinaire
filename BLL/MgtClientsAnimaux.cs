using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CliniqueVeterinaire.Metier;
using CliniqueVeterinaire.Data;

namespace CliniqueVeterinaire.Application
{
    public class MgtClientsAnimaux
    {
        private Client client;
        private Animal animal;
        private List<Race> race;
        private List<Client> listeClients;
        private List<Animal> listeAnimaux;

        public MgtClientsAnimaux()
        {
            listeClients = new List<Client>();
            listeAnimaux = new List<Animal>();
        }

        public List<Client> ListeClients
        {
            get
            {
                GetClients();
                return listeClients;
            }
        }

        public List<Animal> ListeAnimaux
        {
            get
            {
                GetAnimaux();
                return listeAnimaux;
            }
        }

        /// <summary>
        /// alimente la liste avec l'ensemble des clients (non archivés)
        /// </summary>
        public void GetClients()
        {
            listeClients = BDClient.GetClients();
        }

        /// <summary>
        /// alimente la liste avec l'ensemble des animaux du client
        /// (non archivés)
        /// </summary>
        public void GetAnimaux()
        {
            listeAnimaux = BDClient.GetAnimaux(Client);
        }

       
        public List<Race> Races
        {
            get
            {
                return race;
            }
        }

        public Client Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
            }
        }

        public Animal Animal
        {
            get
            {
                return animal;
            }

            set
            {
                animal = value;
            }
        }

        /// <summary>
        /// récupère le client à la position en paramètre
        /// et le place dans l'attribut client
        /// </summary>
        /// <param name="position"></param>
        public void GetClient(int position, String filtre)
        {
            client = BDClient.GetClient(position, filtre);
        }

        /// <summary>
        /// retourne le nombre de clients non archivés (filtrés ou non par nom)
        /// </summary>
        public int NbClients(String filtreRecherche)
        {
            return BDClient.NbClients(filtreRecherche);
        }

        public void ArchivageClient(Guid codeClient)
        {
            BDClient.ArchivageClient(codeClient);
        }

        public void AjoutClient(Client c)
        {
            BDClient.AjoutClient(c);
        }

        /// <summary>
        /// retourne la position DANS LA LISTE
        /// du client en paramètre
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int GetPositionClient(Client c, String filtreRecherche)
        {
            // on récupère la position en base et on enlève 1
            // (car sql commence à 1, C# à 0)
            return BDClient.GetPositionClient(c, filtreRecherche) - 1;
        }

        public void GetRace()
        {
            race = BDClient.GetRace();
        }

        public void AjoutAnimal(string nom, string couleur, string tatouage, object race, object sexe)
        {
            Animal = new Animal(nom, (string)sexe, couleur, (Race)race, tatouage);
            BDClient.AjoutAnimal(Animal, Client);
        }

        public void ModifierAnimal(string nom, string couleur, string tatouage, object race, object sexe, string code)
        {
            Animal = new Animal(nom, (string)sexe, couleur, (Race)race, tatouage);
            BDClient.ModifierAnimal(Animal, Client, code);
        }

        //Methode permettant de retourner la position de l'objet en fonction du nom passé en paramètre
        public int IndiceRaceListe(string nom)
        {
            int position = -1, i = 0;

            foreach (Race objet in race)
            {
                if (objet.Races == nom)
                {
                    position = i;
                }

                i++;
            }
            return position;
        }

        public void ArchiverAnimal(int position)
        {
            String codeAnimal;
            codeAnimal = Client.ListeAnimaux[position].CodeAnimal.ToString();
            BDClient.ArchiverAnimal(codeAnimal);
        }

        /// <summary>
        /// retourne la position de l'animal (prop. Animal)
        /// dans la liste d'animaux du client (prop. Client)
        /// </summary>
        /// <returns>position de l'animal dans la liste</returns>
        public int GetPositionAnimal()
        {
            // on récupère la position en base et on enlève 1
            // (car sql commence à 1, C# à 0)
            return BDClient.GetPositionAnimal(Animal, Client) - 1;
        }

        public void ChargerAnimauxDansListeClient(List<Client> liste)
        {
            foreach (Client item in liste)
            {
                item.ListeAnimaux = BDClient.GetAnimaux(item);
            }
        }

        public List<Consultation> RechercheConsultations(Metier.Animal animal)
        {
            List<Consultation> Liste_Consultation;

            Liste_Consultation = BDConsultations.RechercheConsultations(animal);

            return Liste_Consultation;
        }

        public List<Client> ClientRappel()
        {
            listeClients = BDClient.ClientRappel();
            return listeClients;
        }

        public List<Metier.Animal> AnimauxRappel()
        {
            List<Animal> AnimauxRappel = new List<Animal>();
            AnimauxRappel = BDClient.AnimauxRappel(client);
            return AnimauxRappel;
        }
    }
}
