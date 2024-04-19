using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CenteredMessagebox;
using myFlightInfo.crosswind;
using myFlightInfo.Properties;
using myFlightInfo.utils;

namespace myFlightInfo
{
    public partial class Form1
    {

        private void btn_calc_wind_Click(object sender, EventArgs e)
        {
            //check data is OK if not just return
            if (!DataCheck(txtbx_magnitude.Text, txtbx_direction.Text, txtbx_runway_heading.Text))
            {
                return;
            }

            //if data OK then we reset Graphics just in case already set
            ResetCrosswindGraphics();

            //Get cross wind figures. Returns results which is a mixed array of items.
            var results =
                Crosswind.CalculateWind(txtbx_magnitude.Text, txtbx_direction.Text, txtbx_runway_heading.Text);

            //We will not write and draw figures to screen
            bool StarboardFlag = false;
            bool RunwayFlag = true;
            string RunwayToUse = "";
            double RunwayHeading1 = double.Parse(results.Item1);
            double RunwayHeading2 = double.Parse(results.Item4);
            double crossWind1 = Math.Ceiling(double.Parse(results.Item2));
            double crossWind2 = Math.Ceiling(double.Parse(results.Item5));
            double crosswind3 = 0;
            double headwind = 0;
            double windSpeed1 = Math.Ceiling(double.Parse(results.Item3));
            double windSpeed2 = Math.Ceiling(double.Parse(results.Item6));
            double MaxCrossWindAllowed = Settings.Default.MaxCrossWind;
            float HeadwindMultiplier;
            float CrosswindMultiplier;


            //Runway 1 data - runway Chosen by user
            if (crossWind1 > MaxCrossWindAllowed)
            {
                lbl_runway_heading1.ForeColor = Color.Red;
                lbl_crosswind_1.ForeColor = Color.Red;
                lbl_headwind_1.ForeColor = Color.Red;
            }
            else if (windSpeed1 < 0)
            {
                lbl_runway_heading1.ForeColor = Color.Red;
                lbl_crosswind_1.ForeColor = Color.Red;
                lbl_headwind_1.ForeColor = Color.Red;
            }
            else
            {
                lbl_runway_heading1.ForeColor = Color.Green;
                lbl_crosswind_1.ForeColor = Color.Green;
                lbl_headwind_1.ForeColor = Color.Green;
            }

            lbl_runway_heading1.Text = "Runway " + RunwayHeading1;

            if (crossWind1 > 0)
            {
                lbl_crosswind_1.Text = "Crosswind = " + crossWind1 + "kts from Starboard side";
                StarboardFlag = true;
            }
            else if (crossWind1 < 0)
            {
                lbl_crosswind_1.Text = "Crosswind = " + (crossWind1 * -1) + "kts from Port side";
                StarboardFlag = false;
            }
            else
            {
                lbl_crosswind_1.Text = "No crosswind detected";
            }


            if (windSpeed1 > 0)
            {
                lbl_headwind_1.Text = "Headwind = " + windSpeed1 + "kts";
                RunwayToUse = RunwayHeading1.ToString();
                crosswind3 = (crossWind1 > 0) ? crossWind1 : (crossWind1 * -1);
                headwind = windSpeed1;
            }
            else if (windSpeed1 < 0)
            {

                lbl_headwind_1.Text = "Tailwind = " + (windSpeed1 * -1) + "kts";
            }
            else
            {
                lbl_headwind_1.Text = "No wind detected";
            }


            //Runway 2 data

            if (crossWind2 > MaxCrossWindAllowed)
            {
                lbl_runway_heading2.ForeColor = Color.Red;
                lbl_crosswind_2.ForeColor = Color.Red;
                lbl_headwind_2.ForeColor = Color.Red;
            }
            else if (windSpeed2 < 0)
            {
                lbl_runway_heading2.ForeColor = Color.Red;
                lbl_crosswind_2.ForeColor = Color.Red;
                lbl_headwind_2.ForeColor = Color.Red;
            }
            else
            {
                lbl_runway_heading2.ForeColor = Color.Green;
                lbl_crosswind_2.ForeColor = Color.Green;
                lbl_headwind_2.ForeColor = Color.Green;
            }

            lbl_runway_heading2.Text = "Runway " + RunwayHeading2;

            if (crossWind2 > 0)
            {
                lbl_crosswind_2.Text = "Crosswind = " + crossWind2 + "kts from Starboard side";
                StarboardFlag = true;
            }
            else if (crossWind2 < 0)
            {
                lbl_crosswind_2.Text = "Crosswind = " + (crossWind2 * -1) + "kts from Port side";
                StarboardFlag = false;
            }
            else
            {
                lbl_crosswind_2.Text = "No crosswind detected";
            }

            if (windSpeed2 > 0)
            {
                lbl_headwind_2.Text = "Headwind = " + windSpeed2 + "kts";
                RunwayToUse = RunwayHeading2.ToString();
                crosswind3 = (crossWind2 > 0) ? crossWind2 : (crossWind2 * -1);
                headwind = windSpeed2;
            }
            else if (windSpeed2 < 0)
            {
                lbl_headwind_2.Text = "Tailwind = " + (windSpeed2 * -1) + "kts";
            }
            else
            {
                lbl_headwind_2.Text = "No wind detected";
            }

            //Runway to use
            if (crosswind3 > MaxCrossWindAllowed)
            {
                lbl_RunwayToUse.ForeColor = Color.Red;

                lbl_RunwayToUse.Text =
                    "Not safe to take off.\rCrosswind component is above maximumum allowed for safe takeoff.";
                RunwayFlag = false;
            }
            else
            {
                lbl_RunwayToUse.ForeColor = Color.Green;

                if (RunwayToUse == "")
                {
                    lbl_RunwayToUse.Text = "Runway to use = " + (double.Parse(txtbx_runway_heading.Text));
                }
                else
                {
                    lbl_RunwayToUse.Text = "Runway to use = " + RunwayToUse;
                }
            }

            //Draw the graphics
            Application.DoEvents();
            Graphics RunwayGraphic = picbx_crosswind.CreateGraphics();

            //We now choose to draw a line, you can draw many other things like square circle etc.
            //All the parameters come from the UI
            //The scale we are using is to divide the values by 3. This allows the values to be shown on the
            //graphics screen.

            if (RunwayToUse == txtbx_runway_heading.Text) //used when you choose tailwind runway, app always wants headwind for takeoff. 
            {
                if (StarboardFlag)
                {
                    StarboardFlag = false;
                }
                else
                {
                    StarboardFlag = true;
                }
            }

            if (crosswind3 == headwind)
            {
                CrosswindMultiplier = 1;
                HeadwindMultiplier = 1;
            }
            else if (crosswind3 > headwind)
            {
                CrosswindMultiplier = 2;
                HeadwindMultiplier = 1;
            }
            else
            {
                CrosswindMultiplier = 1;
                HeadwindMultiplier = 2;
            }

            //Draw the crosswind and headwind arrows
            if (StarboardFlag) //starboard side
            {
                PaintWindComponent_kts(CrosswindMultiplier, 180, 20, 130, 20,
                    RunwayGraphic, Math.Round(crosswind3, 0) + "kts", new Font("Arial", 12),
                    Color.Yellow, 80, 10);

                PaintWindComponent_kts(HeadwindMultiplier, 180, 20, 180, 60,
                    RunwayGraphic, Math.Round(headwind, 0) + "kts", new Font("Arial", 12),
                    Color.Yellow, 130, 65);

            }
            else //port side
            {
                PaintWindComponent_kts(CrosswindMultiplier, 15, 20, 65, 20,
                        RunwayGraphic, Math.Round(crosswind3, 0) + "kts", new Font("Arial", 12),
                        Color.Yellow, 68, 10);

                PaintWindComponent_kts(HeadwindMultiplier, 15, 20, 15, 60,
                        RunwayGraphic, Math.Round(headwind, 0) + "kts", new Font("Arial", 12),
                        Color.Yellow, 5, 65);
            }



            // Draw runway number
            if (crossWind1 == 0)
            {
                if (headwind == 0)
                {
                    RunwayGraphic.DrawString(RunwayHeading1 + "/" + RunwayHeading2, new Font("Arial", 50), new SolidBrush(Color.White),
                        new Point(0, 120));
                }
                else
                {
                    RunwayGraphic.DrawString(RunwayToUse, new Font("Arial", 50), new SolidBrush(Color.White), new Point(40, 120));
                }

                PaintWindComponent_kts(HeadwindMultiplier, 180, 20, 130, 20,
                    RunwayGraphic, Math.Round(headwind, 0) + "kts", new Font("Arial", 12),
                    Color.Yellow, 160, 65);

                PaintWindComponent_kts(HeadwindMultiplier, 180, 20, 180, 60,
                    RunwayGraphic, Math.Round(headwind, 0) + "kts", new Font("Arial", 12),
                    Color.Yellow, 160, 65);
            }
            else
            {
                if (RunwayFlag)
                {
                    RunwayGraphic.DrawString(RunwayToUse, new Font("Arial", 50), new SolidBrush(Color.White), new Point(40, 120));
                }
                else //wind exceeds aircraft max limits
                {
                    RunwayGraphic.DrawString("X", new Font("Arial", 50), new SolidBrush(Color.White), new Point(60, 120));
                }
            }
        }


        private bool PaintWindComponent_kts(double myLineWidthMultiplier, int myCrossWindLineStartX, int myCrossWindLineStartY, int myCrossWindLineEndX, int myCrossWindLineEndY,
                                            Graphics myRunwayGraphic, string myRunwayNumber, Font myFont,
                                            Color myColor, int myCrossWindDataStringXCoOrd, int myCrossWindDataStringYCoOrd)
        {
            try
            {
                Pen myPen = new Pen(new SolidBrush(myColor), 4f * (float)(myLineWidthMultiplier));

                //Specify the EndCap and StartCap for line we start with circle and end with arrowhead
                myPen.EndCap = LineCap.ArrowAnchor;
                myPen.StartCap = LineCap.RoundAnchor;

                // Draw line and write in wind strength in knots
                myRunwayGraphic.DrawLine(myPen, myCrossWindLineStartX, myCrossWindLineStartY, myCrossWindLineEndX, myCrossWindLineEndY); //to do change to read in numbers

                //Draw in runway number
                myRunwayGraphic.DrawString(myRunwayNumber, myFont, new SolidBrush(myColor),
                                new Point(myCrossWindDataStringXCoOrd, myCrossWindDataStringYCoOrd));
                return true;
            }
            catch
            {
                //It did not work instead of crashing just put up hint and return gracefully
                MsgBox.Show("Something has gone wrong.\rPlease check data and try again", "Something is Wrong",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void btn_crosswind_reset_Click(object sender, EventArgs e)
        {
            txtbx_magnitude.Text = "";
            txtbx_direction.Text = "";
            txtbx_runway_heading.Text = "";
            lbl_runway_heading1.Text = "";
            lbl_crosswind_1.Text = "";
            lbl_headwind_1.Text = "";
            lbl_runway_heading2.Text = "";
            lbl_crosswind_2.Text = "";
            lbl_headwind_2.Text = "";
            lbl_RunwayToUse.Text = "";
            ResetCrosswindGraphics();
        }

        private void ResetCrosswindGraphics()
        {
            //reset graphics
            picbx_crosswind.Image = null;
            picbx_crosswind.Invalidate();
            picbx_crosswind.Image = Properties.Resources.crosswind_runway;
        }


        private bool DataCheck(string myWindStrength, string myDirection, string myRunwayHeading)
        {
            if (myWindStrength == "0")
            {
                txtbx_direction.Text = "360";
                myDirection = "360";
            }

            //catch for incomplete data
            if ((myWindStrength == "") || (myDirection == "") || (myRunwayHeading == ""))
            {
                MsgBox.Show("Please fill in all the data", "Incomplete Data", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

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
                MsgBox.Show("Check Direction Data is a valid number (0 - 360)", "Incorrect Data", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            else if ((double.Parse(myDirection) < 01) || (double.Parse(myDirection) > 360))
            {
                MsgBox.Show("Check Direction Data is a valid number (0 - 360)", "Data out of scope",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!CheckData.IsItADouble(myRunwayHeading))
            {
                MsgBox.Show("Check Runway Heading is valid (01 - 36)", "Incorrect Data", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            else if ((double.Parse(myRunwayHeading) < 01) || (double.Parse(myRunwayHeading) > 36))
            {
                MsgBox.Show("Check Runway Heading is valid (01 - 36)", "Data out of scope", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;


        }






    }
}