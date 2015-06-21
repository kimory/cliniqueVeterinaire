using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniqueVeterinaire.Metier
{
     class Outils
    {
         /// <summary>
         /// Méthode permettant de checker la longueur d'une chaine par rapport à une taille limite 
         /// </summary>
         /// <param name="chaine"></param>
         /// <param name="longueurMax"></param>
         /// <returns>Vrai si ok</returns>
         public static bool VerifLongueur(String chaine, int longueurMax)
         {
             bool verif = false;

             if (!string.IsNullOrEmpty(chaine) && chaine.Length <= longueurMax)
             {
                 verif = true;
             }
             return verif;
         }
    }
}
