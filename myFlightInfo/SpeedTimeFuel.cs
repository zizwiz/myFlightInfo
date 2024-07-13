using System;
using System.Drawing;
using System.Windows.Forms;
using CenteredMessagebox;
using myFlightInfo.crosswind;
using myFlightInfo.utils;

namespace myFlightInfo
{
    public partial class Form1
    {

        private void btn_calc_speed_time_fuel_Click(object sender, EventArgs e)
        {
            rchtxbx_speed_time_fuel_output.Text = "";

            try
            {
                if (SpeedDataCheck(txtbx_speed_wind_speed.Text, txtbx_speed_wind_direction.Text,
                         txtbx_speed_course.Text, txtbx_speed_true_airspeed.Text))
                {
                    bool TimeFuelFlag = TimeFuelCheck(txtbx_speed_distance.Text, txtbx_speed_fuel_consumption.Text,
                         txtbx_min_landing_fuel.Text, txtbx_speed_fuel_specific_gravity.Text);

                    var results = Speed_Time_Fuel.Calculate_Speed_Time_fuel(txtbx_speed_true_airspeed,
                            txtbx_speed_wind_speed,
                            txtbx_speed_course, txtbx_speed_wind_direction, txtbx_speed_distance,
                            txtbx_speed_fuel_consumption,
                            txtbx_min_landing_fuel, TimeFuelFlag);


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

                    if (results.Item3 != 999)
                    {
                        //FlightTime = Distance in nautical miles / speed in knots
                        rchtxbx_speed_time_fuel_output.SelectionFont = new Font("Ariel", 12);
                        rchtxbx_speed_time_fuel_output.AppendText("\rFlight Time = " +
                                                                  TimeSpan.FromHours(results.Item3)
                                                                      .ToString("h\\:mm\\:ss") +
                                                                  "\r");

                        //Fuel Consumption = Flight Time * Hourly consumption rate
                        rchtxbx_speed_time_fuel_output.SelectionFont = new Font("Ariel", 12);
                        rchtxbx_speed_time_fuel_output.AppendText("\rMin journey fuel consumption = " + results.Item4 +
                                                                  "ℓ");

                        rchtxbx_speed_time_fuel_output.SelectionFont = new Font("Ariel", 12);
                        rchtxbx_speed_time_fuel_output.AppendText("\rMin takeoff fuel load = " + results.Item5 + "ℓ");

                        rchtxbx_speed_time_fuel_output.SelectionFont = new Font("Ariel", 12);
                        rchtxbx_speed_time_fuel_output.AppendText("\rFuel weight at takeoff= " +
                                                                  results.Item5 *
                                                                  Double.Parse(txtbx_speed_fuel_specific_gravity.Text) +
                                                                  "kg");
                    }
                }
            }
            catch
            {
                //It did not work instead of crashing just put up hint and return gracefully
                MsgBox.Show("Something has gone wrong.\rPlease check data and try again", "Something is Wrong",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool SpeedDataCheck(string myWindStrength, string myDirection, string myCourse, string myAirspeed)
        {
            //catch for incomplete data
            if (myCourse == "")
            {
                MsgBox.Show("Please check Course has correct data", "Incomplete Course Data", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (myAirspeed == "")
            {
                MsgBox.Show("Please check True Airspeed has correct data", "Incomplete True Airspeed Data", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (myDirection == "")
            {
                MsgBox.Show("Please check Wind Direction has correct data", "Incomplete Wind Direction Data", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (myWindStrength == "")
            {
                MsgBox.Show("Please check Wind Speed has correct data", "Incomplete Wind Speed Data", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }


            //Check data is in fact doubles.
            if (!CheckData.IsItADouble(myWindStrength))
            {
                MsgBox.Show("Check Wind speed is a valid number.", "Incorrect Data", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (double.Parse(myWindStrength) < 0)
            {
                MsgBox.Show("Check Wind speed is valid number (0 - 999)", "Data out of scope", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (double.Parse(myWindStrength) > 253)
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
                MsgBox.Show("Check Direction Data is a valid number (0° - 360°)", "Incorrect Data", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            else if ((double.Parse(myDirection) < 0) || (double.Parse(myDirection) > 360))
            {
                MsgBox.Show("Check Direction Data is a valid number (0° - 360°)", "Data out of scope",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!CheckData.IsItADouble(myCourse))
            {
                MsgBox.Show("Check Course Data is a valid number (0° - 360°)", "Incorrect Data", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            else if ((double.Parse(myCourse) < 0) || (double.Parse(myCourse) > 360))
            {
                MsgBox.Show("Check Course Data is a valid number (0° - 360°)", "Data out of scope",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!CheckData.IsItADouble(myAirspeed))
            {
                MsgBox.Show("Check True Air Speed Data is a valid number", "Incorrect Data", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            else if ((double.Parse(myAirspeed) < 0) || (double.Parse(myAirspeed) > 999))
            {
                MsgBox.Show("Check True Air Speed Data is a valid number >0 and <999)", "Data out of scope",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private bool TimeFuelCheck(string myDistance, string myFuelConsumption, string myMinLandingFuel, string myFuelSpecificGravity)
        {
            //catch for incomplete data
            if (myDistance == "")
            {
                MsgBox.Show("Please add Distance and try again if you want Time and Fuel Calculations", "Incomplete Distance Data", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (myFuelConsumption == "")
            {
                MsgBox.Show("Please check data is correct for Fuel Consumption", "Incomplete Fuel Consumption Data", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (myMinLandingFuel == "")
            {
                MsgBox.Show("Please check data is correct for Min Landing Fuel", "Incomplete Min Landing Fuel Data", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (myFuelSpecificGravity == "")
            {
                MsgBox.Show("Please check data is correct for Fuel Specific Gravity", "Incomplete Fuel Specific Gravity Data", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }


            //Check data is in fact doubles.
            if (!CheckData.IsItADouble(myDistance))
            {
                MsgBox.Show("Check Distance is a valid number.", "Incorrect Data", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (!CheckData.IsItADouble(myFuelConsumption))
            {
                MsgBox.Show("Check Fuel Consumption is a valid number.", "Incorrect Data", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (!CheckData.IsItADouble(myMinLandingFuel))
            {
                MsgBox.Show("Check Minimum Landing Fuel is a valid number.", "Incorrect Data", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (!CheckData.IsItADouble(myFuelSpecificGravity))
            {
                MsgBox.Show("Check Specific Gravity of Fuel is a valid number.", "Incorrect Data", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
