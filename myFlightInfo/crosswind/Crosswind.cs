using System;

namespace myFlightInfo.crosswind
{
    class Crosswind
    {
        public static (string, string, string, string, string, string) CalculateWind(string magnitude, string direction, string runway_heading)
        {
           string crosswind1 = Math.Round((Double.Parse(magnitude)* 
                                            Math.Sin(Math.PI * (Double.Parse(direction) - Double.Parse(runway_heading)*10)/180)), 2).ToString();
           string headwind1 = Math.Round((Double.Parse(magnitude) *
                                           Math.Cos(Math.PI * (Double.Parse(direction) - Double.Parse(runway_heading)*10) / 180)), 2).ToString();

            
           //Work out the second runway components
           double runway_heading2 = Double.Parse(runway_heading)*10;

           if (runway_heading2 > 180)
           {
               runway_heading2 -= 180;
           }
           else
           {
               runway_heading2 += 180;
           }

           string crosswind2 = Math.Round((Double.Parse(magnitude) *
                                           Math.Sin(Math.PI * (Double.Parse(direction) - runway_heading2) / 180)), 2).ToString();
           string headwind2 = Math.Round((Double.Parse(magnitude) *
                                          Math.Cos(Math.PI * (Double.Parse(direction) - runway_heading2) / 180)), 2).ToString();
            
           //return components
           return (runway_heading, crosswind1, headwind1, (runway_heading2/10).ToString(), crosswind2, headwind2);
        }
    }
}
