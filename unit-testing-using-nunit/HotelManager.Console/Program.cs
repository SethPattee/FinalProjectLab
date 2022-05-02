using System;
using ConsoleTables;
namespace HotelManager;
//this is the UI for the program
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello! Welcome to your hotel manager! How can I be of service today?");
        var contactList = new List<Contact>();
        var checkInList = new List<CheckIn>();
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        checkInList.Add(new CheckIn(DateTime.Now, CheckInStatus.CheckedIn));





        while (true)
        {
            //Console.WriteLine("Please choose an option to explore!\n0: Display Info\n1: Add Person\n2: Remove Person\n3: Save People\n4: Load From Save\n5: Change Status\n6: Exit");
            Console.Clear();
            Console.WriteLine("Please choose an option to explore!");
            var Table = new ConsoleTable("Number to Enter", "Name of Command", "Discription");
            Table.AddRow("0", "Display Info", "Displays the info of the people that you have saved");
            Table.AddRow("1", "Add Person", "Lets you add and save a person's info");
            Table.AddRow("2", "Remove Person", "Lets you delete a person and their info");
            Table.AddRow("3", "Save People", "Lets you save people to a text file for later use or to print out");
            Table.AddRow("4", "Load From Save", "If you already have people saved in a text file, it wiil add them to your current list");
            Table.AddRow("5", "Change Status", "Lets you change the status of a person");
            Table.AddRow("6", "Exit", "Quits the program");
            Table.Write(Format.Alternative);
            Console.WriteLine("Enter the number of the command that you would like to run");

            var option = Console.ReadLine();
            switch (option)
            {
                case "0":
                    Console.Clear();
                    ControlMethods.DisplayInfo(contactList, checkInList);
                    Console.WriteLine("Back to the main menu...");
                    Thread.Sleep(1000);
                    break;
                case "1":
                    ControlMethods.AddPerson(contactList, checkInList);
                    Console.WriteLine("Person has been saved!");
                    Console.WriteLine("Back to the main menu...");
                    Thread.Sleep(1000);
                    break;
                case "2":
                    ControlMethods.RemovePerson(contactList, checkInList);
                    Console.WriteLine("Back to the main menu...");
                    Thread.Sleep(1000);
                    break;
                case "3":
                    ControlMethods.WriteToFile(contactList);
                    Console.Clear();
                    Console.WriteLine("Contacts Saved!");
                    Console.WriteLine("Back to the main menu...");
                    Thread.Sleep(1500);
                    break;
                case "4":
                    ControlMethods.WriteToList(contactList, checkInList);
                    Console.Clear();
                    Console.WriteLine("Contacts Loaded!");
                    Console.WriteLine("Back to the main menu...");
                    Thread.Sleep(1500);
                    break;
                case "5":
                    ControlMethods.ChangeStatus(contactList, checkInList);
                    Console.WriteLine("Status Changed!");
                    Console.WriteLine("Back to the main menu...");
                    Thread.Sleep(1000);
                    break;
                case "6":
                    return;
                default:
                    break;
            }
        }
    }


}