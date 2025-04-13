
using System;

public class HotelProgram
{
    public static void Main()
    {
        
        Room room1 = new Room(415, "Double", true);

        Guest guest1 = new Guest("Ali", 223);

        if (room1.CheckAvailability())
        {
            Booking booking1 = new Booking(guest1, room1, 20250410);

            Console.WriteLine(booking1.GetBookingDetails());
        }
        else
        {
            Console.WriteLine("Room is not available.");
        }
    }
}
public class Room
{
    private int roomNumber;
    public string type;
    public bool isAvailable;

    public Room(int roomNumber, string type, bool isAvailable)
    {
        this.roomNumber = roomNumber;
        this.type = type;
        this.isAvailable = true;
    }

    public  bool CheckAvailability()
    {
        return isAvailable;
    }
    public void MarkAsBooked()
    {
        isAvailable = false;
    }

    public void MarkAsAvailable()
    {
        isAvailable = true;
    }
}

public class  Guest 
{
    public string name;
    public int guestId;

    public Guest(string name, int guestId)
    {
        this.name = name;
        this.guestId = guestId;
    }
    public string getGuestInfo()
    {
        return $"Guest ID: {guestId}, Name: {name}";
    }
}

public class  Booking 
{
    public Guest guest;        
    public Room room;          
    public int checkInDate;

    public Booking(Guest guest, Room room, int checkInDate)
    {
        this.guest = guest;
        this.room = room;
        this.checkInDate = checkInDate;

        room.MarkAsBooked();
    }

    public string GetBookingDetails()
    {
        return $"Booking for {guest.name} (ID: {guest.guestId})\n" +
               $"Room Type: {room.type}, Check-in Date: {checkInDate}\n" +
               $"Room Available: {room.isAvailable}";
    }
}