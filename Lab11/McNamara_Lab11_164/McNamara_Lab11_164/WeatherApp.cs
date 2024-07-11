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

namespace McNamara_Lab11_164
{
    // Structure statement defines new data types
    // with more than one member for the program.
    struct WeatherData
    {
        public DateTime date;
        public double precipitation;
        public double highTemp;
        public double lowTemp;
    }
    public partial class WeatherApp : Form
    {
        // Field that holds a list of weatherData objects.
        private List<WeatherData> weatherDataList = new List<WeatherData>();
        WeatherData myDataStruct = new WeatherData();
        public WeatherApp()
        {
            InitializeComponent();
        }

        // The weather app load reads the contents of the weather.txt file
        private void WeatherApp_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader file; //Reads file
                string line;       //holds a line from the file

                //calls the file "file" and opend the text file.
                file = File.OpenText("weather.txt");
                
                //Reads lines from the file
                while (!file.EndOfStream)
                {
                    //Read the next line from the file
                    line = file.ReadLine();

                    //Tokenize the line using the semicolon character
                    string[] tokens = line.Split(';');

                    //Convert the data to a WeatherData struct
                    myDataStruct.date = DateTime.Parse(tokens[0]);
                    myDataStruct.precipitation = double.Parse(tokens[1]);
                    myDataStruct.highTemp = double.Parse(tokens[2]);
                    myDataStruct.lowTemp = double.Parse(tokens[3]);

                    // store myDataStruct in the weatherDataList
                    weatherDataList.Add(myDataStruct);
                }

                file.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //This method displays the weather info if a date is selected on the calender
        //The method also utilizes a boolean method that is
        //turned true when a date is selected.
        //There is also an if statement that covers if a date is selected
        //outside of the calender's parameter.
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime userSelected = dateTimePicker.Value;
            bool selected = false;
            int index = 0;
            while (index < weatherDataList.Count && selected == false)
            {
                if (weatherDataList[index].date == userSelected )
                {
                    dateLabel.Text = weatherDataList[index].date.ToString();
                    precipitationLabel.Text = weatherDataList[index].precipitation.ToString();
                    highTempLabel.Text = weatherDataList[index].highTemp.ToString();
                    lowTempLabel.Text = weatherDataList[index].lowTemp.ToString();
                    selected = true;
                }
                index++;
            }
            if (selected == false)
            {
                MessageBox.Show("No data found to match selected date.");

            }
            
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Clears all the labels for the next selected 
            dateLabel.Text = "";
            precipitationLabel.Text = "";
            highTempLabel.Text = "";
            lowTempLabel.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //exits the applicationa nd closes the form.
            this.Close();
        }
    }
}
