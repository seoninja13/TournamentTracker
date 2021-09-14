
namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.createTeamLabel = new System.Windows.Forms.Label();
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.addTeamMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberDropdown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.cellphoneValue = new System.Windows.Forms.TextBox();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.createMemebrButton = new System.Windows.Forms.Button();
            this.teamPlayersListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createTeamLabel
            // 
            this.createTeamLabel.AutoSize = true;
            this.createTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.createTeamLabel.Location = new System.Drawing.Point(12, 9);
            this.createTeamLabel.Name = "createTeamLabel";
            this.createTeamLabel.Size = new System.Drawing.Size(163, 37);
            this.createTeamLabel.TabIndex = 2;
            this.createTeamLabel.Text = "Create Team";
            // 
            // teamNameValue
            // 
            this.teamNameValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameValue.Location = new System.Drawing.Point(17, 92);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(361, 39);
            this.teamNameValue.TabIndex = 12;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.teamNameLabel.Location = new System.Drawing.Point(13, 57);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(143, 32);
            this.teamNameLabel.TabIndex = 11;
            this.teamNameLabel.Text = "Team Name";
            // 
            // addTeamMemberButton
            // 
            this.addTeamMemberButton.BackColor = System.Drawing.Color.AliceBlue;
            this.addTeamMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamMemberButton.FlatAppearance.BorderSize = 2;
            this.addTeamMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamMemberButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamMemberButton.Location = new System.Drawing.Point(102, 238);
            this.addTeamMemberButton.Name = "addTeamMemberButton";
            this.addTeamMemberButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addTeamMemberButton.Size = new System.Drawing.Size(178, 46);
            this.addTeamMemberButton.TabIndex = 20;
            this.addTeamMemberButton.Text = "Add Member";
            this.addTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropdown
            // 
            this.selectTeamMemberDropdown.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamMemberDropdown.FormattingEnabled = true;
            this.selectTeamMemberDropdown.Location = new System.Drawing.Point(17, 183);
            this.selectTeamMemberDropdown.Name = "selectTeamMemberDropdown";
            this.selectTeamMemberDropdown.Size = new System.Drawing.Size(361, 40);
            this.selectTeamMemberDropdown.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(11, 148);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(241, 32);
            this.selectTeamMemberLabel.TabIndex = 17;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addNewMemberGroupBox
            // 
            this.addNewMemberGroupBox.Controls.Add(this.createMemebrButton);
            this.addNewMemberGroupBox.Controls.Add(this.cellphoneValue);
            this.addNewMemberGroupBox.Controls.Add(this.cellphoneLabel);
            this.addNewMemberGroupBox.Controls.Add(this.emailValue);
            this.addNewMemberGroupBox.Controls.Add(this.emailLabel);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameValue);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameLabel);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameValue);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameLabel);
            this.addNewMemberGroupBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewMemberGroupBox.Location = new System.Drawing.Point(17, 307);
            this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            this.addNewMemberGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.addNewMemberGroupBox.Size = new System.Drawing.Size(455, 331);
            this.addNewMemberGroupBox.TabIndex = 23;
            this.addNewMemberGroupBox.TabStop = false;
            this.addNewMemberGroupBox.Text = "Add New Member";
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(179, 157);
            this.emailValue.Margin = new System.Windows.Forms.Padding(5);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(262, 39);
            this.emailValue.TabIndex = 18;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.emailLabel.Location = new System.Drawing.Point(8, 158);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(72, 32);
            this.emailLabel.TabIndex = 17;
            this.emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(179, 105);
            this.lastNameValue.Margin = new System.Windows.Forms.Padding(5);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(262, 39);
            this.lastNameValue.TabIndex = 16;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lastNameLabel.Location = new System.Drawing.Point(8, 105);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(127, 32);
            this.lastNameLabel.TabIndex = 15;
            this.lastNameLabel.Text = "Last Name";
            this.lastNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(179, 51);
            this.firstNameValue.Margin = new System.Windows.Forms.Padding(5);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(262, 39);
            this.firstNameValue.TabIndex = 14;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.firstNameLabel.Location = new System.Drawing.Point(8, 52);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(130, 32);
            this.firstNameLabel.TabIndex = 13;
            this.firstNameLabel.Text = "First Name";
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.Location = new System.Drawing.Point(179, 210);
            this.cellphoneValue.Margin = new System.Windows.Forms.Padding(5);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(262, 39);
            this.cellphoneValue.TabIndex = 21;
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cellphoneLabel.Location = new System.Drawing.Point(8, 211);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(124, 32);
            this.cellphoneLabel.TabIndex = 20;
            this.cellphoneLabel.Text = "Cellphone";
            this.cellphoneLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // createMemebrButton
            // 
            this.createMemebrButton.BackColor = System.Drawing.Color.AliceBlue;
            this.createMemebrButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemebrButton.FlatAppearance.BorderSize = 2;
            this.createMemebrButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemebrButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemebrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemebrButton.Location = new System.Drawing.Point(127, 270);
            this.createMemebrButton.Name = "createMemebrButton";
            this.createMemebrButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.createMemebrButton.Size = new System.Drawing.Size(234, 49);
            this.createMemebrButton.TabIndex = 22;
            this.createMemebrButton.Text = "Create Member";
            this.createMemebrButton.UseVisualStyleBackColor = true;
            // 
            // teamPlayersListBox
            // 
            this.teamPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamPlayersListBox.FormattingEnabled = true;
            this.teamPlayersListBox.ItemHeight = 36;
            this.teamPlayersListBox.Location = new System.Drawing.Point(529, 92);
            this.teamPlayersListBox.Name = "teamPlayersListBox";
            this.teamPlayersListBox.Size = new System.Drawing.Size(301, 542);
            this.teamPlayersListBox.TabIndex = 24;
            // 
            // deleteSelectedMemberButton
            // 
            this.deleteSelectedMemberButton.BackColor = System.Drawing.Color.AliceBlue;
            this.deleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedMemberButton.FlatAppearance.BorderSize = 2;
            this.deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedMemberButton.Location = new System.Drawing.Point(836, 92);
            this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            this.deleteSelectedMemberButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deleteSelectedMemberButton.Size = new System.Drawing.Size(130, 88);
            this.deleteSelectedMemberButton.TabIndex = 25;
            this.deleteSelectedMemberButton.Text = "Delete\r\nMember";
            this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            this.deleteSelectedMemberButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // createTeamButton
            // 
            this.createTeamButton.BackColor = System.Drawing.Color.AliceBlue;
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.BorderSize = 2;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamButton.Location = new System.Drawing.Point(395, 665);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.createTeamButton.Size = new System.Drawing.Size(195, 56);
            this.createTeamButton.TabIndex = 26;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 754);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteSelectedMemberButton);
            this.Controls.Add(this.teamPlayersListBox);
            this.Controls.Add(this.addNewMemberGroupBox);
            this.Controls.Add(this.addTeamMemberButton);
            this.Controls.Add(this.selectTeamMemberDropdown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.createTeamLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.Load += new System.EventHandler(this.CreateTeamForm_Load);
            this.addNewMemberGroupBox.ResumeLayout(false);
            this.addNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTeamLabel;
        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Button addTeamMemberButton;
        private System.Windows.Forms.ComboBox selectTeamMemberDropdown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.GroupBox addNewMemberGroupBox;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox cellphoneValue;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.Button createMemebrButton;
        private System.Windows.Forms.ListBox teamPlayersListBox;
        private System.Windows.Forms.Button deleteSelectedMemberButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}