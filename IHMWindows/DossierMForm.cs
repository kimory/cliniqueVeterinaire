using CliniqueVeterinaire.Application;
using CliniqueVeterinaire.Metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHMWindows
{
    public partial class DossierMForm : Form
    {
        private Declarations.ModeRecherche _mode;
        private MgtClientsAnimaux Gestion;
        private List<Client> Liste;
        private List<Consultation> Liste_Consultation;
        //private Guid Nomanimal;

        //Constructeurs pour la form du dossierMedical lorsqu'on l'ouvre depuis le menu principal
        public DossierMForm()
        {
            InitializeComponent();
            Gestion = new MgtClientsAnimaux();
            Liste = Gestion.ListeClients;
            Gestion.ChargerAnimauxDansListeClient(Liste);
            SetUpButtons();
            initialisation();
        }

        //Constructeur appellé depuis le formulaire agenda
        public DossierMForm(Guid nomanimal)
        {
            InitializeComponent();
            Gestion = new MgtClientsAnimaux();
            Liste = Gestion.ListeClients;
            Gestion.ChargerAnimauxDansListeClient(Liste);
            SetUpButtons();
            initialisation();
            GetpositionAnimal(nomanimal);
        }

        private void GetpositionAnimal(Guid code)
        {
            int positionAnimal = 0;
            int positionClient = 0;

            foreach (Client client in Liste)
            {
                foreach (Animal animal in client.ListeAnimaux)
                {
                    if (animal.CodeAnimal == code)
                    {
                        positionAnimal = client.ListeAnimaux.IndexOf(animal);
                        positionClient = Liste.IndexOf(client);
                    }
                }
            }

            comboBoxNomClient.SelectedIndex = positionClient;
            comboBoxNomanimal.SelectedIndex = positionAnimal;

            //On charge le dossier medical à partir de l'animal selectionné...
            try
            {
                Liste_Consultation = Gestion.RechercheConsultations(((Client)comboBoxNomClient.SelectedItem).ListeAnimaux[positionAnimal]);
                ChargerDossier();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message, "Erreur Chargement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void initialisation()
        {
            //On verouille les combobox
            comboBoxNomanimal.Enabled = false;
            comboBoxNomClient.Enabled = false;
            comboBoxPrenomClient.Enabled = false;
            comboBoxTatouage.Enabled = false;
            //richTextBox1.Enabled = false;

            //on charge les combobox avec les valeurs récupérées dans la BD.
            comboBoxNomClient.DataSource = Liste;
            comboBoxNomClient.DisplayMember = "Nom";

            comboBoxPrenomClient.DataSource = Liste;
            comboBoxPrenomClient.DisplayMember = "Prenom";

            //comboBoxNomanimal.DataSource = Liste;
            //comboBoxNomanimal.DisplayMember = "NomAnimal";

            //comboBoxTatouage.DataSource = Liste;
            //comboBoxTatouage.DisplayMember = "Tatouage";
        }

        private Declarations.ModeRecherche Mode
        {
            get
            {
                return _mode;
            }
            set
            {
                _mode = value;
                // on active ou non les combobox en fonction de mode défini dans la propriété
                comboBoxNomanimal.Enabled = ((((Declarations.ModeRecherche)comboBoxNomanimal.Tag) & value) == value);
                comboBoxNomClient.Enabled = ((((Declarations.ModeRecherche)comboBoxNomClient.Tag) & value) == value);
                comboBoxPrenomClient.Enabled = ((((Declarations.ModeRecherche)comboBoxPrenomClient.Tag) & value) == value);
                comboBoxTatouage.Enabled = ((((Declarations.ModeRecherche)comboBoxTatouage.Tag) & value) == value);
            }

        }
        private void SetUpButtons()
        {
            //Cette méthode permet de définir les différents modes pour chaque combobox
            comboBoxNomanimal.Tag = Declarations.ModeRecherche.Animal;
            comboBoxNomClient.Tag = Declarations.ModeRecherche.Client;
            comboBoxPrenomClient.Tag = Declarations.ModeRecherche.Client;
            comboBoxTatouage.Tag = Declarations.ModeRecherche.Tatouage;
        }

        private void Animal_CheckedChanged(object sender, EventArgs e)
        {
            //En fonction du radio bouton checké, on passe le mode adéquate...
            if (Client.Checked == true)
            {
                Mode = Declarations.ModeRecherche.Client;
            }
            else
            {
                if (Animal.Checked == true)
                {
                    Mode = Declarations.ModeRecherche.Animal;
                }
                else
                {
                    Mode = Declarations.ModeRecherche.Tatouage;
                }
            }
        }

        private void comboBoxPrenomClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxNomClient.SelectedIndex;

            comboBoxNomanimal.DataSource = Liste[index].ListeAnimaux;
            comboBoxNomanimal.DisplayMember = "NomAnimal";

            comboBoxTatouage.DataSource = Liste[index].ListeAnimaux;
            comboBoxTatouage.DisplayMember = "Tatouage";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = comboBoxNomanimal.SelectedIndex;
            if (comboBoxNomanimal.SelectedItem != null)
            {
                try
                {
                    Liste_Consultation = Gestion.RechercheConsultations(((Client)comboBoxNomClient.SelectedItem).ListeAnimaux[index]);
                    ChargerDossier();
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message, "Erreur Chargement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void ChargerDossier()
        {
            StringBuilder Dossier = new StringBuilder();
            int numacte;
            //Mise en place de l'entête du dossier medical
            Dossier.AppendLine("Dossier medical de <" + ((Animal)comboBoxNomanimal.SelectedItem).NomAnimal + ">");
            Dossier.AppendLine("Propriétaire : <" + ((Client)comboBoxNomClient.SelectedItem).NomPrenom + ">");
            Dossier.AppendLine("");
            Dossier.AppendLine("");

            //On parcour ensuite chaque consultation
            foreach (Consultation item in Liste_Consultation)
            {
                Dossier.AppendLine("Consultation du : <" + item.DateConsultation.ToString() + "> / Veterinaire : <" + item.Nomveto + ">");
                Dossier.AppendLine("Commentaire : " + item.Commentaire);
                Dossier.AppendLine("");
                numacte = 1;
                //on parcour chaque ligne de consultation pour la consultation en cours...
                foreach (LigneConsultation item2 in item.ListeLigneConsultations)
                {
                    Dossier.AppendLine("<Acte " + numacte + ">");
                    Dossier.AppendLine("Descriptif de l'acte : " + item2.Libelle + "Code : " + item2.Type);
                    Dossier.AppendLine("");
                    numacte++;
                }
            }


            richTextBox1.Text = Dossier.ToString();
        }


    }
}
