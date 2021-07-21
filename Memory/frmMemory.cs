using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllLoto;

namespace Memory
{
    public partial class frmMemory : Form
    {
        // Déclaration des variables globales du jeu
        int nbCartesDansSabot; // Nombre de cartes dans le sabot (en fait nombre
                               // d'images dans le réservoir)
        int nbCartesSurTapis; // Nombre de cartes sur le tapis

        int[] TabNumCarteCache; //contient les numéros (dans le sabot) des cartes distribuées au début du jeu 
        int[] TabNumCarteVisible;//contient les numéros (dans le sabot) des cartes actuellement visibles 
        int[] TabEtat;//donne l'état des cartes sur le tapis : 0 = carte non trouvée et -1 = carte trouvée et 1 = la carte est retourné et attend sa paire
        int numRecherche; //contient le numéro de l'image rechercher
        int score;
        int nbPaireTrouv;
        int nbCoupsJoues;

        double tempsSeconde;

        bool Fin = false;

   

        //tableau de picture box : 
        PictureBox[] Tab_PB = new PictureBox[0];


        public frmMemory()
        {
            InitializeComponent();
            CB_theme.SelectedIndex = 0;
            CB_nbCarte.SelectedIndex = 0;
            tpsJeu.Tick += new EventHandler(tpsJeu_Tick);
            tpsJeu.Interval = 1000;

        }

        private void tpsJeu_Tick(object sender, EventArgs e)
        {
            //on vérifie que la partie n'est pas terminer :
            if (!Fin)
            {
                tempsSeconde -= 0.5;
                lbtpsSec.Text = string.Concat(tempsSeconde, " secondes");
                //si le temps est écoulé 
                if (tempsSeconde == 0)
                {
                    Fin = true;
                    MessageBox.Show("temps imparti dépassé !");
                }
            }


        }



        private void Distribution_Aleatoire()
        {
            // On récupère le nombre d'images dans le réservoir :
            nbCartesDansSabot = ImagesCarte.Images.Count - 1;
            // On enlève 1 car :
            // -> la l'image 0 ne compte pas c’est l’image du dos de carte
            // -> les indices vont de 0 à N-1, donc les indices vont jusqu’à 39
            // s’il y a 40 images au total *
            // On récupère également le nombre de cartes à distribuées sur la tapis
            // autrement dit le nombre de contrôles présents sur le conteneur

            //prise en compte du nb de carte selectionner par l'utilisateur : 
            switch (CB_nbCarte.SelectedIndex)// l'utilisateur à choisit 8 cartes :
            {
                case 0:
                    nbCartesSurTapis = 8;

                    //on vide le tapis de carte
                    this.tlpTapisDeCartes.Controls.Clear();
                    //on refait le tableau de picture box :
                    this.Tab_PB = new PictureBox[nbCartesSurTapis];

                    for (int j = 0; j < 2; j++)
                    {


                        for (int i = 0; i < 4; i++)
                        {

                            this.Tab_PB[i + j * 4] = new PictureBox();
                            this.Tab_PB[i + j * 4].Size = new System.Drawing.Size(100, 100);
                            this.Tab_PB[i + j * 4].Click += new EventHandler(this.pb_xx_Click);
                            this.tlpTapisDeCartes.Controls.Add(this.Tab_PB[i + j * 4], i, j);
                            this.Tab_PB[i + j * 4].Location = new System.Drawing.Point(3, 3);
                            this.Tab_PB[i + j * 4].Name = string.Concat("pb_", (i + j * 4 + 1));
                        }
                    }

                    //redisposition des autres éléments : 
                    this.ClientSize = new System.Drawing.Size(1273 - 400, 588);

                    this.lbscore.Location = new System.Drawing.Point(909 - 400, 431);
                    this.lbNbCoup.Location = new System.Drawing.Point(910 - 400, 310);
                    this.lbNbPaire.Location = new System.Drawing.Point(913 - 400, 358);
                    this.lbtemps.Location = new System.Drawing.Point(1064 - 400, 431);
                    this.lbtpsSec.Location = new System.Drawing.Point(1156 - 400, 431);
                    this.lb_theme.Location = new System.Drawing.Point(900 - 400, 188);
                    this.CB_theme.Location = new System.Drawing.Point(987 - 400, 189);
                    this.btn_Rejouer.Location = new System.Drawing.Point(914 - 400, 495);
                    this.btn_Quitter.Location = new System.Drawing.Point(1143 - 400, 495);
                    this.lb_Message.Location = new System.Drawing.Point(909 - 400, 121);
                    this.lb_nbCarte.Location = new System.Drawing.Point(900 - 400, 247);
                    this.CB_nbCarte.Location = new System.Drawing.Point(1097 - 400, 245);
                    this.lb_Titre.Location = new System.Drawing.Point(514-400, 38);

                    //Adaptation du temps impartie : 60 sec :
                    this.tempsSeconde = 60;

                    break;

                case 1:
                    nbCartesSurTapis = 16;
                    //redef du tapis de carte :

                    //on vide le tapis de carte
                    this.tlpTapisDeCartes.Controls.Clear();
                    //on refait le tableau de picture box :
                    this.Tab_PB = new PictureBox[nbCartesSurTapis];

                    for (int j = 0; j < 4; j++)
                    {

                        for (int i = 0; i < 4; i++)
                        {

                            this.Tab_PB[i + j * 4] = new PictureBox();
                            this.Tab_PB[i + j * 4].Size = new System.Drawing.Size(100, 100);
                            this.Tab_PB[i + j * 4].Click += new EventHandler(this.pb_xx_Click);
                            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
                            this.tlpTapisDeCartes.Controls.Add(this.Tab_PB[i + j * 4], i, j);
                            this.Tab_PB[i + j * 4].Location = new System.Drawing.Point(3, 3);
                            this.Tab_PB[i + j * 4].Name = string.Concat("pb_", (i + j * 4 + 1));
                        }
                    }
                    this.tlpTapisDeCartes.Size = new System.Drawing.Size(850, 425);

                    //redisposition des autres éléments : 
                    this.ClientSize = new System.Drawing.Size(1273-400, 588);

                    this.lbscore.Location = new System.Drawing.Point(909 - 400, 431);
                    this.lbNbCoup.Location = new System.Drawing.Point(910 - 400, 310);
                    this.lbNbPaire.Location = new System.Drawing.Point(913 - 400, 358);
                    this.lbtemps.Location = new System.Drawing.Point(1064 - 400, 431);
                    this.lbtpsSec.Location = new System.Drawing.Point(1156 - 400, 431);
                    this.lb_theme.Location = new System.Drawing.Point(900-400, 188);
                    this.CB_theme.Location = new System.Drawing.Point(987-400, 189);
                    this.btn_Rejouer.Location = new System.Drawing.Point(914 - 400, 495);
                    this.btn_Quitter.Location = new System.Drawing.Point(1143 - 400, 495);
                    this.lb_Message.Location = new System.Drawing.Point(909 - 400, 121);
                    this.lb_nbCarte.Location = new System.Drawing.Point(900-400, 247);
                    this.CB_nbCarte.Location = new System.Drawing.Point(1097-400, 245);
                    this.lb_Titre.Location = new System.Drawing.Point(514 - 400, 38);

                    //Adaptation du temps impartie : 90 sec :
                    this.tempsSeconde = 90;

                    break;



                case 2:
                    nbCartesSurTapis = 32;
                    this.tlpTapisDeCartes.Controls.Clear();

                    this.Tab_PB = new PictureBox[nbCartesSurTapis];

                    for (int j = 0; j < 4; j++)
                    {



                        for (int i = 0; i < 8; i++)
                        {

                            this.Tab_PB[i + j * 8] = new PictureBox();
                            this.Tab_PB[i + j * 8].Size = new System.Drawing.Size(100, 100);
                            this.Tab_PB[i + j * 8].Click += new EventHandler(this.pb_xx_Click);
                            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
                            this.tlpTapisDeCartes.Controls.Add(this.Tab_PB[i + j * 8], i, j);
                            this.Tab_PB[i + j * 8].Location = new System.Drawing.Point(3, 3);
                            this.Tab_PB[i + j * 8].Name = string.Concat("pb_", (i + j * 8 + 1));
                        }
                    }
                    this.tlpTapisDeCartes.Size = new System.Drawing.Size(850, 425);

                    //redisposition des autres éléments : 
                    this.ClientSize = new System.Drawing.Size(1280, 588);

                    this.lbscore.Location = new System.Drawing.Point(909, 431);
                    this.lbNbCoup.Location = new System.Drawing.Point(910, 310);
                    this.lbNbPaire.Location = new System.Drawing.Point(913, 358);
                    this.lbtemps.Location = new System.Drawing.Point(1064, 431);
                    this.lbtpsSec.Location = new System.Drawing.Point(1154, 431);
                    this.lb_theme.Location = new System.Drawing.Point(900, 188);
                    this.CB_theme.Location = new System.Drawing.Point(987, 189);
                    this.btn_Rejouer.Location = new System.Drawing.Point(914, 495);
                    this.btn_Quitter.Location = new System.Drawing.Point(1143, 495);
                    this.lb_Message.Location = new System.Drawing.Point(909, 121);
                    this.lb_nbCarte.Location = new System.Drawing.Point(900, 247);
                    this.CB_nbCarte.Location = new System.Drawing.Point(1097, 245);
                    this.lb_Titre.Location = new System.Drawing.Point(514, 38);


                    
                    
                    


                    //Adaptation du temps impartie : 120 sec :
                    this.tempsSeconde = 120;

                    break;

            }


            // On utilise la LotoMachine pour générer une série aléatoire
            LotoMachine hasard = new LotoMachine(nbCartesDansSabot);
            // On veut une série de nbCartesSurTapis cartes parmi celles
            // du réservoir
            int[] tImagesCartes = hasard.TirageAleatoire(nbCartesSurTapis / 2, false);
            //on sauvegarde les numéros de cartes (avant de les perdres): 
            TabNumCarteCache = new int[nbCartesSurTapis + 1];
            TabNumCarteVisible = new int[nbCartesSurTapis + 1];
            TabEtat = new int[nbCartesSurTapis + 1];

            // La série d'entiers retournée par la LotoMachine correspondra
            // aux indices des cartes dans le "sabot"
            // Affectation des images aux picturebox
            
            int i_image;
            int i_carte = 0;

            //on distribue aléatorement les cartes tiré sur le tapis, en mettant leur numéro dans les tableau :

            while (i_carte < nbCartesSurTapis)
            {
                
                i_image = hasard.NumeroAleatoire(); // tirage numéro de carte (i_carte + 1 à cause des pbs d'indices)

                //vérifie qu'il n'y a pas déjà 2 fois le numéro d'image tiré dans le tableau :
                if (TabNumCarteCache.Count(x => x == i_image) != 2)
                {
                    
                    TabNumCarteCache[i_carte + 1] = i_image;
                    TabNumCarteVisible[i_carte + 1] = i_image;
                    TabEtat[i_carte] = 1; //indique que le jeu n'a pas encore commencé 
                    i_carte++;
                }
            }
        }


        //définition de la calsse générale qui gère tout les click : 
        /// <summary>
        /// fonction qui gère les event de type click sur toute les picture box affiché sur le tapis 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_xx_Click(object sender, EventArgs e)
        {
            //on récupère la Picture box sur laquelle on a cliquée :
            PictureBox PBAppellant = (PictureBox)sender;

            // et l'indice correspondant :
            int numPb = 0;
            while (numPb < nbCartesSurTapis && PBAppellant != Tab_PB[numPb])
            {
                numPb++;
            }

            //vérfie si le temps imparti n'est pas dépassé :
            if (Fin)
            {
                MessageBox.Show("La partie est terminée ! \n Vous allez recommencé une partie...");
                btn_Jouer_Click(sender, e);
            }
            else
            {
                PictureBox carte;
                int i_image;
                int nb_cartes = 0;
                


                //compatge du nombre de carte déjà retourner :

                for (int i = 0; i < tlpTapisDeCartes.Controls.Count; i++)
                {
                    
                    int num = TabNumCarteVisible[i + 1];
                    if (TabNumCarteVisible[i + 1] != 0 && TabEtat[i + 1] != -1)   //si la carte est retournée 
                    {
                        nb_cartes++;
                    }
                }

                if (nb_cartes < 2)
                {
                    if (TabEtat[numPb + 1] == -1)//si la carte séléctionné est déjà trouvée :
                    {
                        MessageBox.Show("Cette carte à déjà était trouvée !");
                        Retourner();
                        nb_cartes = 0;
                       
                    }
                    else
                    {
                        carte = (PictureBox)sender;
                        i_image = TabNumCarteCache[numPb + 1];

                        carte.Image = ImagesCarte.Images[i_image];

                        //mise à jour carte visibles :
                        TabNumCarteVisible[numPb + 1] = i_image;


                        if (nb_cartes == 0)
                        {
                           
                            numRecherche = i_image;
                            TabEtat[numPb + 1] = 1;
                        }
                        if (nb_cartes == 1)
                        {
                            

                            // modifier pour que le num recherche correspondà l'indice de l'image 1 dans le sabot
                            if (TabNumCarteCache[numPb + 1] == numRecherche && TabEtat[numPb + 1] != 1)
                            {
                                
                                lb_Message.Text = "Bravo !";
                                TabEtat[numPb + 1] = -1;
                                //Puis recherche la carte paire : 
                                for (int i = 0; i < nbCartesSurTapis; i++)
                                {
                                    if (TabEtat[i + 1] == 1)
                                    {
                                        TabEtat[i + 1] = -1;
                                    }
                                }

                                //score :
                                nbPaireTrouv++;
                                nbCoupsJoues++;
                                score += 10;
                                lbNbPaire.Text = string.Concat("Nombre de paires trouvées :", nbPaireTrouv.ToString());
                                lbNbCoup.Text = string.Concat("Nombre de coups : ", nbCoupsJoues.ToString());
                                lbscore.Text = string.Concat("Score : ", score.ToString());

                                //on regarde si le joueur n'a pas déjà trouvé toute les paires :
                                if (nbPaireTrouv == nbCartesSurTapis / 2)
                                {
                                    Fin = true;
                                    MessageBox.Show("Bravo vous avez trouvez toute les paires !");
                                }


                            }
                            else if (TabEtat[numPb + 1] == 1) // la carte est la même que celle qui est déjà retournée
                            {
                                lb_Message.Text = "il faut retrouver \nle double de celle-ci !";
                            }
                            else // si ce n'est pas la bonne carte : 
                            {
                                


                                //temporisation pour afficher le dommage et les 2 cartes retournée : 


                                lb_Message.Text = "Dommage !";
                                lb_Message.Refresh();
                                lbscore.Refresh();
                                lbNbCoup.Refresh();
                                lbNbCoup.Refresh();

                                for (int i = 0; i < nbCartesSurTapis; i++)
                                {
                                    Tab_PB[i].Refresh();
                                }

                                System.Threading.Thread.Sleep(1000);

                                







                                //Puis recherche la carte retourné qui n'est pas une paire : 
                                for (int i = 0; i < nbCartesSurTapis; i++)
                                {
                                    if (TabEtat[i + 1] == 1)
                                    {
                                        TabEtat[i + 1] = 0;
                                    }
                                }
                                //et la carte retournée : 
                                TabEtat[numPb + 1] = 0;


                                //score : -2 pts
                                nbCoupsJoues++;
                                score -= 2;
                                lbNbCoup.Text = string.Concat("Nombre de coups : ", nbCoupsJoues.ToString());
                                lbscore.Text = string.Concat("Score : ", score.ToString());




                                //enfin on retourne les cartes non gagnées : 
                                Retourner();
                                nb_cartes = 0;
                                
                            }
                        }
                        nb_cartes++;
                    }
                }
                else
                {
                    MessageBox.Show("Deux cartes sont déjà retournées !");
                    Retourner();
                    nb_cartes = 0;
                    
                }

            }

        }



        
        private void Retourner()
        {

            PictureBox carte;
            for (int i_carte = 0; i_carte < nbCartesSurTapis; i_carte++)
            {
                //on vérifie que la carte à retourner n'est pas une carte gagnée : 
                if (TabEtat[i_carte + 1] != -1)
                {
                    carte = (PictureBox)tlpTapisDeCartes.Controls[i_carte];
                    carte.Image = ImagesCarte.Images[0];
                    TabNumCarteVisible[i_carte + 1] = 0; //les cartes sont retourné 
                    TabEtat[i_carte + 1] = 0;//initialise cartes à 0: retournée
                }
            }

        }

        private void btn_Retourner_Click(object sender, EventArgs e)
        {
            // On récupère le nombre d'images dans le réservoir :
            nbCartesDansSabot = ImagesCarte.Images.Count - 1;

            // On enlève 1 car :
            // -> la l'image 0 ne compte pas c’est l’image du dos de carte
            // -> les indices vont de 0 à N-1, donc les indices vont jusqu’à 39
            // s’il y a 40 images au total *
            // On récupère également le nombre de cartes à distribuées sur la tapis
            // autrement dit le nombre de contrôles présents sur le conteneur
            nbCartesSurTapis = tlpTapisDeCartes.Controls.Count;
            // On effectue la distribution (aléatoire) proprement dite
            Retourner();
        }

        private void btn_Jouer_Click(object sender, EventArgs e)
        {
            CB_theme_SelectedIndexChanged(sender, e);

            Distribution_Aleatoire();
            Retourner();
            score = 0;
            nbPaireTrouv = 0;
            nbCoupsJoues = 0;
            lbNbPaire.Text = string.Concat("Nombre de paires trouvées :", nbPaireTrouv.ToString());
            lbNbCoup.Text = string.Concat("Nombre de coups : ", nbCoupsJoues.ToString());
            lbscore.Text = string.Concat("Score : ", score.ToString());
            btn_Jouer.Visible = false;
            btn_Rejouer.Visible = true;
            btn_Quitter.Visible = true;

            tpsJeu.Stop();

            Fin = false;
            tpsJeu.Start();

        }
        

        private void CB_theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i;
            i = CB_theme.SelectedIndex;
            switch (i)
            {
                case 0:
                    ImagesCarte = Animaux;
                    break;
                case 1:
                    ImagesCarte = Fleurs;
                    break;
                case 2:
                    ImagesCarte = Personnages;
                    break;
                case 3:
                    ImagesCarte = Vehicules;
                    break;
            }
        }



        private void btn_Rejouer_Click(object sender, EventArgs e)
        {
            btn_Jouer_Click(sender, e);
        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
