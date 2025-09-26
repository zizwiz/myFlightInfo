using System;
using System.IO;
using System.Windows.Forms;
using CenteredMessagebox;
using myFlightInfo.timelapse;
using Timer = System.Timers.Timer;

namespace myFlightInfo
{
    public partial class Form1
    {
        TimeLapse myTimeLapseObject = new TimeLapse();



        private void btn_get_list_timelapse_files_Click(object sender, EventArgs e)
        {
            string myFullPathWest = @"C:\temp\temp\west";

            string[] myWestFiles = Directory.GetFiles(myFullPathWest);

            Array.Sort(myWestFiles);
            Array.Reverse(myWestFiles);

            foreach (string WestFile in myWestFiles)
            {
                rchtxtbx_time_lapse_west.AppendText(Path.GetFileName(WestFile) + "\r");
            }
        }






        private void btn_timelapse_start_saving_Click(object sender, EventArgs e)
        {
            if (chkbx_time_lapse_south.Checked && chkbx_time_lapse_west.Checked)
            {
                myTimeLapseObject.StartSaving(lbl_timelapse_counter, picbx_time_lapse_west, picbx_time_lapse_south, 
                    lbl_time_lapse_sequence_started, lbl_time_lapse_last_save, rchtxtbx_time_lapse_west, rchtxtbx_time_lapse_south);
            }
            else if (chkbx_time_lapse_south.Checked && !chkbx_time_lapse_west.Checked)
            {
                myTimeLapseObject.StartSaving(lbl_timelapse_counter, picbx_time_lapse_null, picbx_time_lapse_south,
                    lbl_time_lapse_sequence_started, lbl_time_lapse_last_save, rchtxtbx_time_lapse_west, rchtxtbx_time_lapse_south);
            }
            else if (!chkbx_time_lapse_south.Checked && chkbx_time_lapse_west.Checked)
            {
                myTimeLapseObject.StartSaving(lbl_timelapse_counter, picbx_time_lapse_west, picbx_time_lapse_null,
                    lbl_time_lapse_sequence_started, lbl_time_lapse_last_save, rchtxtbx_time_lapse_west, rchtxtbx_time_lapse_south);
            }
            else
            {
                MsgBox.Show("Please select which images to save", "No image choosen", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btn_timelapse_stop_saving_Click(object sender, EventArgs e)
        {
            myTimeLapseObject.StopSaving();
        }




    }
}