
namespace TravelPlanner
{
    partial class SelectTravel
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
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.groupDestination = new System.Windows.Forms.GroupBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.comboMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboDestination = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboLocations = new System.Windows.Forms.ComboBox();
            this.panelPath = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPlan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupDestination.SuspendLayout();
            this.panelPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.labelUser);
            this.panel1.Location = new System.Drawing.Point(150, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 70);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Forte", 22.02985F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUser.Location = new System.Drawing.Point(18, 15);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(161, 45);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Hi User!";
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonAdmin.Font = new System.Drawing.Font("Cambria", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdmin.Location = new System.Drawing.Point(650, 12);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(144, 38);
            this.buttonAdmin.TabIndex = 1;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // groupDestination
            // 
            this.groupDestination.BackColor = System.Drawing.Color.Cornsilk;
            this.groupDestination.Controls.Add(this.buttonSubmit);
            this.groupDestination.Controls.Add(this.comboMode);
            this.groupDestination.Controls.Add(this.label3);
            this.groupDestination.Controls.Add(this.comboDestination);
            this.groupDestination.Controls.Add(this.label1);
            this.groupDestination.Location = new System.Drawing.Point(149, 169);
            this.groupDestination.Name = "groupDestination";
            this.groupDestination.Size = new System.Drawing.Size(693, 161);
            this.groupDestination.TabIndex = 3;
            this.groupDestination.TabStop = false;
            this.groupDestination.Text = "Get Travel Plan";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonSubmit.BackgroundImage = global::TravelPlanner.Properties.Resources.travelbg;
            this.buttonSubmit.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonSubmit.Location = new System.Drawing.Point(477, 88);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(159, 35);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Get Path";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // comboMode
            // 
            this.comboMode.FormattingEnabled = true;
            this.comboMode.Location = new System.Drawing.Point(477, 36);
            this.comboMode.Name = "comboMode";
            this.comboMode.Size = new System.Drawing.Size(159, 31);
            this.comboMode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Travel Mode";
            // 
            // comboDestination
            // 
            this.comboDestination.FormattingEnabled = true;
            this.comboDestination.Location = new System.Drawing.Point(172, 36);
            this.comboDestination.Name = "comboDestination";
            this.comboDestination.Size = new System.Drawing.Size(169, 31);
            this.comboDestination.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Destination";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.BackColor = System.Drawing.Color.Transparent;
            this.labelLocation.ForeColor = System.Drawing.Color.Cornsilk;
            this.labelLocation.Location = new System.Drawing.Point(150, 121);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(123, 23);
            this.labelLocation.TabIndex = 4;
            this.labelLocation.Text = "Your Location: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(669, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Location";
            // 
            // comboLocations
            // 
            this.comboLocations.FormattingEnabled = true;
            this.comboLocations.Location = new System.Drawing.Point(811, 59);
            this.comboLocations.Name = "comboLocations";
            this.comboLocations.Size = new System.Drawing.Size(144, 31);
            this.comboLocations.TabIndex = 6;
            this.comboLocations.SelectedIndexChanged += new System.EventHandler(this.comboLocations_SelectedIndexChanged);
            // 
            // panelPath
            // 
            this.panelPath.BackColor = System.Drawing.Color.Cornsilk;
            this.panelPath.Controls.Add(this.labelTime);
            this.panelPath.Controls.Add(this.button1);
            this.panelPath.Controls.Add(this.labelPath);
            this.panelPath.Controls.Add(this.label4);
            this.panelPath.Location = new System.Drawing.Point(148, 373);
            this.panelPath.Name = "panelPath";
            this.panelPath.Size = new System.Drawing.Size(693, 179);
            this.panelPath.TabIndex = 7;
            this.panelPath.Visible = false;
            this.panelPath.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPath_Paint);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(20, 90);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(92, 23);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "Total Time:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TravelPlanner.Properties.Resources.travelbg;
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(20, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Plan Trip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(20, 55);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(44, 23);
            this.labelPath.TabIndex = 1;
            this.labelPath.Text = "Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Shortest Path";
            // 
            // buttonPlan
            // 
            this.buttonPlan.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonPlan.Font = new System.Drawing.Font("Cambria", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlan.Location = new System.Drawing.Point(811, 12);
            this.buttonPlan.Name = "buttonPlan";
            this.buttonPlan.Size = new System.Drawing.Size(144, 38);
            this.buttonPlan.TabIndex = 8;
            this.buttonPlan.Text = "My Plan";
            this.buttonPlan.UseVisualStyleBackColor = false;
            this.buttonPlan.Click += new System.EventHandler(this.buttonPlan_Click);
            // 
            // SelectTravel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TravelPlanner.Properties.Resources.travelbg;
            this.ClientSize = new System.Drawing.Size(986, 609);
            this.Controls.Add(this.buttonPlan);
            this.Controls.Add(this.panelPath);
            this.Controls.Add(this.comboLocations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.groupDestination);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SelectTravel";
            this.Text = "SelectTravel";
            this.Load += new System.EventHandler(this.SelectTravel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupDestination.ResumeLayout(false);
            this.groupDestination.PerformLayout();
            this.panelPath.ResumeLayout(false);
            this.panelPath.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.GroupBox groupDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboDestination;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboLocations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboMode;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Panel panelPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonPlan;
    }
}