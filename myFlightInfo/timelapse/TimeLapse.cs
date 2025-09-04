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

       
        public void StartSaving()
        {
            //if (lbl_output.InvokeRequired)
            //{
            //    lbl_output.BeginInvoke((MethodInvoker)delegate () { lbl_output.Text = data; });
            //}

            string myWestDirectory = SetDirectory();
            Directory.CreateDirectory(Path.Combine(myWestDirectory + "/west"));


            Directory.CreateDirectory(Path.Combine(SetDirectory() + "/south"));

            tokenSource = new CancellationTokenSource();    //Make a new instance
            Task.Run(() => RunSequence(tokenSource.Token)); //Run the task that we need to stop
        }

        public void StopSaving()
        {
            tokenSource.Cancel(); // make the token a cancel token
        }

      //  private async void RunSequence(CancellationToken _ct)
        private void RunSequence(CancellationToken _ct)
        {
            int counter = 0;

            for (int i = 0; i < 100; i++)
            {

                int q = i;
                //string myDirectory = SetDirectory();

                //Directory.CreateDirectory(Path.Combine(myDirectory + "/west"));
                //Directory.CreateDirectory(Path.Combine(myDirectory + "/south"));
            }


            //while (!_ct.IsCancellationRequested)
            //{
            //    try
            //    {
            //        await Task.Delay(60000, _ct); //waits 1 second
            //    }
            //    catch
            //    {
            //        // Do nothing just needed so we can exit without exceptions
            //    }

            //}

            //tokenSource.Dispose(); //dispose of the token so we can reuse
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


        /*
        private static Timer mySaveTimer;

        public static string SelectImage()
        {
            string selectedImagePath = "Error";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                }

                return selectedImagePath;
            }
        }


        public static string SetSaveDirectory()
        {
            string saveDirectory = "Error";

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    saveDirectory = folderBrowserDialog.SelectedPath;
                }
            }

            return saveDirectory;
        }


        public static void StartSaving(string mySelectedImagePath, string mySaveDirectory, TextBox myTextBox)
        {
            if (string.IsNullOrEmpty(mySelectedImagePath) || string.IsNullOrEmpty(mySaveDirectory))
            {
                MsgBox.Show("Please select an image and set a save directory first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(myTextBox.Text, out int interval) || interval <= 0)
            {
                MsgBox.Show("Please enter a valid positive number for the interval (in seconds).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            mySaveTimer.Interval = interval * 1000; // Convert seconds to milliseconds
            mySaveTimer.Start();
            MsgBox.Show("Image saving started", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public static void StopSaving()
        {
            mySaveTimer.Stop();
            MsgBox.Show("Image saving stopped.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        */
    }
}
