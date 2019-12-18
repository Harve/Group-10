namespace UserInterface
{
    partial class DoS_HomeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.notificationButton = new System.Windows.Forms.Button();
            this.setDeadlinesButton = new System.Windows.Forms.Button();
            this.assignModeratorsButton = new System.Windows.Forms.Button();
            this.panelButton = new System.Windows.Forms.Button();
            this.assesmentOverviewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Director of Study";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(32, 398);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(149, 26);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // notificationButton
            // 
            this.notificationButton.Location = new System.Drawing.Point(604, 398);
            this.notificationButton.Name = "notificationButton";
            this.notificationButton.Size = new System.Drawing.Size(149, 26);
            this.notificationButton.TabIndex = 2;
            this.notificationButton.Text = "Notifications";
            this.notificationButton.UseVisualStyleBackColor = true;
            this.notificationButton.Click += new System.EventHandler(this.notificationButton_Click);
            // 
            // setDeadlinesButton
            // 
            this.setDeadlinesButton.Location = new System.Drawing.Point(99, 135);
            this.setDeadlinesButton.Name = "setDeadlinesButton";
            this.setDeadlinesButton.Size = new System.Drawing.Size(166, 105);
            this.setDeadlinesButton.TabIndex = 3;
            this.setDeadlinesButton.Text = "Set Deadlines";
            this.setDeadlinesButton.UseVisualStyleBackColor = true;
            this.setDeadlinesButton.Click += new System.EventHandler(this.setDeadlinesButton_Click);
            // 
            // assignModeratorsButton
            // 
            this.assignModeratorsButton.Location = new System.Drawing.Point(307, 135);
            this.assignModeratorsButton.Name = "assignModeratorsButton";
            this.assignModeratorsButton.Size = new System.Drawing.Size(166, 105);
            this.assignModeratorsButton.TabIndex = 4;
            this.assignModeratorsButton.Text = "Assign Moderators";
            this.assignModeratorsButton.UseVisualStyleBackColor = true;
            this.assignModeratorsButton.Click += new System.EventHandler(this.assignModeratorsButton_Click);
            // 
            // panelButton
            // 
            this.panelButton.Location = new System.Drawing.Point(514, 135);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(166, 105);
            this.panelButton.TabIndex = 5;
            this.panelButton.Text = "Panel";
            this.panelButton.UseVisualStyleBackColor = true;
            this.panelButton.Click += new System.EventHandler(this.panelButton_Click);
            // 
            // assesmentOverviewButton
            // 
            this.assesmentOverviewButton.Location = new System.Drawing.Point(307, 274);
            this.assesmentOverviewButton.Name = "assesmentOverviewButton";
            this.assesmentOverviewButton.Size = new System.Drawing.Size(166, 105);
            this.assesmentOverviewButton.TabIndex = 6;
            this.assesmentOverviewButton.Text = "View Assesment Scrutiny Progress";
            this.assesmentOverviewButton.UseVisualStyleBackColor = true;
            this.assesmentOverviewButton.Click += new System.EventHandler(this.assesmentOverviewButton_Click);
            // 
            // DoS_HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.assesmentOverviewButton);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.assignModeratorsButton);
            this.Controls.Add(this.setDeadlinesButton);
            this.Controls.Add(this.notificationButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Name = "DoS_HomeForm";
            this.Text = "DoS_HomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button notificationButton;
        private System.Windows.Forms.Button setDeadlinesButton;
        private System.Windows.Forms.Button assignModeratorsButton;
        private System.Windows.Forms.Button panelButton;
        private System.Windows.Forms.Button assesmentOverviewButton;
    }
}