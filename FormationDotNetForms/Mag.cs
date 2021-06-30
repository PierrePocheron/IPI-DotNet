using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormationDotNetForms
{
    public partial class Mag : Form
    {
        public Mag()
        {
            InitializeComponent();
        }

        private void Mag_Load(object sender, EventArgs e)
        {
            WORLDMMOMag entite = new WORLDMMOMag();
            List<Magasin> listArticles = entite.Magasin.ToList();
            dataGridView1.DataSource = listArticles;
        }

        // =========== Les events des boutons ==========
        // =========== Les events des boutons ==========


        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                WORLDMMOMag entite = new WORLDMMOMag();
                int idArticle = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                Console.WriteLine(idArticle);

                Magasin articleADelete = entite.Magasin.Where(a => a.id_magasin == idArticle).FirstOrDefault();
                entite.Magasin.Remove(articleADelete);
                entite.SaveChanges();
                refresheData();
                viderLesChamps();
            }
        }

        

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Magasin article = new Magasin();
            article.nom = txbNom.Text;
            article.prix = (int)txbPrix.Value;
            //article.poids = (int)txbPrix.Value;
            //article.quantite = (int)txbQuantite.Value;
            //article.tax = (int)txbPrix.Value;

            WORLDMMOMag entite = new WORLDMMOMag();
            entite.Magasin.Add(article);
            entite.SaveChanges();

            this.refresheData();

            viderLesChamps();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                WORLDMMOMag entite = new WORLDMMOMag();
                int idArticle = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                Console.WriteLine(idArticle);

                Magasin articleUpdate = entite.Magasin.Where(a => a.id_magasin == idArticle).FirstOrDefault();

                articleUpdate.nom = txbNom.Text;
                articleUpdate.prix = (float)txbPrix.Value;

                entite.SaveChanges();
                refresheData();
                viderLesChamps();

            }
        }
        // =========== Les events des boutons ==========
        // =========== Les events des boutons ==========


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                txbNom.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txbPrix.Value = decimal.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                //txbPoids.Value = 0;
                //txbQuantite.Value = 0;
                //txbTax.Value = 0;
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        // =========== Les fonctions privées ==========
        // =========== Les fonctions privées ==========
        private void viderLesChamps()
        {
            txbNom.Text = "";
            txbPoids.Value = 0;
            txbPrix.Value = 0;
            txbQuantite.Value = 0;
            txbTax.Value = 0;
        }

        private void refresheData()
        {
            dataGridView1.DataSource = null;
            WORLDMMOMag entite = new WORLDMMOMag();
            List<Magasin> listArticles = entite.Magasin.ToList();
            dataGridView1.DataSource = listArticles;
        }
        // =========== Les fonctions privées ==========
        // =========== Les fonctions privées ==========
    }
}
