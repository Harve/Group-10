namespace UserInterface
{
    partial class ModuleTeamManager
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
            this.updateButton = new System.Windows.Forms.Button();
            this.oldModuleTeamList = new System.Windows.Forms.ListBox();
            this.newModuleTeamChecked = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.moduleIDDropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module Team Manager";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(33, 380);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 36);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(332, 332);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(117, 46);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // oldModuleTeamList
            // 
            this.oldModuleTeamList.FormattingEnabled = true;
            this.oldModuleTeamList.ItemHeight = 16;
            this.oldModuleTeamList.Location = new System.Drawing.Point(270, 119);
            this.oldModuleTeamList.Name = "oldModuleTeamList";
            this.oldModuleTeamList.Size = new System.Drawing.Size(176, 148);
            this.oldModuleTeamList.TabIndex = 3;
            // 
            // newModuleTeamChecked
            // 
            this.newModuleTeamChecked.CheckOnClick = true;
            this.newModuleTeamChecked.FormattingEnabled = true;
            this.newModuleTeamChecked.Location = new System.Drawing.Point(503, 119);
            this.newModuleTeamChecked.Name = "newModuleTeamChecked";
            this.newModuleTeamChecked.Size = new System.Drawing.Size(209, 259);
            this.newModuleTeamChecked.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Old Module Team Members";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "New Module Team Members";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Choose Module";
            // 
            // moduleIDDropdown
            // 
            this.moduleIDDropdown.FormattingEnabled = true;
            this.moduleIDDropdown.Location = new System.Drawing.Point(55, 119);
            this.moduleIDDropdown.Name = "moduleIDDropdown";
            this.moduleIDDropdown.Size = new System.Drawing.Size(164, 24);
            this.moduleIDDropdown.TabIndex = 8;
            this.moduleIDDropdown.SelectedIndexChanged += new System.EventHandler(this.moduleIDDropdown_SelectedIndexChanged);
            // 
            // ModuleTeamManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moduleIDDropdown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newModuleTeamChecked);
            this.Controls.Add(this.oldModuleTeamList);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Name = "ModuleTeamManager";
            this.Text = "ModuleTeamManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ListBox oldModuleTeamList;
        private System.Windows.Forms.CheckedListBox newModuleTeamChecked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox moduleIDDropdown;
    }
}