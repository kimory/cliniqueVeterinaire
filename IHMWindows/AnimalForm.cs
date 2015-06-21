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
    public partial class AnimalForm : Form
    {
        private MgtClientsAnimaux gestion;
        private int Animal;
        private string[] sex;
        private Declarations.ModesEcran mode;

        private Declarations.ModesEcran Mode
        {
            get
            {
                return mode;
            }
            set
            {
                mode = value;

                switch (value)
                {
                    case Declarations.ModesEcran.Ajout :
                        //On met en place la gestion du mode Ajout
                        butDossierMed.Enabled = false;
                        AffichageDonnées(value);
                        break;
                    case Declarations.ModesEcran.Modification :
                        //On met en place la gestion du mode modification
                        butDossierMed.Enabled = true;
                        AffichageDonnées(value);
                        break;
                    default:
                        break;
                }
            }
        }

        //Constructeur prendra en argument un mgtclient pour récup les info du client en cours...
        public AnimalForm(MgtClientsAnimaux gestions, int recupAnimal)
        {
            //On recupère le gestionnaire permettant de manipuler les données liées aux animaux
            InitializeComponent();
            gestion = gestions;
            Animal = recupAnimal;
            sex = new string[3] { "M", "F", "Hermaprodite" };
            //En fonction du mode d'ecran selectionner, on adapte l'affichage
            Mode = Declarations.ModesEcran.Modification;
        }

        public AnimalForm(MgtClientsAnimaux gestions)
        {
            //On récupère le gestionnaire permettant de manipuler les données liées aux animaux
            InitializeComponent();
            gestion = gestions;
            sex = new string[3] { "M", "F", "H" };
            //En fonction du mode d'écran sélectionné, on adapte l'affichage
            Mode = Declarations.ModesEcran.Ajout;
        }

       
        private void AffichageDonnées(Declarations.ModesEcran mode)
        {
            //On charge depuis la BD les données liées aux races et aux espèces
            gestion.GetRace();

            switch (mode)
            {
                case Declarations.ModesEcran.Ajout:
                    txtClient.Text = gestion.Client.Nom + " " + gestion.Client.Prenom;
                    comboBoxEspece.DataSource = gestion.Races;
                    comboBoxEspece.DisplayMember = "Espece";
                    comboBoxRace.DataSource = gestion.Races;
                    comboBoxRace.DisplayMember = "Races";
                    comboBoxSexe.DataSource = sex;
                    break;
                case Declarations.ModesEcran.Modification:
                    //On met les données dans les controls du formulaires : combo box et textBox
                    txtClient.Text = gestion.Client.Nom + " " + gestion.Client.Prenom;
                    txtcode.Text = gestion.Client.ListeAnimaux[Animal].CodeAnimal.ToString();
                    txtCouleur.Text = gestion.Client.ListeAnimaux[Animal].Couleur;
                    txtNom.Text = gestion.Client.ListeAnimaux[Animal].NomAnimal;
                    txtTatouage.Text = gestion.Client.ListeAnimaux[Animal].Tatouage;
                    comboBoxEspece.DataSource = gestion.Races;
                    comboBoxEspece.DisplayMember = "Espece";
                    comboBoxRace.DataSource = gestion.Races;
                    comboBoxRace.DisplayMember = "Races";
                    comboBoxRace.SelectedIndex = gestion.IndiceRaceListe(gestion.Client.ListeAnimaux[Animal].Race.Races);
                    comboBoxSexe.DataSource = sex;
                    break;
                default:
                    break;
            }

        }
        private void butAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butValider_Click(object sender, EventArgs e)
        {
            if (Mode == Declarations.ModesEcran.Ajout && VerifChamps())
            {
                try
                {
                    gestion.AjoutAnimal(txtNom.Text, txtCouleur.Text, txtTatouage.Text, comboBoxEspece.SelectedItem, comboBoxSexe.SelectedItem);
                    MessageBox.Show(txtNom.Text + " a bien été ajouté(e) à la base de données", "Ajout d'un animal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }
            }
            else
            {
                if (VerifChamps())
                {
                    gestion.ModifierAnimal(txtNom.Text, txtCouleur.Text, txtTatouage.Text, comboBoxEspece.SelectedItem, comboBoxSexe.SelectedItem,txtcode.Text);
                    MessageBox.Show(txtNom.Text + " a bien été modifié(e) dans la base de données", "Modification d'un animal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                
            }
        }

        //Cette méthode permet de vérifier que les champs obligatoires sont bien renseignés avant d'effectuer l'ajout ou la modification en base de données
        private bool VerifChamps()
        {
            bool verif = true;

            if (txtCouleur.Text == "")
            {
                errorProvider1.SetError(txtCouleur, "La couleur est obligatoire");
                verif = false;
            }
            else
            {
                errorProvider1.SetError(txtCouleur, "");
            }

            if (txtNom.Text == "")
            {
                errorProvider1.SetError(txtNom, "Le nom est obligatoire");
                verif = false;
            }
            else
            {
                errorProvider1.SetError(txtNom, "");
            }

            return verif;
        }

        private void butDossierMed_Click(object sender, EventArgs e)
        {
            if (Mode == Declarations.ModesEcran.Modification )
            {
                // on ouvre le dossier medical
                DossierMForm dossierMedical = new DossierMForm(gestion.Client.ListeAnimaux[Animal].CodeAnimal);
                dossierMedical.ShowDialog();
            }
            
        }
    }
}
