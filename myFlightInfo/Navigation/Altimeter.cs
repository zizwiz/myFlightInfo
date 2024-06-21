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
        public static bool Calculate_altimeter(string present_pressure, string present_altitude, string to_altitude,
        ListBox myListboxFrom, ListBox myListboxto, Label lbl_to_pressure)
        {
            if (CheckDataCorrect(present_pressure, present_altitude, to_altitude))
            {
                string QNH = "QNH = \t" + Math.Round(
                    (float.Parse(present_pressure) + (float.Parse(present_altitude.Substring(0, present_altitude.Length - 2)) / 30)), 2) + " mb";

                if (myListboxFrom.Items.Count >= 13)
                {
                    //if it exists then remove it and then replace it with new value.
                    //From Airfield
                    myListboxFrom.Items.RemoveAt(13);
                    myListboxFrom.Items.Insert(13, QNH);
                }
                else
                {
                    //It does not yet exist so write for first time
                    //From Airfield
                    myListboxFrom.Items.Add("");
                    myListboxFrom.Items.Add(QNH);
                }

                //To Airfield
                //lbl_to_pressure.Text = Math.Round(
                //        (float.Parse(present_pressure) + ((float.Parse(present_altitude.Substring(0,present_altitude.Length-2)) -
                //                                           float.Parse(to_altitude.Substring(0,to_altitude.Length-2))) / 30)), 2) +"hPa";


                //just say how much hPa difference between QFE and QNH.
                lbl_to_pressure.Text = Math.Round(float.Parse(to_altitude.Substring(0, to_altitude.Length - 2)) / 30, 2) + "hPa";




                myListboxto.Items.Add("");
                myListboxto.Items.Add("");
                //We do not put in QNH as the distance between the two airports may be great and
                //mean there is a pressure difference between the two.

                return true;
            }
            else
            {

                return false;
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

                if (!int.TryParse(present_altitude.Substring(0, present_altitude.Length - 2), out parsedValue))
                {
                    MsgBox.Show("Present altitude must contain only numbers", "Check Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }

                if (!int.TryParse(to_altitude.Substring(0,to_altitude.Length-2), out parsedValue))
                {
                    MsgBox.Show("Destination altitude must contain only numbers", "Check Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }
            }
            return result;
        }
    }
}
