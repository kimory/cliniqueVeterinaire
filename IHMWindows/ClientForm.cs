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
    public partial class ClientForm : Form
    {
        private MgtClientsAnimaux gestion;
        private int indiceCourant = 0;
        private Declarations.ModesEcran mode;


        // prop. auto-implémentée (correspond au filtre de recherche par nom)
        public String FiltreRecherche { get; set; }

        private int IndiceCourant
        {
            get { return indiceCourant; }
            set
            {
                indiceCourant = value;

                if (gestion.NbClients(FiltreRecherche) > 0)
                {
                    gestion.GetClient(indiceCourant, FiltreRecherche);
                    AfficherClientCourant();
                }
            }
        }

        private Declarations.ModesEcran Mode
        {
            get { return mode; }
            set
            {
                mode = value;

                // au changement de mode, on active/désactive les contrôles concernés :
                // note : Tag retourne un objet
                btnValiderAjout.Enabled = (((Declarations.ModesEcran)btnValiderAjout.Tag & mode) == mode);
                btnAnnulerAjout.Enabled = (((Declarations.ModesEcran)btnAnnulerAjout.Tag & mode) == mode);

                btnAjouterClient.Enabled = (((Declarations.ModesEcran)btnAjouterClient.Tag & mode) == mode);
                btnPremier.Enabled = (((Declarations.ModesEcran)btnPremier.Tag & mode) == mode);
                btnPrecedent.Enabled = (((Declarations.ModesEcran)btnPrecedent.Tag & mode) == mode);
                btnSuivant.Enabled = (((Declarations.ModesEcran)btnSuivant.Tag & mode) == mode);
                btnDernier.Enabled = (((Declarations.ModesEcran)btnDernier.Tag & mode) == mode);
                btnSupprimerClient.Enabled = (((Declarations.ModesEcran)btnSupprimerClient.Tag & mode) == mode);
                btnAjouterAnimal.Enabled = (((Declarations.ModesEcran)btnAjouterAnimal.Tag & mode) == mode);
                btnSupprimerAnimal.Enabled = (((Declarations.ModesEcran)btnSupprimerAnimal.Tag & mode) == mode);
                btnEditerAnimal.Enabled = (((Declarations.ModesEcran)btnEditerAnimal.Tag & mode) == mode);
                cbxRechercher.Enabled = (((Declarations.ModesEcran)cbxRechercher.Tag & mode) == mode);
                tbxRechercher.Enabled = (((Declarations.ModesEcran)tbxRechercher.Tag & mode) == mode);

                dgvAnimaux.Enabled = (((Declarations.ModesEcran)dgvAnimaux.Tag & mode) == mode);

                tbxCode.Enabled = (((Declarations.ModesEcran)tbxCode.Tag & mode) == mode);
                tbxNom.Enabled = (((Declarations.ModesEcran)tbxNom.Tag & mode) == mode);
                tbxPrenom.Enabled = (((Declarations.ModesEcran)tbxPrenom.Tag & mode) == mode);
                tbxAdresse1.Enabled = (((Declarations.ModesEcran)tbxAdresse1.Tag & mode) == mode);
                tbxAdresse2.Enabled = (((Declarations.ModesEcran)tbxAdresse2.Tag & mode) == mode);
                tbxCodePostal.Enabled = (((Declarations.ModesEcran)tbxCodePostal.Tag & mode) == mode);
                tbxVille.Enabled = (((Declarations.ModesEcran)tbxVille.Tag & mode) == mode);

                switch (value)
                {
                    case Declarations.ModesEcran.Ajout:

                        // les boutons pour valider ou annuler l'ajout sont affichés :
                        btnValiderAjout.Visible = true;
                        btnAnnulerAjout.Visible = true;
                        break;
                    default:

                        // les boutons pour valider ou annuler l'ajout "disparaissent" de l'écran :
                        btnValiderAjout.Visible = false;
                        btnAnnulerAjout.Visible = false;
                        break;
                }
            }
        }

        #region Constructeurs
        // constructeur par défaut
        public ClientForm()
        {
            InitializeComponent();
            gestion = new MgtClientsAnimaux();
        }

        // constructeur utilisé lorsque le form. Client est instancié depuis le form. RDV
        // (travail sur le même Mgt)
        public ClientForm(MgtClientsAnimaux mgtClient)
        {
            InitializeComponent();
            gestion = mgtClient;
        }
        #endregion

        // au chargement du formulaire
        private void ClientForm_Load(object sender, EventArgs e)
        {
            // le filtre de recherche (par nom) :
            FiltreRecherche = "";

            // pour chaque contrôle, on enregistre les états qui l'activent :
            btnPremier.Tag = Declarations.ModesEcran.Selection | Declarations.ModesEcran.Recherche | Declarations.ModesEcran.Suppression;
            btnPrecedent.Tag = Declarations.ModesEcran.Selection | Declarations.ModesEcran.Recherche | Declarations.ModesEcran.Suppression;
            btnSuivant.Tag = Declarations.ModesEcran.Selection | Declarations.ModesEcran.Recherche | Declarations.ModesEcran.Suppression;
            btnDernier.Tag = Declarations.ModesEcran.Selection | Declarations.ModesEcran.Recherche | Declarations.ModesEcran.Suppression;
            btnSupprimerClient.Tag = Declarations.ModesEcran.Selection | Declarations.ModesEcran.Recherche | Declarations.ModesEcran.Suppression;
            btnAjouterAnimal.Tag = Declarations.ModesEcran.Selection | Declarations.ModesEcran.Recherche | Declarations.ModesEcran.Suppression;
            btnSupprimerAnimal.Tag = Declarations.ModesEcran.Selection | Declarations.ModesEcran.Recherche | Declarations.ModesEcran.Suppression;
            btnEditerAnimal.Tag = Declarations.ModesEcran.Selection | Declarations.ModesEcran.Recherche | Declarations.ModesEcran.Suppression;
            cbxRechercher.Tag = Declarations.ModesEcran.Selection | Declarations.ModesEcran.Recherche | Declarations.ModesEcran.Suppression;
            tbxRechercher.Tag = Declarations.ModesEcran.Selection | Declarations.ModesEcran.Recherche | Declarations.ModesEcran.Suppression;

            btnAjouterClient.Tag = Declarations.ModesEcran.Selection | Declarations.ModesEcran.Suppression;

            btnValiderAjout.Tag = Declarations.ModesEcran.Ajout;
            btnAnnulerAjout.Tag = Declarations.ModesEcran.Ajout;

            dgvAnimaux.Tag = Declarations.ModesEcran.Selection | Declarations.ModesEcran.Recherche | Declarations.ModesEcran.Suppression;

            // le code est généré, il n'est pas ajouté "à la main" :
            tbxCode.Tag = 0;

            tbxNom.Tag = Declarations.ModesEcran.Ajout;
            tbxPrenom.Tag = Declarations.ModesEcran.Ajout;
            tbxAdresse1.Tag = Declarations.ModesEcran.Ajout;
            tbxAdresse2.Tag = Declarations.ModesEcran.Ajout;
            tbxCodePostal.Tag = Declarations.ModesEcran.Ajout;
            tbxVille.Tag = Declarations.ModesEcran.Ajout;

            // au départ on est en mode "sélection" :
            Mode = Declarations.ModesEcran.Selection;

            try
            {
                // on récupère le client à l'indice souhaité
                // (le client sera ensuite accessible 
                // via la prop. "Client" du manager "gestion")
                if (gestion.NbClients(FiltreRecherche) > 0)
                {
                    gestion.GetClient(IndiceCourant, FiltreRecherche);
                    AfficherClientCourant();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AfficherClientCourant()
        {
            if (gestion.Client != null)
            {
                // on alimente les textBoxs avec les infos du client :
                tbxCode.Text = gestion.Client.Code.ToString();
                tbxNom.Text = gestion.Client.Nom;
                tbxPrenom.Text = gestion.Client.Prenom;
                tbxAdresse1.Text = gestion.Client.Adresse1;
                tbxAdresse2.Text = gestion.Client.Adresse2;
                tbxCodePostal.Text = gestion.Client.CodePostal;
                tbxVille.Text = gestion.Client.Ville;

                // on récupère la liste des animaux liés au client
                // via la prop. ListeAnimaux du client. 
                // La dataGridView est alimentée avec cette liste.
                //Propriété autogeneratecolumns permet d'autoriser la génération automatique des colonnes
                dgvAnimaux.AutoGenerateColumns = true;
                dgvAnimaux.DataSource = gestion.Client.ListeAnimaux;
                // la colonne N°7 (antécédents) n'est pas affichée :
                dgvAnimaux.Columns[6].Visible = false;
            }
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            // on revient sur le premier élt de la liste
            IndiceCourant = 0;
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            // on "recule" dans la liste si c'est encore possible
            if (IndiceCourant >= 1)
            {
                IndiceCourant -= 1;
            }
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            // on "avance" dans la liste si c'est encore possible
            if (IndiceCourant <= gestion.NbClients(FiltreRecherche) - 2)
            {
                IndiceCourant += 1;
            }
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            // le dernier élt de la liste = nb de clients - 1
            IndiceCourant = gestion.NbClients(FiltreRecherche) - 1;
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            DialogResult choix;
            if (gestion.Client != null)
            {
                choix = MessageBox.Show("Voulez-vous vraiment supprimer ce client ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (choix == DialogResult.Yes)
                {
                    try
                    {
                        gestion.ArchivageClient(gestion.Client.Code);

                        // une fois le client supprimé, on affiche le client précédent dans la liste
                        if (IndiceCourant >= 1)
                        {
                            IndiceCourant -= 1;
                        }
                        else
                        {
                            // sinon si le client archivé est le 1er de la liste,
                            // on affiche le client suivant qui est désormais à l'indice zéro
                            if (gestion.NbClients(FiltreRecherche) > 0)
                            {
                                IndiceCourant = 0;
                            }
                            // si il n'y a plus de client, on vide la liste et les TextBox :
                            else
                            {
                                ViderFormulaire();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        // vide la liste d'animaux et les TextBox :
        private void ViderFormulaire()
        {
            dgvAnimaux.DataSource = null;
            tbxCode.Clear();
            tbxNom.Clear();
            tbxPrenom.Clear();
            tbxAdresse1.Clear();
            tbxAdresse2.Clear();
            tbxCodePostal.Clear();
            tbxVille.Clear();
        }

        // pour ajouter un nouveau client :
        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            // on passe en mode "ajout" :
            Mode = Declarations.ModesEcran.Ajout;

            // la liste des animaux et les TextBox sont vidées :
            ViderFormulaire();
        }

        // pour annuler l'ajout d'un nouveau client :
        private void btnAnnulerAjout_Click(object sender, EventArgs e)
        {
            // on vide le formulaire, et on réaffiche les infos du client courant
            // s'il existe (l'indice courant est toujours en mémoire) :
            ViderFormulaire();
            AfficherClientCourant();

            // on repasse en mode "sélection" :
            Mode = Declarations.ModesEcran.Selection;
        }

        // pour valider l'ajout d'un nouveau client :
        private void btnValiderAjout_Click(object sender, EventArgs e)
        {
            try
            {
                Client c = new Client(tbxNom.Text, tbxPrenom.Text, tbxAdresse1.Text, tbxAdresse2.Text,
                                        tbxCodePostal.Text, tbxVille.Text);
                gestion.AjoutClient(c);

                // on se positionne sur l'indice du nouveau client :
                IndiceCourant = gestion.GetPositionClient(c, FiltreRecherche);

                // on repasse en mode "sélection" :
                Mode = Declarations.ModesEcran.Selection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAjouterAnimal_Click(object sender, EventArgs e)
        {
            if (gestion.Client != null)
            {
                try
                {
                    AnimalForm formAnimal = new AnimalForm(gestion);
                    formAnimal.ShowDialog();
                    gestion.GetClient(indiceCourant, "");
                    AfficherClientCourant();
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }
            }

        }

        private void btnSupprimerAnimal_Click(object sender, EventArgs e)
        {
            if (dgvAnimaux.SelectedRows.Count != 0)
            {
                try
                {
                    gestion.ArchiverAnimal(dgvAnimaux.SelectedRows[0].Index);
                    gestion.GetClient(indiceCourant, "");
                    AfficherClientCourant();
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }

            }

        }

        private void btnEditerAnimal_Click(object sender, EventArgs e)
        {
            if (dgvAnimaux.SelectedRows.Count != 0)
            {
                AnimalForm formAnimal = new AnimalForm(gestion, dgvAnimaux.SelectedRows[0].Index);
                formAnimal.ShowDialog();
                gestion.GetClient(indiceCourant, "");
                AfficherClientCourant();
                //RefreshForm();
            }
            else
            {
                MessageBox.Show("Veuillez d'abord selectionner un animal");
            }
        }

        private void cbxRechercher_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxRechercher.Checked)
            {
                // si on souhaite filtrer les clients par nom
                FiltreRecherche = tbxRechercher.Text;
                Mode = Declarations.ModesEcran.Recherche;

                try
                {
                    // s'il y a au moins un client
                    if (gestion.NbClients(FiltreRecherche) > 0)
                    {
                        // on récupère le client à l'indice 0
                        IndiceCourant = 0;
                        gestion.GetClient(IndiceCourant, FiltreRecherche);
                        AfficherClientCourant();
                        erpClients.SetError(cbxRechercher, "");
                    }
                    else
                    {
                        // sinon on indique que le client n'a pas été trouvé
                        erpClients.SetError(cbxRechercher, "Aucun résultat");
                        // et on revient sur la liste complète :
                        FiltreRecherche = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                // si on ne souhaite plus filtrer
                FiltreRecherche = "";
                erpClients.SetError(cbxRechercher, "");
                tbxRechercher.Clear();
                Mode = Declarations.ModesEcran.Selection;

                try
                {
                    // on récupère l'indice courant du client actuel
                    // (s'il existe = si la liste n'est pas vide) :
                    if (gestion.Client != null)
                    {
                        IndiceCourant = gestion.GetPositionClient(gestion.Client, FiltreRecherche);
                        // on l'affiche :
                        AfficherClientCourant();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
