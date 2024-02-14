using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public static void BearingAndDistance(string fromAirfieldName, string toAirfieldName, int year, int month, int day, int hour,
            int minute, int second, ListBox myListBox)
        {
            string[] from_data = airport_data.GetAirportInfo(fromAirfieldName);
            double from_lat = double.Parse(from_data[4]);
            double from_lng = double.Parse(from_data[6]);



            Coordinate fc = new Coordinate(from_lat, from_lng, new DateTime(year, month, day, hour, minute, second),
                new EagerLoad(false));


            fc.FormatOptions.Format = CoordinateFormatType.Degree_Minutes_Seconds;
            fc.FormatOptions.Display_Leading_Zeros = true;
            fc.FormatOptions.Round = 3;

            Magnetic m = new Magnetic(fc, DataModel.WMM2020);

            //  rchtxtbx_charting_output.SelectionFont = new Font("Ariel", 8, FontStyle.Underline);
            myListBox.Items.Add("");
            myListBox.Items.Add("Decimal Degrees for " + fromAirfieldName);
            myListBox.Items.Add("Declination: \t" + Math.Round(m.MagneticFieldElements.Declination, 2));
            myListBox.Items.Add("Variation: \t" + Math.Round(m.SecularVariations.Declination, 2));
            myListBox.Items.Add("Uncertainty: \t" + Math.Round(m.Uncertainty.Declination, 2));

            //rchtxtbx_charting_output.SelectionFont = new Font("Ariel", 8, FontStyle.Underline);
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

            myListBox.SelectedIndex = -1; //removes the blue line
        }

    }
}
