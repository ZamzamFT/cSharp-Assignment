using System;

class Program
{
    static void Main()
    {
        // Displying Adressbook title
        Console.WriteLine("******************************** Välkommen till Adressboken ********************************");

        // Declaring a variable to store menu choice
        int mainMenuChoice = -1;

        do
        {

            // Displying The Main Menu
            Console.WriteLine("\n:::Main menu:::");
            Console.WriteLine("            ");


            Console.WriteLine("1. Skapa en kontakt ");
            Console.WriteLine("2. Visa alla kontakter ");
            Console.WriteLine("3. Visa en specifik kontakt");
            Console.WriteLine("4. Ta bort en specifik kontakt");
            Console.WriteLine("0. Återgå till huvud menyn");


            // accept menu choice from keyboard
            Console.Write("Välj ett av alternativen ovan: ");
            mainMenuChoice = int.Parse(Console.ReadLine());


            // switch statement to alternate between menu choices
            switch (mainMenuChoice)
            {
                case 1:AddContact();
                    break;
                case 2:ListAllContacts();
                    break;
                case 3:ShowSpecificContact();
                    break;
                case 4:DeleteSpecificContact();
                    break;
            }


        } while (mainMenuChoice !=0);


        //exit statement
        Console.WriteLine("Avslutar Adressboken. Tack!");
        Console.ReadKey();
    }


    static void AddContact()
    {
        Console.WriteLine("Adding this contact...");

    }


    static void ListAllContacts()
    {
        Console.WriteLine("This is all the contacts...");


    }


    static void ShowSpecificContact()
    {
        Console.WriteLine("Showing this contact....");


    }


    static void DeleteSpecificContact()
    {
        Console.WriteLine("Deleting this contact...");


    }











}