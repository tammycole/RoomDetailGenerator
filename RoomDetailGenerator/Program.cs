using System;

namespace RoomDetailGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            string response;

            do
            { //Could we make a method here in order to run through another room? 
                double roomLength, roomWidth, roomHeight = 0;

                Console.WriteLine("Which room are we measuring today?");
                string roomName = Console.ReadLine();
                Console.WriteLine("Enter Room Length");
                roomLength = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Room Width");
                roomWidth = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Room Height");
                roomHeight = double.Parse(Console.ReadLine());

                double area = roomLength * roomWidth;
                double perimeter = roomLength * 2 + roomWidth * 2;
                double volume = roomLength * roomWidth * roomHeight;
                Console.WriteLine("Measurements for " + roomName + ":");
                Console.WriteLine("The area is " + area);
                Console.WriteLine("The perimeter is " + perimeter);
                Console.WriteLine("The volume is " + volume);

                Console.WriteLine("Continue to another room? Y/N");
                string response = (Console.ReadLine());
            }

            while (response == "Y" || response == "y");
        }
    }
}
