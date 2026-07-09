/*===============================================================
    FILE: ProgramGenerator.cs
    PURPOSE: stores journal prompts
    PromptGenerator can: store 5 prompts, pick a random prompt

=================================================================*/


public class PromptGenerator
{

    /*---------- Everything for journal prompts goes in here ----------*/

    /* Stores all journal prompts */
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be and why?"
    };



    /*---------- Random Prompt ----------*/

    /* Returns one random prompt */
    public string GetRandomPrompt()
    {
        /* Choose one journal question */
        Random randomGenerator = new Random();

        /* Choose which question to show the user */
        int index = randomGenerator.Next(_prompts.Count);

        /* Send the question to Program.cs */
        return _prompts[index];

    }

}