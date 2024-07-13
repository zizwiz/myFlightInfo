using System.Windows.Forms;
using myFlightInfo.browsing;

namespace myFlightInfo
{
    public partial class Form1
    {
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && ((tabcnt_toplevel.SelectedTab == tab_utils) && (tabcnt_utils.SelectedTab == tab_navigation)))
            {
                btn_navigation_calculations.PerformClick();
            }
            else if ((e.KeyCode == Keys.Enter) && ((tabcnt_toplevel.SelectedTab == tab_utils) && (tabcnt_utils.SelectedTab == tab_crosswind)))
            {
                btn_calc_wind.PerformClick();
            }
        }

        private void Crosswind_Keydown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && ((tabcnt_toplevel.SelectedTab == tab_utils) && (tabcnt_utils.SelectedTab == tab_crosswind)))
            {
                btn_calc_wind.PerformClick();
            }
        }

        private void Navigation_Keydown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && ((tabcnt_toplevel.SelectedTab == tab_utils) && (tabcnt_utils.SelectedTab == tab_navigation)))
            {
                btn_navigation_calculations.PerformClick();
            }
        }

        private void SpeedTimeFuel_Keydown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && ((tabcnt_toplevel.SelectedTab == tab_utils) && (tabcnt_utils.SelectedTab == tab_crosswind)))
            {
                btn_calc_speed_time_fuel.PerformClick();
            }
        }

        private void txtbx_navigate_to_url_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Browse.NavigateTo(txtbx_navigate_to_url.Text, webView_browser);
            }
        }
    }
}