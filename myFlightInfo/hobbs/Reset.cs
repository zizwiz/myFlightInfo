using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myFlightInfo.hobbs
{
    class Reset
    {
        public static void Data(TextBox myHobbsStartHours, TextBox myHobbsStartMinutes, TextBox myHobbsEndHours, TextBox myHobbsEndMinutes, Label myHobbsResult)
        {
            myHobbsStartHours.Text = myHobbsStartMinutes.Text = myHobbsEndHours.Text =
                myHobbsEndMinutes.Text = myHobbsResult.Text = "";
        }
    }
}
