using System;
using System.Collections.Generic;

namespace Week04.HotelApp
{
    public class Hotel
    {
        public Hotel(string name, string city, int stars, List<Room> rooms)
        {
            this.Name = name;
            this.City = city;
            this.Stars = stars;
            this.Rooms = rooms;
        }

        public string Name { get; set; }

        public string City { get; set; }

        public int Stars { get; set; }

        public List<Room> Rooms { get; set; }

        public void Print()
        {
            Console.WriteLine($"Hotel: {Name}");
            Console.WriteLine($"\tCity: {City}, Stars: {Stars}");
            foreach (var room in Rooms)
            {
                room.Print();
            }
        }

        public decimal GetPriceForAllRooms()
        {
            decimal x = 0;

            foreach (var room in Rooms)
            {
                x = x + room.Rate.Amount;
            }

            return x;
        }
    }
}