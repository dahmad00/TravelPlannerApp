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
    public partial class SignUp : Form
    {
        public SignUp(AVL locationTree, Form Parent)
        {
            InitializeComponent();
            locations = locationTree.getList();
            parentForm = Parent;
        }

        private void comboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            Path = Directory.GetCurrentDirectory() + "\\";
            Node<Location> it = locations.iterator();
            while (it != null)
            {
                comboLocation.Items.Add(it.data.Name);
                it = it.next;
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            parentForm.Show();
            base.OnClosed(e);
        }

        List<Location> locations;

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            bool valid = true;

            if (boxPassword.Text.Equals(String.Empty))
            {
                valid = false;
                MessageBox.Show("Password can not be empty", "Sign Up Error");
            }

            if (valid == true && comboLocation.Text.Equals(String.Empty))
            {
                valid = false;
                MessageBox.Show("Please select a location", "Sign Up Error"); ;
            }

            if (valid == true)
            {
                using (StreamReader reader = new StreamReader(Path + "users.txt"))
                {

                    //Check Validity
                    while (reader.Peek() != -1)
                    {
                        string str = reader.ReadLine();
                        string[] splits = str.Split(',');
                        str = splits[0];

                        if (str == boxUsername.Text)
                        {
                            MessageBox.Show("The Username already exists, please try another username", "Sign Up Error");
                            valid = false;
                            break;
                        }
                    }
                };
            }

            //Save Record
            if (valid == true)
            {
                string username = boxUsername.Text;
                string password = boxPassword.Text;
                string location = comboLocation.Text;

                using (StreamWriter writer = File.AppendText(Path + "Users.txt"))
                {
                    writer.Write(username + "," + password + "," + location + "," + 0  + Environment.NewLine);
                    MessageBox.Show("Sign up Successful");
                    parentForm.Show();
                    writer.Close();
                    this.Close();
                }

                //create extra file for user
                using (StreamWriter writer = new StreamWriter(Path + "Users//" + username + ".txt"))
                {

                }

            }



        }

        public Form parentForm;

        public string Path { get; set; }
    }
}

