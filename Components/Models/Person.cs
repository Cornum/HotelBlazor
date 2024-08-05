using static HotelBlazer.Components.Pages.MainPage;

namespace HotelBlazer.Components.Models
{
    public class Person
    {
        public DateTime DayStart { get; }
        public int Days { get; }
        public string Name { get; }
        public int Room { get; }
        public BookingStatus Status { get; set; }

        public Person(DateTime dayStart, int days, string name, int room, BookingStatus status)
        {
            DayStart = dayStart;
            Days = days;
            Name = name;
            Room = room;
            Status = status;
        }
    }
}
