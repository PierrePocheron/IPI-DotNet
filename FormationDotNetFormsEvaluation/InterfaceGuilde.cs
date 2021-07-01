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

        private void InterfaceGuilde_Load(object sender, EventArgs e)
        {
            WORLDMMOEntities entiteHero = new WORLDMMOEntities();
            List<Heros> listeHeros = entiteHero.Heros.ToList();

            var queryListeHeros = entiteHero.Heros
                    .ToList<Heros>();

            Console.WriteLine("Query réussi : " + queryListeHeros);
            foreach(var unHero in queryListeHeros) {
                Console.WriteLine("Hero : id = {0} & nom = {1} & prenom = {2}", unHero.id_hero, unHero.nom, unHero.prenom);
            }
            dgvHero.DataSource = listeHeros;
            if (dgvHero.SelectedRows.Count > 0)
            {
                dgvHero.Rows[0].Selected = true;
            }  
        }

        #region Elements Functions

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


            Console.WriteLine(unHero.id_hero);

            refreshDgvHero();
            viderLesChampsHero();

            int index = dgvHero.Rows.Count - 1;
            dgvHero.Rows[index].Selected = true;

            refreshDgvInventaire();
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
                refreshDgvHero();
                viderLesChampsHero();

                refreshDgvInventaire();
                viderLesChampsInventaire();
            }
        }

        private void btnHeroSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvHero.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                int idHero = int.Parse(dgvHero.SelectedRows[0].Cells[0].Value.ToString());

                WORLDMMOEntities entiteHero = new WORLDMMOEntities();
                Console.WriteLine(idHero);
                Heros heroASupprimer = entiteHero.Heros.Where(a => a.id_hero == idHero).FirstOrDefault();

                entiteHero.Heros.Remove(heroASupprimer);

                entiteHero.SaveChanges();
                refreshDgvHero();
                viderLesChampsHero();

                refreshDgvInventaire();
                viderLesChampsInventaire();
            }
        }

        private void btnInventaireAjouter_Click(object sender, EventArgs e)
        {
            if (dgvHero.SelectedRows.Count > 0)
            {
                Inventaire unInventaire = new Inventaire();

                unInventaire.id_hero = int.Parse(dgvHero.SelectedRows[0].Cells[0].Value.ToString());
                unInventaire.objetNom = txbInventaireNom.Text;
                unInventaire.objetLvl = (int)numUDInventaireLvl.Value;
                unInventaire.objetQuantite = (int)numUDInventaireQuantite.Value;
                unInventaire.objetDescription = txbInventaireDescription.Text;
                unInventaire.objetPrix = (float)numUDInventairePrix.Value;

                WORLDMMOEntities entiteInventaire = new WORLDMMOEntities();
                entiteInventaire.Inventaire.Add(unInventaire);

                entiteInventaire.SaveChanges();

                updateInventaire();
            }
            else
            {
                Console.WriteLine("Ajouter Inventaire - Aucune ligne sélectionnée.");
            }        
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
                inventaireAModifier.objetLvl = (int)numUDInventaireLvl.Value;
                inventaireAModifier.objetQuantite = (int)numUDInventaireQuantite.Value;
                inventaireAModifier.objetDescription = txbInventaireDescription.Text;
                inventaireAModifier.objetPrix = (float)numUDInventairePrix.Value;

                entiteInventaire.SaveChanges();

                updateInventaire();
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

                updateInventaire();
            }
        }

        private void dgvHero_SelectionChanged(object sender, EventArgs e)
        {
            remplirChampsHero();
        }

        private void dgvInventaire_SelectionChanged(object sender, EventArgs e)
        {
            remplirChampsInventaire();
        }

        #endregion 


        #region Private Functions

        private void viderLesChampsHero()
        {
            txbHeroNom.Text = "";
            txbHeroPrenom.Text = "";
            txbHeroSpecialite.Text = "";
            txbHeroClasse.Text = "";

            numUPDOHeroLvl.Value = 1;
            numUPDOHeroNbMissionsReussi.Value = 0;
            numUPDOHeroPuissance.Value = 1;
            numUPDOHeroReputation.Value = 1;
        }

        private void refreshDgvHero()
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
            numUDInventaireLvl.Value = 1;
            numUDInventairePrix.Value = 1;
            numUDInventaireQuantite.Value = 1;

        }

        private void refreshDgvInventaire()
        {
            dgvInventaire.DataSource = null;
            if (dgvHero.SelectedRows.Count > 0)
            {
                int idHero = recupIdHeroSelectedRow();
                WORLDMMOEntities entiteInventaire = new WORLDMMOEntities();
                var queryHeroInventaire = entiteInventaire.Inventaire
                        .Where(a => a.id_hero == idHero)
                        .ToList<Inventaire>();

                Console.WriteLine("Query Inventaire réussi : " + queryHeroInventaire);
                foreach (var unInventaire in queryHeroInventaire)
                {
                    Console.WriteLine("Inventaire : idInventaire = {0} & idHero = {1} & nom = {2} & prenom = {3}", unInventaire.id_inventaire, unInventaire.id_hero, unInventaire.objetNom, unInventaire.objetPrix);
                }

                dgvInventaire.DataSource = queryHeroInventaire;
            }

            if (dgvInventaire.Rows.Count > 0)
            {
                dgvInventaire.Rows[0].Selected = true;
            }
        }

        private void remplirChampsHero()
        {
            if (dgvHero.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                txbHeroNom.Text                     = dgvHero.SelectedRows[0].Cells[1].Value.ToString();
                txbHeroPrenom.Text                  = dgvHero.SelectedRows[0].Cells[2].Value.ToString();
                txbHeroSpecialite.Text              = dgvHero.SelectedRows[0].Cells[3].Value.ToString();
                txbHeroClasse.Text                  = dgvHero.SelectedRows[0].Cells[4].Value.ToString();

                numUPDOHeroLvl.Value                = int.Parse(dgvHero.SelectedRows[0].Cells[5].Value.ToString());
                numUPDOHeroPuissance.Value          = decimal.Parse(dgvHero.SelectedRows[0].Cells[6].Value.ToString());
                numUPDOHeroNbMissionsReussi.Value   = int.Parse(dgvHero.SelectedRows[0].Cells[7].Value.ToString());
                numUPDOHeroReputation.Value         = decimal.Parse(dgvHero.SelectedRows[0].Cells[8].Value.ToString());

                lblTitreInventaire.Text = "Inventaire du héro : " + dgvHero.SelectedRows[0].Cells[1].Value.ToString();

                updateInventaire();
            }
        }

        private void remplirChampsInventaire()
        {
            if (dgvInventaire.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                txbInventaireNom.Text               = dgvInventaire.SelectedRows[0].Cells[2].Value.ToString();
                txbInventaireDescription.Text       = dgvInventaire.SelectedRows[0].Cells[5].Value.ToString();
                                                      
                numUDInventaireLvl.Value            = int.Parse(dgvInventaire.SelectedRows[0].Cells[3].Value.ToString());
                numUDInventairePrix.Value           = decimal.Parse(dgvInventaire.SelectedRows[0].Cells[6].Value.ToString());
                numUDInventaireQuantite.Value       = int.Parse(dgvInventaire.SelectedRows[0].Cells[4].Value.ToString());
            }
            else
            {
                viderLesChampsInventaire();
            }
        }

        private int recupIdHeroSelectedRow()
        {
            int idHeroSelected = int.Parse(dgvHero.SelectedRows[0].Cells[0].Value.ToString());
            if (idHeroSelected < 0)
            {
                return 0;
            }
            else
            {
                return idHeroSelected;
            }
        }

        private void remplirChampsNbObjetInventaire()
        {
            if (dgvInventaire.Rows.Count > 0)
            {
                int nombre = dgvInventaire.Rows.Count;
                lblHeroSelecQuantiteObjetInventaireNombre.Text = nombre.ToString();
            }
            else
            {
                lblHeroSelecQuantiteObjetInventaireNombre.Text = "0";
            }
        }

        private void updateHero()
        {
            refreshDgvHero();
            remplirChampsHero();
        }

        private void updateInventaire()
        {
            refreshDgvInventaire();
            remplirChampsInventaire();
            remplirChampsNbObjetInventaire();
        }

        #endregion


        #region uselessCode

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblInventaireHeroID_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
