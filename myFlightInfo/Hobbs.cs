using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CenteredMessagebox;
using ImageMagick;
using myFlightInfo.hobbs;
using myFlightInfo.Properties;

namespace myFlightInfo
{
    public partial class Form1
    {
        private void btn_hobbs_reset_Click(object sender, EventArgs e)
        {
            hobbs.Reset.Data(txtbx_hobbs_start_hours, txtbx_hobbs_start_minutes,
                txtbx_hobbs_end_hours, txtbx_hobbs_end_minutes, lbl_hobbs_result);
            
            picbx_hobbs_start.Image = picbx_hobbs_end.Image = null;
            picbx_hobbs_start.Invalidate();
            picbx_hobbs_end.Invalidate();
        }

        private void btn_hobbs_calculate_Click(object sender, EventArgs e)
        {
            lbl_hobbs_result.Text = hobbs.Calculate.Endurance(txtbx_hobbs_start_hours, txtbx_hobbs_start_minutes,
                txtbx_hobbs_end_hours, txtbx_hobbs_end_minutes);
        }

        private void btn_hobbs_open_start_image_Click(object sender, EventArgs e)
        {
            picbx_hobbs_start.Image = OpenHobbsImageFile();

        }

        private void btn_hobbs_open_end_image_Click(object sender, EventArgs e)
        {
            picbx_hobbs_end.Image = OpenHobbsImageFile();
        }

        private Bitmap OpenHobbsImageFile()
        {
            // We use  Magick.NET NuGet package to do the convertion of image to a jpg file that we display.
            // This will handle HEIC (High-Efficiency Image Format) image files 
            
            Bitmap myBitmap = new Bitmap(1,1); //just a blank one pixel

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select an Image File",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.heic|All Files|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            };

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var myMagickImage = new MagickImage(openFileDialog.FileName))
                    {
                        // Sets the output format to jpeg
                        myMagickImage.Format = MagickFormat.Jpeg;

                        using (var myMemoryStream = new MemoryStream(myMagickImage.ToByteArray()))
                        {
                            myBitmap = new Bitmap(myMemoryStream);
                        }

                        return myBitmap;
                    }
                }
                return myBitmap;
            }
            catch (Exception e)
            {
                MsgBox.Show("Please use an image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            return myBitmap;
        }

        private void btn_hobbs_email_Click(object sender, EventArgs e)
        {
            MakeHobbsImage.CreateImage(panel_hobbs_email, cmbobx_Hobbs_aircraft, dateTimePicker1);
        }
    }
}