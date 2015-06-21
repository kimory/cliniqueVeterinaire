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

namespace IHMWindows
{
    public partial class RdvForm : Form
    {
        private MgtClientsAnimaux mgtClientsAnimaux;
        private MgtVeterinaire mgtVeterinaire;
        private MgtConsultations mgtConsul;

        public RdvForm()
        {
            InitializeComponent();
            mgtClientsAnimaux = new MgtClientsAnimaux();
            mgtVeterinaire = new MgtVeterinaire();
            mgtConsul = new MgtConsultations();
        }

        // au chargement du formulaire
        private void RdvForm_Load(object sender, EventArgs e)
        {
            // on charge les comboxBox "heures et minutes" :
            // de 8h à 18h
            for (int i = 8; i <= 18; i++)
            {
                cbxHeures.Items.Add(i);
            }
            cbxHeures.SelectedIndex = 0;

            // tous les quarts d'heure
            for (int i = 00; i < 60; i += 15)
            {
                cbxMinutes.Items.Add(String.Format("{0:00}", i)); // pour avoir "8h00" et pas "8h0"
            }
            cbxMinutes.SelectedIndex = 0;

            // on construit le DataGridView pour le planning:
            IHMOutils.InitialiserPlanning(dgvRdv);

            // on charge les listes dans les ComboBoxes (vétérinaires, clients, animaux)
            ChargerVeterinaires();
            ChargerClients();
            // on stocke le client sélectionné...
            mgtClientsAnimaux.Client = (Client)cbxClient.SelectedItem;
            // ... pour afficher uniquement les animaux de ce client :
            ChargerAnimaux();

            // on charge le planning du vétérinaire
            //IHMOutils.ChargerPlanning(cbxVeterinaire, dtpRdv, mgtConsul, dgvRdv);
            // appelée automatiquement au chargement des vétérinaires,
            // cf SelectionVeterinaireOuDate()
    
            // on fait en sorte qu'un clic dans une cellule sélectionne la ligne entière
            // et qu'une seule ligne puisse être sélectionnée à la fois :
            dgvRdv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRdv.MultiSelect = false;
        }

        /// <summary>
        /// alimente la ComboBox avec la liste des clients
        /// </summary>
        private void ChargerClients()
        {
            // note : la méthode cbxClient_SelectedIndexChanged devrait être appelée ici, 
            // pour éviter ce comportement on fait un désabonnement / réabonnement...
            cbxClient.SelectedIndexChanged -= cbxClient_SelectedIndexChanged;

            cbxClient.DataSource = null;
            cbxClient.DataSource = mgtClientsAnimaux.ListeClients;
            // pour l'affichage, on se sert de la propriété NomPrenom :
            cbxClient.DisplayMember = "NomPrenom";

            cbxClient.SelectedIndexChanged += cbxClient_SelectedIndexChanged;
        }

        // alimente la ComboBox avec la liste des animaux
        // du client mgtClientsAnimaux.Client
        private void ChargerAnimaux()
        {
            cbxAnimal.DataSource = null;
            cbxAnimal.DataSource = mgtClientsAnimaux.ListeAnimaux;
            // affichage via la propriété NomAnimal :
            cbxAnimal.DisplayMember = "NomAnimal";
        }

        /// <summary>
        /// alimente la ComboBox avec la liste des vétérinaires
        /// </summary>
        private void ChargerVeterinaires()
        {
            cbxVeterinaire.DataSource = null;
            cbxVeterinaire.DataSource = mgtVeterinaire.ListeVeto;
            // affichage via la propriété NomVeto :
            cbxVeterinaire.DisplayMember = "NomVeto";
        }

        /// <summary>
        /// à chaque sélection d'un nouveau client,
        /// il est stocké dans la prop. Client du mgtClientsAnimaux et
        /// la liste de ses animaux est chargée dans la ComboBox correspondante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            mgtClientsAnimaux.Client = (Client)cbxClient.SelectedItem;
            ChargerAnimaux();
        }

        // pour ajouter un client via l'écran des clients
        private void btnAjoutClient_Click(object sender, EventArgs e)
        {
            //On teste si un formulaire client est déja ouvert...si oui on le ferme

            foreach (Form Forms in Application.OpenForms)
            {
                if (Forms.Name == "ClientForm")
                {
                    Forms.Close();
                    break;
                }
            }

            // ouverture du formulaire "Client" (travail sur le même manager) :
            ClientForm formClient = new ClientForm(mgtClientsAnimaux);
            formClient.ShowDialog();

            // on récupère la position du client sur lequel
            // on se trouvait avant de fermer le formulaire "client"
            // (a priori le client nouvellement inséré).
            int pos = mgtClientsAnimaux.GetPositionClient(mgtClientsAnimaux.Client, "");

            // on recharge la liste :
            ChargerClients();

            // On sélectionne le client voulu dans la combobox 
            // (cela entraîne également l'appel de la méthode ChargerAnimaux())
            cbxClient.SelectedIndex = pos;
        }

        private void btnAjoutAnimal_Click(object sender, EventArgs e)
        {
            // ouverture du formulaire "Animal" (travail sur le même manager) :
            AnimalForm formAnimal = new AnimalForm(mgtClientsAnimaux);
            formAnimal.ShowDialog();

            if (mgtClientsAnimaux.Animal != null)
            {
                // on recharge la liste :
                ChargerAnimaux();
                // on se place sur l'animal ajouté :
                cbxAnimal.SelectedIndex = mgtClientsAnimaux.GetPositionAnimal();
            }

        }

        // méthode appelée lorsqu'on sélectionne un nouveau vétérinaire 
        // OU une nouvelle date :
        private void SelectionVeterinaireOuDate(object sender, EventArgs e)
        {
            IHMOutils.ChargerPlanning(cbxVeterinaire, dtpRdv, mgtConsul, dgvRdv);
        }

        /// <summary>
        /// réinitialise le formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // on revient sur le 1er client de la liste, le 1er vétérinaire,
            // la date du jour...
            if (cbxClient.Items.Count > 0) // s'il y a au moins un client
            {
                cbxClient.SelectedIndex = 0;
            }

            if (cbxVeterinaire.Items.Count > 0) // s'il y a au moins un véto
            {
                cbxVeterinaire.SelectedIndex = 0;
            }

            dtpRdv.Value = DateTime.Now;
            cbxHeures.SelectedIndex = 0;
            cbxMinutes.SelectedIndex = 0;
        }

        /// <summary>
        /// valide l'enregistrement du rendez-vous
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxAnimal.SelectedIndex != -1 && cbxVeterinaire.SelectedIndex != -1)
                {
                    // on récupère la date du DateTimePicker (à minuit) :
                    DateTime dateChoisie = dtpRdv.Value.Date;
                    // on ajoute les heures sélectionnées :
                    dateChoisie = dateChoisie.AddHours((int)cbxHeures.SelectedItem);

                    // les minutes sont d'abord récupérées au format String (cf formatage)
                    String min = (String)cbxMinutes.SelectedItem;
                    // on ajoute les minutes :
                    dateChoisie = dateChoisie.AddMinutes(int.Parse(min));

                    // on stocke la consultation dans l'attribut Consultation :
                    mgtConsul.Consultation = new Consultation(dateChoisie,
                                                (Animal)cbxAnimal.SelectedItem,
                                                (Veterinaire)cbxVeterinaire.SelectedItem);
                    // on ajoute la ligne dans l'agenda :
                    mgtConsul.AjoutEntreeAgenda();
                    // on recharge le planning :
                    IHMOutils.ChargerPlanning(cbxVeterinaire, dtpRdv, mgtConsul, dgvRdv);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUrgence_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxAnimal.SelectedIndex != -1 && cbxVeterinaire.SelectedIndex != -1)
                {
                    // on stocke la consultation dans l'attribut Consultation du mgt :
                    // pour une urgence la date enregistrée est celle du moment
                    mgtConsul.Consultation = new Consultation(DateTime.Now,
                                                (Animal)cbxAnimal.SelectedItem,
                                                (Veterinaire)cbxVeterinaire.SelectedItem);
                }

                // on ajoute la ligne dans l'agenda :
                mgtConsul.AjoutEntreeAgenda();

                // on recharge le planning :
                IHMOutils.ChargerPlanning(cbxVeterinaire, dtpRdv, mgtConsul, dgvRdv);

                // on affiche un message (car la modif n'est pas directement visible
                // si on a le planning d'un autre jour à l'écran)
                MessageBox.Show("La consultation \"en urgence\" a bien été enregistrée.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                // si une ligne a bien été sélectionnée
                if (dgvRdv.SelectedRows.Count == 1)
                {
                    int indexLigne = dgvRdv.SelectedRows[0].Index;

                    // on stocke la consultation dans l'attribut Consultation du mgt :
                    mgtConsul.Consultation = mgtConsul.ListeConsultations[indexLigne];

                    // on supprime la ligne de l'agenda :
                    mgtConsul.SuppressionEntreeAgenda();

                    // on recharge le planning :
                    IHMOutils.ChargerPlanning(cbxVeterinaire, dtpRdv, mgtConsul, dgvRdv);
                }
                else
                {
                    MessageBox.Show("Vous devez sélectionner une ligne de rendez-vous, " +
                                    "afin de supprimer l'enregistrement correspondant.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
