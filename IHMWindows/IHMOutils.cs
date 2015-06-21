using CliniqueVeterinaire.Application;
using CliniqueVeterinaire.Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHMWindows
{
    class IHMOutils
    {
        /// <summary>
        /// initialise le planning : crée les colonnes et les dimensionne
        /// </summary>
        /// <param name="dgv"></param>
        internal static void InitialiserPlanning(DataGridView dgv)
        {
            // on construit le DataGridView :
            dgv.ColumnCount = 4;

            // les en-têtes :
            dgv.Columns[0].Name = "Heure";
            dgv.Columns[1].Name = "Nom du client";
            dgv.Columns[2].Name = "Animal";
            dgv.Columns[3].Name = "Race";

            // pour que les colonnes occupent toute la largeur de la grille :
            //for (int i = 0 ; i < dgv.Columns.Count ; i++)
            //{
            //    dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //}
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// affiche dans la DataGridView le planning du vétérinaire sélectionné
        /// à la dateChoisie
        /// </summary>
        /// <param name="cbxVeterinaire">ComboBox pour le choix du vétérinaire</param>
        /// <param name="dtp">DateTimePicker pour le choix de la date</param>
        /// <param name="mgtConsul">MgtConsultations utilisé</param>
        /// <param name="dgv">DataGridView dans laquelle on affiche le planning</param>
        internal static void ChargerPlanning(ComboBox cbxVeterinaire, DateTimePicker dtp,
                                             MgtConsultations mgtConsul, DataGridView dgv)
        {
            // on récupère le vétérinaire sélectionné :
            mgtConsul.Veterinaire = (Veterinaire)cbxVeterinaire.SelectedItem;

            // on alimente la liste de consultations :
            // on prévoit le cas où il n'y a pas de données...
            if (mgtConsul.Veterinaire != null)
            {
                mgtConsul.GetConsultations(dtp.Value);
            }

            // on efface les données précédemment affichées :
            dgv.Rows.Clear();

            // on affiche le détail de chaque consultation
            // on prévoit le cas où il n'y a pas de données...
            if (mgtConsul.ListeConsultations != null)
            {
                foreach (Consultation consul in mgtConsul.ListeConsultations)
                {
                    dgv.Rows.Add(String.Format("{0:HH:mm}", consul.DateConsultation), // heure uniquement
                                        consul.NomClient,
                                        consul.Animal.ToString(),
                                        consul.Animal.Race.Espece); // chien, tortue...
                }
            }
        }
    }
}
