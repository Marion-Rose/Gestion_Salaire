using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Salaire.Classes
{
    /// <summary>
    /// Classe Entreprise
    /// </summary>
    public class Entreprise
    {
        private int idEntreprise;
        private string raisonSociale;
        private string adresse;

        /// <summary>
        /// Constructeur de la classe Entreprise
        /// </summary>
        /// <param name="idEntreprise">Identifiant de l'entreprise</param>
        /// <param name="raisonSociale">Raison Sociale</param>
        /// <param name="adresse">Adresse</param>
        public Entreprise(int idEntreprise, string raisonSociale, string adresse) 
        { 
            this.idEntreprise = idEntreprise;
            this.raisonSociale = raisonSociale;
            this.adresse = adresse;
        }

        public int getIdEntreprise() { return this.idEntreprise; }
        public void setIdEntreprise(int idEntreprise) { this.idEntreprise = idEntreprise; }
        public string getRaisonSociale() { return this.raisonSociale; }
        public void setRaisonSociale(string raisonSociale) { this.raisonSociale = raisonSociale; }
        public string getAdresse() { return this.adresse; }
        public void setAdresse(string adresse) { this.adresse = adresse; }
        public override string ToString()
        {
            return "IdEntreprise : " + this.idEntreprise + ", RaisonSociale : " + this.raisonSociale + ", Adresse : " + this.adresse;
        }
    }
}
