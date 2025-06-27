using System;

namespace myFlightInfo.take_off_landing
{
    class AltitudeFactor
    {
        public static double WorkOutAltitudeFactor(double Altitude)
        {
            //factor is same for take-off or landing
            //factor is 1.1 for every 1000ft increase in aerodrome elevation

            return 1 + (Altitude / 1000) * 0.1;

        }
    }
}
