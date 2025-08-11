using System;
using System.Windows.Forms;

namespace myFlightInfo.hobbs
{
    class Calculate
    {
        public static string Endurance (TextBox myHobbsStartHours, TextBox myHobbsStartMinutes, TextBox myHobbsEndHours, TextBox myHobbsEndMinutes)
        {
            string result;

            // Try to parse all inputs safely
            if (!IsValidTimeInput(myHobbsEndHours.Text, 0, 99999, out int endHour) ||
                !IsValidTimeInput(myHobbsEndMinutes.Text, 0, 59, out int endMinute) ||
                !IsValidTimeInput(myHobbsStartHours.Text, 0, 99999, out int startHour) ||
                !IsValidTimeInput(myHobbsStartMinutes.Text, 0, 59, out int startMinute))
            {
                result = "Please enter valid numbers:\nHours: 0–99999\nMinutes: 0–59";
            }
            else
            {
                // Convert total minutes for each time
                int startTotalMinutes = (startHour * 60) + startMinute;
                int endTotalMinutes = (endHour * 60) + endMinute;

                // Calculate the difference
                int durationMinutes = endTotalMinutes - startTotalMinutes;

                // Handle negative duration (e.g., end time is earlier than start)
                if (durationMinutes < 0)
                {
                    result = "End time must be later than start time.";
                }
                else 
                {
                     // Convert back to hours and minutes
                    result = durationMinutes / 60 + ":" + durationMinutes % 60;
                }

               


                //// Calculate the difference
                //TimeSpan duration = new TimeSpan(int.Parse(myHobbsEndHours.Text), int.Parse(myHobbsEndMinutes.Text), 0)
                //                    - new TimeSpan(int.Parse(myHobbsStartHours.Text),
                //                        int.Parse(myHobbsStartMinutes.Text), 0);

                //// Handle negative duration (e.g., end time is on the next day)
                //if (duration.TotalMinutes < 0)
                //{
                //    duration += TimeSpan.FromDays(1);
                //}

                //result = (int)duration.TotalHours + ":" + duration.Minutes;

            }

            return result;
        }

        // Helper method to validate and parse input
        private static bool IsValidTimeInput(string input, int min, int max, out int value)
        {
            if (int.TryParse(input, out value))
            {
                if (value >= min && value <= max)
                    return true;
            }

            value = 0;
            return false;
        }

    }
}
