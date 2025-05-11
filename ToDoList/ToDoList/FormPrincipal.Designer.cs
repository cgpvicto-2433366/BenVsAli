namespace ToDoList
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            dataGridViewTache = new DataGridView();
            Titre = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            DateEcheance = new DataGridViewTextBoxColumn();
            Statut = new DataGridViewTextBoxColumn();
            Priorite = new DataGridViewTextBoxColumn();
            toolStripOutils = new ToolStrip();
            toolStripButtonAjouter = new ToolStripButton();
            toolStripButton1Supprimer = new ToolStripButton();
            toolStripButtonModifier = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTache).BeginInit();
            toolStripOutils.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewTache
            // 
            dataGridViewTache.AllowUserToAddRows = false;
            dataGridViewTache.AllowUserToDeleteRows = false;
            dataGridViewTache.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTache.Columns.AddRange(new DataGridViewColumn[] { Titre, Description, DateEcheance, Statut, Priorite });
            dataGridViewTache.Location = new Point(12, 12);
            dataGridViewTache.Name = "dataGridViewTache";
            dataGridViewTache.RowHeadersWidth = 51;
            dataGridViewTache.Size = new Size(693, 426);
            dataGridViewTache.TabIndex = 0;
            // 
            // Titre
            // 
            Titre.HeaderText = "Titre";
            Titre.MinimumWidth = 6;
            Titre.Name = "Titre";
            Titre.Width = 125;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 125;
            // 
            // DateEcheance
            // 
            DateEcheance.HeaderText = "Date";
            DateEcheance.MinimumWidth = 6;
            DateEcheance.Name = "DateEcheance";
            DateEcheance.Width = 125;
            // 
            // Statut
            // 
            Statut.HeaderText = "Statut";
            Statut.MinimumWidth = 6;
            Statut.Name = "Statut";
            Statut.Width = 125;
            // 
            // Priorite
            // 
            Priorite.HeaderText = "Priorite";
            Priorite.MinimumWidth = 6;
            Priorite.Name = "Priorite";
            Priorite.Width = 125;
            // 
            // toolStripOutils
            // 
            toolStripOutils.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toolStripOutils.Dock = DockStyle.None;
            toolStripOutils.ImageScalingSize = new Size(20, 20);
            toolStripOutils.Items.AddRange(new ToolStripItem[] { toolStripButtonAjouter, toolStripButton1Supprimer, toolStripButtonModifier });
            toolStripOutils.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStripOutils.Location = new Point(708, 12);
            toolStripOutils.Name = "toolStripOutils";
            toolStripOutils.Size = new Size(83, 93);
            toolStripOutils.TabIndex = 1;
            toolStripOutils.Text = "toolStrip1";
            // 
            // toolStripButtonAjouter
            // 
            toolStripButtonAjouter.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonAjouter.Image = (Image)resources.GetObject("toolStripButtonAjouter.Image");
            toolStripButtonAjouter.ImageTransparentColor = Color.Magenta;
            toolStripButtonAjouter.Name = "toolStripButtonAjouter";
            toolStripButtonAjouter.Size = new Size(81, 24);
            toolStripButtonAjouter.Text = "Ajouter";
            // 
            // toolStripButton1Supprimer
            // 
            toolStripButton1Supprimer.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1Supprimer.Image = (Image)resources.GetObject("toolStripButton1Supprimer.Image");
            toolStripButton1Supprimer.ImageTransparentColor = Color.Magenta;
            toolStripButton1Supprimer.Name = "toolStripButton1Supprimer";
            toolStripButton1Supprimer.Size = new Size(81, 24);
            toolStripButton1Supprimer.Text = "Supprimer";
            toolStripButton1Supprimer.ToolTipText = "toolStripButtonSupprimer";
            // 
            // toolStripButtonModifier
            // 
            toolStripButtonModifier.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonModifier.Image = (Image)resources.GetObject("toolStripButtonModifier.Image");
            toolStripButtonModifier.ImageTransparentColor = Color.Magenta;
            toolStripButtonModifier.Name = "toolStripButtonModifier";
            toolStripButtonModifier.Size = new Size(81, 24);
            toolStripButtonModifier.Text = "Modifier";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStripOutils);
            Controls.Add(dataGridViewTache);
            Name = "FormPrincipal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTache).EndInit();
            toolStripOutils.ResumeLayout(false);
            toolStripOutils.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewTache;
        private DataGridViewTextBoxColumn Titre;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn DateEcheance;
        private DataGridViewTextBoxColumn Statut;
        private DataGridViewTextBoxColumn Priorite;
        private ToolStrip toolStripOutils;
        private ToolStripButton toolStripButtonAjouter;
        private ToolStripButton toolStripButton1Supprimer;
        private ToolStripButton toolStripButtonModifier;
    }
}
