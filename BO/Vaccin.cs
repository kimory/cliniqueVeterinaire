using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniqueVeterinaire.Metier
{
    public class Vaccin
    
    {
        private Guid code;
        private String nom;
        private int quantiteStock;
        private int periodeValidite;

        public Vaccin(Guid codeVaccin, String nomVaccin, int qte, int validite)
        {
            Code = codeVaccin;
            Nom = nomVaccin;
            QuantiteStock = qte;
            PeriodeValidite = validite;
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

        public String Nom
        {
            get
            {
                return nom;
            }

            set
            {
                if (Outils.VerifLongueur(value, 30))
                {
                    nom = value;
                }
                else
                {
                    throw new ApplicationException("Le nom du vaccin doit être renseigné et doit " +
                        "comporter 30 caractères maximum.");
                }
            }
        }

        public int QuantiteStock
        {
            get
            {
                return quantiteStock;
            }

            set
            {
                if (value >= 0)
                {
                    quantiteStock = value;
                }
                else
                {
                    throw new ApplicationException("La quantité en stock doit être positive.");
                }
            }
        }

        public int PeriodeValidite
        {
            get
            {
                return periodeValidite;
            }

            set
            {
                if (value >= 0)
                {
                    periodeValidite = value;
                }
                else
                {
                    throw new ApplicationException("La période de validité doit être positive.");
                }
            }
        }
    }
}
