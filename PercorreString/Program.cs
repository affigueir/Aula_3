using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a sentence:\n");
            string input = Console.ReadLine();

            System.Console.Write("Please type a char: ");
            string charInput = Console.ReadLine();
            char letter = charInput[0];

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == letter)
                    continue;
                else
                {
                    System.Console.Write(input[i]);
                }
            }

        }
    }
}
