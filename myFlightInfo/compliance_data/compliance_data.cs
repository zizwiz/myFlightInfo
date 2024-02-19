using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using CenteredMessagebox;
using myFlightInfo.common_data;
using myFlightInfo.Properties;
using xmlFactory;

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
            SaveSettings();
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

        private void btn_settings_add_aircraft_Click(object sender, EventArgs e)
        {
            //create a dialog and get the name entered on it
            var aircraftNameForm = new compliance_data.aircraftName();
            aircraftNameForm.ShowDialog();
            string myAircraftName = aircraftNameForm.myAircraftName;


           if ((myAircraftName != "")&& (myAircraftName != "error"))
            {
                if ((!CheckIfAircraftNameExists(myAircraftName)) && (File.Exists("compliance_data.xml")))
                {
                    XDocument doc = XDocument.Load("compliance_data.xml");
                    XElement root = new XElement("aircraft_info");


                    root.Add(new XElement("aircraft_name", myAircraftName));

                    if (verification.CheckDouble(txtbx_settings_mtow))
                    {
                        root.Add(new XElement("MaxTakeOffWeight", txtbx_settings_mtow.Text));
                    }
                    else
                    {
                        verification.ShowError("Max Take Off Weight");
                        return;
                    }

                    if (verification.CheckDouble(txtbx_settings_empty_weight))
                    {
                        root.Add(new XElement("EmptyWeight", txtbx_settings_empty_weight.Text));
                    }
                    else
                    {
                        verification.ShowError("Empty Weight");
                        return;
                    }


                    if (verification.CheckDouble(txtbx_settings_empty_weight))
                    {
                        root.Add(new XElement("EmptyWeight", txtbx_settings_empty_weight));
                    }
                    else
                    {
                        verification.ShowError("Empty Weight");
                        return;
                    }

                    if (verification.CheckDouble(txtbx_settings_min_pilot_weight))
                    {
                        root.Add(new XElement("MinPilotWeight", txtbx_settings_min_pilot_weight.Text));
                    }
                    else
                    {
                        verification.ShowError("Min Pilot Weight");
                        return;
                    }

                    if (verification.CheckDouble(txtbx_settings_max_per_crew_weight))
                    {
                        root.Add(new XElement("MaxWeightPerCrewMember", txtbx_settings_max_per_crew_weight.Text));
                    }
                    else
                    {
                        verification.ShowError("Max Weight Per Crew Member");
                        return;
                    }

                    if (verification.CheckDouble(txtbx_settings_max_cockpit_weight))
                    {
                        root.Add(new XElement("MaxCockpitWeight", txtbx_settings_max_cockpit_weight.Text));
                    }
                    else
                    {
                        verification.ShowError("Max Cockpit Weight");
                        return;
                    }

                    if (verification.CheckDouble(txtbx_settings_min_cockpit_weight))
                    {
                        root.Add(new XElement("MinCockpitWeight", txtbx_settings_min_cockpit_weight.Text));
                    }
                    else
                    {
                        verification.ShowError("Min Cockpit Weight");
                        return;
                    }

                    if (verification.CheckDouble(txtbx_settings_max_weight_per_seat))
                    {
                        root.Add(new XElement("MaxWeightPerSeat", txtbx_settings_max_weight_per_seat.Text));
                    }
                    else
                    {
                        verification.ShowError("Max Weight Per Seat");
                        return;
                    }

                    if (verification.CheckDouble(txtbx_settings_max_hold_bag_weight))
                    {
                        root.Add(new XElement("MaxHoldBaggageWeight", txtbx_settings_max_hold_bag_weight.Text));
                    }
                    else
                    {
                        verification.ShowError("Max Hold Baggage Weight");
                        return;
                    }

                    if (verification.CheckDouble(txtbx_settings_vne))
                    {
                        root.Add(new XElement("Vne", txtbx_settings_vne.Text));
                    }
                    else
                    {
                        verification.ShowError("Vne");
                        return;
                    }

                    if (verification.CheckDouble(txtbx_settings_va))
                    {
                        root.Add(new XElement("Va", txtbx_settings_va.Text));
                    }
                    else
                    {
                        verification.ShowError("Va");
                        return;
                    }

                    if (verification.CheckDouble(txtbx_settings_vs0))
                    {
                        root.Add(new XElement("Vs0", txtbx_settings_vs0.Text));
                    }
                    else
                    {
                        verification.ShowError("Vs0");
                        return;
                    }

                    if (verification.CheckDouble(txtbx_settings_vs1))
                    {
                        root.Add(new XElement("Vs1", txtbx_settings_vs1.Text));
                    }
                    else
                    {
                        verification.ShowError("Vs1");
                        return;
                    }

                    if (verification.CheckDouble(txtbx_settings_vfe))
                    {
                        root.Add(new XElement("Vfe", txtbx_settings_vfe.Text));
                    }
                    else
                    {
                        verification.ShowError("Vfe");
                        return;
                    }

                    if (verification.CheckDouble(txtbx_settings_hold_arm))
                    {
                        root.Add(new XElement("AftMomentArm", txtbx_settings_hold_arm.Text));
                    }
                    else
                    {
                        verification.ShowError("Aft Moment Arm");
                        return;
                    }

                    if (verification.CheckDouble(txtbx_settings_cabin_arm))
                    {
                        root.Add(new XElement("FwdMomentArm", txtbx_settings_cabin_arm.Text));
                    }
                    else
                    {
                        verification.ShowError("Fwd Moment Arm");
                        return;
                    }

                    if (verification.CheckDouble(txtbx_settings_aft_cg_limit))
                    {
                        root.Add(new XElement("AftCGLimit", txtbx_settings_aft_cg_limit.Text));
                    }
                    else
                    {
                        verification.ShowError("Aft CG Limit");
                        return;
                    }

                    if (verification.CheckDouble(txtbx_settings_fwd_cg_limit))
                    {
                        root.Add(new XElement("FwdCGLimit", txtbx_settings_fwd_cg_limit.Text));
                    }
                    else
                    {
                        verification.ShowError("Fwd CG Limit");
                        return;
                    }

                    if (verification.CheckDouble(txtbx_settings_max_fuel_vol))
                    {
                        root.Add(new XElement("MaxFuelVol", txtbx_settings_max_fuel_vol.Text));
                    }
                    else
                    {
                        verification.ShowError("Max Fuel Volume");
                        return;
                    }

                    if (verification.CheckDouble(txtbx_settings_min_fuel_vol))
                    {
                        root.Add(new XElement("MinFuelVol", txtbx_settings_min_fuel_vol.Text));
                    }
                    else
                    {
                        verification.ShowError("Min Fuel Volume");
                        return;
                    }


                    //root.Add(new XElement("aircraft_name", myAircraftName));
                    //root.Add(new XElement("MaxTakeOffWeight", txtbx_settings_mtow.Text));
                    //root.Add(new XElement("EmptyWeight", txtbx_settings_empty_weight.Text));
                    //root.Add(new XElement("MinPilotWeight", txtbx_settings_min_pilot_weight.Text));
                    //root.Add(new XElement("MaxWeightPerCrewMember", txtbx_settings_max_per_crew_weight.Text));
                    //root.Add(new XElement("MaxCockpitWeight", txtbx_settings_max_cockpit_weight.Text));
                    //root.Add(new XElement("MinCockpitWeight", txtbx_settings_min_cockpit_weight.Text));
                    //root.Add(new XElement("MaxWeightPerSeat", txtbx_settings_max_weight_per_seat.Text));
                    //root.Add(new XElement("MaxHoldBaggageWeight", txtbx_settings_max_hold_bag_weight.Text));
                    //root.Add(new XElement("MaxFuelVol", txtbx_settings_max_fuel_vol.Text));
                    //root.Add(new XElement("MinFuelVol", txtbx_settings_min_fuel_vol.Text));
                    //root.Add(new XElement("Vne", txtbx_settings_vne.Text));
                    //root.Add(new XElement("Va", txtbx_settings_va.Text));
                    //root.Add(new XElement("Vs0", txtbx_settings_vs0.Text));
                    //root.Add(new XElement("Vs1", txtbx_settings_vs1.Text));
                    //root.Add(new XElement("Vfe", txtbx_settings_vfe.Text));
                    //root.Add(new XElement("AftMomentArm", txtbx_settings_hold_arm.Text));
                    //root.Add(new XElement("FwdMomentArm", txtbx_settings_cabin_arm.Text));
                    //root.Add(new XElement("AftCGLimit", txtbx_settings_aft_cg_limit.Text));
                    //root.Add(new XElement("FwdCGLimit", txtbx_settings_fwd_cg_limit.Text));


                    doc.Element("compliance_data").Add(root);
                    doc.Save("compliance_data.xml");

                    PopulateComplianceDataCmboBx(myAircraftName);
                    cmbobx_aircraftName.SelectedIndex = cmbobx_aircraftName.Items.Count - 1;
                }
                else
                {
                    MsgBox.Show("1. Cannot add as named aircraft already exists\rChoose aircraft and use update" +
                                "\r\r2. The file compliance_data.xml is missing", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                MsgBox.Show("The aircraft needs to have a name, please try again", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GC.Collect();
        }

        private bool CheckIfAircraftNameExists(string myAircraftName)
        {
            bool result = true;

            XDocument doc = XDocument.Load("compliance_data.xml");

            var matches = doc
                .Descendants("aircraft_info")
                .Where(ft => ((string)ft.Element("aircraft_name")) == myAircraftName);

            if (matches.Count() == 0)
            {
                result = false;
            }

            return result;
        }

        private void btn_settings_delete_aircraft_Click(object sender, EventArgs e)
        {
            string myAircraftName = cmbobx_aircraftName.Text;

            if (DeleteData(myAircraftName, true))
            {
                PopulateComplianceDataCmboBx(myAircraftName);
                cmbobx_aircraftName.SelectedIndex = 0;
            }
        }

        private bool DeleteData(string myAircraftName, bool flag)
        {
            bool areYouSure = false;

            if (flag) //false if update button clicked
            {
                if (myAircraftName == "Default") //always keep Default aircraft
                {
                    MsgBox.Show("Cannot Delete aircraft called Default\rPlease try another aircraft name.",
                        "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                //create a dialog to ask if user is sure they want to delete aircraft
                var AreYouSureForm = new AreYouSure(myAircraftName);
                AreYouSureForm.ShowDialog();
                areYouSure = AreYouSureForm.areYouSureToDelete;
            }

            if (areYouSure) //Only delete is yes else ignore
            {
                // create the XML, load the contents
                XmlDocument doc = new XmlDocument();
                doc.Load("compliance_data.xml");

                string xQryStr = "//aircraft_info[aircraft_name ='" + myAircraftName + "']";

                XmlNode node = doc.SelectSingleNode(xQryStr);

                // if found....
                if (node != null)
                {
                    // get its parent node
                    XmlNode parent = node.ParentNode;

                    // remove the child node
                    parent.RemoveChild(node);

                    // verify the new XML structure
                    string newXML = doc.OuterXml;

                    // save to file
                    doc.Save(@"compliance_data.xml");
                }
            }

            return areYouSure;
        }

        private void btn_reset_compliance_xml_Click(object sender, EventArgs e)
        {
            if (MsgBox.Show("All data will revert to default\rYou will lose any aircraft you have entered", "Information",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (MsgBox.Show("Do you want to backup original files?",
                        "Information",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string ID = DateTime.Now.ToString("dd_MM_yy_H_mm_ss"); //Create a unique ID
                    File.Copy("compliance_data.xml", "Data_" + ID + ".xml"); //save file with unique ID
                }

                if (File.Exists("compliance_data.xml")) File.Delete("compliance_data.xml");
                File.WriteAllText("compliance_data.xml", Resources.compliance_data);
                PopulateComplianceDataCmboBx("Default");
                cmbobx_aircraftName.SelectedIndex = 0;
            }
        }

        private void btn_settings_update_aircraft_Click(object sender, EventArgs e)
        {
            if (cmbobx_aircraftName.Text != "Default")
            {
                // Get hold of the data because we will delete this node next
                string[] originalData = new string[20];

                originalData[0] = cmbobx_aircraftName.Text;
                originalData[1] = txtbx_settings_mtow.Text;
                originalData[2] = txtbx_settings_empty_weight.Text;
                originalData[3] = txtbx_settings_min_pilot_weight.Text;
                originalData[4] = txtbx_settings_max_per_crew_weight.Text;
                originalData[5] = txtbx_settings_max_cockpit_weight.Text;
                originalData[6] = txtbx_settings_min_cockpit_weight.Text;
                originalData[7] = txtbx_settings_max_weight_per_seat.Text;
                originalData[8] = txtbx_settings_max_hold_bag_weight.Text;
                originalData[9] = txtbx_settings_max_fuel_vol.Text;
                originalData[10] = txtbx_settings_min_fuel_vol.Text;
                originalData[11] = txtbx_settings_vne.Text;
                originalData[12] = txtbx_settings_va.Text;
                originalData[13] = txtbx_settings_vs0.Text;
                originalData[14] = txtbx_settings_vs1.Text;
                originalData[15] = txtbx_settings_vfe.Text;
                originalData[16] = txtbx_settings_hold_arm.Text;
                originalData[17] = txtbx_settings_cabin_arm.Text;
                originalData[18] = txtbx_settings_aft_cg_limit.Text;
                originalData[19] = txtbx_settings_fwd_cg_limit.Text;

                if (DeleteData(originalData[0], false)) //Delete the node
                {
                    //Re-add the node with stored information
                    XDocument doc = XDocument.Load("compliance_data.xml");
                    XElement root = new XElement("aircraft_info");

                    root.Add(new XElement("aircraft_name", originalData[0]));

                    if (verification.CheckDouble(originalData[1]))
                    {
                        root.Add(new XElement("MaxTakeOffWeight", originalData[1]));
                    }
                    else
                    {
                        verification.ShowError("Max Take Off Weight");
                        return;
                    }

                    if (verification.CheckDouble(originalData[2]))
                    {
                        root.Add(new XElement("EmptyWeight", originalData[2]));
                    }
                    else
                    {
                        verification.ShowError("EmptyWeight");
                        return;
                    }

                    if (verification.CheckDouble(originalData[3]))
                    {
                        root.Add(new XElement("MinPilotWeight", originalData[3]));
                    }
                    else
                    {
                        verification.ShowError("MinPilotWeight");
                        return;
                    }

                    if (verification.CheckDouble(originalData[4]))
                    {
                        root.Add(new XElement("MaxWeightPerCrewMember", originalData[4]));
                    }
                    else
                    {
                        verification.ShowError("MaxWeightPerCrewMember");
                        return;
                    }

                    if (verification.CheckDouble(originalData[5]))
                    {
                        root.Add(new XElement("MaxCockpitWeight", originalData[5]));
                    }
                    else
                    {
                        verification.ShowError("MaxCockpitWeight");
                        return;
                    }

                    if (verification.CheckDouble(originalData[6]))
                    {
                        root.Add(new XElement("MinCockpitWeight", originalData[6]));
                    }
                    else
                    {
                        verification.ShowError("MinCockpitWeight");
                        return;
                    }

                    if (verification.CheckDouble(originalData[7]))
                    {
                        root.Add(new XElement("MaxWeightPerSeat", originalData[7]));
                    }
                    else
                    {
                        verification.ShowError("MaxWeightPerSeat");
                        return;
                    }

                    if (verification.CheckDouble(originalData[8]))
                    {
                        root.Add(new XElement("MaxHoldBaggageWeight", originalData[8]));
                    }
                    else
                    {
                        verification.ShowError("MaxHoldBaggageWeight");
                        return;
                    }

                    if (verification.CheckDouble(originalData[9]))
                    {
                        root.Add(new XElement("MaxFuelVol", originalData[9]));
                    }
                    else
                    {
                        verification.ShowError("MaxFuelVol");
                        return;
                    }

                    if (verification.CheckDouble(originalData[10]))
                    {
                        root.Add(new XElement("MinFuelVol", originalData[10]));
                    }
                    else
                    {
                        verification.ShowError("MinFuelVol");
                        return;
                    }

                    if (verification.CheckDouble(originalData[11]))
                    {
                        root.Add(new XElement("Vne", originalData[11]));
                    }
                    else
                    {
                        verification.ShowError("Vne");
                        return;
                    }

                    if (verification.CheckDouble(originalData[12]))
                    {
                        root.Add(new XElement("Va", originalData[12]));
                    }
                    else
                    {
                        verification.ShowError("Va");
                        return;
                    }

                    if (verification.CheckDouble(originalData[13]))
                    {
                        root.Add(new XElement("Vs0", originalData[13]));
                    }
                    else
                    {
                        verification.ShowError("Vs0");
                        return;
                    }

                    if (verification.CheckDouble(originalData[14]))
                    {
                        root.Add(new XElement("Vs1", originalData[14]));
                    }
                    else
                    {
                        verification.ShowError("Vs1");
                        return;
                    }

                    if (verification.CheckDouble(originalData[15]))
                    {
                        root.Add(new XElement("Vfe", originalData[15]));
                    }
                    else
                    {
                        verification.ShowError("Vfe");
                        return;
                    }

                    if (verification.CheckDouble(originalData[16]))
                    {
                        root.Add(new XElement("AftMomentArm", originalData[16]));
                    }
                    else
                    {
                        verification.ShowError("AftMomentArm");
                        return;
                    }

                    if (verification.CheckDouble(originalData[17]))
                    {
                        root.Add(new XElement("FwdMomentArm", originalData[17]));
                    }
                    else
                    {
                        verification.ShowError("FwdMomentArm");
                        return;
                    }

                    if (verification.CheckDouble(originalData[18]))
                    {
                        root.Add(new XElement("AftCGLimit", originalData[18]));
                    }
                    else
                    {
                        verification.ShowError("AftCGLimit");
                        return;
                    }

                    if (verification.CheckDouble(originalData[19]))
                    {
                        root.Add(new XElement("FwdCGLimit", originalData[19]));
                    }
                    else
                    {
                        verification.ShowError("FwdCGLimit");
                        return;
                    }

                    doc.Element("compliance_data").Add(root);
                    doc.Save("compliance_data.xml");

                    PopulateComplianceDataCmboBx(originalData[0]); //rebuild the combobox

                    cmbobx_aircraftName.SelectedIndex = cmbobx_aircraftName.Items.Count - 1;
                }
            }
            else
            {
                MsgBox.Show("Cannot update aircraft called Default\rPlease try another aircraft name.",
                    "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
