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
            float lineAverage = 0;

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

            float [,] arrayBiDim = new float [horInput,verInput];

            for(int i = 0; i < horInput; i ++)
            {
                for(int j = 0; j < verInput; j ++)
                {
                    System.Console.Write($"Insert a numeric value for position [{i},{j}]: ");
                    arrayBiDim [i,j] = float.Parse(Console.ReadLine());
                    //System.Console.WriteLine(arrayBiDim[i,j]);
                }
            }

            for (int i = 0; i < horInput; i++)
            {
                float average = 0;
                for (int j = 0; j < verInput; j++)
                {
                    average += arrayBiDim[i,j];
                }
                average /= verInput;
                lineAverage += average;
                
                System.Console.WriteLine($"Line {i} average is {average}");
            }

            lineAverage /= horInput;
            System.Console.WriteLine($"Average of all lines is {lineAverage}");
        }
    }
}
