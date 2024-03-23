using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Salaire.Classes
{
    /// <summary>
    /// Classe Grille
    /// </summary>
    public class Grille
    {
        private Poste poste;
        private int[,] grille = new int[2,5];

        /// <summary>
        /// Constructeur de la classe Grille
        /// </summary>
        /// <param name="poste">Poste</param>
        /// <param name="grille">Grille sous forme de tableau</param>
        public Grille(Poste poste, int[,] grille)
        {
            this.poste = poste;
            this.grille = grille;
        }

        public Poste getPoste() { return this.poste; }
        public void setPoste(Poste poste) { this.poste = poste; }
        public int[,] getGrille() { return this.grille; }
        public void setGrille(int[,] grille) { this.grille = grille; }
        public override string ToString()
        {
            return "Poste: " + this.poste + " Grille: " + this.grille;
        }

        /// <summary>
        /// Méthode qui permet de récupérer le salaire d'un échelon
        /// </summary>
        /// <param name="echelon">Echelon</param>
        /// <returns>Salaire(int)</returns>
        public int getSalaire(int echelon)
        {
            return this.grille[echelon-1, 0];
        }

    }
}
