namespace UserInterface
{
    partial class ModuleEdit
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
            this.editButton = new System.Windows.Forms.Button();
            this.moduleNameTextbox = new System.Windows.Forms.TextBox();
            this.moduleIdDropdown = new System.Windows.Forms.ComboBox();
            this.moduleLeaderDropdown = new System.Windows.Forms.ComboBox();
            this.programmeIDDropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module Edit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Module ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Module Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Module Leader";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Programme ID";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(41, 374);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 38);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(392, 258);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(103, 40);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // moduleNameTextbox
            // 
            this.moduleNameTextbox.Location = new System.Drawing.Point(342, 124);
            this.moduleNameTextbox.Name = "moduleNameTextbox";
            this.moduleNameTextbox.Size = new System.Drawing.Size(153, 22);
            this.moduleNameTextbox.TabIndex = 7;
            // 
            // moduleIdDropdown
            // 
            this.moduleIdDropdown.FormattingEnabled = true;
            this.moduleIdDropdown.Location = new System.Drawing.Point(342, 80);
            this.moduleIdDropdown.Name = "moduleIdDropdown";
            this.moduleIdDropdown.Size = new System.Drawing.Size(153, 24);
            this.moduleIdDropdown.TabIndex = 8;
            this.moduleIdDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // moduleLeaderDropdown
            // 
            this.moduleLeaderDropdown.FormattingEnabled = true;
            this.moduleLeaderDropdown.Location = new System.Drawing.Point(342, 168);
            this.moduleLeaderDropdown.Name = "moduleLeaderDropdown";
            this.moduleLeaderDropdown.Size = new System.Drawing.Size(153, 24);
            this.moduleLeaderDropdown.TabIndex = 9;
            // 
            // programmeIDDropdown
            // 
            this.programmeIDDropdown.FormattingEnabled = true;
            this.programmeIDDropdown.Location = new System.Drawing.Point(342, 209);
            this.programmeIDDropdown.Name = "programmeIDDropdown";
            this.programmeIDDropdown.Size = new System.Drawing.Size(153, 24);
            this.programmeIDDropdown.TabIndex = 10;
            // 
            // ModuleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.programmeIDDropdown);
            this.Controls.Add(this.moduleLeaderDropdown);
            this.Controls.Add(this.moduleIdDropdown);
            this.Controls.Add(this.moduleNameTextbox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModuleEdit";
            this.Text = "ModuleEdit";
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
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox moduleNameTextbox;
        private System.Windows.Forms.ComboBox moduleIdDropdown;
        private System.Windows.Forms.ComboBox moduleLeaderDropdown;
        private System.Windows.Forms.ComboBox programmeIDDropdown;
    }
}