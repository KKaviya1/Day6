using System;

namespace MonthlySalaryCalculator
{
        internal class Program
        {
            public int calculation(int hours, int days, int handles = 0, int extras = 0)
            {
                int result = hours * days * 100 + handles * 3000 + extras * 2000;
                return result;
            }
        
          
            static void Main(string[] args)
            {
                Program instance = new Program();
            Console.WriteLine("Welcome to the Monthly Salary Calculator");

            Console.WriteLine("Choose the employee type:");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Software Developer \n");
            Console.WriteLine("Enter the employee type number:");
            int employeeType = Convert.ToInt32(Console.ReadLine());

            int workingHours, numberOfWorkingDays, projectHandles, extras;



            Console.WriteLine("Enter the working hours:");
            workingHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of working days:");
            numberOfWorkingDays = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the project handles:");
            projectHandles = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the extras:");
            extras = Convert.ToInt32(Console.ReadLine());

            double monthlySalary = CalculateMonthlySalary(employeeType, workingHours, numberOfWorkingDays, projectHandles, extras);

            Console.WriteLine("Monthly Salary: $" + monthlySalary);

            Console.ReadLine();
            Console.ReadKey();
        }

        static double CalculateMonthlySalary(int employeeType, int workingHours, int numberOfWorkingDays, int projectHandles, int extras)
        {
            double monthlySalary = 0;

            switch (employeeType)
            {
                case 1: // HR
                    monthlySalary = workingHours * numberOfWorkingDays * 100;
                    break;
                case 2: // Admin
                    monthlySalary = workingHours * numberOfWorkingDays * 100 + projectHandles * 3000;
                    break;
                case 3: // Software Developer
                    monthlySalary = workingHours * numberOfWorkingDays * 100 + projectHandles * 3000 + extras * 2000;
                    break;
                default:
                    Console.WriteLine("Invalid employee type.");
                    break;
            }

            return monthlySalary;

        }

    }
}
