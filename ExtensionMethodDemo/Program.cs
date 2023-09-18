namespace ExtensionMethodDemo;

class Program
{
    static void Main(string[] args)
    {
        PersonModel person = new PersonModel { Name = "bob"};

        Console.WriteLine(person.SetDefaultAge().PrintInfo()); 


        HotelRoomModel room = new HotelRoomModel();

        room.TurnOnAir().SetTemperature(72).OpenShades();

        room.TurnOffAir().CloseShades();

        "hello world".PrintToConsole();

        Console.ReadLine();
    }
}

public class HotelRoomModel
{
    public int Temperature { get; set; }
    public bool IsAirRunning { get; set; }
    public bool AreShadesOpen { get; set; }
}

public class PersonModel
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public static class ExtensionSamples
{
    public static PersonModel SetDefaultAge(this PersonModel person)
    {
        person.Age = 30;
        return person;
    }

    public static string PrintInfo(this PersonModel person)
    {
        return $"{person.Name} : {person.Age}";
    }

    public static HotelRoomModel TurnOnAir(this HotelRoomModel room)
    {
        room.IsAirRunning = true;
        return room;
    }

    public static HotelRoomModel TurnOffAir(this HotelRoomModel room)
    {
        room.IsAirRunning = false;
        return room;
    }

    public static HotelRoomModel SetTemperature (this HotelRoomModel room, int temperature)
    {
        room.Temperature = temperature;
        return room;
    }

    public static HotelRoomModel OpenShades(this HotelRoomModel room)
    {
        room.AreShadesOpen = true;
        return room;
    }

    public static HotelRoomModel CloseShades(this HotelRoomModel room)
    {
        room.AreShadesOpen = false;
        return room;
    }

    public static void PrintToConsole(this string message)
    {
        Console.WriteLine(message);
    }
}