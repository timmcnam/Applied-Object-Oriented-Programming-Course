using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
// Timothy McNamara forgot this last time lol
//ECET 16400
//LAB 03


namespace TimothyMcNamaraLab_03
{
    public partial class DistanceCalculator : Form
    {
        public DistanceCalculator()
        {
            InitializeComponent();
        }

        private void calculateDistanceBtn_Click(object sender, EventArgs e)
        {
            // First we declare the varibles used within the method.

            double vehiclespeed;    // To hold vehicle speed
            double hours;           // To hold the hours traveled
            double distance;        // To hold our calculation

            // Clear the list box of any previous calculations
            distanceListBox.Items.Clear();

            // Validate the MPH input
            if (double.TryParse(speedTxtBox.Text, out vehiclespeed))
            {
                // Validate the hours traveled
                if (double.TryParse(hoursTxtBox.Text, out hours))
                {
                    // we create a for loop to loop for each hour inputted. 
                    // We stop once the hour is equal to the loop count
                    for (double y = 1; y <= hours; y++)
                    {
                        // We simply calculate the distance by multiplying the speed and the loop count
                        distance = vehiclespeed * y;
                        distanceListBox.Items.Add("After hour " + y + " the vehicle traveled "
                                                    + distance.ToString("n1"));
                    }
                }
                else
                {
                    // Display error message for invalid input for hours
                    MessageBox.Show("Invalid input for hours.");
                }
            }
            else
            {
                //Display error message for invalid input for hours
                MessageBox.Show("Invalid input for speed.");
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Clears the distance list box
            distanceListBox.Items.Clear();

            // Clears both textboxes
            speedTxtBox.Text = "";
            hoursTxtBox.Text = "";

            // Brings the focus back to the first of the tab order
            speedTxtBox.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Closes the form
            this.Close();

        }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Declares stream writer variable.
                StreamWriter outputFile;

                // Creates output file to write text to.
                outputFile = File.CreateText("Distance.txt");

                // Writes list box items to the .txt file
                outputFile.WriteLine(distanceListBox.Items);

                // Closes output file
                outputFile.Close();

                // Tells user data was stored in Distance.txt file
                MessageBox.Show("Distances taken.");
                // Clears distance list box
                distanceListBox.Items.Clear();
            }
            catch (Exception ex)
            {
                // Displays error message
                MessageBox.Show(ex.Message);
            }
        }
    }
}
