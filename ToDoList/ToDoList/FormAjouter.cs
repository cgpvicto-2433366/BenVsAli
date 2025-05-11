using Bibliotheque.Controlleur;
using Bibliotheque.Modeles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class FormAjouter : Form
    {
        private ControlleurTache _controlleur = ControlleurTache.S_instance;
        private BindingSource _sourceDonnee = new BindingSource();
        private Tache.Priorite _tempPriorite = Tache.Priorite.Basse;
        private DateOnly _echeance;
        private bool _statut;

        public FormAjouter()
        {
            InitializeComponent();
        }
    }
}
