using Bibliotheque.Controlleur;

namespace ToDoList
{
    public partial class FormPrincipal : Form
    {
        private ControlleurTache _controlleur = ControlleurTache.S_instance;
        private BindingSource _sourceDonnee = new BindingSource();

        public FormPrincipal()
        {
            InitializeComponent();
            this.Text = "T�ches";
            ConfigurationDonnee();
        }
        
        /// <summary>
        /// Configurer la source de donnee
        /// des t�ches
        /// </summary>
        public void ConfigurationDonnee()
        {
            dataGridViewTache.DataSource = _sourceDonnee;
        }

        /// <summary>
        /// M�thode de chargement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FormPrincipal_Load(object sender, EventArgs e)
        {
            // Charger les donn�es quand le formulaire se charge
            Chargement();
        }

        /// <summary>
        /// Chargement des taches
        /// </summary>
        public void Chargement()
        {
            try
            {
                _sourceDonnee.DataSource = _controlleur.Afficher();
                dataGridViewTache.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des t�ches : {ex.GetType()}","Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
