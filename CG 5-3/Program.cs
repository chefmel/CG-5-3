using System;

namespace CG_5_3
{
    class Program
    {
        const int WINNING_VALUE = 20;
        const int NUMBER_DIE_SIDES = 6;

        static void Main(string[] args)
        {
            //create a dice game to see who can get to 20 first.  You will roll two and six sided dice and add up the numbers.
            //then the computer gets to go, and it does the same.  This process will repeat until either you or the commputer wins

            //assign variables, both user and computer start with a score of 0
            int userScore = 0;
            int computerScore = 0;
            //dieTotal is given a value or initialized later with the RollDice method
            int dieTotal;
            //Bool required for taking turns.  Need a return of true or false for the next turn
            bool userTurn = true;
            //use do/while to alternate the user and computer taking turns rolling dice

            int WINNING_VALUE = 0;
            do
            {
                //call the method on the right and the return of the method is be3ing set ito the variable on the left
                dieTotal = RollDice();
                //if is evaluating either true or false.  True executes the if statement, false skips the if statement.

                if (userTurn)
                {
                    Console.WriteLine("Your turn, roll the dice by pressing enter");
                    //stops execution of program until enter is pressed
                    Console.ReadLine();

                    Console.WriteLine("Total of your die is: " + dieTotal);
                    //this is same as userScore = dieTotal + userScore.  This keeps a running total of score
                    //this adds dieTotal with userScore and sets userScore to the result
                    userScore += dieTotal;
                }
                //this will execute when the if statement is false.
                else
                {
                    Console.WriteLine("Computer's turn.");
                    Console.WriteLine();
                    Console.WriteLine("Total of computer dice is: " + dieTotal);

                    computerScore += dieTotal;
                }
                Console.WriteLine("Your score is: " + userScore);
                Console.WriteLine("Computer sore is: " + computerScore);
                Console.WriteLine();
                //criteria for t/f on the if statement. It flips after each turn. It is in the do/while
                userTurn = !userTurn;

                //If usercoe is less than winning balue and computerSore is le than winning blue the true-repeat the do/while loop
            } while (userScore < WINNING_VALUE && computerScore < WINNING_VALUE);
            if (userScore >= WINNING_VALUE)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
            Console.ReadLine();

        }
        ///<summary>
        ///Adds and returns value of 2 dice
        ///</summary>
        ///<returns></returns>
        private static int RollDice()
        {
            //create the variable for the dice.
            int die1;
            int die2;
            //create variable type Random so randomizer can be used
            Random randomizer = new Random();

            die1 = randomizer.Next(1, NUMBER_DIE_SIDES + 1);
            die2 = randomizer.Next(1, NUMBER_DIE_SIDES + 1);

                //returns value of the dice added together
            return (die1 + die2);
        
        }
    }
}
