using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using CenteredMessagebox;
using myFlightInfo.Altimeter;
using myFlightInfo.common_data;
using myFlightInfo.crosswind;
using myFlightInfo.navigation;

namespace myFlightInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //write the dlls before initialising.
            File.WriteAllBytes("Microsoft.Web.WebView2.Core.dll", Properties.Resources.Microsoft_Web_WebView2_Core);
            File.WriteAllBytes("Microsoft.Web.WebView2.WinForms.dll", Properties.Resources.Microsoft_Web_WebView2_WinForms);

            string arcitectureProcessArchitecture = System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture.ToString();

            if (arcitectureProcessArchitecture == "X64")
            {
                //64bit 
                File.WriteAllBytes("WebView2Loader.dll", Properties.Resources._64_WebView2Loader);
            }
            else if (arcitectureProcessArchitecture == "X86")
            {
                // 32bit
                File.WriteAllBytes("WebView2Loader.dll", Properties.Resources._32_WebView2Loader);
            }
            else if (arcitectureProcessArchitecture == "Arm64")
            {
                //ARM64bit 
                File.WriteAllBytes("WebView2Loader.dll", Properties.Resources.arm64_WebView2Loader);
            }

            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //Get the data file from resources and write to file in same dir as the app.
            File.WriteAllText("airport_data.xml", Properties.Resources.airport_data);

            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number

            grpbx_towns.Visible = false;
            grpbx_browser_navigation.Visible = false;
            cmbobx_airport_info.Visible = false;
            cmbobx_gransden_lodge.Visible = false;
            grpbx_altimeter.Visible = false;

            await webView_notams.EnsureCoreWebView2Async();
            await webView_browser.EnsureCoreWebView2Async();
           


            webView_notams.CoreWebView2.Navigate("https://www.notaminfo.com/ukmap?destination=node%2F39");
            //  webView_egmj.CoreWebView2.Navigate("https://metar-taf.com/EGMJ");
            //  webView_egss.CoreWebView2.Navigate("https://metar-taf.com/EGSS");
            // webView_eggw.CoreWebView2.Navigate("https://metar-taf.com/EGGW");


            cmbobx_airport_info.SelectedIndex = 0;
            cmbobx_gransden_lodge.SelectedIndex = 0;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (tabcnt_toplevel.SelectedTab == tab_notams)
            {
                webView_notams.CoreWebView2.Navigate("https://www.notaminfo.com/ukmap?destination=node%2F39");
            }
            else if ((tabcnt_toplevel.SelectedTab == tab_utils) && (tabcnt_utils.SelectedTab == tab_altimeter))
            {
                txtbx_present_pressure.Text = txtbx_present_altitude.Text = txtbx_to_altitude.Text =
                    lbl_p_airport_name.Text = lbl_p_icao_code.Text = lbl_p_latitude_deg.Text =
                        lbl_p_latitude_dec.Text = lbl_p_longitude_deg.Text = lbl_p_longitude_dec.Text =
                            lbl_p_elevation_m.Text = lbl_d_airport_name.Text = lbl_d_icao_code.Text =
                                lbl_d_latitude_deg.Text = lbl_d_latitude_dec.Text = lbl_d_longitude_deg.Text =
                                    lbl_d_longitude_dec.Text = lbl_d_elevation_m.Text =
                                        lbl_to_pressure.Text = lbl_qnh_pressure.Text = "";
            }
            else if ((tabcnt_toplevel.SelectedTab == tab_utils) && (tabcnt_utils.SelectedTab == tab_browser))
            {
                txtbx_navigate_to_url.Text = "";
                cmbobx_airport_info.SelectedIndex = 0;
                webView_browser.CoreWebView2.Navigate("about:blank");
            }
        }

        private void btn_calculate_altimiter_Click(object sender, EventArgs e)
        {
            //Calculate settings for altitude at destination
            /*
             * var values = MyFunction();
               var firstValue = values.Item1;
               var secondValue = values.Item2;
               var thirdValue = values.Item3;

                (string, string, string)MyFunction()

             */

            var values = altimeter.Calculate_altimeter(txtbx_present_pressure.Text, txtbx_present_altitude.Text, txtbx_to_altitude.Text);

            var firstValue = values.Item1;
            var secondValue = values.Item2;

            if ((firstValue != "F") && (secondValue != "F"))
            {
                lbl_to_pressure.Text = firstValue;
                lbl_qnh_pressure.Text = secondValue;
            }
            else
            {
                MsgBox.Show("Check you have filled in all the information correctly", "Incorrect Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbobx_gransden_lodge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbobx_airport_info_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((tabcnt_toplevel.SelectedTab == tab_utils) && (tabcnt_utils.SelectedTab == tab_altimeter))
            {
                string[] data = airport_data.GetAirportInfo(cmbobx_airport_info.Text);

                lbl_to_pressure.Text = lbl_qnh_pressure.Text = "";

                if (rdobtn_present.Checked)
                {
                    lbl_p_airport_name.Text = "Airport Name = " + data[2];
                    lbl_p_icao_code.Text = "ICAO Code = " + data[1];
                    lbl_p_latitude_deg.Text = "Latitude degrees = " + data[3];
                    lbl_p_latitude_dec.Text = "Latitude decimal = " + data[4];
                    lbl_p_longitude_deg.Text = "Longitude degrees = " + data[5];
                    lbl_p_longitude_dec.Text = "Logitude decimal = " + data[6];
                    lbl_p_elevation_m.Text = "Elevation = " + data[7] + "m";
                    txtbx_present_altitude.Text = data[8];
                }
                else
                {
                    lbl_d_airport_name.Text = "Airport Name = " + data[2];
                    lbl_d_icao_code.Text = "ICAO Code = " + data[1];
                    lbl_d_latitude_deg.Text = "Latitude degrees = " + data[3];
                    lbl_d_latitude_dec.Text = "Latitude decimal = " + data[4];
                    lbl_d_longitude_deg.Text = "Longitude degrees = " + data[5];
                    lbl_d_longitude_dec.Text = "Logitude decimal = " + data[6];
                    lbl_d_elevation_m.Text = "Elevation = " + data[7] + "m";
                    txtbx_to_altitude.Text = data[8];
                }
            }
            else if ((tabcnt_toplevel.SelectedTab == tab_utils) && (tabcnt_utils.SelectedTab == tab_browser))
            {
                string URI = "https://metar-taf.com/" + airport_data.GetAirportInfo(cmbobx_airport_info.Text)[1];
                webView_browser.CoreWebView2.Navigate(URI);
                txtbx_navigate_to_url.Text = URI;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.Delete("airport_data.xml");
        }

        private void tabcnt_toplevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbobx_airport_info.Visible = false;
            cmbobx_gransden_lodge.Visible = false;
            grpbx_towns.Visible = false;
            grpbx_browser_navigation.Visible = false;
            grpbx_altimeter.Visible = false;
            btn_gransden_lodge_photo_update.Visible = false;

            if (tabcnt_toplevel.SelectedTab == tab_utils)
            {
                tabcnt_utils.SelectedTab = tab_browser;
                cmbobx_airport_info.SelectedIndex = 0;
                cmbobx_airport_info.Visible = true;
                grpbx_browser_navigation.Visible = true;
            }

        }

        private void tabcnt_utils_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbobx_airport_info.Visible = false;
            grpbx_altimeter.Visible = false;
            grpbx_browser_navigation.Visible = false;

            if (tabcnt_utils.SelectedTab == tab_altimeter)
            {
                cmbobx_airport_info.SelectedIndex = 0;
                cmbobx_airport_info.Visible = true;
                grpbx_altimeter.Visible = true;
                grpbx_browser_navigation.Visible = false;
            }
            else if (tabcnt_utils.SelectedTab == tab_browser)
            {
                cmbobx_airport_info.SelectedIndex = 0;
                cmbobx_airport_info.Visible = true;
                grpbx_altimeter.Visible = false;
                grpbx_browser_navigation.Visible = true;
            }
        }

        private void btn_navigate_to_Click(object sender, EventArgs e)
        {
            Navigation.NavigateTo(txtbx_navigate_to_url.Text, webView_browser);
        }

        private void txtbx_navigate_to_url_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Navigation.NavigateTo(txtbx_navigate_to_url.Text, webView_browser);
            }
        }

        private void btn_calc_wind_Click(object sender, EventArgs e)
        {
            var results = Crosswind.CalculateWind(txtbx_magnitude.Text, txtbx_direction.Text, txtbx_runway_heading.Text);
            
            lbl_runway_heading1.Text = "Runway " + double.Parse(results.Item1)/10;
            lbl_crosswind_1.Text = "Crosswind = " + results.Item2 + "kts";
            lbl_headwind_1.Text = "Headwind = " + results.Item3 + "kts";

            lbl_runway_heading2.Text = "Runway " + double.Parse(results.Item4) / 10;
            lbl_crosswind_2.Text = "Crosswind = " + results.Item5 + "kts";
            lbl_headwind_2.Text = "Crosswind = " + results.Item6 + "kts";

        }
    }
}
