using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CenteredMessagebox;
using myFlightInfo.Altimeter;
using myFlightInfo.common_data;
using myFlightInfo.crosswind;
using myFlightInfo.navigation;
using myFlightInfo.CentreOfGravity;
using myFlightInfo.Properties;


namespace myFlightInfo
{
    public partial class Form1 : Form
    {
        private Settings settings = Settings.Default;

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
            //if there is no school then ask which one
            //school gets set inside the Schools dialog
            if (settings.school == "")
            {
                var f1 = new school.school();
                f1.ShowDialog();
                GC.Collect();
            }

            //check which school is set and use it but also set button to change to other school
            btn_school.Text += settings.school == "Rochester" ? "\rLt Gransden" : "\rRochester";


            //Get the data file from resources and write to file in same dir as the app.
            File.WriteAllText("airport_data.xml", Properties.Resources.airport_data);

            Text += " : " + settings.school + " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number

            grpbx_towns.Visible = false;
            grpbx_browser_navigation.Visible = false;
            cmbobx_airport_info.Visible = false;
            cmbobx_gransden_lodge.Visible = false;
            grpbx_altimeter.Visible = false;

            await webView_notams.EnsureCoreWebView2Async();
            await webView_browser.EnsureCoreWebView2Async();
            await webView_egmj.EnsureCoreWebView2Async();
            await webView_egss.EnsureCoreWebView2Async();
            await webView_eggw.EnsureCoreWebView2Async();
            await webView_egun.EnsureCoreWebView2Async();
            await webView_egxt.EnsureCoreWebView2Async();

            await webView_egcc.EnsureCoreWebView2Async();
            await webView_egss2.EnsureCoreWebView2Async();
            await webView_egmd.EnsureCoreWebView2Async();
            await webView_egkk.EnsureCoreWebView2Async();
            await webView_egto.EnsureCoreWebView2Async();

            await webView_weather_met.EnsureCoreWebView2Async();
            await webView_weather_bbc.EnsureCoreWebView2Async();
            await webView_synoptic.EnsureCoreWebView2Async();
            await webView_gransden_lodge_weather.EnsureCoreWebView2Async();
            await webView_weather_windy.EnsureCoreWebView2Async();

            webView_notams.CoreWebView2.Navigate("https://www.notaminfo.com/ukmap?destination=node%2F39");

            SetMatarPages();
            SetWeatherPages();

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
            else if ((tabcnt_toplevel.SelectedTab == tab_utils) && (tabcnt_utils.SelectedTab == tab_crosswind))
            {
                //Need to add in reset items
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
            grpbx_towns.Visible = false;

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

            SetMatarPages();
            SetWeatherPages();
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

            lbl_runway_heading1.Text = "Runway " + double.Parse(results.Item1) / 10;
            lbl_crosswind_1.Text = "Crosswind = " + results.Item2 + "kts";
            lbl_headwind_1.Text = "Headwind = " + results.Item3 + "kts";

            lbl_runway_heading2.Text = "Runway " + double.Parse(results.Item4) / 10;
            lbl_crosswind_2.Text = "Crosswind = " + results.Item5 + "kts";
            lbl_headwind_2.Text = "Crosswind = " + results.Item6 + "kts";

        }

        private void btn_school_Click(object sender, EventArgs e)
        {
            //check which school is set and use it but also set button to change to other school
            settings.school = settings.school == "Rochester" ? "Lt Gransden" : "Rochester";

            btn_school.Text = "Change School to ";
            btn_school.Text += settings.school == "Rochester" ? "\rLt Gransden" : "\rRochester";

            Text = "myFlightInfo";
            Text += " : " + settings.school + " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number

            settings.Save();

            grpbx_towns.Visible = false;
            SetMatarPages();
            SetWeatherPages();
        }

        private void SetMatarPages()
        {
            //Show only pages for the school you are at.
            if (settings.school == "Rochester")
            {
                grpbx_towns.Visible = false;
                tabCnt_airfields.TabPages.Remove(tab_lt_gransden);
                tabCnt_airfields.TabPages.Insert(0, tab_rochester);
                webView_egcc.CoreWebView2.Navigate("https://metar-taf.com/EGCC");
                webView_egss2.CoreWebView2.Navigate("https://metar-taf.com/EGSS");
                webView_egmd.CoreWebView2.Navigate("https://metar-taf.com/EGMD");
                webView_egkk.CoreWebView2.Navigate("https://metar-taf.com/EGKK");
                webView_egto.CoreWebView2.Navigate("https://metar-taf.com/EGTO");
            }
            else
            {
                grpbx_towns.Visible = true;
                tabCnt_airfields.TabPages.Remove(tab_rochester);
                tabCnt_airfields.TabPages.Insert(0, tab_lt_gransden);
                webView_egmj.CoreWebView2.Navigate("https://metar-taf.com/EGMJ");
                webView_egss.CoreWebView2.Navigate("https://metar-taf.com/EGSS");
                webView_eggw.CoreWebView2.Navigate("https://metar-taf.com/EGGW");
                webView_egun.CoreWebView2.Navigate("https://metar-taf.com/EGUN");
                webView_egxt.CoreWebView2.Navigate("https://metar-taf.com/EGXT");
            }
        }

        private void SetWeatherPages()
        {
            //Show only pages for the school you are at.
            if (settings.school == "Rochester")
            {
                tabcnt_weather.TabPages.Remove(tab_gransden_lodge);
                webView_weather_bbc.CoreWebView2.Navigate("https://www.bbc.co.uk/weather/2639268");
                webView_weather_met.CoreWebView2.Navigate("https://metoffice.gov.uk/weather/forecast/u10k7df1y");
                webView_synoptic.CoreWebView2.Navigate("https://metoffice.gov.uk/weather/maps-and-charts/surface-pressure");
                webView_weather_windy.CoreWebView2.Navigate(
                    "https://www.windy.com/51.352/0.505/airgram?iconD2,temp,51.344,0.508,13");
            }
            else
            {
                tabcnt_weather.TabPages.Insert(4, tab_gransden_lodge);
                webView_weather_bbc.CoreWebView2.Navigate("https://www.bbc.co.uk/weather/2653941"); //Gamlinggay = 2648899 Gt Gransden = 2648095
                webView_weather_met.CoreWebView2.Navigate("https://metoffice.gov.uk/weather/forecast/u1214b469"); //waresley = gcrbu1fn7
                webView_synoptic.CoreWebView2.Navigate("https://metoffice.gov.uk/weather/maps-and-charts/surface-pressure");
                webView_gransden_lodge_weather.CoreWebView2.Navigate("https://members.camgliding.uk/members/GRLweather.aspx");
                webView_weather_windy.CoreWebView2.Navigate(
                    "https://www.windy.com/52.166/-0.154/airgram?iconD2,temp,52.164,-0.156,15");
            }

        }

        private void rdobtn_cambridge_CheckedChanged(object sender, EventArgs e)
        {
            if (tabcnt_weather.SelectedTab == tab_bbc)
            {
                if (rdobtn_Gt_Gransden.Checked)
                {
                    webView_weather_bbc.CoreWebView2.Navigate("https://www.bbc.co.uk/weather/2648095"); //Gt Gransden
                }
                else
                {
                    webView_weather_bbc.CoreWebView2.Navigate("https://www.bbc.co.uk/weather/2653941"); //Cambridge
                }
            }
            else if (tabcnt_weather.SelectedTab == tab_met_office)
            {
                if (rdobtn_Gt_Gransden.Checked)
                {
                    webView_weather_met.CoreWebView2.Navigate("https://metoffice.gov.uk/weather/forecast/gcrbu1fn7"); //waresley
                }
                else
                {
                    webView_weather_met.CoreWebView2.Navigate("https://metoffice.gov.uk/weather/forecast/u1214b469");  //Cambridge
                }
            }
        }

        private void btn_calc_cog_Click(object sender, EventArgs e)
        {
            var results = WorkOutCofG.CalculateCofG(
                txtbx_cog_pilot_weight.Text, txtbx_cog_pilot_arm.Text,
                txtbx_cog_passenger_weight.Text, txtbx_cog_passenger_arm.Text,
                txtbx_cog_cabin_bag_weight.Text, txtbx_cog_cabbin_bag_arm.Text,
                txtbx_cog_hold_bag_weight.Text, txtbx_cog_hold_bag_arm.Text,
                txtbx_cog_takeoff_fuel.Text, txtbx_cog_fuel_arm.Text,
                txtbx_cog_landing_fuel.Text, txtbx_cog_zero_fuel.Text,
                txtbx_specific_gravity.Text
                );


            lbl_cog_take_off.Text = lbl_cog_landing.Text = "";



            lbl_fuel_weight.Text = results.Item12;

            lbl_cog_pilot.Text = results.Item1;
            lbl_cog_passenger.Text = results.Item2;
            lbl_cog_cabin_baggage.Text = results.Item3;
            lbl_cog_hold_baggage.Text = results.Item4;
            lbl_cog_fuel.Text = results.Item5;
            lbl_cog_total_weight.Text = results.Item6;
            lbl_cog_total_moment.Text = results.Item7;

            lbl_cog_take_off.Text = "Take-off = " + results.Item10;
            lbl_cog_take_off.ForeColor = Color.FromName(results.Item8);

            lbl_cog_landing.Text = "Landing = " + results.Item11;
            lbl_cog_landing.ForeColor = Color.FromName(results.Item9);

            lbl_cog_zero.Text = "Zero = " + results.Item14;
            lbl_cog_zero.ForeColor = Color.FromName(results.Item13);



            //aircraftOverweight, CabinOverweight, pilotOverweight, passengerOverweight,  
            // FuelOvervolume, HoldbagOverweight, pilotUnderweight



            //chrt_cog.Series.Add("takeoff");
            //chrt_cog.Series["takeoff"].ChartType = SeriesChartType.Point;
            //chrt_cog.Series["takeoff"].Color = Color.Chartreuse;
            //chrt_cog.Series["takeoff"].Points.AddXY(1,0);


            //chrt_cog.Series["cog"].Points.AddXY(4, 0);
            //chrt_cog.Series["cog"].Points.AddXY(6, 0);
            //chrt_cog.Series["cog"].Points.AddXY(2, 0);
            //chrt_cog.Series["cog"].Points.AddXY(3, 0);


            //chrt_cog.Series["default"].Color=Color.Black;

            //chrt_cog.Series["default"].Points.AddXY(4, 0);
            //chrt_cog.Series["default"].Points.AddXY(6, 0);


        }

        private void btn_cog_reset_Click(object sender, EventArgs e)
        {
            txtbx_cog_pilot_weight.Text = txtbx_cog_passenger_weight.Text = txtbx_cog_cabin_bag_weight.Text =
                txtbx_cog_hold_bag_weight.Text = txtbx_cog_takeoff_fuel.Text = txtbx_cog_zero_fuel.Text = "0";

            txtbx_cog_pilot_arm.Text = txtbx_cog_passenger_arm.Text = txtbx_cog_cabbin_bag_arm.Text = "400";

            txtbx_cog_hold_bag_arm.Text = txtbx_cog_fuel_arm.Text = "950";

            txtbx_cog_landing_fuel.Text = "10";
            txtbx_specific_gravity.Text = "0.72";
            
            lbl_cog_pilot.Text = lbl_cog_passenger.Text = lbl_cog_cabin_baggage.Text =
                lbl_cog_hold_baggage.Text = lbl_cog_fuel.Text = lbl_cog_total_weight.Text =
                    lbl_cog_take_off.Text = lbl_cog_landing.Text = lbl_cog_zero.Text =
                        lbl_fuel_weight.Text = "";

            lbl_cog_take_off.ForeColor = lbl_cog_landing.ForeColor = lbl_cog_zero.ForeColor = Color.Black;
        }
    }
}
