using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroCsharpCollectSingleDoubleNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variable
        public int number1, numberOdd, numberDouble, restNumber, oddValue, doubleValue;
        #endregion


        private void buttonShowSum_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(textBoxNumber.Text);
            restNumber = number1 % 2;
            if (restNumber == 1)
            {
                labelShowPanel.Text = "TEK";
                labelShowPanel.TextAlign = ContentAlignment.MiddleCenter;
                labelShowPanel.BackColor = Color.AliceBlue;
                oddValue = oddValue + number1;

            }
            else
            {
                labelShowPanel.Text = "ÇİFT";
                labelShowPanel.TextAlign = ContentAlignment.MiddleCenter;
                labelShowPanel.BackColor = Color.AntiqueWhite;
                doubleValue = doubleValue + number1;
            }

            textBoxOddNumber.Text = oddValue.ToString();
            textBoxDoubleNumber.Text = doubleValue.ToString();
        }
    }
}

