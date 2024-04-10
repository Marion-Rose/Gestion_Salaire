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

            Entreprise devEnFolie = new Entreprise(1, "Dev en Folie", "2 rue du C# 87000 LIMOGES");
            VariablesGlobales.listeEntreprises.Add(devEnFolie);

            Administrateur admin1 = new Administrateur(1, "Maitre", "Yoda", "admin", "admin");
            VariablesGlobales.listeAdministrateurs.Add(admin1); 

            Salarie aSky = new Salarie(1, "Skywalker", "Anakin", 5, devEnFolie, developpeurChef, 0);
            Salarie lOrg = new Salarie(2, "Organa", "Leia", 3, devEnFolie, developpeur,0);
            Salarie pAmi = new Salarie(3, "Amidala", "Padmé", 2, devEnFolie, developpeur, 0);
            Salarie oKen = new Salarie(4, "Kenobi", "Obi-Wan", 1, devEnFolie, developpeur, 0);
            VariablesGlobales.listeSalaries.Add(aSky);
            VariablesGlobales.listeSalaries.Add(lOrg);
            VariablesGlobales.listeSalaries.Add(pAmi);
            VariablesGlobales.listeSalaries.Add(oKen);

            Utilisateur aSkyU = new Utilisateur(aSky, "user", "user");
            VariablesGlobales.listeUtilisateurs.Add(aSkyU);
        }
    }
}