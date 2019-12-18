namespace UserInterface
{
    partial class ModuleDelete
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.moduleIDDropdown = new System.Windows.Forms.ComboBox();
            this.moduleNameTextbox = new System.Windows.Forms.TextBox();
            this.moduleLeaderTextbox = new System.Windows.Forms.TextBox();
            this.programmeIDTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Module";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Module ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Module Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Module Leader";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Programme ID";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(40, 384);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(129, 35);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(406, 284);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(99, 35);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // moduleIDDropdown
            // 
            this.moduleIDDropdown.FormattingEnabled = true;
            this.moduleIDDropdown.Location = new System.Drawing.Point(349, 75);
            this.moduleIDDropdown.Name = "moduleIDDropdown";
            this.moduleIDDropdown.Size = new System.Drawing.Size(156, 24);
            this.moduleIDDropdown.TabIndex = 7;
            this.moduleIDDropdown.SelectedIndexChanged += new System.EventHandler(this.moduleIDDropdown_SelectedIndexChanged);
            // 
            // moduleNameTextbox
            // 
            this.moduleNameTextbox.Location = new System.Drawing.Point(349, 128);
            this.moduleNameTextbox.Name = "moduleNameTextbox";
            this.moduleNameTextbox.ReadOnly = true;
            this.moduleNameTextbox.Size = new System.Drawing.Size(156, 22);
            this.moduleNameTextbox.TabIndex = 8;
            // 
            // moduleLeaderTextbox
            // 
            this.moduleLeaderTextbox.Location = new System.Drawing.Point(349, 178);
            this.moduleLeaderTextbox.Name = "moduleLeaderTextbox";
            this.moduleLeaderTextbox.ReadOnly = true;
            this.moduleLeaderTextbox.Size = new System.Drawing.Size(156, 22);
            this.moduleLeaderTextbox.TabIndex = 9;
            // 
            // programmeIDTextbox
            // 
            this.programmeIDTextbox.Location = new System.Drawing.Point(349, 231);
            this.programmeIDTextbox.Name = "programmeIDTextbox";
            this.programmeIDTextbox.ReadOnly = true;
            this.programmeIDTextbox.Size = new System.Drawing.Size(156, 22);
            this.programmeIDTextbox.TabIndex = 10;
            // 
            // ModuleDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.programmeIDTextbox);
            this.Controls.Add(this.moduleLeaderTextbox);
            this.Controls.Add(this.moduleNameTextbox);
            this.Controls.Add(this.moduleIDDropdown);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModuleDelete";
            this.Text = "ModuleDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox moduleIDDropdown;
        private System.Windows.Forms.TextBox moduleNameTextbox;
        private System.Windows.Forms.TextBox moduleLeaderTextbox;
        private System.Windows.Forms.TextBox programmeIDTextbox;
    }
}