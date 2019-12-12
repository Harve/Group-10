namespace UserInterface
{
    partial class Administrator
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
            this.UsersButton = new System.Windows.Forms.Button();
            this.AdministratorLabel = new System.Windows.Forms.Label();
            this.UsersPictureBox = new System.Windows.Forms.PictureBox();
            this.ModulesButton = new System.Windows.Forms.Button();
            this.ModulesPictureBox = new System.Windows.Forms.PictureBox();
            this.ReviewAssessmentsPictureBox = new System.Windows.Forms.PictureBox();
            this.ReviewAssessmentsButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.BackButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsersPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModulesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewAssessmentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButtonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersButton
            // 
            this.UsersButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UsersButton.Location = new System.Drawing.Point(33, 182);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(119, 58);
            this.UsersButton.TabIndex = 2;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // AdministratorLabel
            // 
            this.AdministratorLabel.AutoSize = true;
            this.AdministratorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AdministratorLabel.Location = new System.Drawing.Point(271, 20);
            this.AdministratorLabel.Name = "AdministratorLabel";
            this.AdministratorLabel.Size = new System.Drawing.Size(174, 31);
            this.AdministratorLabel.TabIndex = 3;
            this.AdministratorLabel.Text = "Administrator";
            // 
            // UsersPictureBox
            // 
            this.UsersPictureBox.Location = new System.Drawing.Point(158, 74);
            this.UsersPictureBox.Name = "UsersPictureBox";
            this.UsersPictureBox.Size = new System.Drawing.Size(63, 58);
            this.UsersPictureBox.TabIndex = 8;
            this.UsersPictureBox.TabStop = false;
            // 
            // ModulesButton
            // 
            this.ModulesButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModulesButton.Location = new System.Drawing.Point(382, 182);
            this.ModulesButton.Name = "ModulesButton";
            this.ModulesButton.Size = new System.Drawing.Size(119, 58);
            this.ModulesButton.TabIndex = 9;
            this.ModulesButton.Text = "Modules";
            this.ModulesButton.UseVisualStyleBackColor = true;
            // 
            // ModulesPictureBox
            // 
            this.ModulesPictureBox.Location = new System.Drawing.Point(382, 74);
            this.ModulesPictureBox.Name = "ModulesPictureBox";
            this.ModulesPictureBox.Size = new System.Drawing.Size(63, 58);
            this.ModulesPictureBox.TabIndex = 10;
            this.ModulesPictureBox.TabStop = false;
            this.ModulesPictureBox.Click += new System.EventHandler(this.ModulesPictureBox_Click);
            // 
            // ReviewAssessmentsPictureBox
            // 
            this.ReviewAssessmentsPictureBox.Location = new System.Drawing.Point(609, 74);
            this.ReviewAssessmentsPictureBox.Name = "ReviewAssessmentsPictureBox";
            this.ReviewAssessmentsPictureBox.Size = new System.Drawing.Size(63, 58);
            this.ReviewAssessmentsPictureBox.TabIndex = 11;
            this.ReviewAssessmentsPictureBox.TabStop = false;
            // 
            // ReviewAssessmentsButton
            // 
            this.ReviewAssessmentsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ReviewAssessmentsButton.Location = new System.Drawing.Point(207, 182);
            this.ReviewAssessmentsButton.Name = "ReviewAssessmentsButton";
            this.ReviewAssessmentsButton.Size = new System.Drawing.Size(119, 58);
            this.ReviewAssessmentsButton.TabIndex = 12;
            this.ReviewAssessmentsButton.Text = "Assessments";
            this.ReviewAssessmentsButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackButton.Location = new System.Drawing.Point(12, 453);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(101, 24);
            this.BackButton.TabIndex = 22;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BackButtonPictureBox
            // 
            this.BackButtonPictureBox.Location = new System.Drawing.Point(119, 453);
            this.BackButtonPictureBox.Name = "BackButtonPictureBox";
            this.BackButtonPictureBox.Size = new System.Drawing.Size(29, 25);
            this.BackButtonPictureBox.TabIndex = 23;
            this.BackButtonPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 58);
            this.button1.TabIndex = 24;
            this.button1.Text = "Programmes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(693, 489);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BackButtonPictureBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ReviewAssessmentsButton);
            this.Controls.Add(this.ReviewAssessmentsPictureBox);
            this.Controls.Add(this.ModulesPictureBox);
            this.Controls.Add(this.ModulesButton);
            this.Controls.Add(this.UsersPictureBox);
            this.Controls.Add(this.AdministratorLabel);
            this.Controls.Add(this.UsersButton);
            this.Name = "Administrator";
            this.Text = "Administrator";
            ((System.ComponentModel.ISupportInitialize)(this.UsersPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModulesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewAssessmentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButtonPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Label AdministratorLabel;
        private System.Windows.Forms.PictureBox UsersPictureBox;
        private System.Windows.Forms.Button ModulesButton;
        private System.Windows.Forms.PictureBox ModulesPictureBox;
        private System.Windows.Forms.PictureBox ReviewAssessmentsPictureBox;
        private System.Windows.Forms.Button ReviewAssessmentsButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox BackButtonPictureBox;
        private System.Windows.Forms.Button button1;
    }
}