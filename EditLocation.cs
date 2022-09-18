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
    public partial class EditLocation : Form
    {
        public EditLocation(Location location, AVL locationTree, Form Parent)
        {
            InitializeComponent();
            this.location = location;
            this.locationTree = locationTree;
            this.ParentForm = Parent;
        }

        private void EditLocation_Load(object sender, EventArgs e)
        {
            labelName.Text = "Editing " + location.Name;


            //Loading Hotels
            Node<Hotel> itHotel = location.hotels.iterator();
            while (itHotel != null)
            {
                comboHotels.Items.Add(itHotel.data.Name);
                itHotel = itHotel.next;
            }
            comboHotels.Items.Add("Add New Hotel");

            //Loading Restaurants
            Node<Restaurant> itRestaurants = location.restaurants.iterator();
            while (itRestaurants != null)
            {
                comboRestaurants.Items.Add(itRestaurants.data.Name);
                itRestaurants = itRestaurants.next;
            }
            comboRestaurants.Items.Add("Add New Restaurant");

            //Loading GuestHouses
            Node<GuestHouse> itHouses = location.houses.iterator();
            while (itHouses != null)
            {
                comboHouses.Items.Add(itHouses.data.Name);
                itHouses = itHouses.next;
            }
            comboHouses.Items.Add("Add new Guesthouse");

            //Lodaing Places
            Node<Place> itPlaces = location.places.iterator();
            while (itPlaces != null)
            {
                comboPlaces.Items.Add(itPlaces.data.Name);
                itPlaces = itPlaces.next;
            }
            comboPlaces.Items.Add("Add New Place");

            //Loading Other locations from map
            locations = this.locationTree.getList();

            Node<Location> itLocation = locations.iterator();
            while (itLocation != null)
            {
                if (!itLocation.data.Equals(location))
                {
                    comboLocations.Items.Add(itLocation.data.Name);
                }
                itLocation = itLocation.next;
            }


        }

        Location location;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboHotels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboHotels.Text.Equals("Add New Hotel"))
            {
                this.hotelCapacity.Value = 10;
                this.hotelName.Text = "";
                this.hotelStars.Value = 1;
                return;
            }

            Hotel hotel = location.hotels.getT(comboHotels.Text);
            this.hotelCapacity.Value = hotel.Capacity;
            this.hotelStars.Value = hotel.Stars;
            this.hotelName.Text = hotel.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = hotelName.Text;

            //adding new hotel
            if (comboHotels.Text.Equals("Add New Hotel")) 
            {
                
                int stars = (int)hotelStars.Value;
                int capacity = (int)hotelCapacity.Value;
                Hotel hotel = new Hotel(name, location, stars, capacity, 0);

                if (location.hotels.search(name) == true)
                {
                    MessageBox.Show("Hotel with this name already exists");
                    return;
                }

                location.hotels.insertEnd(hotel, name);
                MessageBox.Show("Hotel Added Succesfuly");
            }

            //editing old hotel
            else
            {
                Node<Hotel> node = location.hotels.getNode(comboHotels.Text);
                node.data.Name = name;
                node.data.Capacity = (int)hotelCapacity.Value;
                node.data.Stars = (int)hotelStars.Value;
                node.name = name;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupHotels_Enter(object sender, EventArgs e)
        {

        }

        private void comboRestaurants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRestaurants.Text.Equals("Add New Restaurant"))
            {
                this.restaurantCapacity.Value = 10;
                this.restaurantName.Text = "";
                this.restaurantStars.Value = 1;
                return;
            }

            Restaurant restaurant = location.restaurants.getT(comboRestaurants.Text);
            this.restaurantCapacity.Value = restaurant.Capacity;
            this.restaurantStars.Value = restaurant.Stars;
            this.restaurantName.Text = restaurant.Name;
        }

        private void saveRestaurant_Click(object sender, EventArgs e)
        {
            string name = restaurantName.Text;

            //adding new restaurant
            if (comboRestaurants.Text.Equals("Add New Restaurant"))
            {

                int stars = (int)restaurantStars.Value;
                int capacity = (int)restaurantCapacity.Value;
                Restaurant restaurant = new Restaurant(name, location, stars, capacity, 0);

                if (location.restaurants.search(name) == true)
                {
                    MessageBox.Show("Restaurant with this name already exists");
                    return;
                }

                location.restaurants.insertEnd(restaurant, name);
                MessageBox.Show("Restaurant Added Succesfuly");
            }

            //editing old restaurant
            else
            {
                Node<Restaurant> node = location.restaurants.getNode(comboRestaurants.Text);
                node.data.Name = name;
                node.data.Capacity = (int)restaurantCapacity.Value;
                node.data.Stars = (int)restaurantStars.Value;
                node.name = name;
            }
        }

        private void comboHouses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboHouses.Text.Equals("Add New Guesthouse"))
            {
                this.houseCapacity.Value = 5;
                this.houseName.Text = "";
                this.houseStars.Value = 1;
                return;
            }

            GuestHouse guestHouse = location.houses.getT(comboHouses.Text);
            this.houseCapacity.Value = guestHouse.Capacity;
            this.houseStars.Value = guestHouse.Stars;
            this.houseName.Text = guestHouse.Name;
        }

        private void saveHouse_Click(object sender, EventArgs e)
        {
            string name = houseName.Text;

            //adding new guesthouse
            if (comboHouses.Text.Equals("Add New Guesthouse"))
            {

                int stars = (int)houseStars.Value;
                int capacity = (int)houseCapacity.Value;
                GuestHouse house = new GuestHouse(name, location, stars, capacity, 0);

                if (location.houses.search(name) == true)
                {
                    MessageBox.Show("Guesthouse with this name already exists");
                    return;
                }

                location.houses.insertEnd(house, name);
                MessageBox.Show("Guesthouse Added Succesfuly");
            }

            //editing old guesthouse
            else
            {
                Node<GuestHouse> node = location.houses.getNode(comboHouses.Text);
                node.data.Name = name;
                node.data.Capacity = (int)houseCapacity.Value;
                node.data.Stars = (int)houseStars.Value;
                node.name = name;
            }
        }

        private void comboPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPlaces.Text.Equals("Add New Place"))
            {
                this.placeName.Text = "";
                return;
            }

            Place place = location.places.getT(comboPlaces.Text);
            this.placeName.Text = place.Name;
        }

        private void savePlace_Click(object sender, EventArgs e)
        {
            string name = placeName.Text;

            //adding new Place
            if (comboPlaces.Text.Equals("Add New Place"))
            {

                Place place = new Place(name);

                if (location.places.search(name) == true)
                {
                    MessageBox.Show("Place with this name already exists");
                    return;
                }

                location.places.insertEnd(place, name);
                MessageBox.Show("Place Added Succesfuly");
            }

            //editing old Place
            else
            {
                Node<Place> node = location.places.getNode(comboPlaces.Text);
                node.data.Name = name;
                node.name = name;
            }
        }

        public AVL locationTree;

        private void comboLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            Node<AdjacentInfo> it = location.adjacencies.iterator();
            Location targetLocation = locationTree.getLocation(comboLocations.Text);

            //Checking if selected location is adjacent to given location
            bool adj = false;
            while (it != null)
            {
                if (it.data.Adjacent == targetLocation)
                {
                    adj = true;
                    break;
                }
                it = it.next;
            }

            //if adjacent
            if (adj == true)
            {
                AdjacentInfo adjInfo = it.data;
                this.distance.Value = adjInfo.Distance;
                this.airTime.Value = (decimal)adjInfo.AirTime;
                this.busTime.Value = (decimal)adjInfo.BusTime;
                this.carTime.Value = (decimal)adjInfo.CarTime;
            }

            //if not adjacent
            else
            {
                this.distance.Value = 0;
                this.airTime.Value = 0;
                this.busTime.Value = 0;
                this.carTime.Value = 0;

            }

        }

        public List<Location> locations;

        private void saveMap_Click(object sender, EventArgs e)
        {
            Node<AdjacentInfo> it = location.adjacencies.iterator();

            Location targetLocation = locationTree.getLocation(comboLocations.Text);

            //Checking adjacency
            bool adj = false;
            while (it != null)
            {
                if (it.data.Adjacent == targetLocation)
                {
                    adj = true;
                    break;
                }
                it = it.next;
            }

            //Update existing adjacency
            if (adj == true)
            {
                it.data.Distance = (int)distance.Value;
                it.data.AirTime = (int)airTime.Value;
                it.data.BusTime = (int)busTime.Value;
                it.data.CarTime = (int)carTime.Value;
                MessageBox.Show("Adjacency Edited Succesfuly");
            }

            //add new adjacency
            else
            {
                float busTime = (float)this.busTime.Value;
                float airTime = (float)this.airTime.Value;
                float carTime = (float)this.carTime.Value;
                int distance = (int)this.distance.Value;

                AdjacentInfo adjInfo = new AdjacentInfo(targetLocation, distance, airTime, busTime, carTime);
                location.adjacencies.insertEnd(adjInfo, targetLocation.Name);
                MessageBox.Show("Adjacency Added Succesfuly");
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            //Update files
            Node<Location> it = locations.iterator();

            while (it != null)
            {
                it.data.writeToFile();
                it = it.next;
            }

            

            ParentForm.Show();
            this.Hide();
        }

        public Form ParentForm;

        private void saveRestaurant_Click_1(object sender, EventArgs e)
        {
            string name = restaurantName.Text;

            //adding new restaurant
            if (comboRestaurants.Text.Equals("Add New Restaurant"))
            {

                int stars = (int)restaurantStars.Value;
                int capacity = (int)restaurantCapacity.Value;
                Restaurant restaurant = new Restaurant(name, location, stars, capacity, 0);

                if (location.restaurants.search(name) == true)
                {
                    MessageBox.Show("Restaurant with this name already exists");
                    return;
                }

                location.restaurants.insertEnd(restaurant, name);
                MessageBox.Show("Restaurant Added Succesfuly");
            }

            //editing old restaurant
            else
            {
                Node<Restaurant> node = location.restaurants.getNode(comboRestaurants.Text);
                node.data.Name = name;
                node.data.Capacity = (int)restaurantCapacity.Value;
                node.data.Stars = (int)restaurantStars.Value;
                node.name = name;
            }
        }

        private void groupRestaurants_Enter(object sender, EventArgs e)
        {

        }
    }
}
