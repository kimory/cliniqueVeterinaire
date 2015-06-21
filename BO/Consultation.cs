using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniqueVeterinaire.Metier
{
    public class Consultation
    {
        private Guid code;
        private DateTime dateConsultation;
        private Veterinaire veto;
        private String commentaire;
        private List<LigneConsultation> listeLigneConsultation;
        private String nomClient;
        private String nomVeto;
        private Animal animal;

        public Consultation(DateTime dateHeureConsul, String nomDuClient, Animal animalConsul, Veterinaire veterinaire)
            : this(dateHeureConsul, animalConsul, veterinaire)
        {
            NomClient = nomDuClient;
        }

        public Consultation(DateTime dateConsul, String nomveto, String commentaire,List<LigneConsultation> liste = null)
        {
            DateConsultation = dateConsul;
            nomVeto = nomveto;
            Commentaire = commentaire;
            listeLigneConsultation = liste;
        }

        public Consultation(DateTime dateHeureConsul, Animal animalConsul, Veterinaire veterinaire)
        {
            DateConsultation = dateHeureConsul;
            Animal = animalConsul;
            Veto = veterinaire;
        }

        public String Nomveto
        {
            get 
            {
                return nomVeto;
            }
        }

        public Guid Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public DateTime DateConsultation
        {
            get
            {
                return dateConsultation;
            }
            set
            {
                //if (value < DateTime.Now)
                //{
                //    throw new ApplicationException("La date d'une consultation ne peut pas être inférieure à la date du jour");
                //}
                dateConsultation = value;
            }
        }

        public Veterinaire Veto
        {
            get
            {
                return veto;
            }
            set
            {
                veto = value;
            }
        }

        public String Commentaire
        {
            get
            {
                return commentaire;
            }
            set
            {
                commentaire = value;
            }
        }

        public List<LigneConsultation> ListeLigneConsultations
        {
            get
            {
                return listeLigneConsultation;
            }
        }

        public String NomClient
        {
            get
            {
                return nomClient;
            }
            set
            {
                nomClient = value;
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

        public void AjoutLigneConsultation(List<LigneConsultation> liste)
        {
            listeLigneConsultation = liste;
        }
    }
}
