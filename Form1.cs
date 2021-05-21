using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                int conversionChoice = Convert.ToInt32(choiceInput.Text);
                double value = Convert.ToDouble(valueInput.Text);
                double result;

                if (conversionChoice == 1)
                {
                    result = InchesToCm(value);
                    convertOutput.Text = $"{value} inches = {result.ToString("0.00")} centimetres";
                }
                else if (conversionChoice == 2)
                {
                    result = FeetToCm(value);
                    convertOutput.Text = $"{value} feet = {result.ToString("0.00")} centimetres";
                }
                else if (conversionChoice == 3)
                {
                    result = YardsToMetres(value);
                    convertOutput.Text = $"{value} yards = {result.ToString("0.00")} metres";
                }
                else if (conversionChoice == 4)
                {
                    result = MilesToKm(value);
                    convertOutput.Text = $"{value} miles = {result.ToString("0.00")} kilometres";
                }
                else
                {
                    choiceInput.Text = "";
                    convertOutput.Text = "Please enter number from 1-4 for conversion type";
                }
            }
            catch
            {
                convertOutput.Text = "Please enter numbers";
            }          
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public double InchesToCm(double inches)
        {
            double cm = inches * 2.54;
            return cm;
        }

        public double FeetToCm(double feet)
        {
            double cm = feet * 30.48;
            return cm;
        }

        public double YardsToMetres(double yards)
        {
            double m = yards * 0.91;
            return m;
        }

        public double MilesToKm(double miles)
        {
            double km = miles * 1.6;
            return km;            
        }

        public void Clear()
        {
            choiceInput.Text = "";
            valueInput.Text = "";
            convertOutput.Text = "";
        }
    }
}
