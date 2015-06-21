using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniqueVeterinaire.Metier
{
    public class Race
    {
        private string race;
        private string espece;

        public string Races
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

        public string Espece
        {
            get 
            {
                return espece;
            }
            set 
            {
                espece = value;
            }
        }

        public Race(String race, string espece)
        {
            Races = race;
            Espece = espece;
        }

        public override string ToString()
        {
            return espece + "  (" + race +")";
        }
    }
}
