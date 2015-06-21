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
    public partial class AjoutVeto : Form
    {
        private MgtVeterinaire gestion;

        public AjoutVeto(MgtVeterinaire veto)
        {
            InitializeComponent();
            //gestion = new MgtVeterinaire();
            gestion = veto;
        }

        //On ferme la boite de dialogue
        private void ButAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //On teste si l'utilisateur a bien rempli les deux champs puis on ajoute le nouveau véto...
        private void ButValider_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtMotPasse.Text) && !string.IsNullOrWhiteSpace(TxtNomPrenom.Text))
            {
                try
                {
                    gestion.AjoutVeto(TxtNomPrenom.Text, TxtMotPasse.Text);
                    this.Close();
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }
            }
            else
            {
                MessageBox.Show("Données non valides !!!");
            }
        }
    }
}
