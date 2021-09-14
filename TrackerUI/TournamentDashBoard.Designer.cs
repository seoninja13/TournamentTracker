
namespace TrackerUI
{
    partial class tournamentDashBoardForm
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
            this.tournamentDashBoardHeaderLabel = new System.Windows.Forms.Label();
            this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.loadExistingTournamentDropdown = new System.Windows.Forms.ComboBox();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentDashBoardHeaderLabel
            // 
            this.tournamentDashBoardHeaderLabel.AutoSize = true;
            this.tournamentDashBoardHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentDashBoardHeaderLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tournamentDashBoardHeaderLabel.Location = new System.Drawing.Point(122, 30);
            this.tournamentDashBoardHeaderLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.tournamentDashBoardHeaderLabel.Name = "tournamentDashBoardHeaderLabel";
            this.tournamentDashBoardHeaderLabel.Size = new System.Drawing.Size(381, 46);
            this.tournamentDashBoardHeaderLabel.TabIndex = 4;
            this.tournamentDashBoardHeaderLabel.Text = "Tournament Dashboard ";
            // 
            // loadExistingTournamentLabel
            // 
            this.loadExistingTournamentLabel.AutoSize = true;
            this.loadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExistingTournamentLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.loadExistingTournamentLabel.Location = new System.Drawing.Point(118, 92);
            this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            this.loadExistingTournamentLabel.Size = new System.Drawing.Size(359, 41);
            this.loadExistingTournamentLabel.TabIndex = 17;
            this.loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadExistingTournamentDropdown
            // 
            this.loadExistingTournamentDropdown.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExistingTournamentDropdown.FormattingEnabled = true;
            this.loadExistingTournamentDropdown.Location = new System.Drawing.Point(117, 136);
            this.loadExistingTournamentDropdown.Name = "loadExistingTournamentDropdown";
            this.loadExistingTournamentDropdown.Size = new System.Drawing.Size(361, 49);
            this.loadExistingTournamentDropdown.TabIndex = 19;
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.BackColor = System.Drawing.Color.AliceBlue;
            this.loadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadTournamentButton.FlatAppearance.BorderSize = 2;
            this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTournamentButton.Location = new System.Drawing.Point(135, 198);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loadTournamentButton.Size = new System.Drawing.Size(276, 59);
            this.loadTournamentButton.TabIndex = 25;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.Color.AliceBlue;
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.BorderSize = 2;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.Location = new System.Drawing.Point(93, 302);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.createTournamentButton.Size = new System.Drawing.Size(361, 76);
            this.createTournamentButton.TabIndex = 26;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // tournamentDashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 468);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.loadExistingTournamentDropdown);
            this.Controls.Add(this.loadExistingTournamentLabel);
            this.Controls.Add(this.tournamentDashBoardHeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "tournamentDashBoardForm";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentDashBoardHeaderLabel;
        private System.Windows.Forms.Label loadExistingTournamentLabel;
        private System.Windows.Forms.ComboBox loadExistingTournamentDropdown;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.Button createTournamentButton;
    }
}