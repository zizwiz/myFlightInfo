using System;

namespace myFlightInfo.take_off_landing
{
    class weight_factor
    {
        public static double WorkOutWeightFactor(double baseWeight, double ladenWeight, int type)
        {
            double baseWeightPercentage = baseWeight / 10;
            double factor = 1.2; //10% increase in weight : Takeoff

            double myWeight = Math.Ceiling(ladenWeight - baseWeight / baseWeightPercentage);



            if (type == 1) //0 = take-off, 1 = landing
            {
                factor = 1.1; //10% increase in weight : Landing
            }


            //10% increase in aircraft weight	x 1.2	x 1.1

            return myWeight * factor;

        }

    }
}
