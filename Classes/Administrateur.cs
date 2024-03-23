using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Salaire.Classes
{
    /// <summary>
    /// Classe Administrateur
    /// </summary>
    public class Administrateur
    {
        private int id;
        private string nom;
        private string prenom;
        private string login;
        private string mdp;

        /// <summary>
        /// Constructeur de la classe Administrateur
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="nom">nom</param>
        /// <param name="prenom">prenom</param>
        /// <param name="login">login</param>
        /// <param name="mdp">Mot de passe</param>
        public Administrateur (int id, string nom, string prenom, string login, string mdp)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.mdp = mdp;
        }

        public int getId() { return this.id; }
        public void setId(int id) { this.id = id; }
        public string getNom() { return this.nom; }
        public void setNom(string nom) { this.nom = nom; }
        public string getPrenom() { return this.prenom; }
        public void setPrenom(string prenom) { this.prenom = prenom; }
        public string getNomPrenom() { return this.nom + " " + this.prenom; }
        public string getLogin() { return this.login; }
        public void setLogin(string login) { this.login = login; }
        public string getMdp() { return this.mdp; }
        public void setMdp(string mdp) { this.mdp = mdp; }
        public override string ToString()
        {
           return "Nom: " + this.nom + " Prenom: " + this.prenom + " Login: " + this.login + " Mdp: " + this.mdp;
        }
    }
}
