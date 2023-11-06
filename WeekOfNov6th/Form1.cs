using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfNov6th
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            var input = txtInput1.Text;
            
            if (rdoTempConverter1.Checked)
            {
                rtbOutput.Text += (float.Parse(input) * 9 / 5 + 32) + " Fahrenheit degress." + Environment.NewLine;
            }

            if (rdoTempConverter2.Checked)
            {
                rtbOutput.Text += (float.Parse(input) -32) * 5 / 9  + " Celsius degress." + Environment.NewLine;
            }

        }

        private void rdoTempConverter1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void btn2_Click(object sender, EventArgs e)
        {
            var input = txtInput1.Text;

            if (cmbMoneyConverter.SelectedItem.ToString() == "Yen to Dollar")
            {
                rtbOutput.Text += "Converting " + input + " from Yen to Dollar is " + (float.Parse(input) / 149.275) + Environment.NewLine;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Dollar to Yen")
            {
                rtbOutput.Text += "Converting " + input + " from Dollar to Yen is " + (float.Parse(input) * 149.275) + Environment.NewLine;
            }


            else if (cmbMoneyConverter.SelectedItem.ToString() == "Real to Dollar")
            {
                rtbOutput.Text += "Converting " + input + " from Real to Dollar is " + (float.Parse(input) / 5) + Environment.NewLine;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Dollar to Real")
            {
                rtbOutput.Text += "Converting " + input + " from Dollar to Real is " + (float.Parse(input) * 5) + Environment.NewLine;
            }


           else if (cmbMoneyConverter.SelectedItem.ToString() == "Pesos to Dollar")
            {
                rtbOutput.Text += "Converting " + input + " from Pesos to Dollar is " + (float.Parse(input) / 17.55) + Environment.NewLine;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Dollar to Pesos")
            {
                rtbOutput.Text += "Converting " + input + " from Dollar to Pesos is " + (float.Parse(input) * 17.55) + Environment.NewLine;
            }


           else if (cmbMoneyConverter.SelectedItem.ToString() == "Pesos to Real")
            {
                rtbOutput.Text += "Converting " + input + " from Pesos to Real is " + (float.Parse(input) / 3.58) + Environment.NewLine;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Real to Pesos")
            {
                rtbOutput.Text += "Converting " + input + " from Real to Pesos is " + (float.Parse(input) * 3.58) + Environment.NewLine;
            }



            else if (cmbMoneyConverter.SelectedItem.ToString() == "Real to Yen")
            {
                rtbOutput.Text += "Converting " + input + " from Real to Yen is " + (float.Parse(input) * 30.52) + Environment.NewLine;
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Yen to Real")
            {
                rtbOutput.Text += "Converting " + input + " from Yen to Real is " + (float.Parse(input) / 30.52) + Environment.NewLine;
            }

        }

        private void cmbMoneyConverter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            var input = txtInput1.Text;
            var input2 = txtInput2.Text;

            if (chkMileToKilo.Checked)
            {
                rtbOutput.Text += "Converting " + input + " from Miles to Kilometers is " + (float.Parse(input) * 1.6) + Environment.NewLine;
            }
            else if(chkMeterToInch.Checked)
            {
                rtbOutput.Text += "Converting " + input2 + " from Meters to Inches is " + (float.Parse(input2) * 39.37) + Environment.NewLine;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            var input = txtInput1.Text;
            var input2 = txtInput2.Text;

           if (chkKiloToMiles.Checked)
            {
                rtbOutput.Text += "Converting " + input + " from Kilometers to Miles is " + (float.Parse(input) / 1.6) + Environment.NewLine;
            }
            else if (chkInchToMeter.Checked)
            {
                rtbOutput.Text += "Converting " + input2 + " from Inches to Meters is " + (float.Parse(input) / 39.37) + Environment.NewLine;
            }

        }
    }
}
