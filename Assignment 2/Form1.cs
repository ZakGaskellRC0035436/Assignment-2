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
                label1.Text = "Volume =" + Length * Width * Height;
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
    }
}
