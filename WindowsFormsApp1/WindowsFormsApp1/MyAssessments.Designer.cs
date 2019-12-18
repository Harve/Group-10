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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Programme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Module = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assesment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModuleTeamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BackButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MyAssessmentsLabel
            // 
            this.MyAssessmentsLabel.AutoSize = true;
            this.MyAssessmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.MyAssessmentsLabel.Location = new System.Drawing.Point(324, 11);
            this.MyAssessmentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MyAssessmentsLabel.Name = "MyAssessmentsLabel";
            this.MyAssessmentsLabel.Size = new System.Drawing.Size(273, 39);
            this.MyAssessmentsLabel.TabIndex = 2;
            this.MyAssessmentsLabel.Text = "My Assessments";
            this.MyAssessmentsLabel.Click += new System.EventHandler(this.CreateNewLable_Click);
            // 
            // BackButton
            // 
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackButton.Location = new System.Drawing.Point(16, 565);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(135, 30);
            this.BackButton.TabIndex = 21;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BackButtonPictureBox
            // 
            this.BackButtonPictureBox.Location = new System.Drawing.Point(159, 565);
            this.BackButtonPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackButtonPictureBox.Name = "BackButtonPictureBox";
            this.BackButtonPictureBox.Size = new System.Drawing.Size(39, 31);
            this.BackButtonPictureBox.TabIndex = 22;
            this.BackButtonPictureBox.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Programme,
            this.Module,
            this.Assesment,
            this.ModuleTeamID,
            this.lastStep,
            this.nextStep});
            this.dataGridView1.Location = new System.Drawing.Point(28, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(934, 286);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Programme
            // 
            this.Programme.HeaderText = "Programme";
            this.Programme.Name = "Programme";
            // 
            // Module
            // 
            this.Module.HeaderText = "Module";
            this.Module.Name = "Module";
            // 
            // Assesment
            // 
            this.Assesment.HeaderText = "Assesment";
            this.Assesment.Name = "Assesment";
            // 
            // ModuleTeamID
            // 
            this.ModuleTeamID.HeaderText = "Module Team Member";
            this.ModuleTeamID.Name = "ModuleTeamID";
            // 
            // lastStep
            // 
            this.lastStep.HeaderText = "Last Completed Step";
            this.lastStep.Name = "lastStep";
            // 
            // nextStep
            // 
            this.nextStep.HeaderText = "Next Step to Complete";
            this.nextStep.Name = "nextStep";
            // 
            // MyAssessments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 609);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BackButtonPictureBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.MyAssessmentsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MyAssessments";
            this.Text = "My Assessments";
            this.Load += new System.EventHandler(this.MyAssessments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MyAssessmentsLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox BackButtonPictureBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Programme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Module;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assesment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleTeamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextStep;
    }
}