using Bibliotheque.Modeles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bibliotheque.Modeles.Tache;

namespace Bibliotheque.Data
{
    /// <summary>
    /// Source de donnée non permanente pour les taches
    /// </summary>
    public class TacheSource
    {
        #region Attributs
        private int _autoIncrement = 0;
        private Dictionary<int,Tache> _listeDeTache;
        #endregion

        #region Constructeur && Methodes
        /// <summary>
        /// Constructeur de la source
        /// </summary>
        public TacheSource()
        {
            _listeDeTache = new Dictionary<int, Tache>();
        }

        /// <summary>
        /// Ajouter une tache dans la source
        /// </summary>
        /// <param name="titre">valeeur obligatoire</param>
        /// <param name="dateEcheance">valeeur obligatoire</param>
        /// <param name="priorite1">Par défaut "Basse"</param>
        /// <param name="statut">par défaut "Non terminer"</param>
        /// <param name="description">Par défaut "vide"</param>
        public void Ajouter(string titre, DateOnly dateEcheance, Priorite priorite1 = Tache.Priorite.Basse, bool statut = false, string description="")
        {
            Tache temp = new Tache(titre, description, dateEcheance, priorite1, statut);
            _listeDeTache.Add(_autoIncrement, temp);
            _autoIncrement++;
        }

        /// <summary>
        /// Methode pour modifier 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="titre"></param>
        /// <param name="dateEcheance"></param>
        /// <param name="priorite1"></param>
        /// <param name="statut"></param>
        /// <param name="description"></param>
        /// <exception cref="InvalidOperationException">Si la tache n'existe pas</exception>
        public void Modifier(int index, string titre, DateOnly dateEcheance, Priorite priorite1= Tache.Priorite.Basse, bool statut = false, string description = "")
        {
            if (!_listeDeTache.ContainsKey(index))
                throw new InvalidOperationException("Vous ne pouvez pas modifier une tache inexistante");
            _listeDeTache[index].ModifierTitre(titre);
            _listeDeTache[index].ModifierDescription(description);
            _listeDeTache[index].ModifierStatut(statut);
            _listeDeTache[index].ModifierPriorite(priorite1);
            _listeDeTache[index].ModifierDateEcheance(dateEcheance);
        }

        /// <summary>
        /// SUpprimer une tache
        /// </summary>
        /// <param name="index">index de la tache</param>
        /// <exception cref="InvalidOperationException">Si la tache n'existe pas</exception>
        public void Supprimer(int index)
        {
            if (!_listeDeTache.ContainsKey(index))
                throw new InvalidOperationException("Vous ne pouvez pas supprimer une tache inexistante");
            _listeDeTache.Remove(index);
        }

        /// <summary>
        /// Supprimer toute les taches
        /// </summary>
        public void SupprimerTout()
        {
            _listeDeTache = new Dictionary<int, Tache>();
        }

        /// <summary>
        /// Cherhcer des taches par leur titre ou description
        /// </summary>
        /// <param name="value">titre ou description</param>
        /// <returns>liste de tache</returns>
        public Dictionary<int, Tache> chercher(string value)
        {
            Dictionary<int, Tache> resultat = new Dictionary<int, Tache>();
            for (int i=0; i<_listeDeTache.Count(); i++)
            {
                if (_listeDeTache[i].Titre == value)
                    resultat.Add(i, _listeDeTache[i]);
            }
            if (resultat.Count() == 0)
                return default;
            return resultat;
        }
        #endregion

    }
}
