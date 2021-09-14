using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Class created after clicking event on the 'Create Prize' button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            // If the form is valid, we need to create a model
            if (ValidateForm())
            {
                PrizeModel pModel = new PrizeModel(
                    placeNumberValue.Text,
                    placeNameValue.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text);

                // Save the model
                GlobalConfig.Connection.CreatePrize(pModel);

                // Clear out the form fields when done submitting the data.
                placeNumberValue.Text = "";
                placeNameValue.Text = "";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            // Validating the 'Place Number' field.
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

            if (!placeNumberValidNumber)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            // Validating the 'Place Name' field.
            if (placeNameValue.Text.Length == 0)
            {
                output = false;
            }

            // Validating the 'Price Amount' field.
            decimal prizeAmount = 0;
            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);

            // Validating the 'Price Percentage' field.
            double prizePercentage = 0;
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if (!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <=0)
            {
                output = false;
            }

            if(prizePercentage <0 || prizePercentage >100)
            {
                output = false;
            }


            return output;
        }

    }
}
