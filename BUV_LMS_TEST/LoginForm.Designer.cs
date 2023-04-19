namespace BUV_LMS_TEST
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Username = new Label();
            Password = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            loginPanel = new Panel();
            btnLogIn = new Button();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Username
            // 
            Username.Anchor = AnchorStyles.None;
            Username.AutoSize = true;
            Username.Location = new Point(9, 10);
            Username.Name = "Username";
            Username.Size = new Size(63, 15);
            Username.TabIndex = 0;
            Username.Text = "Username:";
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.None;
            Password.AutoSize = true;
            Password.Location = new Point(9, 44);
            Password.Name = "Password";
            Password.Size = new Size(63, 15);
            Password.TabIndex = 0;
            Password.Text = "Password: ";
            // 
            // tbUsername
            // 
            tbUsername.Anchor = AnchorStyles.None;
            tbUsername.Location = new Point(78, 7);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(207, 23);
            tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.None;
            tbPassword.Location = new Point(78, 36);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(207, 23);
            tbPassword.TabIndex = 1;
            // 
            // loginPanel
            // 
            loginPanel.Anchor = AnchorStyles.None;
            loginPanel.Controls.Add(btnLogIn);
            loginPanel.Controls.Add(tbPassword);
            loginPanel.Controls.Add(tbUsername);
            loginPanel.Controls.Add(Username);
            loginPanel.Controls.Add(Password);
            loginPanel.Location = new Point(531, 274);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(297, 92);
            loginPanel.TabIndex = 2;
            loginPanel.Paint += loginPanel_Paint;
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.None;
            btnLogIn.Location = new Point(92, 65);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(92, 23);
            btnLogIn.TabIndex = 2;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1964, 985);
            Controls.Add(loginPanel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Username;
        private Label Password;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Panel loginPanel;
        private Button btnLogIn;
    }
}