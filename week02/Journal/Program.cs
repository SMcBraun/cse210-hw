using System;


/*===============================================================
    FILE: Program.cs
    PURPOSE: controls the Journal program
    Program can: show menu, read choices, connect classes

=================================================================*/

class Program
{
    static void Main(string[] args)
    {
        /* Creates one Journal */
        Journal theJournal = new Journal();

        /* Creates one PromptGenerator */
        PromptGenerator promptGenerator = new PromptGenerator();

        /* Saves the user's menu choice */
        string choice = "";

        //Exceeding Requirements:
        //I added a delete feature that allows the user to remove a journal entry 

        while (choice != "6")
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Delete");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");


            choice = Console.ReadLine();


            /*---------------Write----------------*/
            if (choice == "1")

            {
                /* Get one journal question */
                string prompt = promptGenerator.GetRandomPrompt();

                /* Show the prompt to the user */
                Console.WriteLine(prompt);
                Console.Write(">");


                /* Store what the user types as their journal response */
                string response = Console.ReadLine();


                /* Create one new Entry object */
                Entry newEntry = new Entry();

                /* Save today's date inside the entry */
                newEntry._date = DateTime.Now.ToShortDateString();


                /* Save the prompt inside the entry */
                newEntry._promptText = prompt;

                /* Save the user's response inside the entry */
                newEntry._entryText = response;


                /* Add the completed entry to the journal's list */
                theJournal.AddEntry(newEntry);


            }


            /*---------------Display---------------*/
            if (choice == "2")
            {
                /*Display all journal entries */
                theJournal.DisplayAll();
            }


            /*---------------Load----------------*/

            if (choice == "3")
            {
                /* Ask the user for a file name */
                Console.Write("Enter a file name: ");

                /* Save the file name the user entered */
                string file = Console.ReadLine();

                /* Send the file name to Journal.cs */
                theJournal.LoadFromFile(file);
            }



            /*---------------Save----------------*/
            if (choice == "4")
            {
                /* Ask the user for a file name */
                Console.Write("Enter a file name: ");

                /* Save the file name the user entered */
                string file = Console.ReadLine();


                /* Send the file name to the Journal.cs */
                theJournal.SaveToFile(file);

            }



            /*--------------Delete---------------*/
            if (choice == "5")
            {
                theJournal.DisplayAll();

                Console.Write("Enter the entry number to delete: ");
                int entryNumber = int.Parse(Console.ReadLine());

                theJournal.DeleteEntry(entryNumber);
            }


        }
    }
}


