using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var door = DoorFactory.CreateDoor(100, 200);

            Console.WriteLine($"Ширина созданной двери: {door.GetWidth()}");
            Console.WriteLine($"высота созданной двери: {door.GetHeight()}");

            Console.ReadKey();
        }
    }
}
