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
            this.dgvHero = new System.Windows.Forms.DataGridView();
            this.dgvInventaire = new System.Windows.Forms.DataGridView();
            this.btnHeroAjouter = new System.Windows.Forms.Button();
            this.btnHeroModifier = new System.Windows.Forms.Button();
            this.btnHeroSupprimer = new System.Windows.Forms.Button();
            this.btnInventaireAjouter = new System.Windows.Forms.Button();
            this.btnInventaireModifier = new System.Windows.Forms.Button();
            this.btnInventaireSupprimer = new System.Windows.Forms.Button();
            this.numUDInventaireLvl = new System.Windows.Forms.NumericUpDown();
            this.numUDInventaireQuantite = new System.Windows.Forms.NumericUpDown();
            this.numUDInventairePrix = new System.Windows.Forms.NumericUpDown();
            this.lblHeroSelecNom = new System.Windows.Forms.Label();
            this.lblHeroSelecQuantiteObjetInventaire = new System.Windows.Forms.Label();
            this.lblInventaireHeroID = new System.Windows.Forms.Label();
            this.cmbHero = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUPDOHeroLvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUPDOHeroPuissance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUPDOHeroNbMissionsReussi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUPDOHeroReputation)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDInventaireLvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDInventaireQuantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDInventairePrix)).BeginInit();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 124);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 225);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txbHeroPrenom
            // 
            this.txbHeroPrenom.Location = new System.Drawing.Point(103, 34);
            this.txbHeroPrenom.Name = "txbHeroPrenom";
            this.txbHeroPrenom.Size = new System.Drawing.Size(94, 20);
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
            this.txbHeroNom.Size = new System.Drawing.Size(94, 20);
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
            this.txbHeroSpecialite.Size = new System.Drawing.Size(94, 20);
            this.txbHeroSpecialite.TabIndex = 9;
            // 
            // txbHeroClasse
            // 
            this.txbHeroClasse.Location = new System.Drawing.Point(103, 98);
            this.txbHeroClasse.Name = "txbHeroClasse";
            this.txbHeroClasse.Size = new System.Drawing.Size(94, 20);
            this.txbHeroClasse.TabIndex = 11;
            // 
            // numUPDOHeroLvl
            // 
            this.numUPDOHeroLvl.Location = new System.Drawing.Point(103, 125);
            this.numUPDOHeroLvl.Name = "numUPDOHeroLvl";
            this.numUPDOHeroLvl.Size = new System.Drawing.Size(94, 20);
            this.numUPDOHeroLvl.TabIndex = 12;
            // 
            // numUPDOHeroPuissance
            // 
            this.numUPDOHeroPuissance.Location = new System.Drawing.Point(103, 151);
            this.numUPDOHeroPuissance.Name = "numUPDOHeroPuissance";
            this.numUPDOHeroPuissance.Size = new System.Drawing.Size(94, 20);
            this.numUPDOHeroPuissance.TabIndex = 13;
            // 
            // numUPDOHeroNbMissionsReussi
            // 
            this.numUPDOHeroNbMissionsReussi.Location = new System.Drawing.Point(103, 175);
            this.numUPDOHeroNbMissionsReussi.Name = "numUPDOHeroNbMissionsReussi";
            this.numUPDOHeroNbMissionsReussi.Size = new System.Drawing.Size(94, 20);
            this.numUPDOHeroNbMissionsReussi.TabIndex = 14;
            // 
            // numUPDOHeroReputation
            // 
            this.numUPDOHeroReputation.Location = new System.Drawing.Point(103, 201);
            this.numUPDOHeroReputation.Name = "numUPDOHeroReputation";
            this.numUPDOHeroReputation.Size = new System.Drawing.Size(94, 20);
            this.numUPDOHeroReputation.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblObjet, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblInventaireLvl, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblInventaireQuantite, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblInventaireDescription, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblInventairePrix, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.txbInventaireNom, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txbInventaireDescription, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.numUDInventaireLvl, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.numUDInventaireQuantite, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.numUDInventairePrix, 1, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 447);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(194, 196);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // lblObjet
            // 
            this.lblObjet.AutoSize = true;
            this.lblObjet.Location = new System.Drawing.Point(3, 54);
            this.lblObjet.Name = "lblObjet";
            this.lblObjet.Size = new System.Drawing.Size(38, 13);
            this.lblObjet.TabIndex = 2;
            this.lblObjet.Text = "Objet :";
            // 
            // lblInventaireLvl
            // 
            this.lblInventaireLvl.AutoSize = true;
            this.lblInventaireLvl.Location = new System.Drawing.Point(3, 83);
            this.lblInventaireLvl.Name = "lblInventaireLvl";
            this.lblInventaireLvl.Size = new System.Drawing.Size(27, 13);
            this.lblInventaireLvl.TabIndex = 3;
            this.lblInventaireLvl.Text = "Lvl :";
            // 
            // lblInventaireQuantite
            // 
            this.lblInventaireQuantite.AutoSize = true;
            this.lblInventaireQuantite.Location = new System.Drawing.Point(3, 110);
            this.lblInventaireQuantite.Name = "lblInventaireQuantite";
            this.lblInventaireQuantite.Size = new System.Drawing.Size(53, 13);
            this.lblInventaireQuantite.TabIndex = 4;
            this.lblInventaireQuantite.Text = "Quantité :";
            // 
            // lblInventaireDescription
            // 
            this.lblInventaireDescription.AutoSize = true;
            this.lblInventaireDescription.Location = new System.Drawing.Point(3, 137);
            this.lblInventaireDescription.Name = "lblInventaireDescription";
            this.lblInventaireDescription.Size = new System.Drawing.Size(66, 13);
            this.lblInventaireDescription.TabIndex = 5;
            this.lblInventaireDescription.Text = "Description :";
            // 
            // lblInventairePrix
            // 
            this.lblInventairePrix.AutoSize = true;
            this.lblInventairePrix.Location = new System.Drawing.Point(3, 167);
            this.lblInventairePrix.Name = "lblInventairePrix";
            this.lblInventairePrix.Size = new System.Drawing.Size(30, 13);
            this.lblInventairePrix.TabIndex = 6;
            this.lblInventairePrix.Text = "Prix :";
            // 
            // txbInventaireNom
            // 
            this.txbInventaireNom.Location = new System.Drawing.Point(100, 57);
            this.txbInventaireNom.Name = "txbInventaireNom";
            this.txbInventaireNom.Size = new System.Drawing.Size(91, 20);
            this.txbInventaireNom.TabIndex = 12;
            // 
            // txbInventaireDescription
            // 
            this.txbInventaireDescription.Location = new System.Drawing.Point(100, 140);
            this.txbInventaireDescription.Name = "txbInventaireDescription";
            this.txbInventaireDescription.Size = new System.Drawing.Size(91, 20);
            this.txbInventaireDescription.TabIndex = 13;
            // 
            // dgvHero
            // 
            this.dgvHero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHero.Location = new System.Drawing.Point(244, 95);
            this.dgvHero.Name = "dgvHero";
            this.dgvHero.Size = new System.Drawing.Size(637, 254);
            this.dgvHero.TabIndex = 10;
            this.dgvHero.SelectionChanged += new System.EventHandler(this.dgvHero_SelectionChanged);
            // 
            // dgvInventaire
            // 
            this.dgvInventaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventaire.Location = new System.Drawing.Point(244, 447);
            this.dgvInventaire.Name = "dgvInventaire";
            this.dgvInventaire.Size = new System.Drawing.Size(637, 196);
            this.dgvInventaire.TabIndex = 11;
            this.dgvInventaire.SelectionChanged += new System.EventHandler(this.dgvInventaire_SelectionChanged);
            // 
            // btnHeroAjouter
            // 
            this.btnHeroAjouter.Location = new System.Drawing.Point(905, 98);
            this.btnHeroAjouter.Name = "btnHeroAjouter";
            this.btnHeroAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnHeroAjouter.TabIndex = 12;
            this.btnHeroAjouter.Text = "Ajouter";
            this.btnHeroAjouter.UseVisualStyleBackColor = true;
            this.btnHeroAjouter.Click += new System.EventHandler(this.btnHeroAjouter_Click);
            // 
            // btnHeroModifier
            // 
            this.btnHeroModifier.Location = new System.Drawing.Point(905, 211);
            this.btnHeroModifier.Name = "btnHeroModifier";
            this.btnHeroModifier.Size = new System.Drawing.Size(75, 23);
            this.btnHeroModifier.TabIndex = 13;
            this.btnHeroModifier.Text = "Modifier";
            this.btnHeroModifier.UseVisualStyleBackColor = true;
            this.btnHeroModifier.Click += new System.EventHandler(this.btnHeroModifier_Click);
            // 
            // btnHeroSupprimer
            // 
            this.btnHeroSupprimer.Location = new System.Drawing.Point(905, 329);
            this.btnHeroSupprimer.Name = "btnHeroSupprimer";
            this.btnHeroSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnHeroSupprimer.TabIndex = 14;
            this.btnHeroSupprimer.Text = "Supprimer";
            this.btnHeroSupprimer.UseVisualStyleBackColor = true;
            this.btnHeroSupprimer.Click += new System.EventHandler(this.btnHeroSupprimer_Click);
            // 
            // btnInventaireAjouter
            // 
            this.btnInventaireAjouter.Location = new System.Drawing.Point(905, 450);
            this.btnInventaireAjouter.Name = "btnInventaireAjouter";
            this.btnInventaireAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnInventaireAjouter.TabIndex = 15;
            this.btnInventaireAjouter.Text = "Ajouter";
            this.btnInventaireAjouter.UseVisualStyleBackColor = true;
            this.btnInventaireAjouter.Click += new System.EventHandler(this.btnInventaireAjouter_Click);
            // 
            // btnInventaireModifier
            // 
            this.btnInventaireModifier.Location = new System.Drawing.Point(905, 533);
            this.btnInventaireModifier.Name = "btnInventaireModifier";
            this.btnInventaireModifier.Size = new System.Drawing.Size(75, 23);
            this.btnInventaireModifier.TabIndex = 16;
            this.btnInventaireModifier.Text = "Modifier";
            this.btnInventaireModifier.UseVisualStyleBackColor = true;
            this.btnInventaireModifier.Click += new System.EventHandler(this.btnInventaireModifier_Click);
            // 
            // btnInventaireSupprimer
            // 
            this.btnInventaireSupprimer.Location = new System.Drawing.Point(905, 620);
            this.btnInventaireSupprimer.Name = "btnInventaireSupprimer";
            this.btnInventaireSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnInventaireSupprimer.TabIndex = 17;
            this.btnInventaireSupprimer.Text = "Supprimer";
            this.btnInventaireSupprimer.UseVisualStyleBackColor = true;
            this.btnInventaireSupprimer.Click += new System.EventHandler(this.btnInventaireSupprimer_Click);
            // 
            // numUDInventaireLvl
            // 
            this.numUDInventaireLvl.Location = new System.Drawing.Point(100, 86);
            this.numUDInventaireLvl.Name = "numUDInventaireLvl";
            this.numUDInventaireLvl.Size = new System.Drawing.Size(91, 20);
            this.numUDInventaireLvl.TabIndex = 18;
            // 
            // numUDInventaireQuantite
            // 
            this.numUDInventaireQuantite.Location = new System.Drawing.Point(100, 113);
            this.numUDInventaireQuantite.Name = "numUDInventaireQuantite";
            this.numUDInventaireQuantite.Size = new System.Drawing.Size(91, 20);
            this.numUDInventaireQuantite.TabIndex = 19;
            // 
            // numUDInventairePrix
            // 
            this.numUDInventairePrix.Location = new System.Drawing.Point(100, 170);
            this.numUDInventairePrix.Name = "numUDInventairePrix";
            this.numUDInventairePrix.Size = new System.Drawing.Size(91, 20);
            this.numUDInventairePrix.TabIndex = 20;
            // 
            // lblHeroSelecNom
            // 
            this.lblHeroSelecNom.AutoSize = true;
            this.lblHeroSelecNom.Location = new System.Drawing.Point(268, 58);
            this.lblHeroSelecNom.Name = "lblHeroSelecNom";
            this.lblHeroSelecNom.Size = new System.Drawing.Size(96, 13);
            this.lblHeroSelecNom.TabIndex = 18;
            this.lblHeroSelecNom.Text = "Héro sélectionné : ";
            this.lblHeroSelecNom.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHeroSelecQuantiteObjetInventaire
            // 
            this.lblHeroSelecQuantiteObjetInventaire.AutoSize = true;
            this.lblHeroSelecQuantiteObjetInventaire.Location = new System.Drawing.Point(520, 58);
            this.lblHeroSelecQuantiteObjetInventaire.Name = "lblHeroSelecQuantiteObjetInventaire";
            this.lblHeroSelecQuantiteObjetInventaire.Size = new System.Drawing.Size(125, 13);
            this.lblHeroSelecQuantiteObjetInventaire.TabIndex = 19;
            this.lblHeroSelecQuantiteObjetInventaire.Text = "Objets dans l\'inventaire : ";
            // 
            // lblInventaireHeroID
            // 
            this.lblInventaireHeroID.AutoSize = true;
            this.lblInventaireHeroID.Location = new System.Drawing.Point(10, 410);
            this.lblInventaireHeroID.Name = "lblInventaireHeroID";
            this.lblInventaireHeroID.Size = new System.Drawing.Size(116, 13);
            this.lblInventaireHeroID.TabIndex = 20;
            this.lblInventaireHeroID.Text = "Sélectionner un Héro  :";
            this.lblInventaireHeroID.Click += new System.EventHandler(this.lblInventaireHeroID_Click);
            // 
            // cmbHero
            // 
            this.cmbHero.FormattingEnabled = true;
            this.cmbHero.Location = new System.Drawing.Point(132, 407);
            this.cmbHero.Name = "cmbHero";
            this.cmbHero.Size = new System.Drawing.Size(161, 21);
            this.cmbHero.TabIndex = 21;
            // 
            // InterfaceGuilde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 655);
            this.Controls.Add(this.lblInventaireHeroID);
            this.Controls.Add(this.cmbHero);
            this.Controls.Add(this.lblHeroSelecQuantiteObjetInventaire);
            this.Controls.Add(this.lblHeroSelecNom);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvHero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDInventaireLvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDInventaireQuantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDInventairePrix)).EndInit();
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
        private System.Windows.Forms.Label lblHeroSelecNom;
        private System.Windows.Forms.Label lblHeroSelecQuantiteObjetInventaire;
        private System.Windows.Forms.Label lblInventaireHeroID;
        private System.Windows.Forms.ComboBox cmbHero;
    }
}

