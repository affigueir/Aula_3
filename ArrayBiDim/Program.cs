using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Array Average!\n");
            
            int x = 0, y = 0, horInput = 0, verInput = 0;
            bool loop = true;

            while (loop == true)
            {
                System.Console.Write("Horizontal Dimension: ");
                string input1 = Console.ReadLine();
                bool result1 = int.TryParse(input1, out x);

                if (result1 == true)
                {
                    while(true)
                    {

                        horInput = int.Parse(input1);

                        System.Console.Write("Vertical Dimension: ");
                        string input2 = Console.ReadLine();
                        bool result2 = int.TryParse(input2, out y);

                        if (result2 == true)
                        {
                            verInput = int.Parse(input2);
                            loop = false;
                            break;
                        }
                        else
                        {
                            System.Console.WriteLine($"{input2} is not a number!");
                            System.Console.WriteLine("-------------------------");
                        }
                    }
                }
                else
                {
                    System.Console.WriteLine($"{input1} is not a number!");
                    System.Console.WriteLine("-------------------------");
                }
            }

            System.Console.WriteLine($"{horInput} | {verInput}");

        }
    }
}
