/*===============================================================
    FILE: Program.cs
    PURPOSE: central controler ("the boss") of the entire app from beginning to end.
    What is housed here: Main method, user inputs, loop.
    
    Exceeding requirements (creativity): Added a hint feature. The user can use up to 3 hints 
    to randomly reveal one hidden word to help with memorization.
=================================================================*/

using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {

            Reference reference = new Reference("Ether", 12, 27);
            string text = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them";
            Scripture scripture = new Scripture(reference, text);
            int hintsRemaining = 3;

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();

                if (scripture.IsCompletelyHidden())

                {
                    Console.WriteLine("All words hidden!");
                    break;
                }

                Console.WriteLine($"Press Enter to hide words, type hint ({hintsRemaining} left), or type quit:");
                string userInput = Console.ReadLine().Trim().ToLower();

                if (userInput == "quit")
                {
                    break;
                }

                if (userInput == "hint")
                {
                    if (hintsRemaining > 0 && scripture.ShowRandomHiddenWord())
                    {
                        hintsRemaining--;
                    }
                    continue;
                }
                scripture.HideRandomWords(2);
            }
        }
    }
}

