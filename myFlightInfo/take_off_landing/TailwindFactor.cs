using System;


namespace myFlightInfo.take_off_landing
{
    class TailwindFactor
    {

        public static double WorkOutTailwindFactor(float myTailWindSpeed)
        {
            // Tailwind component, 10% of lift off speed	takeoff = landing = x 1.2
            // lift off speed = 26kts

            double TenPercentLiftOfSpeed = 26.0/10.0; //get data for aircraft remember add decimal even if zero

            double TailwindFactor = (Math.Ceiling(myTailWindSpeed / TenPercentLiftOfSpeed)) * 0.2;
            
            return 1 + TailwindFactor;
        }


    }
}
