﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace HotelManager;

//this is the logic file
public class ControlMethods
{
    public static string DisplayInfo(List<Contact> contactList, List<CheckIn> checkinList)
    {
        int counter = 0;
        Console.WriteLine("Displaying info");

        foreach (var person in contactList)
        {
            Console.WriteLine($"{counter}:{Contact.GetInfo(person)} Status: {checkinList[counter].Status.ToString()}   Last Updated: {checkinList[counter].LastUpdate.ToString("MM/dd/yyyy hh:mm tt")}");
            counter++;
        }
        return "Done";
    }
    public static void AddPerson(List<Contact> contactList, List<CheckIn> checkinList)
    {
        bool badInput2 = true;
        while (badInput2)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("No commas allowed!!!");
                Console.WriteLine("Please enter the first name");
                string firstName = Console.ReadLine()!;
                Console.WriteLine(firstName);

                Console.WriteLine("No commas allowed!!!");
                Console.WriteLine("Please enter the last name");
                string lastName = Console.ReadLine()!;
                Console.WriteLine(lastName);

                Console.WriteLine("Please don't include commas");
                Console.WriteLine("Please enter the steet address. ex: 1227 North Lane");
                string streetaddress = Console.ReadLine()!;
                Console.WriteLine(streetaddress);

                Console.WriteLine("Please don't include commas");
                Console.WriteLine("Please enter the city, state, and zipcode. Ex: Ephraim UT 84627 ");
                string citystatezip = Console.ReadLine()!;
                Console.WriteLine(citystatezip);

                Console.WriteLine("No commas allowed!!!");
                Console.WriteLine("Please enter the phone number");
                string phone = Console.ReadLine()!;
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
                    checkinList.Add(new CheckIn(DateTime.Now, CheckInStatus.NotCheckedIn));
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
    public static void RemovePerson(List<Contact> contactList, List<CheckIn> checkInList)
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
                input = int.Parse(Console.ReadLine()!);
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
<<<<<<< HEAD
                Console.WriteLine("You entered a letter. Now you have to restart. Next time, please enter a number");
=======
               Console.WriteLine("You entered a letter. Now you have to restart. Next time, please enter a number");
>>>>>>> 6fe049ca3e24813f682df0b65e7d0017ac4c4f29
                Console.ReadLine();
                return;
                throw new YouEnteredALetter("You entered a letter. Now you have to restart. Next time, please enter a number");
            }
        }
        contactList.Remove(contactList[input - 1]);
        checkInList.Remove(checkInList[input - 1]);
    }
    public static void WriteToFile(List<Contact> contactList)
    {
        TextWriter tw = new StreamWriter("SavedList.txt");

        foreach (var person in contactList)
        {
            tw.WriteLine(Contact.GetInfo(person));
        }
        tw.Close();
    }
    public static void WriteToList(List<Contact> contactList, List<CheckIn> checkinList)
    {
        try
        {
            string filePath = ("/Users/sethpattee/Desktop/Test/FinalProjectLab/unit-testing-using-nunit/HotelManager.Console/SavedList.txt");
            //you might have to change this to make it work
            List<string> lines = new List<string>();
            List<Contact> contactlist = new List<Contact>();
            lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Contact p = new Contact(items[0], items[1], items[2], items[3], items[4]);
                contactList.Add(p);
                checkinList.Add(new CheckIn(DateTime.Now, CheckInStatus.NotCheckedIn));
            }
            List<string> outContents = new List<string>();
            foreach (var p in contactlist)
            {
                Console.WriteLine(Contact.GetInfo(p));
            }
            string outFile = ("/Users/sethpattee/Desktop/Test/FinalProjectLab/unit-testing-using-nunit/HotelManager.Console/SavedList.txt");
            //you might have to change this to make it work
            File.WriteAllLines(outFile, outContents);
        }
        catch
        {

        }
    }
    public static void ChangeStatus(List<Contact> contactList, List<CheckIn> checkInList)
    {
        Console.WriteLine("Who's status would you like to change? Enter their number");
        int input = 0;

        bool badInput = true;
        bool badInput2 = true;

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
            Console.WriteLine($"There are {counter} people stored.\nPlease enter the number of the person who's status would you like to change.");
            foreach (var person in contactList)
            {
                Console.WriteLine($"{counter2}: {person.FirstName}");
                counter2++;
            }
            //TODO Add a way to quit

            try
            {
                input = int.Parse(Console.ReadLine()!);
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

                Console.ReadLine();
                return;
                throw new YouEnteredALetter("You entered a letter. Now you have to restart. Next time, please enter a number");

            }
        }
        while (badInput2)
        {
            Console.WriteLine("Please enter the number of what you want to change their status to\n0:Checked in\n1:Checked out\n2:Not Checked In\n3:Quit");
            var option = Console.ReadLine();
            switch (option)
            {
                case "0":
                    CheckInStatus checkIn = CheckInStatus.CheckedIn;
                    checkInList[input - 1].status = checkIn;
                    checkInList[input - 1].LastUpdate = DateTime.Now;
                    Console.WriteLine("Done");
                    return;
                case "1":
                    CheckInStatus checkout = CheckInStatus.CheckedOut;
                    checkInList[input - 1].status = checkout;
                    checkInList[input - 1].LastUpdate = DateTime.Now;
                    Console.WriteLine("Done");
                    return;
                case "2":
                    CheckInStatus notcheckedin = CheckInStatus.CheckedIn;
                    checkInList[input - 1].status = notcheckedin;
                    checkInList[input - 1].LastUpdate = DateTime.Now;
                    Console.WriteLine("Done");
                    return;
                case "3":
                    return;
                default:
                    break;
            }
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

public enum CheckInStatus
{
    CheckedIn,
    CheckedOut,
    NotCheckedIn,
}