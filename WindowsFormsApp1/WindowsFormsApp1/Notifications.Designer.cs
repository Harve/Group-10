﻿namespace UserInterface
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
            this.ActionsTitle = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MarkAsReadButton = new System.Windows.Forms.Button();
            this.NotificationGrid = new System.Windows.Forms.DataGridView();
            this.SendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationGrid)).BeginInit();
            this.SuspendLayout();
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
            // NotificationGrid
            // 
            this.NotificationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotificationGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SendDate,
            this.Message,
            this.Sender});
            this.NotificationGrid.Location = new System.Drawing.Point(35, 116);
            this.NotificationGrid.Name = "NotificationGrid";
            this.NotificationGrid.Size = new System.Drawing.Size(493, 211);
            this.NotificationGrid.TabIndex = 8;
            this.NotificationGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SendDate
            // 
            this.SendDate.HeaderText = "Date";
            this.SendDate.Name = "SendDate";
            // 
            // Message
            // 
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            this.Message.Width = 250;
            // 
            // Sender
            // 
            this.Sender.HeaderText = "Sender";
            this.Sender.Name = "Sender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Notifications";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(572, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NotificationGrid);
            this.Controls.Add(this.MarkAsReadButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ActionsTitle);
            this.Name = "Notifications";
            this.Text = "Notifications";
            ((System.ComponentModel.ISupportInitialize)(this.NotificationGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ActionsTitle;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button MarkAsReadButton;
        private System.Windows.Forms.DataGridView NotificationGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}