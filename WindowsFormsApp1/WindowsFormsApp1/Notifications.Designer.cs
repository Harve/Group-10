namespace UserInterface
{
    partial class Notifications
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
            this.DateNotifiedTitle = new System.Windows.Forms.Label();
            this.DateNotifiedLabelBox = new System.Windows.Forms.Label();
            this.ModuleTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ActionsTitle = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MarkAsReadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateNotifiedTitle
            // 
            this.DateNotifiedTitle.AutoSize = true;
            this.DateNotifiedTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DateNotifiedTitle.Location = new System.Drawing.Point(43, 22);
            this.DateNotifiedTitle.Name = "DateNotifiedTitle";
            this.DateNotifiedTitle.Size = new System.Drawing.Size(90, 17);
            this.DateNotifiedTitle.TabIndex = 0;
            this.DateNotifiedTitle.Text = "Date Notified";
            // 
            // DateNotifiedLabelBox
            // 
            this.DateNotifiedLabelBox.AutoSize = true;
            this.DateNotifiedLabelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DateNotifiedLabelBox.Location = new System.Drawing.Point(2, 60);
            this.DateNotifiedLabelBox.Name = "DateNotifiedLabelBox";
            this.DateNotifiedLabelBox.Size = new System.Drawing.Size(196, 17);
            this.DateNotifiedLabelBox.TabIndex = 1;
            this.DateNotifiedLabelBox.Text = "Placeholder Date Notified Box";
            // 
            // ModuleTitle
            // 
            this.ModuleTitle.AutoSize = true;
            this.ModuleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ModuleTitle.Location = new System.Drawing.Point(272, 22);
            this.ModuleTitle.Name = "ModuleTitle";
            this.ModuleTitle.Size = new System.Drawing.Size(54, 17);
            this.ModuleTitle.TabIndex = 2;
            this.ModuleTitle.Text = "Module";
            this.ModuleTitle.Click += new System.EventHandler(this.ModuleTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(223, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Placeholder Module Box";
            // 
            // ActionsTitle
            // 
            this.ActionsTitle.AutoSize = true;
            this.ActionsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ActionsTitle.Location = new System.Drawing.Point(461, 22);
            this.ActionsTitle.Name = "ActionsTitle";
            this.ActionsTitle.Size = new System.Drawing.Size(54, 17);
            this.ActionsTitle.TabIndex = 4;
            this.ActionsTitle.Text = "Actions";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(501, 51);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(59, 35);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // MarkAsReadButton
            // 
            this.MarkAsReadButton.Location = new System.Drawing.Point(436, 51);
            this.MarkAsReadButton.Name = "MarkAsReadButton";
            this.MarkAsReadButton.Size = new System.Drawing.Size(59, 35);
            this.MarkAsReadButton.TabIndex = 7;
            this.MarkAsReadButton.Text = "Mark as Read";
            this.MarkAsReadButton.UseVisualStyleBackColor = true;
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(572, 481);
            this.Controls.Add(this.MarkAsReadButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ActionsTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModuleTitle);
            this.Controls.Add(this.DateNotifiedLabelBox);
            this.Controls.Add(this.DateNotifiedTitle);
            this.Name = "Notifications";
            this.Text = "Notifications";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateNotifiedTitle;
        private System.Windows.Forms.Label DateNotifiedLabelBox;
        private System.Windows.Forms.Label ModuleTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ActionsTitle;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button MarkAsReadButton;
    }
}