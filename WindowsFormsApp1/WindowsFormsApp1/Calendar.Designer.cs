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
            this.CalendarView = new System.Windows.Forms.MonthCalendar();
            this.CalendarLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.BackButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.AssessmentView = new System.Windows.Forms.DataGridView();
            this.Assessment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BackButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentView)).BeginInit();
            this.SuspendLayout();
            // 
            // CalendarView
            // 
            this.CalendarView.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.CalendarView.Location = new System.Drawing.Point(121, 75);
            this.CalendarView.Name = "CalendarView";
            this.CalendarView.TabIndex = 0;
            //this.CalendarView.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CalendarView_DateSelected);
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
            // BackButton
            // 
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackButton.Location = new System.Drawing.Point(12, 455);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(101, 24);
            this.BackButton.TabIndex = 21;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BackButtonPictureBox
            // 
            this.BackButtonPictureBox.Location = new System.Drawing.Point(119, 454);
            this.BackButtonPictureBox.Name = "BackButtonPictureBox";
            this.BackButtonPictureBox.Size = new System.Drawing.Size(29, 25);
            this.BackButtonPictureBox.TabIndex = 22;
            this.BackButtonPictureBox.TabStop = false;
            // 
            // AssessmentView
            // 
            this.AssessmentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssessmentView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Assessment,
            this.Date});
            this.AssessmentView.Location = new System.Drawing.Point(121, 282);
            this.AssessmentView.Name = "AssessmentView";
            this.AssessmentView.Size = new System.Drawing.Size(458, 150);
            this.AssessmentView.TabIndex = 23;
            // 
            // Assessment
            // 
            this.Assessment.HeaderText = "Assessment";
            this.Assessment.Name = "Assessment";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(719, 491);
            this.Controls.Add(this.AssessmentView);
            this.Controls.Add(this.BackButtonPictureBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CalendarLabel);
            this.Controls.Add(this.CalendarView);
            this.Name = "Calendar";
            this.Text = "Calendar";
            ((System.ComponentModel.ISupportInitialize)(this.BackButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar CalendarView;
        private System.Windows.Forms.Label CalendarLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox BackButtonPictureBox;
        private System.Windows.Forms.DataGridView AssessmentView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assessment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}