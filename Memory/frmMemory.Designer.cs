namespace Memory
{
    partial class frmMemory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemory));
            this.tlpTapisDeCartes = new System.Windows.Forms.TableLayoutPanel();
            this.ImagesCarte = new System.Windows.Forms.ImageList(this.components);
            this.btn_Jouer = new System.Windows.Forms.Button();
            this.lbscore = new System.Windows.Forms.Label();
            this.lbNbCoup = new System.Windows.Forms.Label();
            this.lbNbPaire = new System.Windows.Forms.Label();
            this.lbtemps = new System.Windows.Forms.Label();
            this.tpsJeu = new System.Windows.Forms.Timer(this.components);
            this.lbtpsSec = new System.Windows.Forms.Label();
            this.CB_theme = new System.Windows.Forms.ComboBox();
            this.btn_Rejouer = new System.Windows.Forms.Button();
            this.Animaux = new System.Windows.Forms.ImageList(this.components);
            this.Fleurs = new System.Windows.Forms.ImageList(this.components);
            this.Vehicules = new System.Windows.Forms.ImageList(this.components);
            this.Personnages = new System.Windows.Forms.ImageList(this.components);
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.lb_Message = new System.Windows.Forms.Label();
            this.CB_nbCarte = new System.Windows.Forms.ComboBox();
            this.lb_theme = new System.Windows.Forms.Label();
            this.lb_nbCarte = new System.Windows.Forms.Label();
            this.lb_Titre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tlpTapisDeCartes
            // 
            this.tlpTapisDeCartes.ColumnCount = 8;
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpTapisDeCartes.Location = new System.Drawing.Point(41, 121);
            this.tlpTapisDeCartes.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTapisDeCartes.Name = "tlpTapisDeCartes";
            this.tlpTapisDeCartes.RowCount = 4;
            this.tlpTapisDeCartes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.Size = new System.Drawing.Size(850, 425);
            this.tlpTapisDeCartes.TabIndex = 0;
            // 
            // ImagesCarte
            // 
            this.ImagesCarte.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImagesCarte.ImageStream")));
            this.ImagesCarte.TransparentColor = System.Drawing.Color.Transparent;
            this.ImagesCarte.Images.SetKeyName(0, "DosCarte.jpg");
            this.ImagesCarte.Images.SetKeyName(1, "FemmeAffaire.jpg");
            this.ImagesCarte.Images.SetKeyName(2, "FemmeBatiment.jpg");
            this.ImagesCarte.Images.SetKeyName(3, "FemmeBlanche.jpg");
            this.ImagesCarte.Images.SetKeyName(4, "FemmeBleue.jpg");
            this.ImagesCarte.Images.SetKeyName(5, "FemmeCasque.jpg");
            this.ImagesCarte.Images.SetKeyName(6, "FemmeCuisinier.jpg");
            this.ImagesCarte.Images.SetKeyName(7, "FemmeInformaticienBrune.jpg");
            this.ImagesCarte.Images.SetKeyName(8, "FemmeInformaticienChatain.jpg");
            this.ImagesCarte.Images.SetKeyName(9, "FemmeJournal.jpg");
            this.ImagesCarte.Images.SetKeyName(10, "FemmeMedecin.jpg");
            this.ImagesCarte.Images.SetKeyName(11, "FemmeMegaphone.jpg");
            this.ImagesCarte.Images.SetKeyName(12, "FemmeOrange.jpg");
            this.ImagesCarte.Images.SetKeyName(13, "FemmePhotographe.jpg");
            this.ImagesCarte.Images.SetKeyName(14, "FemmePoliciere.jpg");
            this.ImagesCarte.Images.SetKeyName(15, "HommeAffaire.jpg");
            this.ImagesCarte.Images.SetKeyName(16, "HommeBatiment.jpg");
            this.ImagesCarte.Images.SetKeyName(17, "HommeBleu.jpg");
            this.ImagesCarte.Images.SetKeyName(18, "HommeCasque.jpg");
            this.ImagesCarte.Images.SetKeyName(19, "HommeCuisinier.jpg");
            this.ImagesCarte.Images.SetKeyName(20, "HommeGarde.jpg");
            this.ImagesCarte.Images.SetKeyName(21, "HommeInformaticienBrun.jpg");
            this.ImagesCarte.Images.SetKeyName(22, "HommeInformaticienChatain.jpg");
            this.ImagesCarte.Images.SetKeyName(23, "HommeJournal.jpg");
            this.ImagesCarte.Images.SetKeyName(24, "HommeMarron.jpg");
            this.ImagesCarte.Images.SetKeyName(25, "HommeMedecin.jpg");
            this.ImagesCarte.Images.SetKeyName(26, "HommeMegaphone.jpg");
            this.ImagesCarte.Images.SetKeyName(27, "HommeOrange.jpg");
            this.ImagesCarte.Images.SetKeyName(28, "HommePhotographe.jpg");
            this.ImagesCarte.Images.SetKeyName(29, "HommePolicier.jpg");
            this.ImagesCarte.Images.SetKeyName(30, "Joker.jpg");
            this.ImagesCarte.Images.SetKeyName(31, "LivreurPizza.jpg");
            this.ImagesCarte.Images.SetKeyName(32, "MarinMousse.jpg");
            this.ImagesCarte.Images.SetKeyName(33, "MarinOfficier.jpg");
            this.ImagesCarte.Images.SetKeyName(34, "MarinPompon.jpg");
            this.ImagesCarte.Images.SetKeyName(35, "Mecanicien.jpg");
            this.ImagesCarte.Images.SetKeyName(36, "Pilote.jpg");
            this.ImagesCarte.Images.SetKeyName(37, "Pompier.jpg");
            this.ImagesCarte.Images.SetKeyName(38, "Serveur.jpg");
            this.ImagesCarte.Images.SetKeyName(39, "Dialogue.jpg");
            this.ImagesCarte.Images.SetKeyName(40, "Diplome.jpg");
            // 
            // btn_Jouer
            // 
            this.btn_Jouer.Location = new System.Drawing.Point(1030, 495);
            this.btn_Jouer.Name = "btn_Jouer";
            this.btn_Jouer.Size = new System.Drawing.Size(75, 23);
            this.btn_Jouer.TabIndex = 5;
            this.btn_Jouer.Text = "Jouer";
            this.btn_Jouer.UseVisualStyleBackColor = true;
            this.btn_Jouer.Click += new System.EventHandler(this.btn_Jouer_Click);
            // 
            // lbscore
            // 
            this.lbscore.AutoSize = true;
            this.lbscore.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbscore.Location = new System.Drawing.Point(909, 431);
            this.lbscore.Name = "lbscore";
            this.lbscore.Size = new System.Drawing.Size(60, 22);
            this.lbscore.TabIndex = 7;
            this.lbscore.Text = "Score";
            // 
            // lbNbCoup
            // 
            this.lbNbCoup.AutoSize = true;
            this.lbNbCoup.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNbCoup.Location = new System.Drawing.Point(900, 309);
            this.lbNbCoup.Name = "lbNbCoup";
            this.lbNbCoup.Size = new System.Drawing.Size(171, 19);
            this.lbNbCoup.TabIndex = 8;
            this.lbNbCoup.Text = "Nombre de coups : ";
            // 
            // lbNbPaire
            // 
            this.lbNbPaire.AutoSize = true;
            this.lbNbPaire.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNbPaire.Location = new System.Drawing.Point(900, 356);
            this.lbNbPaire.Name = "lbNbPaire";
            this.lbNbPaire.Size = new System.Drawing.Size(252, 19);
            this.lbNbPaire.TabIndex = 9;
            this.lbNbPaire.Text = "Nombre de paires trouvées :";
            // 
            // lbtemps
            // 
            this.lbtemps.AutoSize = true;
            this.lbtemps.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtemps.Location = new System.Drawing.Point(1064, 431);
            this.lbtemps.Name = "lbtemps";
            this.lbtemps.Size = new System.Drawing.Size(80, 22);
            this.lbtemps.TabIndex = 10;
            this.lbtemps.Text = "Temps :";
            // 
            // tpsJeu
            // 
            this.tpsJeu.Tick += new System.EventHandler(this.tpsJeu_Tick);
            // 
            // lbtpsSec
            // 
            this.lbtpsSec.AutoSize = true;
            this.lbtpsSec.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtpsSec.Location = new System.Drawing.Point(1156, 431);
            this.lbtpsSec.Name = "lbtpsSec";
            this.lbtpsSec.Size = new System.Drawing.Size(60, 22);
            this.lbtpsSec.TabIndex = 11;
            this.lbtpsSec.Text = "0 sec";
            // 
            // CB_theme
            // 
            this.CB_theme.FormattingEnabled = true;
            this.CB_theme.Items.AddRange(new object[] {
            "Animaux",
            "Fleurs",
            "Personnages",
            "Vehicules"});
            this.CB_theme.Location = new System.Drawing.Point(987, 189);
            this.CB_theme.Name = "CB_theme";
            this.CB_theme.Size = new System.Drawing.Size(121, 21);
            this.CB_theme.TabIndex = 12;
            this.CB_theme.SelectedIndexChanged += new System.EventHandler(this.CB_theme_SelectedIndexChanged);
            // 
            // btn_Rejouer
            // 
            this.btn_Rejouer.Location = new System.Drawing.Point(914, 495);
            this.btn_Rejouer.Name = "btn_Rejouer";
            this.btn_Rejouer.Size = new System.Drawing.Size(75, 23);
            this.btn_Rejouer.TabIndex = 13;
            this.btn_Rejouer.Text = "Rejouer";
            this.btn_Rejouer.UseVisualStyleBackColor = true;
            this.btn_Rejouer.Click += new System.EventHandler(this.btn_Rejouer_Click);
            // 
            // Animaux
            // 
            this.Animaux.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Animaux.ImageStream")));
            this.Animaux.TransparentColor = System.Drawing.Color.Transparent;
            this.Animaux.Images.SetKeyName(0, "DosCarte.jpg");
            this.Animaux.Images.SetKeyName(1, "Ecureuil.jpg");
            this.Animaux.Images.SetKeyName(2, "Hanneton.jpg");
            this.Animaux.Images.SetKeyName(3, "Hibou.jpg");
            this.Animaux.Images.SetKeyName(4, "Hippocampe.jpg");
            this.Animaux.Images.SetKeyName(5, "Homard.jpg");
            this.Animaux.Images.SetKeyName(6, "Kangourou.jpg");
            this.Animaux.Images.SetKeyName(7, "Lapin.jpg");
            this.Animaux.Images.SetKeyName(8, "LapinChapeau.jpg");
            this.Animaux.Images.SetKeyName(9, "LapinRieur.jpg");
            this.Animaux.Images.SetKeyName(10, "Lion.jpg");
            this.Animaux.Images.SetKeyName(11, "MacareuxMoine.jpg");
            this.Animaux.Images.SetKeyName(12, "Mouette.jpg");
            this.Animaux.Images.SetKeyName(13, "Ocelot.jpg");
            this.Animaux.Images.SetKeyName(14, "OiseauCage.jpg");
            this.Animaux.Images.SetKeyName(15, "OiseauChante.jpg");
            this.Animaux.Images.SetKeyName(16, "OiseauPic.jpg");
            this.Animaux.Images.SetKeyName(17, "Orycterope.jpg");
            this.Animaux.Images.SetKeyName(18, "Papillon.jpg");
            this.Animaux.Images.SetKeyName(19, "PoissonBocal.jpg");
            this.Animaux.Images.SetKeyName(20, "PoissonBulle.jpg");
            this.Animaux.Images.SetKeyName(21, "PoissonPapillon.jpg");
            this.Animaux.Images.SetKeyName(22, "PorcEpic.jpg");
            this.Animaux.Images.SetKeyName(23, "PorcEpic2.jpg");
            this.Animaux.Images.SetKeyName(24, "Renne.jpg");
            this.Animaux.Images.SetKeyName(25, "Renne2.jpg");
            this.Animaux.Images.SetKeyName(26, "Serpent.jpg");
            this.Animaux.Images.SetKeyName(27, "Taureau.jpg");
            this.Animaux.Images.SetKeyName(28, "Vache.jpg");
            this.Animaux.Images.SetKeyName(29, "Abeille.jpg");
            this.Animaux.Images.SetKeyName(30, "Autruches.jpg");
            this.Animaux.Images.SetKeyName(31, "Canard.jpg");
            this.Animaux.Images.SetKeyName(32, "Chameau.jpg");
            this.Animaux.Images.SetKeyName(33, "Chien.jpg");
            this.Animaux.Images.SetKeyName(34, "ChienGamelle.jpg");
            this.Animaux.Images.SetKeyName(35, "ChienMechant.jpg");
            this.Animaux.Images.SetKeyName(36, "ChienSavant.jpg");
            this.Animaux.Images.SetKeyName(37, "Chimpanze.jpg");
            this.Animaux.Images.SetKeyName(38, "Coccinelle.jpg");
            this.Animaux.Images.SetKeyName(39, "Crabe.jpg");
            this.Animaux.Images.SetKeyName(40, "Crocodile.jpg");
            this.Animaux.Images.SetKeyName(41, "Dauphin.jpg");
            // 
            // Fleurs
            // 
            this.Fleurs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Fleurs.ImageStream")));
            this.Fleurs.TransparentColor = System.Drawing.Color.Transparent;
            this.Fleurs.Images.SetKeyName(0, "DosCarte.jpg");
            this.Fleurs.Images.SetKeyName(1, "Fleur_01.jpg");
            this.Fleurs.Images.SetKeyName(2, "Fleur_02.jpg");
            this.Fleurs.Images.SetKeyName(3, "Fleur_03.jpg");
            this.Fleurs.Images.SetKeyName(4, "Fleur_04.jpg");
            this.Fleurs.Images.SetKeyName(5, "Fleur_05.jpg");
            this.Fleurs.Images.SetKeyName(6, "Fleur_06.jpg");
            this.Fleurs.Images.SetKeyName(7, "Fleur_07.jpg");
            this.Fleurs.Images.SetKeyName(8, "Fleur_08.jpg");
            this.Fleurs.Images.SetKeyName(9, "Fleur_09.jpg");
            this.Fleurs.Images.SetKeyName(10, "Fleur_10.jpg");
            this.Fleurs.Images.SetKeyName(11, "Fleur_11.jpg");
            this.Fleurs.Images.SetKeyName(12, "Fleur_12.jpg");
            this.Fleurs.Images.SetKeyName(13, "Fleur_13.jpg");
            this.Fleurs.Images.SetKeyName(14, "Fleur_14.jpg");
            this.Fleurs.Images.SetKeyName(15, "Fleur_15.jpg");
            this.Fleurs.Images.SetKeyName(16, "Fleur_16.jpg");
            this.Fleurs.Images.SetKeyName(17, "Fleur_17.jpg");
            this.Fleurs.Images.SetKeyName(18, "Fleur_18.jpg");
            this.Fleurs.Images.SetKeyName(19, "Fleur_19.jpg");
            this.Fleurs.Images.SetKeyName(20, "Fleur_20.jpg");
            this.Fleurs.Images.SetKeyName(21, "Fleur_21.jpg");
            this.Fleurs.Images.SetKeyName(22, "Fleur_22.jpg");
            this.Fleurs.Images.SetKeyName(23, "Fleur_23.jpg");
            this.Fleurs.Images.SetKeyName(24, "Fleur_24.jpg");
            this.Fleurs.Images.SetKeyName(25, "Fleur_25.jpg");
            // 
            // Vehicules
            // 
            this.Vehicules.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Vehicules.ImageStream")));
            this.Vehicules.TransparentColor = System.Drawing.Color.Transparent;
            this.Vehicules.Images.SetKeyName(0, "DosCarte.jpg");
            this.Vehicules.Images.SetKeyName(1, "Scooter.jpg");
            this.Vehicules.Images.SetKeyName(2, "a_vehicule_01.jpg");
            this.Vehicules.Images.SetKeyName(3, "a_vehicule_02.jpg");
            this.Vehicules.Images.SetKeyName(4, "a_vehicule_03.jpg");
            this.Vehicules.Images.SetKeyName(5, "a_vehicule_04.jpg");
            this.Vehicules.Images.SetKeyName(6, "a_vehicule_05.jpg");
            this.Vehicules.Images.SetKeyName(7, "a_vehicule_06.jpg");
            this.Vehicules.Images.SetKeyName(8, "a_vehicule_07.jpg");
            this.Vehicules.Images.SetKeyName(9, "a_vehicule_08.jpg");
            this.Vehicules.Images.SetKeyName(10, "a_vehicule_09.jpg");
            this.Vehicules.Images.SetKeyName(11, "a_vehicule_10.jpg");
            this.Vehicules.Images.SetKeyName(12, "a_vehicule_11.jpg");
            this.Vehicules.Images.SetKeyName(13, "a_vehicule_12.jpg");
            this.Vehicules.Images.SetKeyName(14, "a_vehicule_13.jpg");
            this.Vehicules.Images.SetKeyName(15, "a_vehicule_14.jpg");
            this.Vehicules.Images.SetKeyName(16, "a_vehicule_15.jpg");
            this.Vehicules.Images.SetKeyName(17, "a_vehicule_16.jpg");
            this.Vehicules.Images.SetKeyName(18, "a_vehicule_17.jpg");
            this.Vehicules.Images.SetKeyName(19, "a_vehicule_18.jpg");
            this.Vehicules.Images.SetKeyName(20, "a_vehicule_19.jpg");
            this.Vehicules.Images.SetKeyName(21, "a_vehicule_20.jpg");
            this.Vehicules.Images.SetKeyName(22, "a_vehicule_21.jpg");
            this.Vehicules.Images.SetKeyName(23, "a_vehicule_22.jpg");
            this.Vehicules.Images.SetKeyName(24, "a_vehicule_23.jpg");
            this.Vehicules.Images.SetKeyName(25, "a_vehicule_24.jpg");
            this.Vehicules.Images.SetKeyName(26, "a_vehicule_25.jpg");
            this.Vehicules.Images.SetKeyName(27, "a_vehicule_26.jpg");
            this.Vehicules.Images.SetKeyName(28, "a_vehicule_27.jpg");
            this.Vehicules.Images.SetKeyName(29, "a_vehicule_28.jpg");
            this.Vehicules.Images.SetKeyName(30, "a_vehicule_29.jpg");
            this.Vehicules.Images.SetKeyName(31, "a_vehicule_30.jpg");
            this.Vehicules.Images.SetKeyName(32, "a_vehicule_31.jpg");
            this.Vehicules.Images.SetKeyName(33, "a_vehicule_32.jpg");
            this.Vehicules.Images.SetKeyName(34, "a_vehicule_33.jpg");
            this.Vehicules.Images.SetKeyName(35, "a_vehicule_34.jpg");
            this.Vehicules.Images.SetKeyName(36, "a_vehicule_35.jpg");
            this.Vehicules.Images.SetKeyName(37, "a_vehicule_36.jpg");
            this.Vehicules.Images.SetKeyName(38, "a_vehicule_37.jpg");
            this.Vehicules.Images.SetKeyName(39, "a_vehicule_38.jpg");
            this.Vehicules.Images.SetKeyName(40, "a_vehicule_39.jpg");
            this.Vehicules.Images.SetKeyName(41, "a_vehicule_40.jpg");
            this.Vehicules.Images.SetKeyName(42, "CamionMilitaire.jpg");
            this.Vehicules.Images.SetKeyName(43, "Depaneuse.jpg");
            // 
            // Personnages
            // 
            this.Personnages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Personnages.ImageStream")));
            this.Personnages.TransparentColor = System.Drawing.Color.Transparent;
            this.Personnages.Images.SetKeyName(0, "DosCarte.jpg");
            this.Personnages.Images.SetKeyName(1, "FemmeAffaire.jpg");
            this.Personnages.Images.SetKeyName(2, "FemmeBatiment.jpg");
            this.Personnages.Images.SetKeyName(3, "FemmeBlanche.jpg");
            this.Personnages.Images.SetKeyName(4, "FemmeBleue.jpg");
            this.Personnages.Images.SetKeyName(5, "FemmeCasque.jpg");
            this.Personnages.Images.SetKeyName(6, "FemmeCuisinier.jpg");
            this.Personnages.Images.SetKeyName(7, "FemmeInformaticienBrune.jpg");
            this.Personnages.Images.SetKeyName(8, "FemmeInformaticienChatain.jpg");
            this.Personnages.Images.SetKeyName(9, "FemmeJournal.jpg");
            this.Personnages.Images.SetKeyName(10, "FemmeMedecin.jpg");
            this.Personnages.Images.SetKeyName(11, "FemmeMegaphone.jpg");
            this.Personnages.Images.SetKeyName(12, "FemmeOrange.jpg");
            this.Personnages.Images.SetKeyName(13, "FemmePhotographe.jpg");
            this.Personnages.Images.SetKeyName(14, "FemmePoliciere.jpg");
            this.Personnages.Images.SetKeyName(15, "HommeAffaire.jpg");
            this.Personnages.Images.SetKeyName(16, "HommeBatiment.jpg");
            this.Personnages.Images.SetKeyName(17, "HommeBleu.jpg");
            this.Personnages.Images.SetKeyName(18, "HommeCasque.jpg");
            this.Personnages.Images.SetKeyName(19, "HommeCuisinier.jpg");
            this.Personnages.Images.SetKeyName(20, "HommeGarde.jpg");
            this.Personnages.Images.SetKeyName(21, "HommeInformaticienBrun.jpg");
            this.Personnages.Images.SetKeyName(22, "HommeInformaticienChatain.jpg");
            this.Personnages.Images.SetKeyName(23, "HommeJournal.jpg");
            this.Personnages.Images.SetKeyName(24, "HommeMarron.jpg");
            this.Personnages.Images.SetKeyName(25, "HommeMedecin.jpg");
            this.Personnages.Images.SetKeyName(26, "HommeMegaphone.jpg");
            this.Personnages.Images.SetKeyName(27, "HommeOrange.jpg");
            this.Personnages.Images.SetKeyName(28, "HommePhotographe.jpg");
            this.Personnages.Images.SetKeyName(29, "HommePolicier.jpg");
            this.Personnages.Images.SetKeyName(30, "Joker.jpg");
            this.Personnages.Images.SetKeyName(31, "LivreurPizza.jpg");
            this.Personnages.Images.SetKeyName(32, "MarinMousse.jpg");
            this.Personnages.Images.SetKeyName(33, "MarinOfficier.jpg");
            this.Personnages.Images.SetKeyName(34, "MarinPompon.jpg");
            this.Personnages.Images.SetKeyName(35, "Mecanicien.jpg");
            this.Personnages.Images.SetKeyName(36, "Pilote.jpg");
            this.Personnages.Images.SetKeyName(37, "Pompier.jpg");
            this.Personnages.Images.SetKeyName(38, "Serveur.jpg");
            this.Personnages.Images.SetKeyName(39, "Dialogue.jpg");
            this.Personnages.Images.SetKeyName(40, "Diplome.jpg");
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Location = new System.Drawing.Point(1143, 495);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(75, 23);
            this.btn_Quitter.TabIndex = 14;
            this.btn_Quitter.Text = "Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // lb_Message
            // 
            this.lb_Message.AutoSize = true;
            this.lb_Message.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Message.Location = new System.Drawing.Point(900, 121);
            this.lb_Message.Name = "lb_Message";
            this.lb_Message.Size = new System.Drawing.Size(100, 22);
            this.lb_Message.TabIndex = 15;
            this.lb_Message.Text = "Allez-y !";
            // 
            // CB_nbCarte
            // 
            this.CB_nbCarte.DisplayMember = "0";
            this.CB_nbCarte.FormattingEnabled = true;
            this.CB_nbCarte.Items.AddRange(new object[] {
            "8 cartes ",
            "16 cartes",
            "32 cartes"});
            this.CB_nbCarte.Location = new System.Drawing.Point(1097, 245);
            this.CB_nbCarte.Name = "CB_nbCarte";
            this.CB_nbCarte.Size = new System.Drawing.Size(121, 21);
            this.CB_nbCarte.TabIndex = 16;
            // 
            // lb_theme
            // 
            this.lb_theme.AutoSize = true;
            this.lb_theme.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_theme.Location = new System.Drawing.Point(900, 188);
            this.lb_theme.Name = "lb_theme";
            this.lb_theme.Size = new System.Drawing.Size(81, 19);
            this.lb_theme.TabIndex = 17;
            this.lb_theme.Text = "Thème : ";
            // 
            // lb_nbCarte
            // 
            this.lb_nbCarte.AutoSize = true;
            this.lb_nbCarte.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nbCarte.Location = new System.Drawing.Point(900, 247);
            this.lb_nbCarte.Name = "lb_nbCarte";
            this.lb_nbCarte.Size = new System.Drawing.Size(180, 19);
            this.lb_nbCarte.TabIndex = 18;
            this.lb_nbCarte.Text = "Nombre de cartes : ";
            // 
            // lb_Titre
            // 
            this.lb_Titre.AutoSize = true;
            this.lb_Titre.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titre.Location = new System.Drawing.Point(514, 38);
            this.lb_Titre.Name = "lb_Titre";
            this.lb_Titre.Size = new System.Drawing.Size(223, 34);
            this.lb_Titre.TabIndex = 19;
            this.lb_Titre.Text = "Le PolyMemory";
            // 
            // frmMemory
            // 
            this.ClientSize = new System.Drawing.Size(1273, 588);
            this.Controls.Add(this.lb_Titre);
            this.Controls.Add(this.lb_nbCarte);
            this.Controls.Add(this.lb_theme);
            this.Controls.Add(this.CB_nbCarte);
            this.Controls.Add(this.lb_Message);
            this.Controls.Add(this.btn_Quitter);
            this.Controls.Add(this.btn_Rejouer);
            this.Controls.Add(this.CB_theme);
            this.Controls.Add(this.lbtpsSec);
            this.Controls.Add(this.lbtemps);
            this.Controls.Add(this.lbNbPaire);
            this.Controls.Add(this.lbNbCoup);
            this.Controls.Add(this.lbscore);
            this.Controls.Add(this.btn_Jouer);
            this.Controls.Add(this.tlpTapisDeCartes);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmMemory";
            this.Text = "Memory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TableLayoutPanel tlpTapisDeCartes;
        private System.Windows.Forms.ImageList ImagesCarte;
        private System.Windows.Forms.Button btn_Jouer;
        private System.Windows.Forms.Label lbscore;
        private System.Windows.Forms.Label lbNbCoup;
        private System.Windows.Forms.Label lbNbPaire;
        private System.Windows.Forms.Label lbtemps;
        private System.Windows.Forms.Timer tpsJeu;
        private System.Windows.Forms.Label lbtpsSec;
        private System.Windows.Forms.ComboBox CB_theme;
        private System.Windows.Forms.Button btn_Rejouer;
        private System.Windows.Forms.ImageList Animaux;
        private System.Windows.Forms.ImageList Fleurs;
        private System.Windows.Forms.ImageList Vehicules;
        private System.Windows.Forms.ImageList Personnages;
        private System.Windows.Forms.Button btn_Quitter;
        private System.Windows.Forms.Label lb_Message;
        private System.Windows.Forms.ComboBox CB_nbCarte;
        private System.Windows.Forms.Label lb_theme;
        private System.Windows.Forms.Label lb_nbCarte;
        private System.Windows.Forms.Label lb_Titre;
    }
}
#endregion