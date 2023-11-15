namespace KrokodilleSpillet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerPoints = 0;

            Console.WriteLine(
                "HOW TO PLAY:\n" +
                "Enter a valid input('<' '>' '=')\n" +
                "If you enter the correct input you get 1 point\n" +
                "If you get it wrong you lose 1 point");

            while (true)
            {
            startGame(ref playerPoints);
            }
        }

        static void startGame(ref int playerPoints)
        {
            int firstNumber = generateRandomNumber();
            int secondNumber = generateRandomNumber();

            Console.WriteLine($"\n{firstNumber}_{secondNumber}");

            checkIfCorrect(firstNumber, secondNumber, ref playerPoints);

            startGame(ref playerPoints);
        }

        static void checkIfCorrect(int firstNumber, int secondNumber, ref int playerPoints)
        {
            char userInput = Convert.ToChar(Console.ReadLine());
            if (
                userInput == '<' && firstNumber < secondNumber ||
                userInput == '>' && firstNumber > secondNumber ||
                userInput == '=' && firstNumber == secondNumber
                )
            {
                Console.WriteLine("Correct'o!");
                playerPoints++;
            }
            else
            {
                Console.WriteLine("WRONG!");
                playerPoints--;
            }
            Console.WriteLine($"Current score: {playerPoints}");
        }

        static int generateRandomNumber()
        {
            Random num = new Random();
            return num.Next(1,11);
        }
    }
}
