using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CliniqueVeterinaire.Metier;
using CliniqueVeterinaire.Data;

namespace CliniqueVeterinaire.Application
{
    public class MgtConnection
    {
        // singleton
        private static MgtConnection instance;

        public static MgtConnection GetInstance()
        {
            if (instance == null)
            {
                instance = new MgtConnection();
            }
            return instance;
        }

        // constructeur privé
        private MgtConnection()
        {
        }

        private Guid codeVeto;

        // l'identifiant du vétérinaire connecté
        public Guid CodeVeto
        {
            get
            {
                return codeVeto;
            }
        }

        public bool VerifMotPasse(string nomVeto, string motpasse)
        {
            bool verif = false;
            // on récupère le code vétérinaire en sortie
            verif = BDVeterinaire.GetLogin(nomVeto, motpasse, out codeVeto);
            return verif;
        }
    }
}
