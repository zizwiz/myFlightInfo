using System;
using System.Windows.Forms;

namespace myFlightInfo.compliance_data
{
    public partial class aircraftName : Form
    {
        public aircraftName()
        {
            InitializeComponent();
        }

        //public string myAircraftName { get { return txtbx_aircraftName.Text; } }
        public string myAircraftName
        {
            get
            {
                if (txtbx_aircraftName.Text == "")
                {
                    return "error";
                }
                else
                {
                     return txtbx_aircraftName.Text;
                }
               
            }
        }

        private void btn_aircraftName_exit_Click(object sender, EventArgs e)
        {
            txtbx_aircraftName.Text = "error";
            Close();
        }

        private void btn_aircraftName_go_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
