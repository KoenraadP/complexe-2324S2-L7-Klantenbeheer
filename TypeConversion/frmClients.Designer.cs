
namespace TypeConversion
{
    partial class frmClients
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
            this.lblClientId = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblBirthPlace = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cbxBirthPlace = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.genderBox = new System.Windows.Forms.GroupBox();
            this.rdbUnknown = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.genderBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(29, 13);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(68, 13);
            this.lblClientId.TabIndex = 0;
            this.lblClientId.Text = "Klantnummer";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(29, 45);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Voornaam";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(29, 77);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(65, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Familienaam";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(29, 109);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(80, 13);
            this.lblBirthDate.TabIndex = 3;
            this.lblBirthDate.Text = "Geboortedatum";
            // 
            // lblBirthPlace
            // 
            this.lblBirthPlace.AutoSize = true;
            this.lblBirthPlace.Location = new System.Drawing.Point(29, 141);
            this.lblBirthPlace.Name = "lblBirthPlace";
            this.lblBirthPlace.Size = new System.Drawing.Size(79, 13);
            this.lblBirthPlace.TabIndex = 4;
            this.lblBirthPlace.Text = "Geboorteplaats";
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(134, 10);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(200, 20);
            this.txtClientId.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(134, 42);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 20);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(134, 74);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(134, 106);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthDate.TabIndex = 8;
            // 
            // cbxBirthPlace
            // 
            this.cbxBirthPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBirthPlace.FormattingEnabled = true;
            this.cbxBirthPlace.Items.AddRange(new object[] {
            "Brugge",
            "Harelbeke",
            "Hulste",
            "Izegem",
            "Kortrijk",
            "Kuurne",
            "Lendelede",
            "Lichtervelde",
            "Roeselare",
            "Torhout"});
            this.cbxBirthPlace.Location = new System.Drawing.Point(134, 138);
            this.cbxBirthPlace.Name = "cbxBirthPlace";
            this.cbxBirthPlace.Size = new System.Drawing.Size(200, 21);
            this.cbxBirthPlace.Sorted = true;
            this.cbxBirthPlace.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(567, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(291, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Klant toevoegen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(567, 57);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(291, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Klant bijwerken";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(567, 94);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(291, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Klant verwijderen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientId,
            this.FirstName,
            this.LastName,
            this.Age,
            this.BirthPlace,
            this.Gender,
            this.birthDate});
            this.grid.Location = new System.Drawing.Point(32, 182);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(826, 256);
            this.grid.TabIndex = 14;
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlBack.Location = new System.Drawing.Point(-7, 165);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(901, 285);
            this.pnlBack.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(567, 131);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(291, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Bewaren";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // genderBox
            // 
            this.genderBox.Controls.Add(this.rdbUnknown);
            this.genderBox.Controls.Add(this.rdbFemale);
            this.genderBox.Controls.Add(this.rdbMale);
            this.genderBox.Location = new System.Drawing.Point(351, 13);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(200, 146);
            this.genderBox.TabIndex = 10;
            this.genderBox.TabStop = false;
            this.genderBox.Text = "Geslacht";
            // 
            // rdbUnknown
            // 
            this.rdbUnknown.AutoSize = true;
            this.rdbUnknown.Location = new System.Drawing.Point(16, 89);
            this.rdbUnknown.Name = "rdbUnknown";
            this.rdbUnknown.Size = new System.Drawing.Size(137, 17);
            this.rdbUnknown.TabIndex = 2;
            this.rdbUnknown.TabStop = true;
            this.rdbUnknown.Text = "Wil ik liever niet zeggen";
            this.rdbUnknown.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(16, 59);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(55, 17);
            this.rdbFemale.TabIndex = 1;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Vrouw";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(16, 29);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(46, 17);
            this.rdbMale.TabIndex = 0;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Man";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // ClientId
            // 
            this.ClientId.HeaderText = "ClientId";
            this.ClientId.Name = "ClientId";
            this.ClientId.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Voornaam";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Familienaam";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.HeaderText = "Leeftijd";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // BirthPlace
            // 
            this.BirthPlace.HeaderText = "Geboorteplaats";
            this.BirthPlace.Name = "BirthPlace";
            this.BirthPlace.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Geslacht";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // birthDate
            // 
            this.birthDate.HeaderText = "birthDate";
            this.birthDate.Name = "birthDate";
            this.birthDate.ReadOnly = true;
            this.birthDate.Visible = false;
            // 
            // frmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.cbxBirthPlace);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.lblBirthPlace);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblClientId);
            this.Controls.Add(this.pnlBack);
            this.Name = "frmClients";
            this.Text = "Klantenbeheer";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.genderBox.ResumeLayout(false);
            this.genderBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblBirthPlace;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox cbxBirthPlace;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox genderBox;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbUnknown;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDate;
    }
}

