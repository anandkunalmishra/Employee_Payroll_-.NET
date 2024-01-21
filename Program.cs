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
            Console.WriteLine("Choose the option you want");
            Console.WriteLine("\toption 1:check for presence");
            Console.WriteLine("\toption2:calculate daily wage");
            Console.WriteLine("\toption3:calculate for part-time Employee");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:

                    //Check for the presence of the Employee

                    Random random = new Random();

                    if (isPresent(random))
                    {
                        Console.WriteLine("Employee is present");
                    }
                    else
                    {
                        Console.WriteLine("Employee is not present");
                    }

                    break;

                case 2:

                    // Calculate the Daily Wage of the Employee

                    const double wagePerHour = 20;
                    const double fullDayHour = 8;
                    double wageCalculated = dailyEmployeeWage(wagePerHour, fullDayHour);
                    Console.WriteLine($"The Calculated daily wage for the Employee is {wageCalculated}");

                    break;

                case 3:

                    // For Part time Employee : suppose he works for 5hrs
                    const double partTimeDayHour = 5;
                    double partTimeWageCalculated = dailyEmployeeWage(wagePerHour, partTimeDayHour);
                    Console.WriteLine($"The Part time employee's wage for a day is {partTimeWageCalculated}");

                    break;

                default:
                    Console.WriteLine("Wrong Option Choosen");
                    break;
            }

            //for making output stable we use the below command else it ends abruptly
            Console.ReadLine();
        }
    }
}