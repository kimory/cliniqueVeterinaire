using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniqueVeterinaire.Metier
{
    public class Veterinaire
    {
        #region Attributs
        private Guid codeVeto;
        private String nomVeto;
        private String motPasse;
       // private Boolean archive;
        #endregion

        #region Propriétés
        public Guid CodeVeto
        {
            get { return codeVeto; }
        }

        public String NomVeto
        {
            get
            {
                return nomVeto;
            }

            set
            {
                if (!Outils.VerifLongueur(value,30))
                {
                    throw new ApplicationException("Le nom doit être renseigné et doit " +
                        "comporter 30 caractères maximum.");
                }

                nomVeto = value;
            }
        }

        public String MotPasse
        {
            get
            {
                return motPasse;
            }

            set
            {
                if (!Outils.VerifLongueur(value, 10))
                {
                    throw new ApplicationException("Le mot de passe doit être renseigné et doit " +
                        "comporter 10 caractères maximum.");
                }

                motPasse = value;
            }
        }

        #endregion

        #region Constructeurs
        /*
        public Veterinaire(String nom, String mdp, Boolean archive = false)
        {
            codeVeto = Guid.NewGuid();
            NomVeto = nom;
            MotPasse = mdp;
            Archive = archive;
        }*/

        public Veterinaire(Guid codeVeto, String nom, String mdp)
        {
            this.codeVeto = codeVeto;
            NomVeto = nom;
            MotPasse = mdp;
            
        }

        public Veterinaire(String nom)
        {
            NomVeto = nom;
        }
        #endregion
    }
}
