using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bibliotheque.Modeles
{
    /// <summary>
    /// Structure de donnée d'une tâche
    /// </summary>
    public class Tache
    {
        #region Enum
        /// <summary>
        /// Enum sur les differentes valeurs de la priorité d'une tache
        /// </summary>
        private enum Priorite
        {
            Basse,
            Moyenne,
            Haute
        }
        #endregion

        #region Attriuts
        private string _titre;
        private string _description;
        private DateOnly _dateEcheance;
        private Priorite _priorite = Priorite.Basse;
        private bool _statut = false;
        #endregion

    }
}
