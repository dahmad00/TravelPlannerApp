using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlanner
{
    public class BookingData
    {
        public BookingData(Location location)
        {
            hotels = new List<Hotel>();
            restaurants = new List<Restaurant>();
            houses = new List<GuestHouse>();
            //places = new List<Place>();

            this.location = location;
        }

        public string fileStr()
        {
            string str;

            str = location.Name + "$";

            //appending hotels
            Node<Hotel> itHotel = hotels.iterator();

            while (itHotel != null)
            {
                str += itHotel.data.Name;

                if (itHotel.next != null)
                {
                    str += ",";
                }

                itHotel = itHotel.next;
            }

            str += "$";

            //appending restaurants
            Node<Restaurant> itRestaurants = restaurants.iterator();

            while (itRestaurants != null)
            {
                str += itRestaurants.data.Name;

                if (itRestaurants.next != null)
                {
                    str += ",";
                }

                itRestaurants = itRestaurants.next;
            }

            str += "$";

            //appending Guest Houses
            Node<GuestHouse> itHouses = houses.iterator();

            while (itHouses != null)
            {
                str += itHouses.data.Name;

                if (itHouses.next != null)
                {
                    str += ",";
                }

                itHouses = itHouses.next;
            }

            str += "\n";

            return str;
        }

        public List<Hotel> hotels;
        public List<Restaurant> restaurants;
        public List<GuestHouse> houses;
        public List<Place> places;

        public Location location;
    }
}
