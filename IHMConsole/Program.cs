using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CliniqueVeterinaire.Application;
using CliniqueVeterinaire.Metier;
using System.ComponentModel;


namespace CliniqueVeterinaire.IHM
{
    class Program
    {
        static MgtVeterinaire mgtVeto = new MgtVeterinaire();

        static void Main(string[] args)
        {
            //AjoutVeterinaire();

            //ArchivageVeterinaire();

            ModifMotDePasse();

            AffichageVeterinaire();

            Console.ReadKey();
        }

        private static void ModifMotDePasse()
        {
            String nouveauMdp = "titi67";
            mgtVeto.ReinitialiserMotPasse(new Guid("EE7B7A36-5D10-4916-BE9C-52D91DB3FB86"), nouveauMdp);
        }

        private static void ArchivageVeterinaire()
        {
            //try
            //{
            //    mgtVeto.ArchivageVeto(new Guid("63024D24-21F4-49F0-9A7B-8687DC38C7D6"));
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            try
            {
                mgtVeto.ArchivageVeto(new Guid("EE7B7A36-5D10-4916-BE9C-52D91DB3FB86"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void AffichageVeterinaire()
        {
            mgtVeto.GetVetos();
            BindingList<Veterinaire> listeVetos = mgtVeto.ListeVeto;

            foreach (Veterinaire veto in listeVetos)
            {
                Console.WriteLine(veto.CodeVeto);
                Console.WriteLine(veto.NomVeto);
                Console.WriteLine(veto.MotPasse);
            }
        }

        private static void AjoutVeterinaire()
        {
            string nom = "testNom";
            string mdp = "testMdp";

            mgtVeto.AjoutVeto(nom, mdp);

        }
    }
}
