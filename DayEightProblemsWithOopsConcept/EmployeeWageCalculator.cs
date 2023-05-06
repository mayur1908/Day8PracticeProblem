using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayEightProblemsWithOopsConcept
{
        //I've created a class called Employee that encapsulates the logic for calculating the employee wage. 
        class Employee
        {

        private const int EMP_RATE_PER_HOUR = 20;
            private const int IS_FULL_TIME = 1;
            private const int IS_PART_TIME = 2;

            private Random random;

            public Employee()
            {
            //The Employee class has a private field random of type Random to generate random numbers.

            random = new Random();
            }

            public int CalculateWage()
            {
            //The CalculateWage method calculates the employee wage by iterating over the working days until 

            int empHour = 0;
                int empWage = 0;
                int totalEmpWage = 0;
                int totalEmpHour = 0;
                int totalWorkingDays = 0;
                int totalWorkingHours = 0;
            //the total working hours reach 100 or the total working days reach 20.

            while (totalWorkingHours < 100 && totalWorkingDays < 20)
                {
                    totalWorkingDays++;
                    int empCheck = random.Next(3);
                //It uses a switch statement to determine the number of hours worked based on the random number generated.

                switch (empCheck)
                    {
                        case IS_FULL_TIME:
                            empHour = 8;
                            break;
                        case IS_PART_TIME:
                            empHour = 4;
                            break;
                        default:
                            empHour = 0;
                            break;
                    }

                    totalWorkingHours += empHour;
                    Console.WriteLine("Day {0}: {1} hours", totalWorkingDays, empHour);
                    empWage = empHour * EMP_RATE_PER_HOUR;
                    totalEmpWage += empWage;
                }

                Console.WriteLine("\nTotal Working Days: " + totalWorkingDays);
                Console.WriteLine("Total Working Hours: " + totalWorkingHours);
                Console.WriteLine("Total Employee Wage: " + totalEmpWage);

                return totalEmpWage;
            }
        }
    }
