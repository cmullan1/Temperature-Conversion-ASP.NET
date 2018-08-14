/*
 * CPGR214 Lab1
 * Author:  Corinne Mullan
 * Date:    July 19, 2018
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG214_Lab1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            // Local variables
            double tempFrom;        // The temperature value to convert from
            double tempTo = 0;      // The converted temperature

            string unitsFrom;       // The units to convert from
            string unitsTo;         // The units to convert to

            // Obtain the input values
            tempFrom = Convert.ToDouble(txtFromTemperature.Text);

            unitsFrom = ddlFromUnits.SelectedValue;
            unitsTo = ddlToUnits.SelectedValue;

            // First check the value is not below absolute zero
            if ((unitsFrom == "Celsius" && tempFrom < -273.15) ||
                (unitsFrom == "Fahrenheit" && tempFrom < -459.67) ||
                (unitsFrom == "Kelvin" && tempFrom < 0.0))
            {
                lblError.Text = "Error: temperature cannot be less than absolute zero";
                txtToTemperature.Text = "";
            }
            else
            // If the input value is good, perform the calculation
            {
                lblError.Text = "";

                // If the unitsFrom and unitsTo are the same, tempTo = tempFrom
                if (unitsFrom == unitsTo)
                {
                    tempTo = tempFrom;
                }
                // Else perform the required conversion calculation
                else if (unitsFrom == "Celsius")
                {
                    if (unitsTo == "Fahrenheit")
                    {
                        // Convert from Celcius to Fahrenheit
                        tempTo = 9.0 / 5.0 * tempFrom + 32.0;
                    }
                    else if (unitsTo == "Kelvin")
                    {
                        // Convert from Celcius to Kelvin
                        tempTo = tempFrom + 273.15;
                    }
                }
                else if (unitsFrom == "Fahrenheit")
                {
                    if (unitsTo == "Celsius")
                    {
                        // Convert from Fahrenheit to Celsius
                        tempTo = (tempFrom - 32.0) * 5.0 / 9.0;
                    }
                    else if (unitsTo == "Kelvin")
                    {
                        // Convert from Fahrenheit to Kelvin
                        tempTo = (tempFrom - 32.0) * 5.0 / 9.0 + 273.15;
                    }
                }
                else if (unitsFrom == "Kelvin")
                {
                    if (unitsTo == "Celsius")
                    {
                        // Convert from Kelvin to Celsius
                        tempTo = tempFrom - 273.15;

                    }
                    else if (unitsTo == "Fahrenheit")
                    {
                        // Convert from Kelvin to Fahrenheit
                        tempTo = 9.0 / 5.0 * (tempFrom - 273.15) + 32.0;
                    }
                }

                // Output the converted value, rounding to at most one decimal place
                txtToTemperature.Text = tempTo.ToString("0.##");
            }
        }

        // Reset the controls when the clear button is clicked
        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtFromTemperature.Text = "";
            txtToTemperature.Text = "";
            ddlFromUnits.SelectedValue = "Celsius";
            ddlToUnits.SelectedValue = "Fahrenheit";
            lblError.Text = "";
        }
    }
}