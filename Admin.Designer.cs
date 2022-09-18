
namespace TravelPlanner
{
    partial class Admin
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
            this.labelAdminHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.comboLocations = new System.Windows.Forms.ComboBox();
            this.labelSelectLocation = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelOr = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.nameLocation = new System.Windows.Forms.TextBox();
            this.labelAddLocation = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAdminHeading
            // 
            this.labelAdminHeading.AutoSize = true;
            this.labelAdminHeading.BackColor = System.Drawing.Color.Transparent;
            this.labelAdminHeading.Font = new System.Drawing.Font("Constantia", 22.02985F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdminHeading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAdminHeading.Location = new System.Drawing.Point(53, 22);
            this.labelAdminHeading.Name = "labelAdminHeading";
            this.labelAdminHeading.Size = new System.Drawing.Size(274, 50);
            this.labelAdminHeading.TabIndex = 0;
            this.labelAdminHeading.Text = "Administrator";
            this.labelAdminHeading.Click += new System.EventHandler(this.labelAdminHeading_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.comboLocations);
            this.panel1.Controls.Add(this.labelSelectLocation);
            this.panel1.Location = new System.Drawing.Point(66, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 81);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.White;
            this.buttonEdit.ForeColor = System.Drawing.Color.Black;
            this.buttonEdit.Location = new System.Drawing.Point(492, 22);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(105, 32);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Modify";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // comboLocations
            // 
            this.comboLocations.FormattingEnabled = true;
            this.comboLocations.Location = new System.Drawing.Point(300, 24);
            this.comboLocations.Name = "comboLocations";
            this.comboLocations.Size = new System.Drawing.Size(169, 31);
            this.comboLocations.TabIndex = 1;
            this.comboLocations.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelSelectLocation
            // 
            this.labelSelectLocation.AutoSize = true;
            this.labelSelectLocation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSelectLocation.Location = new System.Drawing.Point(103, 27);
            this.labelSelectLocation.Name = "labelSelectLocation";
            this.labelSelectLocation.Size = new System.Drawing.Size(180, 23);
            this.labelSelectLocation.TabIndex = 0;
            this.labelSelectLocation.Text = "Select Location to Edit";
            this.labelSelectLocation.Click += new System.EventHandler(this.labelSelectLocation_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.labelOr);
            this.panel2.Location = new System.Drawing.Point(315, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 93);
            this.panel2.TabIndex = 2;
            // 
            // labelOr
            // 
            this.labelOr.AutoSize = true;
            this.labelOr.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8806F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelOr.ForeColor = System.Drawing.Color.White;
            this.labelOr.Location = new System.Drawing.Point(96, 23);
            this.labelOr.Name = "labelOr";
            this.labelOr.Size = new System.Drawing.Size(62, 44);
            this.labelOr.TabIndex = 0;
            this.labelOr.Text = "OR";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.buttonAdd);
            this.panel3.Controls.Add(this.nameLocation);
            this.panel3.Controls.Add(this.labelAddLocation);
            this.panel3.Location = new System.Drawing.Point(66, 317);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(749, 72);
            this.panel3.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(492, 13);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 32);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add New Location";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // nameLocation
            // 
            this.nameLocation.Location = new System.Drawing.Point(300, 15);
            this.nameLocation.Name = "nameLocation";
            this.nameLocation.Size = new System.Drawing.Size(169, 30);
            this.nameLocation.TabIndex = 2;
            // 
            // labelAddLocation
            // 
            this.labelAddLocation.AutoSize = true;
            this.labelAddLocation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAddLocation.Location = new System.Drawing.Point(157, 22);
            this.labelAddLocation.Name = "labelAddLocation";
            this.labelAddLocation.Size = new System.Drawing.Size(126, 23);
            this.labelAddLocation.TabIndex = 1;
            this.labelAddLocation.Text = "Location Name";
            this.labelAddLocation.Click += new System.EventHandler(this.label1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::TravelPlanner.Properties.Resources.adminbg;
            this.ClientSize = new System.Drawing.Size(910, 563);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelAdminHeading);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAdminHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSelectLocation;
        private System.Windows.Forms.ComboBox comboLocations;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelOr;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelAddLocation;
        private System.Windows.Forms.TextBox nameLocation;
        private System.Windows.Forms.Button buttonAdd;
    }
}