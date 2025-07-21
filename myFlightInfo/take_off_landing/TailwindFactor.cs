using System;


namespace myFlightInfo.take_off_landing
{
    class TailwindFactor
    {

        public static double WorkOutTailwindFactor(float myTailWindSpeed)
        {
            // Tailwind component, for every 10% higher than lift off we increase takeoff distance by 20%	
            // nose wheel lifts @ 26kts
            // Aircraft lifts off @ 38kts

            double TenPercentLiftOfSpeed = 38.0/10.0; //get data for aircraft remember add decimal even if zero

            double TailwindFactor = (Math.Ceiling(myTailWindSpeed / TenPercentLiftOfSpeed)) * 0.2;
            
            return 1 + TailwindFactor;
        }


    }
}
