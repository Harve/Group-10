namespace UserInterface
{
    partial class ProgrammeEdit
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
            this.programmeIDDropdown = new System.Windows.Forms.ComboBox();
            this.programmeDirectorDropdown = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.programmeNameTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Programme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Programme ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Programme Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Programme Director";
            // 
            // programmeIDDropdown
            // 
            this.programmeIDDropdown.FormattingEnabled = true;
            this.programmeIDDropdown.Location = new System.Drawing.Point(378, 121);
            this.programmeIDDropdown.Name = "programmeIDDropdown";
            this.programmeIDDropdown.Size = new System.Drawing.Size(160, 24);
            this.programmeIDDropdown.TabIndex = 4;
            this.programmeIDDropdown.SelectedIndexChanged += new System.EventHandler(this.programmeIDDropdown_SelectedIndexChanged);
            // 
            // programmeDirectorDropdown
            // 
            this.programmeDirectorDropdown.FormattingEnabled = true;
            this.programmeDirectorDropdown.Location = new System.Drawing.Point(378, 229);
            this.programmeDirectorDropdown.Name = "programmeDirectorDropdown";
            this.programmeDirectorDropdown.Size = new System.Drawing.Size(160, 24);
            this.programmeDirectorDropdown.TabIndex = 5;
            this.programmeDirectorDropdown.SelectedIndexChanged += new System.EventHandler(this.programmeDirectorDropdown_SelectedIndexChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(32, 386);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(118, 33);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(418, 287);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(120, 35);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // programmeNameTextbox
            // 
            this.programmeNameTextbox.Location = new System.Drawing.Point(378, 176);
            this.programmeNameTextbox.Name = "programmeNameTextbox";
            this.programmeNameTextbox.Size = new System.Drawing.Size(160, 22);
            this.programmeNameTextbox.TabIndex = 8;
            this.programmeNameTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ProgrammeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.programmeNameTextbox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.programmeDirectorDropdown);
            this.Controls.Add(this.programmeIDDropdown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProgrammeEdit";
            this.Text = "ProgrammeEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox programmeIDDropdown;
        private System.Windows.Forms.ComboBox programmeDirectorDropdown;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox programmeNameTextbox;
    }
}