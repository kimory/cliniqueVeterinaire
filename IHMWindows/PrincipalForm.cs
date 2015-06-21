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
    public partial class PrincipalForm : Form
    {
      
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void ButtClientAnimal_Click(object sender, EventArgs e)
        {
            if (!VerifFormulaire("ClientForm"))
            {
                ClientForm FormulaireClient = new ClientForm();
                FormulaireClient.MdiParent = this;
                FormulaireClient.Show();
            }
        }

        private bool VerifFormulaire(string nom)
        {
            bool trouve = false;

            foreach (Form item in this.MdiChildren)
            {
                if (item.Name == nom)
                {
                    trouve = true;
                }
            }

            return trouve;
        }

        private void ButtRendezVous_Click(object sender, EventArgs e)
        {
            if (!VerifFormulaire("RdvForm"))
            {
                RdvForm rendezvous = new RdvForm();
                rendezvous.MdiParent = this;
                rendezvous.Show();
            }
        }

        private void ButAgenda_Click(object sender, EventArgs e)
        {
            if (!VerifFormulaire("AgendaForm"))
            {
                AgendaForm agenda = new AgendaForm();
                agenda.MdiParent = this;
                agenda.Show();
            }
        }

        private void dossierClientAnimauxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!VerifFormulaire("ClientForm"))
            {
                ClientForm FormulaireClient = new ClientForm();
                FormulaireClient.MdiParent = this;
                FormulaireClient.Show();
            }
        }

        private void priseDeRendezousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!VerifFormulaire("RdvForm"))
            {
                RdvForm rendezvous = new RdvForm();
                rendezvous.MdiParent = this;
                rendezvous.Show();
            }
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!VerifFormulaire("AgendaForm"))
            {
                AgendaForm agenda = new AgendaForm();
                agenda.MdiParent = this;
                agenda.Show();
            }
        }

        private void vétérinairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!VerifFormulaire("VeterinaireForm"))
            {
                VeterinaireForm veto = new VeterinaireForm();
                veto.MdiParent = this;
                veto.Show();
            }
        }

        private void PrincipalForm_Shown(object sender, EventArgs e)
        {
            ConnexionForm Connexion = new ConnexionForm();
            Connexion.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dossiersMedicauxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!VerifFormulaire("DossierMForm"))
            {
                DossierMForm dossier = new DossierMForm();
                dossier.MdiParent = this;
                dossier.Show();
            }
        }

        private void ButDossierMedical_Click(object sender, EventArgs e)
        {
            if (!VerifFormulaire("DossierMForm"))
            {
                DossierMForm dossier = new DossierMForm();
                dossier.MdiParent = this;
                dossier.Show();
            }
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!VerifFormulaire("AboutBox"))
            {
                AboutBox box = new AboutBox();
                box.MdiParent = this;
                box.Show();
            }
        }

        private void relancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!VerifFormulaire("RelanceForm"))
            {
                RelanceForm box = new RelanceForm();
                box.MdiParent = this;
                box.Show();
            }
        }

        private void ButRelance_Click(object sender, EventArgs e)
        {
            if (!VerifFormulaire("RelanceForm"))
            {
                RelanceForm box = new RelanceForm();
                box.MdiParent = this;
                box.Show();
            }
        }

        private void miseAJourDuStockDeVaccinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!VerifFormulaire("VaccinForm"))
            {
                VaccinForm dossier = new VaccinForm();
                dossier.MdiParent = this;
                dossier.Show();
            }
        }

       
    }
}
