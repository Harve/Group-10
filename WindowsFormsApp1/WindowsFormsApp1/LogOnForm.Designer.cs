namespace WindowsFormsApp1
{
    partial class LogOnForm
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
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.logOnButton = new System.Windows.Forms.Button();
            this.headerPictureBox = new System.Windows.Forms.PictureBox();
            this.userIdPictureBox = new System.Windows.Forms.PictureBox();
            this.passwordPictureBox = new System.Windows.Forms.PictureBox();
            this.uohLogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.headerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIdPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uohLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Location = new System.Drawing.Point(245, 199);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(172, 20);
            this.userIdTextBox.TabIndex = 0;
            this.userIdTextBox.Text = "User ID";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(245, 239);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(172, 20);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // logOnButton
            // 
            this.logOnButton.Location = new System.Drawing.Point(358, 276);
            this.logOnButton.Name = "logOnButton";
            this.logOnButton.Size = new System.Drawing.Size(59, 25);
            this.logOnButton.TabIndex = 2;
            this.logOnButton.Text = "Log-On";
            this.logOnButton.UseVisualStyleBackColor = true;
            this.logOnButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // headerPictureBox
            // 
            this.headerPictureBox.Location = new System.Drawing.Point(179, 28);
            this.headerPictureBox.Name = "headerPictureBox";
            this.headerPictureBox.Size = new System.Drawing.Size(291, 136);
            this.headerPictureBox.TabIndex = 3;
            this.headerPictureBox.TabStop = false;
            this.headerPictureBox.Click += new System.EventHandler(this.headerPictureBox_Click);
            // 
            // userIdPictureBox
            // 
            this.userIdPictureBox.Location = new System.Drawing.Point(206, 199);
            this.userIdPictureBox.Name = "userIdPictureBox";
            this.userIdPictureBox.Size = new System.Drawing.Size(33, 20);
            this.userIdPictureBox.TabIndex = 4;
            this.userIdPictureBox.TabStop = false;
            // 
            // passwordPictureBox
            // 
            this.passwordPictureBox.Location = new System.Drawing.Point(206, 239);
            this.passwordPictureBox.Name = "passwordPictureBox";
            this.passwordPictureBox.Size = new System.Drawing.Size(33, 20);
            this.passwordPictureBox.TabIndex = 5;
            this.passwordPictureBox.TabStop = false;
            // 
            // uohLogoPictureBox
            // 
            this.uohLogoPictureBox.Location = new System.Drawing.Point(28, 371);
            this.uohLogoPictureBox.Name = "uohLogoPictureBox";
            this.uohLogoPictureBox.Size = new System.Drawing.Size(141, 89);
            this.uohLogoPictureBox.TabIndex = 6;
            this.uohLogoPictureBox.TabStop = false;
            // 
            // LogOnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(664, 484);
            this.Controls.Add(this.uohLogoPictureBox);
            this.Controls.Add(this.passwordPictureBox);
            this.Controls.Add(this.userIdPictureBox);
            this.Controls.Add(this.headerPictureBox);
            this.Controls.Add(this.logOnButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userIdTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LogOnForm";
            this.Text = "Log-In";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIdPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uohLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button logOnButton;
        private System.Windows.Forms.PictureBox headerPictureBox;
        private System.Windows.Forms.PictureBox userIdPictureBox;
        private System.Windows.Forms.PictureBox passwordPictureBox;
        private System.Windows.Forms.PictureBox uohLogoPictureBox;
    }
}

