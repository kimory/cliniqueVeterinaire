using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniqueVeterinaire.Metier
{
    public class LigneConsultation
    {
        static private int numligne = 1;
        private int numlign;
        private Bareme barem;
        private Double prix;
        private Boolean rappelEnvoye;
        private string type;
        private string libelle;

        public LigneConsultation()
        {
            numlign = numligne;
            numligne++;
        }

        public LigneConsultation(string type, string libelle, Double prix =0, Bareme bar=null)
            : this()
        {
            Type = type;
            Libelle = libelle;
            Prix = prix;
            Barem = bar;
        }

        public int Numligne
        {
            get
            {
                return numlign;
            }
            set
            {
                numlign = value;
            }
        }

        public Bareme Barem
        {
            get
            {
                return barem;
            }
            set
            {
                barem = value;
            }
        }

        public String Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
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
                libelle = value;
            }
        }

        public Double Prix
        {
            get
            {
                return prix;
            }
            set
            {
                if (value < 0)
                    throw new ApplicationException("Le prix d'une consultation ne peut pas être négatif.");

                prix = value;
            }
        }

        public Boolean RappelEnvoye
        {
            get
            {
                return rappelEnvoye;
            }
            set
            {
                rappelEnvoye = value;
            }
        }
    }
}
