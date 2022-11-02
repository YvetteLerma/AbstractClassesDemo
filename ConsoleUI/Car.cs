using System;
namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public bool HasTruck { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("The car is driving.");
        }
    }
}

