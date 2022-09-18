using System;
using System.IO;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        enum type
        {
            a = 1,
            b = 2
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Button b in this.Controls.OfType<Button>())
            {
                b.MouseEnter += (s, e) => b.Cursor = Cursors.Hand;
                b.MouseLeave += (s, e) => b.Cursor = Cursors.Arrow;
            }

            string str;

            //path = "\\Data\\";
            path = Directory.GetCurrentDirectory() + "\\";            

            

            using (StreamReader reader = new StreamReader(path + "Locations_Names.txt"))
            {
                locationTree = new AVL();
                str = reader.ReadLine();
            }

            
            string[] names = str.Split(',');

            for (int i = 0; i < names.Length; i++)
            {
                Location location = new Location(names[i]);
                locationTree.insert(location);

            }

            map = new Map(locationTree);

            Node<Location> it = map.locations.iterator();

            while (it != null)
            {
                it.data.setAdjacencies(locationTree);
                it = it.next;
            }

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void LoginBox_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            SignUp signUp = new SignUp(locationTree, this);
            signUp.Show();
            this.Hide();
        }

        private Form parent;

        private void boxName_TextChanged(object sender, EventArgs e)
        {

        }

        public AVL locationTree;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string name = boxName.Text;
            //Searching in file


            bool valid = false;
            string userData = "";

            using (StreamReader reader = new StreamReader(path + "Users.txt"))
            {
                //Check Validity
                while (reader.Peek() != -1)
                {
                    string str = reader.ReadLine();
                    
                    string[] splits = str.Split(',');
                    string temp = splits[0];

                    if (temp == boxName.Text)
                    {
                        valid = true;
                        userData = str;
                        break;
                    }
                }
            }

            if (valid == false)
            {
                MessageBox.Show("Invalid Username", "Sign in Error");
                return;
            }

            string password;
            string[] data = userData.Split(',');
            password = data[1];

            //sign in successful
            if (boxPassword.Text.Equals(password))
            {
             
                User user = new User(data[0], locationTree.getLocation(data[2]), (data[3].Equals("0") ? false : true));
                //user.getDataFromFile(locationTree);
                SelectTravel travel = new SelectTravel(user, locationTree, this);
                travel.Show();
                this.Hide();

                return;
            }
            //sign in unsuccessful
            else
            {
                MessageBox.Show("Invalid Password", "Sign in Error");
            }
        }

        public string path;

        Map map;
    }
}
