/*
 * Created by: Allison Cook
 * Created on: 12 April, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Running Average
 * This program calculates the average of a growing collection of numbers
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningAverageAllisonC
{
    public partial class frmRunningAverage : Form
    {
        //variable
        int userNumber, sum = 0, total = 0;
        double average; 

        public frmRunningAverage()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //add one to total
            total = total + 1;
            //asign the input
            userNumber =int.Parse(txtNumbers.Text);

            //add it to sum
            sum = sum + userNumber;

            //calculate the average
            average = sum / total;

            this.lblAverage.Text = "The running average is " + average;

            if (userNumber == -1)
            {
                //showing the user that they ended the program
                MessageBox.Show("Running average ended", "running average");

                //the user can not continue the program
                this.btnCalculate.Enabled = false;
                this.txtNumbers.Visible = false;

            }
            else if (userNumber < -1 || userNumber > 100)
            {
                //show the user that they need to enter a number between 1 and 100
                MessageBox.Show("Please enter a number between 1 and 100", "running average");
            }

        }
    }
}
