using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlanner
{
    public class AdjacentInfo
    {
        //Constructor
        public AdjacentInfo(Location adjacent, int distance, float airTime = 0, float busTime = 0, float carTime = 0)
        {
            this.Adjacent = adjacent;
            this.Distance = distance;
            this.AirTime = airTime;
            this.BusTime = busTime;
            this.CarTime = carTime;

            djkDistance = float.MaxValue;
        }
        
        //string for file
        public string fileStr()
        {
            string strFile;

            strFile = Adjacent.Name + "," + Distance + "," + AirTime + "," + BusTime + "," + CarTime;
            return strFile;
        }


        public Location Adjacent;
        public int Distance { get; set; }
        public float AirTime { get; set; }
        public float BusTime { get; set; }
        public float CarTime { get; set; }

        public float djkDistance;
    }
    public class Location
    {
        public Location()
        {
        }

        public Location(string locationName)
        {
            path = Directory.GetCurrentDirectory() + "\\";

            using (StreamReader streamReader = new StreamReader(path + locationName + ".txt"))
            {
                this.Name = locationName;

                //Reading and initializing hotels
                string str = streamReader.ReadLine();
                string[] strHotels = str.Split('$');
                for (int i = 0; i < strHotels.Length; i++)
                {
                    string[] data = strHotels[i].Split(',');

                    if (data.Length <= 1)
                    {
                        continue;
                    }

                    string name = data[0];
                    int stars = Int32.Parse(data[1]);
                    int capacity = Int32.Parse(data[2]);
                    int strength = Int32.Parse(data[3]);

                    addHotel(name, stars, capacity, strength);
                }

                //Reading and initializing restaurants
                str = streamReader.ReadLine();
                string[] strRestaurants = str.Split('$');
                for (int i = 0; i < strRestaurants.Length; i++)
                {
                    string[] data = strRestaurants[i].Split(',');

                    if (data.Length <= 1)
                    {
                        continue;
                    }

                    string name = data[0];
                    int stars = Int32.Parse(data[1]);
                    int capacity = Int32.Parse(data[2]);
                    int strength = Int32.Parse(data[3]);

                    addRestaurant(name, stars, capacity, strength);
                }

                //Reading and initializing guest houses
                str = streamReader.ReadLine();
                string[] strHouses = str.Split('$');
                for (int i = 0; i < strHouses.Length; i++)
                {
                    string[] data = strHouses[i].Split(',');

                    if (data.Length <= 1)
                    {
                        continue;
                    }

                    string name = data[0];
                    int stars = Int32.Parse(data[1]);
                    int capacity = Int32.Parse(data[2]);
                    int strength = Int32.Parse(data[3]);

                    addHouse(name, stars, capacity, strength);
                }

                //Reading and Initializing Places
                str = streamReader.ReadLine();
                string[] places = str.Split('$');
                for (int i = 0; i < places.Length; i++)
                {
                    addPlace(places[i]);
                }

                //reading adjacency string
                str = streamReader.ReadLine();

                adjString = str;
            }

            visited = false;
            weight = float.MaxValue;

            shortestPath = new List<Location>();

        }

        //Add Guest House
        void addHouse(string name, int stars, int capacity, int strength)
        {
            GuestHouse guestHouse = new GuestHouse(name, this, stars, capacity, strength);
            houses.insertEnd(guestHouse, name);
        }

        //Add a hotel
        void addHotel(string name, int stars, int capacity, int strength)
        {
            //string name, Location location, Stars stars, int capacity
            Hotel hotel = new Hotel(name, this, stars, capacity, strength);
            hotels.insertEnd(hotel, name);
        }

        //Overloaded - Add a Hotel
        void addHotel(string name, int stars)
        {
            Hotel hotel = new Hotel(name, this, stars);
            hotels.insertEnd(hotel, name);
        }

        //Add a restaurant
        void addRestaurant(string name, int stars, int capacity, int strength)
        {
            Restaurant restaurant = new Restaurant(name, this, stars, capacity, strength);
            restaurants.insertEnd(restaurant, name);
        }

        //Add a Place
        void addPlace(string name)
        {
            Place place = new Place(name);
            places.insertEnd(place, name);
        }

        public void setAdjacencies(AVL locationTree)
        {
            string[] adj = adjString.Split('$');

            for (int i = 0; i < adj.Length; i++)
            {
                string[] adjacency = adj[i].Split(',');

                if (adjacency.Length <= 1)
                {
                    continue;
                }

                Location location = locationTree.getLocation(adjacency[0]);
                int distance = Int32.Parse(adjacency[1]);
                float airTime = float.Parse(adjacency[2]);
                float busTime = float.Parse(adjacency[3]); 
                float carTime = float.Parse(adjacency[4]);

                AdjacentInfo adjInfo = new AdjacentInfo(location, distance, airTime, busTime, carTime);
                adjacencies.insertEnd(adjInfo, location.Name);
            }
        }

        //Get Path by DFS Search
        public List<Location> getPath(Location Destination)
        {
            List<Location> path = new List<Location>();
            Stack stack = new Stack();

            stack.addLocation(this);
            this.visited = true;

            while (!stack.isEmpty())
            {
                

                Location current = stack.popLocation();
                Node<AdjacentInfo> it = current.adjacencies.iterator();

                //path.insertEnd(current, current.Name);

                if (current == Destination)
                {
                    return path;
                }

                while (it != null)
                {
                    if (it.data.Adjacent.visited == false)
                    {
                        stack.addLocation(it.data.Adjacent);
                        it.data.Adjacent.visited = true;
                    }
                    it = it.next;
                }
            }

            return path;

        }

        //dijkstra path by air time
        public List<Location> dijkstraAirPath(AVL locationTree, Location destination)
        {

            resetVisits(locationTree);
            Stack stackLocation = new Stack();
            this.weight = 0;

            stackLocation.addLocation(this);
            this.visited = true;

            //DFS Search
            while (stackLocation.isEmpty() == false)
            {
                Location current = stackLocation.popLocation();

                current.shortestPath.insertEnd(current, current.Name);


                Node<AdjacentInfo> it = current.adjacencies.iterator();


                //iterating each adjacency
                while (it != null)
                {
                    //setting weight
                    if (it.data.Adjacent.weight > current.weight + it.data.AirTime)
                    {
                        it.data.Adjacent.weight = current.weight + it.data.AirTime;
                        it.data.Adjacent.shortestPath = current.shortestPath.clone();

                        it.data.Adjacent.shortestPath.insertEnd(it.data.Adjacent, it.data.Adjacent.Name);
                    }

                    //adding to stack
                    if (it.data.Adjacent.visited == false && it.data.AirTime > 1)
                    {
                        stackLocation.addLocation(it.data.Adjacent);
                        it.data.Adjacent.visited = true;
                    }
                    it = it.next;
                }
            }

            return destination.shortestPath;
        }

        //dijkstra path by car time
        public List<Location> dijkstraCarPath(AVL locationTree, Location destination)
        {

            resetVisits(locationTree);
            Stack stackLocation = new Stack();
            this.weight = 0;

            stackLocation.addLocation(this);
            this.visited = true;

            //DFS Search
            while (stackLocation.isEmpty() == false)
            {
                Location current = stackLocation.popLocation();

                current.shortestPath.insertEnd(current, current.Name);


                Node<AdjacentInfo> it = current.adjacencies.iterator();


                //iterating each adjacency
                while (it != null)
                {
                    //setting weight
                    if (it.data.Adjacent.weight > current.weight + it.data.CarTime)
                    {
                        it.data.Adjacent.weight = current.weight + it.data.CarTime;
                        it.data.Adjacent.shortestPath = current.shortestPath.clone();

                        it.data.Adjacent.shortestPath.insertEnd(it.data.Adjacent, it.data.Adjacent.Name);
                    }

                    //adding to stack
                    if (it.data.Adjacent.visited == false && it.data.CarTime > 1)
                    {
                        stackLocation.addLocation(it.data.Adjacent);
                        it.data.Adjacent.visited = true;
                    }
                    it = it.next;
                }
            }

            return destination.shortestPath;
        }

        //dijsktra path by bus time
        public List<Location> dijkstraBusPath(AVL locationTree, Location destination)
        {

            resetVisits(locationTree);
            Stack stackLocation = new Stack();
            this.weight = 0;

            stackLocation.addLocation(this);
            this.visited = true;

            //DFS Search
            while (stackLocation.isEmpty() == false)
            {
                Location current = stackLocation.popLocation();

                current.shortestPath.insertEnd(current, current.Name);


                Node<AdjacentInfo> it = current.adjacencies.iterator();


                //iterating each adjacency
                while (it != null)
                {
                    //setting weight
                    if (it.data.Adjacent.weight > current.weight + it.data.BusTime)
                    {
                        it.data.Adjacent.weight = current.weight + it.data.BusTime;
                        it.data.Adjacent.shortestPath = current.shortestPath.clone();

                        it.data.Adjacent.shortestPath.insertEnd(it.data.Adjacent, it.data.Adjacent.Name);
                    }

                    //adding to stack
                    if (it.data.Adjacent.visited == false && it.data.BusTime > 1)
                    {
                        stackLocation.addLocation(it.data.Adjacent);
                        it.data.Adjacent.visited = true;
                    }
                    it = it.next;
                }
            }

            return destination.shortestPath;
        }



        //dijsktra path
        public List<Location> dijsktraPath(AVL locationTree, Location destination)
        {
            resetVisits(locationTree);
            Stack stackLocation = new Stack();
            this.weight = 0;

            stackLocation.addLocation(this);
            this.visited = true;

            //DFS Search
            while (stackLocation.isEmpty() == false)
            {
                Location current = stackLocation.popLocation();

                current.shortestPath.insertEnd(current, current.Name);


                Node<AdjacentInfo> it = current.adjacencies.iterator();

                
                //iterating each adjacency
                while (it != null)
                {
                    //setting weight
                    if (it.data.Adjacent.weight > current.weight + it.data.Distance)
                    {
                        it.data.Adjacent.weight = current.weight + it.data.Distance;
                        it.data.Adjacent.shortestPath = current.shortestPath.clone();

                        it.data.Adjacent.shortestPath.insertEnd(it.data.Adjacent, it.data.Adjacent.Name);
                    }

                    //adding to stack
                    if (it.data.Adjacent.visited == false)
                    {
                        stackLocation.addLocation(it.data.Adjacent);
                        it.data.Adjacent.visited = true;
                    }
                    it = it.next;
                }
            }

            return destination.shortestPath;
        }

        //reset all visits
        public void resetVisits(AVL locationTree)
        {
            List<Location> vertices = locationTree.getList();
            Node<Location> it = vertices.iterator();

            while (it != null)
            {
                it.data.shortestPath.makeEmpty();
                it.data.weight = float.MaxValue;
                it.data.resetVisit();
                it = it.next;
            }
        }

        public void resetVisit()
        {
            this.visited = false;
        }

        //Hotels
        public List<Hotel> hotels = new List<Hotel>();

        //Guest Houses
        public List<GuestHouse> houses = new List<GuestHouse>();
        
        //Restaurants
        public List<Restaurant> restaurants = new List<Restaurant>();

        //Places
        public List<Place> places = new List<Place>();

        //Adjacencies
        public List<AdjacentInfo> adjacencies = new List<AdjacentInfo>();

        //string for file
        public string FileStr()
        {
            string filestr = "";


            //saving hotels data
            Node<Hotel> itHotel = hotels.iterator();
            while (itHotel != null)
            {
                filestr = filestr + itHotel.data.FileStr();
                itHotel = itHotel.next;

                if (itHotel != null)
                {
                    filestr += "$";
                }
            }

            filestr += "\n";

            //saving restaurants data
            Node<Restaurant> itRestaurant = restaurants.iterator();
            while (itRestaurant != null)
            {
                filestr = filestr + itRestaurant.data.FileStr();
                itRestaurant = itRestaurant.next;

                if (itRestaurant != null)
                {
                    filestr += "$";
                }
            }

            filestr += "\n";

            //saving GuestHouses Data
            Node<GuestHouse> itHouse = houses.iterator();
            while (itHouse != null)
            {
                filestr = filestr + itHouse.data.FileStr();
                itHouse = itHouse.next;

                if (itHouse != null)
                {
                    filestr += "$";
                }
            }

            filestr += "\n";

            //saving places data
            Node<Place> itPlace = places.iterator();
            while (itPlace != null)
            {
                filestr = filestr + itPlace.data.FileStr();
                itPlace = itPlace.next;

                if (itPlace != null)
                {
                    filestr += "$";
                }
            }

            filestr += "\n";

            //Saving adjacencies
            Node<AdjacentInfo> itAdj = adjacencies.iterator();
            while (itAdj != null)
            {
                filestr = filestr + itAdj.data.fileStr();
                itAdj = itAdj.next;

                if (itAdj != null)
                {
                    filestr += "$";
                }
            }

            filestr += "\n";
            return filestr;
        }

        //write to file
        public void writeToFile()
        {
            string fileName = path + Name + ".txt";
            using(StreamWriter writer = new StreamWriter(fileName))
            {
                string filestr = FileStr();

                writer.Write(filestr);
            }
        }

        //name
        public string Name { get; set; }

        public string path;

        private string adjString;

        //distance value - utility
        public bool visited;

        //shortest distance - utility for dijkstra
        public float weight;

        //shortest path from source node
        List<Location> shortestPath;
    }
}
