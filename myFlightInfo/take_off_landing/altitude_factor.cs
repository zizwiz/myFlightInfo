using System;

namespace myFlightInfo.take_off_landing
{
    class altitude_factor
    {
        public static double WorkOutAltitudeFactor(double Altitude)
        {
            //factor is same for take-off or landing
            //factor is 1.1 for every 1000ft increase in aerodrome elevation

            return (int)Math.Ceiling(Altitude / 1000) * 1.1;

        }
    }
}
