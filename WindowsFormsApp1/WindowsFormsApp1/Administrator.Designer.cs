namespace WindowsFormsApp1
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
            this.TitleBox = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.BackButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.IDLabelBox = new System.Windows.Forms.Label();
            this.NameLabelBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UsersPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModulesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewAssessmentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButtonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersButton
            // 
            this.UsersButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UsersButton.Location = new System.Drawing.Point(33, 74);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(119, 58);
            this.UsersButton.TabIndex = 2;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseVisualStyleBackColor = true;
            // 
            // AdministratorLabel
            // 
            this.AdministratorLabel.AutoSize = true;
            this.AdministratorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AdministratorLabel.Location = new System.Drawing.Point(264, 9);
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
            this.ModulesButton.Location = new System.Drawing.Point(257, 74);
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
            this.ReviewAssessmentsButton.Location = new System.Drawing.Point(484, 74);
            this.ReviewAssessmentsButton.Name = "ReviewAssessmentsButton";
            this.ReviewAssessmentsButton.Size = new System.Drawing.Size(119, 58);
            this.ReviewAssessmentsButton.TabIndex = 12;
            this.ReviewAssessmentsButton.Text = "Review Assessments";
            this.ReviewAssessmentsButton.UseVisualStyleBackColor = true;
            // 
            // TitleBox
            // 
            this.TitleBox.AutoSize = true;
            this.TitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TitleBox.Location = new System.Drawing.Point(273, 182);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(141, 17);
            this.TitleBox.TabIndex = 13;
            this.TitleBox.Text = "Placeholder Title Box";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(267, 222);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(18, 13);
            this.IDLabel.TabIndex = 14;
            this.IDLabel.Text = "ID";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(379, 222);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 15;
            this.NameLabel.Text = "Name";
            // 
            // AddButton
            // 
            this.AddButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddButton.Location = new System.Drawing.Point(74, 367);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(78, 36);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteButton.Location = new System.Drawing.Point(298, 367);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(78, 36);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditButton.Location = new System.Drawing.Point(525, 367);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(78, 36);
            this.EditButton.TabIndex = 18;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
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
            // 
            // BackButtonPictureBox
            // 
            this.BackButtonPictureBox.Location = new System.Drawing.Point(119, 453);
            this.BackButtonPictureBox.Name = "BackButtonPictureBox";
            this.BackButtonPictureBox.Size = new System.Drawing.Size(29, 25);
            this.BackButtonPictureBox.TabIndex = 23;
            this.BackButtonPictureBox.TabStop = false;
            // 
            // IDLabelBox
            // 
            this.IDLabelBox.AutoSize = true;
            this.IDLabelBox.Location = new System.Drawing.Point(239, 248);
            this.IDLabelBox.Name = "IDLabelBox";
            this.IDLabelBox.Size = new System.Drawing.Size(106, 13);
            this.IDLabelBox.TabIndex = 24;
            this.IDLabelBox.Text = "Placeholder ID Label";
            // 
            // NameLabelBox
            // 
            this.NameLabelBox.AutoSize = true;
            this.NameLabelBox.Location = new System.Drawing.Point(351, 248);
            this.NameLabelBox.Name = "NameLabelBox";
            this.NameLabelBox.Size = new System.Drawing.Size(123, 13);
            this.NameLabelBox.TabIndex = 25;
            this.NameLabelBox.Text = "Placeholder Name Label";
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(693, 489);
            this.Controls.Add(this.NameLabelBox);
            this.Controls.Add(this.IDLabelBox);
            this.Controls.Add(this.BackButtonPictureBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.TitleBox);
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
        private System.Windows.Forms.Label TitleBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox BackButtonPictureBox;
        private System.Windows.Forms.Label IDLabelBox;
        private System.Windows.Forms.Label NameLabelBox;
    }
}