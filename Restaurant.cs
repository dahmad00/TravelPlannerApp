using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlanner
{
    public class Restaurant
    {
        //constructor
        public Restaurant(string name, Location location, int stars, int capacity, int strength)
        {
            this.Name = name;
            this.location = location;
            this.Stars = stars;
            this.Capacity = capacity;
            this.Strength = strength;
        }

        //constructor overloaded
        public Restaurant(string name, Location location, int stars)
        {
            this.Name = name;
            this.location = location;
            this.Stars = stars;
            this.Capacity = 100;
            this.Strength = 0;
        }

        //string for file
        public string FileStr()
        {
            string filestr = "";

            filestr = Name + "," + Stars + "," + Capacity + "," + Strength;

            return filestr;
        }

        //Name
        public string Name { get; set; }

        //Location
        public Location location;

        //Stars
        public int Stars { get; set; }

        //Total Capacity
        public int Capacity { get; set; }

        //Current Strength
        public int Strength { get; set; }

        //Is available for booking?
        public bool available()
        {
            if (Strength < Capacity)
            {
                return true;
            }

            return false;
        }

        public void addBooking()
        {
            if (Capacity > Strength)
            {
                Strength++;
            }
        }
        public void removeBooking()
        {
            Strength--;
        }
    }
}
