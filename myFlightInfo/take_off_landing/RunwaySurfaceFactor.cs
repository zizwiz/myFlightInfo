using System;

namespace myFlightInfo.take_off_landing
{
    class RunwaySurfaceFactor
    {
        public static double WorkOutRunwaySurfaceFactor(string mySurface, int myType)
        {

            // Dry Grass up to 20cm: Take-off = x1.2, landing = x1.15
            // Wet Grass up to 20cm: Take-off = x1.3, landing = x1.35
            // Wet Paved Surface: Take-off = 1, landing = x1.15

            double RunwaySurfaceFactor = 1;

            switch (mySurface)
            {
                case "Dry Grass":
                    RunwaySurfaceFactor = (myType == 0) ? 1.2 : 1.15;
                    break;
                case "Wet Grass":
                    RunwaySurfaceFactor = (myType == 0) ? 1.3 : 1.35;
                    break;
                case "Wet Paved":
                    RunwaySurfaceFactor = (myType == 0) ? 1 : 1.15;
                    break;
                default:
                    RunwaySurfaceFactor = 1;
                    break;
            }
            
            return RunwaySurfaceFactor;
        }
    }
}