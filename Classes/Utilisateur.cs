using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Salaire.Classes
{
    /// <summary>
    /// Classe Utilisateur
    /// </summary>
    public class Utilisateur
    {
        private string login;
        private string motDePasse;
        private Salarie salarie;

        /// <summary>
        /// Constructeur de la classe Utilisateur
        /// </summary>
        /// <param name="salarie">Salarie</param>
        /// <param name="login">Login</param>
        /// <param name="motDePasse">Mot de Passe</param>
        public Utilisateur(Salarie salarie, string login, string motDePasse)
        {
            this.salarie = salarie;
            this.login = login;
            this.motDePasse = motDePasse;
        }

        public string GetLogin() { return this.login; }
        public void SetLogin(string login) { this.login = login; }
        public string GetMotDePasse() { return this.motDePasse; }
        public void SetMotDePasse(string motDePasse) { this.motDePasse = motDePasse; }
        public Salarie GetSalarie() { return this.salarie; }
        public void SetSalarie(Salarie salarie) { this.salarie = salarie; }
        public override string ToString()
        {
            return salarie.ToString() + " Login: " + this.login + " MotDePasse: " + this.motDePasse;
        }
    }
}
