using System;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using myFlightInfo.common_data;

namespace myFlightInfo
{
    public partial class Form1
    {

        /// <summary>
        /// Populate the combobox in the compliance data from the xml file.
        /// </summary>
        private void PopulateComplianceDataCmboBx(string myAircraftName)
        {
            cmbobx_aircraftName.Items.Clear();

            XmlDocument doc = new XmlDocument();
            doc.Load("compliance_data.xml");
            XmlNode root = doc.DocumentElement;
            XmlNodeList nodeList = root.SelectNodes("aircraft_info");

            foreach (XmlNode aircraft in nodeList)
            {
                cmbobx_aircraftName.Items.Add(aircraft["aircraft_name"].InnerText);
            }

            if (!cmbobx_aircraftName.Items.Contains(myAircraftName))
            {
                cmbobx_aircraftName.SelectedIndex = 0;
            }
            else
            {
                cmbobx_aircraftName.SelectedText = myAircraftName;
            }

            GetData(cmbobx_aircraftName.Text);
        }




        //public static string[] GetComplianceData(string aircraft_name)
        //{
        //    string[] reply = new string[20];

        //    try
        //    {
        //        XmlDocument doc = new XmlDocument();
        //        doc.Load("compliance_data.xml");

        //        XmlNodeList nodeList;
        //        XmlNode root = doc.DocumentElement;

        //        nodeList = root.SelectNodes("descendant::aircraft_info[aircraft_name ='" + aircraft_name + "']");


        //        foreach (XmlNode data in nodeList)
        //        {
        //            reply[1] = data["MaxTakeOffWeight"].InnerText;
        //            reply[2] = data["EmptyWeight"].InnerText;
        //            reply[3] = data["MinPilotWeight"].InnerText;
        //            reply[4] = data["MaxWeightPerCrewMember"].InnerText;
        //            reply[5] = data["MaxCockpitWeight"].InnerText;
        //            reply[6] = data["MinCockpitWeight"].InnerText;
        //            reply[7] = data["MaxWeightPerSeat"].InnerText;
        //            reply[8] = data["MaxHoldBaggageWeight"].InnerText;
        //            reply[9] = data["MaxFuelVol"].InnerText;
        //            reply[10] = data["MinFuelVol"].InnerText;
        //            reply[11] = data["Vne"].InnerText;
        //            reply[12] = data["Va"].InnerText;
        //            reply[13] = data["Vs0"].InnerText;
        //            reply[14] = data["Vs1"].InnerText;
        //            reply[15] = data["Vfe"].InnerText;
        //            reply[16] = data["AftMomentArm"].InnerText;
        //            reply[17] = data["FwdMomentArm"].InnerText;
        //            reply[18] = data["AftCGLimit"].InnerText;
        //            reply[19] = data["FwdCGLimit"].InnerText;
        //        }
        //    }
        //    catch
        //    {
        //        reply[0] = "Check the aircraft name is correct";
        //    }


        //    return reply;
        //}


        //public bool AddAircraftComplianceData(string aircraft_name)
        //{
        //    XDocument doc = XDocument.Load("compliance_data.xml");
        //    XElement root = new XElement("aircraft_info");

        //   root.Add(new XElement("aircraft_name", aircraft_name));

        //    if (verification.CheckDouble(txtbx_settings_mtow))
        //    {
        //        root.Add(new XElement("MaxTakeOffWeight", txtbx_settings_mtow.Text));
        //    }
        //    else
        //    {
        //        verification.ShowError("Max Take Off Weight");
        //        return false;
        //    }

        //    if (verification.CheckDouble(txtbx_settings_empty_weight))
        //    {
        //        root.Add(new XElement("EmptyWeight", txtbx_settings_empty_weight.Text));
        //    }
        //    else
        //    {
        //        verification.ShowError("Empty Weight");
        //        return false;
        //    }


        //    if (verification.CheckDouble(txtbx_settings_empty_weight))
        //    {
        //        root.Add(new XElement("EmptyWeight", txtbx_settings_empty_weight));
        //    }
        //    else
        //    {
        //        verification.ShowError("Empty Weight");
        //        return false;
        //    }

        //    if (verification.CheckDouble(txtbx_settings_min_pilot_weight))
        //    {
        //        root.Add(new XElement("MinPilotWeight", txtbx_settings_min_pilot_weight.Text));
        //    }
        //    else
        //    {
        //        verification.ShowError("Min Pilot Weight");
        //        return false;
        //    }

        //    if (verification.CheckDouble(txtbx_settings_max_per_crew_weight))
        //    {
        //        root.Add(new XElement("MaxWeightPerCrewMember", txtbx_settings_max_per_crew_weight.Text));
        //    }
        //    else
        //    {
        //        verification.ShowError("Max Weight Per Crew Member");
        //        return false;
        //    }

        //    if (verification.CheckDouble(txtbx_settings_max_cockpit_weight))
        //    {
        //        root.Add(new XElement("MaxCockpitWeight", txtbx_settings_max_cockpit_weight.Text));
        //    }
        //    else
        //    {
        //        verification.ShowError("Max Cockpit Weight");
        //        return false;
        //    }

        //    if (verification.CheckDouble(txtbx_settings_min_cockpit_weight))
        //    {
        //        root.Add(new XElement("MinCockpitWeight", txtbx_settings_min_cockpit_weight.Text));
        //    }
        //    else
        //    {
        //        verification.ShowError("Min Cockpit Weight");
        //        return false;
        //    }

        //    if (verification.CheckDouble(txtbx_settings_max_weight_per_seat))
        //    {
        //        root.Add(new XElement("MaxWeightPerSeat", txtbx_settings_max_weight_per_seat.Text));
        //    }
        //    else
        //    {
        //        verification.ShowError("Max Weight Per Seat");
        //        return false;
        //    }

        //    if (verification.CheckDouble(txtbx_settings_max_hold_bag_weight))
        //    {
        //        root.Add(new XElement("MaxHoldBaggageWeight", txtbx_settings_max_hold_bag_weight.Text));
        //    }
        //    else
        //    {
        //        verification.ShowError("Max Hold Baggage Weight");
        //        return false;
        //    }

        //    if (verification.CheckDouble(txtbx_settings_vne))
        //    {
        //        root.Add(new XElement("Vne", txtbx_settings_vne.Text));
        //    }
        //    else
        //    {
        //        verification.ShowError("Vne");
        //        return false;
        //    }

        //    if (verification.CheckDouble(txtbx_settings_va))
        //    {
        //        root.Add(new XElement("Va", txtbx_settings_va.Text));
        //    }
        //    else
        //    {
        //        verification.ShowError("Va");
        //        return false;
        //    }

        //    if (verification.CheckDouble(txtbx_settings_vs0))
        //    {
        //        root.Add(new XElement("Vs0", txtbx_settings_vs0.Text));
        //    }
        //    else
        //    {
        //        verification.ShowError("Vs0");
        //        return false;
        //    }

        //    if (verification.CheckDouble(txtbx_settings_vs1))
        //    {
        //        root.Add(new XElement("Vs1", txtbx_settings_vs1.Text));
        //    }
        //    else
        //    {
        //        verification.ShowError("Vs1");
        //        return false;
        //    }

        //    if (verification.CheckDouble(txtbx_settings_vfe))
        //    {
        //        root.Add(new XElement("Vfe", txtbx_settings_vfe.Text));
        //    }
        //    else
        //    {
        //        verification.ShowError("Vfe");
        //        return false;
        //    }

        //    if (verification.CheckDouble(txtbx_settings_hold_arm))
        //    {
        //        root.Add(new XElement("AftMomentArm", txtbx_settings_hold_arm.Text));
        //    }
        //    else
        //    {
        //        verification.ShowError("Aft Moment Arm");
        //        return false;
        //    }

        //    if (verification.CheckDouble(txtbx_settings_cabin_arm))
        //    {
        //        root.Add(new XElement("FwdMomentArm", txtbx_settings_cabin_arm.Text));
        //    }
        //    else
        //    {
        //        verification.ShowError("Fwd Moment Arm");
        //        return false;
        //    }

        //    if (verification.CheckDouble(txtbx_settings_aft_cg_limit))
        //    {
        //        root.Add(new XElement("AftCGLimit", txtbx_settings_aft_cg_limit.Text));
        //    }
        //    else
        //    {
        //        verification.ShowError("Aft CG Limit");
        //        return false;
        //    }

        //    if (verification.CheckDouble(txtbx_settings_fwd_cg_limit))
        //    {
        //        root.Add(new XElement("FwdCGLimit", txtbx_settings_fwd_cg_limit.Text));
        //    }
        //    else
        //    {
        //        verification.ShowError("Fwd CG Limit");
        //        return false;
        //    }

        //    if (verification.CheckDouble(txtbx_settings_max_fuel_vol))
        //    {
        //        root.Add(new XElement("MaxFuelVol", txtbx_settings_max_fuel_vol.Text));
        //    }
        //    else
        //    {
        //        verification.ShowError("Max Fuel Volume");
        //        return false;
        //    }

        //    if (verification.CheckDouble(txtbx_settings_min_fuel_vol))
        //    {
        //        root.Add(new XElement("MinFuelVol", txtbx_settings_min_fuel_vol.Text));
        //    }
        //    else
        //    {
        //        verification.ShowError("Min Fuel Volume");
        //        return false;
        //    }

        //    doc.Element("compliance_data").Add(root);
        //    doc.Save("compliance_data.xml");

        //    return true;
        //}

        private void cmbobx_aircraftName_SelectedValueChanged(object sender, EventArgs e)
        {
            GetData(cmbobx_aircraftName.Text);
        }

        private void GetData(string myAircraftName)
        {
            string xQryStr = "//aircraft_info[aircraft_name ='" + myAircraftName + "']";

            XmlDocument doc = new XmlDocument();
            doc.Load("compliance_data.xml");
            XmlNodeList listOfNodes = doc.SelectNodes(xQryStr);

            foreach (XmlNode node in listOfNodes)
            {
                txtbx_settings_mtow.Text = node.SelectSingleNode("MaxTakeOffWeight").InnerText;
                txtbx_settings_empty_weight.Text = node.SelectSingleNode("EmptyWeight").InnerText;
                txtbx_settings_min_pilot_weight.Text = node.SelectSingleNode("MinPilotWeight").InnerText;
                txtbx_settings_max_per_crew_weight.Text = node.SelectSingleNode("MaxWeightPerCrewMember").InnerText;
                txtbx_settings_max_cockpit_weight.Text = node.SelectSingleNode("MaxCockpitWeight").InnerText;
                txtbx_settings_min_cockpit_weight.Text = node.SelectSingleNode("MinCockpitWeight").InnerText;
                txtbx_settings_max_weight_per_seat.Text = node.SelectSingleNode("MaxWeightPerSeat").InnerText;
                txtbx_settings_max_hold_bag_weight.Text = node.SelectSingleNode("MaxHoldBaggageWeight").InnerText;
                txtbx_settings_max_fuel_vol.Text = node.SelectSingleNode("MaxFuelVol").InnerText;
                txtbx_settings_min_fuel_vol.Text = node.SelectSingleNode("MinFuelVol").InnerText;
                txtbx_settings_vne.Text = node.SelectSingleNode("Vne").InnerText;
                txtbx_settings_va.Text = node.SelectSingleNode("Va").InnerText;
                txtbx_settings_vs0.Text = node.SelectSingleNode("Vs0").InnerText;
                txtbx_settings_vs1.Text = node.SelectSingleNode("Vs1").InnerText;
                txtbx_settings_vfe.Text = node.SelectSingleNode("Vfe").InnerText;
                txtbx_settings_hold_arm.Text = node.SelectSingleNode("AftMomentArm").InnerText;
                txtbx_settings_cabin_arm.Text = node.SelectSingleNode("FwdMomentArm").InnerText;
                txtbx_settings_aft_cg_limit.Text = node.SelectSingleNode("AftCGLimit").InnerText;
                txtbx_settings_fwd_cg_limit.Text = node.SelectSingleNode("FwdCGLimit").InnerText;
            }
        }

    }
}
