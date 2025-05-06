namespace Euro_2004_Tickets
{
    partial class SignUpForm
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
            create = new Button();
            createEmail = new TextBox();
            createFullName = new TextBox();
            createUsername = new TextBox();
            createBirthday = new TextBox();
            createPassword = new TextBox();
            createRePassword = new TextBox();
            quit = new Button();
            SuspendLayout();
            // 
            // create
            // 
            create.BackColor = Color.Transparent;
            create.FlatAppearance.BorderSize = 0;
            create.FlatAppearance.MouseDownBackColor = Color.Transparent;
            create.FlatAppearance.MouseOverBackColor = Color.Transparent;
            create.FlatStyle = FlatStyle.Flat;
            create.Image = Properties.Resources.Create;
            create.Location = new Point(414, 715);
            create.Name = "create";
            create.Size = new Size(271, 61);
            create.TabIndex = 6;
            create.UseVisualStyleBackColor = false;
            create.Click += create_Click;
            // 
            // createEmail
            // 
            createEmail.BorderStyle = BorderStyle.None;
            createEmail.Cursor = Cursors.IBeam;
            createEmail.Font = new Font("Kozuka Gothic Pro R", 22.2F);
            createEmail.Location = new Point(458, 241);
            createEmail.Multiline = true;
            createEmail.Name = "createEmail";
            createEmail.Size = new Size(464, 53);
            createEmail.TabIndex = 7;
            // 
            // createFullName
            // 
            createFullName.BorderStyle = BorderStyle.None;
            createFullName.Cursor = Cursors.IBeam;
            createFullName.Font = new Font("Kozuka Gothic Pro R", 22.2F);
            createFullName.Location = new Point(458, 318);
            createFullName.Multiline = true;
            createFullName.Name = "createFullName";
            createFullName.Size = new Size(464, 53);
            createFullName.TabIndex = 8;
            // 
            // createUsername
            // 
            createUsername.BorderStyle = BorderStyle.None;
            createUsername.Cursor = Cursors.IBeam;
            createUsername.Font = new Font("Kozuka Gothic Pro R", 22.2F);
            createUsername.Location = new Point(458, 396);
            createUsername.Multiline = true;
            createUsername.Name = "createUsername";
            createUsername.Size = new Size(464, 53);
            createUsername.TabIndex = 9;
            // 
            // createBirthday
            // 
            createBirthday.BorderStyle = BorderStyle.None;
            createBirthday.Cursor = Cursors.IBeam;
            createBirthday.Font = new Font("Kozuka Gothic Pro R", 22.2F);
            createBirthday.Location = new Point(458, 473);
            createBirthday.Multiline = true;
            createBirthday.Name = "createBirthday";
            createBirthday.Size = new Size(464, 53);
            createBirthday.TabIndex = 10;
            // 
            // createPassword
            // 
            createPassword.BorderStyle = BorderStyle.None;
            createPassword.Cursor = Cursors.IBeam;
            createPassword.Font = new Font("Kozuka Gothic Pro R", 22.2F);
            createPassword.Location = new Point(458, 551);
            createPassword.Multiline = true;
            createPassword.Name = "createPassword";
            createPassword.Size = new Size(464, 53);
            createPassword.TabIndex = 11;
            // 
            // createRePassword
            // 
            createRePassword.BorderStyle = BorderStyle.None;
            createRePassword.Cursor = Cursors.IBeam;
            createRePassword.Font = new Font("Kozuka Gothic Pro R", 22.2F);
            createRePassword.Location = new Point(458, 628);
            createRePassword.Multiline = true;
            createRePassword.Name = "createRePassword";
            createRePassword.Size = new Size(464, 53);
            createRePassword.TabIndex = 12;
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
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SignUp_Page_bcg;
            ClientSize = new Size(1100, 800);
            Controls.Add(quit);
            Controls.Add(createRePassword);
            Controls.Add(createPassword);
            Controls.Add(createBirthday);
            Controls.Add(createUsername);
            Controls.Add(createFullName);
            Controls.Add(createEmail);
            Controls.Add(create);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button create;
        private TextBox createEmail;
        private TextBox createFullName;
        private TextBox createUsername;
        private TextBox createBirthday;
        private TextBox createPassword;
        private TextBox createRePassword;
        private Button quit;
    }
}