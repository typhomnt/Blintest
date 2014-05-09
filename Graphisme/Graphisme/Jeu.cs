using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graphisme
{
    public partial class Jeu : Form
    {

        //Classe Music
        Music m = new Music();

        //Accueil
        Accueil a = new Accueil();

        //Accueil.nbEquipe / non EquipeX;
        int nbEquipe;
        string Equipe1, Equipe2, Equipe3, Equipe4, Equipe5, Equipe6, Equipe7, Equipe8;

        //Points de chaques équipes
        int nb1, nb2, nb3, nb4, nb5, nb6, nb7, nb8;

        public Jeu(int i_nbEquipe, string w_Equipe1, string w_Equipe2, string w_Equipe3, string w_Equipe4, string w_Equipe5, string w_Equipe6, string w_Equipe7, string w_Equipe8)
        {
            InitializeComponent();

            nbEquipe = i_nbEquipe;
            Equipe1 = w_Equipe1; 
            Equipe2 = w_Equipe2;
            Equipe3 = w_Equipe3;
            Equipe4 = w_Equipe4;
            Equipe5 = w_Equipe5;
            Equipe6 = w_Equipe6;
            Equipe7 = w_Equipe7;
            Equipe8 = w_Equipe8;

            //Affichage selon nbEquipe selection à l'accueil + leur nom
            if (nbEquipe >= 1)
            {
                namegp1.Visible = true;
                namegp1.Text = Equipe1;
                ptsgp1.Visible = true;
                m1.Visible = true;
                p1.Visible = true;
            }
            if (nbEquipe >= 2)
            {
                namegp2.Visible = true;
                namegp2.Text = Equipe2;
                ptsgp2.Visible = true;
                m2.Visible = true;
                p2.Visible = true;
            }
            if (nbEquipe >= 3)
            {
                namegp3.Visible = true;
                namegp3.Text = Equipe3;
                ptsgp3.Visible = true;
                m3.Visible = true;
                p3.Visible = true;
            }
            if (nbEquipe >= 4)
            {
                namegp4.Visible = true;
                namegp4.Text = Equipe4;
                ptsgp4.Visible = true;
                m4.Visible = true;
                p4.Visible = true;
            }
            if (nbEquipe >= 5)
            {
                namegp5.Visible = true;
                namegp5.Text = Equipe5;
                ptsgp5.Visible = true;
                m5.Visible = true;
                p5.Visible = true;
            }
            if (nbEquipe >= 6)
            {
                namegp6.Visible = true;
                namegp6.Text = Equipe6;
                ptsgp6.Visible = true;
                m6.Visible = true;
                p6.Visible = true;
            }
            if (nbEquipe >= 7)
            {
                namegp7.Visible = true;
                namegp7.Text = Equipe7;
                ptsgp7.Visible = true;
                m6.Visible = true;
                p6.Visible = true;
            }
            if (nbEquipe >= 8)
            {
                namegp8.Visible = true;
                namegp8.Text = Equipe8;
                ptsgp8.Visible = true;
                m6.Visible = true;
                p6.Visible = true;
            }


        }

        private void p1_Click(object sender, EventArgs e)
        {
            nb1 = int.Parse(ptsgp1.Text) + 1;
            ptsgp1.Text = nb1.ToString();
        }

        private void p2_Click(object sender, EventArgs e)
        {
            nb2 = int.Parse(ptsgp2.Text) + 1;
            ptsgp2.Text = nb2.ToString();
        }

        private void p3_Click(object sender, EventArgs e)
        {
            nb3 = int.Parse(ptsgp3.Text) + 1;
            ptsgp3.Text = nb3.ToString();
        }

        private void p4_Click(object sender, EventArgs e)
        {
            nb4 = int.Parse(ptsgp4.Text) + 1;
            ptsgp4.Text = nb4.ToString();
        }

        private void p5_Click(object sender, EventArgs e)
        {
            nb5 = int.Parse(ptsgp1.Text) + 1;
            ptsgp5.Text = nb5.ToString();
        }

        private void p6_Click(object sender, EventArgs e)
        {
            nb6 = int.Parse(ptsgp6.Text) + 1;
            ptsgp6.Text = nb6.ToString();
        }

        private void p7_Click(object sender, EventArgs e)
        {
            nb7 = int.Parse(ptsgp7.Text) + 1;
            ptsgp7.Text = nb7.ToString();
        }

        private void p8_Click(object sender, EventArgs e)
        {
            nb8 = int.Parse(ptsgp8.Text) + 1;
            ptsgp8.Text = nb8.ToString();
        }

        private void m1_Click(object sender, EventArgs e)
        {
            nb1 = int.Parse(ptsgp1.Text) - 1;
            if (nb1 <= 0)
            {
                nb1 = 0;
                ptsgp1.Text = nb1.ToString() ;
            }
            ptsgp1.Text = nb1.ToString();
        }

        private void m2_Click(object sender, EventArgs e)
        {
            nb2 = int.Parse(ptsgp2.Text) - 1;
            if (nb2 <= 0)
            {
                nb2 = 0;
                ptsgp2.Text = nb2.ToString();
            }
            ptsgp2.Text = nb2.ToString();
        }

        private void m3_Click(object sender, EventArgs e)
        {
            nb3 = int.Parse(ptsgp3.Text) - 1;
            if (nb3 <= 0)
            {
                nb3 = 0;
                ptsgp3.Text = nb3.ToString();
            }
            ptsgp3.Text = nb3.ToString();
        }

        private void m4_Click(object sender, EventArgs e)
        {
            nb4 = int.Parse(ptsgp4.Text) - 1;
            if (nb4 <= 0)
            {
                nb4 = 0;
                ptsgp4.Text = nb4.ToString();
            }
            ptsgp4.Text = nb4.ToString();
        }

        private void m5_Click(object sender, EventArgs e)
        {
            nb5 = int.Parse(ptsgp5.Text) - 1;
            if (nb5 <= 0)
            {
                nb5 = 0;
                ptsgp5.Text = nb5.ToString();
            }
            ptsgp5.Text = nb5.ToString();
        }

        private void m6_Click(object sender, EventArgs e)
        {
            nb6 = int.Parse(ptsgp6.Text) - 1;
            if (nb6 <= 0)
            {
                nb6 = 0;
                ptsgp6.Text = nb6.ToString();
            }
            ptsgp6.Text = nb6.ToString();
        }

        private void m7_Click(object sender, EventArgs e)
        {
            nb7 = int.Parse(ptsgp7.Text) - 1;
            if (nb7 <= 0)
            {
                nb7 = 0;
                ptsgp7.Text = nb7.ToString();
            }
            ptsgp7.Text = nb7.ToString();
        }

        private void m8_Click(object sender, EventArgs e)
        {
            nb8 = int.Parse(ptsgp8.Text) - 1;
            if (nb8 <= 0)
            {
                nb8 = 0;
                ptsgp8.Text = nb8.ToString();
            }
            ptsgp8.Text = nb8.ToString();
        }


        // Player Music
        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m.open(openFileDialog1.FileName);
                MusicName.Text = openFileDialog1.FileName;
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            m.play();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            m.pause();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            m.stop();
            MusicName.Text = "";
        }


        // Retour Accueil
        private void RetourAccueil_Click(object sender, EventArgs e)
        {
            a.Show();
            this.Close();
        }

       

    }
}
