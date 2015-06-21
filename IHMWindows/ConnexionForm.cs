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
    public partial class ConnexionForm : Form
    {
        private MgtConnection gestion;
        //private PrincipalForm ecranprincipal;

        public ConnexionForm()
        {
            InitializeComponent();
            gestion = MgtConnection.GetInstance();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool verifMotPasse = false;

            if (textBlogin.Text != "" && textBPassword.Text != "")
            {
                verifMotPasse = gestion.VerifMotPasse(textBlogin.Text, textBPassword.Text);
            }

            if (verifMotPasse)
            {
                this.Close();
            }
            else
            {
                lblMessage.Visible = true;
                //textBlogin.Text = "";
                textBPassword.Text = "";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
