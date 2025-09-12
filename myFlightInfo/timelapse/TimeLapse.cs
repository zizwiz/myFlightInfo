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


        public void StartSaving(Label myLabel)
        {
            string myWestDirectory = SetDirectory();
            Directory.CreateDirectory(Path.Combine(myWestDirectory + "/west"));
            
            Directory.CreateDirectory(Path.Combine(SetDirectory() + "/south"));
            
            tokenSource = new CancellationTokenSource();    //Make a new instance
            Task.Run(() => RunSequence(tokenSource.Token, myLabel)); //Run the task that we need to stop
        }

        public void StopSaving()
        {
            tokenSource.Cancel(); // make the token a cancel token
        }

        private async void RunSequence(CancellationToken _ct, Label myLabel)
        {
            int counter = 0;
            
            while (!_ct.IsCancellationRequested)
            {
                // show incrementing number but as we have a task watch for cross threading
                WriteUIData((counter++).ToString(), myLabel);

                try
                {
                    await Task.Delay(1000, _ct); //waits 1 second
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
