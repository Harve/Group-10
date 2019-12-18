namespace UserInterface
{
    partial class ProgrammeAdd
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
            this.programmeNameInput = new System.Windows.Forms.TextBox();
            this.IDinput = new System.Windows.Forms.TextBox();
            this.programDirectorDropdown = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Programme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Programme ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prgramme Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Program Director";
            // 
            // programmeNameInput
            // 
            this.programmeNameInput.Location = new System.Drawing.Point(369, 162);
            this.programmeNameInput.Name = "programmeNameInput";
            this.programmeNameInput.Size = new System.Drawing.Size(168, 22);
            this.programmeNameInput.TabIndex = 4;
            this.programmeNameInput.TextChanged += new System.EventHandler(this.programmeNameInput_TextChanged);
            // 
            // IDinput
            // 
            this.IDinput.Location = new System.Drawing.Point(369, 114);
            this.IDinput.Name = "IDinput";
            this.IDinput.Size = new System.Drawing.Size(167, 22);
            this.IDinput.TabIndex = 5;
            this.IDinput.TextChanged += new System.EventHandler(this.IDinput_TextChanged);
            // 
            // programDirectorDropdown
            // 
            this.programDirectorDropdown.FormattingEnabled = true;
            this.programDirectorDropdown.Location = new System.Drawing.Point(369, 218);
            this.programDirectorDropdown.Name = "programDirectorDropdown";
            this.programDirectorDropdown.Size = new System.Drawing.Size(168, 24);
            this.programDirectorDropdown.TabIndex = 6;
            this.programDirectorDropdown.SelectedIndexChanged += new System.EventHandler(this.programDirectorDropdown_SelectedIndexChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(37, 380);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(85, 28);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(420, 282);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(116, 36);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(542, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "8 Character String";
            // 
            // ProgrammeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.programDirectorDropdown);
            this.Controls.Add(this.IDinput);
            this.Controls.Add(this.programmeNameInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProgrammeAdd";
            this.Text = "ProgrammeAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox programmeNameInput;
        private System.Windows.Forms.TextBox IDinput;
        private System.Windows.Forms.ComboBox programDirectorDropdown;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label5;
    }
}