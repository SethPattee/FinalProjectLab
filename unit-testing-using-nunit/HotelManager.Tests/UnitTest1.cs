using System;
using System.Collections.Generic;
using NUnit.Framework;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Microsoft.VisualStudio.QualityTools.UnitTestFramework.dll;
//using Microsoft.VisualStudio.TestPlatform.TestFramework.dll;
namespace HotelManager.Tests;

//tests
public class Tests
{
    [SetUp]
    public void Setup()
    {
        List<Contact> contactList = new List<Contact>();
        contactList.Add(new Contact("Bob", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));


    }

    [Test]
    public void Test1Adding1Person()
    {
        List<Contact> contactList = new List<Contact>();
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        Assert.AreEqual((Contact.GetInfo("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234")), Contact.GetInfo(contactList[0]));
    }
    [Test]
    public void Adding2People()
    {
        List<Contact> contactList = new List<Contact>();
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        Assert.AreEqual((Contact.GetInfo("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234")), Contact.GetInfo(contactList[0]));
        Assert.AreEqual((Contact.GetInfo("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234")), Contact.GetInfo(contactList[1]));
    }
    [Test]
    public void AddingALotOfPeople()
    {
        List<Contact> contactList = new List<Contact>();
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("I", "Am", "The", "Batman", "here"));
        contactList.Add(new Contact("Chuck", "Norris", "#1 Winnerlane", "Winning land", "telephety"));
        Assert.AreEqual((Contact.GetInfo("I", "Am", "The", "Batman", "here")), Contact.GetInfo(contactList[22]));
        Assert.AreEqual((Contact.GetInfo("Chuck", "Norris", "#1 Winnerlane", "Winning land", "telephety")), Contact.GetInfo(contactList[23]));
    }
    [Test]
    public void WriteTofileWithoutMakingNewFile()
    {
        List<Contact> contactList = new List<Contact>();
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("I", "Am", "The", "Batman", "here"));
        contactList.Add(new Contact("Chuck", "Norris", "#1 Winnerlane", "Winning land", "telephety"));
        ControlMethods.WriteToFile(contactList);
        Assert.AreEqual((Contact.GetInfo("I", "Am", "The", "Batman", "here")), Contact.GetInfo(contactList[22]));
        Assert.AreEqual((Contact.GetInfo("Chuck", "Norris", "#1 Winnerlane", "Winning land", "telephety")), Contact.GetInfo(contactList[23]));

    }
    [Test]
    public void ReadFromFile()
    {
        List<Contact> contactList = new List<Contact>();
        var checkInList = new List<CheckIn>();
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        contactList.Add(new Contact("Bob", "Marley", "#1 Ragge lane", "Jamaica", "123-123-1234"));
        contactList.Add(new Contact("I", "Am", "The", "Batman", "here"));
        contactList.Add(new Contact("Chuck", "Norris", "#1 Winnerlane", "Winning land", "telephety"));
        ControlMethods.WriteToFile(contactList);
        ControlMethods.WriteToList(contactList, checkInList);
        Assert.AreEqual((Contact.GetInfo("I", "Am", "The", "Batman", "here")), Contact.GetInfo(contactList[22]));
        Assert.AreEqual((Contact.GetInfo("Chuck", "Norris", "#1 Winnerlane", "Winning land", "telephety")), Contact.GetInfo(contactList[23]));
    }
     [Test]
    public void ChangingStatus()
    {
        List<Contact> contactList = new List<Contact>();
        List<CheckIn> checkInList = new List<CheckIn>();
        DateTime now = DateTime.Now;
        contactList.Add(new Contact("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234"));
        checkInList.Add(new CheckIn(now, CheckInStatus.NotCheckedIn));
        Assert.AreEqual((Contact.GetInfo("Dick", "Grayson", "1227 Gothem street", "Gothem", "123-123-1234")), Contact.GetInfo(contactList[0]));
        Assert.AreEqual(now, checkInList[0].LastUpdate);
        Assert.AreEqual(CheckInStatus.NotCheckedIn, checkInList[0].Status);

    }
}
