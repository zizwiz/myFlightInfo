using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CenteredMessagebox;
using Timer = System.Timers.Timer;

namespace myFlightInfo.timelapse
{
    class TimeLapse
    {

        CancellationTokenSource tokenSource; // Declare the cancellation token


        public void StartSaving(Label myLabel, PictureBox myPictureBoxWest, PictureBox myPictureBoxSouth,
        Label mySequenceStartedLabel, Label myLastSaveLabel)
        {
            //   string myWestDirectory = SetDirectory();
            //  Directory.CreateDirectory(Path.Combine(myWestDirectory + "/west"));

            //   Directory.CreateDirectory(Path.Combine(SetDirectory() + "/south"));

            WriteUIData("Sequence Started: " + DateTime.Now, mySequenceStartedLabel);

            tokenSource = new CancellationTokenSource();    //Make a new instance
            Task.Run(() => RunSequence(tokenSource.Token, myLabel, myPictureBoxWest, myPictureBoxSouth, myLastSaveLabel)); //Run the task that we need to stop
        }

        public void StopSaving()
        {
            tokenSource.Cancel(); // make the token a cancel token
        }

        private async void RunSequence(CancellationToken _ct, Label myLabel, PictureBox myPictureBoxWest, 
            PictureBox myPictureBoxSouth, Label myLastSaveLabel)
        {
            int counter = 1;

            while (!_ct.IsCancellationRequested)
            {
                GC.Collect(); //clean orphaned memory

                string mySourceFilePathWest = @"https://members.camgliding.uk/volatile/camwest.jpg";
                string mySourceFilePathSouth = @"https://members.camgliding.uk/volatile/camsouth.jpg";

                string folderPathWest = @"C:\temp\temp\west";
                string folderPathSouth = @"C:\temp\temp\south";

                string fileName = counter + ".jpg";

                string myFullPathWest = Path.Combine(folderPathWest, fileName);
                string myFullPathSouth = Path.Combine(folderPathSouth, fileName);

                // show incrementing number but as we have a task watch for cross threading
                WriteUIData((counter++).ToString(), myLabel);

                try
                {
                    try
                    {
                        //Show picture according to the users checkbox choices
                        if (myPictureBoxWest.Name != "picbx_time_lapse_null") DrawImage(myPictureBoxWest, mySourceFilePathWest);
                        if (myPictureBoxSouth.Name != "picbx_time_lapse_null") DrawImage(myPictureBoxSouth, mySourceFilePathSouth);

                    }
                    catch (Exception ex)
                    {
                        MsgBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    await Task.Delay(30000, _ct); //waits 30 seconds to draw images

                    // Save the image according to the users checkbox choices
                    if (myPictureBoxWest.Name != "picbx_time_lapse_null") myPictureBoxWest.Image.Save(myFullPathWest, System.Drawing.Imaging.ImageFormat.Jpeg);
                    if (myPictureBoxSouth.Name != "picbx_time_lapse_null") myPictureBoxSouth.Image.Save(myFullPathSouth, System.Drawing.Imaging.ImageFormat.Jpeg);

                    //write time of save to UI
                    WriteUIData("Last save: " + DateTime.Now, myLastSaveLabel);

                    await Task.Delay(30000, _ct); //waits 30 seconds to save images
                }
                catch
                {
                    // Do nothing just needed so we can exit without exceptions
                }

            }

            if (_ct.IsCancellationRequested)
            {
                //report we have cancelled
                WriteUIData("Cancelled", myLabel);
            }

            tokenSource.Dispose(); //dispose of the token so we can reuse

        }

        private void WriteUIData(String myData, Label myLabel)
        {
            // Write data to UI but as we have a task watch for cross threading

            if (myLabel.InvokeRequired)
            {
                myLabel.BeginInvoke((MethodInvoker)delegate () { myLabel.Text = myData; });
            }
            else
            {
                myLabel.Text = myData;
            }
        }

        private void DrawImage(PictureBox myPictureBox, string myLocation)
        {
            // Draw picture to UI but as we have a task watch for cross threading

            if (myPictureBox.InvokeRequired)
            {
                myPictureBox.BeginInvoke((MethodInvoker)delegate ()
               {
                   myPictureBox.ImageLocation = myLocation;
               });
            }
            else
            {
                myPictureBox.ImageLocation = myLocation;
            }
        }

        private static string SetDirectory()
        {
            string myDirectory = "Error";

            using (FolderBrowserDialog myFolderBrowserDialog = new FolderBrowserDialog())
            {

                if (myFolderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    myDirectory = myFolderBrowserDialog.SelectedPath;
                }
            }

            return myDirectory;
        }
    }
}
