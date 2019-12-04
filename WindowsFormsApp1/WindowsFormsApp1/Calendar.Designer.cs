namespace UserInterface
{
    partial class Calendar
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
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.CalendarLabel = new System.Windows.Forms.Label();
            this.AssignmentsDueLabel = new System.Windows.Forms.Label();
            this.AssignmentsDueBox = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.BackButtonPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackButtonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar.Location = new System.Drawing.Point(121, 75);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            // 
            // CalendarLabel
            // 
            this.CalendarLabel.AutoSize = true;
            this.CalendarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CalendarLabel.Location = new System.Drawing.Point(285, 9);
            this.CalendarLabel.Name = "CalendarLabel";
            this.CalendarLabel.Size = new System.Drawing.Size(124, 31);
            this.CalendarLabel.TabIndex = 2;
            this.CalendarLabel.Text = "Calendar";
            // 
            // AssignmentsDueLabel
            // 
            this.AssignmentsDueLabel.AutoSize = true;
            this.AssignmentsDueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AssignmentsDueLabel.Location = new System.Drawing.Point(305, 267);
            this.AssignmentsDueLabel.Name = "AssignmentsDueLabel";
            this.AssignmentsDueLabel.Size = new System.Drawing.Size(135, 20);
            this.AssignmentsDueLabel.TabIndex = 3;
            this.AssignmentsDueLabel.Text = "Assignments Due";
            this.AssignmentsDueLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // AssignmentsDueBox
            // 
            this.AssignmentsDueBox.AutoSize = true;
            this.AssignmentsDueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AssignmentsDueBox.Location = new System.Drawing.Point(266, 303);
            this.AssignmentsDueBox.Name = "AssignmentsDueBox";
            this.AssignmentsDueBox.Size = new System.Drawing.Size(212, 17);
            this.AssignmentsDueBox.TabIndex = 4;
            this.AssignmentsDueBox.Text = "PlaceHolderForAssignemntsDue";
            // 
            // BackButton
            // 
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackButton.Location = new System.Drawing.Point(12, 455);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(101, 24);
            this.BackButton.TabIndex = 21;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // BackButtonPictureBox
            // 
            this.BackButtonPictureBox.Location = new System.Drawing.Point(119, 454);
            this.BackButtonPictureBox.Name = "BackButtonPictureBox";
            this.BackButtonPictureBox.Size = new System.Drawing.Size(29, 25);
            this.BackButtonPictureBox.TabIndex = 22;
            this.BackButtonPictureBox.TabStop = false;
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(719, 491);
            this.Controls.Add(this.BackButtonPictureBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AssignmentsDueBox);
            this.Controls.Add(this.AssignmentsDueLabel);
            this.Controls.Add(this.CalendarLabel);
            this.Controls.Add(this.monthCalendar);
            this.Name = "Calendar";
            this.Text = "Calendar";
            ((System.ComponentModel.ISupportInitialize)(this.BackButtonPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label CalendarLabel;
        private System.Windows.Forms.Label AssignmentsDueLabel;
        private System.Windows.Forms.Label AssignmentsDueBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox BackButtonPictureBox;
    }
}