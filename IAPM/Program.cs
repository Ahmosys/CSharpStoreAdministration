using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using IAPM.Technique;

namespace IAPM
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmConnexion());

            // Test des webservices //
            /* SalutationPortTypeClient clientSOAPSalutation = new SalutationPortTypeClient();
             InfoServeurPortTypeClient clientSOAPInfoServeur = new InfoServeurPortTypeClient();
             Console.WriteLine(clientSOAPSalutation.getBonjour("Hugo", "Robin"));
             Console.WriteLine(clientSOAPSalutation.getCoucou());
             Console.WriteLine(clientSOAPInfoServeur.getIpClient());
             Console.WriteLine(clientSOAPInfoServeur.getIpServeurDistant());
             Console.WriteLine(clientSOAPInfoServeur.getNomServeurDistant());*/

        }
    }
}
