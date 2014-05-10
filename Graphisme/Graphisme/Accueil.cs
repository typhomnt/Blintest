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
    public partial class Accueil : Form
    {

        int nbEquipe = 2;


        public Accueil()
        {
            InitializeComponent();
            BtnMoins.Enabled = false;

            //List<Liste.Mus> Blindtest = new List<Liste.Mus>();
            Liste.Create_List(Liste.Blindtest, Liste.All_File("..\\..\\..\\..\\Music"), Liste.All_File("..\\..\\..\\..\\Picture"));
            Liste.Display_List(Liste.Blindtest);
        }

        public void BtnPlus_Click(object sender, EventArgs e)
        {
            BtnMoins.Enabled = true;
            if (nbEquipe == 2)
            {
                TextBoxEquipe3.Visible = true;
                label3.Visible = true;
            }

            if (nbEquipe == 3)
            {
                TextBoxEquipe4.Visible = true;
                label4.Visible = true;
            }

            if (nbEquipe == 4)
            {
                TextBoxEquipe5.Visible = true;
                label5.Visible = true;
            }

            if (nbEquipe == 5)
            {
                TextBoxEquipe6.Visible = true;
                label6.Visible = true;
            }

            if (nbEquipe == 6)
            {
                TextBoxEquipe7.Visible = true;
                label7.Visible = true;
            }

            if (nbEquipe == 7)
            {
                TextBoxEquipe8.Visible = true;
                label8.Visible = true;
                BtnPlus.Enabled = false;
            }

            nbEquipe = nbEquipe + 1;
        }

        public void BtnMoins_Click(object sender, EventArgs e)
        {

            if (nbEquipe == 2)
            {
                TextBoxEquipe3.Visible = false;
                label3.Visible = false;
                BtnMoins.Enabled = false;
            }

            if (nbEquipe == 3)
            {
                TextBoxEquipe4.Visible = false;
                label4.Visible = false;
            }

            if (nbEquipe == 4)
            {
                TextBoxEquipe5.Visible = false;
                label5.Visible = false;
            }

            if (nbEquipe == 5)
            {
                TextBoxEquipe6.Visible = false;
                label6.Visible = false;
            }

            if (nbEquipe == 6)
            {
                TextBoxEquipe7.Visible = false;
                label7.Visible = false;
            }

            if (nbEquipe == 7)
            {
                TextBoxEquipe8.Visible = false;
                label8.Visible = false;
                BtnPlus.Enabled = true;
            }

            nbEquipe = nbEquipe - 1;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string Equipe1 = "";
            string Equipe2 = "";
            string Equipe3 = "";
            string Equipe4 = "";
            string Equipe5 = "";
            string Equipe6 = "";
            string Equipe7 = "";
            string Equipe8 = "";

            Equipe1 = TextBoxEquipe1.Text;
            Equipe2 = TextBoxEquipe2.Text;
            Equipe3 = TextBoxEquipe3.Text;
            Equipe4 = TextBoxEquipe4.Text;
            Equipe5 = TextBoxEquipe5.Text;
            Equipe6 = TextBoxEquipe6.Text;
            Equipe7 = TextBoxEquipe7.Text;
            Equipe8 = TextBoxEquipe8.Text;

            Jeu jeu = new Jeu(nbEquipe, Equipe1, Equipe2, Equipe3, Equipe4, Equipe5, Equipe6, Equipe7, Equipe8);
            jeu.Show();
            this.Hide();

        }

    }
}
