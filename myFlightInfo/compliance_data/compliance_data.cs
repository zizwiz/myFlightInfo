using System.Xml;

namespace myFlightInfo.compliance_data
{
    class ComplianceData
    {
        public static string[] GetComplianceData(string aircraft_name)
        {
            string[] reply = new string[20];

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("compliance_data.xml");

                XmlNodeList nodeList;
                XmlNode root = doc.DocumentElement;

                nodeList = root.SelectNodes("descendant::aircraft_info[aircraft_name ='" + aircraft_name + "']");


                foreach (XmlNode data in nodeList)
                {
                    reply[1] = data["MaxTakeOffWeight"].InnerText;
                    reply[2] = data["EmptyWeight"].InnerText;
                    reply[3] = data["MinPilotWeight"].InnerText;
                    reply[4] = data["MaxWeightPerCrewMember"].InnerText;
                    reply[5] = data["MaxCockpitWeight"].InnerText;
                    reply[6] = data["MinCockpitWeight"].InnerText;
                    reply[7] = data["MaxWeightPerSeat"].InnerText;
                    reply[8] = data["MaxHoldBaggageWeight"].InnerText;
                    reply[9] = data["MaxFuelVol"].InnerText;
                    reply[10] = data["MinFuelVol"].InnerText;
                    reply[11] = data["Vne"].InnerText;
                    reply[12] = data["Va"].InnerText;
                    reply[13] = data["Vs0"].InnerText;
                    reply[14] = data["Vs1"].InnerText;
                    reply[15] = data["Vfe"].InnerText;
                    reply[16] = data["AftMomentArm"].InnerText;
                    reply[17] = data["FwdMomentArm"].InnerText;
                    reply[18] = data["AftCGLimit"].InnerText;
                    reply[19] = data["FwdCGLimit"].InnerText;
                }
            }
            catch
            {
                reply[0] = "Check the aircraft name is correct";
            }


            return reply;
        }





    }
}
