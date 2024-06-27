using System;
using System.Drawing;
using System.Windows.Forms;
using CenteredMessagebox;
using CoordinateSharp;
using CoordinateSharp.Magnetic;
//using CoordinateSharp;
//using CoordinateSharp.Magnetic;
using myFlightInfo.common_data;
using myFlightInfo.libraries;
using myFlightInfo.utils;

/*
< Used to work out magnetic declination, 
intensity, directional component, even uncertainly and much more>
Copyright (C) < 2024 >  < ZizWiz>

This program is free software: you can redistribute it and/or modify 
it under the terms of the GNU Affero General Public License as
published by the Free Software Foundation, either version 3 of the
License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Affero General Public License for more details.

You should have received a copy of the GNU Affero General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.

https://coordinatesharp.com/DeveloperGuide#magnetic-fields

*/
namespace myFlightInfo.Navigation
{
    class Navigate
    {
        public static void SolarInfo(string airfield, ListBox myListBox, int year, int month, int day)
        {
            try
            {

                //Clear the area if it is already written
                int NumItems = myListBox.Items.Count;

                string[] data = airport_data.GetAirportInfo(airfield);

                double lat = double.Parse(data[4]);
                double lng = double.Parse(data[6]);

                Sunriset.SunriseSunset(year, month, day, lat, lng, out double tsunrise, out double tsunset);

                //Find last Sunday in March and October of year in datepicker
                DateTime marchDate = CheckDate.LastSundayOfMonth("3", year.ToString());
                DateTime octoberDate = CheckDate.LastSundayOfMonth("10", year.ToString());

                // Construct the chosen date we are looking at 
                DateTime DateToCheck = DateTime.Parse(day + "/" + month + "/" + year + " 00:00:00");

                //Are we in BritishSummerTime for chosen date? 
                //We only fly in daylight so no need to worry about the hour.
                bool BritishSummerTime = marchDate <= DateToCheck && DateToCheck <= octoberDate;

                if (BritishSummerTime)
                {
                    tsunrise += 1;
                    tsunset += 1;
                }


                if (NumItems >= 12)
                {
                    //If we are updating then delete and add again
                    try
                    {
                        myListBox.Items.RemoveAt(10);
                        myListBox.Items.Insert(10, "Sunrise = \t" + TimeSpan.FromHours(tsunrise).ToString(@"hh\:mm\:ss"));

                        myListBox.Items.RemoveAt(11);
                        myListBox.Items.Insert(11, "Sunset = \t" + TimeSpan.FromHours(tsunset).ToString(@"hh\:mm\:ss"));

                    }
                    catch (Exception e)
                    {
                        //ignore and carry on
                    }

                }
                else
                {
                    //First time we need to add
                    myListBox.Items.Add("");
                    myListBox.Items.Add("Sunrise = \t" + TimeSpan.FromHours(tsunrise).ToString(@"hh\:mm\:ss"));
                    myListBox.Items.Add("Sunset = \t" + TimeSpan.FromHours(tsunset).ToString(@"hh\:mm\:ss"));
                }

                myListBox.TopIndex = myListBox.Items.Count - 1;

            }
            catch (Exception e)
            {
                MsgBox.Show("Check all information is correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static bool AirfieldCoOrdinates(bool flag, string airfield, ListBox myListBox, Label lblAirportName, Label lblAltitude)
        {
            bool infoFlag = false;
            
            try
            {
                // Make the ListBox use tabs.
                myListBox.UseTabStops = true;
                myListBox.UseCustomTabOffsets = true;
                

                // Define the tabs.
                ListBox.IntegerCollection offsets = myListBox.CustomTabOffsets;
                offsets.Add(100);

                string[] data = airport_data.GetAirportInfo(airfield);

                if (data[8] != "")
                {
                    //Clear listbox
                    myListBox.Items.Clear();

                    lblAirportName.Text = data[2];
                    lblAltitude.Text = data[8] + "ft";
                    //if (flag) txtbxPressure.Text = "0"; //only do if from airfield

                    myListBox.Items.Add("ICAO Code = \t" + data[1]);

                    myListBox.Items.Add("");
                    myListBox.Items.Add("Latitude degrees = \t" + data[3]);
                    myListBox.Items.Add("Latitude decimal = \t" + data[4]);

                    myListBox.Items.Add("");
                    myListBox.Items.Add("Longitude degrees = \t" + data[5]);
                    myListBox.Items.Add("Longitude decimal = \t" + data[6]);

                    myListBox.Items.Add("");
                    myListBox.Items.Add("Elevation = \t" + data[7] + "m");
                    //myListBox.Items.Add("Elevation = \t" + data[8] + "ft");

                    myListBox.TopIndex = myListBox.Items.Count - 1;
                    infoFlag = true;
                }
                else
                {
                    MsgBox.Show("No information about that airfield\rPlease try another airfield",
                        "No Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch (Exception e)
            {
                MsgBox.Show("Check all information is correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return infoFlag;
        }

        public static void BearingAndDistance(string fromAirfieldName, string toAirfieldName, int year, int month, int day, int hour,
            int minute, int second, ListBox myListBox)
        {
            try
            {
                //Clear the area if it is already written
                int NumItems = myListBox.Items.Count;

                if (NumItems > 14)
                {
                    for (int i = 15; i < NumItems + 3; i++)
                    {
                        try
                        {
                            myListBox.Items.RemoveAt(14);
                        }
                        catch (Exception e)
                        {
                            //ignore and carry on
                        }
                    }
                }

                string[] from_data = airport_data.GetAirportInfo(fromAirfieldName);
                string originLongitude = from_data[4];
                string originLatitude = from_data[6];

                string[] to_data = airport_data.GetAirportInfo(toAirfieldName);
                string destinationLatitude = to_data[4];
                string destinationLongitude = to_data[6];

                myListBox.Items.Add("");
                
                var results = GreatCircle.InitialBearing(originLongitude, originLatitude,
                    destinationLongitude, destinationLatitude);

                myListBox.Items.Add("Flying from " + fromAirfieldName + " to " + toAirfieldName);
               
                if (myListBox.Name == "lstbx_navigation_from")
                {
                    //  myListBox.Items.Add("Forward bearing decimal = " + Math.Round(results.Item1, 4) + "° " + results.Item2);
                    myListBox.Items.Add("\rBearing = " +
                                        Converts.toDegreesMinutesSecondsFromDecimalDegrees(results.Item1.ToString()) +
                                        " " + results.Item2 + "\r");
                }
                else
                {
                    //  myListBox.Items.Add("\rReverse bearing decimal = " + HelpfulFunctions.UnWrap360(Math.Round(results.Item3, 4)) + "° " + results.Item4);
                    myListBox.Items.Add("\rBearing = " +
                                        Converts.toDegreesMinutesSecondsFromDecimalDegrees(HelpfulFunctions
                                            .UnWrap360(Math.Round(results.Item3, 4)).ToString()) + " " + results.Item4 +
                                        "\r");
                }

                Double result = GreatCircle.Distance(originLongitude, originLatitude,
                    destinationLongitude, destinationLatitude);
                myListBox.Items.Add("\r");
                myListBox.Items.Add("\rDistance\r");

               // myListBox.Items.Add("Distance = \r");
                myListBox.Items.Add(Math.Round(result, 4) + "m\r");
                myListBox.Items.Add(Math.Round(result / 1000, 4) + "km\r");
                myListBox.Items.Add(Math.Round(Converts.toMilesFromMetres(result), 4) + " miles\r");
                myListBox.Items.Add(Math.Round(Converts.toNauticalMilesFromMetres(result), 4) + " nautical miles\r");


                myListBox.TopIndex = myListBox.Items.Count - 1;
                myListBox.SelectedIndex = -1; //removes the blue line

            }
            catch (Exception e)
            {
                MsgBox.Show("Check all information is correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
