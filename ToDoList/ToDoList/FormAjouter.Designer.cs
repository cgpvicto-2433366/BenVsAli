namespace ToDoList
{
    partial class FormAjouter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitre = new Label();
            labelDescription = new Label();
            labelDateEcheance = new Label();
            labelPriorite = new Label();
            textBoxTitre = new TextBox();
            textBoxDescription = new TextBox();
            monthCalendarDateEcheacne = new MonthCalendar();
            comboBoxPriorite = new ComboBox();
            radioButtonStatutTerminer = new RadioButton();
            radioButtonStatutNonTerminer = new RadioButton();
            buttonForm2Ajouter = new Button();
            buttonForm2Annuler = new Button();
            groupBoxStatut = new GroupBox();
            groupBoxStatut.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Location = new Point(49, 51);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(39, 20);
            labelTitre.TabIndex = 0;
            labelTitre.Text = "Titre";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(49, 88);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(85, 20);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "Description";
            // 
            // labelDateEcheance
            // 
            labelDateEcheance.AutoSize = true;
            labelDateEcheance.Location = new Point(37, 179);
            labelDateEcheance.Name = "labelDateEcheance";
            labelDateEcheance.Size = new Size(119, 20);
            labelDateEcheance.TabIndex = 2;
            labelDateEcheance.Text = "Date d'échéance";
            labelDateEcheance.Click += labelDateEcheance_Click;
            // 
            // labelPriorite
            // 
            labelPriorite.AutoSize = true;
            labelPriorite.Location = new Point(529, 179);
            labelPriorite.Name = "labelPriorite";
            labelPriorite.Size = new Size(57, 20);
            labelPriorite.TabIndex = 4;
            labelPriorite.Text = "Priorite";
            // 
            // textBoxTitre
            // 
            textBoxTitre.Location = new Point(211, 44);
            textBoxTitre.Name = "textBoxTitre";
            textBoxTitre.Size = new Size(437, 27);
            textBoxTitre.TabIndex = 5;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(211, 88);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(437, 70);
            textBoxDescription.TabIndex = 6;
            // 
            // monthCalendarDateEcheacne
            // 
            monthCalendarDateEcheacne.Location = new Point(211, 170);
            monthCalendarDateEcheacne.Name = "monthCalendarDateEcheacne";
            monthCalendarDateEcheacne.TabIndex = 7;
            monthCalendarDateEcheacne.DateChanged += monthCalendarDateEcheacne_DateChanged;
            // 
            // comboBoxPriorite
            // 
            comboBoxPriorite.FormattingEnabled = true;
            comboBoxPriorite.Location = new Point(592, 179);
            comboBoxPriorite.Name = "comboBoxPriorite";
            comboBoxPriorite.Size = new Size(166, 28);
            comboBoxPriorite.TabIndex = 8;
            comboBoxPriorite.SelectedIndexChanged += comboBoxPriorite_SelectedIndexChanged;
            // 
            // radioButtonStatutTerminer
            // 
            radioButtonStatutTerminer.AutoSize = true;
            radioButtonStatutTerminer.Location = new Point(78, 72);
            radioButtonStatutTerminer.Name = "radioButtonStatutTerminer";
            radioButtonStatutTerminer.Size = new Size(88, 24);
            radioButtonStatutTerminer.TabIndex = 9;
            radioButtonStatutTerminer.TabStop = true;
            radioButtonStatutTerminer.Text = "Termnier";
            radioButtonStatutTerminer.UseVisualStyleBackColor = true;
            radioButtonStatutTerminer.CheckedChanged += radioButtonStatutTerminer_CheckedChanged;
            // 
            // radioButtonStatutNonTerminer
            // 
            radioButtonStatutNonTerminer.AutoSize = true;
            radioButtonStatutNonTerminer.Location = new Point(78, 26);
            radioButtonStatutNonTerminer.Name = "radioButtonStatutNonTerminer";
            radioButtonStatutNonTerminer.Size = new Size(120, 24);
            radioButtonStatutNonTerminer.TabIndex = 10;
            radioButtonStatutNonTerminer.TabStop = true;
            radioButtonStatutNonTerminer.Text = "Non-terminer";
            radioButtonStatutNonTerminer.UseVisualStyleBackColor = true;
            radioButtonStatutNonTerminer.CheckedChanged += radioButtonStatutNonTerminer_CheckedChanged;
            // 
            // buttonForm2Ajouter
            // 
            buttonForm2Ajouter.Location = new Point(67, 389);
            buttonForm2Ajouter.Name = "buttonForm2Ajouter";
            buttonForm2Ajouter.Size = new Size(170, 39);
            buttonForm2Ajouter.TabIndex = 11;
            buttonForm2Ajouter.Text = "Ajouter";
            buttonForm2Ajouter.UseVisualStyleBackColor = true;
            buttonForm2Ajouter.Click += buttonForm2Ajouter_Click;
            // 
            // buttonForm2Annuler
            // 
            buttonForm2Annuler.Location = new Point(366, 389);
            buttonForm2Annuler.Name = "buttonForm2Annuler";
            buttonForm2Annuler.Size = new Size(170, 39);
            buttonForm2Annuler.TabIndex = 12;
            buttonForm2Annuler.Text = "Annuler";
            buttonForm2Annuler.UseVisualStyleBackColor = true;
            // 
            // groupBoxStatut
            // 
            groupBoxStatut.Controls.Add(radioButtonStatutNonTerminer);
            groupBoxStatut.Controls.Add(radioButtonStatutTerminer);
            groupBoxStatut.Location = new Point(538, 240);
            groupBoxStatut.Name = "groupBoxStatut";
            groupBoxStatut.Size = new Size(250, 125);
            groupBoxStatut.TabIndex = 13;
            groupBoxStatut.TabStop = false;
            groupBoxStatut.Text = "Statut";
            // 
            // FormAjouter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxStatut);
            Controls.Add(buttonForm2Annuler);
            Controls.Add(buttonForm2Ajouter);
            Controls.Add(comboBoxPriorite);
            Controls.Add(monthCalendarDateEcheacne);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxTitre);
            Controls.Add(labelPriorite);
            Controls.Add(labelDateEcheance);
            Controls.Add(labelDescription);
            Controls.Add(labelTitre);
            Name = "FormAjouter";
            Text = "FormAjouter";
            groupBoxStatut.ResumeLayout(false);
            groupBoxStatut.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitre;
        private Label labelDescription;
        private Label labelDateEcheance;
        private Label labelPriorite;
        private TextBox textBoxTitre;
        private TextBox textBoxDescription;
        private MonthCalendar monthCalendarDateEcheacne;
        private ComboBox comboBoxPriorite;
        private RadioButton radioButtonStatutTerminer;
        private RadioButton radioButtonStatutNonTerminer;
        private Button buttonForm2Ajouter;
        private Button buttonForm2Annuler;
        private GroupBox groupBoxStatut;
    }
}