
namespace TravelPlanner
{
    partial class Plan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLocation = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBookHotel = new System.Windows.Forms.Button();
            this.labelHotelStars = new System.Windows.Forms.Label();
            this.comboHotels = new System.Windows.Forms.ComboBox();
            this.groupRestaurant = new System.Windows.Forms.GroupBox();
            this.buttonBookRestaurant = new System.Windows.Forms.Button();
            this.labelRestaurantStars = new System.Windows.Forms.Label();
            this.comboRestaurants = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonBookHouse = new System.Windows.Forms.Button();
            this.labelHouseStars = new System.Windows.Forms.Label();
            this.comboHouses = new System.Windows.Forms.ComboBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupRestaurant.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.labelLocation);
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(65, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 82);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Showcard Gothic", 15.04478F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLocation.Location = new System.Drawing.Point(27, 18);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(219, 36);
            this.labelLocation.TabIndex = 0;
            this.labelLocation.Text = "Planning For";
            this.labelLocation.Click += new System.EventHandler(this.labelLocation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Controls.Add(this.buttonBookHotel);
            this.groupBox1.Controls.Add(this.labelHotelStars);
            this.groupBox1.Controls.Add(this.comboHotels);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(66, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 93);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Hotels";
            // 
            // buttonBookHotel
            // 
            this.buttonBookHotel.BackColor = System.Drawing.Color.Linen;
            this.buttonBookHotel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonBookHotel.Location = new System.Drawing.Point(314, 41);
            this.buttonBookHotel.Name = "buttonBookHotel";
            this.buttonBookHotel.Size = new System.Drawing.Size(148, 30);
            this.buttonBookHotel.TabIndex = 2;
            this.buttonBookHotel.Text = "Book Hotel";
            this.buttonBookHotel.UseVisualStyleBackColor = false;
            this.buttonBookHotel.Click += new System.EventHandler(this.buttonBookHotel_Click);
            // 
            // labelHotelStars
            // 
            this.labelHotelStars.AutoSize = true;
            this.labelHotelStars.Location = new System.Drawing.Point(204, 43);
            this.labelHotelStars.Name = "labelHotelStars";
            this.labelHotelStars.Size = new System.Drawing.Size(64, 23);
            this.labelHotelStars.TabIndex = 1;
            this.labelHotelStars.Text = "Stars: 5";
            this.labelHotelStars.Click += new System.EventHandler(this.labelHotelStars_Click);
            // 
            // comboHotels
            // 
            this.comboHotels.FormattingEnabled = true;
            this.comboHotels.Location = new System.Drawing.Point(26, 40);
            this.comboHotels.Name = "comboHotels";
            this.comboHotels.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboHotels.Size = new System.Drawing.Size(146, 31);
            this.comboHotels.TabIndex = 0;
            this.comboHotels.SelectedIndexChanged += new System.EventHandler(this.comboHotels_SelectedIndexChanged);
            // 
            // groupRestaurant
            // 
            this.groupRestaurant.BackColor = System.Drawing.Color.SaddleBrown;
            this.groupRestaurant.Controls.Add(this.buttonBookRestaurant);
            this.groupRestaurant.Controls.Add(this.labelRestaurantStars);
            this.groupRestaurant.Controls.Add(this.comboRestaurants);
            this.groupRestaurant.ForeColor = System.Drawing.Color.White;
            this.groupRestaurant.Location = new System.Drawing.Point(65, 238);
            this.groupRestaurant.Name = "groupRestaurant";
            this.groupRestaurant.Size = new System.Drawing.Size(655, 93);
            this.groupRestaurant.TabIndex = 2;
            this.groupRestaurant.TabStop = false;
            this.groupRestaurant.Text = "Select Restaurants";
            this.groupRestaurant.Enter += new System.EventHandler(this.groupRestaurant_Enter);
            // 
            // buttonBookRestaurant
            // 
            this.buttonBookRestaurant.BackColor = System.Drawing.Color.Linen;
            this.buttonBookRestaurant.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonBookRestaurant.Location = new System.Drawing.Point(315, 41);
            this.buttonBookRestaurant.Name = "buttonBookRestaurant";
            this.buttonBookRestaurant.Size = new System.Drawing.Size(148, 30);
            this.buttonBookRestaurant.TabIndex = 2;
            this.buttonBookRestaurant.Text = "Book Restaurant";
            this.buttonBookRestaurant.UseVisualStyleBackColor = false;
            this.buttonBookRestaurant.Click += new System.EventHandler(this.buttonBookRestaurant_Click);
            // 
            // labelRestaurantStars
            // 
            this.labelRestaurantStars.AutoSize = true;
            this.labelRestaurantStars.Location = new System.Drawing.Point(204, 43);
            this.labelRestaurantStars.Name = "labelRestaurantStars";
            this.labelRestaurantStars.Size = new System.Drawing.Size(64, 23);
            this.labelRestaurantStars.TabIndex = 1;
            this.labelRestaurantStars.Text = "Stars: 5";
            // 
            // comboRestaurants
            // 
            this.comboRestaurants.FormattingEnabled = true;
            this.comboRestaurants.Location = new System.Drawing.Point(26, 40);
            this.comboRestaurants.Name = "comboRestaurants";
            this.comboRestaurants.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboRestaurants.Size = new System.Drawing.Size(146, 31);
            this.comboRestaurants.TabIndex = 0;
            this.comboRestaurants.SelectedIndexChanged += new System.EventHandler(this.comboRestaurants_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SaddleBrown;
            this.groupBox2.Controls.Add(this.buttonBookHouse);
            this.groupBox2.Controls.Add(this.labelHouseStars);
            this.groupBox2.Controls.Add(this.comboHouses);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(66, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 93);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Guest Houses";
            // 
            // buttonBookHouse
            // 
            this.buttonBookHouse.BackColor = System.Drawing.Color.Linen;
            this.buttonBookHouse.Font = new System.Drawing.Font("Segoe UI", 8.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBookHouse.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonBookHouse.Location = new System.Drawing.Point(315, 41);
            this.buttonBookHouse.Name = "buttonBookHouse";
            this.buttonBookHouse.Size = new System.Drawing.Size(148, 30);
            this.buttonBookHouse.TabIndex = 2;
            this.buttonBookHouse.Text = "Book GuestHouse";
            this.buttonBookHouse.UseVisualStyleBackColor = false;
            this.buttonBookHouse.Click += new System.EventHandler(this.buttonBookHouse_Click);
            // 
            // labelHouseStars
            // 
            this.labelHouseStars.AutoSize = true;
            this.labelHouseStars.Location = new System.Drawing.Point(204, 43);
            this.labelHouseStars.Name = "labelHouseStars";
            this.labelHouseStars.Size = new System.Drawing.Size(64, 23);
            this.labelHouseStars.TabIndex = 1;
            this.labelHouseStars.Text = "Stars: 5";
            // 
            // comboHouses
            // 
            this.comboHouses.FormattingEnabled = true;
            this.comboHouses.Location = new System.Drawing.Point(26, 40);
            this.comboHouses.Name = "comboHouses";
            this.comboHouses.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboHouses.Size = new System.Drawing.Size(146, 31);
            this.comboHouses.TabIndex = 0;
            this.comboHouses.SelectedIndexChanged += new System.EventHandler(this.comboHouses_SelectedIndexChanged);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonNext.Font = new System.Drawing.Font("Meiryo UI", 9.895522F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNext.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNext.Location = new System.Drawing.Point(65, 495);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(191, 50);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "Move Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TravelPlanner.Properties.Resources.bgPlan;
            this.ClientSize = new System.Drawing.Size(805, 583);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupRestaurant);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Plan";
            this.Text = "Plan";
            this.Load += new System.EventHandler(this.Plan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupRestaurant.ResumeLayout(false);
            this.groupRestaurant.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboHotels;
        private System.Windows.Forms.Label labelHotelStars;
        private System.Windows.Forms.Button buttonBookHotel;
        private System.Windows.Forms.GroupBox groupRestaurant;
        private System.Windows.Forms.Button buttonBookRestaurant;
        private System.Windows.Forms.Label labelRestaurantStars;
        private System.Windows.Forms.ComboBox comboRestaurants;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonBookHouse;
        private System.Windows.Forms.Label labelHouseStars;
        private System.Windows.Forms.ComboBox comboHouses;
        private System.Windows.Forms.Button buttonNext;
    }
}