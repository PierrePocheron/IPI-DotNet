namespace FormationDotNetFormsEvaluation
{
    partial class InterfaceGuilde
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txbHeroPrenom = new System.Windows.Forms.TextBox();
            this.lblHeroNom = new System.Windows.Forms.Label();
            this.lblHeroPrenom = new System.Windows.Forms.Label();
            this.lblHeroSpecialite = new System.Windows.Forms.Label();
            this.lblHeroClasse = new System.Windows.Forms.Label();
            this.lblHeroLvl = new System.Windows.Forms.Label();
            this.lblHeroPuissance = new System.Windows.Forms.Label();
            this.txbHeroNom = new System.Windows.Forms.TextBox();
            this.lblHeroNbMissionsReussi = new System.Windows.Forms.Label();
            this.lblReputation = new System.Windows.Forms.Label();
            this.txbHeroSpecialite = new System.Windows.Forms.TextBox();
            this.txbHeroClasse = new System.Windows.Forms.TextBox();
            this.numUPDOHeroLvl = new System.Windows.Forms.NumericUpDown();
            this.numUPDOHeroPuissance = new System.Windows.Forms.NumericUpDown();
            this.numUPDOHeroNbMissionsReussi = new System.Windows.Forms.NumericUpDown();
            this.numUPDOHeroReputation = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblObjet = new System.Windows.Forms.Label();
            this.lblInventaireLvl = new System.Windows.Forms.Label();
            this.lblInventaireQuantite = new System.Windows.Forms.Label();
            this.lblInventaireDescription = new System.Windows.Forms.Label();
            this.lblInventairePrix = new System.Windows.Forms.Label();
            this.txbInventaireNom = new System.Windows.Forms.TextBox();
            this.txbInventaireDescription = new System.Windows.Forms.TextBox();
            this.numUDInventaireLvl = new System.Windows.Forms.NumericUpDown();
            this.numUDInventaireQuantite = new System.Windows.Forms.NumericUpDown();
            this.numUDInventairePrix = new System.Windows.Forms.NumericUpDown();
            this.dgvHero = new System.Windows.Forms.DataGridView();
            this.dgvInventaire = new System.Windows.Forms.DataGridView();
            this.btnHeroAjouter = new System.Windows.Forms.Button();
            this.btnHeroModifier = new System.Windows.Forms.Button();
            this.btnHeroSupprimer = new System.Windows.Forms.Button();
            this.btnInventaireAjouter = new System.Windows.Forms.Button();
            this.btnInventaireModifier = new System.Windows.Forms.Button();
            this.btnInventaireSupprimer = new System.Windows.Forms.Button();
            this.lblHeroSelecQuantiteObjetInventaire = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitreInventaire = new System.Windows.Forms.Label();
            this.lblHeroSelecQuantiteObjetInventaireNombre = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUPDOHeroLvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUPDOHeroPuissance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUPDOHeroNbMissionsReussi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUPDOHeroReputation)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDInventaireLvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDInventaireQuantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDInventairePrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventaire)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txbHeroPrenom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHeroNom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblHeroPrenom, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHeroSpecialite, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblHeroClasse, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblHeroLvl, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblHeroPuissance, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txbHeroNom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblHeroNbMissionsReussi, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblReputation, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txbHeroSpecialite, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txbHeroClasse, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.numUPDOHeroLvl, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.numUPDOHeroPuissance, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.numUPDOHeroNbMissionsReussi, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.numUPDOHeroReputation, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 147);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 219);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txbHeroPrenom
            // 
            this.txbHeroPrenom.Location = new System.Drawing.Point(103, 34);
            this.txbHeroPrenom.Name = "txbHeroPrenom";
            this.txbHeroPrenom.Size = new System.Drawing.Size(297, 20);
            this.txbHeroPrenom.TabIndex = 10;
            // 
            // lblHeroNom
            // 
            this.lblHeroNom.AutoSize = true;
            this.lblHeroNom.Location = new System.Drawing.Point(3, 0);
            this.lblHeroNom.Name = "lblHeroNom";
            this.lblHeroNom.Size = new System.Drawing.Size(35, 13);
            this.lblHeroNom.TabIndex = 1;
            this.lblHeroNom.Text = "Nom :";
            // 
            // lblHeroPrenom
            // 
            this.lblHeroPrenom.AutoSize = true;
            this.lblHeroPrenom.Location = new System.Drawing.Point(3, 31);
            this.lblHeroPrenom.Name = "lblHeroPrenom";
            this.lblHeroPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblHeroPrenom.TabIndex = 2;
            this.lblHeroPrenom.Text = "Prénom :";
            // 
            // lblHeroSpecialite
            // 
            this.lblHeroSpecialite.AutoSize = true;
            this.lblHeroSpecialite.Location = new System.Drawing.Point(3, 65);
            this.lblHeroSpecialite.Name = "lblHeroSpecialite";
            this.lblHeroSpecialite.Size = new System.Drawing.Size(59, 13);
            this.lblHeroSpecialite.TabIndex = 3;
            this.lblHeroSpecialite.Text = "Spécialité :";
            // 
            // lblHeroClasse
            // 
            this.lblHeroClasse.AutoSize = true;
            this.lblHeroClasse.Location = new System.Drawing.Point(3, 95);
            this.lblHeroClasse.Name = "lblHeroClasse";
            this.lblHeroClasse.Size = new System.Drawing.Size(44, 13);
            this.lblHeroClasse.TabIndex = 4;
            this.lblHeroClasse.Text = "Classe :";
            // 
            // lblHeroLvl
            // 
            this.lblHeroLvl.AutoSize = true;
            this.lblHeroLvl.Location = new System.Drawing.Point(3, 122);
            this.lblHeroLvl.Name = "lblHeroLvl";
            this.lblHeroLvl.Size = new System.Drawing.Size(27, 13);
            this.lblHeroLvl.TabIndex = 5;
            this.lblHeroLvl.Text = "Lvl :";
            // 
            // lblHeroPuissance
            // 
            this.lblHeroPuissance.AutoSize = true;
            this.lblHeroPuissance.Location = new System.Drawing.Point(3, 148);
            this.lblHeroPuissance.Name = "lblHeroPuissance";
            this.lblHeroPuissance.Size = new System.Drawing.Size(65, 13);
            this.lblHeroPuissance.TabIndex = 6;
            this.lblHeroPuissance.Text = "Puissance : ";
            // 
            // txbHeroNom
            // 
            this.txbHeroNom.Location = new System.Drawing.Point(103, 3);
            this.txbHeroNom.Name = "txbHeroNom";
            this.txbHeroNom.Size = new System.Drawing.Size(297, 20);
            this.txbHeroNom.TabIndex = 7;
            // 
            // lblHeroNbMissionsReussi
            // 
            this.lblHeroNbMissionsReussi.AutoSize = true;
            this.lblHeroNbMissionsReussi.Location = new System.Drawing.Point(3, 172);
            this.lblHeroNbMissionsReussi.Name = "lblHeroNbMissionsReussi";
            this.lblHeroNbMissionsReussi.Size = new System.Drawing.Size(88, 13);
            this.lblHeroNbMissionsReussi.TabIndex = 7;
            this.lblHeroNbMissionsReussi.Text = "Missions Réussi :";
            // 
            // lblReputation
            // 
            this.lblReputation.AutoSize = true;
            this.lblReputation.Location = new System.Drawing.Point(3, 198);
            this.lblReputation.Name = "lblReputation";
            this.lblReputation.Size = new System.Drawing.Size(65, 13);
            this.lblReputation.TabIndex = 8;
            this.lblReputation.Text = "Réputation :";
            // 
            // txbHeroSpecialite
            // 
            this.txbHeroSpecialite.Location = new System.Drawing.Point(103, 68);
            this.txbHeroSpecialite.Name = "txbHeroSpecialite";
            this.txbHeroSpecialite.Size = new System.Drawing.Size(297, 20);
            this.txbHeroSpecialite.TabIndex = 9;
            // 
            // txbHeroClasse
            // 
            this.txbHeroClasse.Location = new System.Drawing.Point(103, 98);
            this.txbHeroClasse.Name = "txbHeroClasse";
            this.txbHeroClasse.Size = new System.Drawing.Size(297, 20);
            this.txbHeroClasse.TabIndex = 11;
            // 
            // numUPDOHeroLvl
            // 
            this.numUPDOHeroLvl.Location = new System.Drawing.Point(103, 125);
            this.numUPDOHeroLvl.Name = "numUPDOHeroLvl";
            this.numUPDOHeroLvl.Size = new System.Drawing.Size(142, 20);
            this.numUPDOHeroLvl.TabIndex = 12;
            this.numUPDOHeroLvl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUPDOHeroPuissance
            // 
            this.numUPDOHeroPuissance.Location = new System.Drawing.Point(103, 151);
            this.numUPDOHeroPuissance.Name = "numUPDOHeroPuissance";
            this.numUPDOHeroPuissance.Size = new System.Drawing.Size(142, 20);
            this.numUPDOHeroPuissance.TabIndex = 13;
            this.numUPDOHeroPuissance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUPDOHeroNbMissionsReussi
            // 
            this.numUPDOHeroNbMissionsReussi.Location = new System.Drawing.Point(103, 175);
            this.numUPDOHeroNbMissionsReussi.Name = "numUPDOHeroNbMissionsReussi";
            this.numUPDOHeroNbMissionsReussi.Size = new System.Drawing.Size(142, 20);
            this.numUPDOHeroNbMissionsReussi.TabIndex = 14;
            // 
            // numUPDOHeroReputation
            // 
            this.numUPDOHeroReputation.Location = new System.Drawing.Point(103, 201);
            this.numUPDOHeroReputation.Name = "numUPDOHeroReputation";
            this.numUPDOHeroReputation.Size = new System.Drawing.Size(142, 20);
            this.numUPDOHeroReputation.TabIndex = 15;
            this.numUPDOHeroReputation.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.lblObjet, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblInventairePrix, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblInventaireDescription, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.numUDInventairePrix, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txbInventaireDescription, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblInventaireQuantite, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.numUDInventaireQuantite, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblInventaireLvl, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.numUDInventaireLvl, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txbInventaireNom, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(523, 192);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(400, 142);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // lblObjet
            // 
            this.lblObjet.AutoSize = true;
            this.lblObjet.Location = new System.Drawing.Point(3, 0);
            this.lblObjet.Name = "lblObjet";
            this.lblObjet.Size = new System.Drawing.Size(38, 13);
            this.lblObjet.TabIndex = 2;
            this.lblObjet.Text = "Objet :";
            // 
            // lblInventaireLvl
            // 
            this.lblInventaireLvl.AutoSize = true;
            this.lblInventaireLvl.Location = new System.Drawing.Point(3, 56);
            this.lblInventaireLvl.Name = "lblInventaireLvl";
            this.lblInventaireLvl.Size = new System.Drawing.Size(27, 13);
            this.lblInventaireLvl.TabIndex = 3;
            this.lblInventaireLvl.Text = "Lvl :";
            // 
            // lblInventaireQuantite
            // 
            this.lblInventaireQuantite.AutoSize = true;
            this.lblInventaireQuantite.Location = new System.Drawing.Point(3, 83);
            this.lblInventaireQuantite.Name = "lblInventaireQuantite";
            this.lblInventaireQuantite.Size = new System.Drawing.Size(53, 13);
            this.lblInventaireQuantite.TabIndex = 4;
            this.lblInventaireQuantite.Text = "Quantité :";
            // 
            // lblInventaireDescription
            // 
            this.lblInventaireDescription.AutoSize = true;
            this.lblInventaireDescription.Location = new System.Drawing.Point(3, 29);
            this.lblInventaireDescription.Name = "lblInventaireDescription";
            this.lblInventaireDescription.Size = new System.Drawing.Size(66, 13);
            this.lblInventaireDescription.TabIndex = 5;
            this.lblInventaireDescription.Text = "Description :";
            // 
            // lblInventairePrix
            // 
            this.lblInventairePrix.AutoSize = true;
            this.lblInventairePrix.Location = new System.Drawing.Point(3, 113);
            this.lblInventairePrix.Name = "lblInventairePrix";
            this.lblInventairePrix.Size = new System.Drawing.Size(30, 13);
            this.lblInventairePrix.TabIndex = 6;
            this.lblInventairePrix.Text = "Prix :";
            // 
            // txbInventaireNom
            // 
            this.txbInventaireNom.Location = new System.Drawing.Point(123, 3);
            this.txbInventaireNom.Name = "txbInventaireNom";
            this.txbInventaireNom.Size = new System.Drawing.Size(274, 20);
            this.txbInventaireNom.TabIndex = 12;
            // 
            // txbInventaireDescription
            // 
            this.txbInventaireDescription.Location = new System.Drawing.Point(123, 32);
            this.txbInventaireDescription.Name = "txbInventaireDescription";
            this.txbInventaireDescription.Size = new System.Drawing.Size(274, 20);
            this.txbInventaireDescription.TabIndex = 13;
            // 
            // numUDInventaireLvl
            // 
            this.numUDInventaireLvl.Location = new System.Drawing.Point(123, 59);
            this.numUDInventaireLvl.Name = "numUDInventaireLvl";
            this.numUDInventaireLvl.Size = new System.Drawing.Size(120, 20);
            this.numUDInventaireLvl.TabIndex = 18;
            this.numUDInventaireLvl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUDInventaireQuantite
            // 
            this.numUDInventaireQuantite.Location = new System.Drawing.Point(123, 86);
            this.numUDInventaireQuantite.Name = "numUDInventaireQuantite";
            this.numUDInventaireQuantite.Size = new System.Drawing.Size(120, 20);
            this.numUDInventaireQuantite.TabIndex = 19;
            this.numUDInventaireQuantite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUDInventairePrix
            // 
            this.numUDInventairePrix.Location = new System.Drawing.Point(123, 116);
            this.numUDInventairePrix.Name = "numUDInventairePrix";
            this.numUDInventairePrix.Size = new System.Drawing.Size(120, 20);
            this.numUDInventairePrix.TabIndex = 20;
            this.numUDInventairePrix.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvHero
            // 
            this.dgvHero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHero.Location = new System.Drawing.Point(19, 382);
            this.dgvHero.Name = "dgvHero";
            this.dgvHero.Size = new System.Drawing.Size(400, 254);
            this.dgvHero.TabIndex = 10;
            this.dgvHero.SelectionChanged += new System.EventHandler(this.dgvHero_SelectionChanged);
            // 
            // dgvInventaire
            // 
            this.dgvInventaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventaire.Location = new System.Drawing.Point(523, 382);
            this.dgvInventaire.Name = "dgvInventaire";
            this.dgvInventaire.Size = new System.Drawing.Size(400, 254);
            this.dgvInventaire.TabIndex = 11;
            this.dgvInventaire.SelectionChanged += new System.EventHandler(this.dgvInventaire_SelectionChanged);
            // 
            // btnHeroAjouter
            // 
            this.btnHeroAjouter.BackColor = System.Drawing.Color.LightGreen;
            this.btnHeroAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnHeroAjouter.Location = new System.Drawing.Point(19, 642);
            this.btnHeroAjouter.Name = "btnHeroAjouter";
            this.btnHeroAjouter.Size = new System.Drawing.Size(122, 41);
            this.btnHeroAjouter.TabIndex = 12;
            this.btnHeroAjouter.Text = "➕ Recruter ➕";
            this.btnHeroAjouter.UseVisualStyleBackColor = false;
            this.btnHeroAjouter.Click += new System.EventHandler(this.btnHeroAjouter_Click);
            // 
            // btnHeroModifier
            // 
            this.btnHeroModifier.BackColor = System.Drawing.Color.LightSalmon;
            this.btnHeroModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnHeroModifier.Location = new System.Drawing.Point(160, 642);
            this.btnHeroModifier.Name = "btnHeroModifier";
            this.btnHeroModifier.Size = new System.Drawing.Size(123, 41);
            this.btnHeroModifier.TabIndex = 13;
            this.btnHeroModifier.Text = "🖊️ Modifier 🖊️";
            this.btnHeroModifier.UseVisualStyleBackColor = false;
            this.btnHeroModifier.Click += new System.EventHandler(this.btnHeroModifier_Click);
            // 
            // btnHeroSupprimer
            // 
            this.btnHeroSupprimer.BackColor = System.Drawing.Color.IndianRed;
            this.btnHeroSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnHeroSupprimer.Location = new System.Drawing.Point(301, 642);
            this.btnHeroSupprimer.Name = "btnHeroSupprimer";
            this.btnHeroSupprimer.Size = new System.Drawing.Size(118, 41);
            this.btnHeroSupprimer.TabIndex = 14;
            this.btnHeroSupprimer.Text = "❌ Exclure ❌";
            this.btnHeroSupprimer.UseVisualStyleBackColor = false;
            this.btnHeroSupprimer.Click += new System.EventHandler(this.btnHeroSupprimer_Click);
            // 
            // btnInventaireAjouter
            // 
            this.btnInventaireAjouter.BackColor = System.Drawing.Color.LightGreen;
            this.btnInventaireAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnInventaireAjouter.Location = new System.Drawing.Point(523, 642);
            this.btnInventaireAjouter.Name = "btnInventaireAjouter";
            this.btnInventaireAjouter.Size = new System.Drawing.Size(129, 41);
            this.btnInventaireAjouter.TabIndex = 15;
            this.btnInventaireAjouter.Text = "➕ Ajouter ➕";
            this.btnInventaireAjouter.UseVisualStyleBackColor = false;
            this.btnInventaireAjouter.Click += new System.EventHandler(this.btnInventaireAjouter_Click);
            // 
            // btnInventaireModifier
            // 
            this.btnInventaireModifier.BackColor = System.Drawing.Color.LightSalmon;
            this.btnInventaireModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnInventaireModifier.Location = new System.Drawing.Point(678, 642);
            this.btnInventaireModifier.Name = "btnInventaireModifier";
            this.btnInventaireModifier.Size = new System.Drawing.Size(117, 41);
            this.btnInventaireModifier.TabIndex = 16;
            this.btnInventaireModifier.Text = "🖊️ Modifier 🖊️";
            this.btnInventaireModifier.UseVisualStyleBackColor = false;
            this.btnInventaireModifier.Click += new System.EventHandler(this.btnInventaireModifier_Click);
            // 
            // btnInventaireSupprimer
            // 
            this.btnInventaireSupprimer.BackColor = System.Drawing.Color.IndianRed;
            this.btnInventaireSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnInventaireSupprimer.Location = new System.Drawing.Point(817, 642);
            this.btnInventaireSupprimer.Name = "btnInventaireSupprimer";
            this.btnInventaireSupprimer.Size = new System.Drawing.Size(106, 41);
            this.btnInventaireSupprimer.TabIndex = 17;
            this.btnInventaireSupprimer.Text = "❌ Jetter ❌";
            this.btnInventaireSupprimer.UseVisualStyleBackColor = false;
            this.btnInventaireSupprimer.Click += new System.EventHandler(this.btnInventaireSupprimer_Click);
            // 
            // lblHeroSelecQuantiteObjetInventaire
            // 
            this.lblHeroSelecQuantiteObjetInventaire.AutoSize = true;
            this.lblHeroSelecQuantiteObjetInventaire.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroSelecQuantiteObjetInventaire.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblHeroSelecQuantiteObjetInventaire.Location = new System.Drawing.Point(520, 151);
            this.lblHeroSelecQuantiteObjetInventaire.Name = "lblHeroSelecQuantiteObjetInventaire";
            this.lblHeroSelecQuantiteObjetInventaire.Size = new System.Drawing.Size(174, 18);
            this.lblHeroSelecQuantiteObjetInventaire.TabIndex = 19;
            this.lblHeroSelecQuantiteObjetInventaire.Text = "Objets dans l\'inventaire : ";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Imprint MT Shadow", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.lblTitre.Location = new System.Drawing.Point(236, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(556, 47);
            this.lblTitre.TabIndex = 22;
            this.lblTitre.Text = "Interface de la Guilde DotNet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Location = new System.Drawing.Point(101, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Membres de la Guilde";
            // 
            // lblTitreInventaire
            // 
            this.lblTitreInventaire.AutoSize = true;
            this.lblTitreInventaire.Font = new System.Drawing.Font("Imprint MT Shadow", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblTitreInventaire.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.lblTitreInventaire.Location = new System.Drawing.Point(543, 100);
            this.lblTitreInventaire.Name = "lblTitreInventaire";
            this.lblTitreInventaire.Size = new System.Drawing.Size(260, 32);
            this.lblTitreInventaire.TabIndex = 24;
            this.lblTitreInventaire.Text = "Inventaire du héro :";
            // 
            // lblHeroSelecQuantiteObjetInventaireNombre
            // 
            this.lblHeroSelecQuantiteObjetInventaireNombre.AutoSize = true;
            this.lblHeroSelecQuantiteObjetInventaireNombre.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroSelecQuantiteObjetInventaireNombre.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblHeroSelecQuantiteObjetInventaireNombre.Location = new System.Drawing.Point(700, 146);
            this.lblHeroSelecQuantiteObjetInventaireNombre.Name = "lblHeroSelecQuantiteObjetInventaireNombre";
            this.lblHeroSelecQuantiteObjetInventaireNombre.Size = new System.Drawing.Size(25, 28);
            this.lblHeroSelecQuantiteObjetInventaireNombre.TabIndex = 25;
            this.lblHeroSelecQuantiteObjetInventaireNombre.Text = "0";
            this.lblHeroSelecQuantiteObjetInventaireNombre.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // InterfaceGuilde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(935, 694);
            this.Controls.Add(this.lblHeroSelecQuantiteObjetInventaireNombre);
            this.Controls.Add(this.lblTitreInventaire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblHeroSelecQuantiteObjetInventaire);
            this.Controls.Add(this.btnInventaireSupprimer);
            this.Controls.Add(this.btnInventaireModifier);
            this.Controls.Add(this.btnInventaireAjouter);
            this.Controls.Add(this.btnHeroSupprimer);
            this.Controls.Add(this.btnHeroModifier);
            this.Controls.Add(this.btnHeroAjouter);
            this.Controls.Add(this.dgvInventaire);
            this.Controls.Add(this.dgvHero);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "InterfaceGuilde";
            this.Text = "Interface de la Guilde";
            this.Load += new System.EventHandler(this.InterfaceGuilde_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUPDOHeroLvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUPDOHeroPuissance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUPDOHeroNbMissionsReussi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUPDOHeroReputation)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDInventaireLvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDInventaireQuantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDInventairePrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHeroNom;
        private System.Windows.Forms.Label lblHeroPrenom;
        private System.Windows.Forms.Label lblHeroSpecialite;
        private System.Windows.Forms.Label lblHeroClasse;
        private System.Windows.Forms.Label lblHeroLvl;
        private System.Windows.Forms.Label lblHeroPuissance;
        private System.Windows.Forms.Label lblHeroNbMissionsReussi;
        private System.Windows.Forms.Label lblReputation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblObjet;
        private System.Windows.Forms.TextBox txbHeroPrenom;
        private System.Windows.Forms.TextBox txbHeroNom;
        private System.Windows.Forms.TextBox txbHeroSpecialite;
        private System.Windows.Forms.TextBox txbHeroClasse;
        private System.Windows.Forms.NumericUpDown numUPDOHeroLvl;
        private System.Windows.Forms.NumericUpDown numUPDOHeroPuissance;
        private System.Windows.Forms.NumericUpDown numUPDOHeroNbMissionsReussi;
        private System.Windows.Forms.NumericUpDown numUPDOHeroReputation;
        private System.Windows.Forms.Label lblInventaireLvl;
        private System.Windows.Forms.Label lblInventaireQuantite;
        private System.Windows.Forms.Label lblInventaireDescription;
        private System.Windows.Forms.Label lblInventairePrix;
        private System.Windows.Forms.TextBox txbInventaireNom;
        private System.Windows.Forms.TextBox txbInventaireDescription;
        private System.Windows.Forms.DataGridView dgvHero;
        private System.Windows.Forms.DataGridView dgvInventaire;
        private System.Windows.Forms.Button btnHeroAjouter;
        private System.Windows.Forms.Button btnHeroModifier;
        private System.Windows.Forms.Button btnHeroSupprimer;
        private System.Windows.Forms.Button btnInventaireAjouter;
        private System.Windows.Forms.Button btnInventaireModifier;
        private System.Windows.Forms.Button btnInventaireSupprimer;
        private System.Windows.Forms.NumericUpDown numUDInventaireLvl;
        private System.Windows.Forms.NumericUpDown numUDInventaireQuantite;
        private System.Windows.Forms.NumericUpDown numUDInventairePrix;
        private System.Windows.Forms.Label lblHeroSelecQuantiteObjetInventaire;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitreInventaire;
        private System.Windows.Forms.Label lblHeroSelecQuantiteObjetInventaireNombre;
    }
}

