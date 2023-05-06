using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayEightProblemsWithOopsConcept
{
    class Line
    {
        
         //I've created a Line class that encapsulates the logic for calculating the length of a line.
        //The Line class has private fields x1, y1, x2, and y2 to store the coordinates of the line's endpoints.
        //The constructor of the Line class accepts these coordinates as parameters and initializes
        
        private double x1, y1, x2, y2;

        public Line(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
   //The CalculateLength method calculates the length of the line using the formula provided in the original program.
        public double CalculateLength()
        {
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            // It returns the calculated length
            return length;
        }
    }
}
