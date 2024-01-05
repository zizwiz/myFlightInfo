using System;

namespace myFlightInfo.CentreOfGravity
{
    class WorkOutCofG
    {

        public static (string, string, string, string, string, string, string, string, string, string, string,
            string, string, string, bool, bool, bool, bool, bool, bool, bool)
            CalculateCofG(
                string pilot_weight, string pilot_arm,
                string passenger_weight, string passenger_arm,
                string cabin_bag_weight, string cabin_bag_arm,
                string hold_bag_weight, string hold_bag_arm,
                string takeoff_fuel_volume, string fuel_arm,
                string landing_fuel_volume, string zero_fuel_volume,
                string specific_gravity)
        {
            string TakeOffColour = "green";
            string LandingColour = "green";
            string ZeroColour = "green";

            double PilotWeight = Double.Parse(pilot_weight);
            double PassengerWeight = Double.Parse(passenger_weight);
            double CabinBagWeight = Double.Parse(cabin_bag_weight);
            double HoldBagWeight = Double.Parse(hold_bag_weight);
            double FuelVolume = Double.Parse(takeoff_fuel_volume);

            /////////////////////////////////////////////////////////////////////////////////////////
            // workout fuel weight
            /////////////////////////////////////////////////////////////////////////////////////////
            double sg = Double.Parse(specific_gravity);
            double takeoff_fuel_weight = FuelVolume * sg;
            double Landing_fuel_weight = Double.Parse(landing_fuel_volume) * sg;
            double zero_weight = Double.Parse(zero_fuel_volume) * sg;

            /////////////////////////////////////////////////////////////////////////////////////////
            // workout all moments
            /////////////////////////////////////////////////////////////////////////////////////////
            string pilot_moment = (PilotWeight * Double.Parse(pilot_arm)).ToString();
            string passenger_moment = (PassengerWeight * Double.Parse(passenger_arm)).ToString();
            string cabin_bag_moment = (CabinBagWeight * Double.Parse(cabin_bag_arm)).ToString();
            string hold_bag_moment = (HoldBagWeight * Double.Parse(hold_bag_arm)).ToString();
            string fuel_moment = (takeoff_fuel_weight * Double.Parse(fuel_arm)).ToString();

            // workout total moment and total weight minus the fuel
            double cog_moment = Double.Parse(pilot_moment) + Double.Parse(passenger_moment)
                                                           + Double.Parse(cabin_bag_moment) +
                                                           Double.Parse(hold_bag_moment);


            double cog_weight = PilotWeight + PassengerWeight + CabinBagWeight + HoldBagWeight;

            /////////////////////////////////////////////////////////////////////////////////////////
            // total take-off moment and weight includes fuel
            /////////////////////////////////////////////////////////////////////////////////////////
            string Total_Moment = (cog_moment + Double.Parse(fuel_moment)).ToString();
            string Total_Weight = (cog_weight + takeoff_fuel_weight).ToString();

            /////////////////////////////////////////////////////////////////////////////////////////
            // total landing moment and weight includes all fuel 
            /////////////////////////////////////////////////////////////////////////////////////////
            double tow_cog = Math.Round(Double.Parse(Total_Moment) / Double.Parse(Total_Weight), 2);

            /////////////////////////////////////////////////////////////////////////////////////////
            // total landing moment and weight includes only landing fuel
            /////////////////////////////////////////////////////////////////////////////////////////
            double lw_cog = Math.Round((cog_moment + (Landing_fuel_weight * 950)) / (cog_weight + Landing_fuel_weight),
                2);

            /////////////////////////////////////////////////////////////////////////////////////////
            // total landing moment and weight includes zero fuel litres
            /////////////////////////////////////////////////////////////////////////////////////////
            double zero_cog = Math.Round((cog_moment + (zero_weight * 950)) / (cog_weight + zero_weight), 2);

            /////////////////////////////////////////////////////////////////////////////////////////
            // Are we within limits if not then lable will be red
            /////////////////////////////////////////////////////////////////////////////////////////
            if ((tow_cog > 560) || (tow_cog < 350))
            {
                TakeOffColour = "red";
            }

            if ((lw_cog > 560) || (lw_cog < 350))
            {
                LandingColour = "red";
            }

            if ((zero_cog > 560) || (zero_cog < 350))
            {
                ZeroColour = "red";
            }

            /////////////////////////////////////////////////////////////////////////////////////////
            // check if overweight
            // Pilot, Passenger, Cabin Weight, Hold Bag, Fuel, Aircraft
            /////////////////////////////////////////////////////////////////////////////////////////
            //PilotWeight
            //PassengerWeight
            //CabinBagWeight
            //HoldBagWeight
            //takeoff_fuel_weight
            //FuelVolume
            bool pilotUnderweight = false;

            bool aircraftOverweight = (PilotWeight + PassengerWeight + CabinBagWeight + HoldBagWeight + takeoff_fuel_weight + 258) > 450;
            bool CabinOverweight = (PilotWeight + PassengerWeight + CabinBagWeight) > 220;
            bool pilotOverweight = PilotWeight > 120;
            bool passengerOverweight = PassengerWeight > 120;
            bool FuelOvervolume = FuelVolume > 65;
            bool HoldbagOverweight = CabinBagWeight > 10;


            if (PassengerWeight == 0) {pilotUnderweight = PilotWeight < 55; }

            
        /////////////////////////////////////////////////////////////////////////////////////////
        // Return values
        /////////////////////////////////////////////////////////////////////////////////////////
        return (pilot_moment, passenger_moment, cabin_bag_moment, hold_bag_moment, fuel_moment, Total_Weight,
                Total_Moment, TakeOffColour, LandingColour, tow_cog.ToString(), lw_cog.ToString(), 
                takeoff_fuel_weight.ToString(), ZeroColour, zero_cog.ToString(),
                aircraftOverweight, CabinOverweight, pilotOverweight, passengerOverweight,  
                FuelOvervolume, HoldbagOverweight, pilotUnderweight
                );
        }

    }
}
