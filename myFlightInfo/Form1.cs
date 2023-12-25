using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

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

            await webView_notams.EnsureCoreWebView2Async();
            await webView_browser.EnsureCoreWebView2Async();

            webView_notams.CoreWebView2.Navigate("   https://www.notaminfo.com/ukmap?destination=node%2F39");
            webView_egmj.CoreWebView2.Navigate("https://metar-taf.com/EGMJ");
            webView_egss.CoreWebView2.Navigate("https://metar-taf.com/EGSS");
            webView_eggw.CoreWebView2.Navigate("https://metar-taf.com/EGGW");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
