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
    public partial class Admin : Form
    {
        public Admin(AVL locationTree, Form Parent)
        {
            InitializeComponent();
            this.locationTree = locationTree;

            List<Location> locations = locationTree.getList();

            Node<Location> it = locations.iterator();

            while (it != null)
            {
                comboLocations.Items.Add(it.data.Name);
                it = it.next;
            }

            this.parentForm = Parent;

            path = "F:\\Data Structures Lab\\Project\\TravelPlanner\\Data\\";
        }

        protected override void OnClosed(EventArgs e)
        {
            parentForm.Show();
            base.OnClosed(e);
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        public AVL locationTree;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelSelectLocation_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboLocations.Text.Equals(String.Empty))
            {
                MessageBox.Show("Please select a location");
                return;
            }

            Location location = locationTree.getLocation(comboLocations.Text);

            EditLocation edit = new EditLocation(location, locationTree, this);
            edit.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            List<Location> locations = locationTree.getList();
            if (locations.search(nameLocation.Text))
            {
                MessageBox.Show("Location with this name already exists");
                return;
            }

            string name = nameLocation.Text;

            //saving in file
            using (StreamWriter writer = new StreamWriter(path + "Locations_Names.txt", append:true))
            {
                writer.Write("," + nameLocation.Text);
            }

            //creating new file
            using (StreamWriter writer = new StreamWriter(path + name + ".txt"))
            {
                writer.Write("\n\n\n\n\n");
            }

            Location location = new Location(name);

        }

        public string path;

        private void labelAdminHeading_Click(object sender, EventArgs e)
        {

        }

        public Form parentForm;
    }
}
