using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlanner
{
    public class StackNode
    {
        public StackNode(Location location)
        {
            next = null;
            this.Data = location;
        }

        public StackNode next;
        public Location Data;
    }
    class Stack
    {
        public Stack()
        {
            top = null;
        }
        
        //Add a location
        public void addLocation(Location location)
        {
            StackNode node = new StackNode(location);
            if (top == null)
            {
                top = node;
                return;
            }

            node.next = top;
            top = node;

            return;
        }

        //pop
        public Location popLocation()
        {

            Location location = top.Data;

            top = top.next;
            return location;
        }

        //Check empty
        public bool isEmpty()
        {
            if (top == null)
            {
                return true;
            }
            return false;
        }
        public StackNode top;
    }
}
