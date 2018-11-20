// Grading ID: A5508
// Program 1
// Due: February 14, 2017
// CIS 199-01
// Program 1 allows you to figure out the total cost of a paint job based on the inputs of:
// square feet of wall space to be painted, number of coats of paint desired, and
//price of paint per gallon.








using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project__1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float wallSpace;  // total wall space in square feet
        int coats_1;  // number of coats applied
        float paintCostPerGallon;  // paint cost per gallon
        float squareFeetToPaint;  //  square feet to paint
        float gallonsRequired;  //  gallons of paint needed
        float laborHoursRequired;  // labor hours needed
        float paintCostTotal;  // total cost of paint
        float laborCostTotal;  // total cost of labor
        float totalPrice;  //total price of paint job

        const float laborPrice = 10.50f;  // establishes labor price
        const float wallSpaceCoveragePerGal = 330f;  // establishes wall space coverage per gallon of paint in square feet
        const int laborHoursPerGal = 6;  // labor hours per gallon of paint

        private void submitButton_Click(object sender, EventArgs e)
        {

            squareFeetToPaint = float.Parse(wallSpaceTextBox.Text);  // convert input into float

            coats_1 = int.Parse(coatsTextBox.Text);  // convert input into integer

            squareFeetToPaint = squareFeetToPaint * coats_1;  // determine value of square feet to paint

            totalSqFtOutputLabel.Text = squareFeetToPaint.ToString("F1");  // display square feet of paint with 1 decimal place




            gallonsRequired = squareFeetToPaint / wallSpaceCoveragePerGal;  //  determine value of gallons of paint required

            gallonsOutputLabel.Text = Math.Ceiling(gallonsRequired).ToString("N0");  //  display gallons required while rounding up
                                                                                     // and no decimal place



            laborHoursRequired = laborHoursPerGal * gallonsRequired;  // determine value of labor hours required

            hoursOutputLabel.Text = laborHoursRequired.ToString("F1");  // display labor hours required with 1 decimal place





            paintCostPerGallon = float.Parse(pricePerGallonTextBox.Text);  // change paint cost per gallon to float number

            paintCostTotal = float.Parse(gallonsOutputLabel.Text) * paintCostPerGallon;  // determine value of paint cost

            paintPriceOutputLabel.Text = paintCostTotal.ToString("c");  // display paint price in currency format




            laborCostTotal = laborPrice * laborHoursRequired;  // determine value of labor cost total

            laborPriceOutputLabel.Text = laborCostTotal.ToString("c");  // display value for labor price




            totalPrice = paintCostTotal + laborCostTotal;  // determine value for the total price of paint job

            totalPriceOutputLabel.Text = totalPrice.ToString("c");  // display total price of paint job

        }































        }
    }

