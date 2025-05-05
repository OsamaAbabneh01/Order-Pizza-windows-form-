using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void UpdateTotalPrice()
        {
            float price = 0;
            if (rbSmall.Checked)
            {
                price += Convert.ToSingle(rbSmall.Tag);
            }

            if (rbMeduim.Checked)
            {
                price += Convert.ToSingle(rbMeduim.Tag);
            }
            
            if (rbLarg.Checked)
            {
                price += Convert.ToSingle(rbLarg.Tag);
            }

            if (rbThinCrust.Checked)
            {
                price += Convert.ToSingle(rbThinCrust.Tag);
            }

            if (rbThickCrust.Checked)
            {
                price += Convert.ToSingle(rbThickCrust.Tag);
            }

            if (chbExtraChees.Checked)
            {
                price += Convert.ToSingle(chbExtraChees.Tag);
            }

            if (chbOlives.Checked)
            {
                price += Convert.ToSingle(chbOlives.Tag);
            }

            if (chbOnion.Checked)
            {
                price += Convert.ToSingle(chbOnion.Tag);
            }

            if (chbGreenPeppers.Checked)
            {
                price += Convert.ToSingle(chbGreenPeppers.Tag);
            }

            if (chbTomatoes.Checked)
            {
                price += Convert.ToSingle(chbTomatoes.Tag);
            }

            if (ckbMushrooms.Checked)
            {
                price += Convert.ToSingle(ckbMushrooms.Tag);
            }

            lbTotalPrice.Text = "$" + price.ToString();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                lbSize.Text = "Small";
                return;
            }

            if (rbMeduim.Checked)
            {
                lbSize.Text = "Meduim";
                return;
            }

            if (rbLarg.Checked)
            {
                lbSize.Text = "Larg";
                return;
            }
        }

        private void rbSmall_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        
        void UpdateCrustType()
        {
            UpdateTotalPrice();

            if (rbThinCrust.Checked)
            {
                lbCrustType.Text = "Thin Crust";
                return;
            }

            if (rbThickCrust.Checked)
            {
                lbCrustType.Text = "Thick Crust";
                return;
            }
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
            {
                lbWhereToEat.Text = rbEatIn.Text;
                return;
            }

            if (rbTakeOut.Checked)
            {
                lbWhereToEat.Text = rbTakeOut.Text;
                return;
            }
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            string sToppings = "";
            if (chbExtraChees.Checked)
            {
                sToppings += chbExtraChees.Text + ", ";
            }

            if (ckbMushrooms.Checked)
            {
                sToppings += ckbMushrooms.Text + ", ";
            }

            if (chbTomatoes.Checked)
            {
                sToppings += chbTomatoes.Text + ", ";
            }

            if (chbOnion.Checked)
            {
                sToppings += chbOnion.Text + ", ";
            }

            if (chbOlives.Checked)
            {
                sToppings += chbOlives.Text + ", ";
            }

            if (chbGreenPeppers.Checked)
            {
                sToppings += chbGreenPeppers.Text + ", ";
            }

            if (sToppings == "")
            {
                sToppings = "No Toppings";
                lbToppings.Text = sToppings;
                return;
            }

            lbToppings.Text = sToppings.Substring(0, sToppings.Length - 2);
        }

        private void chbExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void ckbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chbOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chbOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                btnOrderPizza.Enabled = false;
            }
            else
            {
                MessageBox.Show("Update your order", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
            btnOrderPizza.Enabled = true;
            
            rbMeduim.Checked = true;
            rbThinCrust.Checked = true;
            rbEatIn.Checked = true;

            chbExtraChees.Checked = false;
            chbGreenPeppers.Checked = false;
            chbOlives.Checked = false;
            chbTomatoes.Checked = false;
            chbOnion.Checked = false;
            ckbMushrooms.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

    }
}