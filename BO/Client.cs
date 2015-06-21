using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniqueVeterinaire.Metier
{
    public class Client
    {
        private Guid code;
        private String nom;
        private String prenom;
        private String adresse1;
        private String adresse2;
        private String codepostal;
        private String ville;
        private List<Animal> listeAnimaux;

        #region constructeurs

        // sans le code :
        public Client(String nom, String prenom, String adresse1,
            String adresse2, String codepostal, string ville)
        {
            Nom = nom;
            Prenom = prenom;
            Adresse1 = adresse1;
            Adresse2 = adresse2;
            CodePostal = codepostal;
            Ville = ville;
        }

        // avec le code :
        public Client(Guid code, String nom, String prenom, String adresse1,
            String adresse2, String codepostal, string ville)
                : this(nom, prenom, adresse1, adresse2, codepostal, ville)
        {
            Code = code;
        }

        // uniquement code, nom, prénom :
        public Client(Guid code, String nom, String prenom)
        {
            Code = code;
            Nom = nom;
            Prenom = prenom;
        }

        public Client(String nom, String prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }
        #endregion

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

        public String Nom
        {
            get
            {
                return nom;
            }

            set
            {
                if(Outils.VerifLongueur(value, 20))
                {
                    nom = value;
                }
                else
                {
                    throw new ApplicationException("Le nom doit être renseigné, et ne doit pas excéder " +
                                                    "20 caractères.");
                }
            }
        }

        public String Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                if(Outils.VerifLongueur(value, 20))
                {
                    prenom = value;
                }
                else
                {
                    throw new ApplicationException("Le prénom doit être renseigné, et ne doit pas excéder " +
                                                    "20 caractères.");
                }
            }
        }

        // nom + prénom (en lecture seule)
        public String NomPrenom
        {
            get
            {
                return nom.ToUpper() + " " + prenom;
            }
        }

        public String Adresse1
        {
            get
            {
                return adresse1;
            }

            set
            {
                if (value.Length <= 30)
                {
                    adresse1 = value;
                }
                else
                {
                    throw new ApplicationException("La 1ère ligne d'adresse ne peut pas excéder 30 caractères.");
                }
            }
        }

        public String Adresse2
        {
            get
            {
                return adresse2;
            }

            set
            {
                if (value.Length <= 30)
                {
                    adresse2 = value;
                }
                else
                {
                    throw new ApplicationException("La 2ème ligne d'adresse ne peut pas excéder 30 caractères.");
                }
            }
        }

        public String CodePostal
        {
            get
            {
                return codepostal;
            }

            set
            {
                if (value.Length <= 6)
                {
                    codepostal = value;
                }
                else
                {
                    throw new ApplicationException("Le code postal ne peut pas faire plus de 6 caractères.");
                }
            }
        }

        public String Ville
        {
            get
            {
                return ville;
            }

            set
            {
                if (value.Length <= 25)
                {
                    ville = value;
                }
                else
                {
                    throw new ApplicationException("La ville ne peut pas excéder 25 caractères.");
                }
            }
        }

        public List<Animal> ListeAnimaux
        {
            get
            {
                return listeAnimaux;
            }

            set
            {
                listeAnimaux = value;
            }
        }
    }
}
