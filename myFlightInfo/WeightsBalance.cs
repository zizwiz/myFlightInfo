using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;


namespace myFlightInfo
{
    public partial class Form1
    {
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (tabcnt_utils.SelectedTab == tab_weight_balance)
            {
                Calculate();
            }
        }


        private void btn_calc_cog_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        void Calculate()
        {
            /////////////////////////////////////////////////////////////////////////////////
            //Check if data is sensible doubles
            // We do not check if within range
            /////////////////////////////////////////////////////////////////////////////////

            if (!CheckDouble(txtbx_cog_pilot_weight)) { ShowError("Pilots Weight"); return; }
            if (!CheckDouble(txtbx_cog_passenger_weight)) { ShowError("Passengers Weight "); return; }
            if (!CheckDouble(txtbx_cog_cabin_bag_weight)) { ShowError("Cabin Bag Weight "); return; }
            if (!CheckDouble(txtbx_cog_hold_bag_weight)) { ShowError("Hold Bag Weight "); return; }
            if (!CheckDouble(txtbx_cog_accessories_weight)) { ShowError("Accessories Weight "); return; }
            if (!CheckDouble(txtbx_cog_pilot_arm)) { ShowError("Pilots Arm "); return; }
            if (!CheckDouble(txtbx_cog_passenger_arm)) { ShowError("Passengers Arm "); return; }
            if (!CheckDouble(txtbx_cog_cabin_bag_arm)) { ShowError("Cabin Bag Arm "); return; }
            if (!CheckDouble(txtbx_cog_hold_bag_arm)) { ShowError("Hold Bag Arm "); return; }
            if (!CheckDouble(txtbx_cog_accessories_arm)) { ShowError("Accessories Arm "); return; }
            if (!CheckDouble(txtbx_cog_takeoff_fuel)) { ShowError("Takeoff Fuel Volume "); return; }
            if (!CheckDouble(txtbx_cog_landing_fuel)) { ShowError("Landing Fuel Volume "); return; }
            if (!CheckDouble(txtbx_cog_zero_fuel)) { ShowError("Zero Fuel Volume "); return; }
            if (!CheckDouble(txtbx_specific_gravity)) { ShowError("Fuel Specific Gravity "); return; }
            if (!CheckDouble(txtbx_cog_fuel_arm)) { ShowError("Fuel Arm "); return; }

            /////////////////////////////////////////////////////////////////////////////////
            //Clear the CoG graphices
            ///////////////////////////////////////////////////////////////////////////////////
            ResetGraphics();

            /////////////////////////////////////////////////////////////////////////////////
            //Declare any variables
            /////////////////////////////////////////////////////////////////////////////////

            Double MaxTakeOffWeight = settings.MaxTakeOffWeight;
            Double EmptyAircraftWeight = settings.EmptyWeight;
            Double MinPilotWeight = settings.MinPilotWeight;
            Double MaxWeightPerCrewMember = settings.MaxWeightPerCrewMember;
            Double MaxCockpitWeight = settings.MaxCockpitWeight;
            Double MinCockpitWeight = settings.MinCockpitWeight;
            Double MaxWeightPerSeat = settings.MaxWeightPerSeat;
            Double MaxHoldBaggageWeight = settings.MaxHoldBaggageWeight;
            Double MaxFuelVol = settings.MaxFuelVol;
            Double MinFuelVol = settings.MinFuelVol;
            Double VneValue = settings.Vne;
            Double VaValue = settings.Va;
            Double Vs0Value = settings.Vs0;
            Double Vs1Value = settings.Vs1;
            Double VfeValue = settings.Vfe;
            Double AftMomentArm = settings.AftMomentArm;
            Double FwdMomentArm = settings.FwdMomentArm;
            Double AftCGLimit = settings.AftCGLimit;
            Double FwdCGLimit = settings.FwdCGLimit;


            /////////////////////////////////////////////////////////////////////////////////
            // clear report
            /////////////////////////////////////////////////////////////////////////////////
            rchtxtbx_cog_report.Text = "";


            /////////////////////////////////////////////////////////////////////////////////
            //if any item is empty then we put in min defaults
            /////////////////////////////////////////////////////////////////////////////////
            if (txtbx_cog_pilot_weight.Text == "") txtbx_cog_pilot_weight.Text = "0";
            if (txtbx_cog_passenger_weight.Text == "") txtbx_cog_passenger_weight.Text = "0";
            if (txtbx_cog_cabin_bag_weight.Text == "") txtbx_cog_cabin_bag_weight.Text = "0";
            if (txtbx_cog_hold_bag_weight.Text == "") txtbx_cog_hold_bag_weight.Text = "0";
            if (txtbx_cog_takeoff_fuel.Text == "") txtbx_cog_takeoff_fuel.Text = "0";
            if (txtbx_cog_landing_fuel.Text == "") txtbx_cog_landing_fuel.Text = "0";
            if (txtbx_cog_zero_fuel.Text == "") txtbx_cog_zero_fuel.Text = "0";

            if (txtbx_specific_gravity.Text == "") txtbx_specific_gravity.Text = "0.72";

            if (txtbx_cog_pilot_arm.Text == "") txtbx_cog_pilot_arm.Text = "400";
            if (txtbx_cog_passenger_arm.Text == "") txtbx_cog_passenger_arm.Text = "400";
            if (txtbx_cog_cabin_bag_arm.Text == "") txtbx_cog_cabin_bag_arm.Text = "400";
            if (txtbx_cog_hold_bag_arm.Text == "") txtbx_cog_hold_bag_arm.Text = "950";
            if (txtbx_cog_fuel_arm.Text == "") txtbx_cog_fuel_arm.Text = "950";


            /////////////////////////////////////////////////////////////////////////////////
            //Convert all data into doubles
            /////////////////////////////////////////////////////////////////////////////////

            double PilotsWeight = double.Parse(txtbx_cog_pilot_weight.Text);
            double PassengersWeight = double.Parse(txtbx_cog_passenger_weight.Text);
            double CabinBagWeight = double.Parse(txtbx_cog_cabin_bag_weight.Text);
            double HoldBagWeight = double.Parse(txtbx_cog_hold_bag_weight.Text);
            double AccessoriesWeight = double.Parse(txtbx_cog_accessories_weight.Text);

            double PilotsArm = double.Parse(txtbx_cog_pilot_arm.Text);
            double PassengersArm = double.Parse(txtbx_cog_passenger_arm.Text);
            double CabinBagArm = double.Parse(txtbx_cog_cabin_bag_arm.Text);
            double HoldBagArm = double.Parse(txtbx_cog_hold_bag_arm.Text);
            double AccessoriesArm = double.Parse(txtbx_cog_accessories_arm.Text);

            double TakeoffFuelVolume = double.Parse(txtbx_cog_takeoff_fuel.Text);
            double LandingFuelVolume = double.Parse(txtbx_cog_landing_fuel.Text);
            double ZeroFuelVolume = double.Parse(txtbx_cog_zero_fuel.Text);
            double SpecificGravity = Double.Parse(txtbx_specific_gravity.Text);
            double FuelArm = double.Parse(txtbx_cog_fuel_arm.Text);

            double TakeOffFuelWeight = TakeoffFuelVolume * SpecificGravity;
            double LandingFuelWeight = LandingFuelVolume * SpecificGravity;
            double ZeroFuelWeight = ZeroFuelVolume * SpecificGravity;

            /////////////////////////////////////////////////////////////////////////////////////////
            // workout all moments
            /////////////////////////////////////////////////////////////////////////////////////////
            double pilot_moment = PilotsWeight * PilotsArm;
            double passenger_moment = PassengersWeight * PassengersArm;
            double cabin_bag_moment = CabinBagWeight * CabinBagArm;
            double hold_bag_moment = HoldBagWeight * HoldBagArm;
            double Accessories_moment = AccessoriesWeight * AccessoriesArm;
            double takeoff_fuel_moment = TakeOffFuelWeight * FuelArm;
            double landing_fuel_moment = LandingFuelWeight * FuelArm;
            double zero_fuel_moment = ZeroFuelWeight * FuelArm;

            /////////////////////////////////////////////////////////////////////////////////////////
            // write all moments to UI
            /////////////////////////////////////////////////////////////////////////////////////////

            txtbx_fuel_weight.Text = TakeOffFuelWeight.ToString();

            txtbx_cog_pilot.Text = pilot_moment.ToString();
            txtbx_cog_passenger.Text = passenger_moment.ToString();
            txtbx_cog_cabin_baggage.Text = cabin_bag_moment.ToString();
            txtbx_cog_hold_baggage.Text = hold_bag_moment.ToString();
            txtbx_cog_accessories.Text = Accessories_moment.ToString();
            txtbx_cog_fuel.Text = takeoff_fuel_moment.ToString();

            /////////////////////////////////////////////////////////////////////////////////////////
            // workout total moment and weight and also write to UI
            /////////////////////////////////////////////////////////////////////////////////////////

            double TakeOffTotalWeight = PilotsWeight + PassengersWeight + CabinBagWeight + HoldBagWeight +
                                        TakeOffFuelWeight + AccessoriesWeight;
            double TakeOffTotalMoment = pilot_moment + passenger_moment + cabin_bag_moment + hold_bag_moment +
                                 takeoff_fuel_moment + Accessories_moment;

            txtbx_cog_total_weight.Text = TakeOffTotalWeight.ToString();
            txtbx_cog_total_moment.Text = TakeOffTotalMoment.ToString();

            double LandingTotalWeight = PilotsWeight + PassengersWeight + CabinBagWeight + HoldBagWeight +
                                        LandingFuelWeight + AccessoriesWeight;
            double LandingTotalMoment = pilot_moment + passenger_moment + cabin_bag_moment + hold_bag_moment +
                                 landing_fuel_moment + Accessories_moment;

            double ZeroTotalWeight = PilotsWeight + PassengersWeight + CabinBagWeight + HoldBagWeight +
                                        ZeroFuelWeight + AccessoriesWeight;
            double ZeroTotalMoment = pilot_moment + passenger_moment + cabin_bag_moment + hold_bag_moment +
                                      zero_fuel_moment + Accessories_moment;

            /////////////////////////////////////////////////////////////////////////////////////////
            // workout takeoff weight plus landing weight and zero fuel weight
            /////////////////////////////////////////////////////////////////////////////////////////

            double TakeOffWeight = TakeOffTotalWeight + EmptyAircraftWeight;
            double LandingWeight = LandingTotalWeight + EmptyAircraftWeight;
            double ZeroWeight = ZeroTotalWeight + EmptyAircraftWeight;

            double CabinWeight = PilotsWeight + PassengersWeight + CabinBagWeight;
            
            /////////////////////////////////////////////////////////////////////////////////////////
            // total landing moment and weight includes all fuel 
            /////////////////////////////////////////////////////////////////////////////////////////

            double TakeOffCoG = 0;
            if (TakeOffTotalWeight > 0) TakeOffCoG = Math.Round((TakeOffTotalMoment / TakeOffTotalWeight), 2);

            /////////////////////////////////////////////////////////////////////////////////////////
            // total landing moment and weight includes only landing fuel
            /////////////////////////////////////////////////////////////////////////////////////////
            double LandingCofG = 0;
            if (LandingTotalWeight > 0) LandingCofG = Math.Round((LandingTotalMoment / LandingTotalWeight), 2);

            /////////////////////////////////////////////////////////////////////////////////////////
            // total landing moment and weight includes zero fuel litres
            /////////////////////////////////////////////////////////////////////////////////////////
            double ZeroCofG = 0;
            if (ZeroTotalWeight > 0) ZeroCofG = Math.Round((ZeroTotalMoment / ZeroTotalWeight), 2);

            /////////////////////////////////////////////////////////////////////////////////////////
            // Here we create the report
            /////////////////////////////////////////////////////////////////////////////////////////

            rchtxtbx_cog_report.SelectionFont = new Font("Ariel", 12, FontStyle.Underline);
            rchtxtbx_cog_report.SelectionAlignment = HorizontalAlignment.Center;
            rchtxtbx_cog_report.AppendText("Weights and Balances Report\r" + DateTime.Now.ToString("f",
                CultureInfo.CreateSpecificCulture("en-GB")) + "\r");
            rchtxtbx_cog_report.SelectionAlignment = HorizontalAlignment.Left;

            //Draw Centre of Gravity lines to picture

            DrawLimitLines(FwdCGLimit, 0, 60, "FWD Limit", "Purple", false);
            DrawLimitLines(AftCGLimit, 0, AftCGLimit + 12, "AFT Limit", "Purple", false);

            //Centre of Gravity
            rchtxtbx_cog_report.AppendText("\rThe Centre of Gravity needs to be between " + FwdCGLimit +
                                           "mm and " + AftCGLimit + "mm for both take-off and landing");

            if ((TakeOffCoG > AftCGLimit) || (TakeOffCoG < FwdCGLimit))
            {
                rchtxtbx_cog_report.SelectionColor = Color.Red;
                rchtxtbx_cog_report.AppendText("\r\tTake-off CoG = " + TakeOffCoG + "mm = Outside aircraft limits");
                DrawLimitLines(TakeOffCoG, 70, TakeOffCoG + 12, "Takeoff CoG", "Red", true);
            }
            else
            {
                rchtxtbx_cog_report.SelectionColor = Color.Green;
                rchtxtbx_cog_report.AppendText("\r\tTake-off CoG = " + TakeOffCoG + "mm = OK");
                DrawLimitLines(TakeOffCoG, 70, TakeOffCoG + 12, "Takeoff CoG", "Green", true);
            }

            if ((LandingCofG > AftCGLimit) || (LandingCofG < FwdCGLimit))
            {
                rchtxtbx_cog_report.SelectionColor = Color.Red;
                rchtxtbx_cog_report.AppendText("\r\tLanding CoG = " + LandingCofG + "mm = Outside aircraft limits");
                DrawLimitLines(LandingCofG, 70, 60, "Landing CoG", "Red", true);
            }
            else
            {
                rchtxtbx_cog_report.SelectionColor = Color.Green;
                rchtxtbx_cog_report.AppendText("\r\tLanding CoG = " + LandingCofG + "mm = OK");
                DrawLimitLines(LandingCofG, 70, 60, "Landing CoG", "Green", true);
            }

            if ((ZeroCofG > AftCGLimit) || (ZeroCofG < FwdCGLimit))
            {
                rchtxtbx_cog_report.SelectionColor = Color.Red;
                rchtxtbx_cog_report.AppendText("\r\tZero CoG = " + ZeroCofG + "mm = Outside aircraft limits\r");
            }
            else
            {
                rchtxtbx_cog_report.SelectionColor = Color.Green;
                rchtxtbx_cog_report.AppendText("\r\tZero CoG = " + ZeroCofG + "mm = OK\r");
            }



            //Aircraft Weight
            rchtxtbx_cog_report.AppendText("\rMTOW needs to be between " + EmptyAircraftWeight + "kg and " + MaxTakeOffWeight + "kg");
            if (TakeOffWeight >= MaxTakeOffWeight)
            {
                rchtxtbx_cog_report.SelectionColor = Color.Red;
                rchtxtbx_cog_report.AppendText("\r\tTotal aircraft weight = " + TakeOffWeight + "kg = Overweight\r");
            }
            else
            {
                if (TakeOffWeight <= EmptyAircraftWeight)
                {
                    rchtxtbx_cog_report.SelectionColor = Color.Red;
                    rchtxtbx_cog_report.AppendText("\r\tTotal aircraft weight = " + TakeOffWeight + "kg = Underweight\r");
                }
                else
                {
                    rchtxtbx_cog_report.SelectionColor = Color.Green;
                    rchtxtbx_cog_report.AppendText("\r\tTotal aircraft weight = " + TakeOffWeight + "kg = OK\r");
                }
            }

            // Cabin Weight
            rchtxtbx_cog_report.AppendText("\rTotal cabin weight needs to be between " + MinCockpitWeight + "kg and " + MaxCockpitWeight + "kg");
            if ((CabinWeight <= MaxCockpitWeight) && (CabinWeight >= MinCockpitWeight))
            {
                rchtxtbx_cog_report.SelectionColor = Color.Green;
                rchtxtbx_cog_report.AppendText("\r\tTotal cabin weight = " + CabinWeight + "kg = OK\r");
            }
            else if (CabinWeight <= MinCockpitWeight)
            {
                rchtxtbx_cog_report.SelectionColor = Color.Red;
                rchtxtbx_cog_report.AppendText("\r\tTotal cabin weight = " + CabinWeight + "kg = Underweight\r");
            }
            else
            {
                rchtxtbx_cog_report.SelectionColor = Color.Red;
                rchtxtbx_cog_report.AppendText("\r\tTotal cabin weight = " + CabinWeight + "kg = Overweight\r");
            }

            //Pilot Weight
            if (PilotsWeight <= MaxWeightPerSeat)
            {
                if ((PilotsWeight < MinPilotWeight) && (PassengersWeight == 0))
                {

                    rchtxtbx_cog_report.AppendText("\rSolo pilot weight needs to be between " + MinPilotWeight + "kg and " + MaxWeightPerSeat + "kg");
                    rchtxtbx_cog_report.SelectionColor = Color.Red;
                    rchtxtbx_cog_report.AppendText("\r\tSolo pilots weight = " + PilotsWeight + "kg = Underweight\r");
                }
                else
                {
                    rchtxtbx_cog_report.AppendText("\rPilot weight needs to be <= " + MaxWeightPerSeat + "kg");
                    rchtxtbx_cog_report.SelectionColor = Color.Green;
                    rchtxtbx_cog_report.AppendText("\r\tPilots weight = " + PilotsWeight + "kg = OK\r");
                }
            }
            else
            {
                rchtxtbx_cog_report.AppendText("\rPilot weight needs to be <= " + MaxWeightPerSeat + "kg");
                rchtxtbx_cog_report.SelectionColor = Color.Red;
                rchtxtbx_cog_report.AppendText("\r\tPilots weight = " + PilotsWeight + "kg = Overweight\r");
            }

            //Passenger Weight
            if (PassengersWeight == 0)
            {
                rchtxtbx_cog_report.AppendText("\rNo passenger on flight\r");
            }
            else
            {
                rchtxtbx_cog_report.AppendText("\rPassenger weight needs to be <= " + MaxWeightPerSeat + "kg");
                if (PassengersWeight <= MaxWeightPerSeat)
                {
                    rchtxtbx_cog_report.SelectionColor = Color.Green;
                    rchtxtbx_cog_report.AppendText("\r\tPassenger weight = " + PassengersWeight + "kg = OK\r");
                }
                else
                {
                    rchtxtbx_cog_report.SelectionColor = Color.Red;
                    rchtxtbx_cog_report.AppendText("\r\tPassenger weight = " + PassengersWeight + "kg = Overweight\r");
                }
            }

            //Fuel Volume
            if (TakeoffFuelVolume <= MinFuelVol)
            {
                rchtxtbx_cog_report.SelectionColor = Color.Red;
                rchtxtbx_cog_report.AppendText("\r\tFuel volume = " + TakeoffFuelVolume + "ℓ = too low for safe outing\r");
            }
            else
            {
                rchtxtbx_cog_report.AppendText("\rFuel volume needs to be between " + MinFuelVol + "ℓ and " + MaxFuelVol + "ℓ");
                if (TakeoffFuelVolume <= MaxFuelVol)
                {
                    rchtxtbx_cog_report.SelectionColor = Color.Green;
                    rchtxtbx_cog_report.AppendText("\r\tFuel volume = " + TakeoffFuelVolume + "ℓ = OK\r");
                }
                else
                {
                    rchtxtbx_cog_report.SelectionColor = Color.Red;
                    rchtxtbx_cog_report.AppendText("\r\tFuel volume = " + TakeoffFuelVolume + "ℓ = Overfull\r");
                }
            }

            //Hold baggage Weight
            if (HoldBagWeight == 0)
            {
                rchtxtbx_cog_report.AppendText("\rNo hold baggage on flight\r");
            }
            else
            {
                rchtxtbx_cog_report.AppendText("\rTotal hold baggage weight needs to be <= " + MaxHoldBaggageWeight + "kg");
                if (HoldBagWeight <= MaxHoldBaggageWeight)
                {
                    rchtxtbx_cog_report.SelectionColor = Color.Green;
                    rchtxtbx_cog_report.AppendText("\r\tTotal hold baggage weight = " + HoldBagWeight + "kg = OK\r");
                }
                else
                {
                    rchtxtbx_cog_report.SelectionColor = Color.Red;
                    rchtxtbx_cog_report.AppendText("\r\tTotal hold baggage weight = " + HoldBagWeight + "kg = Overweight\r");
                }
            }
        }

        private void btn_cog_clear_report_Click(object sender, EventArgs e)
        {
            txtbx_cog_pilot_weight.Text = txtbx_cog_passenger_weight.Text = txtbx_cog_cabin_bag_weight.Text =
                txtbx_cog_hold_bag_weight.Text = txtbx_cog_takeoff_fuel.Text = txtbx_cog_zero_fuel.Text = "0";

            txtbx_cog_pilot_arm.Text = txtbx_cog_passenger_arm.Text = txtbx_cog_cabin_bag_arm.Text = settings.FwdMomentArm.ToString();

            txtbx_cog_hold_bag_arm.Text = txtbx_cog_fuel_arm.Text = settings.AftMomentArm.ToString();

            txtbx_cog_landing_fuel.Text = settings.MinFuelVol.ToString();
            txtbx_specific_gravity.Text = "0.72";

            txtbx_cog_pilot.Text = txtbx_cog_passenger.Text = txtbx_cog_cabin_baggage.Text =
                txtbx_cog_hold_baggage.Text = txtbx_cog_fuel.Text = txtbx_cog_total_weight.Text =
                    txtbx_fuel_weight.Text = "";

            // clear report
            rchtxtbx_cog_report.Text = "";

            ResetGraphics();
        }

        private void ResetGraphics()
        {
            //clear picture of lines but replace the aircraft
            picbx_cog_limits.Image = null;
            picbx_cog_limits.Invalidate();
            picbx_cog_limits.Image = Properties.Resources.c42_sideview;
        }

        private void DrawLimitLines(double xStart, double yStart, double textStart, string text, string colour, bool bottom)
        {
            //Set text startpoint
            double byStart = yStart;
            if (bottom) byStart += 33;
            
            Application.DoEvents();
            Graphics g = picbx_cog_limits.CreateGraphics();

            //We now choose to draw a line, you can draw many other things like square circle etc.
            //All the parameters come from the UI

            g.DrawLine(new Pen(Color.FromName(colour)),
                        (float)xStart / 3, (float)yStart,
                        (float)xStart / 3, (float)yStart + 50);

            using (Font myFont = new Font("Arial", 14))
            {
                g.DrawString(text, myFont, new SolidBrush((Color)new ColorConverter().ConvertFrom(colour)), new Point((int)textStart / 3, (int)byStart));
            }
            
            // g.DrawString(text, myFont, Brushes.Green, new Point((int)textStart / 3, (int)byStart));
        }
    }
}
