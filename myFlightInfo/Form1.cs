using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using CenteredMessagebox;
using myFlightInfo.Navigation;
using myFlightInfo.common_data;
using myFlightInfo.crosswind;
using myFlightInfo.browsing;
using myFlightInfo.Properties;
using xmlFactory;

//using myFlightInfo.compliance_data;


namespace myFlightInfo
{
    public partial class Form1 : Form
    {
        private Settings settings = Settings.Default;
        private Thread myThread;

        public Form1()
        {
            //write the dlls before initialising.
            File.WriteAllBytes("Microsoft.Web.WebView2.Core.dll", Resources.Microsoft_Web_WebView2_Core);
            File.WriteAllBytes("Microsoft.Web.WebView2.WinForms.dll", Resources.Microsoft_Web_WebView2_WinForms);

            File.WriteAllBytes("CoordinateSharp.Magnetic.dll", Resources.CoordinateSharp_Magnetic);
            File.WriteAllBytes("CoordinateSharp.dll", Resources.CoordinateSharp);

            string arcitectureProcessArchitecture =
                System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture.ToString();

            if (arcitectureProcessArchitecture == "X64")
            {
                //64bit 
                File.WriteAllBytes("WebView2Loader.dll", Resources._64_WebView2Loader);
            }
            else if (arcitectureProcessArchitecture == "X86")
            {
                // 32bit
                File.WriteAllBytes("WebView2Loader.dll", Resources._32_WebView2Loader);
            }
            else if (arcitectureProcessArchitecture == "Arm64")
            {
                //ARM64bit 
                File.WriteAllBytes("WebView2Loader.dll", Resources.arm64_WebView2Loader);
            }

            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // make GUI invisible
            SetVisibleCore(false);

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
            File.WriteAllText("airport_data.xml", Resources.airport_data);
            //Start thread to populate the combobox after writing file above
            //Watch cross threading
            myThread = new Thread(new ThreadStart(PopulateAirfieldCmboBx));
            myThread.Start();

            //if the file does not exist then copy basic file from resources
            if (!File.Exists("compliance_data.xml"))
            {
                File.WriteAllText("compliance_data.xml", Resources.compliance_data);
            }

            Text += " : " + settings.school + " : v" +
                     Assembly.GetExecutingAssembly().GetName().Version; // put in the version number

            grpbx_towns.Visible = false;
            grpbx_browser_navigation.Visible = false;
            cmbobx_airport_info.Visible = false;
            cmbobx_gransden_lodge.Visible = false;
            grpbx_altimeter.Visible = false;
            btn_navigation_calculations.Visible = false;

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
            await webView_weather_netweather.EnsureCoreWebView2Async();
            await webView_synoptic.EnsureCoreWebView2Async();
            await webView_gransden_lodge_weather.EnsureCoreWebView2Async();
            await webView_weather_windy.EnsureCoreWebView2Async();

            await webView_navFromChart.EnsureCoreWebView2Async();
            await webView_navToChart.EnsureCoreWebView2Async();

            webView_notams.CoreWebView2.Navigate("https://www.notaminfo.com/ukmap?destination=node%2F39");

            SetMetarPages();
            SetWeatherPages();

            cmbobx_gransden_lodge.SelectedIndex = 0;

            //do this last in this order to make sure all else is working.
            PopulateComplianceDataCmboBx(settings.Aircraft); //set to aircraft in settings
            GetSettings();

            //Make GUI visible but the combobox will still be loading on different thread
            SetVisibleCore(true);
        }


        void PopulateAirfieldCmboBx()
        {
            // A different thread watch cross threading
            //populate the combo boxes with the airfield names direct from xml file so we get 
            //names correctly spelt for later look up
            XmlDocument doc = new XmlDocument();
            doc.Load("airport_data.xml");
            XmlNodeList airportList = doc.SelectNodes("uk_airports/airport_info/airport_name");
            foreach (XmlNode Name in airportList)
            {
                if (Name.InnerText != "UN-ASSIGNED") // if there is am actual airport
                {
                    string[] data = airport_data.GetAirportInfo(Name.InnerText);

                    if (data[8] != "") // only include if we have data for airport in this case altitude in metres
                    {
                        //use invoke ot prevent cross threading
                        BeginInvoke(new Action(() =>
                        {
                            cmbobx_airport_info.Items.Add(Name.InnerText);
                        }));
                    }
                }
            }

            //use invoke ot prevent cross threading
            BeginInvoke(new Action(() =>
            {
                cmbobx_airport_info.SelectedIndex = 0;
            }));
        }

        //Use this to make the GUI visible after it has loaded
        protected override void SetVisibleCore(bool value)
        {
            if (!IsHandleCreated)
            {
                CreateHandle();
            }
            base.SetVisibleCore(value);
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
            else if (tabcnt_toplevel.SelectedTab == tab_metar)
            {
                SetMetarPages();
            }
            else if ((tabcnt_toplevel.SelectedTab == tab_weather) && (tabcnt_weather.SelectedTab == tab_gransden_lodge))
            {
                webView_gransden_lodge_weather.CoreWebView2.Navigate("https://members.camgliding.uk/members/GRLweather.aspx");
            }
            else if (tabcnt_toplevel.SelectedTab == tab_weather)
            {
                SetWeatherPages();
            }
            else if ((tabcnt_toplevel.SelectedTab == tab_utils) && (tabcnt_utils.SelectedTab == tab_navigation))
            {
                cmbobx_airport_info.SelectedIndex = 0;
                rdobtn_present.Checked = true;

                txtbx_present_pressure.Text = "0";
                txtbx_present_altitude.Text = "";
                txtbx_to_altitude.Text = "";
                lbl_p_airport_name.Text = "";
                lbl_d_airport_name.Text = "";
                lbl_to_pressure.Text = "";

                NavigationDateTimePicker.Value = DateTime.Now;

                lstbx_navigation_from.Items.Clear();
                lstbx_navigation_to.Items.Clear();
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

        private void btn_navigation_calculations_Click(object sender, EventArgs e)
        {
            //Calculate settings for altitude at destination
            /*
             * var values = MyFunction();
               var firstValue = values.Item1;
               var secondValue = values.Item2;
               var thirdValue = values.Item3;

                (string, string, string)MyFunction()

             */

            int year = NavigationDateTimePicker.Value.Year;
            int month = NavigationDateTimePicker.Value.Month;
            int day = NavigationDateTimePicker.Value.Day;
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;

            if (altimeter.Calculate_altimeter(txtbx_present_pressure.Text, txtbx_present_altitude.Text,
                    txtbx_to_altitude.Text, lstbx_navigation_from, lstbx_navigation_to, lbl_to_pressure))
            {
                // Get bearing and distance display in listbox for both airfields
                Navigate.BearingAndDistance(lbl_p_airport_name.Text, lbl_d_airport_name.Text, year, month, day, hour,
                    minute, second, lstbx_navigation_from);

                Navigate.BearingAndDistance(lbl_d_airport_name.Text, lbl_p_airport_name.Text, year, month, day, hour,
                    minute, second, lstbx_navigation_to);
            }
            else
            {
                MsgBox.Show("Check you have filled in all the information correctly", "Incorrect Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbobx_gransden_lodge_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_gransden_lodge_photo_update.Visible = false;

            if (cmbobx_gransden_lodge.Text == "General Weather")
            {
                webView_gransden_lodge_weather.CoreWebView2.Navigate(
                    "https://members.camgliding.uk/members/GRLweather.aspx");
            }
            else if (cmbobx_gransden_lodge.Text == "Browse Weather")
            {
                webView_gransden_lodge_weather.CoreWebView2.Navigate(
                    "https://members.camgliding.uk/xcplanning/weather.aspx");
            }
            else if (cmbobx_gransden_lodge.Text == "Radar Weather")
            {
                webView_gransden_lodge_weather.CoreWebView2.Navigate(
                    "https://members.camgliding.uk/tracking/");
            }
            else if (cmbobx_gransden_lodge.Text == "South Camera")
            {
                btn_gransden_lodge_photo_update.Visible = true;
                webView_gransden_lodge_weather.CoreWebView2.Navigate(
                    "https://members.camgliding.uk/volatile/camsouth.jpg");
            }
            else if (cmbobx_gransden_lodge.Text == "West Camera")
            {
                btn_gransden_lodge_photo_update.Visible = true;
                webView_gransden_lodge_weather.CoreWebView2.Navigate(
                    "https://members.camgliding.uk/volatile/camwest.jpg");
            }
        }

        private void cmbobx_airport_info_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((tabcnt_toplevel.SelectedTab == tab_utils) && (tabcnt_utils.SelectedTab == tab_navigation))
            {
                

                grpbx_towns.Visible = false;

                int year = NavigationDateTimePicker.Value.Year;
                int month = NavigationDateTimePicker.Value.Month;
                int day = NavigationDateTimePicker.Value.Day;

                //we use flags as the info in the xml file we will use may not be complete
                //we only show info if it is complete.
                bool noInfoFlag;
                bool fromDataOK = true;

                if (rdobtn_present.Checked)
                {
                    fromDataOK = false;

                    noInfoFlag = Navigate.AirfieldCoOrdinates(true, cmbobx_airport_info.Text, lstbx_navigation_from,
                        lbl_to_pressure, lbl_p_airport_name, txtbx_present_altitude, txtbx_present_pressure);

                    if (noInfoFlag)
                    {
                        string[] data = airport_data.GetAirportInfo(cmbobx_airport_info.Text);
                        double lat = double.Parse(data[4]);
                        double lng = double.Parse(data[6]);

                        Navigate.SolarInfo(cmbobx_airport_info.Text, lstbx_navigation_from, year, month, day);

                        webView_navFromChart.CoreWebView2.Navigate("https://www.openstreetmap.org/?minlat" +
                            lat + "&minlon=" + lng + "#map=14/" + lat + "/" + lng);

                        fromDataOK = true;
                    }
                }
                else
                {
                    noInfoFlag = Navigate.AirfieldCoOrdinates(false, cmbobx_airport_info.Text, lstbx_navigation_to,
                        lbl_to_pressure, lbl_d_airport_name, txtbx_to_altitude, txtbx_present_pressure);

                    if ((noInfoFlag) && (fromDataOK))
                    {
                        string[] data = airport_data.GetAirportInfo(cmbobx_airport_info.Text);
                        double lat = double.Parse(data[4]);
                        double lng = double.Parse(data[6]);

                        Navigate.SolarInfo(cmbobx_airport_info.Text, lstbx_navigation_to, year, month, day);

                        webView_navToChart.CoreWebView2.Navigate("https://www.openstreetmap.org/?minlat" +
                                                                   lat + "&minlon=" + lng + "#map=14/" + lat + "/" + lng);
                       
                        btn_navigation_calculations.Visible = true; //Now show button to calculate
                    }

                }
            }
            else if ((tabcnt_toplevel.SelectedTab == tab_utils) && (tabcnt_utils.SelectedTab == tab_browser))
            {
                grpbx_towns.Visible = false;

                string URI = "https://metar-taf.com/" + airport_data.GetAirportInfo(cmbobx_airport_info.Text)[1];
                webView_browser.CoreWebView2.Navigate(URI);
                txtbx_navigate_to_url.Text = URI;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //Update with Sunrise and Sunset for this new date

            if (((lbl_p_airport_name.Text != "") && (lbl_p_airport_name.Text != "..")) ||
                ((lbl_d_airport_name.Text != "..") && (lbl_d_airport_name.Text != "")))
            {

                int year = NavigationDateTimePicker.Value.Year;
                int month = NavigationDateTimePicker.Value.Month;
                int day = NavigationDateTimePicker.Value.Day;

                Navigate.SolarInfo(lbl_p_airport_name.Text, lstbx_navigation_from, year, month, day);
                Navigate.SolarInfo(lbl_d_airport_name.Text, lstbx_navigation_to, year, month, day);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            myThread.Abort();
            Thread.Sleep(500);
            if (File.Exists("airport_data.xml")) File.Delete("airport_data.xml");
        }


        private void btn_navigate_to_Click(object sender, EventArgs e)
        {
            Browse.NavigateTo(txtbx_navigate_to_url.Text, webView_browser);
        }

        
        private void btn_school_Click(object sender, EventArgs e)
        {
            //check which school is set and use it but also set button to change to other school
            settings.school = settings.school == "Rochester" ? "Lt Gransden" : "Rochester";

            btn_school.Text = "Change School to ";
            btn_school.Text += settings.school == "Rochester" ? "\rLt Gransden" : "\rRochester";

            Text = "myFlightInfo";
            Text += " : " + settings.school + " : v" +
                    Assembly.GetExecutingAssembly().GetName().Version; // put in the version number

            settings.Save();

            grpbx_towns.Visible = false;
            SetMetarPages();
            SetWeatherPages();
        }

        private void SetMetarPages()
        {
            tabCnt_airfields.TabPages.Clear(); //Remove all pages associated with tab control airfields.

            //Show only pages for the school you are at.
            if (settings.school == "Rochester")
            {
                grpbx_towns.Visible = false;
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
                grpbx_towns.Visible = false;
                tabcnt_weather.TabPages.Remove(tab_gransden_lodge);
                webView_weather_bbc.CoreWebView2.Navigate("https://www.bbc.co.uk/weather/2639268");
                webView_weather_met.CoreWebView2.Navigate("https://metoffice.gov.uk/weather/forecast/u10k7df1y");
                webView_synoptic.CoreWebView2.Navigate(
                    "https://metoffice.gov.uk/weather/maps-and-charts/surface-pressure");
                webView_weather_windy.CoreWebView2.Navigate(
                    "https://www.windy.com/51.352/0.505/airgram?iconD2,temp,51.344,0.508,13");
            }
            else
            {
                if (tab_gransden_lodge.Visible)
                {
                    tabcnt_weather.TabPages.Insert(4, tab_gransden_lodge);
                    webView_gransden_lodge_weather.CoreWebView2.Navigate(
                        "https://members.camgliding.uk/members/GRLweather.aspx");
                }

                if (rdobtn_cambridge.Checked)
                {
                    webView_weather_bbc.CoreWebView2.Navigate(
                        "https://www.bbc.co.uk/weather/2653941");
                    webView_weather_met.CoreWebView2.Navigate(
                        "https://metoffice.gov.uk/weather/forecast/u1214b469");
                    webView_weather_netweather.CoreWebView2.Navigate("https://www.netweather.tv/weather-forecasts/uk/7-day/5155~Cambridge");
                }
                else
                {
                    webView_weather_bbc.CoreWebView2.Navigate(
                        "https://www.bbc.co.uk/weather/2648095"); //Gamlinggay = 2648899 Gt Gransden = 2648095
                    webView_weather_met.CoreWebView2.Navigate(
                        "https://metoffice.gov.uk/weather/forecast/gcrbu1fn7"); //waresley = gcrbu1fn7
                    webView_weather_netweather.CoreWebView2.Navigate("https://www.netweather.tv/weather-forecasts/uk/7-day/50408~Little%20Gransden");
                }

                if (tabcnt_weather.SelectedTab == tab_windy) grpbx_towns.Visible = false;

                webView_synoptic.CoreWebView2.Navigate(
                    "https://metoffice.gov.uk/weather/maps-and-charts/surface-pressure");
                webView_gransden_lodge_weather.CoreWebView2.Navigate(
                    "https://members.camgliding.uk/members/GRLweather.aspx");
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
                    webView_weather_met.CoreWebView2.Navigate(
                        "https://metoffice.gov.uk/weather/forecast/gcrbu1fn7"); //waresley
                }
                else
                {
                    webView_weather_met.CoreWebView2.Navigate(
                        "https://metoffice.gov.uk/weather/forecast/u1214b469"); //Cambridge
                }
            }
            else if (tabcnt_weather.SelectedTab == tab_netweather)
            {
                if (rdobtn_Gt_Gransden.Checked)
                {
                    webView_weather_netweather.CoreWebView2.Navigate(
                        "https://www.netweather.tv/weather-forecasts/uk/7-day/50408~Little%20Gransden");//lt gransden

                }
                else
                {
                    webView_weather_netweather.CoreWebView2.Navigate(
                        "https://www.netweather.tv/weather-forecasts/uk/7-day/5155~Cambridge"); //Cambridge
                }
            }
        }

        private void btn_gransden_lodge_photo_update_Click(object sender, EventArgs e)
        {
            if (cmbobx_gransden_lodge.Text == "South Camera")
            {
                webView_gransden_lodge_weather.CoreWebView2.Navigate(
                    "https://members.camgliding.uk/volatile/camsouth.jpg");
            }
            else if (cmbobx_gransden_lodge.Text == "West Camera")
            {
                webView_gransden_lodge_weather.CoreWebView2.Navigate(
                    "https://members.camgliding.uk/volatile/camwest.jpg");
            }
        }

       
    }
}
