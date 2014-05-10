using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Graphisme
{
      static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
     
            //List<Liste.Mus> Blindtest = new List<Liste.Mus>();
            Liste.Create_List(Liste.Blindtest, Liste.All_File("..\\..\\..\\..\\Music"), Liste.All_File("..\\..\\..\\..\\Picture"));
            Liste.Display_List(Liste.Blindtest);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Accueil());
        }
    }
}
