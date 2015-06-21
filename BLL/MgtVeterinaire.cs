using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CliniqueVeterinaire.Metier;
using CliniqueVeterinaire.Data;
using System.ComponentModel;

namespace CliniqueVeterinaire.Application
{
    public class MgtVeterinaire
    {
        BindingList<Veterinaire> listeVeto;

        public BindingList<Veterinaire> ListeVeto
        {
            get 
            {
                GetVetos();
                return listeVeto; 
            }
        }

        public MgtVeterinaire()
        {
            listeVeto = new BindingList<Veterinaire>();
        }

        public void GetVetos()
        {
            listeVeto = BDVeterinaire.GetVetos();
        }

        public void AjoutVeto(String nom, String motPasse)
        {
            // ajout en base
            BDVeterinaire.AjoutVeto(nom, motPasse);

            // ajout dans la liste
            GetVetos();
        }

        public void ArchivageVeto(Guid codeVeto)
        {
            BDVeterinaire.ArchivageVeto(codeVeto);
        }

        public void ReinitialiserMotPasse(Guid codeVeto, String nouveauMotPasse)
        {
            BDVeterinaire.ReinitialiserMotPasse(codeVeto, nouveauMotPasse);
        }
    }
}
