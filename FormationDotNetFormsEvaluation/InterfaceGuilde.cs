using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormationDotNetFormsEvaluation
{
    public partial class InterfaceGuilde : Form
    {
        public InterfaceGuilde()
        {
            InitializeComponent();
        }

        //  Initialisation de la fenêtre
        private void InterfaceGuilde_Load(object sender, EventArgs e)
        {
            //  Initialisation du DGV Hero
            WORLDMMOEntities entiteHero = new WORLDMMOEntities();
            List<Heros> listeHeros = entiteHero.Heros.ToList();
            dgvHero.DataSource = listeHeros;

            //  Initialisation du DGV Inventaire
            /*WORLDMMOEntities entiteInventaire = new WORLDMMOEntities();
            List<Inventaire> listeInventaires = entiteInventaire.Inventaire.ToList();
            dgvInventaire.DataSource = listeInventaires;*/
        }

        private void btnHeroAjouter_Click(object sender, EventArgs e)
        {
            Heros unHero = new Heros();

            unHero.nom              =   txbHeroNom.Text;
            unHero.prenom           =   txbHeroPrenom.Text;
            unHero.specialite       =   txbHeroSpecialite.Text;
            unHero.classe           =   txbHeroClasse.Text;

            unHero.lvl              =   (int)numUPDOHeroLvl.Value;
            unHero.nbMissionReussi  =   (int)numUPDOHeroNbMissionsReussi.Value;
            unHero.puissance        =   (int)numUPDOHeroPuissance.Value;
            unHero.reputation       =   (int)numUPDOHeroReputation.Value;

            WORLDMMOEntities entiteHero = new WORLDMMOEntities();
            entiteHero.Heros.Add(unHero);

            entiteHero.SaveChanges();
            refreshDataHero();
            viderLesChampsHero();

            refreshDataInventaire();
            viderLesChampsInventaire();
        }

        private void btnHeroModifier_Click(object sender, EventArgs e)
        {
            if (dgvHero.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                WORLDMMOEntities entiteHero = new WORLDMMOEntities();
                int idHero = int.Parse(dgvHero.SelectedRows[0].Cells[0].Value.ToString());
                Console.WriteLine(idHero);

                Heros heroAModifier = entiteHero.Heros.Where(a => a.id_hero == idHero).FirstOrDefault();

                heroAModifier.nom = txbHeroNom.Text;
                heroAModifier.prenom = txbHeroPrenom.Text;
                heroAModifier.specialite = txbHeroSpecialite.Text;
                heroAModifier.classe = txbHeroClasse.Text;

                heroAModifier.lvl = (int)numUPDOHeroLvl.Value;
                heroAModifier.nbMissionReussi = (int)numUPDOHeroNbMissionsReussi.Value;
                heroAModifier.puissance = (int)numUPDOHeroPuissance.Value;
                heroAModifier.reputation = (int)numUPDOHeroReputation.Value;

                entiteHero.SaveChanges();
                refreshDataHero();
                viderLesChampsHero();

                refreshDataInventaire();
                viderLesChampsInventaire();
            }
        }

        private void btnHeroSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvHero.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                WORLDMMOEntities entiteHero = new WORLDMMOEntities();
                int idHero = int.Parse(dgvHero.SelectedRows[0].Cells[0].Value.ToString());
                Console.WriteLine(idHero);

                Heros heroASupprimer = entiteHero.Heros.Where(a => a.id_hero == idHero).FirstOrDefault();
                entiteHero.Heros.Remove(heroASupprimer);

                entiteHero.SaveChanges();
                refreshDataHero();
                viderLesChampsHero();

                refreshDataInventaire();
                viderLesChampsInventaire();
            }
        }

        private void btnInventaireAjouter_Click(object sender, EventArgs e)
        {

            Inventaire unInventaire = new Inventaire();

            unInventaire.objetNom = txbInventaireNom.Text;
            unInventaire.objetLvl = txbInventaireDescription.Text;
            unInventaire.objetQuantite = txbInventaireLvl.Text;
            unInventaire.objetDescription = txbInventaireQuantite.Text;
            unInventaire.objetPrix = txbInventairePrix.Text;

            WORLDMMOEntities entiteInventaire = new WORLDMMOEntities();
            entiteInventaire.Inventaire.Add(unInventaire);

            entiteInventaire.SaveChanges();
            refreshDataInventaire();
            viderLesChampsInventaire();
        }

        private void btnInventaireModifier_Click(object sender, EventArgs e)
        {
            if (dgvInventaire.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                WORLDMMOEntities entiteInventaire = new WORLDMMOEntities();
                int idInventaire = int.Parse(dgvInventaire.SelectedRows[0].Cells[0].Value.ToString());
                Console.WriteLine(idInventaire);

                Inventaire inventaireAModifier = entiteInventaire.Inventaire.Where(a => a.id_inventaire == idInventaire).FirstOrDefault();

                inventaireAModifier.objetNom = txbInventaireNom.Text;
                inventaireAModifier.objetLvl = txbInventaireDescription.Text;
                inventaireAModifier.objetQuantite = txbInventaireLvl.Text;
                inventaireAModifier.objetDescription = txbInventaireQuantite.Text;
                inventaireAModifier.objetPrix = txbInventairePrix.Text;

                entiteInventaire.SaveChanges();
                refreshDataInventaire();
                viderLesChampsInventaire();
            }
        }

        private void btnInventaireSupprimer_Click(object sender, EventArgs e)
        {

            if (dgvInventaire.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                WORLDMMOEntities entiteInventaire = new WORLDMMOEntities();
                int idInventaire = int.Parse(dgvInventaire.SelectedRows[0].Cells[0].Value.ToString());
                Console.WriteLine(idInventaire);

                Inventaire inventaireASupprimer = entiteInventaire.Inventaire.Where(a => a.id_inventaire == idInventaire).FirstOrDefault();
                entiteInventaire.Inventaire.Remove(inventaireASupprimer);

                entiteInventaire.SaveChanges();
                refreshDataInventaire();
                viderLesChampsInventaire();
            }

        }

        // =========== Les fonctions privées ==========
        // =========== Les fonctions privées ==========
        private void viderLesChampsHero()
        {
            txbHeroNom.Text = "";
            txbHeroPrenom.Text = "";
            txbHeroSpecialite.Text = "";
            txbHeroClasse.Text = "";

            //numUPDOHeroID.Value = 0;
            numUPDOHeroLvl.Value = 0;
            numUPDOHeroNbMissionsReussi.Value = 0;
            numUPDOHeroPuissance.Value = 0;
            numUPDOHeroReputation.Value = 0;
        }

        private void refreshDataHero()
        {
            dgvHero.DataSource = null;
            WORLDMMOEntities entiteHero = new WORLDMMOEntities();
            List<Heros> listeHeros = entiteHero.Heros.ToList();
            dgvHero.DataSource = listeHeros;
        }

        private void viderLesChampsInventaire()
        {
            txbInventaireNom.Text = "";
            txbInventaireDescription.Text = "";
            txbInventaireLvl.Text = "";
            txbInventairePrix.Text = "";
            txbInventaireQuantite.Text = "";

            //numUPDOHeroID.Value = 0;
            numUPDOHeroLvl.Value = 0;
            numUPDOHeroNbMissionsReussi.Value = 0;
            numUPDOHeroPuissance.Value = 0;
            numUPDOHeroReputation.Value = 0;
        }

        private void refreshDataInventaire()
        {
            dgvInventaire.DataSource = null;
            WORLDMMOEntities entiteInventaire = new WORLDMMOEntities();
            List<Inventaire> listeInventaires = entiteInventaire.Inventaire.ToList();
            dgvInventaire.DataSource = listeInventaires;
        }

        private void dgvHero_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHero.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                txbHeroNom.Text                     = dgvHero.SelectedRows[0].Cells[1].Value.ToString();
                txbHeroPrenom.Text                  = dgvHero.SelectedRows[0].Cells[2].Value.ToString();
                txbHeroSpecialite.Text              = dgvHero.SelectedRows[0].Cells[3].Value.ToString();
                txbHeroClasse.Text                  = dgvHero.SelectedRows[0].Cells[4].Value.ToString();

                numUPDOHeroLvl.Value                = decimal.Parse(dgvHero.SelectedRows[0].Cells[5].Value.ToString());
                numUPDOHeroNbMissionsReussi.Value   = decimal.Parse(dgvHero.SelectedRows[0].Cells[6].Value.ToString());
                numUPDOHeroReputation.Value         = decimal.Parse(dgvHero.SelectedRows[0].Cells[7].Value.ToString());


                WORLDMMOEntities entiteInventaire = new WORLDMMOEntities();
                int idHero = int.Parse(dgvHero.SelectedRows[0].Cells[0].Value.ToString());
                Console.WriteLine(idHero);

                Inventaire inventaireAModifier = entiteInventaire.Inventaire.Where(a => a.id_inventaire == idHero).FirstOrDefault();

                if (inventaireAModifier == null)
                {
                    Console.WriteLine("il est null");
                }
                else
                {
                    Console.WriteLine(inventaireAModifier);

                    txbInventaireNom.Text = inventaireAModifier.objetNom;
                    txbInventaireDescription.Text = inventaireAModifier.objetDescription;
                    txbInventaireLvl.Text = inventaireAModifier.objetLvl;
                    txbInventaireQuantite.Text = inventaireAModifier.objetQuantite;
                    txbInventairePrix.Text = inventaireAModifier.objetPrix;
                }
            }
        }

        private void dgvInventaire_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInventaire.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                /*txbInventaireNom.Text               = dgvInventaire.SelectedRows[0].Cells[0].Value.ToString();
                txbInventaireDescription.Text       = dgvInventaire.SelectedRows[0].Cells[0].Value.ToString();
                txbInventaireLvl.Text               = dgvInventaire.SelectedRows[0].Cells[0].Value.ToString();
                txbInventaireQuantite.Text          = dgvInventaire.SelectedRows[0].Cells[0].Value.ToString();
                txbInventairePrix.Text              = dgvInventaire.SelectedRows[0].Cells[0].Value.ToString();*/
            }

        }
        // =========== Les fonctions privées ==========
        // =========== Les fonctions privées ==========


    }
}
