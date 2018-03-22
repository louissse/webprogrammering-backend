using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyCalculaterForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnToEuro_Click(object sender, EventArgs e)
        {
            float amountInDkk;
            if (!float.TryParse(txtAmount.Text.Trim(), out amountInDkk))
            {
                MessageBox.Show("You must type in a valid value for the amount.");
            }
            else {
                float amountInEuro = CurrencyConverter.DkkToEuro(amountInDkk);
                MessageBox.Show(string.Format("{0} DKK is {1} EURO", amountInDkk, amountInEuro));
            };

        }

        private void btnToDkk_Click(object sender, EventArgs e)
        {
            float amountInEuro;
            if (!float.TryParse(txtAmount.Text.Trim(), out amountInEuro))
            {
                MessageBox.Show("You must type in a valid value for the amount.");
            }
            else
            {
                float amountInDkk = CurrencyConverter.EuroToDkk(amountInEuro);
                MessageBox.Show(string.Format("{0} EURO is {1} DKK", amountInEuro, amountInDkk));
            };


        }
    }
}
