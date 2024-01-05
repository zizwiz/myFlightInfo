using System;
using System.Drawing;


namespace myFlightInfo
{
    public partial class Form1
    {

        private void btn_calc_cog_Click(object sender, EventArgs e)
        {
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
            Double VneValue = settings.Vne;
            Double VaValue= settings.Va;
            Double Vs0Value= settings.Vs0;
            Double Vs1Value= settings.Vs1;
            Double VfeValue = settings.Vfe;
            Double AftMomentArm = settings.AftMomentArm;
            Double FwdMomentArm = settings.FwdMomentArm;
            Double AftCGLimit = settings.AftCGLimit;
            Double FwdCGLimit = settings.FwdCGLimit;


            /////////////////////////////////////////////////////////////////////////////////
            // clear report
            /////////////////////////////////////////////////////////////////////////////////
            rchtxtbx_cog_report.Text = "";
            string TakeOffColour = "green";
            string LandingColour = "green";
            string ZeroColour = "green";

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

            lbl_fuel_weight.Text = TakeOffFuelWeight.ToString();

            lbl_cog_pilot.Text = pilot_moment.ToString();
            lbl_cog_passenger.Text = passenger_moment.ToString();
            lbl_cog_cabin_baggage.Text = cabin_bag_moment.ToString();
            lbl_cog_hold_baggage.Text = hold_bag_moment.ToString();
            lbl_cog_accessories.Text = Accessories_moment.ToString();
            lbl_cog_fuel.Text = takeoff_fuel_moment.ToString();

            /////////////////////////////////////////////////////////////////////////////////////////
            // workout total moment and weight and also write to UI
            /////////////////////////////////////////////////////////////////////////////////////////

            double TakeOffTotalWeight = PilotsWeight + PassengersWeight + CabinBagWeight + HoldBagWeight +
                                        TakeOffFuelWeight + AccessoriesWeight;
            double TakeOffTotalMoment = pilot_moment + passenger_moment + cabin_bag_moment + hold_bag_moment +
                                 takeoff_fuel_moment + Accessories_moment;

            lbl_cog_total_weight.Text = TakeOffTotalWeight.ToString();
            lbl_cog_total_moment.Text = TakeOffTotalMoment.ToString();

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
            // Are we within limits to takeoff and land. what about zero fuel? 
            /////////////////////////////////////////////////////////////////////////////////////////

            lbl_cog_take_off.Text = lbl_cog_landing.Text = "";


            /////////////////////////////////////////////////////////////////////////////////////////
            // total landing moment and weight includes all fuel 
            /////////////////////////////////////////////////////////////////////////////////////////
            double TakeOffCoG = Math.Round((TakeOffTotalMoment / TakeOffTotalWeight), 2);

            /////////////////////////////////////////////////////////////////////////////////////////
            // total landing moment and weight includes only landing fuel
            /////////////////////////////////////////////////////////////////////////////////////////
            double LandingCofG = Math.Round((LandingTotalMoment / LandingTotalWeight), 2);

            /////////////////////////////////////////////////////////////////////////////////////////
            // total landing moment and weight includes zero fuel litres
            /////////////////////////////////////////////////////////////////////////////////////////
            double ZeroCofG = Math.Round((ZeroTotalMoment / ZeroTotalWeight), 2);

            /////////////////////////////////////////////////////////////////////////////////////////
            // Are we within limits if not then label will be red
            /////////////////////////////////////////////////////////////////////////////////////////
            if ((TakeOffCoG > 560) || (TakeOffCoG < 350)) TakeOffColour = "red";
            if ((LandingCofG > 560) || (LandingCofG < 350)) LandingColour = "red";
            if ((ZeroCofG > 560) || (ZeroCofG < 350)) ZeroColour = "red";

            lbl_cog_take_off.Text = "Take-off = " + TakeOffCoG + "mm";
            lbl_cog_take_off.ForeColor = Color.FromName(TakeOffColour);

            lbl_cog_landing.Text = "Landing = " + LandingCofG + "mm";
            lbl_cog_landing.ForeColor = Color.FromName(LandingColour);

            lbl_cog_zero.Text = "Zero = " + ZeroCofG + "mm";
            lbl_cog_zero.ForeColor = Color.FromName(ZeroColour);



            /////////////////////////////////////////////////////////////////////////////////////////
            // Here we create the report
            /////////////////////////////////////////////////////////////////////////////////////////


            //Aircraft Weight
            rchtxtbx_cog_report.AppendText("\rMTOW needs to be < 450kg");
            if (TakeOffWeight > 450)
            {
                rchtxtbx_cog_report.AppendText("\rTotal aircraft weight = " + TakeOffWeight + "kg = Overweight\r");
            }
            else
            {
                if (TakeOffWeight < 258)
                {
                    rchtxtbx_cog_report.AppendText("\rTotal aircraft weight = " + TakeOffWeight + "kg = Underweight\r");
                }
                else
                {
                    rchtxtbx_cog_report.AppendText("\rTotal aircraft weight = " + TakeOffWeight + "kg = OK\r");
                }
            }

            // Cabin Weight
            rchtxtbx_cog_report.AppendText("\rTotal cabin weight needs to be between 55kg and 172kg");
            if ((CabinWeight < 172) && (CabinWeight > 55))
            {
                rchtxtbx_cog_report.AppendText("\rTotal cabin weight = " + CabinWeight + "kg = OK\r");
            }
            else if (CabinWeight < 55)
            {
                rchtxtbx_cog_report.AppendText("\rTotal cabin weight = " + CabinWeight + "kg = Underweight\r");
            }
            else
            {
                rchtxtbx_cog_report.AppendText("\rTotal cabin weight = " + CabinWeight + "kg = Overweight\r");
            }

            //Pilot Weight
            if (PilotsWeight < 120)
            {
                if ((PilotsWeight < 55) && (PassengersWeight == 0))
                {
                    rchtxtbx_cog_report.AppendText("\rSolo pilot weight needs to be between 55kg and 120kg");
                    rchtxtbx_cog_report.AppendText("\rSolo pilots weight = " + PilotsWeight + "kg = Underweight\r");
                }
                else
                {
                    rchtxtbx_cog_report.AppendText("\rPilot weight needs to be < 120kg");
                    rchtxtbx_cog_report.AppendText("\rPilots weight = " + PilotsWeight + "kg = OK\r");
                }
            }
            else
            {
                rchtxtbx_cog_report.AppendText("\rPilot weight needs to be < 120kg");
                rchtxtbx_cog_report.AppendText("\rPilots weight = " + PilotsWeight + "kg = Overweight\r");
            }

            //Passenger Weight
            if (PassengersWeight == 0)
            {
                rchtxtbx_cog_report.AppendText("\rNo passenger on flight\r");
            }
            else
            {
                rchtxtbx_cog_report.AppendText("\rPassenger weight needs to be < 120kg");
                if (PassengersWeight < 120)
                {
                    rchtxtbx_cog_report.AppendText("\rPassenger weight = " + PassengersWeight + "kg = OK\r");
                }
                else
                {
                    rchtxtbx_cog_report.AppendText("\rPassenger weight = " + PassengersWeight + "kg = Overweight\r");
                }
            }

            //Fuel Volume
            if (TakeoffFuelVolume < 10)
            {
                rchtxtbx_cog_report.AppendText("\rFuel volume = " + TakeoffFuelVolume + "ℓ = too low for safe outing\r");
            }
            else
            {
                rchtxtbx_cog_report.AppendText("\rFuel volume needs to be < 65ℓ");
                if (TakeoffFuelVolume < 65)
                {
                    rchtxtbx_cog_report.AppendText("\rFuel volume = " + TakeoffFuelVolume + "ℓ = OK\r");
                }
                else
                {
                    rchtxtbx_cog_report.AppendText("\rFuel volume = " + TakeoffFuelVolume + "ℓ = Overfull\r");
                }
            }

            //Hold baggage Weight
            if (HoldBagWeight == 0)
            {
                rchtxtbx_cog_report.AppendText("\rNo hold baggage on flight\r");
            }
            else
            {
                rchtxtbx_cog_report.AppendText("\rTotal hold baggage weight needs to be < 10kg");
                if (HoldBagWeight < 10)
                {
                    rchtxtbx_cog_report.AppendText("\rTotal hold baggage weight = " + HoldBagWeight + "kg = OK\r");
                }
                else
                {
                    rchtxtbx_cog_report.AppendText("\rTotal hold baggage weight = " + HoldBagWeight + "kg = Overweight\r");
                }
            }





            //chrt_cog.Series.Add("takeoff");
            //chrt_cog.Series["takeoff"].ChartType = SeriesChartType.Point;
            //chrt_cog.Series["takeoff"].Color = Color.Chartreuse;
            //chrt_cog.Series["takeoff"].Points.AddXY(1,0);


            //chrt_cog.Series["cog"].Points.AddXY(4, 0);
            //chrt_cog.Series["cog"].Points.AddXY(6, 0);
            //chrt_cog.Series["cog"].Points.AddXY(2, 0);
            //chrt_cog.Series["cog"].Points.AddXY(3, 0);


            //chrt_cog.Series["default"].Color=Color.Black;

            //chrt_cog.Series["default"].Points.AddXY(4, 0);
            //chrt_cog.Series["default"].Points.AddXY(6, 0);


        }

        /*
           
            private void btn_cog_reset_Click(object sender, EventArgs e)
        {
            txtbx_cog_pilot_weight.Text = txtbx_cog_passenger_weight.Text = txtbx_cog_cabin_bag_weight.Text =
                txtbx_cog_hold_bag_weight.Text = txtbx_cog_takeoff_fuel.Text = txtbx_cog_zero_fuel.Text = "0";

            txtbx_cog_pilot_arm.Text = txtbx_cog_passenger_arm.Text = txtbx_cog_cabin_bag_arm.Text = "400";

            txtbx_cog_hold_bag_arm.Text = txtbx_cog_fuel_arm.Text = "950";

            txtbx_cog_landing_fuel.Text = "10";
            txtbx_specific_gravity.Text = "0.72";

            lbl_cog_pilot.Text = lbl_cog_passenger.Text = lbl_cog_cabin_baggage.Text =
                lbl_cog_hold_baggage.Text = lbl_cog_fuel.Text = lbl_cog_total_weight.Text =
                    lbl_cog_take_off.Text = lbl_cog_landing.Text = lbl_cog_zero.Text =
                        lbl_fuel_weight.Text = "";

            lbl_cog_take_off.ForeColor = lbl_cog_landing.ForeColor = lbl_cog_zero.ForeColor = Color.Black;

            // clear report
            rchtxtbx_cog_report.Text = "";
           */
    }
}
