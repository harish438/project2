using CarComparisonTool.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarComparisonTool
{
    public partial class Form1 : Form
    {
        CarUtil util = new CarUtil();
        public Form1()
        {
            InitializeComponent();
            label3.Text = "please click the ADD CARS-Button to add the cars to the below List.";
            //txtCars.Text
        }

        private void btnAddCars_Click(object sender, EventArgs e)
        {
            grdResult.DataSource = util.AddCars(txtCars.Text);
            label3.Text = "All the details of cars are added to the List.";           
        }

        private void btnNewestVehicles_Click(object sender, EventArgs e)
        {
            try
            {
                grdResult.DataSource = util.GetNewestVehicles();
                label3.Text = "Below is the list of new vehicles as per year.";
            }
            catch
            {
                label3.Text = "please click the ADD CARS-Button to add the cars to the below List.";
            }
            }

        private void btnAlphabetizedList_Click(object sender, EventArgs e)
        {
            try { 
            grdResult.DataSource = util.GetAlphabetizedList();
            label3.Text = "Below is the list of vehicles in Alphabetized order from A-Z.";
            }
            catch
            {
                label3.Text = "please click the ADD CARS-Button to add the cars to the below List.";
            }

        }

        private void btnVehiclesbyPrice_Click(object sender, EventArgs e)
        {
            try {
            grdResult.DataSource = util.GetVehiclesbyPrice();
            label3.Text = "Below is the list of vehicles from higher price to lower price.";
            }
            catch
            {
                label3.Text = "please click the ADD CARS-Button to add the cars to the below List.";
            }
        }

        private void btnFuelConsumption_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtDistance.Text);
                grdResult.DataSource = util.CalculateFuelConsumption(Convert.ToDecimal(txtDistance.Text));
                label3.Text = "Please check last column to see the fuel consumption of each vehicle for the give distance.";
            }
            catch
            {
                label3.Text = "You have not entered a number";
            }          
        }

        private void btnRandomCar_Click(object sender, EventArgs e)
        {
            try { 
            grdResult.DataSource = new List<Car> { util.GetRandomCar() };
            label3.Text = " Random car from the List of cars";
            }
            catch
            {
                label3.Text = "please click the ADD CARS-Button to add the cars to the below List.";
            }
        }

        private void btnAvgMiles_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtDistance.Text);
                grdResult.DataSource = util.GetAvgMiles(Convert.ToDecimal(txtDistance.Text));
                label3.Text = "Below is the list of average mpg of all vehicles for every year.";
            }
            catch
            {
                label3.Text = "You have not entered a number of miles.";
            }        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {                
            grdResult.DataSource = util.GetBestValue();
            label3.Text = "Below is the ordered list of vehicles with best value. The Top 1 is the best car with low cost, high mpg and good rating.";
            }
            catch
            {
                label3.Text = "please click the ADD CARS-Button to add the cars to the below List.";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
