using System;
using System.Drawing;
using System.Windows.Forms;
using CenteredMessagebox;
using CoordinateSharp;
using CoordinateSharp.Magnetic;
using myFlightInfo.common_data;
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

        public static bool AirfieldCoOrdinates(bool flag, string airfield, ListBox myListBox, Label lblPressure, Label lblAirportName,
            TextBox txtbxAltitude, TextBox txtbxPressure)
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

                    lblPressure.Text = "";

                    //Clear listbox
                    myListBox.Items.Clear();

                    lblAirportName.Text = data[2];
                    txtbxAltitude.Text = data[8];
                    if (flag) txtbxPressure.Text = "0"; //only do if from airfield

                    myListBox.Items.Add("ICAO Code = \t" + data[1]);

                    myListBox.Items.Add("");
                    myListBox.Items.Add("Latitude degrees = \t" + data[3]);
                    myListBox.Items.Add("Latitude decimal = \t" + data[4]);

                    myListBox.Items.Add("");
                    myListBox.Items.Add("Longitude degrees = \t" + data[5]);
                    myListBox.Items.Add("Longitude decimal = \t" + data[6]);

                    myListBox.Items.Add("");
                    myListBox.Items.Add("Elevation = \t" + data[7] + "m");

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
                double from_lat = double.Parse(from_data[4]);
                double from_lng = double.Parse(from_data[6]);



                Coordinate fc = new Coordinate(from_lat, from_lng, new DateTime(year, month, day, hour, minute, second),
                    new EagerLoad(false));


                fc.FormatOptions.Format = CoordinateFormatType.Degree_Minutes_Seconds;
                fc.FormatOptions.Display_Leading_Zeros = true;
                fc.FormatOptions.Round = 3;

                Magnetic m = new Magnetic(fc, DataModel.WMM2020);

                myListBox.Items.Add("");
                myListBox.Items.Add("Decimal Degrees for " + fromAirfieldName);
                myListBox.Items.Add("Declination: \t" + Math.Round(m.MagneticFieldElements.Declination, 2));
                myListBox.Items.Add("Variation: \t" + Math.Round(m.SecularVariations.Declination, 2));
                myListBox.Items.Add("Uncertainty: \t" + Math.Round(m.Uncertainty.Declination, 2));

                myListBox.Items.Add("");
                myListBox.Items.Add("Degrees, minutes and seconds for " + fromAirfieldName);
                myListBox.Items.Add("Declination: \t" +
                                    Converts.DecimalToDegrees(m.MagneticFieldElements.Declination));
                myListBox.Items.Add("Variation: \t" + Converts.DecimalToDegrees(m.SecularVariations.Declination));
                myListBox.Items.Add("Uncertainty: \t" + Converts.DecimalToDegrees(m.Uncertainty.Declination));

                string[] to_data = airport_data.GetAirportInfo(toAirfieldName);
                double to_lat = double.Parse(to_data[4]);
                double to_lng = double.Parse(to_data[6]);

                myListBox.Items.Add("");
                Coordinate tc = new Coordinate(to_lat, to_lng, new DateTime(year, month, day, hour, minute, second));
                Distance d = new Distance(fc, tc, Shape.Ellipsoid);

                myListBox.ClearSelected();
                myListBox.Font = new Font("Ariel", 18, FontStyle.Underline);

                myListBox.Items.Add("Flying from " + fromAirfieldName + " to " +
                                    toAirfieldName);

                myListBox.Font = new Font("Ariel", 8, FontStyle.Regular);
                myListBox.Items.Add("Distance = \t" + Math.Round(d.NauticalMiles, 2) + "nm");
                myListBox.Items.Add("Bearing = \t" + Math.Round(d.Bearing, 2) + "°");

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
