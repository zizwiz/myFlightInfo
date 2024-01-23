using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using myFlightInfo.common_data;

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


        public static bool AddAircraftComplianceData(string aircraft_name)
        {
           // Form1 Form2 = new Form1();
           
            XDocument doc = XDocument.Load("compliance_data.xml");
            XElement root = new XElement("aircraft_info");

            //root.Add(new XAttribute("MaxTakeOffWeight", "999"));

            root.Add(new XElement("aircraft_name", aircraft_name));
            root.Add(new XElement("MaxTakeOffWeight", "999"));
            root.Add(new XElement("EmptyWeight", "888"));

            

            doc.Element("compliance_data").Add(root);
            doc.Save("compliance_data.xml");

            return true;

           /*
            if (verification.CheckDouble(Form2.txtbx_settings_mtow))
            {
                root.Add(new XAttribute("MaxTakeOffWeight", Form2.txtbx_settings_mtow.Text));
            }
            else
            {
                verification.ShowError("Max Take Off Weight");
                return false;
            }

            if (verification.CheckDouble(Form2.txtbx_settings_empty_weight))
            {
                root.Add(new XAttribute("EmptyWeight", Form2.txtbx_settings_empty_weight.Text)); 
            }
            else
            {
                verification.ShowError("Empty Weight");
                return false;
            }


            if (verification.CheckDouble(Form2.txtbx_settings_empty_weight))
            {
                root.Add(new XAttribute("EmptyWeight", Form2.txtbx_settings_empty_weight));
            }
            else
            {
                verification.ShowError("Empty Weight");
                return false;
            }

            if (verification.CheckDouble(Form2.txtbx_settings_min_pilot_weight))
            {
                root.Add(new XAttribute("MinPilotWeight", Form2.txtbx_settings_min_pilot_weight.Text)); 
            }
            else
            {
                verification.ShowError("Min Pilot Weight");
                return false;
            }

            if (verification.CheckDouble(Form2.txtbx_settings_max_per_crew_weight))
            {
                root.Add(new XAttribute("MaxWeightPerCrewMember", Form2.txtbx_settings_max_per_crew_weight.Text));
            }
            else
            {
                verification.ShowError("Max Weight Per Crew Member");
                return false;
            }

            if (verification.CheckDouble(Form2.txtbx_settings_max_cockpit_weight))
            {
                root.Add(new XAttribute("MaxCockpitWeight", Form2.txtbx_settings_max_cockpit_weight.Text));
            }
            else
            {
                verification.ShowError("Max Cockpit Weight");
                return false;
            }

            if (verification.CheckDouble(Form2.txtbx_settings_min_cockpit_weight))
            {
                root.Add(new XAttribute("MinCockpitWeight", Form2.txtbx_settings_min_cockpit_weight.Text));
            }
            else
            {
                verification.ShowError("Min Cockpit Weight");
                return false;
            }

            if (verification.CheckDouble(Form2.txtbx_settings_max_weight_per_seat))
            {
                root.Add(new XAttribute("MaxWeightPerSeat", Form2.txtbx_settings_max_weight_per_seat.Text));
            }
            else
            {
                verification.ShowError("Max Weight Per Seat");
                return false;
            }

            if (verification.CheckDouble(Form2.txtbx_settings_max_hold_bag_weight))
            {
                root.Add(new XAttribute("MaxHoldBaggageWeight", Form2.txtbx_settings_max_hold_bag_weight.Text));
            }
            else
            {
                verification.ShowError("Max Hold Baggage Weight");
                return false;
            }

            if (verification.CheckDouble(Form2.txtbx_settings_vne))
            {
                 root.Add(new XAttribute("Vne", Form2.txtbx_settings_vne.Text));
            }
            else
            {
                verification.ShowError("Vne");
                return false;
            }

            if (verification.CheckDouble(Form2.txtbx_settings_va))
            {
                root.Add(new XAttribute("Va", Form2.txtbx_settings_va.Text));
            }
            else
            {
                verification.ShowError("Va");
                return false;
            }

            if (verification.CheckDouble(Form2.txtbx_settings_vs0))
            {
                root.Add(new XAttribute("Vs0", Form2.txtbx_settings_vs0.Text));
            }
            else
            {
                verification.ShowError("Vs0");
                return false;
            }

            if (verification.CheckDouble(Form2.txtbx_settings_vs1))
            {
                root.Add(new XAttribute("Vs1", Form2.txtbx_settings_vs1.Text));
            }
            else
            {
                verification.ShowError("Vs1");
                return false;
            }

            if (verification.CheckDouble(Form2.txtbx_settings_vfe))
            {
                root.Add(new XAttribute("Vfe", Form2.txtbx_settings_vfe.Text));
            }
            else
            {
                verification.ShowError("Vfe");
                return false;
            }

            if (verification.CheckDouble(Form2.txtbx_settings_hold_arm))
            {
                root.Add(new XAttribute("AftMomentArm", Form2.txtbx_settings_hold_arm.Text));
            }
            else
            {
                verification.ShowError("Aft Moment Arm");
                return false;
            }

            if (verification.CheckDouble(Form2.txtbx_settings_cabin_arm))
            {
                root.Add(new XAttribute("FwdMomentArm", Form2.txtbx_settings_cabin_arm.Text));
            }
            else
            {
                verification.ShowError("Fwd Moment Arm");
                return false;
            }

            if (verification.CheckDouble(Form2.txtbx_settings_aft_cg_limit))
            {
                root.Add(new XAttribute("AftCGLimit", Form2.txtbx_settings_aft_cg_limit.Text));
            }
            else
            {
                verification.ShowError("Aft CG Limit");
                return false;
            }

            if (verification.CheckDouble(Form2.txtbx_settings_fwd_cg_limit))
            {
                root.Add(new XAttribute("FwdCGLimit", Form2.txtbx_settings_fwd_cg_limit.Text));
            }
            else
            {
                verification.ShowError("Fwd CG Limit");
                return false;
            }

            if (verification.CheckDouble(Form2.txtbx_settings_max_fuel_vol))
            {
                root.Add(new XAttribute("MaxFuelVol", Form2.txtbx_settings_max_fuel_vol.Text));
            }
            else
            {
                verification.ShowError("Max Fuel Volume");
                return false;
            }

            if (verification.CheckDouble(Form2.txtbx_settings_min_fuel_vol))
            {
                root.Add(new XAttribute("MinFuelVol", Form2.txtbx_settings_min_fuel_vol.Text));
            }
            else
            {
                verification.ShowError("Min Fuel Volume");
                return false;
            }
            
            doc.Element("aircraft_info").Add(root);
            doc.Save("compliance_data.xml");
            
            return true;*/
        }
    }
}
