namespace Y9_Sequ_Selec_DiceGame
{
    internal class Program
    {
        static void DiceGame()
        {
            int p1_score = 0; //intialises player 1's score to 0
            int p2_score = 0; //intialises player 2's score to 0
            Random random = new Random(); //imports the pseudo rnaodm number generator i think
            int die1_p1 = random.Next(1, 6); //generates rnaodm number from 1 to six for each player's dice
            int die2_p1 = random.Next(1, 6);
            int die1_p2 = random.Next(1, 6);
            int die2_p2 = random.Next(1, 6);
            //Player 1
            if (die1_p1 != die2_p1) //checks if the dice rolls are different
            {
                p1_score = die1_p1 + die2_p1; //adds the dice roll scores together
            } else if (die1_p1 == die2_p1) // checks if the dice rolls are the same
            {
                if (die1_p1 == 6 ^ die2_p1 == 6) //checks if either of the dice rolls are a 6 using exclusive or (evaluates to false when both are true)
                {
                    p1_score = die1_p1 * 2; //doubles dice score
                } else //if both rolls are 6
                {
                    p1_score = 0; //sets score to zero 
                } 
            }
            //Player 2 (exactly the same as player 1)
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
                else
                {
                    p2_score = 0;
                }
            }
            Console.WriteLine("Player 1: " +die1_p1 + ", " +die2_p1 + ". Player 2: " +die1_p2 + ", " +die2_p2); //outputs dice rolls
            Console.WriteLine("P1 Score: " +p1_score + ". P2 Score: " +p2_score); //outputs score
            if (p1_score > p2_score) //checks if P1 won
            {
                Console.WriteLine("Player 1 hath won"); //outputs p1 has won
            } else if (p2_score > p1_score) //checks if p2 won
            {
                Console.WriteLine("Player 2 hath won"); //outputs p2 has won
            } else if (p1_score == p2_score) //checks if it was a draw
            {
                Console.WriteLine("It hath drawn"); //outputs it was a draw
            } else
            {
                Console.WriteLine("what"); //if you meet mysterious circumstances
            }
        }
        static void Main(string[] args)
        {
            DiceGame();
        }
    }
}
