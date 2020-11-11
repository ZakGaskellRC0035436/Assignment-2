using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Use Try-Catch to avoid imput errors
            try
            {
                //Read values for the Length, width and height from textboxes 
                double Length = double.Parse(textBox1.Text);
                double Width = double.Parse(textBox2.Text);
                double Height = double.Parse(textBox3.Text);
                //Calculate Volume using the equation, Length * Width * Height
                double Volume = Length * Width * Height;
                //Output solutions to Label1
                label1.Text = "Volume =" + Volume;
                //Calculate Area using the equation, 2.0*(Lengh + Width + Height)
                Double Area = 2.0 * (Length + Width + Height);
                //Output solution to Label5
                label5.Text = "Area =" + Area;
            }
            catch
            {
                MessageBox.Show("Error On Imput");
            }
        }
        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Use Try-Catch to avoid imput errors
            try
            {
                //Reading the values for the raduis
                double Radius = double.Parse(textBox4.Text);
            //Calculating the Area and Volume using the respective equations
            Double Area = 4.0 * Math.PI * Radius * Radius * Radius;
            Double Volume = 4.0 / 3.0 * Math.PI * Radius * Radius * Radius;
            //Output solution to labels
            label7.Text = "Area =" + 4 * Math.PI * Radius * Radius * Radius;
            label8.Text = "Volume =" + 4.0 / 3.0 * Math.PI * Radius * Radius * Radius;
            }
            catch
            {
                MessageBox.Show("Error On Imput");
            }
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Use Try-Catch to avoid imput errors
            try
            {
                //Reading the values for the raduis and Height
                double Radius = double.Parse(textBox5.Text);
                double Width = double.Parse(textBox6.Text);
                //Calculating the Area and Volume using the respective equations
                Double Area = Math.PI * Radius *(Radius + Math.Sqrt(Height * Height + Radius * Radius));
                Double Volume = 1.0 / 3.0 * Math.PI * Radius * Radius * Height;
                //Output solution to labels
                label10.Text = "Area =" + Math.PI * Radius *(Radius + Math.Sqrt(Height * Height + Radius * Radius));
                label11.Text = "Volume =" + 1.0 / 3.0 * Math.PI * Radius * Radius * Height;
            }
            catch
            {
                MessageBox.Show("Error On Imput");
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
