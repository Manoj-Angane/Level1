using System;

namespace Level1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number 1");
            string input1=Console.ReadLine();
            Console.WriteLine("Enter Number 2");
            string input2 = Console.ReadLine();
            Console.WriteLine("Enter Number 3");
            string input3 = Console.ReadLine();
            try
            {
                double Number1 = Double.Parse(input1);
                double Number2 = Double.Parse(input2);
                double Number3 = Double.Parse(input3);
                if (Number1 >= Number2 & Number1 >= Number3)
                {
                    Console.WriteLine("Number1 is greatest Number :" + Number1);
                }
                else if (Number2 >= Number1 & Number2 >= Number3)
                {
                    Console.WriteLine("Number2 is greatest Number :" + Number2);
                }
                else
                {
                    Console.WriteLine("Number3 is greatest Number :" + Number3);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Thank You!!..Hit any key to exit");
            Console.ReadKey(true);
        }
    }
}
