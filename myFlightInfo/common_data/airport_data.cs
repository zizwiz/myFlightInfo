using System.Xml;

namespace myFlightInfo.common_data
{
    class airport_data
    {

        public static string[] GetAirportInfo(string airport_name)
        {
            string[] reply = new string[10];


            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("airport_data.xml");

                XmlNodeList nodeList;
                XmlNode root = doc.DocumentElement;

                nodeList = root.SelectNodes("descendant::airport_info[airport_name ='" + airport_name + "']");


                foreach (XmlNode data in nodeList)
                {
                    reply[1] = data["icao_code"].InnerText;
                    reply[2] = data["airport_name"].InnerText;
                    reply[3] = data["latitude_deg"].InnerText;
                    reply[4] = data["latitude_dec"].InnerText;
                    reply[5] = data["longitude_deg"].InnerText;
                    reply[6] = data["longitude_dec"].InnerText;
                    reply[7] = data["elevation_m"].InnerText;
                    reply[8] = data["elevation_ft"].InnerText;
                }
            }
            catch
            {
                reply[0] = "Check the airport name is correct";
            }


            return reply;
        }


    }
}
