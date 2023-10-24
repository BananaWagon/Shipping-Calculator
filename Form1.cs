//Author: Nestor Monteagudo
//Student ID: 649049
//Date: March 6, 2023
//Goal / Purpose of program: To calculate shipping cost using user inputted weight and cost zones.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShippingCalculator___NestorMonteagudo
{
    public partial class Form1 : Form
    {
        int _zoneCost;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Clears previous results
            weightCostOutputLabel.Text = string.Empty;
            zoneCostOutPutLabel.Text = string.Empty;
            totalShippingOutputLabel.Text = string.Empty;
            poundRateOutputLabel.Text = string.Empty;
            priceCappedImageBox.Visible = false;
            priceCappedLabel.Visible = false;

            //Calculations
            if (int.TryParse(packageWeightInputTextBox.Text, out int _packageWeight))
            {
                if (_packageWeight < 1) //Throws error if input for weight is less than 1.
                {
                    MessageBox.Show("Please input valid number for package weight. Valid number must be a whole number.");
                    return;
                }
                else
                {
                    //Variables
                    int _weightCost = _packageWeight * 18;
                    int _totalShipping;
                    const int _priceCap = 100;

                    //Determines value of _zoneCost.
                    if (nRadioButton.Checked)
                    {
                        _zoneCost = 27;
                    }
                    else if (sRadioButton.Checked)
                    {
                        _zoneCost = 36;
                    }
                    else if (eRadioButton.Checked)
                    {
                        _zoneCost = 45;
                    }
                    else if (wRadioButton.Checked)
                    {
                        _zoneCost = 54;
                    }
                    else
                    {
                        MessageBox.Show("Please select a shipping zone!");
                        return;
                    }

                    //Calculations for total shipping costs.
                    _totalShipping = _weightCost + _zoneCost;

                    //Caps the total shipping cost to the price cap.
                    if (_totalShipping > _priceCap)
                    {
                        _totalShipping = _priceCap;
                        priceCappedImageBox.Visible = true;
                        priceCappedLabel.Visible = true;
                    }

                    int _poundRate = _totalShipping / _packageWeight;

                    //Display output to program
                    weightCostOutputLabel.Text = _weightCost.ToString("C");
                    zoneCostOutPutLabel.Text = _zoneCost.ToString("C");
                    totalShippingOutputLabel.Text = _totalShipping.ToString("C");
                    poundRateOutputLabel.Text = _poundRate.ToString("C");
                }
            }
            //Shows user a message box with error and suggestion.
            else
            {
                MessageBox.Show("Please input valid number for package weight. Valid number must be a whole number.");
                return;
            }
        }
    }
}
