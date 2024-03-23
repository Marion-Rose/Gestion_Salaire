using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Salaire.Classes
{
    /// <summary>
    /// Classe Salarié
    /// </summary>
    public class Salarie
    {
        private int id;
        private string nom;
        private string prenom;
        public string nomPrenom;
        private int echelon;
        private Entreprise entreprise;
        private Poste poste;
        private int annee;

        /// <summary>
        /// Constructeur de la classe Salarie
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="echelon"></param>
        /// <param name="entreprise"></param>
        /// <param name="poste"></param>
        /// <param name="annee"></param>
        public Salarie(int id, string nom, string prenom, int echelon, Entreprise entreprise, Poste poste, int annee)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.echelon = echelon;
            this.entreprise = entreprise;
            this.poste = poste;
            this.annee = annee;
            this.nomPrenom = nom + " " + prenom;
        }
        public int getId() { return id; }
        public void setId(int id) { this.id = id; }
        public string getNom() { return this.nom; }
        public void setNom(string nom) { this.nom = nom; }
        public string getPrenom() { return this.prenom; }
        public void setPrenom(string prenom) { this.prenom = prenom; }
        public int getEchelon() { return this.echelon; }
        public void setEchelon(int echelon) { this.echelon = echelon; }
        public Entreprise getEntreprise() { return this.entreprise; }
        public void setEntreprise(Entreprise entreprise) { this.entreprise = entreprise; }
        public Poste getPoste() { return this.poste; }
        public void setPoste(Poste poste) { this.poste = poste; }
        public int getAnnee() { return this.annee; }
        public void setAnnee(int annee) { this.annee = annee; }
        public string getNomPrenom() { return this.nomPrenom; }
        public void setNomPrenom(string nomPrenom) { this.nomPrenom = nomPrenom; }
        public override string ToString()
        {
            return "Nom: " + this.nom + " Prenom: " + this.prenom + " Echelon: " + this.echelon + " Entreprise: " + this.entreprise + " Poste: " + this.poste + " Annee: " + this.annee;
        }

        /// <summary>
        /// Renvoie la grille associée au poste du salarié
        /// </summary>
        /// <param name="salarie">Salarie</param>
        /// <returns>Grille</returns>
        public Grille GrilleSelonSalarie(Salarie salarie)
        {

            foreach (Grille grille in VariablesGlobales.listeGrilles)
            {
                if (grille.getPoste() == salarie.getPoste())
                {
                    return grille;
                }
            }
            return null;
        }

        /// <summary>
        ///     Augmente l'année d'exercice du salarie
        /// </summary>
        public void AugmenterAnnee() {
            int[,] grille = GrilleSelonSalarie(this).getGrille();
            int anneeRequise = grille[this.echelon - 1, 1];

            //verifie si le salarie a le nombre d'année requise pour passer à l'échelon supérieur
            if (this.annee < anneeRequise)
            {
                this.annee++;
            }
            else
            {
                AugmenterEchelon();
            }
        }

        /// <summary>
        /// Augmente l'échelon du salarie
        /// </summary>
        public void AugmenterEchelon() { 
            Grille grille = GrilleSelonSalarie(this);
            int nouvelEchelon = this.echelon;
            //vérifie que l'échelon n'est pas déjà au maximum de la grille actuelle
            if(this.echelon < grille.getGrille().GetLength(0))
            {
                nouvelEchelon = this.echelon + 1;
                Logger.EcrireLog("Augmentation d'échelon : L'employé " + this.getNomPrenom() + " est passé de l'échelon " + this.echelon + " à l'échelon " + nouvelEchelon);
                this.echelon = nouvelEchelon;
            }
            else if (this.echelon >= grille.getGrille().GetLength(0)){ //Si l'échelon est au maximum de la grille actuelle, on augmente le poste
                AugmenterPoste();
            }
            this.annee = 0;
        }

        /// <summary>
        /// Augmente le poste du salarie
        /// </summary>
        public void AugmenterPoste()
        {
            Poste nouveauPoste = null;
            // Récupérer le poste supérieur
            foreach (Poste poste in VariablesGlobales.listePostes)
            {
                if (poste.getPoids() > this.poste.getPoids())
                {
                    nouveauPoste = poste;
                    break;
                }
            }

            //recupération de l'ancienne et de la nouvelle grille
            int[,] grilleActuelle = GrilleSelonSalarie(this).getGrille();
            Grille grilleNouvelle = VariablesGlobales.listeGrilles.Where(grille => grille.getPoste() == nouveauPoste).FirstOrDefault();

            //verifie que le nouveau poste à une grille associée
            if (grilleNouvelle != null)
            {
                int[,] nouvelleGrille = grilleNouvelle.getGrille();
                int salaireActuel = grilleActuelle[this.echelon - 1, 0];
                int nouvelEchelon = 0;

                //Récupère le nouvel échelon en fonction du salaire tout juste supérieur à celui actuel
                for (int i = 0; i < nouvelleGrille.GetLength(0); i++)
                {
                    int salaire = nouvelleGrille[i, 0];
                    if (salaire > salaireActuel)
                    {
                        nouvelEchelon = i + 1;
                        break;
                    }
                }

                Logger.EcrireLog("Augmentation de poste : L'employé " + this.getNomPrenom() + " est passé du poste de " + this.poste.getLibelle() + " à l'échelon " + this.echelon + " au poste de " + nouveauPoste.getLibelle() + " a l'échelon " + nouvelEchelon);

                this.poste = nouveauPoste;
                this.echelon = nouvelEchelon;
                this.annee = 0;

            }
        }

    }
}
