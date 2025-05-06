namespace Euro_2004_Tickets
{
    partial class Euro2024Tickets
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
            catA = new Button();
            catB = new Button();
            catC = new Button();
            adultCounter = new Label();
            btnPay = new Button();
            btnPlusAdult = new Button();
            btnMunisAdult = new Button();
            btnMunisChild = new Button();
            btnPlusChild = new Button();
            childCounter = new Label();
            lblPrice = new Label();
            price = new Label();
            quit = new Button();
            money = new Label();
            LogOut = new Button();
            SuspendLayout();
            // 
            // catA
            // 
            catA.BackColor = Color.Transparent;
            catA.Cursor = Cursors.Hand;
            catA.FlatAppearance.BorderSize = 0;
            catA.FlatAppearance.MouseDownBackColor = Color.Transparent;
            catA.FlatAppearance.MouseOverBackColor = Color.Transparent;
            catA.FlatStyle = FlatStyle.Flat;
            catA.Image = Properties.Resources.btnCategoryA;
            catA.Location = new Point(177, 225);
            catA.Name = "catA";
            catA.Size = new Size(170, 255);
            catA.TabIndex = 0;
            catA.UseVisualStyleBackColor = false;
            catA.Click += catA_Click;
            // 
            // catB
            // 
            catB.BackColor = Color.Transparent;
            catB.Cursor = Cursors.Hand;
            catB.FlatAppearance.BorderColor = Color.DarkBlue;
            catB.FlatAppearance.BorderSize = 0;
            catB.FlatAppearance.MouseDownBackColor = Color.Transparent;
            catB.FlatAppearance.MouseOverBackColor = Color.Transparent;
            catB.FlatStyle = FlatStyle.Flat;
            catB.Image = Properties.Resources.btnCategoryB1;
            catB.Location = new Point(464, 227);
            catB.Name = "catB";
            catB.Size = new Size(170, 255);
            catB.TabIndex = 1;
            catB.UseVisualStyleBackColor = false;
            catB.Click += catB_Click;
            // 
            // catC
            // 
            catC.BackColor = Color.Transparent;
            catC.Cursor = Cursors.Hand;
            catC.FlatAppearance.BorderColor = Color.DarkBlue;
            catC.FlatAppearance.BorderSize = 0;
            catC.FlatAppearance.MouseDownBackColor = Color.Transparent;
            catC.FlatAppearance.MouseOverBackColor = Color.Transparent;
            catC.FlatStyle = FlatStyle.Flat;
            catC.Image = Properties.Resources.btnCategoryC1;
            catC.Location = new Point(754, 227);
            catC.Name = "catC";
            catC.Size = new Size(170, 255);
            catC.TabIndex = 2;
            catC.UseVisualStyleBackColor = false;
            catC.Click += catC_Click;
            // 
            // adultCounter
            // 
            adultCounter.AutoSize = true;
            adultCounter.BackColor = Color.Transparent;
            adultCounter.Font = new Font("ITC Avant Garde Gothic LT", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adultCounter.ForeColor = Color.FromArgb(33, 49, 103);
            adultCounter.Location = new Point(365, 581);
            adultCounter.Name = "adultCounter";
            adultCounter.Size = new Size(52, 57);
            adultCounter.TabIndex = 3;
            adultCounter.Text = "0";
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.Transparent;
            btnPay.BackgroundImage = Properties.Resources.btnPay1;
            btnPay.Cursor = Cursors.Hand;
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPay.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Image = Properties.Resources.btnPay1;
            btnPay.Location = new Point(401, 672);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(297, 69);
            btnPay.TabIndex = 5;
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnPlusAdult
            // 
            btnPlusAdult.BackColor = Color.Transparent;
            btnPlusAdult.Cursor = Cursors.Hand;
            btnPlusAdult.FlatAppearance.BorderSize = 0;
            btnPlusAdult.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPlusAdult.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPlusAdult.FlatStyle = FlatStyle.Flat;
            btnPlusAdult.Image = Properties.Resources.btnPlus;
            btnPlusAdult.Location = new Point(428, 585);
            btnPlusAdult.Name = "btnPlusAdult";
            btnPlusAdult.Size = new Size(27, 47);
            btnPlusAdult.TabIndex = 6;
            btnPlusAdult.UseVisualStyleBackColor = false;
            btnPlusAdult.Click += btnPlusAdult_Click;
            // 
            // btnMunisAdult
            // 
            btnMunisAdult.BackColor = Color.Transparent;
            btnMunisAdult.Cursor = Cursors.Hand;
            btnMunisAdult.FlatAppearance.BorderSize = 0;
            btnMunisAdult.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMunisAdult.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMunisAdult.FlatStyle = FlatStyle.Flat;
            btnMunisAdult.Image = Properties.Resources.btnMunis1;
            btnMunisAdult.Location = new Point(327, 589);
            btnMunisAdult.Name = "btnMunisAdult";
            btnMunisAdult.Size = new Size(27, 47);
            btnMunisAdult.TabIndex = 7;
            btnMunisAdult.UseVisualStyleBackColor = false;
            btnMunisAdult.Click += btnMunisAdult_Click;
            // 
            // btnMunisChild
            // 
            btnMunisChild.BackColor = Color.Transparent;
            btnMunisChild.Cursor = Cursors.Hand;
            btnMunisChild.FlatAppearance.BorderSize = 0;
            btnMunisChild.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMunisChild.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMunisChild.FlatStyle = FlatStyle.Flat;
            btnMunisChild.Image = Properties.Resources.btnMunis1;
            btnMunisChild.Location = new Point(639, 588);
            btnMunisChild.Name = "btnMunisChild";
            btnMunisChild.Size = new Size(27, 47);
            btnMunisChild.TabIndex = 10;
            btnMunisChild.UseVisualStyleBackColor = false;
            btnMunisChild.Click += btnMunisChild_Click;
            // 
            // btnPlusChild
            // 
            btnPlusChild.BackColor = Color.Transparent;
            btnPlusChild.Cursor = Cursors.Hand;
            btnPlusChild.FlatAppearance.BorderSize = 0;
            btnPlusChild.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPlusChild.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPlusChild.FlatStyle = FlatStyle.Flat;
            btnPlusChild.Image = Properties.Resources.btnPlus;
            btnPlusChild.Location = new Point(741, 587);
            btnPlusChild.Name = "btnPlusChild";
            btnPlusChild.Size = new Size(27, 47);
            btnPlusChild.TabIndex = 9;
            btnPlusChild.UseVisualStyleBackColor = false;
            btnPlusChild.Click += btnPlusChild_Click;
            // 
            // childCounter
            // 
            childCounter.AutoSize = true;
            childCounter.BackColor = Color.Transparent;
            childCounter.Font = new Font("ITC Avant Garde Gothic LT", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            childCounter.ForeColor = Color.FromArgb(33, 49, 103);
            childCounter.Location = new Point(675, 582);
            childCounter.Name = "childCounter";
            childCounter.Size = new Size(52, 57);
            childCounter.TabIndex = 8;
            childCounter.Text = "0";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("LT Sonoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.FromArgb(33, 49, 103);
            lblPrice.Location = new Point(880, 746);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(129, 54);
            lblPrice.TabIndex = 11;
            lblPrice.Text = "Price :";
            // 
            // price
            // 
            price.AutoSize = true;
            price.BackColor = Color.Transparent;
            price.Font = new Font("LT Sonoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            price.ForeColor = Color.FromArgb(33, 49, 103);
            price.Location = new Point(997, 746);
            price.Name = "price";
            price.Size = new Size(46, 54);
            price.TabIndex = 12;
            price.Text = "0";
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
            quit.TabIndex = 13;
            quit.UseVisualStyleBackColor = false;
            quit.Click += quit_Click;
            // 
            // money
            // 
            money.AutoSize = true;
            money.BackColor = Color.Transparent;
            money.Font = new Font("LT Sonoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            money.ForeColor = Color.FromArgb(33, 49, 103);
            money.Location = new Point(1045, 746);
            money.Name = "money";
            money.Size = new Size(46, 54);
            money.TabIndex = 14;
            money.Text = "$";
            // 
            // LogOut
            // 
            LogOut.BackColor = Color.Transparent;
            LogOut.Cursor = Cursors.Hand;
            LogOut.FlatAppearance.BorderSize = 0;
            LogOut.FlatAppearance.MouseDownBackColor = Color.Transparent;
            LogOut.FlatAppearance.MouseOverBackColor = Color.Transparent;
            LogOut.FlatStyle = FlatStyle.Flat;
            LogOut.Image = Properties.Resources.LogOut;
            LogOut.Location = new Point(25, 26);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(145, 50);
            LogOut.TabIndex = 15;
            LogOut.UseVisualStyleBackColor = false;
            LogOut.Click += LogOut_Click;
            // 
            // Euro2024Tickets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.Euro_2024_Tickets_bcg_2;
            ClientSize = new Size(1100, 800);
            Controls.Add(LogOut);
            Controls.Add(money);
            Controls.Add(quit);
            Controls.Add(price);
            Controls.Add(lblPrice);
            Controls.Add(btnMunisChild);
            Controls.Add(btnPlusChild);
            Controls.Add(childCounter);
            Controls.Add(btnMunisAdult);
            Controls.Add(btnPlusAdult);
            Controls.Add(btnPay);
            Controls.Add(adultCounter);
            Controls.Add(catC);
            Controls.Add(catB);
            Controls.Add(catA);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Euro2024Tickets";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Euro2024Tickets";
            Load += Euro2024Tickets_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button catA;
        private Button catB;
        private Button catC;
        private Label adultCounter;
        private Button btnPay;
        private Button btnPlusAdult;
        private Button btnMunisAdult;
        private Button btnMunisChild;
        private Button btnPlusChild;
        private Label childCounter;
        private Label lblPrice;
        private Label price;
        private Button quit;
        private Label money;
        private Button LogOut;
    }
}
