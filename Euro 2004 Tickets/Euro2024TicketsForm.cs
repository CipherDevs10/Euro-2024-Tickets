using System.Security.Cryptography.X509Certificates;

namespace Euro_2004_Tickets
{
    public partial class Euro2024Tickets : Form
    {
        public Euro2024Tickets()
        {
            InitializeComponent();
        }
        int CatSelect = 0;
        public void priceCalculate()
        {
            double amountPrice = Convert.ToDouble(price.Text);
            int childTickets = Convert.ToInt32(childCounter.Text);
            int adultTickets = Convert.ToInt32(adultCounter.Text);

            if (CatSelect == 1)
            {
                amountPrice = (adultTickets * 17) + (childTickets * 9);
            }
            if (CatSelect == 2)
            {
                amountPrice = (adultTickets * 13) + (childTickets * 8);
            }
            if (CatSelect == 3)
            {
                amountPrice = (adultTickets * 11) + (childTickets * 7);
            }

            price.Text = amountPrice.ToString();
        }

        public void tickectsLimit()
        {
            int adultTickets = Convert.ToInt32(adultCounter.Text);


            if (adultTickets <= 0) //asghar mn 0
            {
                btnMunisAdult.Enabled = false;
                btnPlusAdult.Enabled = true;
            }//corerct

            if (adultTickets >= 3)
            {
                btnPlusAdult.Enabled = false;
            }
            else
            {
                btnPlusAdult.Enabled = true;
            }//correct

            if (adultTickets >= 1)
            {
                btnMunisAdult.Enabled = true;
            }


            //childTickets

            int childTickets = Convert.ToInt32(childCounter.Text);

            if (childTickets <= 0)
            {
                btnMunisChild.Enabled = false;
                btnPlusChild.Enabled = true;


            }
            if (childTickets > 0)
            {
                btnMunisChild.Enabled = true;
            }
            if (childTickets >= 3)
            {
                btnPlusChild.Enabled = false;
            }
            else
            {
                btnPlusChild.Enabled = true;
            }

            //payActivation
            if (adultTickets != 0 && CatSelect > 0)
            {
                btnPay.Enabled = true;
            }
            else
            {
                btnPay.Enabled = false;
            }

        }

        private void catA_Click(object sender, EventArgs e)
        {
            CatSelect = 1;
            catA.Image = Properties.Resources.btnCategoryA_Selected1;
            catC.Image = Properties.Resources.btnCategoryC;
            catB.Image = Properties.Resources.btnCategoryB;
            tickectsLimit();
            priceCalculate();

        }

        private void catB_Click(object sender, EventArgs e)
        {
            CatSelect = 2;
            catB.Image = Properties.Resources.btnCategoryB_Selected1;
            catA.Image = Properties.Resources.btnCategoryA;
            catC.Image = Properties.Resources.btnCategoryC;
            tickectsLimit();
            priceCalculate();
        }

        private void catC_Click(object sender, EventArgs e)
        {
            CatSelect = 3;
            catC.Image = Properties.Resources.btnCategoryC_Selected1;
            catA.Image = Properties.Resources.btnCategoryA;
            catB.Image = Properties.Resources.btnCategoryB;
            tickectsLimit();
            priceCalculate();
        }



        private void Euro2024Tickets_Load(object sender, EventArgs e)
        {
            btnMunisAdult.Enabled = false;
            btnMunisChild.Enabled = false;
            btnPay.Enabled = false;


        }

        private void btnPlusChild_Click(object sender, EventArgs e)
        {
            int childTickets = Convert.ToInt32(childCounter.Text);
            childTickets++;
            childCounter.Text = childTickets.ToString();
            tickectsLimit();
            priceCalculate();
        }

        private void btnPlusAdult_Click(object sender, EventArgs e)
        {
            int adultTickets = Convert.ToInt32(adultCounter.Text);
            adultTickets++;
            adultCounter.Text = adultTickets.ToString();
            tickectsLimit();
            priceCalculate();
        }

        private void btnMunisAdult_Click(object sender, EventArgs e)
        {
            int adultTickets = Convert.ToInt32(adultCounter.Text);
            adultTickets--;
            adultCounter.Text = adultTickets.ToString();
            tickectsLimit();
            priceCalculate();
        }

        private void btnMunisChild_Click(object sender, EventArgs e)
        {
            int childTickets = Convert.ToInt32(childCounter.Text);
            childTickets--;
            childCounter.Text = childTickets.ToString();
            tickectsLimit();
            priceCalculate();

        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
