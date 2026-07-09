/*===============================================================
    FILE: Entry.cs
    PURPOSE
    Stores ONE journal entry 
    Each entry will remember: Date, Prompt, User'sResponse

=================================================================*/

public class Entry
{
    /*---------- Everything for ONE journal entry goes in here ----------*/

    /*---------- Member Variables ----------*/

    /* Saves the date */
    public string _date = "";

    /* Saves the prompt */
    public string _promptText = "";

    /* Saves the user's response */
    public string _entryText = "";


    /*---------- Display Method ----------*/

    /*Displays one journal entry */
    public void Display()
    {
        /*Displays the date */
        Console.WriteLine($"Date: {_date}");

        /*Displays the the writing prompt */
        Console.WriteLine($"Prompt: {_promptText}");

        /*Displays the users jouranal response*/
        Console.WriteLine($"Entry: {_entryText}");


        /*Prints a blank line so multiple entries dont run together */
        Console.WriteLine();

    }


}