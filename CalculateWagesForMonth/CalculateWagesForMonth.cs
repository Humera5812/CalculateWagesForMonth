using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateWagesForMonth
{
    internal class CalculateWagesForMonth
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUMBER_OF_WORKING_DAYS = 2;
        public static void CalculateWages()
        {
            int empHrs = 0;
            int empwage = 0;
            int totalwage = 0;
            for (int day = 0; day < NUMBER_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0,3);
                empwage = empHrs * EMP_RATE_PER_HOUR;
                totalwage += empwage;
                Console.WriteLine("Emp Wage : " + empwage);

            }
            Console.WriteLine("Total Employee Wage : " + totalwage);
        }
            
        
    }
}
