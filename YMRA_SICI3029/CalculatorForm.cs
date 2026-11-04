using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMRA_SICI3029
{
    public partial class CalculatorForm : Form
    {
       
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MonthlyFeeLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            int months;
            int saMonthlyFee = 40;
            int childMonthlyFee = 20;
            int studentMonthlyFee = 25;
            int seniorMonthlyFee = 30;

            int pilatesMonthlyFee = 30;
            int karateMonthlyFee = 10;
            int personalTrainingMonthlyFee = 50;
            int monthlyFee = 0;
            int totalCost = 0;

            if (FirstNameTB.Text == "" || LastNameTB.Text == "") {
                MessageBox.Show("Please enter your first and last name.");
                return;
            }

            if(!int.TryParse(MonthsTextbox.Text, out months) || months < 1 || months > 24)
            {
                MessageBox.Show("Please enter a valid number of months (1-24).");
                return;
            }


                if (int.TryParse(MonthsTextbox.Text, out months))
                {
                    if (StudentRadioButton.Checked)
                    {

                        monthlyFee += studentMonthlyFee;
                    }
                    else if (SeniorRadioButton.Checked)
                    {
                        monthlyFee += seniorMonthlyFee;
                    }
                    else if (ChildRadioButton.Checked)
                    {
                        monthlyFee += childMonthlyFee;
                    }
                    else if (saRadioButton.Checked)
                    {
                        monthlyFee += saMonthlyFee;
                    }
                    else
                    {
                        MessageBox.Show("Please select a membership type.");
                    }
                    //Optional

                    if (PilatesCheckBox.Checked)
                    {
                        monthlyFee += pilatesMonthlyFee;
                    }
                    if (KarateCheckBox.Checked)
                    {
                        monthlyFee += karateMonthlyFee;
                    }
                    if (PersonalTrainingCheckBox.Checked)
                    {
                        monthlyFee += personalTrainingMonthlyFee;
                    }

                    totalCost = monthlyFee * months;
                    monthlyLabel.Text = monthlyFee.ToString("c");
                    resultLabel.Text = totalCost.ToString("c");
                }
            }
                


        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
