using System.Windows.Forms;
using CenteredMessagebox;

namespace myFlightInfo.common_data
{
    class verification
    {

        public static bool CheckDouble(TextBox myTextBox)
        {
            return double.TryParse(myTextBox.Text, out var myValue);
        }





        public static void ShowError(string myError)
        {
            MsgBox.Show("Check as value in " + myError + " is not correct", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
