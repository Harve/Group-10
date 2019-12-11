namespace UserInterface
{
    partial class NewModule
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
            this.ModuleID = new System.Windows.Forms.TextBox();
            this.ProgrammeBox = new System.Windows.Forms.ComboBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TeamListBox = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TeamLeader = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Module";
            // 
            // ModuleID
            // 
            this.ModuleID.Location = new System.Drawing.Point(163, 117);
            this.ModuleID.Name = "ModuleID";
            this.ModuleID.Size = new System.Drawing.Size(100, 20);
            this.ModuleID.TabIndex = 1;
            // 
            // ProgrammeBox
            // 
            this.ProgrammeBox.FormattingEnabled = true;
            this.ProgrammeBox.Location = new System.Drawing.Point(163, 180);
            this.ProgrammeBox.Name = "ProgrammeBox";
            this.ProgrammeBox.Size = new System.Drawing.Size(121, 21);
            this.ProgrammeBox.TabIndex = 2;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(163, 243);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 20);
            this.Title.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Module ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Programme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Title";
            // 
            // TeamListBox
            // 
            this.TeamListBox.FormattingEnabled = true;
            this.TeamListBox.Location = new System.Drawing.Point(512, 123);
            this.TeamListBox.Name = "TeamListBox";
            this.TeamListBox.Size = new System.Drawing.Size(120, 94);
            this.TeamListBox.TabIndex = 7;
            this.TeamListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.TeamListBox_ItemCheck);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Team";
            // 
            // TeamLeader
            // 
            this.TeamLeader.FormattingEnabled = true;
            this.TeamLeader.Location = new System.Drawing.Point(512, 265);
            this.TeamLeader.Name = "TeamLeader";
            this.TeamLeader.Size = new System.Drawing.Size(121, 21);
            this.TeamLeader.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Team Leader";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NewModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TeamLeader);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TeamListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ProgrammeBox);
            this.Controls.Add(this.ModuleID);
            this.Controls.Add(this.label1);
            this.Name = "NewModule";
            this.Text = "NewModule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ModuleID;
        private System.Windows.Forms.ComboBox ProgrammeBox;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox TeamListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TeamLeader;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}