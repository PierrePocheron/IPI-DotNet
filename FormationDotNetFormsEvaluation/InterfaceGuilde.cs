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
            //var nomHeros = entiteHero.Heros.Select(a => new Heros { nom = a.nom, prenom = a.prenom });

            Console.WriteLine(listeHeros.ToString());


            dgvHero.DataSource = listeHeros;
            //cmbHero.DataSource = nomHeros;

            //  Initialisation du DGV Inventaire
            /*WORLDMMOEntities entiteInventaire = new WORLDMMOEntities();
            List<Inventaire> listeInventaires = entiteInventaire.Inventaire.ToList();
            dgvInventaire.DataSource = listeInventaires;*/
        }

        private void btnHeroAjouter_Click(object sender, EventArgs e)
        {
            // Création d'un objet Hero
            Heros unHero = new Heros();

            //  Valorisation de notre objet héro
            unHero.nom              =   txbHeroNom.Text;
            unHero.prenom           =   txbHeroPrenom.Text;
            unHero.specialite       =   txbHeroSpecialite.Text;
            unHero.classe           =   txbHeroClasse.Text;

            unHero.lvl              =   (int)numUPDOHeroLvl.Value;
            unHero.nbMissionReussi  =   (int)numUPDOHeroNbMissionsReussi.Value;
            unHero.puissance        =   (int)numUPDOHeroPuissance.Value;
            unHero.reputation       =   (int)numUPDOHeroReputation.Value;

            //  Création d'une entite correspondant a notre héro
            WORLDMMOEntities entiteHero = new WORLDMMOEntities();
            entiteHero.Heros.Add(unHero);
            //  Envoi en bdd du héro
            entiteHero.SaveChanges();

            //  Création d'une entite correspondant a l'inventaire de notre héro
            /*Inventaire unInventaire = new Inventaire();
            unInventaire.id_hero = unHero.id_hero;
            WORLDMMOEntities entiteInventaire = new WORLDMMOEntities();
            entiteInventaire.Inventaire.Add(unInventaire);
            entiteInventaire.SaveChanges();*/

            Console.WriteLine(unHero.id_hero);

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
                int idHero = int.Parse(dgvHero.SelectedRows[0].Cells[0].Value.ToString());

                

                /*WORLDMMOEntities entiteInventaire = new WORLDMMOEntities();     
                Inventaire inventaireASupprimer = entiteInventaire.Inventaire.Where(a => a.id_hero == idHero).FirstOrDefault();

                Console.WriteLine(entiteInventaire.Inventaire.Where(a => a.id_hero == idHero).FirstOrDefault());
                entiteInventaire.Inventaire.Remove(inventaireASupprimer);
                entiteInventaire.SaveChanges();*/

                WORLDMMOEntities entiteHero = new WORLDMMOEntities();
                Console.WriteLine(idHero);
                Heros heroASupprimer = entiteHero.Heros.Where(a => a.id_hero == idHero).FirstOrDefault();

                /*if (entiteInventaire.Inventaire.Where(a => a.id_hero == idHero).FirstOrDefault())
                {

                }*/

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
            unInventaire.objetLvl = (int)numUDInventaireLvl.Value;
            unInventaire.objetQuantite = (int)numUDInventaireQuantite.Value;
            unInventaire.objetDescription = txbInventaireDescription.Text;
            unInventaire.objetPrix = (float)numUDInventairePrix.Value;

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
                inventaireAModifier.objetLvl = (int)numUDInventaireLvl.Value;
                inventaireAModifier.objetQuantite = (int)numUDInventaireQuantite.Value;
                inventaireAModifier.objetDescription = txbInventaireDescription.Text;
                inventaireAModifier.objetPrix = (float)numUDInventairePrix.Value;

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
            numUDInventaireLvl.Value = 0;
            numUDInventairePrix.Value = 0;
            numUDInventaireQuantite.Value = 0;

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
                numUPDOHeroPuissance.Value          = decimal.Parse(dgvHero.SelectedRows[0].Cells[6].Value.ToString());
                numUPDOHeroNbMissionsReussi.Value   = decimal.Parse(dgvHero.SelectedRows[0].Cells[7].Value.ToString());
                numUPDOHeroReputation.Value         = decimal.Parse(dgvHero.SelectedRows[0].Cells[8].Value.ToString());

                lblHeroSelecNom.Text                = "Héro sélectionné : " + dgvHero.SelectedRows[0].Cells[1].Value.ToString();
                lblHeroSelecQuantiteObjetInventaire.Text = "Objets dans l'inventaire : " + "5";


                WORLDMMOEntities entiteInventaire = new WORLDMMOEntities();
                int idHero = int.Parse(dgvHero.SelectedRows[0].Cells[0].Value.ToString());

                Console.WriteLine("id hero selec : " + idHero);

                //Inventaire inventaireAModifier = entiteInventaire.Inventaire.Where(a => a.id_inventaire == idHero).FirstOrDefault();

                /*if (inventaireAModifier == null)
                {
                    Console.WriteLine("il est null");
                }
                else
                {
                    Console.WriteLine(inventaireAModifier);

                    txbInventaireNom.Text           = inventaireAModifier.objetNom;
                    txbInventaireDescription.Text   = inventaireAModifier.objetDescription;
                    numUDInventaireLvl.Value        = inventaireAModifier.objetLvl;
                    numUDInventairePrix.Value       = inventaireAModifier.objetQuantite;
                    numUDInventaireQuantite.Value   = inventaireAModifier.objetPrix;
                }*/
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


        private void checkInventaire()
        {
            Boolean check = false;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblInventaireHeroID_Click(object sender, EventArgs e)
        {

        }

        // =========== Les fonctions privées ==========
        // =========== Les fonctions privées ==========


    }
}
