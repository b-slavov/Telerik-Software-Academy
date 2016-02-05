using System;
using System.Numerics;

class CardWarsBatka
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger player1TotalScore = 0;
        BigInteger player2TotalScore = 0;

        int player1GamesWon = 0;
        int player2GamesWon = 0;

        for (int i = 0; i < n; i++)
        {
            BigInteger player1HandScore = 0;
            BigInteger player2HandScore = 0;
            bool player1HasXCard = false;
            bool player2HasXCard = false;

            for (int j = 0; j < 3; j++)
            {
                string card = Console.ReadLine();
                switch (card)
                {
                    case "A": player1HandScore += 1; break;
                    case "K": player1HandScore += 13; break;
                    case "Q": player1HandScore += 12; break;
                    case "J": player1HandScore += 11; break;
                    case "X": player1HasXCard = true; break;
                    case "Y": player1TotalScore -= 200; break;
                    case "Z": player1TotalScore *= 2; break;
                    default: player1HandScore += 12 - int.Parse(card); break;
                }
            }

            for (int j = 0; j < 3; j++)
            {
                string card = Console.ReadLine();
                switch (card)
                {
                    case "A": player2HandScore += 1; break;
                    case "K": player2HandScore += 13; break;
                    case "Q": player2HandScore += 12; break;
                    case "J": player2HandScore += 11; break;
                    case "X": player2HasXCard = true; break;
                    case "Y": player2TotalScore -= 200; break;
                    case "Z": player2TotalScore *= 2; break;
                    default: player2HandScore += 12 - int.Parse(card); break;
                }
            }

            if (player1HasXCard && player2HasXCard)
            {
                player1TotalScore += 50;
                player2TotalScore += 50;
            }
            else if (player1HasXCard)
            {
                Console.WriteLine("X card drawn! Player 1 wins the match!");
                return;
            }
            else if (player2HasXCard)
            {
                Console.WriteLine("X card drawn! Player 2 wins the match!");
                return;
            }

            if (player1HandScore > player2HandScore)
            {
                player1TotalScore += player1HandScore;
                player1GamesWon++;
            }
            else if (player1HandScore > player2HandScore)
            {
                player2TotalScore += player2HandScore;
                player2GamesWon++;
            }
        }

        if (player1TotalScore == player2TotalScore)
        {
            Console.WriteLine(@"It's a tie!
Score: {0}", player2TotalScore);
        }
        else if (player1TotalScore > player2TotalScore)
        {
            Console.WriteLine(@"First player wins!
Score: {0}
Games won: {1}", player1TotalScore, player1GamesWon);
        }
        else if (player1TotalScore > player2TotalScore)
        {
            Console.WriteLine(@"First player wins!
Score: {0}
Games won: {1}", player2TotalScore, player2GamesWon);
        }
    }
}