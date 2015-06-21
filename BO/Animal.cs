using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniqueVeterinaire.Metier
{
   public class Animal
    {
        #region Attributs
        private Guid codeAnimal;
        private String nomAnimal;
        private String sexe;
        private String couleur;
        private Race race;
        private String tatouage;
        private String antecedents; 
        #endregion

        public Animal(String nom, String sex, String couleur, Race race, String tatouage)
        {
            NomAnimal = nom;
            Sexe = sex;
            Couleur = couleur;
            Race = race;
            Tatouage = tatouage;
        }

        public Animal(Guid code, String nom, String sex, String couleur, Race race, String tatouage)
            : this(nom, sex, couleur, race, tatouage)
        {
            CodeAnimal = code;
        }

       // uniquement code + nom :
        public Animal(Guid code, String nom, string tatouage="")
        {
            CodeAnimal = code;
            NomAnimal = nom;
            Tatouage = tatouage;
        }

        public Guid CodeAnimal
        {
            get
            {
                return codeAnimal;
            }

            set
            {
                codeAnimal = value;
            }
        }

        public String NomAnimal
        {
            get
            {
                return nomAnimal;
            }

            set
            {
                if (Outils.VerifLongueur(value, 30))
                {
                    nomAnimal = value;
                }
                else
                {
                    throw new ApplicationException("Le nom doit être renseigné et " +
                        "doit faire 30 caractères maximum.");
                }
            }
        }

        public String Sexe
        {
            get
            {
                return sexe;
            }

            set
            {
                if (value != null)
                {
                    sexe = value;
                }
                else
                {
                    throw new ApplicationException("Le genre doit être renseigné.");
                }
            }
        }

        public String Couleur
        {
            get
            {
                return couleur;
            }

            set
            {
                if (value.Length <= 20)
                {
                    couleur = value;
                }
                else
                {
                    throw new ApplicationException("La couleur doit faire 20 caractères maximum.");
                }
            }
        }

        public Race Race
        {
            get
            {
                return race;
            }

            set
            {
                race = value;
            }
        }

        public String Tatouage
        {
            get
            {
                return tatouage;
            }

            set
            {
                if (value.Length <= 10)
                {
                    tatouage = value;
                }
                else
                {
                    throw new ApplicationException("Le tatouage doit faire 10 caractères maximum.");
                }
            }
        }

        public String Antecedents
        {
            get
            {
                return antecedents;
            }

            set
            {
                antecedents = value;
            }
        }

        public override string ToString()
        {
            return NomAnimal;
        }
    }
}
