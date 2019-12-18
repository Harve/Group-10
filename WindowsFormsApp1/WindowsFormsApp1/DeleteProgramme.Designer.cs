namespace UserInterface
{
    partial class DeleteProgramme
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ProgrammeIDDropdown = new System.Windows.Forms.ComboBox();
            this.programmeNameTextBox = new System.Windows.Forms.TextBox();
            this.programmeDirectorTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Programme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Programme ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Programme Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Programme Director";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProgrammeIDDropdown
            // 
            this.ProgrammeIDDropdown.FormattingEnabled = true;
            this.ProgrammeIDDropdown.Location = new System.Drawing.Point(323, 97);
            this.ProgrammeIDDropdown.Name = "ProgrammeIDDropdown";
            this.ProgrammeIDDropdown.Size = new System.Drawing.Size(154, 24);
            this.ProgrammeIDDropdown.TabIndex = 6;
            this.ProgrammeIDDropdown.SelectedIndexChanged += new System.EventHandler(this.ProgrammeIDDropdown_SelectedIndexChanged);
            // 
            // programmeNameTextBox
            // 
            this.programmeNameTextBox.Location = new System.Drawing.Point(323, 149);
            this.programmeNameTextBox.Name = "programmeNameTextBox";
            this.programmeNameTextBox.ReadOnly = true;
            this.programmeNameTextBox.Size = new System.Drawing.Size(154, 22);
            this.programmeNameTextBox.TabIndex = 7;
            // 
            // programmeDirectorTextbox
            // 
            this.programmeDirectorTextbox.Location = new System.Drawing.Point(323, 199);
            this.programmeDirectorTextbox.Name = "programmeDirectorTextbox";
            this.programmeDirectorTextbox.ReadOnly = true;
            this.programmeDirectorTextbox.Size = new System.Drawing.Size(154, 22);
            this.programmeDirectorTextbox.TabIndex = 8;
            // 
            // DeleteProgramme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.programmeDirectorTextbox);
            this.Controls.Add(this.programmeNameTextBox);
            this.Controls.Add(this.ProgrammeIDDropdown);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteProgramme";
            this.Text = "DeleteProgramme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox ProgrammeIDDropdown;
        private System.Windows.Forms.TextBox programmeNameTextBox;
        private System.Windows.Forms.TextBox programmeDirectorTextbox;
    }
}