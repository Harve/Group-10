﻿namespace UserInterface
{
    partial class ModuleTeam_HomeForm
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
            this.notificationButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.uploadButton = new System.Windows.Forms.Button();
            this.assesmentOverviewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module Team";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(34, 395);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(194, 33);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // notificationButton
            // 
            this.notificationButton.Location = new System.Drawing.Point(572, 395);
            this.notificationButton.Name = "notificationButton";
            this.notificationButton.Size = new System.Drawing.Size(194, 33);
            this.notificationButton.TabIndex = 2;
            this.notificationButton.Text = "Notifications";
            this.notificationButton.UseVisualStyleBackColor = true;
            this.notificationButton.Click += new System.EventHandler(this.notificationButton_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(50, 147);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(189, 89);
            this.downloadButton.TabIndex = 3;
            this.downloadButton.Text = "Download Assesment/Scrutiny Form";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(303, 147);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(189, 89);
            this.uploadButton.TabIndex = 4;
            this.uploadButton.Text = "Create Assesment";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // assesmentOverviewButton
            // 
            this.assesmentOverviewButton.Location = new System.Drawing.Point(552, 147);
            this.assesmentOverviewButton.Name = "assesmentOverviewButton";
            this.assesmentOverviewButton.Size = new System.Drawing.Size(189, 89);
            this.assesmentOverviewButton.TabIndex = 5;
            this.assesmentOverviewButton.Text = "View Assesment Scrutiny Progress";
            this.assesmentOverviewButton.UseVisualStyleBackColor = true;
            this.assesmentOverviewButton.Click += new System.EventHandler(this.assesmentOverviewButton_Click);
            // 
            // ModuleTeam_HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.assesmentOverviewButton);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.notificationButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Name = "ModuleTeam_HomeForm";
            this.Text = "ModuleTeam_HomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button notificationButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Button assesmentOverviewButton;
    }
}