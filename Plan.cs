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
    public partial class Plan : Form
    {
        public Plan(User user, Location location, int number, Form ParentForm, Node<Location> it)
        {
            this.user = user;
            this.location = location;
            this.number = number;
            this.it = it;
            this.parentForm = ParentForm;
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
                      
        }
        private void Plan_Load(object sender, EventArgs e)
        {
            labelLocation.Text = "Planning for " + location.Name;

            //loading combo hotels
            Node<Hotel> itHotel = location.hotels.iterator();

            while (itHotel != null)
            {
                comboHotels.Items.Add(itHotel.data.Name);
                comboHotels.Text = itHotel.data.Name;
                itHotel = itHotel.next;
            }

            //Loading combo restaurants
            Node<Restaurant> itRestaurant = location.restaurants.iterator();

            while (itRestaurant != null)
            {
                comboRestaurants.Items.Add(itRestaurant.data.Name);
                comboRestaurants.Text = itRestaurant.data.Name;
                itRestaurant = itRestaurant.next;
            }

            //Loading combo Houses
            Node<GuestHouse> itHouse = location.houses.iterator();

            while (itHouse != null)
            {
                comboHouses.Items.Add(itHouse.data.Name);
                comboHouses.Text = itHouse.data.Name;
                itHouse = itHouse.next;
            }
        }

        private void labelLocation_Click(object sender, EventArgs e)
        {
            
        }

        public User user;
        public Location location;
        int number;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        Node<Location> it;
        Form parentForm;

        private void buttonBookHotel_Click(object sender, EventArgs e)
        {
            string name = comboHotels.Text;

            Hotel hotel = location.hotels.getT(name);

            BookingData bookingData = user.bookings.getT(location.Name);

            if (bookingData.hotels.search(hotel.Name))
            {
                MessageBox.Show("You have already booked this hotel");
            }
            else if (hotel.available() == false)
            {
                MessageBox.Show("Sorry. This hotel is already booked");
            }
            else
            {
                hotel.addBooking();
                bookingData.hotels.insertEnd(hotel, name);
            }
            
        }

        private void labelHotelStars_Click(object sender, EventArgs e)
        {

        }

        private void comboHotels_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comboHotels.Text;
            Hotel hotel = location.hotels.getT(name);
            this.labelHotelStars.Text = "Stars: " + hotel.Stars;
        }

        private void comboRestaurants_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comboRestaurants.Text;
            Restaurant restaurant = location.restaurants.getT(name);
            this.labelHotelStars.Text = "Stars: " + restaurant.Stars;
        }

        private void buttonBookRestaurant_Click(object sender, EventArgs e)
        {
            string name = comboRestaurants.Text;

            Restaurant restaurant = location.restaurants.getT(name);

            BookingData bookingData = user.bookings.getT(location.Name);
            if (bookingData.restaurants.search(restaurant.Name))
            {
                MessageBox.Show("You have already booked this restaurant");
            }
            else if (restaurant.available() == false)
            {
                MessageBox.Show("This restaurant is already booked");
            }
            else
            {
                restaurant.addBooking();
                bookingData.restaurants.insertEnd(restaurant, name);
            }
            
        }

        private void comboHouses_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comboHouses.Text;
            GuestHouse house = location.houses.getT(name);
            this.labelHouseStars.Text = "Stars: " + house.Stars;
        }

        private void buttonBookHouse_Click(object sender, EventArgs e)
        {
            string name = comboHouses.Text;

            GuestHouse house = location.houses.getT(name);

            BookingData bookingData = user.bookings.getT(location.Name);
            if (bookingData.houses.search(house.Name))
            {
                MessageBox.Show("You have already booked this guesthouse");
            }
            else
            {
                house.addBooking();
                bookingData.houses.insertEnd(house, name);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (it.next != null)
            {
                Plan plan = new Plan(user, it.next.data, number + 1, ParentForm, it.next);
                plan.Show();
                
            }
            else
            {
                user.saveToFile();
                user.isEmpty = false;
                base.OnClosed(e);
            }
            this.Close();
        }

        private void groupRestaurant_Enter(object sender, EventArgs e)
        {

        }
    }
}
