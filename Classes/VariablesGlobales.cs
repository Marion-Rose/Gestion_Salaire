using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Salaire.Classes
{
    /// <summary>
    /// Classe VariablesGlobales
    /// </summary>
    public static class VariablesGlobales
    {
        public static List<Poste> listePostes = new List<Poste>();
        public static List<Entreprise> listeEntreprises = new List<Entreprise>();
        public static List<Utilisateur> listeUtilisateurs = new List<Utilisateur>();
        public static List<Salarie> listeSalaries = new List<Salarie>();
        public static List<Administrateur> listeAdministrateurs = new List<Administrateur>();
        public static List<Grille> listeGrilles = new List<Grille>();

        public static Utilisateur utilisateurConnecte;
        public static Administrateur adminConnecte;
        public static int anneeActuelle = 2024;
    }
}
