
namespace myFlightInfo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.panel31 = new System.Windows.Forms.Panel();
            this.grpbx_towns = new System.Windows.Forms.GroupBox();
            this.rdobtn_Gt_Gransden = new System.Windows.Forms.RadioButton();
            this.rdobtn_cambridge = new System.Windows.Forms.RadioButton();
            this.panel32 = new System.Windows.Forms.Panel();
            this.grpbx_altimeter = new System.Windows.Forms.GroupBox();
            this.rdobtn_destination = new System.Windows.Forms.RadioButton();
            this.rdobtn_present = new System.Windows.Forms.RadioButton();
            this.panel33 = new System.Windows.Forms.Panel();
            this.cmbobx_gransden_lodge = new System.Windows.Forms.ComboBox();
            this.cmbobx_airport_info = new System.Windows.Forms.ComboBox();
            this.panel34 = new System.Windows.Forms.Panel();
            this.grpbx_browser_navigation = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.panel35 = new System.Windows.Forms.Panel();
            this.txtbx_navigate_to_url = new System.Windows.Forms.TextBox();
            this.panel36 = new System.Windows.Forms.Panel();
            this.btn_navigate_to = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_gransden_lodge_photo_update = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_school = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.tabcnt_toplevel = new System.Windows.Forms.TabControl();
            this.tab_weather = new System.Windows.Forms.TabPage();
            this.tabcnt_weather = new System.Windows.Forms.TabControl();
            this.tab_met_office = new System.Windows.Forms.TabPage();
            this.webView_weather_met = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_bbc = new System.Windows.Forms.TabPage();
            this.webView_weather_bbc = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_windy = new System.Windows.Forms.TabPage();
            this.webView_weather_windy = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_synoptic = new System.Windows.Forms.TabPage();
            this.webView_synoptic = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_gransden_lodge = new System.Windows.Forms.TabPage();
            this.webView_gransden_lodge_weather = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_metar = new System.Windows.Forms.TabPage();
            this.tabCnt_airfields = new System.Windows.Forms.TabControl();
            this.tab_lt_gransden = new System.Windows.Forms.TabPage();
            this.tabcnt_lt_gransden = new System.Windows.Forms.TabControl();
            this.tab_m_ltgransden = new System.Windows.Forms.TabPage();
            this.webView_egmj = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_m_luton = new System.Windows.Forms.TabPage();
            this.webView_eggw = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_m_stanstead = new System.Windows.Forms.TabPage();
            this.webView_egss = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_m_wittering = new System.Windows.Forms.TabPage();
            this.webView_egxt = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_m_mildenhall = new System.Windows.Forms.TabPage();
            this.webView_egun = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_rochester = new System.Windows.Forms.TabPage();
            this.tabCnt_rochester = new System.Windows.Forms.TabControl();
            this.tab_m_rochester = new System.Windows.Forms.TabPage();
            this.webView_egto = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_m_lon_city = new System.Windows.Forms.TabPage();
            this.webView_egcc = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_m_lydd = new System.Windows.Forms.TabPage();
            this.webView_egmd = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_m_gatwick = new System.Windows.Forms.TabPage();
            this.webView_egkk = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_m_stansted = new System.Windows.Forms.TabPage();
            this.webView_egss2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_notams = new System.Windows.Forms.TabPage();
            this.webView_notams = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_utils = new System.Windows.Forms.TabPage();
            this.tabcnt_utils = new System.Windows.Forms.TabControl();
            this.tab_browser = new System.Windows.Forms.TabPage();
            this.webView_browser = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tab_altimeter = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_calculate_altimiter = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.grpbx_to = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_to_altitude = new System.Windows.Forms.TextBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.lbl_to_pressure = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.lbl_d_elevation_m = new System.Windows.Forms.Label();
            this.lbl_d_longitude_dec = new System.Windows.Forms.Label();
            this.lbl_d_longitude_deg = new System.Windows.Forms.Label();
            this.lbl_d_latitude_dec = new System.Windows.Forms.Label();
            this.lbl_d_latitude_deg = new System.Windows.Forms.Label();
            this.lbl_d_icao_code = new System.Windows.Forms.Label();
            this.lbl_d_airport_name = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.grpbx_present = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtbx_present_altitude = new System.Windows.Forms.TextBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel30 = new System.Windows.Forms.Panel();
            this.txtbx_present_pressure = new System.Windows.Forms.TextBox();
            this.panel37 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.lbl_p_elevation_m = new System.Windows.Forms.Label();
            this.lbl_p_longitude_dec = new System.Windows.Forms.Label();
            this.lbl_p_longitude_deg = new System.Windows.Forms.Label();
            this.lbl_p_latitude_dec = new System.Windows.Forms.Label();
            this.lbl_p_latitude_deg = new System.Windows.Forms.Label();
            this.lbl_p_icao_code = new System.Windows.Forms.Label();
            this.lbl_p_airport_name = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.grpbx_QNH = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lbl_sea_level_ft = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lbl_qnh_pressure = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.tab_crosswind = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_calc_wind = new System.Windows.Forms.Button();
            this.lbl_runway_heading2 = new System.Windows.Forms.Label();
            this.lbl_headwind_2 = new System.Windows.Forms.Label();
            this.lbl_crosswind_2 = new System.Windows.Forms.Label();
            this.lbl_runway_heading1 = new System.Windows.Forms.Label();
            this.lbl_headwind_1 = new System.Windows.Forms.Label();
            this.lbl_crosswind_1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbx_runway_heading = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbx_direction = new System.Windows.Forms.TextBox();
            this.txtbx_magnitude = new System.Windows.Forms.TextBox();
            this.tab_CofG = new System.Windows.Forms.TabPage();
            this.btn_cog_reset = new System.Windows.Forms.Button();
            this.rchtxtbx_cog_report = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_fuel_weight = new System.Windows.Forms.Label();
            this.lbl_cog_total_moment = new System.Windows.Forms.Label();
            this.lbl_cog_total_weight = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbx_cog_hold_bag_weight = new System.Windows.Forms.TextBox();
            this.txtbx_cog_cabin_bag_weight = new System.Windows.Forms.TextBox();
            this.txtbx_cog_passenger_weight = new System.Windows.Forms.TextBox();
            this.txtbx_cog_pilot_weight = new System.Windows.Forms.TextBox();
            this.lbl_cog_fuel = new System.Windows.Forms.Label();
            this.lbl_cog_hold_baggage = new System.Windows.Forms.Label();
            this.lbl_cog_cabin_baggage = new System.Windows.Forms.Label();
            this.lbl_cog_passenger = new System.Windows.Forms.Label();
            this.lbl_cog_pilot = new System.Windows.Forms.Label();
            this.txtbx_cog_fuel_arm = new System.Windows.Forms.TextBox();
            this.txtbx_cog_hold_bag_arm = new System.Windows.Forms.TextBox();
            this.txtbx_cog_cabin_bag_arm = new System.Windows.Forms.TextBox();
            this.txtbx_cog_passenger_arm = new System.Windows.Forms.TextBox();
            this.txtbx_cog_pilot_arm = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chrt_cog = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_cog_zero = new System.Windows.Forms.Label();
            this.lbl_cog_landing = new System.Windows.Forms.Label();
            this.lbl_cog_take_off = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtbx_specific_gravity = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtbx_cog_zero_fuel = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtbx_cog_landing_fuel = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtbx_cog_takeoff_fuel = new System.Windows.Forms.TextBox();
            this.btn_calc_cog = new System.Windows.Forms.Button();
            this.btn_cog_print_report = new System.Windows.Forms.Button();
            this.txtbx_cog_accessories_weight = new System.Windows.Forms.TextBox();
            this.lbl_cog_accessories = new System.Windows.Forms.Label();
            this.txtbx_cog_accessories_arm = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel31.SuspendLayout();
            this.grpbx_towns.SuspendLayout();
            this.panel32.SuspendLayout();
            this.grpbx_altimeter.SuspendLayout();
            this.panel33.SuspendLayout();
            this.panel34.SuspendLayout();
            this.grpbx_browser_navigation.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel35.SuspendLayout();
            this.panel36.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabcnt_toplevel.SuspendLayout();
            this.tab_weather.SuspendLayout();
            this.tabcnt_weather.SuspendLayout();
            this.tab_met_office.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_weather_met)).BeginInit();
            this.tab_bbc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_weather_bbc)).BeginInit();
            this.tab_windy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_weather_windy)).BeginInit();
            this.tab_synoptic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_synoptic)).BeginInit();
            this.tab_gransden_lodge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_gransden_lodge_weather)).BeginInit();
            this.tab_metar.SuspendLayout();
            this.tabCnt_airfields.SuspendLayout();
            this.tab_lt_gransden.SuspendLayout();
            this.tabcnt_lt_gransden.SuspendLayout();
            this.tab_m_ltgransden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_egmj)).BeginInit();
            this.tab_m_luton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_eggw)).BeginInit();
            this.tab_m_stanstead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_egss)).BeginInit();
            this.tab_m_wittering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_egxt)).BeginInit();
            this.tab_m_mildenhall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_egun)).BeginInit();
            this.tab_rochester.SuspendLayout();
            this.tabCnt_rochester.SuspendLayout();
            this.tab_m_rochester.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_egto)).BeginInit();
            this.tab_m_lon_city.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_egcc)).BeginInit();
            this.tab_m_lydd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_egmd)).BeginInit();
            this.tab_m_gatwick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_egkk)).BeginInit();
            this.tab_m_stansted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_egss2)).BeginInit();
            this.tab_notams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_notams)).BeginInit();
            this.tab_utils.SuspendLayout();
            this.tabcnt_utils.SuspendLayout();
            this.tab_browser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_browser)).BeginInit();
            this.tab_altimeter.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.grpbx_to.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel9.SuspendLayout();
            this.grpbx_present.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel30.SuspendLayout();
            this.panel37.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel10.SuspendLayout();
            this.grpbx_QNH.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.tab_crosswind.SuspendLayout();
            this.tab_CofG.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_cog)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tabcnt_toplevel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1365, 805);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 7;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 335F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.panel31, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel32, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel33, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel34, 6, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1359, 94);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.grpbx_towns);
            this.panel31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel31.Location = new System.Drawing.Point(3, 3);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(149, 88);
            this.panel31.TabIndex = 0;
            // 
            // grpbx_towns
            // 
            this.grpbx_towns.Controls.Add(this.rdobtn_Gt_Gransden);
            this.grpbx_towns.Controls.Add(this.rdobtn_cambridge);
            this.grpbx_towns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbx_towns.Location = new System.Drawing.Point(0, 0);
            this.grpbx_towns.Name = "grpbx_towns";
            this.grpbx_towns.Size = new System.Drawing.Size(149, 88);
            this.grpbx_towns.TabIndex = 4;
            this.grpbx_towns.TabStop = false;
            // 
            // rdobtn_Gt_Gransden
            // 
            this.rdobtn_Gt_Gransden.AutoSize = true;
            this.rdobtn_Gt_Gransden.Location = new System.Drawing.Point(15, 52);
            this.rdobtn_Gt_Gransden.Name = "rdobtn_Gt_Gransden";
            this.rdobtn_Gt_Gransden.Size = new System.Drawing.Size(123, 24);
            this.rdobtn_Gt_Gransden.TabIndex = 3;
            this.rdobtn_Gt_Gransden.Text = "Lt Gransden";
            this.rdobtn_Gt_Gransden.UseVisualStyleBackColor = true;
            // 
            // rdobtn_cambridge
            // 
            this.rdobtn_cambridge.AutoSize = true;
            this.rdobtn_cambridge.Checked = true;
            this.rdobtn_cambridge.Location = new System.Drawing.Point(15, 22);
            this.rdobtn_cambridge.Name = "rdobtn_cambridge";
            this.rdobtn_cambridge.Size = new System.Drawing.Size(111, 24);
            this.rdobtn_cambridge.TabIndex = 2;
            this.rdobtn_cambridge.TabStop = true;
            this.rdobtn_cambridge.Text = "Cambridge";
            this.rdobtn_cambridge.UseVisualStyleBackColor = true;
            this.rdobtn_cambridge.CheckedChanged += new System.EventHandler(this.rdobtn_cambridge_CheckedChanged);
            // 
            // panel32
            // 
            this.panel32.Controls.Add(this.grpbx_altimeter);
            this.panel32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel32.Location = new System.Drawing.Point(173, 3);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(138, 88);
            this.panel32.TabIndex = 1;
            // 
            // grpbx_altimeter
            // 
            this.grpbx_altimeter.Controls.Add(this.rdobtn_destination);
            this.grpbx_altimeter.Controls.Add(this.rdobtn_present);
            this.grpbx_altimeter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbx_altimeter.Location = new System.Drawing.Point(0, 0);
            this.grpbx_altimeter.Name = "grpbx_altimeter";
            this.grpbx_altimeter.Size = new System.Drawing.Size(138, 88);
            this.grpbx_altimeter.TabIndex = 1;
            this.grpbx_altimeter.TabStop = false;
            // 
            // rdobtn_destination
            // 
            this.rdobtn_destination.AutoSize = true;
            this.rdobtn_destination.Location = new System.Drawing.Point(6, 52);
            this.rdobtn_destination.Name = "rdobtn_destination";
            this.rdobtn_destination.Size = new System.Drawing.Size(115, 24);
            this.rdobtn_destination.TabIndex = 0;
            this.rdobtn_destination.TabStop = true;
            this.rdobtn_destination.Text = "Destination";
            this.rdobtn_destination.UseVisualStyleBackColor = true;
            // 
            // rdobtn_present
            // 
            this.rdobtn_present.AutoSize = true;
            this.rdobtn_present.Checked = true;
            this.rdobtn_present.Location = new System.Drawing.Point(6, 22);
            this.rdobtn_present.Name = "rdobtn_present";
            this.rdobtn_present.Size = new System.Drawing.Size(89, 24);
            this.rdobtn_present.TabIndex = 0;
            this.rdobtn_present.TabStop = true;
            this.rdobtn_present.Text = "Present";
            this.rdobtn_present.UseVisualStyleBackColor = true;
            // 
            // panel33
            // 
            this.panel33.Controls.Add(this.cmbobx_gransden_lodge);
            this.panel33.Controls.Add(this.cmbobx_airport_info);
            this.panel33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel33.Location = new System.Drawing.Point(332, 3);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(329, 88);
            this.panel33.TabIndex = 2;
            // 
            // cmbobx_gransden_lodge
            // 
            this.cmbobx_gransden_lodge.FormattingEnabled = true;
            this.cmbobx_gransden_lodge.Items.AddRange(new object[] {
            "General Weather",
            "Navigation Weather",
            "Radar Weather",
            "South Camera",
            "West Camera"});
            this.cmbobx_gransden_lodge.Location = new System.Drawing.Point(6, 32);
            this.cmbobx_gransden_lodge.Name = "cmbobx_gransden_lodge";
            this.cmbobx_gransden_lodge.Size = new System.Drawing.Size(318, 28);
            this.cmbobx_gransden_lodge.Sorted = true;
            this.cmbobx_gransden_lodge.TabIndex = 1;
            this.cmbobx_gransden_lodge.SelectedIndexChanged += new System.EventHandler(this.cmbobx_gransden_lodge_SelectedIndexChanged);
            // 
            // cmbobx_airport_info
            // 
            this.cmbobx_airport_info.FormattingEnabled = true;
            this.cmbobx_airport_info.Items.AddRange(new object[] {
            " Choose Airport Below",
            "AAC Middle Wallop",
            "Aberdeen Airport",
            "Aberporth Airport",
            "Aintree Heliport",
            "Alderney Airport",
            "Andrewsfield Aerodrome",
            "Anglesey Airport",
            "Anwick",
            "Ascot Racecourse Heliport",
            "Ashcroft",
            "Audley End Airfield",
            "Bagby Airfield",
            "Barra Airport",
            "Barrow/Walney Island Airport",
            "Beccles Airfield",
            "Bedford Aerodrome",
            "Belfast International Airport",
            "Bembridge Airport",
            "Benbecula Airport",
            "Beverley/Linley Hill Airfield",
            "Bicester Airfield",
            "Birmingham Airport",
            "Blackbushe Airport",
            "Blackpool Airport",
            "Bodmin Aerodrome",
            "Bourn Airfield",
            "Bournemouth Airport",
            "Breighton Aerodrome",
            "Brimpton",
            "Bristol Airport",
            "Brooklands",
            "Bruntingthorpe Aerodrome",
            "Caernarfon Airport",
            "Cambridge City Airport",
            "Campbeltown Airport ",
            "Cardiff Airport",
            "Cardiff Heliport",
            "Carlisle Lake District Airport",
            "Chalgrove Airfield",
            "Challock Airfield",
            "Cheltenham Racecourse Heliport",
            "Chester Hawarden Airport",
            "Chichester/Goodwood Airport",
            "City of Derry Airport",
            "Clacton Airport",
            "Colerne",
            "Coll Airport",
            "Colonsay Airport",
            "Compton Abbas Airfield",
            "Cotswold Airport",
            "Cottesmore",
            "Coventry Airport",
            "Cranfield Airport",
            "Crosland Moor Airfield",
            "Crowfield Airfield",
            "Culter Heliport",
            "Cumbernauld Airport",
            "Damyns Hall Aerodrome",
            "Deanland Lewes",
            "Deenethorpe",
            "Denham Aerodrome",
            "Derby Airfield",
            "Doncaster Sheffield Airport",
            "Dundee Airport",
            "Dunkeswell Aerodrome",
            "Dunsfold Aerodrome",
            "Duxford Aerodrome",
            "Eaglescott Airfield",
            "Earls Colne Airfield",
            "East Midlands Airport",
            "Eday Airport",
            "Edinburgh Airport",
            "Elmsett Airfield",
            "Elstree Aerodrome",
            "Elvington Airfield",
            "Enniskillen",
            "Enstone Airfield",
            "Exeter Airport",
            "Fair Isle Airport",
            "Fairoaks Airport",
            "Farnborough Airport",
            "Farthing Corner",
            "Fenland Airfield",
            "Fife Airport",
            "Filton",
            "Fishburn Airfield",
            "Fowlmere Airfield",
            "Full Sutton Airfield",
            "George Best Belfast City Airport",
            "Glasgow Airport",
            "Glasgow City Heliport",
            "Glasgow Prestwick Airport",
            "Gloucestershire Airport",
            "Goodwood Racecourse Heliport",
            "Great Yarmouth",
            "Guernsey Airport",
            "Haverfordwest Airport",
            "Headcorn Aerodrome",
            "Henstridge Airfield",
            "Holyhead Heliport",
            "Humberside Airport",
            "Hunsdon",
            "Inverness Airport",
            "Islay Airport",
            "Isle of Man Airport",
            "Isle of Skye",
            "Isle of Wight/Sandown Airport",
            "Jersey Airport",
            "Kinloss Barracks",
            "Kirkwall Airport",
            "Land\'s End Airport",
            "Langford Lodge",
            "Lasham Airfield",
            "Leconfield",
            "Lee on Solent",
            "Leeds Bradford Airport",
            "Leeds East Airport",
            "Leicester Airport",
            "Leuchars Station",
            "Little Gransden Airfield",
            "Liverpool John Lennon Airport",
            "Llanbedr Airport",
            "London Biggin Hill Airport",
            "London City Airport",
            "London Gatwick Airport",
            "London Heathrow Airport",
            "London Luton",
            "London Oxford Airport",
            "London Southend Airport",
            "London Stansted Airport",
            "London Westland Heliport",
            "Long Marston",
            "Longside",
            "Lydd Airport",
            "Main Hall Farm Airfield",
            "Manchester Airport",
            "Manchester Barton Aerodrome",
            "Manston Airport",
            "Marshland",
            "Maypole",
            "MoD Boscombe Down",
            "Netheravon Airfield",
            "Netherthorpe Airfield",
            "Newcastle International Airport",
            "Newmarket Heath",
            "Newquay Airport / RAF St Mawgan",
            "Newtownards Airport",
            "North Ronaldsay Airport",
            "North Weald Airfield",
            "Norwich Airport",
            "Nottingham Airport",
            "Oaksey Park Airfield",
            "Oban Airport",
            "Old Buckenham Airfield",
            "Old Sarum Airfield",
            "Papa Westray Airport",
            "Pembrey Airport",
            "Penzance Heliport",
            "Perranporth Airfield",
            "Perth Airport",
            "Peterborough Business Airport",
            "Peterborough Sibson",
            "Plymouth",
            "Popham Airfield",
            "Portland Heliport",
            "RAF Barkston Heath",
            "RAF Benson",
            "RAF Brize Norton",
            "RAF Coltishall",
            "RAF Coningsby",
            "RAF Cosford",
            "RAF Cranwell",
            "RAF Dishforth",
            "RAF Fairford",
            "RAF Halton",
            "RAF Henlow",
            "RAF Honington",
            "RAF Lakenheath",
            "RAF Leeming",
            "RAF Linton-on-Ouse",
            "RAF Lossiemouth",
            "RAF Lyneham",
            "RAF Marham",
            "RAF Mildenhall",
            "RAF Northolt",
            "RAF Odiham",
            "RAF Scampton",
            "RAF Shawbury",
            "RAF Ternhill",
            "RAF Topcliffe",
            "RAF Waddington",
            "RAF Wittering",
            "RAF Woodvale",
            "RAF Wyton",
            "Redhill Aerodrome",
            "Retford Gamston Airport",
            "RNAS Culdrose",
            "RNAS Yeovilton",
            "Rochester Airport",
            "Royal Marines Base Chivenor",
            "Sanday Airport",
            "Sandtoft Airfield",
            "Scatsta",
            "Seething Airfield",
            "Sherburn-in-Elmet Airfield",
            "Shipdham Airfield",
            "Shobdon Aerodrome",
            "Shoreham Airport",
            "Shotton Airfield/Peterlee Parachute Centre",
            "Shuttleworth Aerodrome",
            "Silverstone",
            "Skegness",
            "Sleap Airfield",
            "Southampton Airport",
            "St Athan",
            "St Mary\'s Airport",
            "Stapleford Aerodrome",
            "Stornoway Airport",
            "Stronsay Airport",
            "Strubby Airfield",
            "Sturgate Airfield",
            "Sumburgh Airport",
            "Swansea Airport",
            "Sywell Aerodrome",
            "Tatenhill Airfield",
            "Teesside International Airport",
            "Thruxton Aerodrome",
            "Thurrock",
            "Tilstock",
            "Tingwall Airport",
            "Tiree Airport",
            "Tresco Heliport",
            "Truro Aerodrome",
            "Turweston Aerodrome",
            "Unst Airport",
            "Upavon",
            "Warton Aerodrome",
            "Wattisham Airfield",
            "Wellesbourne Mountford Aerodrome",
            "Welshpool Airport",
            "West Freugh",
            "Westray Airport",
            "Whalsay Airstrip",
            "White Waltham Airfield",
            "Wick Airport",
            "Wickenby Aerodrome",
            "Wolverhampton Airport",
            "Wycombe Air Park",
            "Yeovil Aerodrome"});
            this.cmbobx_airport_info.Location = new System.Drawing.Point(6, 32);
            this.cmbobx_airport_info.Name = "cmbobx_airport_info";
            this.cmbobx_airport_info.Size = new System.Drawing.Size(318, 28);
            this.cmbobx_airport_info.Sorted = true;
            this.cmbobx_airport_info.TabIndex = 0;
            this.cmbobx_airport_info.SelectedIndexChanged += new System.EventHandler(this.cmbobx_airport_info_SelectedIndexChanged);
            // 
            // panel34
            // 
            this.panel34.Controls.Add(this.grpbx_browser_navigation);
            this.panel34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel34.Location = new System.Drawing.Point(682, 3);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(674, 88);
            this.panel34.TabIndex = 3;
            // 
            // grpbx_browser_navigation
            // 
            this.grpbx_browser_navigation.Controls.Add(this.tableLayoutPanel8);
            this.grpbx_browser_navigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbx_browser_navigation.Location = new System.Drawing.Point(0, 0);
            this.grpbx_browser_navigation.Name = "grpbx_browser_navigation";
            this.grpbx_browser_navigation.Size = new System.Drawing.Size(674, 88);
            this.grpbx_browser_navigation.TabIndex = 5;
            this.grpbx_browser_navigation.TabStop = false;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel8.Controls.Add(this.panel35, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.panel36, 2, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(668, 63);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // panel35
            // 
            this.panel35.Controls.Add(this.txtbx_navigate_to_url);
            this.panel35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel35.Location = new System.Drawing.Point(3, 3);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(560, 57);
            this.panel35.TabIndex = 0;
            // 
            // txtbx_navigate_to_url
            // 
            this.txtbx_navigate_to_url.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_navigate_to_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_navigate_to_url.Location = new System.Drawing.Point(0, 0);
            this.txtbx_navigate_to_url.Name = "txtbx_navigate_to_url";
            this.txtbx_navigate_to_url.Size = new System.Drawing.Size(560, 26);
            this.txtbx_navigate_to_url.TabIndex = 0;
            this.txtbx_navigate_to_url.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_navigate_to_url_KeyPress);
            // 
            // panel36
            // 
            this.panel36.Controls.Add(this.btn_navigate_to);
            this.panel36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel36.Location = new System.Drawing.Point(571, 3);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(94, 57);
            this.panel36.TabIndex = 1;
            // 
            // btn_navigate_to
            // 
            this.btn_navigate_to.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_navigate_to.Location = new System.Drawing.Point(0, 0);
            this.btn_navigate_to.Name = "btn_navigate_to";
            this.btn_navigate_to.Size = new System.Drawing.Size(94, 57);
            this.btn_navigate_to.TabIndex = 1;
            this.btn_navigate_to.Text = "&Go";
            this.btn_navigate_to.UseVisualStyleBackColor = true;
            this.btn_navigate_to.Click += new System.EventHandler(this.btn_navigate_to_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 8, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 728);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1359, 74);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 68);
            this.panel1.TabIndex = 0;
            // 
            // btn_reset
            // 
            this.btn_reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_reset.Location = new System.Drawing.Point(0, 0);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(211, 68);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_gransden_lodge_photo_update);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(287, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 68);
            this.panel2.TabIndex = 1;
            // 
            // btn_gransden_lodge_photo_update
            // 
            this.btn_gransden_lodge_photo_update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_gransden_lodge_photo_update.Location = new System.Drawing.Point(0, 0);
            this.btn_gransden_lodge_photo_update.Name = "btn_gransden_lodge_photo_update";
            this.btn_gransden_lodge_photo_update.Size = new System.Drawing.Size(211, 68);
            this.btn_gransden_lodge_photo_update.TabIndex = 1;
            this.btn_gransden_lodge_photo_update.Text = "Update Picture";
            this.btn_gransden_lodge_photo_update.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_school);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(571, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 68);
            this.panel3.TabIndex = 2;
            // 
            // btn_school
            // 
            this.btn_school.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_school.Location = new System.Drawing.Point(0, 0);
            this.btn_school.Name = "btn_school";
            this.btn_school.Size = new System.Drawing.Size(211, 68);
            this.btn_school.TabIndex = 2;
            this.btn_school.Text = "Change School to ";
            this.btn_school.UseVisualStyleBackColor = true;
            this.btn_school.Click += new System.EventHandler(this.btn_school_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(855, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(211, 68);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_close);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(1139, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(217, 68);
            this.panel5.TabIndex = 4;
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_close.Location = new System.Drawing.Point(0, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(217, 68);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // tabcnt_toplevel
            // 
            this.tabcnt_toplevel.Controls.Add(this.tab_weather);
            this.tabcnt_toplevel.Controls.Add(this.tab_metar);
            this.tabcnt_toplevel.Controls.Add(this.tab_notams);
            this.tabcnt_toplevel.Controls.Add(this.tab_utils);
            this.tabcnt_toplevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcnt_toplevel.Location = new System.Drawing.Point(3, 103);
            this.tabcnt_toplevel.Name = "tabcnt_toplevel";
            this.tabcnt_toplevel.SelectedIndex = 0;
            this.tabcnt_toplevel.Size = new System.Drawing.Size(1359, 619);
            this.tabcnt_toplevel.TabIndex = 1;
            this.tabcnt_toplevel.SelectedIndexChanged += new System.EventHandler(this.tabcnt_toplevel_SelectedIndexChanged);
            // 
            // tab_weather
            // 
            this.tab_weather.Controls.Add(this.tabcnt_weather);
            this.tab_weather.Location = new System.Drawing.Point(4, 29);
            this.tab_weather.Name = "tab_weather";
            this.tab_weather.Size = new System.Drawing.Size(1351, 586);
            this.tab_weather.TabIndex = 3;
            this.tab_weather.Text = "Weather";
            this.tab_weather.UseVisualStyleBackColor = true;
            // 
            // tabcnt_weather
            // 
            this.tabcnt_weather.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabcnt_weather.Controls.Add(this.tab_met_office);
            this.tabcnt_weather.Controls.Add(this.tab_bbc);
            this.tabcnt_weather.Controls.Add(this.tab_windy);
            this.tabcnt_weather.Controls.Add(this.tab_synoptic);
            this.tabcnt_weather.Controls.Add(this.tab_gransden_lodge);
            this.tabcnt_weather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcnt_weather.Location = new System.Drawing.Point(0, 0);
            this.tabcnt_weather.Multiline = true;
            this.tabcnt_weather.Name = "tabcnt_weather";
            this.tabcnt_weather.SelectedIndex = 0;
            this.tabcnt_weather.Size = new System.Drawing.Size(1351, 586);
            this.tabcnt_weather.TabIndex = 0;
            // 
            // tab_met_office
            // 
            this.tab_met_office.Controls.Add(this.webView_weather_met);
            this.tab_met_office.Location = new System.Drawing.Point(28, 4);
            this.tab_met_office.Name = "tab_met_office";
            this.tab_met_office.Padding = new System.Windows.Forms.Padding(3);
            this.tab_met_office.Size = new System.Drawing.Size(1319, 578);
            this.tab_met_office.TabIndex = 0;
            this.tab_met_office.Text = "Met Office";
            this.tab_met_office.UseVisualStyleBackColor = true;
            // 
            // webView_weather_met
            // 
            this.webView_weather_met.AllowExternalDrop = true;
            this.webView_weather_met.CreationProperties = null;
            this.webView_weather_met.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_weather_met.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_weather_met.Location = new System.Drawing.Point(3, 3);
            this.webView_weather_met.Name = "webView_weather_met";
            this.webView_weather_met.Size = new System.Drawing.Size(1313, 572);
            this.webView_weather_met.TabIndex = 1;
            this.webView_weather_met.ZoomFactor = 1D;
            // 
            // tab_bbc
            // 
            this.tab_bbc.Controls.Add(this.webView_weather_bbc);
            this.tab_bbc.Location = new System.Drawing.Point(28, 4);
            this.tab_bbc.Name = "tab_bbc";
            this.tab_bbc.Padding = new System.Windows.Forms.Padding(3);
            this.tab_bbc.Size = new System.Drawing.Size(1319, 578);
            this.tab_bbc.TabIndex = 1;
            this.tab_bbc.Text = "BBC";
            this.tab_bbc.UseVisualStyleBackColor = true;
            // 
            // webView_weather_bbc
            // 
            this.webView_weather_bbc.AllowExternalDrop = true;
            this.webView_weather_bbc.CreationProperties = null;
            this.webView_weather_bbc.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_weather_bbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_weather_bbc.Location = new System.Drawing.Point(3, 3);
            this.webView_weather_bbc.Name = "webView_weather_bbc";
            this.webView_weather_bbc.Size = new System.Drawing.Size(1313, 572);
            this.webView_weather_bbc.TabIndex = 1;
            this.webView_weather_bbc.ZoomFactor = 1D;
            // 
            // tab_windy
            // 
            this.tab_windy.Controls.Add(this.webView_weather_windy);
            this.tab_windy.Location = new System.Drawing.Point(28, 4);
            this.tab_windy.Name = "tab_windy";
            this.tab_windy.Size = new System.Drawing.Size(1319, 578);
            this.tab_windy.TabIndex = 2;
            this.tab_windy.Text = "Windy";
            this.tab_windy.UseVisualStyleBackColor = true;
            // 
            // webView_weather_windy
            // 
            this.webView_weather_windy.AllowExternalDrop = true;
            this.webView_weather_windy.CreationProperties = null;
            this.webView_weather_windy.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_weather_windy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_weather_windy.Location = new System.Drawing.Point(0, 0);
            this.webView_weather_windy.Name = "webView_weather_windy";
            this.webView_weather_windy.Size = new System.Drawing.Size(1319, 578);
            this.webView_weather_windy.TabIndex = 3;
            this.webView_weather_windy.ZoomFactor = 1D;
            // 
            // tab_synoptic
            // 
            this.tab_synoptic.Controls.Add(this.webView_synoptic);
            this.tab_synoptic.Location = new System.Drawing.Point(28, 4);
            this.tab_synoptic.Name = "tab_synoptic";
            this.tab_synoptic.Size = new System.Drawing.Size(1319, 578);
            this.tab_synoptic.TabIndex = 3;
            this.tab_synoptic.Text = "Synoptic Charts";
            this.tab_synoptic.UseVisualStyleBackColor = true;
            // 
            // webView_synoptic
            // 
            this.webView_synoptic.AllowExternalDrop = true;
            this.webView_synoptic.CreationProperties = null;
            this.webView_synoptic.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_synoptic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_synoptic.Location = new System.Drawing.Point(0, 0);
            this.webView_synoptic.Name = "webView_synoptic";
            this.webView_synoptic.Size = new System.Drawing.Size(1319, 578);
            this.webView_synoptic.TabIndex = 1;
            this.webView_synoptic.ZoomFactor = 1D;
            // 
            // tab_gransden_lodge
            // 
            this.tab_gransden_lodge.Controls.Add(this.webView_gransden_lodge_weather);
            this.tab_gransden_lodge.Location = new System.Drawing.Point(28, 4);
            this.tab_gransden_lodge.Name = "tab_gransden_lodge";
            this.tab_gransden_lodge.Size = new System.Drawing.Size(1319, 578);
            this.tab_gransden_lodge.TabIndex = 4;
            this.tab_gransden_lodge.Text = "Gransden Lodge";
            this.tab_gransden_lodge.UseVisualStyleBackColor = true;
            // 
            // webView_gransden_lodge_weather
            // 
            this.webView_gransden_lodge_weather.AllowExternalDrop = true;
            this.webView_gransden_lodge_weather.CreationProperties = null;
            this.webView_gransden_lodge_weather.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_gransden_lodge_weather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_gransden_lodge_weather.Location = new System.Drawing.Point(0, 0);
            this.webView_gransden_lodge_weather.Name = "webView_gransden_lodge_weather";
            this.webView_gransden_lodge_weather.Size = new System.Drawing.Size(1319, 578);
            this.webView_gransden_lodge_weather.TabIndex = 2;
            this.webView_gransden_lodge_weather.ZoomFactor = 1D;
            // 
            // tab_metar
            // 
            this.tab_metar.Controls.Add(this.tabCnt_airfields);
            this.tab_metar.Location = new System.Drawing.Point(4, 29);
            this.tab_metar.Name = "tab_metar";
            this.tab_metar.Padding = new System.Windows.Forms.Padding(3);
            this.tab_metar.Size = new System.Drawing.Size(1351, 586);
            this.tab_metar.TabIndex = 0;
            this.tab_metar.Text = "Metar";
            this.tab_metar.UseVisualStyleBackColor = true;
            // 
            // tabCnt_airfields
            // 
            this.tabCnt_airfields.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabCnt_airfields.Controls.Add(this.tab_lt_gransden);
            this.tabCnt_airfields.Controls.Add(this.tab_rochester);
            this.tabCnt_airfields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCnt_airfields.Location = new System.Drawing.Point(3, 3);
            this.tabCnt_airfields.Multiline = true;
            this.tabCnt_airfields.Name = "tabCnt_airfields";
            this.tabCnt_airfields.SelectedIndex = 0;
            this.tabCnt_airfields.Size = new System.Drawing.Size(1345, 580);
            this.tabCnt_airfields.TabIndex = 0;
            // 
            // tab_lt_gransden
            // 
            this.tab_lt_gransden.Controls.Add(this.tabcnt_lt_gransden);
            this.tab_lt_gransden.Location = new System.Drawing.Point(28, 4);
            this.tab_lt_gransden.Name = "tab_lt_gransden";
            this.tab_lt_gransden.Padding = new System.Windows.Forms.Padding(3);
            this.tab_lt_gransden.Size = new System.Drawing.Size(1313, 572);
            this.tab_lt_gransden.TabIndex = 0;
            this.tab_lt_gransden.Text = "Little Gransden";
            this.tab_lt_gransden.UseVisualStyleBackColor = true;
            // 
            // tabcnt_lt_gransden
            // 
            this.tabcnt_lt_gransden.Controls.Add(this.tab_m_ltgransden);
            this.tabcnt_lt_gransden.Controls.Add(this.tab_m_luton);
            this.tabcnt_lt_gransden.Controls.Add(this.tab_m_stanstead);
            this.tabcnt_lt_gransden.Controls.Add(this.tab_m_wittering);
            this.tabcnt_lt_gransden.Controls.Add(this.tab_m_mildenhall);
            this.tabcnt_lt_gransden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcnt_lt_gransden.Location = new System.Drawing.Point(3, 3);
            this.tabcnt_lt_gransden.Name = "tabcnt_lt_gransden";
            this.tabcnt_lt_gransden.SelectedIndex = 0;
            this.tabcnt_lt_gransden.Size = new System.Drawing.Size(1307, 566);
            this.tabcnt_lt_gransden.TabIndex = 0;
            // 
            // tab_m_ltgransden
            // 
            this.tab_m_ltgransden.Controls.Add(this.webView_egmj);
            this.tab_m_ltgransden.Location = new System.Drawing.Point(4, 29);
            this.tab_m_ltgransden.Name = "tab_m_ltgransden";
            this.tab_m_ltgransden.Padding = new System.Windows.Forms.Padding(3);
            this.tab_m_ltgransden.Size = new System.Drawing.Size(1299, 533);
            this.tab_m_ltgransden.TabIndex = 0;
            this.tab_m_ltgransden.Text = "Lt Gransden (EGMJ)";
            this.tab_m_ltgransden.UseVisualStyleBackColor = true;
            // 
            // webView_egmj
            // 
            this.webView_egmj.AllowExternalDrop = true;
            this.webView_egmj.CreationProperties = null;
            this.webView_egmj.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_egmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_egmj.Location = new System.Drawing.Point(3, 3);
            this.webView_egmj.Name = "webView_egmj";
            this.webView_egmj.Size = new System.Drawing.Size(1293, 527);
            this.webView_egmj.TabIndex = 1;
            this.webView_egmj.ZoomFactor = 1D;
            // 
            // tab_m_luton
            // 
            this.tab_m_luton.Controls.Add(this.webView_eggw);
            this.tab_m_luton.Location = new System.Drawing.Point(4, 29);
            this.tab_m_luton.Name = "tab_m_luton";
            this.tab_m_luton.Padding = new System.Windows.Forms.Padding(3);
            this.tab_m_luton.Size = new System.Drawing.Size(1299, 533);
            this.tab_m_luton.TabIndex = 1;
            this.tab_m_luton.Text = "Luton (EGGW)";
            this.tab_m_luton.UseVisualStyleBackColor = true;
            // 
            // webView_eggw
            // 
            this.webView_eggw.AllowExternalDrop = true;
            this.webView_eggw.CreationProperties = null;
            this.webView_eggw.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_eggw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_eggw.Location = new System.Drawing.Point(3, 3);
            this.webView_eggw.Name = "webView_eggw";
            this.webView_eggw.Size = new System.Drawing.Size(1293, 527);
            this.webView_eggw.TabIndex = 1;
            this.webView_eggw.ZoomFactor = 1D;
            // 
            // tab_m_stanstead
            // 
            this.tab_m_stanstead.Controls.Add(this.webView_egss);
            this.tab_m_stanstead.Location = new System.Drawing.Point(4, 29);
            this.tab_m_stanstead.Name = "tab_m_stanstead";
            this.tab_m_stanstead.Size = new System.Drawing.Size(1299, 533);
            this.tab_m_stanstead.TabIndex = 2;
            this.tab_m_stanstead.Text = "Stanstead (EGSS)";
            this.tab_m_stanstead.UseVisualStyleBackColor = true;
            // 
            // webView_egss
            // 
            this.webView_egss.AllowExternalDrop = true;
            this.webView_egss.CreationProperties = null;
            this.webView_egss.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_egss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_egss.Location = new System.Drawing.Point(0, 0);
            this.webView_egss.Name = "webView_egss";
            this.webView_egss.Size = new System.Drawing.Size(1299, 533);
            this.webView_egss.TabIndex = 1;
            this.webView_egss.ZoomFactor = 1D;
            // 
            // tab_m_wittering
            // 
            this.tab_m_wittering.Controls.Add(this.webView_egxt);
            this.tab_m_wittering.Location = new System.Drawing.Point(4, 29);
            this.tab_m_wittering.Name = "tab_m_wittering";
            this.tab_m_wittering.Size = new System.Drawing.Size(1299, 533);
            this.tab_m_wittering.TabIndex = 3;
            this.tab_m_wittering.Text = "RAF Wittering (EGXT)";
            this.tab_m_wittering.UseVisualStyleBackColor = true;
            // 
            // webView_egxt
            // 
            this.webView_egxt.AllowExternalDrop = true;
            this.webView_egxt.CreationProperties = null;
            this.webView_egxt.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_egxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_egxt.Location = new System.Drawing.Point(0, 0);
            this.webView_egxt.Name = "webView_egxt";
            this.webView_egxt.Size = new System.Drawing.Size(1299, 533);
            this.webView_egxt.TabIndex = 2;
            this.webView_egxt.ZoomFactor = 1D;
            // 
            // tab_m_mildenhall
            // 
            this.tab_m_mildenhall.Controls.Add(this.webView_egun);
            this.tab_m_mildenhall.Location = new System.Drawing.Point(4, 29);
            this.tab_m_mildenhall.Name = "tab_m_mildenhall";
            this.tab_m_mildenhall.Size = new System.Drawing.Size(1299, 533);
            this.tab_m_mildenhall.TabIndex = 4;
            this.tab_m_mildenhall.Text = "RAF Mildenhall (EGUN)";
            this.tab_m_mildenhall.UseVisualStyleBackColor = true;
            // 
            // webView_egun
            // 
            this.webView_egun.AllowExternalDrop = true;
            this.webView_egun.CreationProperties = null;
            this.webView_egun.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_egun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_egun.Location = new System.Drawing.Point(0, 0);
            this.webView_egun.Name = "webView_egun";
            this.webView_egun.Size = new System.Drawing.Size(1299, 533);
            this.webView_egun.TabIndex = 2;
            this.webView_egun.ZoomFactor = 1D;
            // 
            // tab_rochester
            // 
            this.tab_rochester.Controls.Add(this.tabCnt_rochester);
            this.tab_rochester.Location = new System.Drawing.Point(28, 4);
            this.tab_rochester.Name = "tab_rochester";
            this.tab_rochester.Padding = new System.Windows.Forms.Padding(3);
            this.tab_rochester.Size = new System.Drawing.Size(1313, 572);
            this.tab_rochester.TabIndex = 1;
            this.tab_rochester.Text = "Rochester";
            this.tab_rochester.UseVisualStyleBackColor = true;
            // 
            // tabCnt_rochester
            // 
            this.tabCnt_rochester.Controls.Add(this.tab_m_rochester);
            this.tabCnt_rochester.Controls.Add(this.tab_m_lon_city);
            this.tabCnt_rochester.Controls.Add(this.tab_m_lydd);
            this.tabCnt_rochester.Controls.Add(this.tab_m_gatwick);
            this.tabCnt_rochester.Controls.Add(this.tab_m_stansted);
            this.tabCnt_rochester.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCnt_rochester.Location = new System.Drawing.Point(3, 3);
            this.tabCnt_rochester.Name = "tabCnt_rochester";
            this.tabCnt_rochester.SelectedIndex = 0;
            this.tabCnt_rochester.Size = new System.Drawing.Size(1307, 566);
            this.tabCnt_rochester.TabIndex = 1;
            // 
            // tab_m_rochester
            // 
            this.tab_m_rochester.Controls.Add(this.webView_egto);
            this.tab_m_rochester.Location = new System.Drawing.Point(4, 29);
            this.tab_m_rochester.Name = "tab_m_rochester";
            this.tab_m_rochester.Padding = new System.Windows.Forms.Padding(3);
            this.tab_m_rochester.Size = new System.Drawing.Size(1299, 533);
            this.tab_m_rochester.TabIndex = 0;
            this.tab_m_rochester.Text = "Rochester (EGTO)";
            this.tab_m_rochester.UseVisualStyleBackColor = true;
            // 
            // webView_egto
            // 
            this.webView_egto.AllowExternalDrop = true;
            this.webView_egto.CreationProperties = null;
            this.webView_egto.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_egto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_egto.Location = new System.Drawing.Point(3, 3);
            this.webView_egto.Name = "webView_egto";
            this.webView_egto.Size = new System.Drawing.Size(1293, 527);
            this.webView_egto.TabIndex = 3;
            this.webView_egto.ZoomFactor = 1D;
            // 
            // tab_m_lon_city
            // 
            this.tab_m_lon_city.Controls.Add(this.webView_egcc);
            this.tab_m_lon_city.Location = new System.Drawing.Point(4, 29);
            this.tab_m_lon_city.Name = "tab_m_lon_city";
            this.tab_m_lon_city.Padding = new System.Windows.Forms.Padding(3);
            this.tab_m_lon_city.Size = new System.Drawing.Size(1299, 533);
            this.tab_m_lon_city.TabIndex = 1;
            this.tab_m_lon_city.Text = "London City (EGCC)";
            this.tab_m_lon_city.UseVisualStyleBackColor = true;
            // 
            // webView_egcc
            // 
            this.webView_egcc.AllowExternalDrop = true;
            this.webView_egcc.CreationProperties = null;
            this.webView_egcc.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_egcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_egcc.Location = new System.Drawing.Point(3, 3);
            this.webView_egcc.Name = "webView_egcc";
            this.webView_egcc.Size = new System.Drawing.Size(1293, 527);
            this.webView_egcc.TabIndex = 3;
            this.webView_egcc.ZoomFactor = 1D;
            // 
            // tab_m_lydd
            // 
            this.tab_m_lydd.Controls.Add(this.webView_egmd);
            this.tab_m_lydd.Location = new System.Drawing.Point(4, 29);
            this.tab_m_lydd.Name = "tab_m_lydd";
            this.tab_m_lydd.Size = new System.Drawing.Size(1299, 533);
            this.tab_m_lydd.TabIndex = 2;
            this.tab_m_lydd.Text = "Lydd (EGMD)";
            this.tab_m_lydd.UseVisualStyleBackColor = true;
            // 
            // webView_egmd
            // 
            this.webView_egmd.AllowExternalDrop = true;
            this.webView_egmd.CreationProperties = null;
            this.webView_egmd.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_egmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_egmd.Location = new System.Drawing.Point(0, 0);
            this.webView_egmd.Name = "webView_egmd";
            this.webView_egmd.Size = new System.Drawing.Size(1299, 533);
            this.webView_egmd.TabIndex = 3;
            this.webView_egmd.ZoomFactor = 1D;
            // 
            // tab_m_gatwick
            // 
            this.tab_m_gatwick.Controls.Add(this.webView_egkk);
            this.tab_m_gatwick.Location = new System.Drawing.Point(4, 29);
            this.tab_m_gatwick.Name = "tab_m_gatwick";
            this.tab_m_gatwick.Size = new System.Drawing.Size(1299, 533);
            this.tab_m_gatwick.TabIndex = 3;
            this.tab_m_gatwick.Text = "London Gatwick (EGKK)";
            this.tab_m_gatwick.UseVisualStyleBackColor = true;
            // 
            // webView_egkk
            // 
            this.webView_egkk.AllowExternalDrop = true;
            this.webView_egkk.CreationProperties = null;
            this.webView_egkk.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_egkk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_egkk.Location = new System.Drawing.Point(0, 0);
            this.webView_egkk.Name = "webView_egkk";
            this.webView_egkk.Size = new System.Drawing.Size(1299, 533);
            this.webView_egkk.TabIndex = 3;
            this.webView_egkk.ZoomFactor = 1D;
            // 
            // tab_m_stansted
            // 
            this.tab_m_stansted.Controls.Add(this.webView_egss2);
            this.tab_m_stansted.Location = new System.Drawing.Point(4, 29);
            this.tab_m_stansted.Name = "tab_m_stansted";
            this.tab_m_stansted.Size = new System.Drawing.Size(1299, 533);
            this.tab_m_stansted.TabIndex = 4;
            this.tab_m_stansted.Text = "London Stansted (EGSS)";
            this.tab_m_stansted.UseVisualStyleBackColor = true;
            // 
            // webView_egss2
            // 
            this.webView_egss2.AllowExternalDrop = true;
            this.webView_egss2.CreationProperties = null;
            this.webView_egss2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_egss2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_egss2.Location = new System.Drawing.Point(0, 0);
            this.webView_egss2.Name = "webView_egss2";
            this.webView_egss2.Size = new System.Drawing.Size(1299, 533);
            this.webView_egss2.TabIndex = 3;
            this.webView_egss2.ZoomFactor = 1D;
            // 
            // tab_notams
            // 
            this.tab_notams.Controls.Add(this.webView_notams);
            this.tab_notams.Location = new System.Drawing.Point(4, 29);
            this.tab_notams.Name = "tab_notams";
            this.tab_notams.Padding = new System.Windows.Forms.Padding(3);
            this.tab_notams.Size = new System.Drawing.Size(1351, 586);
            this.tab_notams.TabIndex = 1;
            this.tab_notams.Text = "Notams";
            this.tab_notams.UseVisualStyleBackColor = true;
            // 
            // webView_notams
            // 
            this.webView_notams.AllowExternalDrop = true;
            this.webView_notams.CreationProperties = null;
            this.webView_notams.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_notams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_notams.Location = new System.Drawing.Point(3, 3);
            this.webView_notams.Name = "webView_notams";
            this.webView_notams.Size = new System.Drawing.Size(1345, 580);
            this.webView_notams.TabIndex = 1;
            this.webView_notams.ZoomFactor = 1D;
            // 
            // tab_utils
            // 
            this.tab_utils.Controls.Add(this.tabcnt_utils);
            this.tab_utils.Location = new System.Drawing.Point(4, 29);
            this.tab_utils.Name = "tab_utils";
            this.tab_utils.Size = new System.Drawing.Size(1351, 586);
            this.tab_utils.TabIndex = 2;
            this.tab_utils.Text = "Utilities";
            this.tab_utils.UseVisualStyleBackColor = true;
            // 
            // tabcnt_utils
            // 
            this.tabcnt_utils.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabcnt_utils.Controls.Add(this.tab_browser);
            this.tabcnt_utils.Controls.Add(this.tab_altimeter);
            this.tabcnt_utils.Controls.Add(this.tab_crosswind);
            this.tabcnt_utils.Controls.Add(this.tab_CofG);
            this.tabcnt_utils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcnt_utils.Location = new System.Drawing.Point(0, 0);
            this.tabcnt_utils.Multiline = true;
            this.tabcnt_utils.Name = "tabcnt_utils";
            this.tabcnt_utils.SelectedIndex = 0;
            this.tabcnt_utils.Size = new System.Drawing.Size(1351, 586);
            this.tabcnt_utils.TabIndex = 0;
            this.tabcnt_utils.SelectedIndexChanged += new System.EventHandler(this.tabcnt_utils_SelectedIndexChanged);
            // 
            // tab_browser
            // 
            this.tab_browser.Controls.Add(this.webView_browser);
            this.tab_browser.Location = new System.Drawing.Point(28, 4);
            this.tab_browser.Name = "tab_browser";
            this.tab_browser.Padding = new System.Windows.Forms.Padding(3);
            this.tab_browser.Size = new System.Drawing.Size(1319, 578);
            this.tab_browser.TabIndex = 0;
            this.tab_browser.Text = "Browser";
            this.tab_browser.UseVisualStyleBackColor = true;
            // 
            // webView_browser
            // 
            this.webView_browser.AllowExternalDrop = true;
            this.webView_browser.CreationProperties = null;
            this.webView_browser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_browser.Location = new System.Drawing.Point(3, 3);
            this.webView_browser.Name = "webView_browser";
            this.webView_browser.Size = new System.Drawing.Size(1313, 572);
            this.webView_browser.TabIndex = 1;
            this.webView_browser.ZoomFactor = 1D;
            // 
            // tab_altimeter
            // 
            this.tab_altimeter.Controls.Add(this.tableLayoutPanel3);
            this.tab_altimeter.Location = new System.Drawing.Point(28, 4);
            this.tab_altimeter.Name = "tab_altimeter";
            this.tab_altimeter.Padding = new System.Windows.Forms.Padding(3);
            this.tab_altimeter.Size = new System.Drawing.Size(1319, 578);
            this.tab_altimeter.TabIndex = 1;
            this.tab_altimeter.Text = "Altimeter";
            this.tab_altimeter.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.panel6, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.panel7, 5, 3);
            this.tableLayoutPanel3.Controls.Add(this.panel8, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel9, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel10, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel19, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.panel20, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel23, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel24, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel25, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1313, 572);
            this.tableLayoutPanel3.TabIndex = 27;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(527, 455);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(256, 74);
            this.panel6.TabIndex = 25;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_calculate_altimiter);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(920, 455);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(256, 74);
            this.panel7.TabIndex = 26;
            // 
            // btn_calculate_altimiter
            // 
            this.btn_calculate_altimiter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_calculate_altimiter.Location = new System.Drawing.Point(0, 0);
            this.btn_calculate_altimiter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_calculate_altimiter.Name = "btn_calculate_altimiter";
            this.btn_calculate_altimiter.Size = new System.Drawing.Size(256, 74);
            this.btn_calculate_altimiter.TabIndex = 22;
            this.btn_calculate_altimiter.Text = "Calculate";
            this.btn_calculate_altimiter.UseVisualStyleBackColor = true;
            this.btn_calculate_altimiter.Click += new System.EventHandler(this.btn_calculate_altimiter_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.grpbx_to);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(920, 43);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(256, 366);
            this.panel8.TabIndex = 27;
            // 
            // grpbx_to
            // 
            this.grpbx_to.BackColor = System.Drawing.Color.Transparent;
            this.grpbx_to.Controls.Add(this.tableLayoutPanel5);
            this.grpbx_to.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbx_to.Location = new System.Drawing.Point(0, 0);
            this.grpbx_to.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_to.Name = "grpbx_to";
            this.grpbx_to.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_to.Size = new System.Drawing.Size(256, 366);
            this.grpbx_to.TabIndex = 21;
            this.grpbx_to.TabStop = false;
            this.grpbx_to.Text = "Destination QFE";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label4, 2, 3);
            this.tableLayoutPanel5.Controls.Add(this.panel21, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtbx_to_altitude, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.panel22, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.lbl_to_pressure, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.panel18, 0, 5);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 24);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(248, 337);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(202, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 30);
            this.label4.TabIndex = 18;
            this.label4.Text = "mb";
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.label3);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel21.Location = new System.Drawing.Point(201, 13);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(44, 24);
            this.panel21.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "ft";
            // 
            // txtbx_to_altitude
            // 
            this.txtbx_to_altitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_to_altitude.Location = new System.Drawing.Point(4, 15);
            this.txtbx_to_altitude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_to_altitude.Name = "txtbx_to_altitude";
            this.txtbx_to_altitude.Size = new System.Drawing.Size(180, 26);
            this.txtbx_to_altitude.TabIndex = 19;
            // 
            // panel22
            // 
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(201, 43);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(44, 4);
            this.panel22.TabIndex = 3;
            // 
            // lbl_to_pressure
            // 
            this.lbl_to_pressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_to_pressure.Location = new System.Drawing.Point(4, 50);
            this.lbl_to_pressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_to_pressure.Name = "lbl_to_pressure";
            this.lbl_to_pressure.Size = new System.Drawing.Size(180, 30);
            this.lbl_to_pressure.TabIndex = 23;
            this.lbl_to_pressure.Text = "....";
            // 
            // panel18
            // 
            this.panel18.AutoScroll = true;
            this.tableLayoutPanel5.SetColumnSpan(this.panel18, 3);
            this.panel18.Controls.Add(this.lbl_d_elevation_m);
            this.panel18.Controls.Add(this.lbl_d_longitude_dec);
            this.panel18.Controls.Add(this.lbl_d_longitude_deg);
            this.panel18.Controls.Add(this.lbl_d_latitude_dec);
            this.panel18.Controls.Add(this.lbl_d_latitude_deg);
            this.panel18.Controls.Add(this.lbl_d_icao_code);
            this.panel18.Controls.Add(this.lbl_d_airport_name);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(3, 93);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(242, 241);
            this.panel18.TabIndex = 24;
            // 
            // lbl_d_elevation_m
            // 
            this.lbl_d_elevation_m.AutoSize = true;
            this.lbl_d_elevation_m.Location = new System.Drawing.Point(3, 187);
            this.lbl_d_elevation_m.Name = "lbl_d_elevation_m";
            this.lbl_d_elevation_m.Size = new System.Drawing.Size(17, 20);
            this.lbl_d_elevation_m.TabIndex = 13;
            this.lbl_d_elevation_m.Text = "..";
            // 
            // lbl_d_longitude_dec
            // 
            this.lbl_d_longitude_dec.AutoSize = true;
            this.lbl_d_longitude_dec.Location = new System.Drawing.Point(3, 148);
            this.lbl_d_longitude_dec.Name = "lbl_d_longitude_dec";
            this.lbl_d_longitude_dec.Size = new System.Drawing.Size(17, 20);
            this.lbl_d_longitude_dec.TabIndex = 12;
            this.lbl_d_longitude_dec.Text = "..";
            // 
            // lbl_d_longitude_deg
            // 
            this.lbl_d_longitude_deg.AutoSize = true;
            this.lbl_d_longitude_deg.Location = new System.Drawing.Point(3, 128);
            this.lbl_d_longitude_deg.Name = "lbl_d_longitude_deg";
            this.lbl_d_longitude_deg.Size = new System.Drawing.Size(17, 20);
            this.lbl_d_longitude_deg.TabIndex = 11;
            this.lbl_d_longitude_deg.Text = "..";
            // 
            // lbl_d_latitude_dec
            // 
            this.lbl_d_latitude_dec.AutoSize = true;
            this.lbl_d_latitude_dec.Location = new System.Drawing.Point(3, 92);
            this.lbl_d_latitude_dec.Name = "lbl_d_latitude_dec";
            this.lbl_d_latitude_dec.Size = new System.Drawing.Size(17, 20);
            this.lbl_d_latitude_dec.TabIndex = 10;
            this.lbl_d_latitude_dec.Text = "..";
            // 
            // lbl_d_latitude_deg
            // 
            this.lbl_d_latitude_deg.AutoSize = true;
            this.lbl_d_latitude_deg.Location = new System.Drawing.Point(3, 72);
            this.lbl_d_latitude_deg.Name = "lbl_d_latitude_deg";
            this.lbl_d_latitude_deg.Size = new System.Drawing.Size(17, 20);
            this.lbl_d_latitude_deg.TabIndex = 9;
            this.lbl_d_latitude_deg.Text = "..";
            // 
            // lbl_d_icao_code
            // 
            this.lbl_d_icao_code.AutoSize = true;
            this.lbl_d_icao_code.Location = new System.Drawing.Point(3, 35);
            this.lbl_d_icao_code.Name = "lbl_d_icao_code";
            this.lbl_d_icao_code.Size = new System.Drawing.Size(17, 20);
            this.lbl_d_icao_code.TabIndex = 8;
            this.lbl_d_icao_code.Text = "..";
            // 
            // lbl_d_airport_name
            // 
            this.lbl_d_airport_name.AutoSize = true;
            this.lbl_d_airport_name.Location = new System.Drawing.Point(3, 15);
            this.lbl_d_airport_name.Name = "lbl_d_airport_name";
            this.lbl_d_airport_name.Size = new System.Drawing.Size(17, 20);
            this.lbl_d_airport_name.TabIndex = 7;
            this.lbl_d_airport_name.Text = "..";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.grpbx_present);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(527, 43);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(256, 366);
            this.panel9.TabIndex = 28;
            // 
            // grpbx_present
            // 
            this.grpbx_present.BackColor = System.Drawing.Color.Transparent;
            this.grpbx_present.Controls.Add(this.tableLayoutPanel4);
            this.grpbx_present.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbx_present.Location = new System.Drawing.Point(0, 0);
            this.grpbx_present.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_present.Name = "grpbx_present";
            this.grpbx_present.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_present.Size = new System.Drawing.Size(256, 366);
            this.grpbx_present.TabIndex = 20;
            this.grpbx_present.TabStop = false;
            this.grpbx_present.Text = "Present QFE";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel15, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel17, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel30, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.panel37, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.panel16, 0, 5);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 24);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(248, 337);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txtbx_present_altitude);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(3, 13);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(182, 24);
            this.panel15.TabIndex = 0;
            // 
            // txtbx_present_altitude
            // 
            this.txtbx_present_altitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_present_altitude.Location = new System.Drawing.Point(0, 0);
            this.txtbx_present_altitude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_present_altitude.Name = "txtbx_present_altitude";
            this.txtbx_present_altitude.Size = new System.Drawing.Size(182, 26);
            this.txtbx_present_altitude.TabIndex = 15;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.label5);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(201, 13);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(44, 24);
            this.panel17.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "ft";
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.txtbx_present_pressure);
            this.panel30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel30.Location = new System.Drawing.Point(3, 53);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(182, 24);
            this.panel30.TabIndex = 4;
            // 
            // txtbx_present_pressure
            // 
            this.txtbx_present_pressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_present_pressure.Location = new System.Drawing.Point(0, 0);
            this.txtbx_present_pressure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_present_pressure.Name = "txtbx_present_pressure";
            this.txtbx_present_pressure.Size = new System.Drawing.Size(182, 26);
            this.txtbx_present_pressure.TabIndex = 16;
            // 
            // panel37
            // 
            this.panel37.Controls.Add(this.label6);
            this.panel37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel37.Location = new System.Drawing.Point(201, 53);
            this.panel37.Name = "panel37";
            this.panel37.Size = new System.Drawing.Size(44, 24);
            this.panel37.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "mb";
            // 
            // panel16
            // 
            this.panel16.AutoScroll = true;
            this.tableLayoutPanel4.SetColumnSpan(this.panel16, 3);
            this.panel16.Controls.Add(this.lbl_p_elevation_m);
            this.panel16.Controls.Add(this.lbl_p_longitude_dec);
            this.panel16.Controls.Add(this.lbl_p_longitude_deg);
            this.panel16.Controls.Add(this.lbl_p_latitude_dec);
            this.panel16.Controls.Add(this.lbl_p_latitude_deg);
            this.panel16.Controls.Add(this.lbl_p_icao_code);
            this.panel16.Controls.Add(this.lbl_p_airport_name);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(3, 93);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(242, 241);
            this.panel16.TabIndex = 6;
            // 
            // lbl_p_elevation_m
            // 
            this.lbl_p_elevation_m.AutoSize = true;
            this.lbl_p_elevation_m.Location = new System.Drawing.Point(3, 187);
            this.lbl_p_elevation_m.Name = "lbl_p_elevation_m";
            this.lbl_p_elevation_m.Size = new System.Drawing.Size(17, 20);
            this.lbl_p_elevation_m.TabIndex = 6;
            this.lbl_p_elevation_m.Text = "..";
            // 
            // lbl_p_longitude_dec
            // 
            this.lbl_p_longitude_dec.AutoSize = true;
            this.lbl_p_longitude_dec.Location = new System.Drawing.Point(3, 148);
            this.lbl_p_longitude_dec.Name = "lbl_p_longitude_dec";
            this.lbl_p_longitude_dec.Size = new System.Drawing.Size(17, 20);
            this.lbl_p_longitude_dec.TabIndex = 5;
            this.lbl_p_longitude_dec.Text = "..";
            // 
            // lbl_p_longitude_deg
            // 
            this.lbl_p_longitude_deg.AutoSize = true;
            this.lbl_p_longitude_deg.Location = new System.Drawing.Point(3, 128);
            this.lbl_p_longitude_deg.Name = "lbl_p_longitude_deg";
            this.lbl_p_longitude_deg.Size = new System.Drawing.Size(17, 20);
            this.lbl_p_longitude_deg.TabIndex = 4;
            this.lbl_p_longitude_deg.Text = "..";
            // 
            // lbl_p_latitude_dec
            // 
            this.lbl_p_latitude_dec.AutoSize = true;
            this.lbl_p_latitude_dec.Location = new System.Drawing.Point(3, 92);
            this.lbl_p_latitude_dec.Name = "lbl_p_latitude_dec";
            this.lbl_p_latitude_dec.Size = new System.Drawing.Size(17, 20);
            this.lbl_p_latitude_dec.TabIndex = 3;
            this.lbl_p_latitude_dec.Text = "..";
            // 
            // lbl_p_latitude_deg
            // 
            this.lbl_p_latitude_deg.AutoSize = true;
            this.lbl_p_latitude_deg.Location = new System.Drawing.Point(3, 72);
            this.lbl_p_latitude_deg.Name = "lbl_p_latitude_deg";
            this.lbl_p_latitude_deg.Size = new System.Drawing.Size(17, 20);
            this.lbl_p_latitude_deg.TabIndex = 2;
            this.lbl_p_latitude_deg.Text = "..";
            // 
            // lbl_p_icao_code
            // 
            this.lbl_p_icao_code.AutoSize = true;
            this.lbl_p_icao_code.Location = new System.Drawing.Point(3, 35);
            this.lbl_p_icao_code.Name = "lbl_p_icao_code";
            this.lbl_p_icao_code.Size = new System.Drawing.Size(17, 20);
            this.lbl_p_icao_code.TabIndex = 1;
            this.lbl_p_icao_code.Text = "..";
            // 
            // lbl_p_airport_name
            // 
            this.lbl_p_airport_name.AutoSize = true;
            this.lbl_p_airport_name.Location = new System.Drawing.Point(3, 15);
            this.lbl_p_airport_name.Name = "lbl_p_airport_name";
            this.lbl_p_airport_name.Size = new System.Drawing.Size(17, 20);
            this.lbl_p_airport_name.TabIndex = 0;
            this.lbl_p_airport_name.Text = "..";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.grpbx_QNH);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(134, 43);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(256, 366);
            this.panel10.TabIndex = 29;
            // 
            // grpbx_QNH
            // 
            this.grpbx_QNH.BackColor = System.Drawing.Color.Transparent;
            this.grpbx_QNH.Controls.Add(this.tableLayoutPanel6);
            this.grpbx_QNH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbx_QNH.Location = new System.Drawing.Point(0, 0);
            this.grpbx_QNH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_QNH.Name = "grpbx_QNH";
            this.grpbx_QNH.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_QNH.Size = new System.Drawing.Size(256, 366);
            this.grpbx_QNH.TabIndex = 24;
            this.grpbx_QNH.TabStop = false;
            this.grpbx_QNH.Text = "QNH";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel6.Controls.Add(this.panel11, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.panel12, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.panel13, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.panel14, 2, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 24);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(248, 337);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.lbl_sea_level_ft);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(3, 23);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(182, 44);
            this.panel11.TabIndex = 0;
            // 
            // lbl_sea_level_ft
            // 
            this.lbl_sea_level_ft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_sea_level_ft.Location = new System.Drawing.Point(0, 0);
            this.lbl_sea_level_ft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sea_level_ft.Name = "lbl_sea_level_ft";
            this.lbl_sea_level_ft.Size = new System.Drawing.Size(182, 44);
            this.lbl_sea_level_ft.TabIndex = 25;
            this.lbl_sea_level_ft.Text = "0";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.lbl_qnh_pressure);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(3, 73);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(182, 44);
            this.panel12.TabIndex = 1;
            // 
            // lbl_qnh_pressure
            // 
            this.lbl_qnh_pressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_qnh_pressure.Location = new System.Drawing.Point(0, 0);
            this.lbl_qnh_pressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_qnh_pressure.Name = "lbl_qnh_pressure";
            this.lbl_qnh_pressure.Size = new System.Drawing.Size(182, 44);
            this.lbl_qnh_pressure.TabIndex = 24;
            this.lbl_qnh_pressure.Text = "....";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label2);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(201, 23);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(44, 44);
            this.panel13.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 44);
            this.label2.TabIndex = 17;
            this.label2.Text = "ft";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label1);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(201, 73);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(44, 44);
            this.panel14.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 44);
            this.label1.TabIndex = 18;
            this.label1.Text = "mb";
            // 
            // panel19
            // 
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(134, 455);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(256, 74);
            this.panel19.TabIndex = 30;
            // 
            // panel20
            // 
            this.panel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel20.Location = new System.Drawing.Point(527, 3);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(256, 34);
            this.panel20.TabIndex = 31;
            // 
            // panel23
            // 
            this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel23.Location = new System.Drawing.Point(920, 3);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(256, 34);
            this.panel23.TabIndex = 32;
            // 
            // panel24
            // 
            this.panel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel24.Location = new System.Drawing.Point(134, 3);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(256, 34);
            this.panel24.TabIndex = 33;
            // 
            // panel25
            // 
            this.panel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel25.Location = new System.Drawing.Point(396, 3);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(125, 34);
            this.panel25.TabIndex = 34;
            // 
            // tab_crosswind
            // 
            this.tab_crosswind.Controls.Add(this.label12);
            this.tab_crosswind.Controls.Add(this.btn_calc_wind);
            this.tab_crosswind.Controls.Add(this.lbl_runway_heading2);
            this.tab_crosswind.Controls.Add(this.lbl_headwind_2);
            this.tab_crosswind.Controls.Add(this.lbl_crosswind_2);
            this.tab_crosswind.Controls.Add(this.lbl_runway_heading1);
            this.tab_crosswind.Controls.Add(this.lbl_headwind_1);
            this.tab_crosswind.Controls.Add(this.lbl_crosswind_1);
            this.tab_crosswind.Controls.Add(this.label11);
            this.tab_crosswind.Controls.Add(this.txtbx_runway_heading);
            this.tab_crosswind.Controls.Add(this.label10);
            this.tab_crosswind.Controls.Add(this.label9);
            this.tab_crosswind.Controls.Add(this.label8);
            this.tab_crosswind.Controls.Add(this.label7);
            this.tab_crosswind.Controls.Add(this.txtbx_direction);
            this.tab_crosswind.Controls.Add(this.txtbx_magnitude);
            this.tab_crosswind.Location = new System.Drawing.Point(28, 4);
            this.tab_crosswind.Name = "tab_crosswind";
            this.tab_crosswind.Size = new System.Drawing.Size(1319, 578);
            this.tab_crosswind.TabIndex = 2;
            this.tab_crosswind.Text = "Crosswind";
            this.tab_crosswind.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(396, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "°";
            // 
            // btn_calc_wind
            // 
            this.btn_calc_wind.Location = new System.Drawing.Point(234, 341);
            this.btn_calc_wind.Name = "btn_calc_wind";
            this.btn_calc_wind.Size = new System.Drawing.Size(166, 68);
            this.btn_calc_wind.TabIndex = 14;
            this.btn_calc_wind.Text = "Calculate Wind";
            this.btn_calc_wind.UseVisualStyleBackColor = true;
            this.btn_calc_wind.Click += new System.EventHandler(this.btn_calc_wind_Click);
            // 
            // lbl_runway_heading2
            // 
            this.lbl_runway_heading2.AutoSize = true;
            this.lbl_runway_heading2.Location = new System.Drawing.Point(406, 204);
            this.lbl_runway_heading2.Name = "lbl_runway_heading2";
            this.lbl_runway_heading2.Size = new System.Drawing.Size(60, 20);
            this.lbl_runway_heading2.TabIndex = 13;
            this.lbl_runway_heading2.Text = "label12";
            // 
            // lbl_headwind_2
            // 
            this.lbl_headwind_2.AutoSize = true;
            this.lbl_headwind_2.Location = new System.Drawing.Point(408, 263);
            this.lbl_headwind_2.Name = "lbl_headwind_2";
            this.lbl_headwind_2.Size = new System.Drawing.Size(60, 20);
            this.lbl_headwind_2.TabIndex = 12;
            this.lbl_headwind_2.Text = "label12";
            // 
            // lbl_crosswind_2
            // 
            this.lbl_crosswind_2.AutoSize = true;
            this.lbl_crosswind_2.Location = new System.Drawing.Point(408, 234);
            this.lbl_crosswind_2.Name = "lbl_crosswind_2";
            this.lbl_crosswind_2.Size = new System.Drawing.Size(60, 20);
            this.lbl_crosswind_2.TabIndex = 11;
            this.lbl_crosswind_2.Text = "label12";
            // 
            // lbl_runway_heading1
            // 
            this.lbl_runway_heading1.AutoSize = true;
            this.lbl_runway_heading1.Location = new System.Drawing.Point(105, 204);
            this.lbl_runway_heading1.Name = "lbl_runway_heading1";
            this.lbl_runway_heading1.Size = new System.Drawing.Size(60, 20);
            this.lbl_runway_heading1.TabIndex = 10;
            this.lbl_runway_heading1.Text = "label12";
            // 
            // lbl_headwind_1
            // 
            this.lbl_headwind_1.AutoSize = true;
            this.lbl_headwind_1.Location = new System.Drawing.Point(107, 263);
            this.lbl_headwind_1.Name = "lbl_headwind_1";
            this.lbl_headwind_1.Size = new System.Drawing.Size(60, 20);
            this.lbl_headwind_1.TabIndex = 9;
            this.lbl_headwind_1.Text = "label12";
            // 
            // lbl_crosswind_1
            // 
            this.lbl_crosswind_1.AutoSize = true;
            this.lbl_crosswind_1.Location = new System.Drawing.Point(107, 234);
            this.lbl_crosswind_1.Name = "lbl_crosswind_1";
            this.lbl_crosswind_1.Size = new System.Drawing.Size(60, 20);
            this.lbl_crosswind_1.TabIndex = 8;
            this.lbl_crosswind_1.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Runway Heading";
            // 
            // txtbx_runway_heading
            // 
            this.txtbx_runway_heading.Location = new System.Drawing.Point(255, 96);
            this.txtbx_runway_heading.Name = "txtbx_runway_heading";
            this.txtbx_runway_heading.Size = new System.Drawing.Size(135, 26);
            this.txtbx_runway_heading.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(396, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "°";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "kts";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Direction";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Windspeed";
            // 
            // txtbx_direction
            // 
            this.txtbx_direction.Location = new System.Drawing.Point(255, 64);
            this.txtbx_direction.Name = "txtbx_direction";
            this.txtbx_direction.Size = new System.Drawing.Size(135, 26);
            this.txtbx_direction.TabIndex = 1;
            // 
            // txtbx_magnitude
            // 
            this.txtbx_magnitude.Location = new System.Drawing.Point(255, 32);
            this.txtbx_magnitude.Name = "txtbx_magnitude";
            this.txtbx_magnitude.Size = new System.Drawing.Size(135, 26);
            this.txtbx_magnitude.TabIndex = 0;
            // 
            // tab_CofG
            // 
            this.tab_CofG.Controls.Add(this.btn_cog_print_report);
            this.tab_CofG.Controls.Add(this.btn_cog_reset);
            this.tab_CofG.Controls.Add(this.rchtxtbx_cog_report);
            this.tab_CofG.Controls.Add(this.groupBox4);
            this.tab_CofG.Controls.Add(this.chrt_cog);
            this.tab_CofG.Controls.Add(this.groupBox3);
            this.tab_CofG.Controls.Add(this.groupBox2);
            this.tab_CofG.Controls.Add(this.btn_calc_cog);
            this.tab_CofG.Location = new System.Drawing.Point(28, 4);
            this.tab_CofG.Name = "tab_CofG";
            this.tab_CofG.Padding = new System.Windows.Forms.Padding(3);
            this.tab_CofG.Size = new System.Drawing.Size(1319, 578);
            this.tab_CofG.TabIndex = 3;
            this.tab_CofG.Text = "CofG";
            this.tab_CofG.UseVisualStyleBackColor = true;
            // 
            // btn_cog_reset
            // 
            this.btn_cog_reset.Location = new System.Drawing.Point(1165, 229);
            this.btn_cog_reset.Name = "btn_cog_reset";
            this.btn_cog_reset.Size = new System.Drawing.Size(121, 45);
            this.btn_cog_reset.TabIndex = 46;
            this.btn_cog_reset.Text = "Reset";
            this.btn_cog_reset.UseVisualStyleBackColor = true;
            this.btn_cog_reset.Click += new System.EventHandler(this.btn_cog_reset_Click);
            // 
            // rchtxtbx_cog_report
            // 
            this.rchtxtbx_cog_report.Location = new System.Drawing.Point(734, 212);
            this.rchtxtbx_cog_report.Name = "rchtxtbx_cog_report";
            this.rchtxtbx_cog_report.Size = new System.Drawing.Size(420, 218);
            this.rchtxtbx_cog_report.TabIndex = 45;
            this.rchtxtbx_cog_report.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtbx_cog_accessories_weight);
            this.groupBox4.Controls.Add(this.lbl_cog_accessories);
            this.groupBox4.Controls.Add(this.txtbx_cog_accessories_arm);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.lbl_fuel_weight);
            this.groupBox4.Controls.Add(this.lbl_cog_total_moment);
            this.groupBox4.Controls.Add(this.lbl_cog_total_weight);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.txtbx_cog_hold_bag_weight);
            this.groupBox4.Controls.Add(this.txtbx_cog_cabin_bag_weight);
            this.groupBox4.Controls.Add(this.txtbx_cog_passenger_weight);
            this.groupBox4.Controls.Add(this.txtbx_cog_pilot_weight);
            this.groupBox4.Controls.Add(this.lbl_cog_fuel);
            this.groupBox4.Controls.Add(this.lbl_cog_hold_baggage);
            this.groupBox4.Controls.Add(this.lbl_cog_cabin_baggage);
            this.groupBox4.Controls.Add(this.lbl_cog_passenger);
            this.groupBox4.Controls.Add(this.lbl_cog_pilot);
            this.groupBox4.Controls.Add(this.txtbx_cog_fuel_arm);
            this.groupBox4.Controls.Add(this.txtbx_cog_hold_bag_arm);
            this.groupBox4.Controls.Add(this.txtbx_cog_cabin_bag_arm);
            this.groupBox4.Controls.Add(this.txtbx_cog_passenger_arm);
            this.groupBox4.Controls.Add(this.txtbx_cog_pilot_arm);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(29, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(678, 409);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            // 
            // lbl_fuel_weight
            // 
            this.lbl_fuel_weight.AutoSize = true;
            this.lbl_fuel_weight.Location = new System.Drawing.Point(179, 306);
            this.lbl_fuel_weight.Name = "lbl_fuel_weight";
            this.lbl_fuel_weight.Size = new System.Drawing.Size(18, 20);
            this.lbl_fuel_weight.TabIndex = 35;
            this.lbl_fuel_weight.Text = "0";
            // 
            // lbl_cog_total_moment
            // 
            this.lbl_cog_total_moment.AutoSize = true;
            this.lbl_cog_total_moment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cog_total_moment.Location = new System.Drawing.Point(492, 379);
            this.lbl_cog_total_moment.Name = "lbl_cog_total_moment";
            this.lbl_cog_total_moment.Size = new System.Drawing.Size(19, 20);
            this.lbl_cog_total_moment.TabIndex = 27;
            this.lbl_cog_total_moment.Text = "0";
            // 
            // lbl_cog_total_weight
            // 
            this.lbl_cog_total_weight.AutoSize = true;
            this.lbl_cog_total_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cog_total_weight.Location = new System.Drawing.Point(179, 379);
            this.lbl_cog_total_weight.Name = "lbl_cog_total_weight";
            this.lbl_cog_total_weight.Size = new System.Drawing.Size(19, 20);
            this.lbl_cog_total_weight.TabIndex = 26;
            this.lbl_cog_total_weight.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(20, 379);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(49, 20);
            this.label27.TabIndex = 25;
            this.label27.Text = "Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(25, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 8);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // txtbx_cog_hold_bag_weight
            // 
            this.txtbx_cog_hold_bag_weight.Location = new System.Drawing.Point(177, 205);
            this.txtbx_cog_hold_bag_weight.Name = "txtbx_cog_hold_bag_weight";
            this.txtbx_cog_hold_bag_weight.Size = new System.Drawing.Size(100, 26);
            this.txtbx_cog_hold_bag_weight.TabIndex = 22;
            this.txtbx_cog_hold_bag_weight.Text = "0";
            // 
            // txtbx_cog_cabin_bag_weight
            // 
            this.txtbx_cog_cabin_bag_weight.Location = new System.Drawing.Point(177, 154);
            this.txtbx_cog_cabin_bag_weight.Name = "txtbx_cog_cabin_bag_weight";
            this.txtbx_cog_cabin_bag_weight.Size = new System.Drawing.Size(100, 26);
            this.txtbx_cog_cabin_bag_weight.TabIndex = 21;
            this.txtbx_cog_cabin_bag_weight.Text = "0";
            // 
            // txtbx_cog_passenger_weight
            // 
            this.txtbx_cog_passenger_weight.Location = new System.Drawing.Point(177, 109);
            this.txtbx_cog_passenger_weight.Name = "txtbx_cog_passenger_weight";
            this.txtbx_cog_passenger_weight.Size = new System.Drawing.Size(100, 26);
            this.txtbx_cog_passenger_weight.TabIndex = 20;
            this.txtbx_cog_passenger_weight.Text = "0";
            // 
            // txtbx_cog_pilot_weight
            // 
            this.txtbx_cog_pilot_weight.Location = new System.Drawing.Point(177, 60);
            this.txtbx_cog_pilot_weight.Name = "txtbx_cog_pilot_weight";
            this.txtbx_cog_pilot_weight.Size = new System.Drawing.Size(100, 26);
            this.txtbx_cog_pilot_weight.TabIndex = 19;
            this.txtbx_cog_pilot_weight.Text = "0";
            // 
            // lbl_cog_fuel
            // 
            this.lbl_cog_fuel.AutoSize = true;
            this.lbl_cog_fuel.Location = new System.Drawing.Point(492, 303);
            this.lbl_cog_fuel.Name = "lbl_cog_fuel";
            this.lbl_cog_fuel.Size = new System.Drawing.Size(18, 20);
            this.lbl_cog_fuel.TabIndex = 18;
            this.lbl_cog_fuel.Text = "0";
            // 
            // lbl_cog_hold_baggage
            // 
            this.lbl_cog_hold_baggage.AutoSize = true;
            this.lbl_cog_hold_baggage.Location = new System.Drawing.Point(491, 208);
            this.lbl_cog_hold_baggage.Name = "lbl_cog_hold_baggage";
            this.lbl_cog_hold_baggage.Size = new System.Drawing.Size(18, 20);
            this.lbl_cog_hold_baggage.TabIndex = 17;
            this.lbl_cog_hold_baggage.Text = "0";
            // 
            // lbl_cog_cabin_baggage
            // 
            this.lbl_cog_cabin_baggage.AutoSize = true;
            this.lbl_cog_cabin_baggage.Location = new System.Drawing.Point(491, 157);
            this.lbl_cog_cabin_baggage.Name = "lbl_cog_cabin_baggage";
            this.lbl_cog_cabin_baggage.Size = new System.Drawing.Size(18, 20);
            this.lbl_cog_cabin_baggage.TabIndex = 16;
            this.lbl_cog_cabin_baggage.Text = "0";
            // 
            // lbl_cog_passenger
            // 
            this.lbl_cog_passenger.AutoSize = true;
            this.lbl_cog_passenger.Location = new System.Drawing.Point(492, 112);
            this.lbl_cog_passenger.Name = "lbl_cog_passenger";
            this.lbl_cog_passenger.Size = new System.Drawing.Size(18, 20);
            this.lbl_cog_passenger.TabIndex = 15;
            this.lbl_cog_passenger.Text = "0";
            // 
            // lbl_cog_pilot
            // 
            this.lbl_cog_pilot.AutoSize = true;
            this.lbl_cog_pilot.Location = new System.Drawing.Point(491, 63);
            this.lbl_cog_pilot.Name = "lbl_cog_pilot";
            this.lbl_cog_pilot.Size = new System.Drawing.Size(18, 20);
            this.lbl_cog_pilot.TabIndex = 14;
            this.lbl_cog_pilot.Text = "0";
            // 
            // txtbx_cog_fuel_arm
            // 
            this.txtbx_cog_fuel_arm.Location = new System.Drawing.Point(335, 300);
            this.txtbx_cog_fuel_arm.Name = "txtbx_cog_fuel_arm";
            this.txtbx_cog_fuel_arm.Size = new System.Drawing.Size(100, 26);
            this.txtbx_cog_fuel_arm.TabIndex = 13;
            this.txtbx_cog_fuel_arm.Text = "950";
            // 
            // txtbx_cog_hold_bag_arm
            // 
            this.txtbx_cog_hold_bag_arm.Location = new System.Drawing.Point(335, 205);
            this.txtbx_cog_hold_bag_arm.Name = "txtbx_cog_hold_bag_arm";
            this.txtbx_cog_hold_bag_arm.Size = new System.Drawing.Size(100, 26);
            this.txtbx_cog_hold_bag_arm.TabIndex = 12;
            this.txtbx_cog_hold_bag_arm.Text = "950";
            // 
            // txtbx_cog_cabin_bag_arm
            // 
            this.txtbx_cog_cabin_bag_arm.Location = new System.Drawing.Point(335, 154);
            this.txtbx_cog_cabin_bag_arm.Name = "txtbx_cog_cabin_bag_arm";
            this.txtbx_cog_cabin_bag_arm.Size = new System.Drawing.Size(100, 26);
            this.txtbx_cog_cabin_bag_arm.TabIndex = 11;
            this.txtbx_cog_cabin_bag_arm.Text = "400";
            // 
            // txtbx_cog_passenger_arm
            // 
            this.txtbx_cog_passenger_arm.Location = new System.Drawing.Point(335, 109);
            this.txtbx_cog_passenger_arm.Name = "txtbx_cog_passenger_arm";
            this.txtbx_cog_passenger_arm.Size = new System.Drawing.Size(100, 26);
            this.txtbx_cog_passenger_arm.TabIndex = 10;
            this.txtbx_cog_passenger_arm.Text = "400";
            // 
            // txtbx_cog_pilot_arm
            // 
            this.txtbx_cog_pilot_arm.Location = new System.Drawing.Point(335, 60);
            this.txtbx_cog_pilot_arm.Name = "txtbx_cog_pilot_arm";
            this.txtbx_cog_pilot_arm.Size = new System.Drawing.Size(100, 26);
            this.txtbx_cog_pilot_arm.TabIndex = 9;
            this.txtbx_cog_pilot_arm.Text = "400";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 303);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 20);
            this.label21.TabIndex = 8;
            this.label21.Text = "Fuel";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 208);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 20);
            this.label20.TabIndex = 7;
            this.label20.Text = "Hold Baggage";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 157);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(119, 20);
            this.label19.TabIndex = 6;
            this.label19.Text = "Cabin Baggage";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 112);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 20);
            this.label18.TabIndex = 5;
            this.label18.Text = "Passenger";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 20);
            this.label17.TabIndex = 4;
            this.label17.Text = "Pilot";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(491, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "Moment (kgmm)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(331, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Arm (mm)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(173, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Weight (kg)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Items";
            // 
            // chrt_cog
            // 
            chartArea1.AxisX.IsMarksNextToAxis = false;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorGrid.LineWidth = 2;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Maroon;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.OrangeRed;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.MediumBlue;
            chartArea1.AxisX2.IsMarksNextToAxis = false;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.CustomLabels.Add(customLabel1);
            chartArea1.AxisY.IsMarksNextToAxis = false;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY2.IsMarksNextToAxis = false;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chrt_cog.ChartAreas.Add(chartArea1);
            this.chrt_cog.IsSoftShadows = false;
            this.chrt_cog.Location = new System.Drawing.Point(29, 436);
            this.chrt_cog.Name = "chrt_cog";
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.IsVisibleInLegend = false;
            series1.LabelForeColor = System.Drawing.Color.Transparent;
            series1.Name = "cog";
            series1.ShadowColor = System.Drawing.Color.LightGray;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Name = "default";
            this.chrt_cog.Series.Add(series1);
            this.chrt_cog.Series.Add(series2);
            this.chrt_cog.Size = new System.Drawing.Size(1257, 117);
            this.chrt_cog.TabIndex = 43;
            this.chrt_cog.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_cog_zero);
            this.groupBox3.Controls.Add(this.lbl_cog_landing);
            this.groupBox3.Controls.Add(this.lbl_cog_take_off);
            this.groupBox3.Location = new System.Drawing.Point(743, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 185);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Centre of Gravity";
            // 
            // lbl_cog_zero
            // 
            this.lbl_cog_zero.AutoSize = true;
            this.lbl_cog_zero.Location = new System.Drawing.Point(27, 135);
            this.lbl_cog_zero.Name = "lbl_cog_zero";
            this.lbl_cog_zero.Size = new System.Drawing.Size(84, 20);
            this.lbl_cog_zero.TabIndex = 41;
            this.lbl_cog_zero.Text = "Zero CofG";
            // 
            // lbl_cog_landing
            // 
            this.lbl_cog_landing.AutoSize = true;
            this.lbl_cog_landing.Location = new System.Drawing.Point(27, 88);
            this.lbl_cog_landing.Name = "lbl_cog_landing";
            this.lbl_cog_landing.Size = new System.Drawing.Size(108, 20);
            this.lbl_cog_landing.TabIndex = 34;
            this.lbl_cog_landing.Text = "Landing CofG";
            // 
            // lbl_cog_take_off
            // 
            this.lbl_cog_take_off.AutoSize = true;
            this.lbl_cog_take_off.Location = new System.Drawing.Point(27, 45);
            this.lbl_cog_take_off.Name = "lbl_cog_take_off";
            this.lbl_cog_take_off.Size = new System.Drawing.Size(113, 20);
            this.lbl_cog_take_off.TabIndex = 33;
            this.lbl_cog_take_off.Text = "Take-Off CofG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.txtbx_specific_gravity);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.txtbx_cog_zero_fuel);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.txtbx_cog_landing_fuel);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.txtbx_cog_takeoff_fuel);
            this.groupBox2.Location = new System.Drawing.Point(1030, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 181);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fuel Volume";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(221, 145);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(14, 20);
            this.label30.TabIndex = 45;
            this.label30.Text = "ℓ";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(221, 113);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(14, 20);
            this.label29.TabIndex = 44;
            this.label29.Text = "ℓ";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(221, 81);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(14, 20);
            this.label28.TabIndex = 43;
            this.label28.Text = "ℓ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(221, 30);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 20);
            this.label26.TabIndex = 42;
            this.label26.Text = "kg/ℓ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(26, 30);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(118, 20);
            this.label25.TabIndex = 41;
            this.label25.Text = "Specific Gravity";
            // 
            // txtbx_specific_gravity
            // 
            this.txtbx_specific_gravity.Location = new System.Drawing.Point(150, 27);
            this.txtbx_specific_gravity.Name = "txtbx_specific_gravity";
            this.txtbx_specific_gravity.Size = new System.Drawing.Size(65, 26);
            this.txtbx_specific_gravity.TabIndex = 40;
            this.txtbx_specific_gravity.Text = "0.72";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(26, 145);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(42, 20);
            this.label23.TabIndex = 39;
            this.label23.Text = "Zero";
            // 
            // txtbx_cog_zero_fuel
            // 
            this.txtbx_cog_zero_fuel.Location = new System.Drawing.Point(150, 142);
            this.txtbx_cog_zero_fuel.Name = "txtbx_cog_zero_fuel";
            this.txtbx_cog_zero_fuel.Size = new System.Drawing.Size(65, 26);
            this.txtbx_cog_zero_fuel.TabIndex = 38;
            this.txtbx_cog_zero_fuel.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(26, 113);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(66, 20);
            this.label22.TabIndex = 37;
            this.label22.Text = "Landing";
            // 
            // txtbx_cog_landing_fuel
            // 
            this.txtbx_cog_landing_fuel.Location = new System.Drawing.Point(150, 110);
            this.txtbx_cog_landing_fuel.Name = "txtbx_cog_landing_fuel";
            this.txtbx_cog_landing_fuel.Size = new System.Drawing.Size(65, 26);
            this.txtbx_cog_landing_fuel.TabIndex = 36;
            this.txtbx_cog_landing_fuel.Text = "10";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(26, 81);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 20);
            this.label24.TabIndex = 29;
            this.label24.Text = "Take-off";
            // 
            // txtbx_cog_takeoff_fuel
            // 
            this.txtbx_cog_takeoff_fuel.Location = new System.Drawing.Point(150, 78);
            this.txtbx_cog_takeoff_fuel.Name = "txtbx_cog_takeoff_fuel";
            this.txtbx_cog_takeoff_fuel.Size = new System.Drawing.Size(65, 26);
            this.txtbx_cog_takeoff_fuel.TabIndex = 23;
            this.txtbx_cog_takeoff_fuel.Text = "0";
            // 
            // btn_calc_cog
            // 
            this.btn_calc_cog.Location = new System.Drawing.Point(1165, 358);
            this.btn_calc_cog.Name = "btn_calc_cog";
            this.btn_calc_cog.Size = new System.Drawing.Size(121, 45);
            this.btn_calc_cog.TabIndex = 32;
            this.btn_calc_cog.Text = "Calculate";
            this.btn_calc_cog.UseVisualStyleBackColor = true;
            this.btn_calc_cog.Click += new System.EventHandler(this.btn_calc_cog_Click);
            // 
            // btn_cog_print_report
            // 
            this.btn_cog_print_report.Location = new System.Drawing.Point(1165, 299);
            this.btn_cog_print_report.Name = "btn_cog_print_report";
            this.btn_cog_print_report.Size = new System.Drawing.Size(121, 45);
            this.btn_cog_print_report.TabIndex = 47;
            this.btn_cog_print_report.Text = "Print";
            this.btn_cog_print_report.UseVisualStyleBackColor = true;
            // 
            // txtbx_cog_accessories_weight
            // 
            this.txtbx_cog_accessories_weight.Location = new System.Drawing.Point(178, 252);
            this.txtbx_cog_accessories_weight.Name = "txtbx_cog_accessories_weight";
            this.txtbx_cog_accessories_weight.Size = new System.Drawing.Size(100, 26);
            this.txtbx_cog_accessories_weight.TabIndex = 39;
            this.txtbx_cog_accessories_weight.Text = "0";
            // 
            // lbl_cog_accessories
            // 
            this.lbl_cog_accessories.AutoSize = true;
            this.lbl_cog_accessories.Location = new System.Drawing.Point(492, 255);
            this.lbl_cog_accessories.Name = "lbl_cog_accessories";
            this.lbl_cog_accessories.Size = new System.Drawing.Size(18, 20);
            this.lbl_cog_accessories.TabIndex = 38;
            this.lbl_cog_accessories.Text = "0";
            // 
            // txtbx_cog_accessories_arm
            // 
            this.txtbx_cog_accessories_arm.Location = new System.Drawing.Point(336, 252);
            this.txtbx_cog_accessories_arm.Name = "txtbx_cog_accessories_arm";
            this.txtbx_cog_accessories_arm.Size = new System.Drawing.Size(100, 26);
            this.txtbx_cog_accessories_arm.TabIndex = 37;
            this.txtbx_cog_accessories_arm.Text = "0";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(20, 255);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(95, 20);
            this.label32.TabIndex = 36;
            this.label32.Text = "Accessories";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 805);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "myFlightInfo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.panel31.ResumeLayout(false);
            this.grpbx_towns.ResumeLayout(false);
            this.grpbx_towns.PerformLayout();
            this.panel32.ResumeLayout(false);
            this.grpbx_altimeter.ResumeLayout(false);
            this.grpbx_altimeter.PerformLayout();
            this.panel33.ResumeLayout(false);
            this.panel34.ResumeLayout(false);
            this.grpbx_browser_navigation.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.panel35.ResumeLayout(false);
            this.panel35.PerformLayout();
            this.panel36.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tabcnt_toplevel.ResumeLayout(false);
            this.tab_weather.ResumeLayout(false);
            this.tabcnt_weather.ResumeLayout(false);
            this.tab_met_office.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_weather_met)).EndInit();
            this.tab_bbc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_weather_bbc)).EndInit();
            this.tab_windy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_weather_windy)).EndInit();
            this.tab_synoptic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_synoptic)).EndInit();
            this.tab_gransden_lodge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_gransden_lodge_weather)).EndInit();
            this.tab_metar.ResumeLayout(false);
            this.tabCnt_airfields.ResumeLayout(false);
            this.tab_lt_gransden.ResumeLayout(false);
            this.tabcnt_lt_gransden.ResumeLayout(false);
            this.tab_m_ltgransden.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_egmj)).EndInit();
            this.tab_m_luton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_eggw)).EndInit();
            this.tab_m_stanstead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_egss)).EndInit();
            this.tab_m_wittering.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_egxt)).EndInit();
            this.tab_m_mildenhall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_egun)).EndInit();
            this.tab_rochester.ResumeLayout(false);
            this.tabCnt_rochester.ResumeLayout(false);
            this.tab_m_rochester.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_egto)).EndInit();
            this.tab_m_lon_city.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_egcc)).EndInit();
            this.tab_m_lydd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_egmd)).EndInit();
            this.tab_m_gatwick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_egkk)).EndInit();
            this.tab_m_stansted.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_egss2)).EndInit();
            this.tab_notams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_notams)).EndInit();
            this.tab_utils.ResumeLayout(false);
            this.tabcnt_utils.ResumeLayout(false);
            this.tab_browser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_browser)).EndInit();
            this.tab_altimeter.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.grpbx_to.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.grpbx_present.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            this.panel37.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.grpbx_QNH.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.tab_crosswind.ResumeLayout(false);
            this.tab_crosswind.PerformLayout();
            this.tab_CofG.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_cog)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TabControl tabcnt_toplevel;
        private System.Windows.Forms.TabPage tab_metar;
        private System.Windows.Forms.TabPage tab_notams;
        private System.Windows.Forms.TabPage tab_utils;
        private System.Windows.Forms.TabControl tabcnt_utils;
        private System.Windows.Forms.TabPage tab_browser;
        private System.Windows.Forms.TabPage tab_altimeter;
        private System.Windows.Forms.TabPage tab_crosswind;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_notams;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_browser;
        private System.Windows.Forms.TabControl tabCnt_airfields;
        private System.Windows.Forms.TabPage tab_lt_gransden;
        private System.Windows.Forms.TabControl tabcnt_lt_gransden;
        private System.Windows.Forms.TabPage tab_m_ltgransden;
        private System.Windows.Forms.TabPage tab_m_luton;
        private System.Windows.Forms.TabPage tab_rochester;
        private System.Windows.Forms.TabControl tabCnt_rochester;
        private System.Windows.Forms.TabPage tab_m_rochester;
        private System.Windows.Forms.TabPage tab_m_lon_city;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_gransden_lodge_photo_update;
        private System.Windows.Forms.Button btn_close;
        public Microsoft.Web.WebView2.WinForms.WebView2 webView_egmj;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_eggw;
        private System.Windows.Forms.TabPage tab_m_stanstead;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_egss;
        private System.Windows.Forms.TabPage tab_weather;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_calculate_altimiter;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox grpbx_to;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_to_altitude;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label lbl_to_pressure;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label lbl_d_elevation_m;
        private System.Windows.Forms.Label lbl_d_longitude_dec;
        private System.Windows.Forms.Label lbl_d_longitude_deg;
        private System.Windows.Forms.Label lbl_d_latitude_dec;
        private System.Windows.Forms.Label lbl_d_latitude_deg;
        private System.Windows.Forms.Label lbl_d_icao_code;
        private System.Windows.Forms.Label lbl_d_airport_name;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.GroupBox grpbx_present;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtbx_present_altitude;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.TextBox txtbx_present_pressure;
        private System.Windows.Forms.Panel panel37;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label lbl_p_elevation_m;
        private System.Windows.Forms.Label lbl_p_longitude_dec;
        private System.Windows.Forms.Label lbl_p_longitude_deg;
        private System.Windows.Forms.Label lbl_p_latitude_dec;
        private System.Windows.Forms.Label lbl_p_latitude_deg;
        private System.Windows.Forms.Label lbl_p_icao_code;
        private System.Windows.Forms.Label lbl_p_airport_name;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.GroupBox grpbx_QNH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lbl_sea_level_ft;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lbl_qnh_pressure;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.GroupBox grpbx_towns;
        private System.Windows.Forms.RadioButton rdobtn_Gt_Gransden;
        private System.Windows.Forms.RadioButton rdobtn_cambridge;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.GroupBox grpbx_altimeter;
        private System.Windows.Forms.RadioButton rdobtn_destination;
        private System.Windows.Forms.RadioButton rdobtn_present;
        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.ComboBox cmbobx_gransden_lodge;
        private System.Windows.Forms.ComboBox cmbobx_airport_info;
        private System.Windows.Forms.Panel panel34;
        private System.Windows.Forms.GroupBox grpbx_browser_navigation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Panel panel35;
        private System.Windows.Forms.TextBox txtbx_navigate_to_url;
        private System.Windows.Forms.Panel panel36;
        private System.Windows.Forms.Button btn_navigate_to;
        private System.Windows.Forms.Button btn_calc_wind;
        private System.Windows.Forms.Label lbl_runway_heading2;
        private System.Windows.Forms.Label lbl_headwind_2;
        private System.Windows.Forms.Label lbl_crosswind_2;
        private System.Windows.Forms.Label lbl_runway_heading1;
        private System.Windows.Forms.Label lbl_headwind_1;
        private System.Windows.Forms.Label lbl_crosswind_1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbx_runway_heading;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbx_direction;
        private System.Windows.Forms.TextBox txtbx_magnitude;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tab_m_wittering;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_egxt;
        private System.Windows.Forms.TabPage tab_m_mildenhall;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_egun;
        private System.Windows.Forms.TabPage tab_m_lydd;
        private System.Windows.Forms.TabPage tab_m_gatwick;
        private System.Windows.Forms.TabPage tab_m_stansted;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_egto;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_egcc;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_egmd;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_egkk;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_egss2;
        private System.Windows.Forms.Button btn_school;
        private System.Windows.Forms.TabControl tabcnt_weather;
        private System.Windows.Forms.TabPage tab_met_office;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_weather_met;
        private System.Windows.Forms.TabPage tab_bbc;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_weather_bbc;
        private System.Windows.Forms.TabPage tab_windy;
        private System.Windows.Forms.TabPage tab_synoptic;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_synoptic;
        private System.Windows.Forms.TabPage tab_gransden_lodge;
        public Microsoft.Web.WebView2.WinForms.WebView2 webView_gransden_lodge_weather;
        public Microsoft.Web.WebView2.WinForms.WebView2 webView_weather_windy;
        private System.Windows.Forms.TabPage tab_CofG;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbl_cog_total_moment;
        private System.Windows.Forms.Label lbl_cog_total_weight;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbx_cog_takeoff_fuel;
        private System.Windows.Forms.TextBox txtbx_cog_hold_bag_weight;
        private System.Windows.Forms.TextBox txtbx_cog_cabin_bag_weight;
        private System.Windows.Forms.TextBox txtbx_cog_passenger_weight;
        private System.Windows.Forms.TextBox txtbx_cog_pilot_weight;
        private System.Windows.Forms.Label lbl_cog_fuel;
        private System.Windows.Forms.Label lbl_cog_hold_baggage;
        private System.Windows.Forms.Label lbl_cog_cabin_baggage;
        private System.Windows.Forms.Label lbl_cog_passenger;
        private System.Windows.Forms.Label lbl_cog_pilot;
        private System.Windows.Forms.TextBox txtbx_cog_fuel_arm;
        private System.Windows.Forms.TextBox txtbx_cog_hold_bag_arm;
        private System.Windows.Forms.TextBox txtbx_cog_cabin_bag_arm;
        private System.Windows.Forms.TextBox txtbx_cog_passenger_arm;
        private System.Windows.Forms.TextBox txtbx_cog_pilot_arm;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_calc_cog;
        private System.Windows.Forms.Label lbl_cog_take_off;
        private System.Windows.Forms.Label lbl_cog_landing;
        private System.Windows.Forms.Label lbl_fuel_weight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtbx_cog_zero_fuel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtbx_cog_landing_fuel;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtbx_specific_gravity;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_cog_zero;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_cog;
        private System.Windows.Forms.Button btn_cog_reset;
        private System.Windows.Forms.RichTextBox rchtxtbx_cog_report;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_cog_print_report;
        private System.Windows.Forms.TextBox txtbx_cog_accessories_weight;
        private System.Windows.Forms.Label lbl_cog_accessories;
        private System.Windows.Forms.TextBox txtbx_cog_accessories_arm;
        private System.Windows.Forms.Label label32;
    }
}

