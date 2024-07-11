using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Timothy McNamara
//Lab 01 Controls practice
//ECET 16400
//1/19/2022

namespace TimothyMcNamaraLab_01
{
    public partial class ControlsPractice : Form
    {
        public ControlsPractice()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Close();
        }

        private void clearTextBtn_Click(object sender, EventArgs e)
        {
            //clears the textbox of the name of the the dog label
            //The fact that it only clears this text box kinda bugs me.
            dogLabel.Text = "";
        }

        private void welcomeBtn_Click(object sender, EventArgs e)
        {
            /* displays message box that says
             * "I love to program!" then, 
             * the output label will have the same words 
             * that were displayed within the messagebox */
            MessageBox.Show("I love to program!");
            outputLabel.Text = "I love to program!";
        }

        private void myNameBtn_Click(object sender, EventArgs e)
        {
            /* Replaces any text that is within the label and 
             * displays my name, "Timothy McNamara". It also
             displays a messagebox that says the same thing. */
            MessageBox.Show("My name is Timothy McNamara!");
            outputLabel.Text = "Timothy McNamara";

        }

        private void dogNameBtn_Click(object sender, EventArgs e)
        {
            /* displays in the dog label the name of the "dog I own" */
            dogLabel.Text = "Fido";
        }

        private void showPictureBtn_Click(object sender, EventArgs e)
        {
            //Reveals the hidden picture that has visibility set to false
            myPicture.Visible = true;
        }

        private void hidePictureBtn_Click(object sender, EventArgs e)
        {
            //Hides the picture by setting the visibility set to false
            myPicture.Visible = false;
        }
    }
}
