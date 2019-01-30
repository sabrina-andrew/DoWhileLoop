using System;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int pickANumber = 1;


            do
            {
                Console.WriteLine(pickANumber);
                pickANumber++;
            } while (pickANumber <= 100);

                Console.ReadKey();
        }
    }
}
