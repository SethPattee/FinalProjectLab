using System;
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
            Console.WriteLine("Please choose an option to explore!\n0: Display Info\n1: Add Person\n2: Remove Person\n3: Save People\n4: Load From Save\n5: Change Status\n6: Exit");
            var option = Console.ReadLine();
            switch (option)
            {
                case "0":
                    Console.Clear();
                    ControlMethods.DisplayInfo(contactList, checkInList);
                    Console.WriteLine("Done");
                    break;
                case "1":
                    ControlMethods.AddPerson(contactList, checkInList);
                    break;
                case "2":
                    ControlMethods.RemovePerson(contactList, checkInList);
                    Console.WriteLine("Person has been removed");
                    break;
                case "3":
                    ControlMethods.WriteToFile(contactList);
                    Console.WriteLine("Contacts Saved!");
                    break;
                case "4":
                    ControlMethods.WriteToList(contactList, checkInList);
                    Console.WriteLine("Contacts Loaded!");
                    break;
                case "5":
                    ControlMethods.ChangeStatus(contactList, checkInList);
                    Console.WriteLine("Status Changed!");
                    break;
                case "6":
                    return;
                default:
                    break;
            }
        }
    }


}