using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var moreInput = true;
            var puzzleInput = new List<int>();
            while (moreInput)
            {
                var x = Console.ReadLine();
                if (x == "")
                {
                    moreInput = false;
                }
                else 
                {
                    puzzleInput.Add(int.Parse(x));
                }

            }
            for (int i = 0; i < puzzleInput.Count-2; i++)
            {
                for (int j = i+1; j < puzzleInput.Count-1; j++)
                {
                    for (int k = j+1; k < puzzleInput.Count; k++)
                    {
                    if (puzzleInput[i]+puzzleInput[j] + puzzleInput[k] == 2020)
                    {
                        Console.WriteLine("answer: " + puzzleInput[i] * puzzleInput[j]* puzzleInput[k]);
                    }
                    }
                }
            }
        }
    }
}
