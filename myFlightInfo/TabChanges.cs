using System;

namespace myFlightInfo
{
    public partial class Form1
    {
        /*
         * A tabcnt is the parent tab but can be a child inside the parent
         * A tab is just a tab in the parent tabcnt. there can be many tabs to one tabcnt
         *
         * The outlay of the tabs is below.
         *
         * tabcnt_toplevel  - tab_weather
         *                          |
         *                          tabcnt_weather
         *                                          - tab_met_office
         *                                          - tab_bbc
         *                                          - tab_windy
         *                                          - tab_synoptic
         *                                          - tab_gransden_lodge
         *                  - tab_metar
         *                          |
         *                          tabCnt_airfields
         *                                  |
         *                                      - tab_lt_gransden
         *                                              |
         *                                              tabcnt_lt_gransden
         *                                                                  - tab_m_ltgransden
         *                                                                  - tab_m_luton
         *                                                                  - tab_m_stanstead
         *                                                                  - tab_m_wittering
         *                                                                  - tab_m_mildenhall
         *                                      - tab_rochester
         *                                              |
         *                                              tabCnt_rochester
         *                                                              - tab_m_rochester
         *                                                              - tab_m_lon_city
         *                                                              - tab_m_ludd
         *                                                              - tab_m_gatwick
         *                                                              - tab_m_stanstead
         *                  - tab_notams
         *                  - tab_utils
         *                          |
         *                              - tab_browser
         *                              - tab_altimeter
         *                              - tab_crosswind
         *                              - tab_weight_balance
         *                              - tab_compliance_data
         */


        /// <summary>
        /// The main Tabs are changed. Tabs are Weather, Metar, NOTAMS, Utilities 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabcnt_toplevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbobx_airport_info.Visible = false;
            NavigationDateTimePicker.Visible = false;
            cmbobx_gransden_lodge.Visible = false;
            grpbx_towns.Visible = true;
            btn_school.Visible = true;
            grpbx_browser_navigation.Visible = false;
            grpbx_altimeter.Visible = false;
            btn_gransden_lodge_photo_update.Visible = false;

            if (tabcnt_toplevel.SelectedTab == tab_utils)
            {
                tabcnt_weather.SelectedTab = tab_met_office;
                tabcnt_utils.SelectedTab = tab_browser;
                cmbobx_airport_info.SelectedIndex = 0;
                cmbobx_airport_info.Visible = true;
                NavigationDateTimePicker.Visible = false;
                grpbx_browser_navigation.Visible = true;
                btn_school.Visible = false;
                grpbx_towns.Visible = false;
            }
            else if (tabcnt_toplevel.SelectedTab == tab_metar)
            {
                grpbx_towns.Visible = false;
            }
            else if (tabcnt_toplevel.SelectedTab == tab_notams)
            {
                grpbx_towns.Visible = false;
            }
            else if ((tabcnt_toplevel.SelectedTab == tab_weather) && (settings.school != "Rochester"))
            {
                grpbx_towns.Visible = true;
            }

        }

        /// <summary>
        /// The main Tabs Utils is chosen and this gives us a second set of tabs are changed.
        /// Tabs are met_office, BBC, windy, synoptic.
        /// if set to lt gransden then also tab gransden_lodge 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabcnt_weather_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (settings.school != "Rochester") grpbx_towns.Visible = true;
            btn_school.Visible = true;
            cmbobx_gransden_lodge.Visible = true;
            btn_gransden_lodge_photo_update.Visible = false;

            if (tabcnt_weather.SelectedTab == tab_gransden_lodge)
            {
                cmbobx_gransden_lodge.Visible = true;
                cmbobx_gransden_lodge.SelectedIndex = 0;
                grpbx_towns.Visible = false;
                btn_school.Visible = false;
            }
            else if (tabcnt_weather.SelectedTab == tab_windy)
            {
                cmbobx_gransden_lodge.Visible = false;
                grpbx_towns.Visible = false;
            }
            else if (tabcnt_weather.SelectedTab == tab_bbc)
            {
                cmbobx_gransden_lodge.Visible = false;

                if (settings.school == "Rochester")
                {
                    grpbx_towns.Visible = false;
                    webView_weather_bbc.CoreWebView2.Navigate("https://www.bbc.co.uk/weather/2639268");
                }
                else
                {
                    grpbx_towns.Visible = true;
                    if (rdobtn_cambridge.Checked)
                    {
                        webView_weather_bbc.CoreWebView2.Navigate(
                            "https://www.bbc.co.uk/weather/2653941");
                    }
                    else
                    {
                        webView_weather_bbc.CoreWebView2.Navigate(
                            "https://www.bbc.co.uk/weather/2648095"); //Gamlinggay = 2648899 Gt Gransden = 2648095
                    }
                }

                grpbx_towns.Visible = true;
                btn_school.Visible = true;
            }
            else if (tabcnt_weather.SelectedTab == tab_met_office)
            {
                cmbobx_gransden_lodge.Visible = false;

                if (settings.school == "Rochester")
                {
                    grpbx_towns.Visible = false;
                    webView_weather_met.CoreWebView2.Navigate("https://metoffice.gov.uk/weather/forecast/u10k7df1y");
                }
                else
                {
                    grpbx_towns.Visible = true;
                    if (rdobtn_cambridge.Checked)
                    {
                        webView_weather_met.CoreWebView2.Navigate(
                            "https://metoffice.gov.uk/weather/forecast/u1214b469");
                    }
                    else
                    {
                        webView_weather_met.CoreWebView2.Navigate(
                            "https://metoffice.gov.uk/weather/forecast/gcrbu1fn7"); //waresley = gcrbu1fn7
                    }
                }
            }
            else if (tabcnt_weather.SelectedTab == tab_synoptic)
            {
                cmbobx_gransden_lodge.Visible = false;

                grpbx_towns.Visible = false;
                btn_school.Visible = false;
            }
            else if (tabcnt_weather.SelectedTab == tab_nasa_satellite)
            {
                cmbobx_gransden_lodge.Visible = false;

                grpbx_towns.Visible = false;
                btn_school.Visible = false;
            }
        }



        /// <summary>
        /// The main Tabs Utils is chosen and this gives us a second set of tabs are changed.
        /// Tabs are Browser, Crosswind, altimeter, weights and balances, compliance data.  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabcnt_utils_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbobx_airport_info.Visible = false;
            NavigationDateTimePicker.Visible = false;
                grpbx_altimeter.Visible = false;
            grpbx_browser_navigation.Visible = false;
            btn_navigation_calculations.Visible = false;

            if (tabcnt_utils.SelectedTab == tab_navigation)
            {
                btn_navigation_calculations.Visible = false;
               cmbobx_airport_info.Visible = true;
                NavigationDateTimePicker.Visible = true;
                grpbx_altimeter.Visible = true;
                grpbx_browser_navigation.Visible = true;
                btn_navigate_to.Visible = false;
                txtbx_navigate_to_url.Visible = false;

                if ((lbl_d_airport_name.Text != "..") && (lbl_d_airport_name.Text != ""))
                {
                    btn_navigation_calculations.Visible = true;
                }

            }
            else if (tabcnt_utils.SelectedTab == tab_browser)
            {
                cmbobx_airport_info.SelectedIndex = 0;
                cmbobx_airport_info.Visible = true;
                NavigationDateTimePicker.Visible = false;
                grpbx_altimeter.Visible = false;
                grpbx_browser_navigation.Visible = true;
                btn_navigate_to.Visible = true;
                txtbx_navigate_to_url.Visible = true;
            }
            
            SetMetarPages();
            SetWeatherPages();

            grpbx_towns.Visible = false;
            btn_school.Visible = false;

            //Here we select the textbox that will be in focus.
            if (tabcnt_utils.SelectedTab == tab_crosswind)
            {
                txtbx_magnitude.Select(); // Put cursor into Wind Magnitude Textbox"
            }
            else if (tabcnt_utils.SelectedTab == tab_weight_balance)
            {
                txtbx_cog_pilot_weight.Select(); // Put cursor into pilots weight Textbox"
            }
        }
    }
}
