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
        public static bool Calculate_altimeter(string myAltitude, ListBox myListbox)
        {
            if (CheckDataCorrect(myAltitude))
            {
                string myText = "QFE to QNH = \t"; //Airfield is above sea level

                if (float.Parse(myAltitude.Substring(0, myAltitude.Length - 2)) < 0)
                {
                    myText = "QFE to QNH = \t-"; //Airfield is below sea level
                }

                string QNH = myText + Math.Round(
                    (float.Parse(myAltitude.Substring(0, myAltitude.Length - 2)) / 30), 0) + " hPa";

                if (myListbox.Items.Count >= 13)
                {
                    //if it exists then remove it and then replace it with new value.
                    //From Airfield
                    myListbox.Items.RemoveAt(13);
                    myListbox.Items.Insert(13, QNH);
                }
                else
                {
                    //It does not yet exist so write for first time
                    //From Airfield
                    myListbox.Items.Add("");
                    myListbox.Items.Add(QNH);
                }

                
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
        public static bool CheckDataCorrect(string myAltitude)
        {
            int parsedValue;
            bool result = false;

            if (myAltitude != "")
            {
                result = true;

                if (!int.TryParse(myAltitude.Substring(0, myAltitude.Length - 2), out parsedValue))
                {
                    MsgBox.Show("Altitude must contain only numbers", "Check Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }
            }
            return result;
        }
    }
}
