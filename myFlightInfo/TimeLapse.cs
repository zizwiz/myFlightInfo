using System;
using System.Windows.Forms;
using CenteredMessagebox;
using myFlightInfo.timelapse;
using Timer = System.Timers.Timer;

namespace myFlightInfo
{
    public partial class Form1
    {
       // TimeLapse myTimeLapseObject = new TimeLapse();




        private void btn_timelapse_select_image_Click(object sender, EventArgs e)
        {
            //string selectedImage = TimeLapse.SelectImage();

            //if (selectedImage == "Error")
            //{
            //    MsgBox.Show("An Error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    MsgBox.Show("Image " + selectedImage + " selected successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void btn_timelapse_set_save_directory_Click(object sender, EventArgs e)
        {
            //string saveDirectory = TimeLapse.SetSaveDirectory();

            //if (saveDirectory == "Error")
            //{
            //     MsgBox.Show("An Error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    MsgBox.Show("Save directory set to " + saveDirectory, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        
        private void btn_timelapse_start_saving_Click(object sender, EventArgs e)
        {
           // myTimeLapseObject.StartSaving();

           new timelapse.TimeLapse().StartSaving();
        }

        private void btn_timelapse_stop_saving_Click(object sender, EventArgs e)
        {
           // myTimeLapseObject.StopSaving();
        }




    }
}