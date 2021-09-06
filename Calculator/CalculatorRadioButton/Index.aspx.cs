using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorRadioButton
{
    public partial class Index : System.Web.UI.Page
    {
        double number1;
        double number2;
        double result;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           if(rbAddition.Checked == true)
            {
                number1 = double.Parse(txtNumber1.Text);
                number2 = double.Parse(txtNumber2.Text);

                result = number1 + number2;

                lblResult.Text = "The result is: " + result.ToString();
                lblResult.ForeColor = System.Drawing.Color.Blue;
                lblDisplay.Text = "Addition";
                lblDisplay.ForeColor = System.Drawing.Color.Blue;
            }
            else if(rbSubtraction.Checked == true)
            {
                number1 = double.Parse(txtNumber1.Text);
                number2 = double.Parse(txtNumber2.Text);

                result = number1 - number2;

                lblResult.Text = "The result is: " + result.ToString();
                lblResult.ForeColor = System.Drawing.Color.Red;
                lblDisplay.Text = "Subtraction";
                lblDisplay.ForeColor = System.Drawing.Color.Red;
            }
            else if(rbMultiplication.Checked == true)
            {
                number1 = double.Parse(txtNumber1.Text);
                number2 = double.Parse(txtNumber2.Text);

                result = number1 * number2;

                lblResult.Text = "The result is: " + result.ToString();
                lblResult.ForeColor = System.Drawing.Color.Green;
                lblDisplay.Text = "Multiplication";
                lblDisplay.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                number1 = double.Parse(txtNumber1.Text);
                number2 = double.Parse(txtNumber2.Text);

                result = number1 / number2;

                lblResult.Text = "The result is: " + result.ToString();
                lblResult.ForeColor = System.Drawing.Color.DarkViolet;
                lblDisplay.Text = "Division";
                lblDisplay.ForeColor = System.Drawing.Color.DarkViolet;
            }
        }

        protected void rbAddition_CheckedChanged(object sender, EventArgs e)
        {
            number1 = double.Parse(txtNumber1.Text);
            number2 = double.Parse(txtNumber2.Text);

            result = number1 + number2;

            lblResult.Text = "The result is: " + result.ToString();
            lblResult.ForeColor = System.Drawing.Color.Blue;
            lblDisplay.Text = "Addition";
            lblDisplay.ForeColor = System.Drawing.Color.Blue;
        }

        protected void rbSubtraction_CheckedChanged(object sender, EventArgs e)
        {
            number1 = double.Parse(txtNumber1.Text);
            number2 = double.Parse(txtNumber2.Text);

            result = number1 - number2;

            lblResult.Text = "The result is: " + result.ToString();
            lblResult.ForeColor = System.Drawing.Color.Red;
            lblDisplay.Text = "Subtraction";
            lblDisplay.ForeColor = System.Drawing.Color.Red;
        }

        protected void rbMultiplication_CheckedChanged(object sender, EventArgs e)
        {
            number1 = double.Parse(txtNumber1.Text);
            number2 = double.Parse(txtNumber2.Text);

            result = number1 * number2;

            lblResult.Text = "The result is: " + result.ToString();
            lblResult.ForeColor = System.Drawing.Color.Green;
            lblDisplay.Text = "Multiplication";
            lblDisplay.ForeColor = System.Drawing.Color.Green;
        }

        protected void rbDivision_CheckedChanged(object sender, EventArgs e)
        {
            number1 = double.Parse(txtNumber1.Text);
            number2 = double.Parse(txtNumber2.Text);

            result = number1 / number2;

            lblResult.Text = "The result is: " + result.ToString();
            lblResult.ForeColor = System.Drawing.Color.DarkViolet;
            lblDisplay.Text = "Division";
            lblDisplay.ForeColor = System.Drawing.Color.DarkViolet;
        }
    }
}