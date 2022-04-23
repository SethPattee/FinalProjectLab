namespace HotelManager;

public class CheckIn
{
    public DateTime lastUpdate;
    public CheckInStatus status;
    public CheckIn(DateTime lastUpdate, CheckInStatus status)
    {
        LastUpdate = lastUpdate;
        Status = status;

    }
    public DateTime LastUpdate { get; set; }
    public CheckInStatus Status { get; set; }


}





