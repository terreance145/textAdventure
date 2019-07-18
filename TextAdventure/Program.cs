using System;

namespace AlphabetGame
{
    class Program
    {
      

        static void Main(string[] args)
        {
            Console.WriteLine("Lets Play the Alphabet Game!!");
            Console.WriteLine("Instruction: I'm thinking of an alphabet......" +
                 " " + "If you need any assistants press 'h' the help button");
            //answer sheet
            GetAlphabet("What is the 17th letter: ", "q", "Quiet, Quick, Quiz");
            GetAlphabet("what the 23rd letter in the alphabet: ", "w", "What will William wear while working with Wanda?");
            GetAlphabet("what the 5th letter in the alphabet: ", "e", "Ed, Edd, Eddy");
            GetAlphabet("what the 18th letter in the alphabet: ", "r", "A pirate say's");
            GetAlphabet("what the 20th letter in the alphabet: ", "t", "timmy turner, television, talking");
        }

        
        static void GetAlphabet(string statement, string letter, string helpMessage)
        {
            bool correctAnswer = false;

            while (correctAnswer == false)
            {
                Console.WriteLine(statement);
                string response = Console.ReadLine();

                if (response == letter)
                {
                    Console.WriteLine("Correct");
                    correctAnswer = true;

                }

                //trying to decide
                else if (response != "")
                {
                    HelpKey(helpMessage);
                }

            }
        }
        
        //method if player gets stuck
        static void HelpKey(string hint)
        {
            string helpKey = "h";
            Console.WriteLine("Would you like a hint?");
            string response2 = Console.ReadLine();
            if (response2 == helpKey)
            {
                Console.WriteLine(hint);
            }
            else
            {
                Console.WriteLine("Try Again");
            }
        }

    }
}
