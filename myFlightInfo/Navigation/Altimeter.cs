using System;
using System.Windows.Forms;
using CenteredMessagebox;

namespace myFlightInfo.Navigation
{
    class altimeter
    {

        /// <summary>
        /// Work out the pressure at Sea level (QNH) and Destination (Destination QFE)
        /// </summary>
        /// <param name="present_pressure"></param>
        /// <param name="present_altitude"></param>
        /// /// <param name="to_altitude"></param>
        /// /// <returns>(string, string)</returns>
        public static (string, string)Calculate_altimeter(string present_pressure, string present_altitude, string to_altitude)
        {
            if (CheckDataCorrect(present_pressure, present_altitude, to_altitude))
            {
                return (
                   Math.Round(
                           (float.Parse(present_pressure) + ((float.Parse(present_altitude) -
                                                                         float.Parse(to_altitude)) / 30)), 2)
                       .ToString(),
                   Math.Round(
                       (float.Parse(present_pressure) + ((float.Parse(present_altitude)) / 30)),
                       2).ToString());
            }
            else
            {
                return ("F", "F"); //Data not correct so return F = fail
            }
        }

        /// <summary>
        /// Check That there is data and if there is check that it is the correct type.
        /// </summary>
        /// <param name="present_pressure"></param>
        /// <param name="present_altitude"></param>
        /// <param name="to_altitude"></param>
        /// <returns>Bool</returns>
        public static bool CheckDataCorrect(string present_pressure, string present_altitude, string to_altitude)
        {
            int parsedValue;
            bool result = false;

            if ((present_pressure != "") && (present_altitude != "") && (to_altitude != ""))
            {
                result = true;

                if (!int.TryParse(present_pressure, out parsedValue))
                {
                    MsgBox.Show("Present QFE pressure must contain only numbers", "Check Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }

                if (!int.TryParse(present_altitude, out parsedValue))
                {
                    MsgBox.Show("Present QFE pressure must contain only numbers", "Check Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }

                if (!int.TryParse(to_altitude, out parsedValue))
                {
                    MsgBox.Show("Destination QFE pressure must contain only numbers", "Check Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }
            }
            return result;
        }
    }
}
