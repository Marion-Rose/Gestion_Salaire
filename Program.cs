using Gestion_Salaire.Classes;
using Gestion_Salaire.Forms;
using Microsoft.VisualBasic;

namespace Gestion_Salaire
{
    public class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Initialisation();
            Application.Run(new Connexion());
            
        }

        /// <summary>
        /// Initialisation des données de l'application
        /// </summary>
        public static void Initialisation()
        {
            Poste developpeur = new Poste(1, "Developpeur",1);
            Poste developpeurChef = new Poste(2, "Developpeur en chef",2);
            Poste test = new Poste(3, "Testeur",4);
            Poste chefProjet = new Poste(4, "Chef de projet",3);
            VariablesGlobales.listePostes.Add(developpeur);
            VariablesGlobales.listePostes.Add(developpeurChef);

            Grille grilleDeveloppeur = new Grille(developpeur, new int[,] { { 1500, 1 }, { 1650, 1 }, { 1900, 2 }, { 2100, 3 }, { 2300, 0 } });
            Grille grilleDéveloppeurChef = new Grille(developpeurChef, new int[,] { { 2000, 1 }, { 2300, 1 }, { 2600, 1 }, { 2950, 2 }, { 3200, 0 } });
            VariablesGlobales.listeGrilles.Add(grilleDeveloppeur);
            VariablesGlobales.listeGrilles.Add(grilleDéveloppeurChef);

            Entreprise okantis = new Entreprise(1, "Okantis", "2 rue Jean Monnet 87170 ISLE");
            VariablesGlobales.listeEntreprises.Add(okantis);

            Administrateur admin1 = new Administrateur(1, "Dum", "Laurent", "admin", "admin");
            VariablesGlobales.listeAdministrateurs.Add(admin1); 

            Salarie vMaza = new Salarie(1, "Maza", "Valentin", 5, okantis, developpeurChef, 0);
            Salarie qRod = new Salarie(2, "Rod", "Quentin", 3, okantis, developpeur,0);
            Salarie eAl = new Salarie(3, "Al", "Emeline", 2, okantis, developpeur, 0);
            Salarie aMard = new Salarie(4, "Mard", "Antoine", 1, okantis, developpeur, 0);
            VariablesGlobales.listeSalaries.Add(vMaza);
            VariablesGlobales.listeSalaries.Add(qRod);
            VariablesGlobales.listeSalaries.Add(eAl);
            VariablesGlobales.listeSalaries.Add(aMard);

            Utilisateur vMazaU = new Utilisateur(vMaza, "m", "m");
            VariablesGlobales.listeUtilisateurs.Add(vMazaU);
        }
    }
}