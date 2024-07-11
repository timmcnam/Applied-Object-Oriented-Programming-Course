using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimothyMcNamaraLab_03_04
{
    public partial class tempConverter : Form
    {
        public tempConverter()
        {
            InitializeComponent();
        }

        private void converterButton_Click(object sender, EventArgs e)
        {
            try
            {
                const double nineoverfiveforF = 1.8;                //      9/5 fraction used in conversion equation
                const double fiveovernineforC = (5.0 / 9.0);        //      5/9 fraction used in conversion equation 
                double temp, convertedtemp;                         //      sets variables

                //  Gets temperature from textbox
                temp = double.Parse(tempTextBox.Text);

                //  if radio button of fahrenheit to celcius is checked
                if (fahrenheitToCelciusRadioButton.Checked)
                {
                    //converts temperature celcius
                    convertedtemp = (fiveovernineforC * (temp - 32));
                    convertedTempLabel.Text = convertedtemp.ToString("n2");    
                    degreeCelciusLabel.Visible = true;      //  displays degrees C
                    degreeFahrenheitLabel.Visible = false;  //  hides degrees F
                }
                else if (celciusToFahrenheitRadioButton.Checked)
                {
                    //converts temperature to fahrenheit 
                    convertedtemp = ((nineoverfiveforF * temp) + 32);
                    convertedTempLabel.Text = convertedtemp.ToString("n2");
                    degreeFahrenheitLabel.Visible = true;   //displays degrees F
                    degreeCelciusLabel.Visible = false;     //hides degrees C
                }
              //else
                //{
                  // tempTextBox.Text != ""
                //}



            }

            catch (Exception ex)
            {
                //covers other possible errors
                MessageBox.Show("Insert Temperature!");
            }


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clears text box
            tempTextBox.Text = "";
            tempTextBox.Focus();
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exits program
            this.Close();
        }
    }
}
