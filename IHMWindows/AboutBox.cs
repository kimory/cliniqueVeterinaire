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
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            InitializeComponent();
            
            this.Text = String.Format("Gestion Clinique v1.0");
            this.labelProductName.Text = "GestionClinique";
            this.labelVersion.Text = String.Format("Version {0} {0}", 1,0);
            this.labelCopyright.Text = "Copyright Julie And Antoine";
            this.labelCompanyName.Text = "ENI Studio";
            this.textBoxDescription.Text = "Application de gestion d'une clinique vétérinaire";
        }
    }
}
