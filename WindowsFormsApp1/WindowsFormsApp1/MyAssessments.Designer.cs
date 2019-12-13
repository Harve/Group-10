namespace UserInterface
{
    partial class MyAssessments
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
            this.MyAssessmentsLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.BackButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AssessmentViewer = new System.Windows.Forms.DataGridView();
            this.Assessment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssessmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Module = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditStatus = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BackButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // MyAssessmentsLabel
            // 
            this.MyAssessmentsLabel.AutoSize = true;
            this.MyAssessmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.MyAssessmentsLabel.Location = new System.Drawing.Point(243, 9);
            this.MyAssessmentsLabel.Name = "MyAssessmentsLabel";
            this.MyAssessmentsLabel.Size = new System.Drawing.Size(220, 31);
            this.MyAssessmentsLabel.TabIndex = 2;
            this.MyAssessmentsLabel.Text = "My Assessments";
            this.MyAssessmentsLabel.Click += new System.EventHandler(this.CreateNewLable_Click);
            // 
            // BackButton
            // 
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackButton.Location = new System.Drawing.Point(12, 459);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(101, 24);
            this.BackButton.TabIndex = 21;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BackButtonPictureBox
            // 
            this.BackButtonPictureBox.Location = new System.Drawing.Point(119, 459);
            this.BackButtonPictureBox.Name = "BackButtonPictureBox";
            this.BackButtonPictureBox.Size = new System.Drawing.Size(29, 25);
            this.BackButtonPictureBox.TabIndex = 22;
            this.BackButtonPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            // 
            // AssessmentViewer
            // 
            this.AssessmentViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssessmentViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Assessment,
            this.AssessmentName,
            this.Module,
            this.DueDate,
            this.Status,
            this.EditStatus});
            this.AssessmentViewer.Location = new System.Drawing.Point(37, 103);
            this.AssessmentViewer.Name = "AssessmentViewer";
            this.AssessmentViewer.Size = new System.Drawing.Size(676, 298);
            this.AssessmentViewer.TabIndex = 27;
            // 
            // Assessment
            // 
            this.Assessment.HeaderText = "Assessment";
            this.Assessment.Name = "Assessment";
            // 
            // AssessmentName
            // 
            this.AssessmentName.HeaderText = "AssessmentName";
            this.AssessmentName.Name = "AssessmentName";
            // 
            // Module
            // 
            this.Module.HeaderText = "Module";
            this.Module.Name = "Module";
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "Due Date";
            this.DueDate.Name = "DueDate";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // EditStatus
            // 
            this.EditStatus.HeaderText = "EditStatus";
            this.EditStatus.Name = "EditStatus";
            this.EditStatus.Text = "Edit Status";
            // 
            // MyAssessments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 495);
            this.Controls.Add(this.AssessmentViewer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButtonPictureBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.MyAssessmentsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MyAssessments";
            this.Text = "My Assessments";
            this.Load += new System.EventHandler(this.MyAssessments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MyAssessmentsLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox BackButtonPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AssessmentViewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assessment;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssessmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Module;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn EditStatus;
    }
}