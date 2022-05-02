using CIS4930.models;

namespace ItemList.API.Database
{
    static public class FakeDatabase
    {
        public static List<int> Ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public static List<double> Doubles = new List<double> { 3.14, 2.80, 5.5 };

        public static List<Item> Appointments = new List<Item>
        {
            new Appointment{Name = "Appointment 1", Description="Appointment 1 Desc", Start=DateTime.Today, Id = 1},

        };

        public static List<Item> Tasks = new List<Item>
        {
            new Tasks{Name = "ToDo 1", Description="ToDo 1 Desc", isCompleted=false, Id = 2}
        };
    }
}
