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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAfficherUnMessage_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Titre de la fenêtre","Hello world", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            switch (DialogResult)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    Console.WriteLine("OK");
                    break;
                case DialogResult.Cancel:
                    Console.WriteLine("Cancel");
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    Console.WriteLine("Yes");
                    break;
                case DialogResult.No:
                    Console.WriteLine("No");
                    break;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NomPrenom nomPrenomForm = new NomPrenom();
            nomPrenomForm.ShowDialog();
        }

        private void btnSaisiePersonne_Click(object sender, EventArgs e)
        {
            NomPrenom nomPrenomForm = new NomPrenom();
            nomPrenomForm.ShowDialog();
        }

        private void btnEventMouse_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEventMouse_Click(object sender, EventArgs e)
        {
            InfoSouris InfoSourisForm = new InfoSouris();
            InfoSourisForm.ShowDialog();
        }

        private void btnMagasin_Click(object sender, EventArgs e)
        {
            Mag MagForm = new Mag();
            MagForm.ShowDialog();
        }
    }
}
