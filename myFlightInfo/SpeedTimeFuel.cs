using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using CenteredMessagebox;
using myFlightInfo.crosswind;
using myFlightInfo.Properties;
using myFlightInfo.utils;

namespace myFlightInfo
{
    public partial class Form1
    {

        private void btn_calc_speed_time_fuel_Click(object sender, EventArgs e)
        {


            var results = Speed_Time_Fuel.Calculate_Speed_Time_fuel(txtbx_speed_true_airspeed,
                txtbx_speed_wind_speed,
                txtbx_speed_course, txtbx_speed_wind_direction, txtbx_speed_distance, txtbx_speed_fuel_consumption,
                txtbx_min_landing_fuel, txtbx_speed_fuel_specific_gravity);

            //WindCorrection, GroundSpeed, FlightTime, JourneyFuelLoad, FuelLoad

            rchtxbx_speed_time_fuel_output.Text = "";
            rchtxbx_speed_time_fuel_output.AppendText("Wind Correction = " + results.Item1 + "°\r");
            rchtxbx_speed_time_fuel_output.AppendText("Heading = " + (Double.Parse(txtbx_speed_course.Text) + results.Item1) + "°\r");
            rchtxbx_speed_time_fuel_output.AppendText("Ground Speed = " + results.Item2 + "kts\r");

            //FlightTime = Distance in nautical miles / speed in knots
            //Double FlightTime = Double.Parse(myDistance.Text) / GroundSpeed;
            //rchtxbx_speed_time_fuel_output.AppendText("\rFlight Time = " + TimeSpan.FromHours(FlightTime).ToString("h\\:mm\\:ss") + "\r");

            //Fuel Consumption = Flight Time * Hourly consumption rate
            //Double JourneyFuelLoad = Math.Ceiling(FlightTime * Double.Parse(myFuelConsumption.Text));
            //rchtxbx_speed_time_fuel_output.AppendText("\rMin journey fuel consumption = " + JourneyFuelLoad + "ℓ");

            //Double FuelLoad = JourneyFuelLoad + Double.Parse(myMinLandingFuel.Text);
            //myRichTextBox.AppendText("\rMin takeoff fuel load = " + FuelLoad + "ℓ");

            //myRichTextBox.AppendText("\rFuel weight at takeoff= " + FuelLoad * Double.Parse(myFuelSpecificGravity.Text) + "kg");

             






        }













    }
}
