using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Accueil : Form
    {

        int nbEquipe = 0;
        
        

        public Accueil()
        {
            InitializeComponent();
            BtnMoins.Enabled = false;
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            BtnMoins.Enabled = true;
            if (nbEquipe == 0)
            {
                TextBoxEquipe3.Visible = true;           
            }

            if (nbEquipe == 1)
            {
                TextBoxEquipe4.Visible = true;
            }

            if (nbEquipe == 2)
            {
                TextBoxEquipe5.Visible = true;
            }

            if (nbEquipe == 3)
            {
                TextBoxEquipe6.Visible = true;
            }

            if (nbEquipe == 4)
            {
                TextBoxEquipe7.Visible = true;
            }

            if (nbEquipe == 5)
            {
                TextBoxEquipe8.Visible = true;
                BtnPlus.Enabled = false;
            }

            nbEquipe = nbEquipe + 1;
        }

        private void BtnMoins_Click(object sender, EventArgs e)
        {

            if (nbEquipe == 0)
            {
                TextBoxEquipe3.Visible = false;
                BtnMoins.Enabled = false;
            }

            if (nbEquipe == 1)
            {
                TextBoxEquipe4.Visible = false;
            }

            if (nbEquipe == 2)
            {
                TextBoxEquipe5.Visible = false;
            }

            if (nbEquipe == 3)
            {
                TextBoxEquipe6.Visible = false;
            }

            if (nbEquipe == 4)
            {
                TextBoxEquipe7.Visible = false;
            }

            if (nbEquipe == 5)
            {
                TextBoxEquipe8.Visible = false;
            }

            nbEquipe = nbEquipe - 1;
        }

        private void button1_Click(object sender, EventArgs e)
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


        }

    }
}
