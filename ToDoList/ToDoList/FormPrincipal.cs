using Bibliotheque.Controlleur;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class FormPrincipal : Form
    {
        private ControlleurTache _controlleur = ControlleurTache.S_instance;
        private BindingSource _sourceDonnee = new BindingSource();

        public FormPrincipal()
        {
            InitializeComponent();
            this.Text = "Tâches";
        }
    }
}
