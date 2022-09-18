using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlanner
{
    public class User
    {
        public User(string fileStr)
        {
            filePath = Directory.GetCurrentDirectory() + "\\Users\\";
        }

        public User(string name, Location location, bool isAdmin)
        {
            Name = name;
            Location = location;
            Admin = isAdmin;
            Path = new List<Location>();
            bookings = new List<BookingData>();
            isEmpty = true;

            filePath = Directory.GetCurrentDirectory() +  "\\Users\\";
        }

        //set path
        public void setPath(List<Location> path)
        {
            Node<Location> it = path.iterator();
            this.Path = new List<Location>();
            this.bookings = new List<BookingData>();

            while (it != null)
            {
                this.Path.insertEnd(it.data, it.data.Name);

                BookingData booking = new BookingData(it.data);
                bookings.insertEnd(booking, it.data.Name);

                it = it.next;
            }
        }

        public void saveToFile()
        {
            using (StreamWriter writer = new StreamWriter(filePath + Name + ".txt"))
            {
                Node<BookingData> it = bookings.iterator();

                while (it != null)
                {
                    string str = it.data.fileStr();
                    writer.Write(str);
                    it = it.next;
                }
            }
        }

        //clear booking data
        public void clear()
        {
            bookings.makeEmpty();
            Path.makeEmpty();
        }

        //read from file
        public void getDataFromFile(AVL locationTree)
        {
            using (StreamReader reader = new StreamReader(filePath + Name + ".txt"))
            {
                if (reader.Peek() == -1)
                {
                    isEmpty = true;
                }
                else
                {
                    isEmpty = false;
                }

                while (reader.Peek() != -1)
                {
                    string line = reader.ReadLine();

                    string[] data = line.Split('$');

                    //location name
                    string name = data[0];
                    Location location = locationTree.getLocation(name);
                    Path.insertEnd(location, name);
                    BookingData booking = new BookingData(location);

                    //Getting hotels
                    string hotelStr = data[1];
                   
                    if (hotelStr.Length > 0)
                    {
                        string[] hotels = hotelStr.Split(',');

                        for (int i = 0; i < hotels.Length; i++)
                        {
                            Hotel hotel = location.hotels.getT(hotels[i]);
                            booking.hotels.insertEnd(hotel, hotel.Name);
                        }

                    }

                    //Getting Restaurants
                    string restaurantStr = data[2];
                    if (restaurantStr.Length > 0)
                    {
                        string[] restaurants = restaurantStr.Split(',');

                        for (int i = 0; i < restaurants.Length; i++)
                        {
                            Restaurant restaurant = location.restaurants.getT(restaurants[i]);
                            booking.restaurants.insertEnd(restaurant, restaurant.Name);
                        }
                    }

                    //Getting Guest houses
                    string houseStr = data[3];
                    if (houseStr.Length > 0)
                    {
                        string[] houses = houseStr.Split(',');

                        for (int i = 0; i < houses.Length; i++)
                        {
                            GuestHouse house = location.houses.getT(houses[i]);
                            booking.houses.insertEnd(house, house.Name);
                        }
                    }

                    this.bookings.insertEnd(booking, location.Name);
                }
            }
        }

        string filePath;

        public List<BookingData> bookings;
        public List<Location> Path;

        public string Name { get; set; }
        public Location Location { get; set; }
        public bool Admin { get; set; }

        public bool isEmpty;
        

    }
}
