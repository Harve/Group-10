namespace UserInterface
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.headerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIdPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uohLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Location = new System.Drawing.Point(327, 245);
            this.userIdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(228, 22);
            this.userIdTextBox.TabIndex = 0;
            this.userIdTextBox.TextChanged += new System.EventHandler(this.userIdTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(327, 294);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(228, 22);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // logOnButton
            // 
            this.logOnButton.Location = new System.Drawing.Point(477, 340);
            this.logOnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logOnButton.Name = "logOnButton";
            this.logOnButton.Size = new System.Drawing.Size(79, 31);
            this.logOnButton.TabIndex = 2;
            this.logOnButton.Text = "Login";
            this.logOnButton.UseVisualStyleBackColor = true;
            this.logOnButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // headerPictureBox
            // 
            this.headerPictureBox.Location = new System.Drawing.Point(240, 38);
            this.headerPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.headerPictureBox.Name = "headerPictureBox";
            this.headerPictureBox.Size = new System.Drawing.Size(388, 167);
            this.headerPictureBox.TabIndex = 3;
            this.headerPictureBox.TabStop = false;
            this.headerPictureBox.Click += new System.EventHandler(this.headerPictureBox_Click);
            // 
            // userIdPictureBox
            // 
            this.userIdPictureBox.Location = new System.Drawing.Point(275, 245);
            this.userIdPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userIdPictureBox.Name = "userIdPictureBox";
            this.userIdPictureBox.Size = new System.Drawing.Size(44, 25);
            this.userIdPictureBox.TabIndex = 4;
            this.userIdPictureBox.TabStop = false;
            this.userIdPictureBox.Click += new System.EventHandler(this.userIdPictureBox_Click);
            // 
            // passwordPictureBox
            // 
            this.passwordPictureBox.Location = new System.Drawing.Point(275, 294);
            this.passwordPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordPictureBox.Name = "passwordPictureBox";
            this.passwordPictureBox.Size = new System.Drawing.Size(44, 25);
            this.passwordPictureBox.TabIndex = 5;
            this.passwordPictureBox.TabStop = false;
            // 
            // uohLogoPictureBox
            // 
            this.uohLogoPictureBox.Location = new System.Drawing.Point(37, 457);
            this.uohLogoPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uohLogoPictureBox.Name = "uohLogoPictureBox";
            this.uohLogoPictureBox.Size = new System.Drawing.Size(188, 110);
            this.uohLogoPictureBox.TabIndex = 6;
            this.uohLogoPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 249);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "User ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(520, 44);
            this.label3.TabIndex = 9;
            this.label3.Text = "Assesment Scrutiny System";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LogOnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(885, 596);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uohLogoPictureBox);
            this.Controls.Add(this.passwordPictureBox);
            this.Controls.Add(this.userIdPictureBox);
            this.Controls.Add(this.headerPictureBox);
            this.Controls.Add(this.logOnButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userIdTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

