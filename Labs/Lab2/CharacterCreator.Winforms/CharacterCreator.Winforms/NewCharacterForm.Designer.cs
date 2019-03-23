namespace CharacterCreator.Winforms
{
    partial class NewCharacterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.OnNewCharaName = new System.Windows.Forms.Label();
            this.onNewCharaProfession = new System.Windows.Forms.Label();
            this.onNewCharaRace = new System.Windows.Forms.Label();
            this.OnNewCharaAttributes = new System.Windows.Forms.Label();
            this.OnNewCharaDescription = new System.Windows.Forms.Label();
            this.onNewCharaProfessionComboBox = new System.Windows.Forms.ComboBox();
            this.onNewCharaRaceComboBox = new System.Windows.Forms.ComboBox();
            this.onNewCharaNameTextBox = new System.Windows.Forms.TextBox();
            this.onNewCharaDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.onNewCharaStrength = new System.Windows.Forms.Label();
            this.onNewCharaIntelligence = new System.Windows.Forms.Label();
            this.onNewCharaAgility = new System.Windows.Forms.Label();
            this.onNewCharaConstitution = new System.Windows.Forms.Label();
            this.onNewCharaCharisma = new System.Windows.Forms.Label();
            this.onNewCharaStrengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.onNewCharaIntelligenceUpDown = new System.Windows.Forms.NumericUpDown();
            this.onNewCharaAgilityUpDown = new System.Windows.Forms.NumericUpDown();
            this.onNewCharaConstitutionUpDown = new System.Windows.Forms.NumericUpDown();
            this.onNewCharaCharismaUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.onNewCharaStrengthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onNewCharaIntelligenceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onNewCharaAgilityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onNewCharaConstitutionUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onNewCharaCharismaUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OnNewCharaName
            // 
            this.OnNewCharaName.AutoSize = true;
            this.OnNewCharaName.Location = new System.Drawing.Point(36, 31);
            this.OnNewCharaName.Name = "OnNewCharaName";
            this.OnNewCharaName.Size = new System.Drawing.Size(45, 17);
            this.OnNewCharaName.TabIndex = 0;
            this.OnNewCharaName.Text = "&Name";
            this.OnNewCharaName.Click += new System.EventHandler(this.OnNewCharaName_Click);
            // 
            // onNewCharaProfession
            // 
            this.onNewCharaProfession.AutoSize = true;
            this.onNewCharaProfession.Location = new System.Drawing.Point(36, 66);
            this.onNewCharaProfession.Name = "onNewCharaProfession";
            this.onNewCharaProfession.Size = new System.Drawing.Size(75, 17);
            this.onNewCharaProfession.TabIndex = 1;
            this.onNewCharaProfession.Text = "&Profession";
            // 
            // onNewCharaRace
            // 
            this.onNewCharaRace.AutoSize = true;
            this.onNewCharaRace.Location = new System.Drawing.Point(36, 103);
            this.onNewCharaRace.Name = "onNewCharaRace";
            this.onNewCharaRace.Size = new System.Drawing.Size(41, 17);
            this.onNewCharaRace.TabIndex = 2;
            this.onNewCharaRace.Text = "&Race";
            // 
            // OnNewCharaAttributes
            // 
            this.OnNewCharaAttributes.AutoSize = true;
            this.OnNewCharaAttributes.Location = new System.Drawing.Point(36, 137);
            this.OnNewCharaAttributes.Name = "OnNewCharaAttributes";
            this.OnNewCharaAttributes.Size = new System.Drawing.Size(68, 17);
            this.OnNewCharaAttributes.TabIndex = 3;
            this.OnNewCharaAttributes.Text = "&Attributes";
            // 
            // OnNewCharaDescription
            // 
            this.OnNewCharaDescription.AutoSize = true;
            this.OnNewCharaDescription.Location = new System.Drawing.Point(36, 316);
            this.OnNewCharaDescription.Name = "OnNewCharaDescription";
            this.OnNewCharaDescription.Size = new System.Drawing.Size(79, 17);
            this.OnNewCharaDescription.TabIndex = 9;
            this.OnNewCharaDescription.Text = "&Description";
            this.OnNewCharaDescription.Click += new System.EventHandler(this.OnNewCharaDescription_Click);
            // 
            // onNewCharaProfessionComboBox
            // 
            this.onNewCharaProfessionComboBox.FormattingEnabled = true;
            this.onNewCharaProfessionComboBox.Items.AddRange(new object[] {
            "Fighter",
            "Hunter",
            "Priest",
            "Rogue",
            "Wizard"});
            this.onNewCharaProfessionComboBox.Location = new System.Drawing.Point(198, 66);
            this.onNewCharaProfessionComboBox.Name = "onNewCharaProfessionComboBox";
            this.onNewCharaProfessionComboBox.Size = new System.Drawing.Size(121, 24);
            this.onNewCharaProfessionComboBox.TabIndex = 11;
            // 
            // onNewCharaRaceComboBox
            // 
            this.onNewCharaRaceComboBox.FormattingEnabled = true;
            this.onNewCharaRaceComboBox.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half Elf",
            "Human"});
            this.onNewCharaRaceComboBox.Location = new System.Drawing.Point(198, 103);
            this.onNewCharaRaceComboBox.Name = "onNewCharaRaceComboBox";
            this.onNewCharaRaceComboBox.Size = new System.Drawing.Size(121, 24);
            this.onNewCharaRaceComboBox.TabIndex = 12;
            // 
            // onNewCharaNameTextBox
            // 
            this.onNewCharaNameTextBox.Location = new System.Drawing.Point(198, 31);
            this.onNewCharaNameTextBox.Name = "onNewCharaNameTextBox";
            this.onNewCharaNameTextBox.Size = new System.Drawing.Size(121, 22);
            this.onNewCharaNameTextBox.TabIndex = 10;
            // 
            // onNewCharaDescriptionTextBox
            // 
            this.onNewCharaDescriptionTextBox.Location = new System.Drawing.Point(198, 316);
            this.onNewCharaDescriptionTextBox.Multiline = true;
            this.onNewCharaDescriptionTextBox.Name = "onNewCharaDescriptionTextBox";
            this.onNewCharaDescriptionTextBox.Size = new System.Drawing.Size(121, 99);
            this.onNewCharaDescriptionTextBox.TabIndex = 18;
            // 
            // onNewCharaStrength
            // 
            this.onNewCharaStrength.AutoSize = true;
            this.onNewCharaStrength.Location = new System.Drawing.Point(88, 169);
            this.onNewCharaStrength.Name = "onNewCharaStrength";
            this.onNewCharaStrength.Size = new System.Drawing.Size(62, 17);
            this.onNewCharaStrength.TabIndex = 4;
            this.onNewCharaStrength.Text = "S&trength";
            // 
            // onNewCharaIntelligence
            // 
            this.onNewCharaIntelligence.AutoSize = true;
            this.onNewCharaIntelligence.Location = new System.Drawing.Point(88, 197);
            this.onNewCharaIntelligence.Name = "onNewCharaIntelligence";
            this.onNewCharaIntelligence.Size = new System.Drawing.Size(79, 17);
            this.onNewCharaIntelligence.TabIndex = 5;
            this.onNewCharaIntelligence.Text = "I&ntelligence";
            // 
            // onNewCharaAgility
            // 
            this.onNewCharaAgility.AutoSize = true;
            this.onNewCharaAgility.Location = new System.Drawing.Point(88, 224);
            this.onNewCharaAgility.Name = "onNewCharaAgility";
            this.onNewCharaAgility.Size = new System.Drawing.Size(45, 17);
            this.onNewCharaAgility.TabIndex = 6;
            this.onNewCharaAgility.Text = "A&gility";
            // 
            // onNewCharaConstitution
            // 
            this.onNewCharaConstitution.AutoSize = true;
            this.onNewCharaConstitution.Location = new System.Drawing.Point(88, 253);
            this.onNewCharaConstitution.Name = "onNewCharaConstitution";
            this.onNewCharaConstitution.Size = new System.Drawing.Size(82, 17);
            this.onNewCharaConstitution.TabIndex = 7;
            this.onNewCharaConstitution.Text = "C&onstitution";
            // 
            // onNewCharaCharisma
            // 
            this.onNewCharaCharisma.AutoSize = true;
            this.onNewCharaCharisma.Location = new System.Drawing.Point(88, 280);
            this.onNewCharaCharisma.Name = "onNewCharaCharisma";
            this.onNewCharaCharisma.Size = new System.Drawing.Size(67, 17);
            this.onNewCharaCharisma.TabIndex = 8;
            this.onNewCharaCharisma.Text = "C&harisma";
            this.onNewCharaCharisma.Click += new System.EventHandler(this.label5_Click);
            // 
            // onNewCharaStrengthUpDown
            // 
            this.onNewCharaStrengthUpDown.Location = new System.Drawing.Point(244, 167);
            this.onNewCharaStrengthUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.onNewCharaStrengthUpDown.Name = "onNewCharaStrengthUpDown";
            this.onNewCharaStrengthUpDown.Size = new System.Drawing.Size(75, 22);
            this.onNewCharaStrengthUpDown.TabIndex = 13;
            this.onNewCharaStrengthUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // onNewCharaIntelligenceUpDown
            // 
            this.onNewCharaIntelligenceUpDown.Location = new System.Drawing.Point(244, 197);
            this.onNewCharaIntelligenceUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.onNewCharaIntelligenceUpDown.Name = "onNewCharaIntelligenceUpDown";
            this.onNewCharaIntelligenceUpDown.Size = new System.Drawing.Size(75, 22);
            this.onNewCharaIntelligenceUpDown.TabIndex = 14;
            this.onNewCharaIntelligenceUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // onNewCharaAgilityUpDown
            // 
            this.onNewCharaAgilityUpDown.Location = new System.Drawing.Point(244, 226);
            this.onNewCharaAgilityUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.onNewCharaAgilityUpDown.Name = "onNewCharaAgilityUpDown";
            this.onNewCharaAgilityUpDown.Size = new System.Drawing.Size(75, 22);
            this.onNewCharaAgilityUpDown.TabIndex = 15;
            this.onNewCharaAgilityUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // onNewCharaConstitutionUpDown
            // 
            this.onNewCharaConstitutionUpDown.Location = new System.Drawing.Point(244, 255);
            this.onNewCharaConstitutionUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.onNewCharaConstitutionUpDown.Name = "onNewCharaConstitutionUpDown";
            this.onNewCharaConstitutionUpDown.Size = new System.Drawing.Size(75, 22);
            this.onNewCharaConstitutionUpDown.TabIndex = 16;
            this.onNewCharaConstitutionUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // onNewCharaCharismaUpDown
            // 
            this.onNewCharaCharismaUpDown.Location = new System.Drawing.Point(244, 284);
            this.onNewCharaCharismaUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.onNewCharaCharismaUpDown.Name = "onNewCharaCharismaUpDown";
            this.onNewCharaCharismaUpDown.Size = new System.Drawing.Size(75, 22);
            this.onNewCharaCharismaUpDown.TabIndex = 17;
            this.onNewCharaCharismaUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // NewCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 518);
            this.Controls.Add(this.onNewCharaNameTextBox);
            this.Controls.Add(this.onNewCharaCharismaUpDown);
            this.Controls.Add(this.onNewCharaConstitutionUpDown);
            this.Controls.Add(this.onNewCharaAgilityUpDown);
            this.Controls.Add(this.onNewCharaIntelligenceUpDown);
            this.Controls.Add(this.onNewCharaStrengthUpDown);
            this.Controls.Add(this.onNewCharaCharisma);
            this.Controls.Add(this.onNewCharaConstitution);
            this.Controls.Add(this.onNewCharaAgility);
            this.Controls.Add(this.onNewCharaIntelligence);
            this.Controls.Add(this.onNewCharaStrength);
            this.Controls.Add(this.onNewCharaDescriptionTextBox);
            this.Controls.Add(this.onNewCharaRaceComboBox);
            this.Controls.Add(this.onNewCharaProfessionComboBox);
            this.Controls.Add(this.OnNewCharaDescription);
            this.Controls.Add(this.OnNewCharaAttributes);
            this.Controls.Add(this.onNewCharaRace);
            this.Controls.Add(this.onNewCharaProfession);
            this.Controls.Add(this.OnNewCharaName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCharacterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Character";
            ((System.ComponentModel.ISupportInitialize)(this.onNewCharaStrengthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onNewCharaIntelligenceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onNewCharaAgilityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onNewCharaConstitutionUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onNewCharaCharismaUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OnNewCharaName;
        private System.Windows.Forms.Label onNewCharaProfession;
        private System.Windows.Forms.Label onNewCharaRace;
        private System.Windows.Forms.Label OnNewCharaAttributes;
        private System.Windows.Forms.Label OnNewCharaDescription;
        private System.Windows.Forms.ComboBox onNewCharaProfessionComboBox;
        private System.Windows.Forms.ComboBox onNewCharaRaceComboBox;
        private System.Windows.Forms.TextBox onNewCharaNameTextBox;
        private System.Windows.Forms.TextBox onNewCharaDescriptionTextBox;
        private System.Windows.Forms.Label onNewCharaStrength;
        private System.Windows.Forms.Label onNewCharaIntelligence;
        private System.Windows.Forms.Label onNewCharaAgility;
        private System.Windows.Forms.Label onNewCharaConstitution;
        private System.Windows.Forms.Label onNewCharaCharisma;
        private System.Windows.Forms.NumericUpDown onNewCharaStrengthUpDown;
        private System.Windows.Forms.NumericUpDown onNewCharaIntelligenceUpDown;
        private System.Windows.Forms.NumericUpDown onNewCharaAgilityUpDown;
        private System.Windows.Forms.NumericUpDown onNewCharaConstitutionUpDown;
        private System.Windows.Forms.NumericUpDown onNewCharaCharismaUpDown;
    }
}