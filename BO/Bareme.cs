using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniqueVeterinaire.Metier
{
    public class Bareme
    {
        private String codeGroupement;
        private String dateVigueur;
        private String typeActe;
        private String libelle;
        private Double tarifFixe;
        private Double tarifMini;
        private Double tarifMaxi;
        private Vaccin vaccin;

        public Bareme(String codegroup, String datev, String type, String libelle, Double Mini, Double Maxi, Double prix)
        {
            TypeActe = type;
            Libelle = libelle;
            TarifMini = Mini;
            TarifMaxi = Maxi;
            TarifFixe = prix;
            CodeGroupement = codegroup;
            DateVigueur = datev;
        }

        public String CodeGroupement
        {
            get
            {
                return codeGroupement;
            }

            set
            {
                if (value.Length == 3)
                {
                    codeGroupement = value;
                }
                else
                {
                    throw new ApplicationException("Le code groupement doit comporter 3 caractères.");
                }
            }
        }

        public String DateVigueur
        {
            get
            {
                return dateVigueur;
            }

            set
            {
               dateVigueur = value; 
            }
        }

        public String TypeActe
        {
            get
            {
                return typeActe;
            }

            set
            {
                typeActe = value;
            }
        }

        public String Libelle
        {
            get
            {
                return libelle;
            }

            set
            {
                if (value.Length <= 30)
                {
                    libelle = value;
                }
                else
                {
                    throw new ApplicationException("Le libellé ne peut pas faire plus de 30 caractères.");
                }
            }
        }

        public Double TarifFixe
        {
            get
            {
                return tarifFixe;
            }

            set
            {
                if (value >= 0)
                {
                    tarifFixe = value;
                }
                else
                {
                    throw new ApplicationException("Le tarif fixe doit être positif.");
                }
            }
        }

        public Double TarifMini
        {
            get
            {
                return tarifMini;
            }

            set
            {
                if (value >= 0)
                {
                    tarifMini = value;
                }
                else
                {
                    throw new ApplicationException("Le tarif minimum doit être positif.");
                }
            }
        }

        public Double TarifMaxi
        {
            get
            {
                return tarifMaxi;
            }

            set
            {
                if (value >= 0)
                {
                    tarifMaxi = value;
                }
                else
                {
                    throw new ApplicationException("Le tarif maximum doit être positif.");
                }
            }
        }

        public Vaccin Vaccin
        {
            get
            {
                return vaccin;
            }

            set
            {
                vaccin = value;
            }
        }
    }
}
