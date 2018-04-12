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
        public frmRunningAverage()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //variable
            int userNumber, sum, total = 0;
            double average;

            //add one to total
            total = total + 1;
            //asign the input
            userNumber = Convert.ToInt32(txtNumbers);

            //add it to sum
        }
    }
}
