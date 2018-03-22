using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverterForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnToCelcius_Click(object sender, EventArgs e)
        {
            float degreeFarenheit;

            if (!float.TryParse(txtTemperature.Text.Trim(), out degreeFarenheit))
            {
                MessageBox.Show("Please enter a valid temperature");
            }
            else
            {
                float degreeCelcius = TemperatureConverter.FarenheitToCelcius(degreeFarenheit);
                MessageBox.Show(string.Format("{0:f2}°F is {1:f2}°C", degreeFarenheit, degreeCelcius));
            }
        }

        private void btnToFarenheit_Click(object sender, EventArgs e)
        {
            float degreeCelcius;

            if (!float.TryParse(txtTemperature.Text.Trim(), out degreeCelcius))
            {
                MessageBox.Show("Please enter a valid temperature");
            }
            else
            {
                float degreeFarenheit = TemperatureConverter.CelciusToFarenheit(degreeCelcius);
                MessageBox.Show(string.Format("{0:f2}°C is {1:f2}°F", degreeCelcius, degreeFarenheit));
            }
        }
    }
}
