using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CenteredMessagebox;

namespace myFlightInfo.timelapse
{
    class TimeLapse
    {

        CancellationTokenSource tokenSource; // Declare the cancellation token


        public void StartSaving(Label myLabel, PictureBox myPictureBoxWest, PictureBox myPictureBoxSouth,
        Label mySequenceStartedLabel, Label myLastSaveLabel, RichTextBox myRichTextBoxWest,
        RichTextBox myRichTextBoxSouth)
        {
            //   string myWestDirectory = SetDirectory();
            //  Directory.CreateDirectory(Path.Combine(myWestDirectory + "/west"));

            //   Directory.CreateDirectory(Path.Combine(SetDirectory() + "/south"));

            WriteUIData("Sequence Started @ " + DateTime.Now, mySequenceStartedLabel);

            tokenSource = new CancellationTokenSource();    //Make a new instance
            Task.Run(() => RunSequence(tokenSource.Token, myLabel, myPictureBoxWest, myPictureBoxSouth, myLastSaveLabel,
                myRichTextBoxWest, myRichTextBoxSouth, mySequenceStartedLabel)); //Run the task that we need to stop
        }

        public void StopSaving()
        {
            tokenSource.Cancel(); // make the token a cancel token
        }

        private async void RunSequence(CancellationToken _ct, Label myLabel, PictureBox myPictureBoxWest,
            PictureBox myPictureBoxSouth, Label myLastSaveLabel, RichTextBox myRichTextBoxWest,
            RichTextBox myRichTextBoxSouth, Label mySequenceStartedLabel)
        {
            int counter = 1;

            while (!_ct.IsCancellationRequested)
            {
                GC.Collect(); //clean orphaned memory

                string mySourceFilePathWest = @"https://members.camgliding.uk/volatile/camwest.jpg";
                string mySourceFilePathSouth = @"https://members.camgliding.uk/volatile/camsouth.jpg";

                string folderPathWest = @"C:\temp\temp\west";
                string folderPathSouth = @"C:\temp\temp\south";

               // string fileName = counter + ".jpg";

                string fileName = DateTime.Now.ToString("ddMMyyyy_HHmmss") + "_" + counter + ".jpg";

                string myFullPathWest = Path.Combine(folderPathWest, fileName);
                string myFullPathSouth = Path.Combine(folderPathSouth, fileName);

                // show incrementing number but as we have a task watch for cross threading
                WriteUIData("Showing Image: " + counter, myLabel);

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
                    if ((myPictureBoxWest.Name != "picbx_time_lapse_null")&&(myPictureBoxWest.Image != null)) 
                        myPictureBoxWest.Image.Save(myFullPathWest, System.Drawing.Imaging.ImageFormat.Jpeg);
                   
                    
                    if ((myPictureBoxSouth.Name != "picbx_time_lapse_null")&&(myPictureBoxSouth.Image != null)) 
                        myPictureBoxSouth.Image.Save(myFullPathSouth, System.Drawing.Imaging.ImageFormat.Jpeg);

                    //write time of save to UI
                    WriteUIData("Last saved: " + fileName + " @ " + DateTime.Now, myLastSaveLabel);

                    await Task.Delay(15000, _ct); //waits 15 seconds to save images

                    //Write list of saved files in folder to richtextbox
                    string[] myWestFiles = Directory.GetFiles(folderPathWest);
                    string[] mySouthFiles = Directory.GetFiles(folderPathSouth);


                    Array.Sort(myWestFiles);
                    Array.Reverse(myWestFiles);

                    //Needs invoking as it is on a different thread
                    if (myRichTextBoxWest.InvokeRequired)
                    {
                        myRichTextBoxWest.BeginInvoke((MethodInvoker)delegate ()
                       {
                           myRichTextBoxWest.Clear();

                           foreach (string WestFile in myWestFiles)
                           {
                               myRichTextBoxWest.AppendText(Path.GetFileName(WestFile) + "\r");
                           }

                       });
                    }
                    else
                    {
                        myRichTextBoxWest.Clear();

                        foreach (string WestFile in myWestFiles)
                        {
                            myRichTextBoxWest.AppendText(Path.GetFileName(WestFile) + "\r");
                        }
                    }

                    Array.Sort(mySouthFiles);
                    Array.Reverse(mySouthFiles);

                    if (myRichTextBoxSouth.InvokeRequired)
                    {
                        myRichTextBoxSouth.BeginInvoke((MethodInvoker)delegate ()
                        {
                            myRichTextBoxSouth.Clear();

                            foreach (string SouthFile in mySouthFiles)
                            {
                                myRichTextBoxSouth.AppendText(Path.GetFileName(SouthFile) + "\r");
                            }

                        });
                    }
                    else
                    {
                        myRichTextBoxSouth.Clear();

                        foreach (string SouthFile in mySouthFiles)
                        {
                            myRichTextBoxSouth.AppendText(Path.GetFileName(SouthFile) + "\r");
                        }
                    }

                    counter++;
                    await Task.Delay(15000, _ct); //waits 15 seconds to get, sort and write the files
                }
                catch
                {
                    // Do nothing just needed so we can exit without exceptions
                }

            }

            if (_ct.IsCancellationRequested)
            {
                //report we have cancelled
                WriteUIData("Not running at the moment.", myLabel);
                WriteUIData("Sequence Stopped @ " + DateTime.Now, mySequenceStartedLabel);
                myPictureBoxSouth.Image = myPictureBoxWest.Image = null;
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
