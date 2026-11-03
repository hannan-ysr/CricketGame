namespace HowzattSubroutineChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int result = rollDice(rng, 6);
            // a game of howzatt is played by rolling a dice
            // and scoring runs based on the result of the roll.
            // The game continues until the player is out.
            // The player can roll the dice multiple times to accumulate runs, but if they roll a 6,
            // they must check if they are out.
            // If they are out, the game ends and their total score is displayed.

            //1. Complete the program to play the game of howzatt
            //2. Extend the game to allow the player to have 10 batters and keep track of their scores and the total score
            //3. Extend further to make it a 2 player game where each player has 10 batters and the winner is the player with the highest total score
            //4. Extend further to allow the player to choose how many batters they want to have and how many players they want to play against
            //5. running the basic game, what is the maximum score you can get with a single batter?

        }
        static int rollDice(Random rng, int max)
        {
            return rng.Next(1, max); // this doesn't work as intended
        }
        static int score(int roll)
        {
            // a 1 is worth 1 run
            // a 2 is worth 2 runs
            // a 3 is worth 4 runs
            // a 4 is worth 6 runs
            // a 5 is worth 0 runs
            // a 6 checks if player is out, if they are the game is over
            return 0;
        }
        static bool isOut() // you will need to adjust parameters for this method to work
        {
            // 1 is run out
            // 2 is caught out
            // 3 is bowled out
            // 4 is not out 
            return false;
        }
    }
}
