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
    public partial class RelanceForm : Form
    {
        private MgtClientsAnimaux mgtClientsAnimaux;
        private List<Animal> List_Animaux;
        private List<Animal> List_Animaux_Rappel;
        private List<Client> List_Client;

        public RelanceForm()
        {
            InitializeComponent();
            mgtClientsAnimaux = new MgtClientsAnimaux();
        }

        private void RelanceForm_Load(object sender, EventArgs e)
        {
            ChargerClients();
            //ChargerAnimaux();
        }

        private void ChargerAnimaux()
        {
            //On stocke le client selectionné dans la liste box
            mgtClientsAnimaux.Client = (Client)listBox1.SelectedItem;
            List_Animaux = mgtClientsAnimaux.ListeAnimaux;

            //On recupère les animaux pour lesquels un rappel est necessaire...
            List_Animaux_Rappel = mgtClientsAnimaux.AnimauxRappel();

            listView1.Items.Clear();
            //On ajoute dans la liste view les animaux...
            foreach (Animal item in List_Animaux)
            {
                listView1.Items.Add(item.NomAnimal);
            }

            MiseEnforme();
            //listBox2.DataSource = mgtClientsAnimaux.ListeAnimaux;
            //listBox2.DisplayMember = "NomAnimal";
        }

        //Cette méthode a pour but de colorer en rouge les chiens dont un rappel vaccin est necessaire
        private void MiseEnforme()
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int j = 0; j < List_Animaux_Rappel.Count; j++)
                {
                    if (listView1.Items[i].ToString().Contains(List_Animaux_Rappel[j].NomAnimal))
                    {
                        listView1.Items[i].ForeColor = Color.Red;
                    }
                }
            }
        }

        //Cette méthode permet de charger dans la listBox de droite la liste des clients dont au moins un des chiens necessite un rappel
        private void ChargerClients()
        {
            List_Client = mgtClientsAnimaux.ClientRappel();
            listBox1.DataSource = List_Client;
            listBox1.DisplayMember = "NomPrenom";
        }

        //Sur l'evenement IndexChanged de la liste, on recharge les animaux correspondants
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargerAnimaux();
        }

        //Cette méthode se contente d'afficher sous forme de message box la liste des animaux necessitant un rappel pour le client selectionné
        private void butrelance_Click(object sender, EventArgs e)
        {
            StringBuilder rappel = new StringBuilder();

            if (mgtClientsAnimaux.Client != null)
            {
                rappel.AppendLine("Pour le client : " + mgtClientsAnimaux.Client.NomPrenom);
                rappel.AppendLine("Liste des Animaux dont un rappel est nécessaire : ");
                rappel.AppendLine("");

                foreach (Animal item in List_Animaux_Rappel)
                {
                    rappel.AppendLine(item.NomAnimal);
                }

                MessageBox.Show(rappel.ToString());
            }

        }
    }
}
