using System;

namespace SnakeAndLadders
{
    class Program
    {
		//static constants
        const int NO_PLAY = 0;
        const int LADDER = 1;
        const int SNAKE = 2;
        const int PLAYER_1_TURN = 1;
        const int PLAYER_2_TURN = 2;

		private static int returnPositionAfterLadder(int diceThrow, int position, int playerTurn)
		{
			position += diceThrow;
			if (position > 100)
			{
				position -= diceThrow;
			}
			Console.WriteLine("Ladder! :-) Player " + playerTurn + " Position :" + position);
			return position;
		}

		private static int returnPositionAfterSnake(int diceThrow, int position, int playerTurn)
		{
			position -= diceThrow;
			if (position < 0)
			{
				position = 0;
			}
            Console.WriteLine("Snake! :-( Player " + playerTurn + " Position :" + position);
			return position;
		}

       
        private static void playGame()
		{
			/// <summary>Snake and Ladders 2 player game is played</summary>
			//variables
			int player1Position = 0;
			int player2Position = 0;
			int diceThrowCount = 0;
			int turn = PLAYER_2_TURN;
			bool ladderFlag = false;
			var rand = new Random();

			while (player1Position < 100 && player2Position < 100)
			{
				if (ladderFlag)
					ladderFlag = false;
				else
				{
					if (turn == PLAYER_1_TURN)
						turn = PLAYER_2_TURN;
					else
						turn = PLAYER_1_TURN;
				}
				int diceThrow = rand.Next(1, 6);
				diceThrowCount++;
				int option = rand.Next(2);
				switch (option)
				{
					case NO_PLAY:

						if (turn == PLAYER_1_TURN)
							Console.WriteLine("No Play.. :-| Player 1 Position :" + player1Position);
						else
							Console.WriteLine("No Play.. :-| Player 2 Position :" + player2Position);
						break;

					case LADDER:

						ladderFlag = true;
						if (turn == PLAYER_1_TURN)
							player1Position = returnPositionAfterLadder(diceThrow, player1Position, PLAYER_1_TURN);
						else
							player2Position = returnPositionAfterLadder(diceThrow, player2Position, PLAYER_2_TURN);
						break;

					case SNAKE:

						if (turn == PLAYER_1_TURN)
							player1Position = returnPositionAfterSnake(diceThrow, player1Position, PLAYER_1_TURN);
						else
							player2Position = returnPositionAfterSnake(diceThrow, player2Position, PLAYER_2_TURN);
						break;
					default:
						break;

				}//end switch
			}//end while
			Console.WriteLine("No of times dice was cast: " + diceThrowCount);
			if (player1Position == 100)
				Console.WriteLine("Player 1 won!!");
			else
				Console.WriteLine("Player 2 won!!");
		}


		static void Main(string[] args)
		{
			playGame();
		}	
    }	
}
