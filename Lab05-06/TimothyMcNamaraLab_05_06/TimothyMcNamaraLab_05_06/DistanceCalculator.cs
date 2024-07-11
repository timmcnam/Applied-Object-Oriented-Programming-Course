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
//Timothy McNamara
//ECET 16400
//Lab 05_06
//added "using system.IO" to put data into txt file
namespace TimothyMcNamaraLab_05_06
{
    public partial class DistanceCalculator : Form
    {
        public DistanceCalculator()
        {
            InitializeComponent();
        }

        private void calculateDistanceMilesTraveled_Click(object sender, EventArgs e)
        {
            // declasres variables as integers for our calculations
            int hours;          
            int speed;
            int distance;

            //clears the list box
            distanceListBox.Items.Clear();

            if (int.TryParse(speedTextBox.Text, out speed))
            {
                if (int.TryParse(timeTextBox.Text, out hours))
                {
                    //uses a for loop to keep going until i is equal to the amount of hours
                    for (int i = 1; i <= hours; i++)
                    {
                        distance = speed * i;
                        distanceListBox.Items.Add("After hour " + i + " the vehicle traveled " + distance.ToString("n") + " miles ");
                    }
                }
                else
                {
                    //displays error message
                    MessageBox.Show("Invalid Input");
                }
            }
            else
            {
                //displays error message
                MessageBox.Show("Invalid Input");
            }
        }

        private void writeDataToFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declares stream writer variable.
                StreamWriter outputFile;

                //Creates output file to write text to.
                outputFile = File.CreateText("Distance.txt");

                //Writes distance "items" to distance file
                outputFile.WriteLine(distanceListBox.Items);

                //Closes output file
                outputFile.Close();

                //Tells user data was stored in Distance.txt file
                MessageBox.Show("Distances Written!");
                //Clears distance list box
                distanceListBox.Items.Clear();
            }
            catch
            {
                //displays error message
                MessageBox.Show("Invalid Input");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clears distance list box
            distanceListBox.Items.Clear();

            //Clears textboxes
            speedTextBox.Text="";
            timeTextBox.Text = "";

            //focuses back to the top textbox
            speedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exits Program
            this.Close();
        }
    }
}
