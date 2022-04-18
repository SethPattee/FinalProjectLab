using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace HotelManager;

//this is the logic file
public class ControlMethods
{
    public static void AddPerson(List<Contact> contactList)
    {
        bool badInput2 = true;
        while (badInput2)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("No commas allowed!!!");
                Console.WriteLine("Please enter the first name");
                string firstName = Console.ReadLine();
                Console.WriteLine(firstName);

                Console.WriteLine("No commas allowed!!!");
                Console.WriteLine("Please enter the last name");
                string lastName = Console.ReadLine();
                Console.WriteLine(lastName);

                Console.WriteLine("Please don't include commas");
                Console.WriteLine("Please enter the steet address. ex: 1227 North Lane");
                string streetaddress = Console.ReadLine();
                Console.WriteLine(streetaddress);

                Console.WriteLine("Please don't include commas");
                Console.WriteLine("Please enter the city, state, and zipcode. Ex: Ephraim UT 84627 ");
                string citystatezip = Console.ReadLine();
                Console.WriteLine(citystatezip);

                Console.WriteLine("No commas allowed!!!");
                Console.WriteLine("Please enter the phone number");
                string phone = Console.ReadLine();
                Console.WriteLine(phone);
                string checkComma = firstName + lastName + streetaddress + citystatezip + phone;
                // this is to make sure that there are no commas that will mess up the saving. 
                char value = ',';
                bool result = checkComma.Contains(value);
                Console.WriteLine(checkComma);
                //Add excption here?

                Console.WriteLine($"Is this correct: {firstName} {lastName}, {streetaddress}, {citystatezip}, {phone}?\ny/n");
                var yesno = Console.ReadLine();
                if (result)
                {
                    
                    Console.WriteLine("Try again. You have a comma somwhere. Enter anything but 'y' or 'n' to quit");
                    Console.WriteLine($"Is this correct:{firstName} {lastName}, {streetaddress}, {citystatezip}, {phone}?\ny/n");
                    yesno = Console.ReadLine();
                    if (yesno != "y" && yesno != "n")//for quitting
                    {
                        badInput2 = false;
                    }
                }
                if (yesno != "y" && yesno != "n")
                {
                    Console.WriteLine("Try again. Enter anything but 'y' or 'n' to quit");
                    Console.WriteLine($"Is this correct:{firstName} {lastName}, {streetaddress}, {citystatezip}, {phone}?\ny/n");
                    yesno = Console.ReadLine();
                    if (yesno != "y" && yesno != "n") //for quitting 
                    {
                        badInput2 = false;
                    }
                }
                if (yesno == "y" && result == false) // adds input to the list of contacts
                {
                    contactList.Add(new Contact(firstName, lastName, streetaddress, citystatezip, phone));
                    badInput2 = false;

                }
                if (yesno == "n") // restarts the method
                {
                    badInput2 = true;
                }


            }
            catch
            {

            }



        }

    }
    public static string DisplayInfo(List<Contact> contactList)
    {
        int counter = 0;
        Console.WriteLine("Displaying info");

        foreach (var person in contactList)
        {
            Console.WriteLine($"{counter}:{Contact.GetInfo(person)}");
            counter++;
        }
        return "Done";

    }
    public static void RemovePerson(List<Contact> contactList)
    {
        int input = 0;

        bool badInput = true;

        while (badInput)
        {
            int counter = 0;
            int counter2 = 1;
            foreach (var people in contactList)
            {
                counter++;
            }

            if (counter == 0)
            {
                Console.WriteLine("No people stored");
                return;
            }
            Console.WriteLine($"There are {counter} people stored.\nPlease choose the person the you would like to delete");
            foreach (var person in contactList)
            {
                Console.WriteLine($"{counter2}: {person.FirstName}");
                counter2++;
            }
            //TODO Add a way to quit

            try
            {
                input = int.Parse(Console.ReadLine());
                if (input > counter || input < 1)
                {
                    Console.WriteLine("You are out of bounds. Please enter a number that is inbounds");
                }
                else
                {
                    badInput = false;
                }
            }
            catch
            {
                throw new YouEnteredALetter("You entered a letter. Now you have to restart. Next time, please enter a number");
                Console.ReadLine();
                return ;

            }
        }
        contactList.Remove(contactList[input - 1]);
    }
    public static void WriteToFile(List<Contact> contactList)
    {
        TextWriter tw = new StreamWriter("SavedList.txt", true);

        foreach (var person in contactList)
        {
            tw.WriteLine(Contact.GetInfo(person));
        }
        tw.Close();
    }
    public static void WriteToList(List<Contact> contactList)
    {
        try
        {
            string filePath = ("/Users/sethpattee/Desktop/Labcode/FinalProjectLab/unit-testing-using-nunit/HotelManager.Console/SavedList.txt");
            //you might have to change this to make it work
            List<string> lines = new List<string>();
            List<Contact> contactlist = new List<Contact>();
            lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Contact p = new Contact(items[0], items[1], items[2], items[3], items[4]);
                contactList.Add(p);
            }
            List<string> outContents = new List<string>();
            foreach (var p in contactlist)
            {
                Console.WriteLine(Contact.GetInfo(p));

            }
            string outFile = ("/Users/sethpattee/Desktop/Labcode/FinalProjectLab/unit-testing-using-nunit/HotelManager.Console/SavedList.txt");
            //you might have to change this to make it work
            File.WriteAllLines(outFile, outContents);
        }
        catch
        {

        }


    }

}



public class HasCommaException : Exception
{
    public HasCommaException(string message)
    {

    }
}
public class YouEnteredALetter : Exception
{
    public YouEnteredALetter(string message)
    {
        Console.ReadLine();
        return;
    }
}

public class Contact
{
    public string? firstName;
    public string? lastName;
    public string? streetAddress;
    public string? cityStateZip;
    public string? phone;

    public Contact(string firstName, string lastName, string streetAddress, string cityStateZip, string phone)
    //base(GetName(firstName, lastName)) // Im going to add a base. 
    {
        FirstName = firstName;
        LastName = lastName;
        StreetAddress = streetAddress;
        CityStateZip = cityStateZip;
        Phone = phone;
    }


    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string? StreetAddress { get; set; }
    public string? CityStateZip { get; set; }

    public string? Phone { get; set; }
    public static string GetInfo(string FirstName, string LastName, string StreetAddress, string CityStateZip, string Phone)
    {
        return ($"{FirstName}, {LastName}, {StreetAddress}, {CityStateZip}, {Phone}");
    }
    public static string GetInfo(Contact p)
    {
        return ($"{p.FirstName}, {p.LastName}, {p.StreetAddress}, {p.CityStateZip}, {p.Phone}");
    }
}





