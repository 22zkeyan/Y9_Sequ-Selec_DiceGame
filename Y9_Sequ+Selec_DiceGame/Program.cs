namespace Y9_Sequ_Selec_DiceGame
{
    internal class Program
    {
        static void DiceGame()
        {
            int p1_score = 0;
            int p2_score = 0;
            Random random = new Random();
            int die1_p1 = random.Next(1, 6);
            int die2_p1 = random.Next(1, 6);
            int die1_p2 = random.Next(1, 6);
            int die2_p2 = random.Next(1, 6);
            //Player 1
            if (die1_p1 != die2_p1)
            {
                p1_score = die1_p1 + die2_p1;
            } else if (die1_p1 == die2_p1)
            {
                if (die1_p1 == 6 ^ die2_p1 == 6)
                {
                    p1_score = die1_p1 * 2;
                } else if (die1_p1 == 6 && die2_p1 == 6)
                {
                    p1_score = 0;
                } 
            }
            //Player 2
            if (die1_p2 != die2_p2)
            {
                p2_score = die1_p2 + die2_p2;
            }
            else if (die1_p2 == die2_p2)
            {
                if (die1_p2 == 6 ^ die2_p2 == 6)
                {
                    p2_score = die1_p2 * 2;
                }
                else if (die1_p2 == 6 && die2_p2 == 6)
                {
                    p2_score = 0;
                }
            }
            Console.WriteLine("Player 1: " +die1_p1 + ", " +die2_p1 + ". Player 2: " +die1_p2 + ", " +die2_p2);
            Console.WriteLine("P1 Score: " +p1_score + ". P2 Score: " +p2_score);
            if (p1_score > p2_score)
            {
                Console.WriteLine("Player 1 hath won");
            } else if (p2_score > p1_score)
            {
                Console.WriteLine("Player 2 hath won");
            } else if (p1_score == p2_score)
            {
                Console.WriteLine("It hath drawn");
            } else
            {
                Console.WriteLine("what");
            }
        }
        static void Main(string[] args)
        {
            DiceGame();
        }
    }
}
