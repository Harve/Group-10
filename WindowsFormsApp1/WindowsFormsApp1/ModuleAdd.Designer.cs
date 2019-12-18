namespace UserInterface
{
    partial class ModuleAdd
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
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.moduleIDTextbox = new System.Windows.Forms.TextBox();
            this.moduleNameTextbox = new System.Windows.Forms.TextBox();
            this.moduleLeaderDropdown = new System.Windows.Forms.ComboBox();
            this.programmeIDDropdown = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Module";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(34, 388);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(107, 34);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(368, 275);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(115, 40);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Module ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Module Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Programme ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Module Leader\r\n";
            // 
            // moduleIDTextbox
            // 
            this.moduleIDTextbox.Location = new System.Drawing.Point(353, 102);
            this.moduleIDTextbox.Name = "moduleIDTextbox";
            this.moduleIDTextbox.Size = new System.Drawing.Size(130, 22);
            this.moduleIDTextbox.TabIndex = 7;
            // 
            // moduleNameTextbox
            // 
            this.moduleNameTextbox.Location = new System.Drawing.Point(353, 145);
            this.moduleNameTextbox.Name = "moduleNameTextbox";
            this.moduleNameTextbox.Size = new System.Drawing.Size(130, 22);
            this.moduleNameTextbox.TabIndex = 8;
            // 
            // moduleLeaderDropdown
            // 
            this.moduleLeaderDropdown.FormattingEnabled = true;
            this.moduleLeaderDropdown.Location = new System.Drawing.Point(353, 186);
            this.moduleLeaderDropdown.Name = "moduleLeaderDropdown";
            this.moduleLeaderDropdown.Size = new System.Drawing.Size(130, 24);
            this.moduleLeaderDropdown.TabIndex = 9;
            // 
            // programmeIDDropdown
            // 
            this.programmeIDDropdown.FormattingEnabled = true;
            this.programmeIDDropdown.Location = new System.Drawing.Point(353, 228);
            this.programmeIDDropdown.Name = "programmeIDDropdown";
            this.programmeIDDropdown.Size = new System.Drawing.Size(130, 24);
            this.programmeIDDropdown.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(489, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "8 Character String";
            // 
            // ModuleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.programmeIDDropdown);
            this.Controls.Add(this.moduleLeaderDropdown);
            this.Controls.Add(this.moduleNameTextbox);
            this.Controls.Add(this.moduleIDTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Name = "ModuleAdd";
            this.Text = "ModuleAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox moduleIDTextbox;
        private System.Windows.Forms.TextBox moduleNameTextbox;
        private System.Windows.Forms.ComboBox moduleLeaderDropdown;
        private System.Windows.Forms.ComboBox programmeIDDropdown;
        private System.Windows.Forms.Label label6;
    }
}