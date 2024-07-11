using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimothyMcNamaraLab_02
{
    public partial class tempConverter : Form
    {
        public tempConverter()
        {
            InitializeComponent();
        }

        private void fahrenheitBtn_Click(object sender, EventArgs e)
        {
            const double nineoverfive = (9.0 / 5.0);    // this is a constant that is multiplied by the number in the textbox
            double temp, convtemp;                      // These are variables that I will be using to help simplify my equations.

            if (double.TryParse(tempTextBox.Text, out temp))
            {
                // Calculate temperature
                convtemp = ((nineoverfive * temp) + 32);

                //display in output label
                string textoffahrenheit = " Temperature " + temp.ToString("n2") + " C converted to degree Fahrenheit is " + convtemp.ToString("n2") + " F ";      //This is formatted to the liking of the teacher
                tempLabel.Text = textoffahrenheit;  //created a string variable to help simplify the code for my personal taste
            }
            else
            {
                //displays this error if there in not a double within the textbox
                MessageBox.Show("Insert the temperature in numerical format only, please.");
            }
        }

        private void celsiusBtn_Click(object sender, EventArgs e)
        {
            const double fiveovernine = (5.0 / 9.0);    //This constant variable is to help make the fraction 5/9 easier for the calculations later. 
            double temp1, convtemp1;

            if (double.TryParse(tempTextBox.Text, out temp1))
            {
                // calculate for celsius
                convtemp1 = (fiveovernine * (temp1 - 32));

                // display in the output label
                string textofcelsius = " Temperature " + temp1.ToString("n2") + " F converted to degree Celsius is " + convtemp1.ToString("n2") + " C ";
                tempLabel.Text = textofcelsius;
            }
            else
            {
                //displays an error if the input in the textbox is not that of a double
                MessageBox.Show("Insert the temperature in numerical format only, please");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // This will clear both the input textbox and output label.
            tempLabel.Text = "";
            tempTextBox.Text = "";

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //this will close the form!
            this.Close();
        }
    }
}
