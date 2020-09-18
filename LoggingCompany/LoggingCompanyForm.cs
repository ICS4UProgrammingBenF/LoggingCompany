using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoggingCompany
{
    public partial class LoggingCompanyForm : Form
    {
        public LoggingCompanyForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            //declare constants
            const int maxWeight = 1100, weightPerM = 20;

            //declare variables
            double lengthDes = 0, numMaxLogs, maxLength;

            //check to see if the 1m button is selected
            if (radOneM.Checked == true)
            {
                //write to console that 1m is selected
                Console.WriteLine("1m selected");

                //set the lengthDes variable to 1
                lengthDes = 1;
            }
            else if (radPointFiveM.Checked == true)
            {
                //write to console that 0.5m is selected
                Console.WriteLine(".5m selected");

                //set the lengthDes variable to 0.5
                lengthDes = 0.5;
            }
            else if (radPointTwoFiveM.Checked == true)
            {
                //write to console that 0.25m is selected
                Console.WriteLine(".25m selected");

                //set the lengthDes variable to 0.25
                lengthDes = 0.25;
            }

            //calculate the overall maximum length carryable based on weight
            maxLength = maxWeight / weightPerM;

            //calculate the max amount of logs carryable
            numMaxLogs = maxLength / lengthDes;

            //display the max number of logs carryable and thank the user
            txtTotalLogs.Text = ("The max number of logs carryable is: " + numMaxLogs);
            lblThanks.Show();
        }
    }
}
