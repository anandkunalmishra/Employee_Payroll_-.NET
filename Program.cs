namespace Employee
{
    class Payrole
    {
        public static bool isPresent(Random random)
        {
            int presentStatus = random.Next(0, 2);
            if (presentStatus == 1) return true;
            return false;
         }


        public static double dailyEmployeeWage(double wagePerHour, double fullDayHour)
        {
            return wagePerHour * fullDayHour;
        }


        public static void Main(String[] args)
        {
            //Check for the presence of the Employee

            Random random = new Random();

            if(isPresent(random))
            {

                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is not present");
            }

            // Calculate the Daily Wage of the Employee

            const double wagePerHour = 20;
            const double fullDayHour = 8;

            double wageCalculated = dailyEmployeeWage(wagePerHour, fullDayHour);
            Console.WriteLine($"The Calculated daily wage for the Employee is {wageCalculated}");


            Console.ReadLine();
        }
    }
}