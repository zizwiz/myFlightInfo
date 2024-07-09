using System;
using System.Diagnostics.Eventing.Reader;
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
            if (SpeedTimeFuelDataCheck(txtbx_speed_wind_speed.Text, txtbx_speed_wind_direction.Text, txtbx_speed_course.Text, txtbx_speed_true_airspeed.Text))
            {
                var results = Speed_Time_Fuel.Calculate_Speed_Time_fuel(txtbx_speed_true_airspeed,
                    txtbx_speed_wind_speed,
                    txtbx_speed_course, txtbx_speed_wind_direction, txtbx_speed_distance, txtbx_speed_fuel_consumption,
                    txtbx_min_landing_fuel);

                //results = WindCorrection, GroundSpeed, FlightTime, JourneyFuelLoad, FuelLoad

                rchtxbx_speed_time_fuel_output.Text = "";
                rchtxbx_speed_time_fuel_output.SelectionFont = new Font("Ariel", 12);
                rchtxbx_speed_time_fuel_output.AppendText("Wind Correction = " + results.Item1 + "°\r");
                rchtxbx_speed_time_fuel_output.SelectionFont = new Font("Ariel", 12);
                rchtxbx_speed_time_fuel_output.AppendText("Heading = " +
                                                          (Double.Parse(txtbx_speed_course.Text) + results.Item1) +
                                                          "°\r");
                rchtxbx_speed_time_fuel_output.SelectionFont = new Font("Ariel", 12);
                rchtxbx_speed_time_fuel_output.AppendText("Ground Speed = " + results.Item2 + "kts\r");

                //FlightTime = Distance in nautical miles / speed in knots
                rchtxbx_speed_time_fuel_output.SelectionFont = new Font("Ariel", 12);
                rchtxbx_speed_time_fuel_output.AppendText("\rFlight Time = " +
                                                          TimeSpan.FromHours(results.Item3).ToString("h\\:mm\\:ss") +
                                                          "\r");

                //Fuel Consumption = Flight Time * Hourly consumption rate
                rchtxbx_speed_time_fuel_output.SelectionFont = new Font("Ariel", 12);
                rchtxbx_speed_time_fuel_output.AppendText("\rMin journey fuel consumption = " + results.Item4 + "ℓ");

                rchtxbx_speed_time_fuel_output.SelectionFont = new Font("Ariel", 12);
                rchtxbx_speed_time_fuel_output.AppendText("\rMin takeoff fuel load = " + results.Item5 + "ℓ");

                rchtxbx_speed_time_fuel_output.SelectionFont = new Font("Ariel", 12);
                rchtxbx_speed_time_fuel_output.AppendText("\rFuel weight at takeoff= " +
                                                          results.Item5 *
                                                          Double.Parse(txtbx_speed_fuel_specific_gravity.Text) + "kg");

            }
            else
            {

            }





        }


        private bool SpeedTimeFuelDataCheck(string myWindStrength, string myDirection, string myCourse, string myAirspeed)
        {
            //catch for incomplete data
            if ((myWindStrength == "") || (myDirection == "") || (myCourse == "") || (myAirspeed == ""))
            {
                MsgBox.Show("Please fill in all the data", "Incomplete Data", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            //if (myWindStrength == "0")
            //{
            //    txtbx_direction.Text = "360";
            //    myDirection = "360";
            //}

            //Check data is in fact doubles.
            if (!CheckData.IsItADouble(myWindStrength))
            {

            }
            else if (double.Parse(myWindStrength) < 0)
            {
                MsgBox.Show("Check Wind speed is valid number (0 - 999)", "Data out of scope", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            else if (double.Parse(myWindStrength) > 253)
            {
                if (MsgBox.Show("Are you really sure that is the wind speed?", "New World Record for Wind Speed",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                {
                    ResetCrosswindGraphics();
                    return false;
                }
            }
            else if (!CheckData.IsItADouble(myDirection))
            {
                MsgBox.Show("Check Direction Data is a valid number (1° - 360°)", "Incorrect Data", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            else if ((double.Parse(myDirection) < 01) || (double.Parse(myDirection) > 360))
            {
                MsgBox.Show("Check Direction Data is a valid number (1° - 360°)", "Data out of scope",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }










            return true;
        }










    }
}
