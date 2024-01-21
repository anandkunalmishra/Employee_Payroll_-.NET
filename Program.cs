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
        public static void Main(String[] args)
        {

            Random random = new Random();

            if(isPresent(random))
            {

                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is not present");
            }

            Console.ReadLine();
        }
    }
}