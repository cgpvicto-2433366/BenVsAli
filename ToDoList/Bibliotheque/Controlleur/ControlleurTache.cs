using Bibliotheque.Data;
using Bibliotheque.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bibliotheque.Modeles.Tache;

namespace Bibliotheque.Controlleur
{
    /// <summary>
    /// Controlleur d'action sur les taches
    /// </summary>
    public class ControlleurTache
    {
        #region Attributs
        TacheSource _source = new TacheSource();
        #endregion

        #region Constructeur et méthodes
        /// <summary>
        /// Constructeur
        /// </summary>
        private ControlleurTache()
        {

        }

        /// <summary>
        /// Creer une tâche, l'index de la tche est ajouter de façon automatique
        /// </summary>
        /// <param name="titre">titre</param>
        /// <param name="dateEcheance">date</param>
        /// <param name="priorite1">Priorité, par défaut niveau Basse</param>
        /// <param name="statut">statut, par defaut false(non terminer)</param>
        /// <param name="description">description, par défaut vide</param>
        public void Creer(string titre, DateOnly dateEcheance, Priorite priorite1 = Tache.Priorite.Basse, bool statut = false, string description = "")
        {
            _source.Ajouter(titre, dateEcheance, priorite1, statut, description);
        }

        /// <summary>
        /// Methode pour modifier une tache
        /// </summary>
        /// <param name="index">identifiant de la tache</param>
        /// <param name="titre">nouveua titre</param>
        /// <param name="dateEcheance">nouvelle date </param>
        /// <param name="priorite1">nouvelle priorite, par défaut niveau Basse</param>
        /// <param name="statut">nouveau statut, par defaut false(non terminer)</param>
        /// <param name="description">nouvelle description, par défaut vide</param>
        /// <exception cref="InvalidOperationException">Si la tache n'existe pas</exception>
        public void Modifier(int index, string titre, DateOnly dateEcheance, Priorite priorite1 = Tache.Priorite.Basse, bool statut = false, string description = "")
        {
            _source.Modifier(index, titre, dateEcheance, priorite1, statut, description);
        }

        /// <summary>
        /// Supprimer une tache, les index sont reorganiser automatiquement
        /// </summary>
        /// <param name="index">index de la tache</param>
        /// <exception cref="InvalidOperationException">Si la tache n'existe pas</exception>
        public void Supprimer(int index)
        {
            _source.Supprimer(index);
        }

        /// <summary>
        /// Recuperer toutes les taches qui ont déjà 
        /// été creer
        /// </summary>
        /// <returns>Liste de tache</returns>
        public Dictionary<int, Tache> Afficher()
        {
           return _source.Afficher();
        }

        /// <summary>
        /// Supprimer toutes les taches
        /// </summary>
        public void SupprimerTout()
        {
            _source.SupprimerTout();
        }

        /// <summary>
        /// Cherhcer des taches par leur titre ou description
        /// </summary>
        /// <param name="value">titre ou description</param>
        /// <returns>liste de tache</returns>
        public Dictionary<int, Tache> Chercher(string value)
        {
            return _source.chercher(value);
        }
        #endregion

        #region Singleton
        //-------------Singleton-------------------------
        private static ControlleurTache s_instance;

        /// <summary>
        /// Accesseur sur l'instance du controlleur
        /// </summary>
        public static ControlleurTache S_instance 
        { 
            get 
            {
                if (s_instance is null)
                    return new ControlleurTache();
                return s_instance; 
            } 
        }
        #endregion
    }
}
