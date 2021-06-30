using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormationDotNetForms
{
    public partial class NomPrenom : Form
    {
        public NomPrenom()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            var personne = new
            {
                nom = txbNom.Text,
                prenom = txbPrenom.Text
            };
        }
    }
}
