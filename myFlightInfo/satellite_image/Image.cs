using Microsoft.Web.WebView2.WinForms;
using myFlightInfo.browsing;
using myFlightInfo.utils;

namespace myFlightInfo.satellite_image
{
    class Image
    {

        public static void DrawSatelliteImage(string myURI, WebView2 myWebView2)
        {
            Browse.NavigateTo(myURI, myWebView2);

            //add a delay if not then the new image will not be shown
            TimeFunctions.BlockingTimeDelay(1000); //delay 1 second
            myWebView2.Reload();
        }



    }
}
