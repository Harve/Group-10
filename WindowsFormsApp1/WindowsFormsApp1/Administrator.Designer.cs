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
            this.ModulesButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsersButton
            // 
            this.UsersButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UsersButton.Location = new System.Drawing.Point(134, 224);
            this.UsersButton.Margin = new System.Windows.Forms.Padding(4);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(159, 71);
            this.UsersButton.TabIndex = 2;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // AdministratorLabel
            // 
            this.AdministratorLabel.AutoSize = true;
            this.AdministratorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AdministratorLabel.Location = new System.Drawing.Point(335, 41);
            this.AdministratorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdministratorLabel.Name = "AdministratorLabel";
            this.AdministratorLabel.Size = new System.Drawing.Size(208, 39);
            this.AdministratorLabel.TabIndex = 3;
            this.AdministratorLabel.Text = "Admin Menu";
            // 
            // ModulesButton
            // 
            this.ModulesButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModulesButton.Location = new System.Drawing.Point(358, 224);
            this.ModulesButton.Margin = new System.Windows.Forms.Padding(4);
            this.ModulesButton.Name = "ModulesButton";
            this.ModulesButton.Size = new System.Drawing.Size(159, 71);
            this.ModulesButton.TabIndex = 9;
            this.ModulesButton.Text = "Modules";
            this.ModulesButton.UseVisualStyleBackColor = true;
            this.ModulesButton.Click += new System.EventHandler(this.ModulesButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackButton.Location = new System.Drawing.Point(44, 558);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(159, 30);
            this.BackButton.TabIndex = 22;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 224);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 71);
            this.button1.TabIndex = 24;
            this.button1.Text = "Programmes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(721, 558);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 30);
            this.button2.TabIndex = 25;
            this.button2.Text = "Notifications";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(924, 602);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ModulesButton);
            this.Controls.Add(this.AdministratorLabel);
            this.Controls.Add(this.UsersButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Label AdministratorLabel;
        private System.Windows.Forms.Button ModulesButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}