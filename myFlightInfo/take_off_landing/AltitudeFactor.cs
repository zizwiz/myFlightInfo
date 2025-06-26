using System;

namespace myFlightInfo.take_off_landing
{
    class AltitudeFactor
    {
        public static double WorkOutAltitudeFactor(double Altitude)
        {
            //factor is same for take-off or landing
            //factor is 1.1 for every 1000ft increase in aerodrome elevation

          //  double answer = (int)Math.Ceiling(Altitude / 1000) * 1.1;

            double answer = (Altitude / 1000) * 1.1;

            if (answer < 1) answer = 1;

            return answer;

        }
    }
}
