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
            bool TimeFuelFlag = true;

            try
            {
                if ((txtbx_speed_distance.Text == "")||(txtbx_speed_fuel_consumption.Text == "")||
                    (txtbx_min_landing_fuel.Text == "") || (txtbx_speed_fuel_specific_gravity.Text == ""))
                    
                    //&& TimeFuelCheck(txtbx_speed_fuel_consumption.Text,txtbx_min_landing_fuel.Text, txtbx_speed_fuel_specific_gravity.Text))
                {
                    TimeFuelFlag = false;
                }


                if (SpeedDataCheck(txtbx_speed_wind_speed.Text, txtbx_speed_wind_direction.Text,
                        txtbx_speed_course.Text, txtbx_speed_true_airspeed.Text))
                {
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
                else
                {
                    //It did not work instead of crashing just put up hint and return gracefully
                    MsgBox.Show("Something has gone wrong.\rPlease check data and try again", "Something is Wrong",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if ((myWindStrength == "") || (myDirection == "") || (myCourse == "") || (myAirspeed == ""))
            {
                MsgBox.Show("Please fill in all the data", "Incomplete Data", MessageBoxButtons.OK,
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
                MsgBox.Show("Check True Air Speed Data is a valid number)", "Data out of scope",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }




            return true;
        }


       


        private bool TimeFuelCheck(string myFuelConsumption, string myMinLandingFuel, string myFuelSpecificGravity)
        {
            //catch for incomplete data
            if ((myFuelConsumption == "") || (myMinLandingFuel == "") || (myFuelSpecificGravity == ""))
            {
                MsgBox.Show("Please data is correct for Fuel Consumption, Min Landing Fuel and Fuel Specific Gravity", "Incomplete Data", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }




            return true;
        }


    }
}
