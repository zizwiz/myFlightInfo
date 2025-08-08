using System;

namespace myFlightInfo
{
    public partial class Form1
    {
        private void btn_hobbs_reset_Click(object sender, EventArgs e)
        {
            hobbs.Reset.Data(txtbx_hobbs_start_hours, txtbx_hobbs_start_minutes,
                txtbx_hobbs_end_hours, txtbx_hobbs_end_minutes, lbl_hobbs_result);
        }

        private void btn_hobbs_calculate_Click(object sender, EventArgs e)
        {
            lbl_hobbs_result.Text = hobbs.Calculate.Endurance(txtbx_hobbs_start_hours, txtbx_hobbs_start_minutes,
                txtbx_hobbs_end_hours, txtbx_hobbs_end_minutes);
        }


    }
}