using System;

namespace myFlightInfo.take_off_landing
{
    class RunwaySlopeFactor
    {
        public static double WorkOutRunwaySlopeFactor(float myRunwaySlope)
        {
            // Runway Slope component, for every 2% increase distance by 10%	
            // Take-off and Landing are the same

           double RunwaySlopeFactor = (Math.Ceiling(myRunwaySlope / 2.0)) * 0.1;

           return 1 + RunwaySlopeFactor;
        }
    }
}
