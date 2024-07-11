using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McNamara_Lab11_12
{
    class Car
    {
        // Fields
        private string _make;
        private string _model;
        private int _year;
        private double _speed;

        // Constructor
        public Car (string make, string model, int year, double speed)
        { 
            _make = make;
            _model = model;
            _year = year;
            _speed = speed;
        }

        // Properties
        // Make property
        public string Make 
        {
            get { return _make; } 
            set { _make = value; }
        }
        // Model Property
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        // Year Property
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        // Speed Property
        public double Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        // Public Methods
        // Accelerate 
        //This method will add 5 mph to the displayed speed
        public void Accelerate()
        {
            // Accelerates the 
          if (Speed > 0)
            {
                Speed += 5;
            }
          else
            {
                Speed += 5;
            }
           
        }
        // Brake
        // This method covers all possible speeds and prevents 
        // displaying a negative speed.
        public void Brake()
        {
            if (Speed != 0 && Speed > 5)
            {
                Speed -= 5;
            }
            else if (Speed < 5)
            {
                Speed = 0;
            }
            else
            {
                Speed = 0;
            }

           
        }
    }
}
