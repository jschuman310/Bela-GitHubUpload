using System;

namespace Bela
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToUpper().Split(" ");

            long n = Int64.Parse(input[0]);
            char b = input[1][0];

            int points = 0;

            for (int i = 0; i < (n * 4); i++)
            {
                char[] card = Console.ReadLine().ToUpper().ToCharArray();

                char description = card[0];
                char suit = card[1];

                if (suit == b)
                {
                    //If suit is dominant
                    if (description == 'A')
                    {
                        points += 11;
                    }
                    else if (description == 'K')
                    {
                        points += 4;
                    }
                    else if (description == 'Q')
                    {
                        points += 3;
                    }
                    else if (description == 'J')
                    {
                        points += 20;
                    }
                    else if (description == 'T')
                    {
                        points += 10;
                    }
                    else if (description == '9')
                    {
                        points += 14;
                    }
                    else if (description == '8')
                    {
                        points += 0;
                    }
                    else if (description == '7')
                    {
                        points += 0;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (suit != b)
                {
                    //If suit is not dominant
                    if (description == 'A')
                    {
                        points += 11;
                    }
                    else if (description == 'K')
                    {
                        points += 4;
                    }
                    else if (description == 'Q')
                    {
                        points += 3;
                    }
                    else if (description == 'J')
                    {
                        points += 2;
                    }
                    else if (description == 'T')
                    {
                        points += 10;
                    }
                    else if (description == '9')
                    {
                        points += 0;
                    }
                    else if (description == '8')
                    {
                        points += 0;
                    }
                    else if (description == '7')
                    {
                        points += 0;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.Write(points);
        }
    }
}