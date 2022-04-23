namespace HotelManager;

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





