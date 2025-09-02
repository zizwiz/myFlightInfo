using System.Windows.Forms;
using CenteredMessagebox;
using Timer = System.Timers.Timer;

namespace myFlightInfo.timelapse
{
    class TimeLapse
    {
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
    }
}
