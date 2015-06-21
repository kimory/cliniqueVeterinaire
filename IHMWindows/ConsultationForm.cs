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
using Microsoft.VisualBasic;


namespace IHMWindows
{
    public partial class ConsultationForm : Form
    {


        private MgtConsultations Gestion;
        private List<LigneConsultation> liste;
        private bool verif = false;

        public ConsultationForm(Consultation consul)
        {
            InitializeComponent();
            //on stock dans gestion les éléments relatifs aux véto et à l'animal selectionné
            Gestion = new MgtConsultations();
            Gestion.Consultation = consul;
            Gestion.GetBaremes();
            liste = new List<LigneConsultation>();
        }

        private void Consultation_Load(object sender, EventArgs e)
        {
            AffichageAnimalVeto();
            AffichageBaremes();
            dateTimePicker1.Value = Gestion.Consultation.DateConsultation;
            liste.Add(new LigneConsultation());
            dGVListeActes.DataSource = liste;
            dGVListeActes.Columns[1].Visible = false;
            dGVListeActes.Columns[5].Visible = false;

        }

        private void AffichageBaremes()
        {
            comboBoxLibelle.DataSource = Gestion.ListeBaremes;
            comboBoxLibelle.DisplayMember = "Libelle";
            comboBoxType.DataSource = Gestion.ListeBaremes;
            comboBoxType.DisplayMember = "TypeActe";
        }


        private void AffichageAnimalVeto()
        {
            //On remplit les champs avec les infos relatives à l'animal selectionné
            txtCouleur.Text = Gestion.Consultation.Animal.Couleur;
            txtRace.Text = Gestion.Consultation.Animal.Race.Races;
            txtsexe.Text = Gestion.Consultation.Animal.Sexe;
            txtTatouage.Text = Gestion.Consultation.Animal.Tatouage;
            textCode.Text = Gestion.Consultation.Animal.CodeAnimal.ToString();
            textEspece.Text = Gestion.Consultation.Animal.Race.Espece;
            textNom.Text = Gestion.Consultation.Animal.NomAnimal;
            txtVeto.Text = Gestion.Consultation.Veto.NomVeto;
        }

        private void comboBoxLibelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxMaxi.Text = ((Bareme)comboBoxLibelle.SelectedItem).TarifMaxi.ToString();
            textBoxMini.Text = ((Bareme)comboBoxLibelle.SelectedItem).TarifMini.ToString();
            textBoxPrix.Text = ((Bareme)comboBoxLibelle.SelectedItem).TarifFixe.ToString();
        }

        private void RefreshDataGrid()
        {
            dGVListeActes.DataSource = null;
            dGVListeActes.DataSource = liste;
            dGVListeActes.Columns[1].Visible = false;
            dGVListeActes.Columns[5].Visible = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            foreach (LigneConsultation item in liste)
            {
                MessageBox.Show(item.Libelle + " " + item.Type);
            }
        }

        private void ButAjouterActe_Click(object sender, EventArgs e)
        {
            if (!verif)
            {
                if (verifTarif())
                {
                    liste[0].Libelle = ((Bareme)comboBoxLibelle.SelectedItem).Libelle;
                    liste[0].Type = ((Bareme)comboBoxLibelle.SelectedItem).TypeActe;
                    liste[0].Prix = Double.Parse(textBoxPrix.Text);
                    liste[0].Barem = (Bareme)comboBoxLibelle.SelectedItem;
                    RefreshDataGrid();
                    verif = true;
                    ClearError();
                }
            }

            else
            {
                try
                {
                    if (verifTarif())
                    {
                        liste.Add(new LigneConsultation(((Bareme)comboBoxLibelle.SelectedItem).TypeActe,
                                 ((Bareme)comboBoxLibelle.SelectedItem).Libelle, Double.Parse(textBoxPrix.Text),(Bareme)comboBoxLibelle.SelectedItem));
                        RefreshDataGrid();
                        ClearError();
                    }
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }
            }
        }

        private void ClearError()
        {
            errorProvider1.SetError(textBoxPrix, "");
        }

        private bool verifTarif()
        {
            bool verif = true;
            Double mini, maxi, tarif;
            tarif = Double.Parse(textBoxPrix.Text);
            maxi = ((Bareme)comboBoxLibelle.SelectedItem).TarifMaxi;
            mini = ((Bareme)comboBoxLibelle.SelectedItem).TarifMini;

            //trois cas possible en matière de vérification du tarif par rapport au maxi et mini

            if (maxi != 0 && mini != 0)
            {
                if (tarif < mini || tarif > maxi)
                {
                    errorProvider1.SetError(textBoxPrix,
                        "Le tarif ne correspond pas aux contraintes maxi et mini definies par le barême");
                    verif = false;
                }
            }
            else
            {
                if (mini != 0 && maxi == 0)
                {
                    if (tarif < mini)
                    {
                        errorProvider1.SetError(textBoxPrix,
                        "Le tarif ne correspond pas aux contraintes maxi et mini definies par le barême");
                        verif = false;
                    }
                }
                else
                {
                    if (mini == 0 && maxi != 0)
                    {
                        if (tarif > maxi)
                        {
                            errorProvider1.SetError(textBoxPrix,
                            "Le tarif ne correspond pas aux contraintes maxi et mini definies par le barême");
                            verif = false;
                        }
                    }
                }
            }
            return verif;
        }

        private void butAnnul_Click(object sender, EventArgs e)
        {
            liste.Clear();
            RefreshDataGrid();
        }

        private void dGVListeActes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Double total = 0;
            foreach (LigneConsultation item in liste)
            {
                total += item.Prix;
            }

            textBoxTotal.Text = total.ToString();
        }

        private void butValider_Click(object sender, EventArgs e)
        {
            Gestion.Consultation.Commentaire = richTextBox1.Text;
            Gestion.Consultation.AjoutLigneConsultation(liste);

            try
            {
                Gestion.MiseAjourStockVaccin();
                Gestion.AjoutConsultation(true);
                MessageBox.Show("La consultation a été validée !", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butTatouage_Click(object sender, EventArgs e)
        {
            string tatouage = Interaction.InputBox("Entrer la valeur du tatouage : ", "Ajout Tatouage");
            if (tatouage != string.Empty)
            {
                try
                {
                    Gestion.AjoutTatouage(tatouage,Gestion.Consultation.Animal.CodeAnimal);
                    txtTatouage.Text = tatouage;
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }
            }
        }

      
    }
}
