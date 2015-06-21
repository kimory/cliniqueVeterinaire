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
    public partial class VaccinForm : Form
    {
        private MgtVaccins gestion;

        public VaccinForm()
        {
            InitializeComponent();
            gestion = new MgtVaccins();
            //dgvVaccins.DataError += VerifFormat;

            sfdVaccins.Filter = "fichiers csv|*.csv";
        }

        // au chargement du formulaire
        private void VaccinForm_Load(object sender, EventArgs e)
        {
            // on construit le DataGridView :
            dgvVaccins.ColumnCount = 3;

            // les en-têtes :
            dgvVaccins.Columns[0].Name = "Nom";
            dgvVaccins.Columns[1].Name = "Période de validité";
            dgvVaccins.Columns[2].Name = "Quantité en stock";

            // pour que les colonnes occupent toute la largeur de la grille :
            dgvVaccins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // les colonnes "nom" et "periode de validite" sont en lecture seule :
            dgvVaccins.Columns[0].ReadOnly = true;
            dgvVaccins.Columns[1].ReadOnly = true;

            try
            {
                ChargerListeVaccins();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// remplissage de la DataGridView avec la liste des vaccins
        /// </summary>
        private void ChargerListeVaccins()
        {
            // on stocke la liste des vaccins dans gestion.ListeVaccins :
            gestion.GetVaccins();
            // La dataGridView est alimentée avec les infos voulues :
            // pour plus de flexibilité (type des propriétés...),
            // on choisit de ne pas alimenter la grille avec la prop. DataSource
            if (gestion.ListeVaccins != null)
            {
                foreach (Vaccin vaccin in gestion.ListeVaccins)
                {
                    dgvVaccins.Rows.Add(vaccin.Nom,
                                        vaccin.PeriodeValidite.ToString(),
                                        vaccin.QuantiteStock.ToString());
                }
            }

            // l'affichage diffère selon la quantité en stock
            for (int i = 0; i < dgvVaccins.RowCount; i++)
            {
                Coloration(dgvVaccins["Quantité en stock", i]);
            }
        }

        /// <summary>
        /// colore la valeur dans la cellule en fct de la qté indiquée
        /// rouge = stock à zéro
        /// orange = stock inférieur à 5
        /// noir = stock supérieur ou égal à 5
        /// </summary>
        /// <param name="dataGridViewCell"></param>
        private void Coloration(DataGridViewCell dataGridViewCell)
        {
            int valeur = int.Parse((String) dataGridViewCell.Value);

            if (valeur == 0)
            {
                dataGridViewCell.Style.ForeColor = Color.Red;
            }
            else if (valeur < 5)
            {
                dataGridViewCell.Style.ForeColor = Color.Orange;
            }
            else
            {
                dataGridViewCell.Style.ForeColor = Color.Black;
            }
        }

        // lorsqu'une valeur est modifiée dans une cellule
        private void dgvVaccins_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Vaccin vaccinSelectionne;
            int qteSaisie;
            bool testInt = false;

            // si la valeur modifiée est bien une quantité en stock
            if (dgvVaccins.Columns[e.ColumnIndex].Name == "Quantité en stock")
            {
                try
                {
                    // on poursuit si la qté saisie est bien un entier (et pas une chaîne...)
                    testInt = int.TryParse(dgvVaccins["Quantité en stock", e.RowIndex].Value.ToString(), 
                                            out qteSaisie);

                    if (!testInt)
                    {
                        throw new Exception("La nouvelle quantité doit être un nombre entier.");
                    }

                    // avec l'index de la ligne, on récupère le vaccin sélectionné
                    vaccinSelectionne = gestion.ListeVaccins[e.RowIndex];

                    // on tente de mettre à jour la quantité en base :
                    gestion.MiseAJourStockVaccin(vaccinSelectionne, qteSaisie);

                    // on met à jour la quantité dans la liste :
                    gestion.ListeVaccins[e.RowIndex].QuantiteStock = qteSaisie;

                    // l'affichage diffère selon la quantité
                    Coloration(dgvVaccins["Quantité en stock", e.RowIndex]);
                }
                catch (Exception ex)
                {
                    // si la mise à jour a échoué, on affiche un message
                    MessageBox.Show(ex.Message);

                    // on recharge la cellule avec l'ancienne quantité
                    // pour éviter de réappeler la méthode dgvVaccins_CellValueChanged()
                    // on se désabonne, puis réabonne :
                    dgvVaccins.CellValueChanged -= dgvVaccins_CellValueChanged;
                    dgvVaccins[e.ColumnIndex, e.RowIndex].Value = gestion.ListeVaccins[e.RowIndex].QuantiteStock;
                    dgvVaccins.CellValueChanged += dgvVaccins_CellValueChanged;
                }
            }
        }

        // pour récupérer la liste des vaccins en rupture de stock
        private void btnVaccinsACder_Click(object sender, EventArgs e)
        {
            List<String> nomDesVaccinsACder = new List<String>();
            bool cdeAPasser = false;

            foreach (Vaccin vaccin in gestion.ListeVaccins)
            {
                if (vaccin.QuantiteStock < 5)
                {
                    // on stocke les noms vaccins à commander :
                    nomDesVaccinsACder.Add(vaccin.Nom);
                    cdeAPasser = true;
                }
            }

            if (!cdeAPasser)
            {
                // si il n'y en a aucun, on l'écrit :
                MessageBox.Show("Aucun vaccin en rupture de stock.");
            }
            else
            {
                // sinon on génère un fichier csv :
                try
                {
                    DialogResult reponse = sfdVaccins.ShowDialog();
                    if (reponse == DialogResult.OK)
                    {
                        gestion.GenererCsv(sfdVaccins.FileName, nomDesVaccinsACder);
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
