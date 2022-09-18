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
    public partial class SelectTravel : Form
    {
        public SelectTravel(User user, AVL locationTree, Form ParentForm)
        {
            this.user = user;
            this.locationTree = locationTree;
            this.parentForm = ParentForm;
            this.location = user.Location;

            this.user.getDataFromFile(locationTree);
            InitializeComponent();
        }

       
        private void SelectTravel_Load(object sender, EventArgs e)
        {
            this.labelUser.Text = "Hi " + user.Name + "!";
            this.labelLocation.Text = "Location: " + location.Name;

            //positioning button
            if (user.Admin == false)
            {
                this.buttonAdmin.Visible = false;
            }


            List<Location> locations = locationTree.getList();


            //Loading locations combo box
            Node<Location> it = locations.iterator();
            while (it != null)
            {
                if (it.data != location)
                {
                    this.comboLocations.Items.Add(it.data.Name);
                }
                it = it.next;
            }

            //Loading destination combo box
            it = locations.iterator();
            while (it != null)
            {
                if (it.data != location)
                {
                    this.comboDestination.Items.Add(it.data.Name);
                }
                it = it.next;
            }

            //Loading Mode Combo Mox
            comboMode.Items.Add("By Air");
            comboMode.Items.Add("By Bus");
            comboMode.Items.Add("By Car");

        }

        protected override void OnClosed(EventArgs e)
        {
            parentForm.Show();
            base.OnClosed(e);
        }


        private Form parentForm;
        private User user;
        private AVL locationTree;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(locationTree, parentForm);
            admin.Show();
            this.Hide();
        }

        private void buttonLocation_Click(object sender, EventArgs e)
        {
        
            
        }

        public Location location;

        private void comboLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            location = locationTree.getLocation(comboLocations.Text);
            this.labelLocation.Text = "Location: " + location.Name;

            comboDestination.Text = String.Empty;

            List<Location> locations = locationTree.getList();

            //ReLoading locations combo box
            comboLocations.Items.Clear();

            Node<Location> it = locations.iterator();
            while (it != null)
            {
                if (it.data != location)
                {
                    this.comboLocations.Items.Add(it.data.Name);
                }
                it = it.next;
            }

            //ReLoading destination combo box
            comboDestination.Items.Clear();
            it = locations.iterator();
            while (it != null)
            {
                if (it.data != location)
                {
                    this.comboDestination.Items.Add(it.data.Name);
                }
                it = it.next;
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            this.panelPath.Visible = true;
            Location source = location;
            Location destination = locationTree.getLocation(comboDestination.Text);

            //getting travel mode
            //comboMode.Items.Add("By Air");
            //comboMode.Items.Add("By Bus");
            //comboMode.Items.Add("By Car");

            string mode = comboMode.Text;

            //Car Mode
            if (mode.Equals("By Car"))
            {

                List<Location> path = source.dijkstraCarPath(locationTree, destination);
                path.removeDuplicates();

                if (path.lastValue() != destination)
                {

                    labelPath.Text = "No Path found";
                    labelTime.Text = "";
                }
                else
                {
                    labelPath.Text = String.Empty;

                    Node<Location> it = path.iterator();

                    this.path = path;

                    while (it != null)
                    {
                        labelPath.Text += it.data.Name;

                        if (it.next != null)
                        {
                            labelPath.Text += "-->";
                        }
                        it = it.next;
                    }

                    labelTime.Text = "Total Car Travel Time: " + destination.weight + " minutes";
                }
            }

            //bus mode
            else if (mode.Equals("By Bus"))
            {
                List<Location> path = source.dijkstraBusPath(locationTree, destination);
                path.removeDuplicates();

                if (path.lastValue() != destination)
                {

                    labelPath.Text = "No Path found";
                    labelTime.Text = "";
                }
                else
                {
                    labelPath.Text = String.Empty;

                    Node<Location> it = path.iterator();

                    this.path = path;

                    while (it != null)
                    {
                        labelPath.Text += it.data.Name;

                        if (it.next != null)
                        {
                            labelPath.Text += "-->";
                        }
                        it = it.next;
                    }

                    labelTime.Text = "Total Bus Time: " + destination.weight + " Minutes";
                }
            }

            //air mode
            else if (mode.Equals("By Air"))
            {
                List<Location> path = source.dijkstraAirPath(locationTree, destination);
                path.removeDuplicates();

                if (path.lastValue() != destination)
                {

                    labelPath.Text = "No Path found";
                    labelTime.Text = "";
                }
                else
                {
                    labelPath.Text = String.Empty;

                    Node<Location> it = path.iterator();

                    this.path = path;

                    while (it != null)
                    {
                        labelPath.Text += it.data.Name;

                        if (it.next != null)
                        {
                            labelPath.Text += "-->";
                        }
                        it = it.next;
                    }

                    labelTime.Text = "Total Air Travel Time: " + destination.weight + " Minutes";
                }
            }

            //no mode set
            else
            {
                this.panelPath.Visible = false;
                MessageBox.Show("Please select a travel mode");
            }

            //Resetting visits
            List<Location> locations = locationTree.getList();

            Node<Location> itLocation = locations.iterator();

            while (itLocation != null)
            {
                itLocation.data.resetVisit();
                itLocation = itLocation.next;
            }
        }

        private void panelPath_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user.isEmpty == false)
            {
                DialogResult result = MessageBox.Show("You will lose your previously planned trip. Are you sure?", "Confirmation", MessageBoxButtons.OKCancel);

                if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            user.clear();

            user.setPath(path);

            int index = 1;
            Node<Location> it = path.iterator();

            if (it != null)
            {
                Plan plan = new Plan(user, it.data, index, this, it);
                plan.Show();
            }
        }

        List<Location> path;

        Node<Location> it;

        private void buttonPlan_Click(object sender, EventArgs e)
        {
            if (user.isEmpty)
            {
                MessageBox.Show("You have not selected a plan yet");
            }
            else
            {
               // user.getDataFromFile(locationTree);
                MyPlan myPlan = new MyPlan(user, this, locationTree);
                myPlan.Show();
            }
        }
    }
}
