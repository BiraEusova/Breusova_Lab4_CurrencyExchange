using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyExchange
{
    public partial class Form1 : Form
    {

        private Random random = new Random();
        private const double k = 0.1;
        private double capitalRuble;
        private double capitalEuro;
        private double rate;
        private int amount;
        private int purchaseCheck; // -1 - buy, 1 - sell, 0 - skip
        private int days;

        public Form1()
        {
            InitializeComponent();
            buyButton.Enabled = false;
            sellButton.Enabled = false;
            skipButton.Enabled = false;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            purchaseCheck = 1;
            days = 0;
            capitalEuro = 0;
            capitalRuble = (double)capitalNumericUpDown.Value;
            rate = (double)courseNumericUpDown.Value;

            remainderLabel.Text = Math.Round(capitalRuble, 3).ToString() + " ₽";
            euroLabel.Text = capitalEuro.ToString() + " €";

            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(0, rate);

            buyButton.Enabled = true;
            sellButton.Enabled = true;
            skipButton.Enabled = true;
        }

        private void calculation()
        {
            amount = (int)buyOrSellNumericUpDown.Value;

            if (Check(purchaseCheck, amount))
            {
                capitalRuble = capitalRuble + purchaseCheck * amount * rate;
                capitalEuro = capitalEuro - purchaseCheck * amount;

                remainderLabel.Text = Math.Round(capitalRuble, 3).ToString() + " ₽";
                euroLabel.Text = capitalEuro.ToString() + " €";

                rate = rate * (1 + k * (random.NextDouble() - 0.5));
                chart1.Series[0].Points.AddXY(++days, rate);

                if (capitalRuble < rate)
                    buyButton.Enabled = false;
                else buyButton.Enabled = true;

                if (capitalEuro <= 0)
                    sellButton.Enabled = false;
                else sellButton.Enabled = true;
            }
            
        }

        private bool Check(int k, int amount)
        {
            if (k == 1 && amount <= capitalEuro) return true;
            else if (k == -1 && amount * rate <= capitalRuble) return true;
            else if (k == 0) return true;
            else return false;
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            purchaseCheck = -1;
            calculation();
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            purchaseCheck = 1;
            calculation();
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            purchaseCheck = 0;
            calculation();
        }
    }
}
