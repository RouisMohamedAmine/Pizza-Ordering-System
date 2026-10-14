using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Frm2 : Form
    {
        public Frm2()
        {
            InitializeComponent();

            this.Size = new Size(800, 600);
            this.WindowState = FormWindowState.Normal;
        }



        private float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);
            else if (rbMedum.Checked)
                return Convert.ToSingle(rbMedum.Tag);
            else if (rbLarge.Checked)
                return Convert.ToSingle(rbLarge.Tag);
            else
                return 0;
        }

        private float GetSelectedCrustPrice()
        {
            if (rbThink.Checked)
                return Convert.ToSingle(rbThink.Tag);
            else if (rbThin.Checked)
                return Convert.ToSingle(rbThin.Tag);
            else
                return 0;
        }

        private float CalculateToppingsPrice()
        {
            float ToppingsPrice = 0;

            if (cbExtraChees.Checked)
                ToppingsPrice += Convert.ToSingle(cbExtraChees.Tag);

            if (cbMushrooms.Checked)
                ToppingsPrice += Convert.ToSingle(cbMushrooms.Tag);

            if (cbTomatoes.Checked)
                ToppingsPrice += Convert.ToSingle(cbTomatoes.Tag);

            if (cbOnion.Checked)
                ToppingsPrice += Convert.ToSingle(cbOnion.Tag);

            if (cbOlives.Checked)
                ToppingsPrice += Convert.ToSingle(cbOlives.Tag);

            if (cbPeppers.Checked)
                ToppingsPrice += Convert.ToSingle(cbPeppers.Tag);

            return ToppingsPrice;
        }

        private float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + GetSelectedCrustPrice() + CalculateToppingsPrice();
        }

        private void UpdateTotalPrice()
        {
            lblPrice.Text = "$" + CalculateTotalPrice().ToString("0.00");
        }

        private void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
                lblSize.Text = "Small";
            else if (rbMedum.Checked)
                lblSize.Text = "Medium";
            else if (rbLarge.Checked)
                lblSize.Text = "Large";
        }

        private void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThin.Checked)
                lblCrust.Text = "Thin";
            else if (rbThink.Checked)
                lblCrust.Text = "Thick";
        }

        private void UpdateToppings()
        {
            UpdateTotalPrice();

            string toppings = "";

            if (cbOlives.Checked) toppings += "Olives, ";
            if (cbExtraChees.Checked) toppings += "Extra Cheese, ";
            if (cbOnion.Checked) toppings += "\nOnion, ";
            if (cbMushrooms.Checked) toppings += "Mushrooms, ";
            if (cbPeppers.Checked) toppings += "\nGreen Peppers, ";
            if (cbTomatoes.Checked) toppings += "Tomatoes, ";

            if (toppings.EndsWith(", "))
                toppings = toppings.Substring(0, toppings.Length - 2);

            if (string.IsNullOrEmpty(toppings))
                toppings = "No Toppings";

            lblToppings.Text = toppings;
        }

        private void UpdateEatPlace()
        {
            if (rbEatIn.Checked)
                lblWheretoEat.Text = "Eat In";
            else 
                lblWheretoEat.Text = "Take Out";
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e) { UpdateSize(); }
        private void rbMedum_CheckedChanged(object sender, EventArgs e) { UpdateSize(); }
        private void rbLarge_CheckedChanged(object sender, EventArgs e) { UpdateSize(); }

        private void rbThin_CheckedChanged(object sender, EventArgs e) { UpdateCrust(); }
        private void rbThink_CheckedChanged(object sender, EventArgs e) { UpdateCrust(); }

        private void cbExtraChees_CheckedChanged(object sender, EventArgs e) { UpdateToppings(); }
        private void cbMushrooms_CheckedChanged(object sender, EventArgs e) { UpdateToppings(); }
        private void cbTomatoes_CheckedChanged(object sender, EventArgs e) { UpdateToppings(); }
        private void cbOnion_CheckedChanged(object sender, EventArgs e) { UpdateToppings(); }
        private void cbOlives_CheckedChanged(object sender, EventArgs e) { UpdateToppings(); }
        private void cbPeppers_CheckedChanged(object sender, EventArgs e) { UpdateToppings(); }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e) { UpdateEatPlace(); }
        private void rbEatOut_CheckedChanged(object sender, EventArgs e) { UpdateEatPlace(); }

        private void Order()
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to order?",
                "Confirm Order",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
            {
                grpSize.Enabled = false;
                grpCrust.Enabled = false;
                grpToppings.Enabled = false;
                grpWheretoEat.Enabled = false;

                rbEatIn.Enabled = false;
                rbEatOut.Enabled = false;

                rbThin.Enabled = false;
                rbThink.Enabled = false;

                rbLarge.Enabled = false;
                rbSmall.Enabled = false;
                rbMedum.Enabled = false;

                cbExtraChees.Enabled = false;
                cbMushrooms.Enabled = false;
                cbOlives.Enabled = false;
                cbTomatoes.Enabled = false;
                cbPeppers.Enabled = false;
                cbOnion.Enabled = false;

                MessageBox.Show(
                    "Order successful!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }


        private void Reset()
        {
            grpSize.Enabled = true;
            grpCrust.Enabled = true;
            grpToppings.Enabled = true;
            grpWheretoEat.Enabled = true;

            rbSmall.Enabled = true;
            rbMedum.Enabled = true;
            rbLarge.Enabled = true;

            rbThin.Enabled = true;
            rbThink.Enabled = true;

            rbEatIn.Enabled = true;
            rbEatOut.Enabled = true;

            cbExtraChees.Enabled = true;
            cbMushrooms.Enabled = true;
            cbOlives.Enabled = true;
            cbTomatoes.Enabled = true;
            cbPeppers.Enabled = true;
            cbOnion.Enabled = true;

            rbSmall.Checked = false;
            rbMedum.Checked = false;
            rbLarge.Checked = false;

            rbThin.Checked = false;
            rbThink.Checked = false;

            rbEatIn.Checked = false;
            rbEatOut.Checked = false;

            cbExtraChees.Checked = false;
            cbMushrooms.Checked = false;
            cbOlives.Checked = false;
            cbTomatoes.Checked = false;
            cbPeppers.Checked = false;
            cbOnion.Checked = false;

            lblSize.Text = "";
            lblCrust.Text = "";
            lblToppings.Text = "";
            lblWheretoEat.Text = "";
            lblPrice.Text = "$0.00";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }


        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            Order();
        }
    }
}
