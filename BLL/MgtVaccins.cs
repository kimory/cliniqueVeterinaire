using CliniqueVeterinaire.Data;
using CliniqueVeterinaire.Metier;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniqueVeterinaire.Application
{
    public class MgtVaccins
    {
        private List<Vaccin> listeVaccins;

        public List<Vaccin> ListeVaccins
        {
            get
            {
                return listeVaccins;
            }
        }

        /// <summary>
        /// stocke la liste des vaccins (non archivés) dans listeVaccins
        /// </summary>
        public void GetVaccins()
        {
            listeVaccins = BDVaccin.GetVaccins();
        }

        /// <summary>
        /// met à jour la qté en stock du vaccin en paramètre
        /// </summary>
        /// <param name="vaccin">vaccin à mettre à jour</param>
        /// <param name="nouvelleQte">nouvelle qté en stock</param>
        public void MiseAJourStockVaccin(Vaccin vaccin, int nouvelleQte)
        {
            BDVaccin.MiseAJourStockVaccin(vaccin, nouvelleQte);
        }

        /// <summary>
        /// appelle la méthode de la DAL pour l'export des vaccins en CSV
        /// </summary>
        /// <param name="nomFichier">fichier dans lequel l'enregistrement doit se faire</param>
        /// <param name="nomDesVaccinsACder">liste des noms des vaccins en rupture de stock</param>
        public void GenererCsv(string nomFichier, List<String> nomDesVaccinsACder)
        {
            BDVaccin.GenererCsv(nomFichier, nomDesVaccinsACder);
        }
    }
}
