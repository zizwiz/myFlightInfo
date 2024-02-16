using System;
using myFlightInfo.common_data;


namespace myFlightInfo
{
    public partial class Form1
    {
        private void btn_save_settings_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void btn_settings_defaults_Click(object sender, EventArgs e)
        {
            DefaultSettings();
        }

        private void SaveSettings()
        {
            settings.Aircraft = cmbobx_aircraftName.Text;

            if (verification.CheckDouble(txtbx_settings_mtow))
            {
                settings.MaxTakeOffWeight = double.Parse(txtbx_settings_mtow.Text);
            }
            else
            {
                verification.ShowError("Max Take Off Weight");
                return;
            }

            if (verification.CheckDouble(txtbx_settings_empty_weight))
            {
                settings.EmptyWeight = double.Parse(txtbx_settings_empty_weight.Text);
            }
            else
            {
                verification.ShowError("Empty Weight");
                return;
            }

            if (verification.CheckDouble(txtbx_settings_min_pilot_weight))
            {
                settings.MinPilotWeight = double.Parse(txtbx_settings_min_pilot_weight.Text);
            }
            else
            {
                verification.ShowError("Min Pilot Weight");
                return;
            }

            if (verification.CheckDouble(txtbx_settings_max_per_crew_weight))
            {
                settings.MaxWeightPerCrewMember = double.Parse(txtbx_settings_max_per_crew_weight.Text);
            }
            else
            {
                verification.ShowError("Max Weight Per Crew Member");
                return;
            }

            if (verification.CheckDouble(txtbx_settings_max_cockpit_weight))
            {
                settings.MaxCockpitWeight = double.Parse(txtbx_settings_max_cockpit_weight.Text);
            }
            else
            {
                verification.ShowError("Max Cockpit Weight");
                return;
            }

            if (verification.CheckDouble(txtbx_settings_min_cockpit_weight))
            {
                settings.MinCockpitWeight = double.Parse(txtbx_settings_min_cockpit_weight.Text);
            }
            else
            {
                verification.ShowError("Min Cockpit Weight");
                return;
            }

            if (verification.CheckDouble(txtbx_settings_max_weight_per_seat))
            {
                settings.MaxWeightPerSeat = double.Parse(txtbx_settings_max_weight_per_seat.Text);
            }
            else
            {
                verification.ShowError("Max Weight Per Seat");
                return;
            }

            if (verification.CheckDouble(txtbx_settings_max_hold_bag_weight))
            {
                settings.MaxHoldBaggageWeight = double.Parse(txtbx_settings_max_hold_bag_weight.Text);
            }
            else
            {
                verification.ShowError("Max Hold Baggage Weight");
                return;
            }

            if (verification.CheckDouble(txtbx_settings_vne))
            {
                settings.Vne = double.Parse(txtbx_settings_vne.Text);
            }
            else
            {
                verification.ShowError("Vne");
                return;
            }

            if (verification.CheckDouble(txtbx_settings_va))
            {
                settings.Va = double.Parse(txtbx_settings_va.Text);
            }
            else
            {
                verification.ShowError("Va");
                return;
            }

            if (verification.CheckDouble(txtbx_settings_vs0))
            {
                settings.Vs0 = double.Parse(txtbx_settings_vs0.Text);
            }
            else
            {
                verification.ShowError("Vs0");
                return;
            }

            if (verification.CheckDouble(txtbx_settings_vs1))
            {
                settings.Vs1 = double.Parse(txtbx_settings_vs1.Text);
            }
            else
            {
                verification.ShowError("Vs1");
                return;
            }

            if (verification.CheckDouble(txtbx_settings_vfe))
            {
                settings.Vfe = double.Parse(txtbx_settings_vfe.Text);
            }
            else
            {
                verification.ShowError("Vfe");
                return;
            }

            if (verification.CheckDouble(txtbx_settings_hold_arm))
            {
                settings.AftMomentArm = double.Parse(txtbx_settings_hold_arm.Text);
            }
            else
            {
                verification.ShowError("Aft Moment Arm");
                return;
            }

            if (verification.CheckDouble(txtbx_settings_cabin_arm))
            {
                settings.FwdMomentArm = double.Parse(txtbx_settings_cabin_arm.Text);
            }
            else
            {
                verification.ShowError("Fwd Moment Arm");
                return;
            }

            if (verification.CheckDouble(txtbx_settings_aft_cg_limit))
            {
                settings.AftCGLimit = double.Parse(txtbx_settings_aft_cg_limit.Text);
            }
            else
            {
                verification.ShowError("Aft CG Limit");
                return;
            }

            if (verification.CheckDouble(txtbx_settings_fwd_cg_limit))
            {
                settings.FwdCGLimit = double.Parse(txtbx_settings_fwd_cg_limit.Text);
            }
            else
            {
                verification.ShowError("Fwd CG Limit");
                return;
            }

            if (verification.CheckDouble(txtbx_settings_max_fuel_vol))
            {
                settings.MaxFuelVol = double.Parse(txtbx_settings_max_fuel_vol.Text);
            }
            else
            {
                verification.ShowError("Max Fuel Volume");
                return;
            }

            if (verification.CheckDouble(txtbx_settings_min_fuel_vol))
            {
                settings.MinFuelVol = double.Parse(txtbx_settings_min_fuel_vol.Text);
            }
            else
            {
                verification.ShowError("Min Fuel Volume");
                return;
            }

            settings.Save();

            ResetweightsAndBalances();
        }

        //private void ShowError(string myError)
        //{
        //    MsgBox.Show("Check as value in " + myError + " is not correct", "Error", MessageBoxButtons.OK,
        //        MessageBoxIcon.Error);
        //}

        private void DefaultSettings()
        {
            cmbobx_aircraftName.SelectedIndex = 0;
            txtbx_settings_mtow.Text = "450";
            txtbx_settings_empty_weight.Text = "268";
            txtbx_settings_min_pilot_weight.Text = "55";
            txtbx_settings_max_per_crew_weight.Text = "120";
            txtbx_settings_max_cockpit_weight.Text = "172";
            txtbx_settings_min_cockpit_weight.Text = "55";
            txtbx_settings_max_weight_per_seat.Text = "120";
            txtbx_settings_max_hold_bag_weight.Text = "10";
            txtbx_settings_vne.Text = "121";
            txtbx_settings_va.Text = "82";
            txtbx_settings_vs0.Text = "32";
            txtbx_settings_vs1.Text = "41";
            txtbx_settings_vfe.Text = "63";
            txtbx_settings_hold_arm.Text = "950";
            txtbx_settings_cabin_arm.Text = "400";
            txtbx_settings_aft_cg_limit.Text = "560";
            txtbx_settings_fwd_cg_limit.Text = "350";
            txtbx_settings_max_fuel_vol.Text = "65";
            txtbx_settings_min_fuel_vol.Text = "10";

            SaveSettings();
           
        }

        private void GetSettings()
        {
            cmbobx_aircraftName.Text = settings.Aircraft;
            txtbx_settings_mtow.Text = settings.MaxTakeOffWeight.ToString();
            txtbx_settings_empty_weight.Text = settings.EmptyWeight.ToString();
            txtbx_settings_min_pilot_weight.Text = settings.MinPilotWeight.ToString();
            txtbx_settings_max_per_crew_weight.Text = settings.MaxWeightPerCrewMember.ToString();
            txtbx_settings_max_cockpit_weight.Text = settings.MaxCockpitWeight.ToString();
            txtbx_settings_min_cockpit_weight.Text = settings.MinCockpitWeight.ToString();
            txtbx_settings_max_weight_per_seat.Text = settings.MaxWeightPerSeat.ToString();
            txtbx_settings_max_hold_bag_weight.Text = settings.MaxHoldBaggageWeight.ToString();

            txtbx_settings_max_fuel_vol.Text = settings.MaxFuelVol.ToString();
            txtbx_settings_min_fuel_vol.Text = settings.MinFuelVol.ToString();

            txtbx_settings_vne.Text = settings.Vne.ToString();
            txtbx_settings_va.Text = settings.Va.ToString();
            txtbx_settings_vs0.Text = settings.Vs0.ToString();
            txtbx_settings_vs1.Text = settings.Vs1.ToString();
            txtbx_settings_vfe.Text = settings.Vfe.ToString();

            txtbx_cog_fuel_arm.Text = txtbx_cog_hold_bag_arm.Text =
                txtbx_settings_hold_arm.Text = settings.AftMomentArm.ToString();

            txtbx_cog_pilot_arm.Text = txtbx_cog_passenger_arm.Text = txtbx_cog_cabin_bag_arm.Text =
                txtbx_settings_cabin_arm.Text = settings.FwdMomentArm.ToString();


            txtbx_settings_aft_cg_limit.Text = settings.AftCGLimit.ToString();
            txtbx_settings_fwd_cg_limit.Text = settings.FwdCGLimit.ToString();

        }
    }
}