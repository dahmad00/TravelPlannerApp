
namespace TravelPlanner
{
    partial class EditLocation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.groupHotels = new System.Windows.Forms.GroupBox();
            this.saveHotel = new System.Windows.Forms.Button();
            this.hotelCapacity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.hotelStars = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.hotelName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboHotels = new System.Windows.Forms.ComboBox();
            this.groupRestaurants = new System.Windows.Forms.GroupBox();
            this.saveRestaurant = new System.Windows.Forms.Button();
            this.restaurantCapacity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.restaurantStars = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.restaurantName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboRestaurants = new System.Windows.Forms.ComboBox();
            this.groupHouses = new System.Windows.Forms.GroupBox();
            this.saveHouse = new System.Windows.Forms.Button();
            this.houseCapacity = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.houseStars = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.houseName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboHouses = new System.Windows.Forms.ComboBox();
            this.groupPlaces = new System.Windows.Forms.GroupBox();
            this.savePlace = new System.Windows.Forms.Button();
            this.placeName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboPlaces = new System.Windows.Forms.ComboBox();
            this.groupMap = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.carTime = new System.Windows.Forms.NumericUpDown();
            this.busTime = new System.Windows.Forms.NumericUpDown();
            this.airTime = new System.Windows.Forms.NumericUpDown();
            this.distance = new System.Windows.Forms.NumericUpDown();
            this.saveMap = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.comboLocations = new System.Windows.Forms.ComboBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelStars)).BeginInit();
            this.groupRestaurants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantStars)).BeginInit();
            this.groupHouses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.houseCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseStars)).BeginInit();
            this.groupPlaces.SuspendLayout();
            this.groupMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Cooper Black", 18.26866F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName.Location = new System.Drawing.Point(223, 21);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(147, 40);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Editing";
            // 
            // groupHotels
            // 
            this.groupHotels.BackColor = System.Drawing.Color.Transparent;
            this.groupHotels.Controls.Add(this.saveHotel);
            this.groupHotels.Controls.Add(this.hotelCapacity);
            this.groupHotels.Controls.Add(this.label4);
            this.groupHotels.Controls.Add(this.hotelStars);
            this.groupHotels.Controls.Add(this.label3);
            this.groupHotels.Controls.Add(this.hotelName);
            this.groupHotels.Controls.Add(this.label2);
            this.groupHotels.Controls.Add(this.label1);
            this.groupHotels.Controls.Add(this.comboHotels);
            this.groupHotels.Font = new System.Drawing.Font("Segoe UI", 8.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupHotels.ForeColor = System.Drawing.Color.White;
            this.groupHotels.Location = new System.Drawing.Point(12, 63);
            this.groupHotels.Name = "groupHotels";
            this.groupHotels.Size = new System.Drawing.Size(776, 118);
            this.groupHotels.TabIndex = 1;
            this.groupHotels.TabStop = false;
            this.groupHotels.Text = "Edit Hotels";
            this.groupHotels.Enter += new System.EventHandler(this.groupHotels_Enter);
            // 
            // saveHotel
            // 
            this.saveHotel.BackColor = System.Drawing.Color.Black;
            this.saveHotel.Location = new System.Drawing.Point(599, 55);
            this.saveHotel.Name = "saveHotel";
            this.saveHotel.Size = new System.Drawing.Size(108, 33);
            this.saveHotel.TabIndex = 6;
            this.saveHotel.Text = "Save";
            this.saveHotel.UseVisualStyleBackColor = false;
            this.saveHotel.Click += new System.EventHandler(this.button1_Click);
            // 
            // hotelCapacity
            // 
            this.hotelCapacity.Location = new System.Drawing.Point(458, 60);
            this.hotelCapacity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.hotelCapacity.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.hotelCapacity.Name = "hotelCapacity";
            this.hotelCapacity.Size = new System.Drawing.Size(84, 28);
            this.hotelCapacity.TabIndex = 5;
            this.hotelCapacity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Capacity";
            // 
            // hotelStars
            // 
            this.hotelStars.Location = new System.Drawing.Point(372, 61);
            this.hotelStars.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.hotelStars.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hotelStars.Name = "hotelStars";
            this.hotelStars.Size = new System.Drawing.Size(60, 28);
            this.hotelStars.TabIndex = 4;
            this.hotelStars.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stars";
            // 
            // hotelName
            // 
            this.hotelName.Location = new System.Drawing.Point(216, 60);
            this.hotelName.Name = "hotelName";
            this.hotelName.Size = new System.Drawing.Size(140, 28);
            this.hotelName.TabIndex = 3;
            this.hotelName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Hotel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboHotels
            // 
            this.comboHotels.FormattingEnabled = true;
            this.comboHotels.Location = new System.Drawing.Point(22, 60);
            this.comboHotels.Name = "comboHotels";
            this.comboHotels.Size = new System.Drawing.Size(169, 28);
            this.comboHotels.TabIndex = 0;
            this.comboHotels.SelectedIndexChanged += new System.EventHandler(this.comboHotels_SelectedIndexChanged);
            // 
            // groupRestaurants
            // 
            this.groupRestaurants.BackColor = System.Drawing.Color.Transparent;
            this.groupRestaurants.Controls.Add(this.saveRestaurant);
            this.groupRestaurants.Controls.Add(this.restaurantCapacity);
            this.groupRestaurants.Controls.Add(this.label5);
            this.groupRestaurants.Controls.Add(this.restaurantStars);
            this.groupRestaurants.Controls.Add(this.label6);
            this.groupRestaurants.Controls.Add(this.restaurantName);
            this.groupRestaurants.Controls.Add(this.label7);
            this.groupRestaurants.Controls.Add(this.label8);
            this.groupRestaurants.Controls.Add(this.comboRestaurants);
            this.groupRestaurants.Font = new System.Drawing.Font("Segoe UI", 8.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupRestaurants.ForeColor = System.Drawing.Color.White;
            this.groupRestaurants.Location = new System.Drawing.Point(12, 202);
            this.groupRestaurants.Name = "groupRestaurants";
            this.groupRestaurants.Size = new System.Drawing.Size(776, 118);
            this.groupRestaurants.TabIndex = 2;
            this.groupRestaurants.TabStop = false;
            this.groupRestaurants.Text = "Edit Restaruants";
            this.groupRestaurants.Enter += new System.EventHandler(this.groupRestaurants_Enter);
            // 
            // saveRestaurant
            // 
            this.saveRestaurant.BackColor = System.Drawing.Color.Black;
            this.saveRestaurant.Location = new System.Drawing.Point(599, 55);
            this.saveRestaurant.Name = "saveRestaurant";
            this.saveRestaurant.Size = new System.Drawing.Size(108, 33);
            this.saveRestaurant.TabIndex = 6;
            this.saveRestaurant.Text = "Save";
            this.saveRestaurant.UseVisualStyleBackColor = false;
            this.saveRestaurant.Click += new System.EventHandler(this.saveRestaurant_Click_1);
            // 
            // restaurantCapacity
            // 
            this.restaurantCapacity.Location = new System.Drawing.Point(458, 60);
            this.restaurantCapacity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.restaurantCapacity.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.restaurantCapacity.Name = "restaurantCapacity";
            this.restaurantCapacity.Size = new System.Drawing.Size(84, 28);
            this.restaurantCapacity.TabIndex = 5;
            this.restaurantCapacity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Capacity";
            // 
            // restaurantStars
            // 
            this.restaurantStars.Location = new System.Drawing.Point(372, 61);
            this.restaurantStars.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.restaurantStars.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.restaurantStars.Name = "restaurantStars";
            this.restaurantStars.Size = new System.Drawing.Size(60, 28);
            this.restaurantStars.TabIndex = 4;
            this.restaurantStars.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Stars";
            // 
            // restaurantName
            // 
            this.restaurantName.Location = new System.Drawing.Point(216, 60);
            this.restaurantName.Name = "restaurantName";
            this.restaurantName.Size = new System.Drawing.Size(140, 28);
            this.restaurantName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Select Restaurant";
            // 
            // comboRestaurants
            // 
            this.comboRestaurants.FormattingEnabled = true;
            this.comboRestaurants.Location = new System.Drawing.Point(22, 60);
            this.comboRestaurants.Name = "comboRestaurants";
            this.comboRestaurants.Size = new System.Drawing.Size(169, 28);
            this.comboRestaurants.TabIndex = 0;
            this.comboRestaurants.SelectedIndexChanged += new System.EventHandler(this.comboRestaurants_SelectedIndexChanged);
            // 
            // groupHouses
            // 
            this.groupHouses.BackColor = System.Drawing.Color.Transparent;
            this.groupHouses.Controls.Add(this.saveHouse);
            this.groupHouses.Controls.Add(this.houseCapacity);
            this.groupHouses.Controls.Add(this.label9);
            this.groupHouses.Controls.Add(this.houseStars);
            this.groupHouses.Controls.Add(this.label10);
            this.groupHouses.Controls.Add(this.houseName);
            this.groupHouses.Controls.Add(this.label11);
            this.groupHouses.Controls.Add(this.label12);
            this.groupHouses.Controls.Add(this.comboHouses);
            this.groupHouses.Font = new System.Drawing.Font("Segoe UI", 8.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupHouses.ForeColor = System.Drawing.Color.White;
            this.groupHouses.Location = new System.Drawing.Point(12, 341);
            this.groupHouses.Name = "groupHouses";
            this.groupHouses.Size = new System.Drawing.Size(776, 118);
            this.groupHouses.TabIndex = 3;
            this.groupHouses.TabStop = false;
            this.groupHouses.Text = "Edit GuestHouses";
            // 
            // saveHouse
            // 
            this.saveHouse.BackColor = System.Drawing.Color.Black;
            this.saveHouse.Location = new System.Drawing.Point(599, 61);
            this.saveHouse.Name = "saveHouse";
            this.saveHouse.Size = new System.Drawing.Size(108, 33);
            this.saveHouse.TabIndex = 6;
            this.saveHouse.Text = "Save";
            this.saveHouse.UseVisualStyleBackColor = false;
            this.saveHouse.Click += new System.EventHandler(this.saveHouse_Click);
            // 
            // houseCapacity
            // 
            this.houseCapacity.Location = new System.Drawing.Point(458, 60);
            this.houseCapacity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.houseCapacity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.houseCapacity.Name = "houseCapacity";
            this.houseCapacity.Size = new System.Drawing.Size(84, 28);
            this.houseCapacity.TabIndex = 5;
            this.houseCapacity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(458, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Capacity";
            // 
            // houseStars
            // 
            this.houseStars.Location = new System.Drawing.Point(372, 61);
            this.houseStars.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.houseStars.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.houseStars.Name = "houseStars";
            this.houseStars.Size = new System.Drawing.Size(60, 28);
            this.houseStars.TabIndex = 4;
            this.houseStars.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(372, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 21);
            this.label10.TabIndex = 3;
            this.label10.Text = "Stars";
            // 
            // houseName
            // 
            this.houseName.Location = new System.Drawing.Point(216, 60);
            this.houseName.Name = "houseName";
            this.houseName.Size = new System.Drawing.Size(140, 28);
            this.houseName.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(211, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 21);
            this.label12.TabIndex = 1;
            this.label12.Text = "Select Guesthouse";
            // 
            // comboHouses
            // 
            this.comboHouses.FormattingEnabled = true;
            this.comboHouses.Location = new System.Drawing.Point(22, 60);
            this.comboHouses.Name = "comboHouses";
            this.comboHouses.Size = new System.Drawing.Size(169, 28);
            this.comboHouses.TabIndex = 0;
            this.comboHouses.SelectedIndexChanged += new System.EventHandler(this.comboHouses_SelectedIndexChanged);
            // 
            // groupPlaces
            // 
            this.groupPlaces.BackColor = System.Drawing.Color.Transparent;
            this.groupPlaces.Controls.Add(this.savePlace);
            this.groupPlaces.Controls.Add(this.placeName);
            this.groupPlaces.Controls.Add(this.label15);
            this.groupPlaces.Controls.Add(this.label16);
            this.groupPlaces.Controls.Add(this.comboPlaces);
            this.groupPlaces.Font = new System.Drawing.Font("Segoe UI", 8.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupPlaces.ForeColor = System.Drawing.Color.White;
            this.groupPlaces.Location = new System.Drawing.Point(12, 626);
            this.groupPlaces.Name = "groupPlaces";
            this.groupPlaces.Size = new System.Drawing.Size(514, 118);
            this.groupPlaces.TabIndex = 4;
            this.groupPlaces.TabStop = false;
            this.groupPlaces.Text = "Edit Places";
            // 
            // savePlace
            // 
            this.savePlace.BackColor = System.Drawing.Color.Black;
            this.savePlace.Location = new System.Drawing.Point(372, 54);
            this.savePlace.Name = "savePlace";
            this.savePlace.Size = new System.Drawing.Size(110, 39);
            this.savePlace.TabIndex = 6;
            this.savePlace.Text = "Save";
            this.savePlace.UseVisualStyleBackColor = false;
            this.savePlace.Click += new System.EventHandler(this.savePlace_Click);
            // 
            // placeName
            // 
            this.placeName.Location = new System.Drawing.Point(216, 60);
            this.placeName.Name = "placeName";
            this.placeName.Size = new System.Drawing.Size(140, 28);
            this.placeName.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(211, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 21);
            this.label15.TabIndex = 2;
            this.label15.Text = "Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 21);
            this.label16.TabIndex = 1;
            this.label16.Text = "Select Place";
            // 
            // comboPlaces
            // 
            this.comboPlaces.FormattingEnabled = true;
            this.comboPlaces.Location = new System.Drawing.Point(22, 60);
            this.comboPlaces.Name = "comboPlaces";
            this.comboPlaces.Size = new System.Drawing.Size(169, 28);
            this.comboPlaces.TabIndex = 0;
            this.comboPlaces.SelectedIndexChanged += new System.EventHandler(this.comboPlaces_SelectedIndexChanged);
            // 
            // groupMap
            // 
            this.groupMap.BackColor = System.Drawing.Color.Transparent;
            this.groupMap.Controls.Add(this.label19);
            this.groupMap.Controls.Add(this.label17);
            this.groupMap.Controls.Add(this.label14);
            this.groupMap.Controls.Add(this.label13);
            this.groupMap.Controls.Add(this.carTime);
            this.groupMap.Controls.Add(this.busTime);
            this.groupMap.Controls.Add(this.airTime);
            this.groupMap.Controls.Add(this.distance);
            this.groupMap.Controls.Add(this.saveMap);
            this.groupMap.Controls.Add(this.label18);
            this.groupMap.Controls.Add(this.comboLocations);
            this.groupMap.Font = new System.Drawing.Font("Segoe UI", 8.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupMap.ForeColor = System.Drawing.Color.White;
            this.groupMap.Location = new System.Drawing.Point(12, 490);
            this.groupMap.Name = "groupMap";
            this.groupMap.Size = new System.Drawing.Size(776, 118);
            this.groupMap.TabIndex = 5;
            this.groupMap.TabStop = false;
            this.groupMap.Text = "Edit Map";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(489, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 21);
            this.label19.TabIndex = 14;
            this.label19.Text = "Car Time";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(388, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 21);
            this.label17.TabIndex = 13;
            this.label17.Text = "Bus Time";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(283, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 21);
            this.label14.TabIndex = 12;
            this.label14.Text = "Air Time";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(171, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 21);
            this.label13.TabIndex = 11;
            this.label13.Text = "Distance";
            // 
            // carTime
            // 
            this.carTime.Location = new System.Drawing.Point(489, 60);
            this.carTime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.carTime.Name = "carTime";
            this.carTime.Size = new System.Drawing.Size(89, 28);
            this.carTime.TabIndex = 10;
            // 
            // busTime
            // 
            this.busTime.Location = new System.Drawing.Point(388, 60);
            this.busTime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.busTime.Name = "busTime";
            this.busTime.Size = new System.Drawing.Size(83, 28);
            this.busTime.TabIndex = 9;
            // 
            // airTime
            // 
            this.airTime.Location = new System.Drawing.Point(283, 60);
            this.airTime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.airTime.Name = "airTime";
            this.airTime.Size = new System.Drawing.Size(84, 28);
            this.airTime.TabIndex = 8;
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(171, 60);
            this.distance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(92, 28);
            this.distance.TabIndex = 7;
            // 
            // saveMap
            // 
            this.saveMap.BackColor = System.Drawing.Color.Black;
            this.saveMap.Location = new System.Drawing.Point(599, 60);
            this.saveMap.Name = "saveMap";
            this.saveMap.Size = new System.Drawing.Size(108, 33);
            this.saveMap.TabIndex = 6;
            this.saveMap.Text = "Save";
            this.saveMap.UseVisualStyleBackColor = false;
            this.saveMap.Click += new System.EventHandler(this.saveMap_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 21);
            this.label18.TabIndex = 1;
            this.label18.Text = "Select Location";
            // 
            // comboLocations
            // 
            this.comboLocations.FormattingEnabled = true;
            this.comboLocations.Location = new System.Drawing.Point(22, 60);
            this.comboLocations.Name = "comboLocations";
            this.comboLocations.Size = new System.Drawing.Size(130, 28);
            this.comboLocations.TabIndex = 0;
            this.comboLocations.SelectedIndexChanged += new System.EventHandler(this.comboLocations_SelectedIndexChanged);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.Black;
            this.buttonDone.Font = new System.Drawing.Font("Segoe UI", 10.89552F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDone.ForeColor = System.Drawing.Color.White;
            this.buttonDone.Location = new System.Drawing.Point(581, 670);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(123, 44);
            this.buttonDone.TabIndex = 6;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // EditLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TravelPlanner.Properties.Resources.bgLocation;
            this.ClientSize = new System.Drawing.Size(816, 806);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupMap);
            this.Controls.Add(this.groupPlaces);
            this.Controls.Add(this.groupHouses);
            this.Controls.Add(this.groupRestaurants);
            this.Controls.Add(this.groupHotels);
            this.Controls.Add(this.labelName);
            this.Name = "EditLocation";
            this.Text = "Edit Location";
            this.Load += new System.EventHandler(this.EditLocation_Load);
            this.groupHotels.ResumeLayout(false);
            this.groupHotels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelStars)).EndInit();
            this.groupRestaurants.ResumeLayout(false);
            this.groupRestaurants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantStars)).EndInit();
            this.groupHouses.ResumeLayout(false);
            this.groupHouses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.houseCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseStars)).EndInit();
            this.groupPlaces.ResumeLayout(false);
            this.groupPlaces.PerformLayout();
            this.groupMap.ResumeLayout(false);
            this.groupMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupHotels;
        private System.Windows.Forms.ComboBox comboHotels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hotelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown hotelStars;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown hotelCapacity;
        private System.Windows.Forms.Button saveHotel;
        private System.Windows.Forms.GroupBox groupRestaurants;
        private System.Windows.Forms.Button saveRestaurant;
        private System.Windows.Forms.NumericUpDown restaurantCapacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown restaurantStars;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox restaurantName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboRestaurants;
        private System.Windows.Forms.GroupBox groupHouses;
        private System.Windows.Forms.Button saveHouse;
        private System.Windows.Forms.NumericUpDown houseCapacity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown houseStars;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox houseName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboHouses;
        private System.Windows.Forms.GroupBox groupPlaces;
        private System.Windows.Forms.Button savePlace;
        private System.Windows.Forms.TextBox placeName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboPlaces;
        private System.Windows.Forms.GroupBox groupMap;
        private System.Windows.Forms.Button saveMap;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboLocations;
        private System.Windows.Forms.NumericUpDown distance;
        private System.Windows.Forms.NumericUpDown airTime;
        private System.Windows.Forms.NumericUpDown busTime;
        private System.Windows.Forms.NumericUpDown carTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buttonDone;
    }
}