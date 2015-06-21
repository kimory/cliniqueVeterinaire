using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CliniqueVeterinaire.Application;
using CliniqueVeterinaire.Metier;
using System.Collections;

namespace IHMWindows
{
    public partial class AgendaForm : Form
    {
        private MgtConsultations gestion;
        private MgtVeterinaire mgtVeterinaire;
        private MgtConnection mgtConnection;

        public AgendaForm()
        {
            InitializeComponent();
            gestion = new MgtConsultations();
            mgtVeterinaire = new MgtVeterinaire();
            mgtConnection = MgtConnection.GetInstance();
        }

        private void AgendaForm_Load(object sender, EventArgs e)
        {
            // On construit le DataGridView :
            IHMOutils.InitialiserPlanning(dgvAgenda);

            ChargerListeVeterinaires();

            // On charge le planning du vétérinaire :
            //IHMOutils.ChargerPlanning(cbxVeterinaire, dtpAgenda, gestion, dgvAgenda);
            // appelée automatiquement, cf SelectionVeterinaireOuDate()
        }

        private void ChargerListeVeterinaires()
        {
            // La comboBox est alimentée avec la liste des vétérinaires
            cbxVeterinaire.DataSource = mgtVeterinaire.ListeVeto;
            // pour l'affichage, on se sert de la propriété NomVeto des Vétérinaires :
            cbxVeterinaire.DisplayMember = "NomVeto";

            // on récupère le code du vétérinaire connecté.
            // par défaut, on affiche son propre planning :
            int indexVeto = -1;
            bool indiceTrouve = false;
            for (int i = 0; i < mgtVeterinaire.ListeVeto.Count && !indiceTrouve; i++)
            {
                if (mgtVeterinaire.ListeVeto[i].CodeVeto == mgtConnection.CodeVeto)
                {
                    indexVeto = i;
                    indiceTrouve = true;
                }
            }

            cbxVeterinaire.SelectedIndex = indexVeto;
        }
        
        // méthode appelée lorsqu'on sélectionne un nouveau vétérinaire OU une nouvelle date :
        private void SelectionVeterinaireOuDate(object sender, EventArgs e)
        {
            IHMOutils.ChargerPlanning(cbxVeterinaire, dtpAgenda, gestion, dgvAgenda);
        }

        private void dgvAgenda_DoubleClic(object sender, EventArgs e)
        {
            // si une ligne a été sélectionnée
            if (dgvAgenda.SelectedRows.Count == 1)
            {
                int indexLigne = dgvAgenda.SelectedRows[0].Index;
                // on passe en paramètre l'élément Consultation sélectionné
                ConsultationForm consulForm = new ConsultationForm(gestion.ListeConsultations[indexLigne]);

                if (gestion.verifConsultationValidee(gestion.ListeConsultations[indexLigne]))
                {
                    consulForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("La consultation a déjà été validée, elle ne " +
                        "peut pas être modifiée.");
                }
            }
        }

        private void btnDossierMedical_Click(object sender, EventArgs e)
        {
            if (dgvAgenda.SelectedRows.Count == 1)
            {
                int indexLigne = dgvAgenda.SelectedRows[0].Index;
                DossierMForm Dossiermedical = new DossierMForm(gestion.ListeConsultations[indexLigne].Animal.CodeAnimal);
                Dossiermedical.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aucun animal n'a été selectionné !"); 
            }
        }
    }
}
