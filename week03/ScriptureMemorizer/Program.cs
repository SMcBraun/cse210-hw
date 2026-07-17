/*===============================================================
    FILE: Program.cs
    PURPOSE: central controler ("the boss") of the entire app from beginning to end.
    What is housed here: Main method, user inputs, loop.
=================================================================*/

using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exceeding requirement/Creativity: Hide 2 woords at a time instead of 3 for user to  practice retaining.*/

            Reference reference = new Reference("Ether", 12, 27);
            string text = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them";
            Scripture scripture = new Scripture(reference, text);

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

                Console.WriteLine("Press Enter to hide words, or type 'quit' to exit: ");
                string UserInput = Console.ReadLine();

                if (UserInput.Trim().ToLower() == "quit")
                {
                    break;
                }

                scripture.HideRandomWords(2);
            }
        }
    }
}

