using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bibliotheque.Modeles
{
    /// <summary>
    /// Structure de donnée d'une tâche
    /// </summary>
    public class Tache: IComparable
    {
        #region Enum
        /// <summary>
        /// Enum sur les differentes valeurs de la priorité d'une tache
        /// </summary>
        public enum Priorite
        {
            Basse,
            Moyenne,
            Haute
        }
        #endregion

        #region Attriuts
        private string _titre;
        private string _description;
        private DateOnly _dateEcheance= DateOnly.FromDateTime(DateTime.Now); //valeur par défaut, la date du jour
        private Priorite _priorite = Priorite.Basse;
        private bool _statut = false;
        #endregion

        #region Constructeurs & Méthodes
        /// <summary>
        /// COnstructeur d'une tache
        /// </summary>
        /// <param name="titre"></param>
        /// <param name="description"></param>
        /// <param name="dateEcheance"></param>
        /// <param name="priorite1"></param>
        /// <param name="statut"></param>
        public Tache(string titre, string description, DateOnly dateEcheance, Priorite priorite1, bool statut)
        {
            Titre = titre;
            Description = description;
            DateEcheance = dateEcheance;
            Priorite1 = priorite1;
            Statut = statut;
        }

        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Tache()
        {

        }

        /// <summary>
        /// Modifier la priorité d'une tache
        /// </summary>
        /// <param name="priorite"></param>
        public void ModifierPriorite(Priorite priorite)
        {
            this.Priorite1 = priorite;     
        }

        /// <summary>
        /// Modifier le titre de la tache
        /// </summary>
        /// <param name="titre">nouvreua titre</param>
        public void ModifierTitre(string titre)
        {
            Titre = titre;
        }

        /// <summary>
        /// Comparer les taches (égalité)
        /// </summary>
        /// <param name="other">Une tache</param>
        /// <returns>True si il s'agit des mêmes taches</returns>
        public bool Equals(Tache other)
        {
            if (other is null)
                return false;
            if (this.Titre == other.Titre &&
                this.Description == other.Description &&
                this.DateEcheance == other.DateEcheance)
                return true;
            return false;
        }

        /// <summary>
        /// Modifier la description de la tache
        /// </summary>
        /// <param name="titre">nouvreua titre</param>
        public void ModifierDescription(string description)
        {
            Description= description;
        }

        /// <summary>
        /// Modifier la date d'échéance de la tache
        /// </summary>
        /// <param name="titre">nouvreua titre</param>
        public void ModifierDateEcheance(DateOnly date)
        {
            DateEcheance = date;
        }

        /// <summary>
        /// Modifier le statut de la tache
        /// </summary>
        /// <param name="value"></param>
        public void ModifierStatut(bool value)
        {
            Statut = value;
        }

        /// <summary>
        /// Comparaison de deux tache en fontion de la date d'echéance
        /// </summary>
        /// <param name="obj">Un objet</param>
        /// <returns></returns>
        public int CompareTo(object? obj)
        {
            if (obj is null)
                return 1;
            if(obj is Tache)
            {
                Tache temp = new Tache();
                temp = (Tache)obj;
                if (this.DateEcheance < temp.DateEcheance)
                    return -1;
                if (this.DateEcheance > temp.DateEcheance)
                    return 1;
                if (this.DateEcheance == temp.DateEcheance)
                    return 0;
            }
            return 1;
                
        }
        #endregion

        #region Accesseurs
        /// <summary>
        /// Accesseur sur le titre de la tache, valeur non null, ni vide 
        /// </summary>
        public string Titre 
        { 
            get => _titre; 
            private set 
            {
                if(string.IsNullOrEmpty(value))
                    _titre = value; 
            }
        }

        /// <summary>
        /// Accesseur sur la description, valeur facultative
        /// </summary>
        public string Description 
        { 
            get => _description; 
            private set  
            {
                if(string.IsNullOrEmpty(value))
                    _description = "";
                _description = value;
            } 
        }

        /// <summary>
        /// Accesseur sur la date d'echeance de la tache 
        /// </summary>
        public DateOnly DateEcheance 
        { 
            get => _dateEcheance; 
            private set 
            {
                if (value < DateOnly.FromDateTime(DateTime.Now))
                    throw new ArgumentOutOfRangeException("la date d'échéance ne peut pas être dans le passé");
                _dateEcheance = value; 
            } 
        }

        /// <summary>
        /// Accesseur sur la priorité
        /// </summary>
        private Priorite Priorite1 { get => _priorite; set => _priorite = value; }

        /// <summary>
        /// Accesseur sur le statut de la tache
        /// </summary>
        public bool Statut { get => _statut; set => _statut = value; }
        #endregion
    }
}
