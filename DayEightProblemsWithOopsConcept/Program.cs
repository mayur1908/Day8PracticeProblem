using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayEightProblemsWithOopsConcept
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WellCome To Employee Wage Computation ");
 //an instance of the Employee class is created, and the CalculateWage method is called to calculate and display the total employee wage.
            Employee emp = new Employee();
            int totalWage = emp.CalculateWage();
            Console.WriteLine("\nTotal Employee Wage: " + totalWage);
            Console.WriteLine("WellCome To Line Comparision Program");
            /*
             the user is prompted to enter the coordinates of the two lines. 
            Two instances of the Line class are created with the provided coordinates. 
            The CalculateLength method is called on each line object to calculate their lengths.
             */
            Console.WriteLine("Enter the (x,y) coordinates of the first point of line 1:");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the (x,y) coordinates of the second point of line 1:");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the (x,y) coordinates of the first point of line 2:");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the (x,y) coordinates of the second point of line 2:");
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            Line line1 = new Line(x1, y1, x2, y2);
            Line line2 = new Line(x3, y3, x4, y4);

            double length1 = line1.CalculateLength();
            double length2 = line2.CalculateLength();

            int comparisonResult = length1.CompareTo(length2);

            if (comparisonResult == 0)
            {
                Console.WriteLine("Line 1 is equal to line 2.");
            }
            else if (comparisonResult < 0)
            {
                Console.WriteLine("Line 1 is less than line 2.");
            }
            else
            {
                Console.WriteLine("Line 1 is greater than line 2.");
            }
        }
    }
}
