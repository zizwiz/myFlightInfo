using System.Windows.Forms;

namespace xmlFactory
{
    public partial class AreYouSure : Form
    {

        public AreYouSure(string myAircraftName)
        {
            InitializeComponent();
            lbl_areyousure_delete_aircraft.Text = myAircraftName;
        }

        public bool areYouSureToDelete
        {
            get
            {
                //We set the yes button tabstop true or false and send that back
                //to say if this is Ok or to abort
                return btn_areyousure_yes.TabStop;

            }
        }
        
        private void btn_areyousure_no_Click(object sender, System.EventArgs e)
        {
            btn_areyousure_yes.TabStop = false;
            Close();
        }

        private void btn_areyousure_yes_Click(object sender, System.EventArgs e)
        {
            btn_areyousure_yes.TabStop = true;
            Close();
        }

    }
}