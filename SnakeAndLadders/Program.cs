using System;

namespace SnakeAndLadders
{
    class Program
    {
        //static constants
        const int NO_PLAY = 0;
        const int LADDER = 1;
        const int SNAKE = 2;
        static void Main(string[] args)
        {
            int position = 0;
            Random rand = new Random();
            while(position<100)
            {
                int diceThrow = rand.Next(1, 7);
                int option = rand.Next(2);
                switch (option)
                {
                    case NO_PLAY:

                        Console.WriteLine("Player Remained at same position : " + position);
                        break;

                    case LADDER:

                        position += diceThrow;
                        if (position > 100)
                        {
                            position -= diceThrow;
                        }
                        Console.WriteLine("Player moved to : " + position);
                        break;

                    case SNAKE:

                        position -= diceThrow;
                        if (position < 0)
                        {
                            position = 0;
                        }
                        Console.WriteLine("Player moved to : " + position);
                        break;

                    default:
                        break;

                }//end switch
            }
            
		}
    }
}
