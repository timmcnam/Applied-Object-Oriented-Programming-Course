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

namespace Timothy_McNamaraLab08_164
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ProcessSalesFiles()
        {
            //all variables used in method
            int index = 0;                              //loop counter
            const int SUM = 9;                          //number of sales
            double[] salesArray = new double[SUM];      //array of test scores 
            double total = 0;                           //holds total and is used to calculate total
            double highestSale;                         //holds highest sale
            double lowestSale;                          //holds lowest sale
            double averageSale;                         //holds average sale

            StreamReader inputFile;

            
            try
            {
                //opens file through streamreader
                inputFile = File.OpenText("Sales.txt");

                //reads test scores into array
                //calculates total of array values
                //converts them to string
                while (index < salesArray.Length && !inputFile.EndOfStream)
                {
                    salesArray[index] = double.Parse(inputFile.ReadLine());

                    total += salesArray[index];
                    salesListBox.Items.Add(salesArray[index].ToString());

                    index++;
                }

                inputFile.Close();

                //gets values
                highestSale = GetHighest(salesArray);
                lowestSale = GetLowest(salesArray);
                averageSale = GetAverage(salesArray);

                //displays values
                highestSaleLabelBox.Text = highestSale.ToString();
                lowestSaleLabelBox.Text = lowestSale.ToString();
                averageSaleLabelBox.Text = averageSale.ToString("n2");
                totalSaleLabelBox.Text = total.ToString("n2");

               

            }
            catch
            {
                MessageBox.Show("This cannot be done.");
            }
        }

        //The average method accepts an double array argument
        //and returns the Average of the values in the array.
        private double GetAverage(double[] salesArray)
        {
            double total = 0;       //accumulator, initialized to 0
            double average;         //holds the average

            //Steps through the array. Adds each element to the accumulator
            for(int index = 0; index < salesArray.Length; index++)
            {
                total += salesArray[index];
            }

            //calculate the average
            average = (double)total / salesArray.Length;

            //returns the average
            return average;
        }

        //The highest method accepts an double array argument
        //and returns the highest value in that array.
        private double GetHighest(double[] salesArray)
        {
            //Declare a variable to hold the highest value, and
            //initialize it with the first value in the array.
            double highest = salesArray[0];

            //Step through the rest of the array, beginning at
            //1. When a value  greater then highest is found,
            //assign that value to highest.
            for (int index = 1; index < salesArray.Length; index++)
            {
                if (salesArray[index] > highest)
                {
                    highest = salesArray[index];
                }
            }

            //returns the highest value.
            return highest;
        }

        //The lowest method accepts an double array argument
        //and returns the lowest value in that array.
        private double GetLowest(double[] salesArray)
        {
            //declare a variable to hold the lowest value, and
            //initialize it with first value in the array.
            double lowest = salesArray[0];

            //Steps through the rest of the array, beginning at
            //1. When a value less than lowest is found,
            //assign that value to lowest.
            for (int index = 1; index < salesArray.Length; index++)
            {
                if (salesArray[index] < lowest)
                {
                    lowest = salesArray[index];
                }
            }

            //returns the lowest value.
            return lowest;
        }


        private void getSalesButton_Click(object sender, EventArgs e)
        {
            try
            {
                //goes through the method and calls on said method.
                ProcessSalesFiles();
            }
            catch 
            {
                MessageBox.Show("This cannot be done");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears output labels and list box
            salesListBox.Items.Clear();
            highestSaleLabelBox.Text = "";
            lowestSaleLabelBox .Text= "";
            averageSaleLabelBox.Text = "";
            totalSaleLabelBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exits form application
            this.Close();
        }
    }
}
