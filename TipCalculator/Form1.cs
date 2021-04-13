using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class Form1 : Form
    {
        //Declaring the variables
        double billamt;
        double tippercent;
        int noofpeople;
        double tipamt;
        double tipamtperperson;
        double totbill;
        double billamtperperson;

        public Form1()
        {
            InitializeComponent();
        }

        private void people_txtbox_TextChanged(object sender, EventArgs e)
        {   //This calculates the tip per person and bill per person and displays it in the labels.
            try { 
            billamt = Convert.ToDouble(bill_amttxtbox.Text);
            tippercent = Convert.ToDouble(tipcent_txtbox.Text);
            if ((people_txtbox.Text != "") || !(string.IsNullOrEmpty(people_txtbox.Text)))
            {
                noofpeople = Convert.ToInt32(people_txtbox.Text);
                tipamt = billamt * (tippercent / 100);
                tipamtperperson = tipamt / noofpeople;
                tipperperson_label.Text = tipamtperperson.ToString("N2");
                totbill = billamt + tipamt;
                billamtperperson = totbill / noofpeople;
                billperperson_label.Text = billamtperperson.ToString("N2");
                }
            else
            {
                noofpeople = 0;
            }
        }
            catch(Exception excp)
            {
                MessageBox.Show("Exception occured: " +excp);
            }
        }
        private void tipcent_txtbox_TextChanged(object sender, EventArgs e)
        {
            //This calculates the tip per person and bill per person and displays it in the labels.
            //User gets displayed with correct result in case of any changes made in tip percentage value also.
            try
            {
                if ((people_txtbox.Text != "") || !(string.IsNullOrEmpty(people_txtbox.Text)))
                {
                    billamt = Convert.ToDouble(bill_amttxtbox.Text);
                    tippercent = Convert.ToDouble(tipcent_txtbox.Text);
                    noofpeople = Convert.ToInt32(people_txtbox.Text);
                    tipamt = billamt * (tippercent / 100);
                    tipamtperperson = tipamt / noofpeople;
                    tipperperson_label.Text = tipamtperperson.ToString();
                    totbill = billamt + tipamt;
                    billamtperperson = totbill / noofpeople;
                    billperperson_label.Text = billamtperperson.ToString();

                }
                else
                {
                    tippercent = 0;
                }
            }
            catch
            {
                MessageBox.Show("Please enter tip percentage");
            }
        }

        private void bill_amttxtbox_Validating(object sender, CancelEventArgs e)
        {
            //Validates and checks if bill amount textbox is empty or 0,it gives a message box.
            try {
                if (bill_amttxtbox.Text == "" || bill_amttxtbox.Text == "0")
                {
                    MessageBox.Show("Please enter the bill amount");
                    bill_amttxtbox.Focus();
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Exception: "+excp);
            }
        }

        private void tipcent_txtbox_Validating(object sender, CancelEventArgs e)
        {
            //Validates and checks if tip percent textbox is empty,it gives a message box.
            try
            {
                if (tipcent_txtbox.Text == "")
                {
                    MessageBox.Show("Please enter the tip percentage");
                    tipcent_txtbox.Focus();
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Exception: "+excp);
            }
        }

        private void people_txtbox_Validating(object sender, CancelEventArgs e)
        {
            //Validates and checks if number of people textbox is empty or 0,it gives a message box.
            try
            {
                if (tipcent_txtbox.Text == "" || people_txtbox.Text == "0")
                {
                    MessageBox.Show("Please enter the tip percentage");
                    people_txtbox.Focus();
                }
            }
            catch(Exception excp)
            {
                MessageBox.Show("Exception: " + excp);
            }
        }

        private void inctip_btn_Click(object sender, EventArgs e)
        {
            //Increments the number in the tip percent textbox on the click of the button.
            try
            {
                double counttipinc = double.Parse(tipcent_txtbox.Text);
                counttipinc++;
                tipcent_txtbox.Text = counttipinc.ToString();
            }

            catch (Exception excp)
            {
                MessageBox.Show("Exception: " + excp);
            }
        }


        private void dectip_btn_Click(object sender, EventArgs e)
        {
            //Decrements the number in the tip percent textbox on the click of the button.
            try
            {
                double counttipdec = double.Parse(tipcent_txtbox.Text);
                if (counttipdec >= 1)
                {
                    counttipdec--;
                    tipcent_txtbox.Text = counttipdec.ToString();
                }

                else
                {
                    MessageBox.Show("Only values greater than or equal to 0 permitted!");
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Exception: " + excp);
            }
        }

        private void peopleinc_btn_Click(object sender, EventArgs e)
        {
            //Increments the number in the number of people textbox on the click of the button.
            try
            {
                int countpeopleinc = 0;
                if ((people_txtbox.Text != "") || !(string.IsNullOrEmpty(people_txtbox.Text)))
                {
                    countpeopleinc = int.Parse(people_txtbox.Text);
                    countpeopleinc++;
                    people_txtbox.Text = countpeopleinc.ToString();
                }
                else
                {
                    countpeopleinc++;
                    people_txtbox.Text = countpeopleinc.ToString();
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Exception: " + excp);
            }
        }

        private void peopledec_btn_Click(object sender, EventArgs e)
        {
            //Decrements the number in the number of people textbox on the click of the button.
            try
            {
                double countpeopledec = double.Parse(people_txtbox.Text);
                if (countpeopledec >= 2)
                {
                    countpeopledec--;
                    people_txtbox.Text = countpeopledec.ToString();
                }
                else
                {
                    MessageBox.Show("Only values greater than 0 permitted!");
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Exception: " + excp);
            }

        }

        private void bill_amttxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Makes sure that user could use only digits,backspace and decimal character in bill amount textbox.
            try
            {
                char c = e.KeyChar;
                if (!char.IsDigit(c) && c != 8 && c != 46)
                {
                    e.Handled = true;
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Exception:" + excp);
            }
        }

        private void tipcent_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Makes sure that user could use only digits,backspace and decimal character in tip percent textbox.
            try
            {
                char c = e.KeyChar;
                if (!char.IsDigit(c) && c != 8 && c != 46)
                {
                    e.Handled = true;
                }
            }

            catch (Exception excp)
            {
                MessageBox.Show("Exception :" + excp);
            }

        }

        private void people_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Makes sure that user could input only digits and backspace in number of people textbox.
            try
            {
                char c = e.KeyChar;
                if (!char.IsDigit(c) && c != 8)
                {
                    e.Handled = true;
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Exception :" + excp);
            }
        }

    }
}
