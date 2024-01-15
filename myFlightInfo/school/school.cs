using System;
using System.Windows.Forms;
using myFlightInfo.Properties;

namespace myFlightInfo.school
{
    public partial class school : Form
    {
        private Settings settings = Settings.Default;
        private bool flag = true;

        public school()
        {
            InitializeComponent();
        }

        private void btn_choose_school_Click(object sender, EventArgs e)
        {
            settings.school = rdobtn_lt_gransden.Checked ? "Lt Gransden" : "Rochester";

            settings.Save();

            flag = false;

            Close();
        }

        private void school_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag)
            {
                Environment.Exit(0); //Do not carry on starting the main app
            }
        }
    }
}
