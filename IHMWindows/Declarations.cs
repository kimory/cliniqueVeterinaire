using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHMWindows
{
    public abstract class Declarations
    {
        /// <summary>
        /// définition des modes écran retenus
        /// </summary>
        [Flags]
        public enum ModesEcran
        {
            Neutre = 1,
            Selection = 2,
            Ajout = 4,
            Modification = 8,
            Suppression = 16,
            Recherche = 32
        }

        public enum ModeRecherche
        {
            Client = 1,
            Animal = 2,
            Tatouage = 4
        }
    }
}
