namespace Euro_2004_Tickets
{
    partial class Login
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
            quit = new Button();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            btnConnection = new Button();
            facebookLogin = new Button();
            emailLogin = new Button();
            googleLogin = new Button();
            SuspendLayout();
            // 
            // quit
            // 
            quit.BackColor = Color.LightGreen;
            quit.Cursor = Cursors.Hand;
            quit.FlatStyle = FlatStyle.Flat;
            quit.Font = new Font("Bahij Helvetica Neue 75 Bold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quit.ForeColor = Color.FromArgb(33, 49, 103);
            quit.Image = Properties.Resources.exit;
            quit.Location = new Point(1037, 0);
            quit.Name = "quit";
            quit.Size = new Size(63, 63);
            quit.TabIndex = 14;
            quit.UseVisualStyleBackColor = false;
            quit.Click += quit_Click;
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Kozuka Gothic Pro B", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(465, 282);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(452, 52);
            tbEmail.TabIndex = 15;
            tbEmail.Text = "admin@admin";
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Cursor = Cursors.IBeam;
            tbPassword.Font = new Font("Kozuka Gothic Pro B", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 128);
            tbPassword.Location = new Point(465, 361);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(452, 52);
            tbPassword.TabIndex = 16;
            tbPassword.Text = "admin";
            // 
            // btnConnection
            // 
            btnConnection.BackColor = Color.Transparent;
            btnConnection.Cursor = Cursors.Hand;
            btnConnection.FlatAppearance.BorderSize = 0;
            btnConnection.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnConnection.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnConnection.FlatStyle = FlatStyle.Flat;
            btnConnection.Location = new Point(404, 466);
            btnConnection.Name = "btnConnection";
            btnConnection.Size = new Size(290, 70);
            btnConnection.TabIndex = 17;
            btnConnection.UseVisualStyleBackColor = false;
            btnConnection.Click += btnConnection_Click;
            // 
            // facebookLogin
            // 
            facebookLogin.BackColor = Color.Transparent;
            facebookLogin.Cursor = Cursors.Hand;
            facebookLogin.FlatAppearance.BorderSize = 0;
            facebookLogin.FlatAppearance.CheckedBackColor = Color.Transparent;
            facebookLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            facebookLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            facebookLogin.FlatStyle = FlatStyle.Flat;
            facebookLogin.Image = Properties.Resources.facebookLogin;
            facebookLogin.Location = new Point(523, 654);
            facebookLogin.Name = "facebookLogin";
            facebookLogin.Size = new Size(59, 59);
            facebookLogin.TabIndex = 18;
            facebookLogin.UseVisualStyleBackColor = false;
            // 
            // emailLogin
            // 
            emailLogin.BackColor = Color.Transparent;
            emailLogin.Cursor = Cursors.Hand;
            emailLogin.FlatAppearance.BorderSize = 0;
            emailLogin.FlatAppearance.CheckedBackColor = Color.Transparent;
            emailLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            emailLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            emailLogin.FlatStyle = FlatStyle.Flat;
            emailLogin.Image = Properties.Resources.emailLogin;
            emailLogin.Location = new Point(610, 654);
            emailLogin.Name = "emailLogin";
            emailLogin.Size = new Size(59, 59);
            emailLogin.TabIndex = 19;
            emailLogin.UseVisualStyleBackColor = false;
            emailLogin.Click += emailLogin_Click;
            // 
            // googleLogin
            // 
            googleLogin.BackColor = Color.Transparent;
            googleLogin.Cursor = Cursors.Hand;
            googleLogin.FlatAppearance.BorderSize = 0;
            googleLogin.FlatAppearance.CheckedBackColor = Color.Transparent;
            googleLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            googleLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            googleLogin.FlatStyle = FlatStyle.Flat;
            googleLogin.Image = Properties.Resources.googleLogin;
            googleLogin.Location = new Point(431, 653);
            googleLogin.Name = "googleLogin";
            googleLogin.Size = new Size(59, 59);
            googleLogin.TabIndex = 20;
            googleLogin.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Euro_2024_Tickets___Login_page;
            ClientSize = new Size(1100, 800);
            Controls.Add(googleLogin);
            Controls.Add(emailLogin);
            Controls.Add(facebookLogin);
            Controls.Add(btnConnection);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(quit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button quit;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private Button btnConnection;
        private Button facebookLogin;
        private Button emailLogin;
        private Button googleLogin;
    }
}