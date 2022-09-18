using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlanner
{
    class Node
    {
        public Node(Location location)
        {
            this.location = location;
            this.height = 1;
            this.left = null;
            this.right = null;
        }

        public int height;
        public Location location;
        public Node right;
        public Node left;
    }
    public class AVL
    {
        public AVL()
        {
            root = null;
        }

        //rotate right
        Node rotateRight(Node node)
        {
            Node x = node.left;
            Node y = x.right;

            x.right = node;
            node.left = y;

            //Adjust heights
            x.height = 1 + max(height(x.left), height(x.right));
            node.height = 1 + max(height(node.left), height(node.right));
            

            return x;
        }

       

        //Rotate Left
        Node rotateLeft(Node node)
        {
            Node x = node.right;
            Node y = x.left;

            //Rotate
            x.left = node;
            node.right = y;

            //height adjustment
            x.height = max(height(x.left), height(x.right)) + 1;
            node.height = max(height(node.left), height(node.right)) + 1;

            return x;
        }

        //get location from location name
        public Location getLocation(string name)
        {
            Node node = getNode(root, name);

            if (node == null)
            {
                return null;
            }

            return node.location;
        }

        //get node from location name
        Node getNode(Node root, string name)
        {
            if (root == null || String.Compare(root.location.Name, name) == 0)
            {
                return root;
            }

            //move left
            if (String.Compare(root.location.Name, name) > 0)
            {
                return getNode(root.left, name);
            }
            //move right
            else
            {
                return getNode(root.right, name);
            }
        }

        //insert a location
        public void insert(Location location)
        {
            root = insert(root, location);
        }

        //Recursive method to insert a new Location
        Node insert(Node root, Location newLocation)
        {
            //insert
            if (root == null)
            {
                Node newNode = new Node(newLocation);
                return newNode;
            }

            //move to right
            if (String.Compare(root.location.Name, newLocation.Name) < 0)
            {
                root.right = insert(root.right, newLocation);
            }

            //move to left
            else if (String.Compare(root.location.Name, newLocation.Name) > 0)
            {
                root.left = insert(root.left, newLocation);
            }

            //return if already present
            else if (String.Compare(root.location.Name, newLocation.Name) == 0)
            {
                return root;
            }

            //update height
            root.height = 1 + max(height(root.left), height(root.right));

            //Balance Factor
            int balance = height(root.left) - height(root.right);

            //Right Rotation
            if (balance > 1 && String.Compare(root.left.location.Name, newLocation.Name) > 0)
            {
                return rotateRight(root);
            }
            //Right Left Rotation
            else if (balance > 1 && String.Compare(root.left.location.Name, newLocation.Name) < 0)
            {
                root.left = rotateLeft(root.left);
                return rotateRight(root);
            }
            //Left Rotation
            else if (balance < -1 && String.Compare(root.right.location.Name, newLocation.Name) < 0)
            {
                return rotateLeft(root);
            }
            //Left Right Rotation
            else if (balance < -1 && String.Compare(root.right.location.Name, newLocation.Name) > 0)
            {
                root.right = rotateRight(root.right);
                return rotateLeft(root);
            }

            return root;
        }

        Node root;

        //Utitlity Function
        int max(int a, int b)
        {
            return (a > b ? a : b);
        }

        //Node Height
        int height(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            return node.height;
        }

        //get a pre order list of locations
        public List<Location> getList()
        {
            List<Location> list = new List<Location>();
            generateList(root, list);
            return list;
        }

        //generate list pre order
        void generateList(Node root, List<Location> list)
        {
            if (root == null)
            {
                return;
            }

            generateList(root.left,  list);
            list.insertEnd(root.location, root.location.Name);
            generateList(root.right,  list);
        }

        //set adjacency of each list item
        void setAdjacencies()
        {
            if (root == null)
            {
                return;
            }
        }
    }
}
