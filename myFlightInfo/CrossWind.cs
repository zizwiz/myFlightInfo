﻿using System;
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
            /*
             *Input (all from UI)
                magnitude
                direction
                runway_heading
               
               Output
                runway_heading = runway in UI
                    crosswind1 = on runway_heading
                    headwind1 = on runway_heading
               
                runway_heading2 = reciprocal of runway in UI
                    crosswind2 = on runway_heading2
                    headwind2 = on runway_heading2
              */

            var results =
                Crosswind.CalculateWind(txtbx_magnitude.Text, txtbx_direction.Text, txtbx_runway_heading.Text);

            //We will not write and draw figures to screen
            bool StarboardFlag = false;
            bool RunwayFlag = true;

            string RunwayToUse = "";

            //from UI data
            double RunwayHeading1 = double.Parse(results.Item1);
            double crossWind1 = Math.Ceiling(double.Parse(results.Item2));
            double headwind1 = Math.Ceiling(double.Parse(results.Item3));

            //from reciprocal to UI data
            double RunwayHeading2 = double.Parse(results.Item4);
            double crossWind2 = Math.Ceiling(double.Parse(results.Item5));
            double headwind2 = Math.Ceiling(double.Parse(results.Item6));

            double crosswind3 = 0;
            double headwind3 = 0;

            double MaxCrossWindAllowed = Settings.Default.MaxCrossWind;

            float HeadwindMultiplier;
            float CrosswindMultiplier;


            //Runway 1 data - runway Chosen by user
            // Set colours we will write labels with
            if (crossWind1 > MaxCrossWindAllowed) //Cross wind exceeds max allowed for aircraft

            {
                lbl_runway_heading1.ForeColor = Color.Red;
                lbl_crosswind_1.ForeColor = Color.Red;
                lbl_headwind_1.ForeColor = Color.Red;
            }
            else if (headwind1 < 0) //a minus headwind means tailwind. We take off into headwind only. crosswind within limits 
            {
                lbl_runway_heading1.ForeColor = Color.Red;
                lbl_crosswind_1.ForeColor = Color.Red;
                lbl_headwind_1.ForeColor = Color.Red;
            }
            else //headwind and crosswind within limits so good to takeoff
            {
                lbl_runway_heading1.ForeColor = Color.Green;
                lbl_crosswind_1.ForeColor = Color.Green;
                lbl_headwind_1.ForeColor = Color.Green;
            }

            //write text to UI
            lbl_runway_heading1.Text = "Runway " + RunwayHeading1;

            if (crossWind1 > 0) //Starboard crosswind on RunwayHeading1
            {
                lbl_crosswind_1.Text = "Crosswind = " + crossWind1 + "kts from Starboard side";
                StarboardFlag = true;
            }
            else if (crossWind1 < 0) //Port side crosswind on RunwayHeading1
            {
                lbl_crosswind_1.Text = "Crosswind = " + (crossWind1 * -1) + "kts from Port side";
            }
            else //No crosswind across RunwayHeading1
            {
                lbl_crosswind_1.Text = "No crosswind detected";
            }


            if (headwind1 > 0) //Headwind on RunwayHeading1
            {
                lbl_headwind_1.Text = "Headwind = " + headwind1 + "kts";
                RunwayToUse = RunwayHeading1.ToString(); //This is headwind so use RunwayHeading1
                crosswind3 = (crossWind1 > 0) ? crossWind1 : (crossWind1 * -1); //Make crosswind1 positive figure
                headwind3 = headwind1; //Use headwind1 as the headwind
            }
            else if (headwind1 < 0) //Tailwind on RunwayHeading1
            {

                lbl_headwind_1.Text = "Tailwind = " + (headwind1 * -1) + "kts";
            }
            else //No Headwind or Tailwind on RunwayHeading1
            {
                lbl_headwind_1.Text = "No wind detected";
            }


            //Runway 2 data (reciprocal runway to that in UI)
            // Set colours we will write labels with

            if (crossWind2 > MaxCrossWindAllowed) //Cross wind exceeds max allowed for aircraft
            {
                lbl_runway_heading2.ForeColor = Color.Red;
                lbl_crosswind_2.ForeColor = Color.Red;
                lbl_headwind_2.ForeColor = Color.Red;
            }
            else if (headwind2 < 0) //a minus headwind means tailwind. We take off into headwind only. crosswind within limits 
            {
                lbl_runway_heading2.ForeColor = Color.Red;
                lbl_crosswind_2.ForeColor = Color.Red;
                lbl_headwind_2.ForeColor = Color.Red;
            }
            else //headwind and crosswind within limits so good to takeoff
            {
                lbl_runway_heading2.ForeColor = Color.Green;
                lbl_crosswind_2.ForeColor = Color.Green;
                lbl_headwind_2.ForeColor = Color.Green;
            }

            //write text to UI
            lbl_runway_heading2.Text = "Runway " + RunwayHeading2;

            if (crossWind2 > 0) //Starboard crosswind on reciprocal runway
            {
                lbl_crosswind_2.Text = "Crosswind = " + crossWind2 + "kts from Starboard side";
                StarboardFlag = true;
            }
            else if (crossWind2 < 0) //Port side crosswind on reciprocal runway
            {
                lbl_crosswind_2.Text = "Crosswind = " + (crossWind2 * -1) + "kts from Port side";
                StarboardFlag = false;
            }
            else //No Headwind or Tailwind on reciprocal runway
            {
                lbl_crosswind_2.Text = "No crosswind detected";
            }

            if (headwind2 > 0) //Headwind on reciprocal runway
            {
                lbl_headwind_2.Text = "Headwind = " + headwind2 + "kts";
                RunwayToUse = RunwayHeading2.ToString(); //This is headwind so use RunwayHeading2
                crosswind3 = (crossWind2 > 0) ? crossWind2 : (crossWind2 * -1); //Make crosswind2 positive figure
                headwind3 = headwind2; //Use headwind2 as the headwind
            }
            else if (headwind2 < 0) //Tailwind on reciprocal runway
            {
                lbl_headwind_2.Text = "Tailwind = " + (headwind2 * -1) + "kts";
            }
            else
            {
                lbl_headwind_2.Text = "No wind detected"; //No Headwind or Tailwind on reciprocal runway
            }

            // Check if crosswind within limits if not advise via UI that runway is closed so do not take-off
            if (crosswind3 > MaxCrossWindAllowed)
            {
                lbl_RunwayToUse.ForeColor = Color.Red;

                lbl_RunwayToUse.Text =
                    "Not safe to take off.\rCrosswind component is above maximumum allowed for safe takeoff.";
                RunwayFlag = false;
            }
            else // Crosswind OK. We can write runway to use to UI. 
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

            //////////////////////////////////////////////////////////////////////////
            // Now we know the runway, headwind and crosswind we draw the graphics
            //////////////////////////////////////////////////////////////////////////

            Application.DoEvents();
            Graphics RunwayGraphic = picbx_crosswind.CreateGraphics();


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

            if (crosswind3 == headwind3)
            {
                CrosswindMultiplier = 1;
                HeadwindMultiplier = 1;
            }
            else if (crosswind3 > headwind3)
            {
                CrosswindMultiplier = 2;
                HeadwindMultiplier = 1;
            }
            else //crosswind < headwind
            {
                CrosswindMultiplier = 1;
                HeadwindMultiplier = 2;
            }

            // when there is no crosswind we set multiplier to 1
            if (crosswind3 == 0)
            {
                CrosswindMultiplier = 1;
            }

            // when there is no headwind we set multiplier to 1
            if (headwind3 == 0)
            {
                HeadwindMultiplier = 1;
            }


            if (crosswind3 > MaxCrossWindAllowed) // crosswind exceeds limits
            {
                RunwayGraphic.DrawString("X", new Font("Arial", 50), new SolidBrush(Color.White), new Point(60, 120));
            }
            else // Crosswind OK. We can write runway to use to UI. 
            {
                if (crosswind3 == 0 && headwind3 == 0) // no wind use any runway.
                {
                    // Paint Runway marking
                    RunwayGraphic.DrawString(RunwayHeading1 + "/" + RunwayHeading2, new Font("Arial", 50),
                        new SolidBrush(Color.White),
                        new Point(0, 120));

                    // Draw both wind arrows. only write crosswind number once
                    PaintDataOnToRunwayGraphics(1, 180, 20, 130, 20,
                        RunwayGraphic, "", new Font("Arial", 12),
                        Color.Yellow, 80, 10);

                    PaintDataOnToRunwayGraphics(1, 180, 20, 180, 60,
                        RunwayGraphic, Math.Round(headwind3, 0) + "kts", new Font("Arial", 12),
                        Color.Yellow, 130, 65);

                    PaintDataOnToRunwayGraphics(1, 15, 20, 65, 20,
                        RunwayGraphic, Math.Round(crosswind3, 0) + "kts", new Font("Arial", 12),
                        Color.Yellow, 78, 10);

                    PaintDataOnToRunwayGraphics(1, 15, 20, 15, 60,
                        RunwayGraphic, Math.Round(headwind3, 0) + "kts", new Font("Arial", 12),
                        Color.Yellow, 5, 65);
                }
                else if (crosswind3 == 0 && headwind3 > 0) // headwind only no cross wind
                {
                    // Paint Runway marking
                    RunwayGraphic.DrawString(RunwayToUse, new Font("Arial", 50), new SolidBrush(Color.White), new Point(50, 120));

                    // Draw both wind arrows. only write crosswind number once
                    //crosswind multiplier = 1 headwind multiplier = 2
                    PaintDataOnToRunwayGraphics(1, 180, 20, 130, 20,
                        RunwayGraphic, "", new Font("Arial", 12),
                        Color.Yellow, 80, 10);

                    PaintDataOnToRunwayGraphics(2, 180, 20, 180, 60,
                        RunwayGraphic, Math.Round(headwind3, 0) + "kts", new Font("Arial", 12),
                        Color.Yellow, 130, 65);

                    PaintDataOnToRunwayGraphics(1, 15, 20, 65, 20,
                        RunwayGraphic, Math.Round(crosswind3, 0) + "kts", new Font("Arial", 12),
                        Color.Yellow, 78, 10);

                    PaintDataOnToRunwayGraphics(2, 15, 20, 15, 60,
                        RunwayGraphic, Math.Round(headwind3, 0) + "kts", new Font("Arial", 12),
                        Color.Yellow, 5, 65);
                }
                else // headwind and cross wind we need to work out which is greater etc
                {
                    // Paint Runway marking
                    RunwayGraphic.DrawString(RunwayToUse, new Font("Arial", 50), new SolidBrush(Color.White), new Point(50, 120));

                    //Draw the crosswind and headwind arrows
                    if (StarboardFlag) //starboard side
                    {
                        PaintDataOnToRunwayGraphics(CrosswindMultiplier, 180, 20, 130, 20,
                            RunwayGraphic, Math.Round(crosswind3, 0) + "kts", new Font("Arial", 12),
                            Color.Yellow, 80, 10);

                        PaintDataOnToRunwayGraphics(HeadwindMultiplier, 180, 20, 180, 60,
                            RunwayGraphic, Math.Round(headwind3, 0) + "kts", new Font("Arial", 12),
                            Color.Yellow, 130, 65);

                    }
                    else //port side
                    {
                        PaintDataOnToRunwayGraphics(CrosswindMultiplier, 15, 20, 65, 20,
                                RunwayGraphic, Math.Round(crosswind3, 0) + "kts", new Font("Arial", 12),
                                Color.Yellow, 68, 10);

                        PaintDataOnToRunwayGraphics(HeadwindMultiplier, 15, 20, 15, 60,
                                RunwayGraphic, Math.Round(headwind3, 0) + "kts", new Font("Arial", 12),
                                Color.Yellow, 5, 65);
                    }

                }
            }
        }


        private void PaintDataOnToRunwayGraphics(double myLineWidthMultiplier, int myCrossWindLineStartX, int myCrossWindLineStartY, int myCrossWindLineEndX, int myCrossWindLineEndY,
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
            }
            catch
            {
                //It did not work instead of crashing just put up hint and return gracefully
                MsgBox.Show("Something has gone wrong.\rPlease check data and try again", "Something is Wrong",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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