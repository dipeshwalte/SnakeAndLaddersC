using System;

namespace SnakeAndLadders
{
    class Program
    {

        static void Main(string[] args)
        {
            int position = 0;
            Random rand = new Random();
            int diceThrow = rand.Next(1, 7);
            Console.WriteLine(diceThrow);
            Console.WriteLine("Player 1 Started at Position : " + position);
        }
    }
}
