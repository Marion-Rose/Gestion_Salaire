using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Salaire.Classes
{
    /// <summary>
    /// Classe Logger
    /// </summary>
    public static class Logger
    {
        private static readonly string cheminFichier = @"..\..\..\Logs\logs.txt";

        /// <summary>
        /// Méthode qui permet d'écrire dans le fichier de logs
        /// </summary>
        /// <param name="information">Information à écrire</param>
        public static void EcrireLog(string information)
        {
            
            using (StreamWriter writer = new StreamWriter(cheminFichier, true))
            {
                if (VariablesGlobales.adminConnecte != null)
                {
                    writer.WriteLine(DateTime.Now.ToString() + ": " + information + ", par l'administrateur " + VariablesGlobales.adminConnecte.getNomPrenom());
                }
                else
                {
                    writer.WriteLine(DateTime.Now.ToString() + ": " + information + ", par l'utilisateur " + VariablesGlobales.utilisateurConnecte.GetSalarie().getNomPrenom());
                }
                
            }
        }

        /// <summary>
        /// Méthode qui permet d'ouvrir le fichier de logs
        /// </summary>
        public static void OuvrirLogs()
        {
            if (File.Exists(cheminFichier))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "notepad.exe",
                    Arguments = cheminFichier
                };
                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show("Le fichier de logs na pas été trouvé.");
            }
        }
    }
}
