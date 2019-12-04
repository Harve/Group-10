namespace UserInterface
{
    partial class CreateNewForm
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
            this.CreateNewLable = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ModuleLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ReleaseDateLabel = new System.Windows.Forms.Label();
            this.DueDateLabel = new System.Windows.Forms.Label();
            this.CanvasURLLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FileUploadTextBox = new System.Windows.Forms.TextBox();
            this.URLTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.UploadButton = new System.Windows.Forms.Button();
            this.UploadedTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ModuleListBox = new System.Windows.Forms.ListBox();
            this.ReleaseDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.DueDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.BackButtonPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackButtonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateNewLable
            // 
            this.CreateNewLable.AutoSize = true;
            this.CreateNewLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CreateNewLable.Location = new System.Drawing.Point(312, 41);
            this.CreateNewLable.Name = "CreateNewLable";
            this.CreateNewLable.Size = new System.Drawing.Size(158, 31);
            this.CreateNewLable.TabIndex = 1;
            this.CreateNewLable.Text = "Create New";
            this.CreateNewLable.Click += new System.EventHandler(this.Home_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(130, 133);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // ModuleLabel
            // 
            this.ModuleLabel.AutoSize = true;
            this.ModuleLabel.Location = new System.Drawing.Point(130, 178);
            this.ModuleLabel.Name = "ModuleLabel";
            this.ModuleLabel.Size = new System.Drawing.Size(42, 13);
            this.ModuleLabel.TabIndex = 3;
            this.ModuleLabel.Text = "Module";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(130, 231);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 4;
            this.DescriptionLabel.Text = "Description";
            // 
            // ReleaseDateLabel
            // 
            this.ReleaseDateLabel.AutoSize = true;
            this.ReleaseDateLabel.Location = new System.Drawing.Point(130, 286);
            this.ReleaseDateLabel.Name = "ReleaseDateLabel";
            this.ReleaseDateLabel.Size = new System.Drawing.Size(72, 13);
            this.ReleaseDateLabel.TabIndex = 5;
            this.ReleaseDateLabel.Text = "Release Date";
            // 
            // DueDateLabel
            // 
            this.DueDateLabel.AutoSize = true;
            this.DueDateLabel.Location = new System.Drawing.Point(566, 96);
            this.DueDateLabel.Name = "DueDateLabel";
            this.DueDateLabel.Size = new System.Drawing.Size(53, 13);
            this.DueDateLabel.TabIndex = 6;
            this.DueDateLabel.Text = "Due Date";
            this.DueDateLabel.Click += new System.EventHandler(this.DueDateLabel_Click);
            // 
            // CanvasURLLabel
            // 
            this.CanvasURLLabel.AutoSize = true;
            this.CanvasURLLabel.Location = new System.Drawing.Point(484, 289);
            this.CanvasURLLabel.Name = "CanvasURLLabel";
            this.CanvasURLLabel.Size = new System.Drawing.Size(68, 13);
            this.CanvasURLLabel.TabIndex = 7;
            this.CanvasURLLabel.Text = "Canvas URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "File Upload";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FileUploadTextBox
            // 
            this.FileUploadTextBox.Location = new System.Drawing.Point(487, 345);
            this.FileUploadTextBox.Name = "FileUploadTextBox";
            this.FileUploadTextBox.ReadOnly = true;
            this.FileUploadTextBox.Size = new System.Drawing.Size(182, 20);
            this.FileUploadTextBox.TabIndex = 9;
            this.FileUploadTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // URLTextBox
            // 
            this.URLTextBox.Location = new System.Drawing.Point(569, 286);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.ReadOnly = true;
            this.URLTextBox.Size = new System.Drawing.Size(100, 20);
            this.URLTextBox.TabIndex = 10;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(487, 372);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 11;
            this.BrowseButton.Text = "Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(594, 372);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(75, 23);
            this.UploadButton.TabIndex = 12;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = true;
            // 
            // UploadedTextBox
            // 
            this.UploadedTextBox.Location = new System.Drawing.Point(487, 412);
            this.UploadedTextBox.Name = "UploadedTextBox";
            this.UploadedTextBox.ReadOnly = true;
            this.UploadedTextBox.Size = new System.Drawing.Size(182, 20);
            this.UploadedTextBox.TabIndex = 13;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(206, 130);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 14;
            this.NameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(206, 228);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.DescriptionTextBox.TabIndex = 15;
            // 
            // ModuleListBox
            // 
            this.ModuleListBox.FormattingEnabled = true;
            this.ModuleListBox.Location = new System.Drawing.Point(206, 178);
            this.ModuleListBox.Name = "ModuleListBox";
            this.ModuleListBox.Size = new System.Drawing.Size(100, 17);
            this.ModuleListBox.TabIndex = 16;
            // 
            // ReleaseDateCalendar
            // 
            this.ReleaseDateCalendar.Location = new System.Drawing.Point(133, 308);
            this.ReleaseDateCalendar.Name = "ReleaseDateCalendar";
            this.ReleaseDateCalendar.TabIndex = 17;
            this.ReleaseDateCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // DueDateCalendar
            // 
            this.DueDateCalendar.Location = new System.Drawing.Point(487, 118);
            this.DueDateCalendar.Name = "DueDateCalendar";
            this.DueDateCalendar.TabIndex = 18;
            // 
            // SubmitButton
            // 
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SubmitButton.Location = new System.Drawing.Point(648, 488);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(101, 24);
            this.SubmitButton.TabIndex = 19;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackButton.Location = new System.Drawing.Point(12, 488);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(101, 24);
            this.BackButton.TabIndex = 20;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // BackButtonPictureBox
            // 
            this.BackButtonPictureBox.Location = new System.Drawing.Point(119, 488);
            this.BackButtonPictureBox.Name = "BackButtonPictureBox";
            this.BackButtonPictureBox.Size = new System.Drawing.Size(29, 25);
            this.BackButtonPictureBox.TabIndex = 21;
            this.BackButtonPictureBox.TabStop = false;
            // 
            // CreateNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(761, 524);
            this.Controls.Add(this.BackButtonPictureBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.DueDateCalendar);
            this.Controls.Add(this.ReleaseDateCalendar);
            this.Controls.Add(this.ModuleListBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.UploadedTextBox);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.URLTextBox);
            this.Controls.Add(this.FileUploadTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CanvasURLLabel);
            this.Controls.Add(this.DueDateLabel);
            this.Controls.Add(this.ReleaseDateLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ModuleLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CreateNewLable);
            this.Name = "CreateNewForm";
            this.Text = "Create New Assessment";
            ((System.ComponentModel.ISupportInitialize)(this.BackButtonPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateNewLable;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ModuleLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label ReleaseDateLabel;
        private System.Windows.Forms.Label DueDateLabel;
        private System.Windows.Forms.Label CanvasURLLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileUploadTextBox;
        private System.Windows.Forms.TextBox URLTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.TextBox UploadedTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.ListBox ModuleListBox;
        private System.Windows.Forms.MonthCalendar ReleaseDateCalendar;
        private System.Windows.Forms.MonthCalendar DueDateCalendar;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox BackButtonPictureBox;
    }
}