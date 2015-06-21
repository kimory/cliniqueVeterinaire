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
    public partial class VeterinaireForm : Form
    {
        private MgtVeterinaire Gestion;
        private MgtConnection connexion;

        public VeterinaireForm()
        {
            InitializeComponent();
            Gestion = new MgtVeterinaire();
            connexion = MgtConnection.GetInstance();
        }

        //Sur chargement du formulaire on charge la liste des véto à partir de gestion...
        private void VeterinaireForm_Load(object sender, EventArgs e)
        {
            LBVeterinaire.DataSource = Gestion.ListeVeto;
            LBVeterinaire.DisplayMember = "NomVeto";
        }

        //Méthode pour afficher la boite de dialogue demandant le nom et mot de passe
        private void BtAjouter_Click(object sender, EventArgs e)
        {
            AjoutVeto Form = new AjoutVeto(Gestion);
            Form.ShowDialog();
            RefreshList();
        }

        //méthode permettant de rafraichir la listebox...
        private void RefreshList()
        {
            LBVeterinaire.DataSource = null;
            LBVeterinaire.DataSource = Gestion.ListeVeto;
            LBVeterinaire.DisplayMember = "NomVeto";
        }

        //Méthode permettant de modifier le champs "archive" de la table véto : 0-->1
        private void BtArchiver_Click(object sender, EventArgs e)
        {
            DialogResult choix;
            Veterinaire vet = (Veterinaire)LBVeterinaire.SelectedItem;
            if (vet != null && vet.CodeVeto != connexion.CodeVeto)
            {
                String nomprenom = vet.NomVeto;

                choix = MessageBox.Show("Souhaitez-vous archiver le vétérinaire suivant ?"
                + Environment.NewLine + Environment.NewLine + nomprenom, "Archivage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (choix == DialogResult.Yes)
                {
                    try
                    {
                        Gestion.ArchivageVeto(vet.CodeVeto);
                        RefreshList();
                    }
                    catch (Exception m)
                    {
                        MessageBox.Show(m.Message);
                    }
                }

            }
        }

        //Méthode permettant de changer le mot de passe via un objet "inputbox"
        private void BtReinitialiser_Click(object sender, EventArgs e)
        {
            string mdp = Interaction.InputBox("Nouveau mot de passe :");
            Veterinaire vet = (Veterinaire)LBVeterinaire.SelectedItem;

            if (!string.IsNullOrEmpty(mdp) && vet!= null)
            {
                try
                {
                    Gestion.ReinitialiserMotPasse(vet.CodeVeto, mdp);
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }
            }
        }
    }
}
