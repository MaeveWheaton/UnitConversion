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
            int conversionChoice = Convert.ToInt32(choiceInput.Text);
            double value = Convert.ToDouble(valueInput.Text);

            if (conversionChoice == 1)
            {
                InchesToCm(value);
            }
            else if (conversionChoice == 2)
            {
                FeetToCm(value);
            }
            else if (conversionChoice == 3)
            {
                YardsToMetres(value);
            }
            else if (conversionChoice == 4)
            {
                MilesToKm(value);
            }
            else
            {
                choiceInput.Text = "";
                convertOutput.Text = "Please enter number from 1-4";
            }
        }

        public void InchesToCm(double inches)
        {
            double cm = inches * 2.54;

            convertOutput.Text = $"{inches} inches = {cm.ToString("0.00")} centimetres";
        }

        public void FeetToCm(double feet)
        {
            double cm = feet * 30.48;

            convertOutput.Text = $"{feet} feet = {cm.ToString("0.00")} centimetres";
        }

        public void YardsToMetres(double yards)
        {
            double m = yards * 0.91;

            convertOutput.Text = $"{yards} yards = {m.ToString("0.00")} metres";
        }

        public void MilesToKm(double miles)
        {
            double km = miles * 1.6;

            convertOutput.Text = $"{miles} miles = {km.ToString("0.00")} kilometres";
        }
    }
}
