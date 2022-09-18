using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelPlanner
{
    public partial class MyPlan : Form
    {
        public MyPlan(User user, Form parentForm, AVL locationTree)
        {
            this.user = user;
            this.parentForm = parentForm;
            this.locationTree = locationTree;

            InitializeComponent();
        }

        private void MyPlan_Load(object sender, EventArgs e)
        {
            string labelText = "";
            //user.getDataFromFile(locationTree);
            List<BookingData> bookings = user.bookings;
            Node<BookingData> it = bookings.iterator();

            while (it != null)
            {
                BookingData current = it.data;

                labelText += "Location: " + current.location.Name + Environment.NewLine;
                
                List<Hotel> hotels = current.hotels;

                //hotel names to label
                labelText += "Hotels: ";
                Node<Hotel> itHotels = hotels.iterator();
                if (itHotels == null)
                {
                    labelText += "None";
                }
                while (itHotels != null)
                {
                    labelText += itHotels.data.Name;
                    itHotels = itHotels.next;

                    if (itHotels != null)
                    {
                        labelText += ", ";
                    }
                }

                labelText += Environment.NewLine;

                //Restaurant names to label
                List<Restaurant> restaurants = current.restaurants;
                Node<Restaurant> itRestaurants = restaurants.iterator();

                labelText += "Restaurants: ";
                if (itRestaurants == null)
                {
                    labelText += "None";
                }

                while (itRestaurants != null)
                {
                    labelText += itRestaurants.data.Name;
                    itRestaurants = itRestaurants.next;

                    if (itRestaurants != null)
                    {
                        labelText += ", ";
                    }
                }
                labelText += Environment.NewLine;


                //Guesthouse names to labels
                List<GuestHouse> houses = current.houses;
                Node<GuestHouse> itHouses = houses.iterator();

                labelText += "Guesthouses: ";
                if (itHouses == null)
                {
                    labelText += "None";
                }

                while (itHouses != null)
                {
                    labelText += itHouses.data.Name;
                    itHouses = itHouses.next;

                    if (itHouses != null)
                    {
                        labelText += ", ";
                    }
                }

                labelText += Environment.NewLine;
                labelText += Environment.NewLine;

                it = it.next;
            }

            labelPlan.Text = labelText;
        }

        public User user;
        public Form parentForm;
        public AVL locationTree;

        private void button1_Click(object sender, EventArgs e)
        {
            user.clear();
            this.Close();
        }
    }
}
