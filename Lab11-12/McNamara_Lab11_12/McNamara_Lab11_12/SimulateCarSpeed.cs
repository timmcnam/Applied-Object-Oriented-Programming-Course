using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McNamara_Lab11_12
{
    public partial class SimulateCarSpeed : Form
    {
        // Created a global refernce variablr for the Car class.
        Car myCar;
        public SimulateCarSpeed()
        {
            InitializeComponent();
        }

        private void CreateCarBtn_Click(object sender, EventArgs e)
        {
            // try catch statement to help buff out the code if it were to have errors. 
            // In a sense, it will catch those errors
            // and display what went wrong.
            try
            {
                //takes the given values from the textboxes
                //and puts them into the carSpeedLabel
                myCar = new Car(makeTextBox.Text,
                                modelTextBox.Text,
                                int.Parse(yearTextBox.Text),
                                double.Parse(speedTextBox.Text));
                carSpeedLabel.Text = "The speed of " + myCar.Year + " " + myCar.Make + " "
                                        + myCar.Model + " is " + myCar.Speed + " mph.";
            }
            catch (Exception ex)
            {
                // Displays error message if someone
                // types a character in the text box
                // that is not a required character.
                MessageBox.Show(ex.Message);
            }
        }

        private void AccelerateBtn_Click(object sender, EventArgs e)
        {

            // Calls the accelerate method
            myCar.Accelerate();

            //displays the cars added speed.
            carSpeedLabel.Text = "The speed of " + myCar.Year + " " + myCar.Make + " "
                                        + myCar.Model + " is " + myCar.Speed + " mph.";

        }

        // Once the Brake Button is clicked,
        // It will subtract 5 mph from the Speed displayed. 
        private void BrakeBtn_Click(object sender, EventArgs e)
        {
            // Calls the Brake method
            myCar.Brake();

            // Displays the cars subtracted speed.
            carSpeedLabel.Text = "The speed of " + myCar.Year + " " + myCar.Make + " "
                                        + myCar.Model + " is " + myCar.Speed + " mph.";


        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // Clears all textboxes.
            carSpeedLabel.Text = "";
            makeTextBox.Text = "";
            modelTextBox.Text = "";
            yearTextBox.Text = "";
            speedTextBox.Text = "";
            makeTextBox.Focus();


        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // Closes the Form
            this.Close();

        }
    }
}
