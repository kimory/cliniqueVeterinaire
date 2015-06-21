using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CliniqueVeterinaire.Metier;
using CliniqueVeterinaire.Data;

namespace CliniqueVeterinaire.Application
{
    public class MgtConsultations
    {
        #region Attributs regroupant le véto + l'animal + la consultation...
        private Veterinaire veto;
        private Animal animal;
        private Consultation consultation;
        private List<Consultation> listeConsultations;
        private List<Bareme> listeinfoBarem;
        #endregion

        #region Constructeurs
        public MgtConsultations(Veterinaire veterinaire, Animal animalconsu)
        {
            veto = veterinaire;
            animal = animalconsu;
        }

        public MgtConsultations()
        {
        } 
        #endregion

        #region Propriétés
        public Consultation Consultation
        {
            get
            {
                return consultation;
            }
            set
            {
                consultation = value;
            }
        }

        public List<Consultation> ListeConsultations
        {
            get
            {
                return listeConsultations;
            }
        }

        public Animal Animal
        {
            get
            {
                return animal;
            }
        }

        public Veterinaire Veterinaire
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

        public List<Bareme> ListeBaremes
        {
            get
            {
                return listeinfoBarem;
            }
        }
        #endregion

        #region Méthodes
        public void GetConsultations(DateTime dateConsultation)
        {
            listeConsultations = BDConsultations.GetConsultations(Veterinaire, dateConsultation);
        }

        public void GetVeto()
        {
            veto = BDVeterinaire.GetVeto();
        }

        public void GetAnimal()
        {
            //animal = BDClient.GetAnimal();
        }

        public void GetBaremes()
        {
            listeinfoBarem = BDConsultations.GetBareme();
        }
        #endregion

        public bool verifConsultationValidee(Consultation consulaverifier)
        {

            return BDConsultations.verifConsultationValidee(consulaverifier);
        }

        public void AjoutConsultation(bool p)
        {
            BDConsultations.AjoutConsultation(p, Consultation);

        }

        public void AjoutTatouage(string p, Guid codeanimal)
        {
            BDClient.Ajouttatouage(p,codeanimal);
            Consultation.Animal.Tatouage = p;
        }

        /// <summary>
        /// on enregistre dans l'agenda
        /// les infos contenues dans la prop. Consultation
        /// </summary>
        public void AjoutEntreeAgenda()
        {
            BDConsultations.AjoutEntreeAgenda(Consultation);
        }

        /// <summary>
        /// on supprime de l'agenda
        /// la consultation stockée dans la prop. Consultation
        /// </summary>
        public void SuppressionEntreeAgenda()
        {
            BDConsultations.SuppressionEntreeAgenda(Consultation);
        }

        public void MiseAjourStockVaccin()
        {
          
            List<LigneConsultation> listeVaccinAMettreAJour = new List<LigneConsultation>();
            //On regarde pour chaque ligne de consultation si un vaccin a été administré
            foreach (LigneConsultation ligne in consultation.ListeLigneConsultations)
            {
                if (ligne.Type == "VACC")
                {
                    //Si la ligne de consultation correspond a un vaccin on l'ajoute dans une liste spécifique...
                    listeVaccinAMettreAJour.Add(ligne);
                }
            }

            if (listeVaccinAMettreAJour.Count != 0)
            {
                //Si on a trouve au moins une ligne de consultation contenant un vaccin alors on fait la mise à jour en base de données
                BDVaccin.MettreAjourStock(listeVaccinAMettreAJour);
            }
        }
    }
}
