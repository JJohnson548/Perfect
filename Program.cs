namespace Perfect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number to determine if it is a perfect numebr");

            int userNumber;

            if (int.TryParse(Console.ReadLine(), out userNumber) && userNumber > 0)
            {
                int sumOfNumbers = 0;

                for (int i = 1; i < userNumber; i++)
                {
                    if (userNumber % i == 0)
                        sumOfNumbers += i; 
                }

                if (sumOfNumbers == userNumber)
                    Console.WriteLine ("perfect number.");
                else
                    Console.WriteLine("not a perfect number.");
            }
            else
            {
                Console.WriteLine("Not a valid integer");
       
        }
    }
}     }