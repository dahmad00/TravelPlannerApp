using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlanner
{
    class Map
    {
        public Map(AVL locationTree)
        {
            locations = locationTree.getList();
        }

        //get location from name
        Location getLocation(string name)
        {
            Node<Location> it = locations.iterator();

            while (it != null)
            {
                if (it.data.Name.Equals(name))
                {
                    return it.data;
                }
                it = it.next;
            }

            return null;
        }

        public List<Location> locations;
        
    }
}
