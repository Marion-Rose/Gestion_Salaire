using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Salaire.Classes
{
    /// <summary>
    /// Classe Poste
    /// </summary>
    public class Poste
    {
        private int idPoste;
        private string libelle;
        private int poids;

        /// <summary>
        /// Constructeur de la classe Poste
        /// </summary>
        /// <param name="idPoste">Identifiant</param>
        /// <param name="libelle">Libellé</param>
        /// <param name="poids">Poids</param>
        public Poste(int idPoste, string libelle, int poids)
        {
            this.idPoste = idPoste;
            this.libelle = libelle;
            this.poids = poids;
        }

        public int getIdPoste() { return this.idPoste; }
        public void setIdPoste(int idPoste) { this.idPoste = idPoste; }
        public string getLibelle() { return this.libelle; }
        public void setLibelle(string libelle) { this.libelle = libelle; }
        public int getPoids() { return this.poids; }
        public void setPoids(int poids) { this.poids = poids; }
        public override string ToString()
        {
            return "IdPoste: " + this.idPoste + " Libelle: " + this.libelle + " Poids: " + this.poids;
        }

    }
}
