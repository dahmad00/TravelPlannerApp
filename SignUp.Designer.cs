
namespace TravelPlanner
{
    partial class SignUp
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
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.boxUsername = new System.Windows.Forms.TextBox();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.comboLocation = new System.Windows.Forms.ComboBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(28, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(87, 23);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(28, 103);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(80, 23);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(28, 182);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(125, 23);
            this.labelLocation.TabIndex = 2;
            this.labelLocation.Text = "Select Location";
            // 
            // boxUsername
            // 
            this.boxUsername.Location = new System.Drawing.Point(28, 48);
            this.boxUsername.Name = "boxUsername";
            this.boxUsername.Size = new System.Drawing.Size(246, 30);
            this.boxUsername.TabIndex = 3;
            // 
            // boxPassword
            // 
            this.boxPassword.Location = new System.Drawing.Point(28, 129);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.Size = new System.Drawing.Size(246, 30);
            this.boxPassword.TabIndex = 4;
            // 
            // comboLocation
            // 
            this.comboLocation.FormattingEnabled = true;
            this.comboLocation.Location = new System.Drawing.Point(28, 208);
            this.comboLocation.Name = "comboLocation";
            this.comboLocation.Size = new System.Drawing.Size(246, 31);
            this.comboLocation.TabIndex = 5;
            this.comboLocation.SelectedIndexChanged += new System.EventHandler(this.comboLocation_SelectedIndexChanged);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.Black;
            this.buttonSignUp.Font = new System.Drawing.Font("Calibri", 12.89552F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSignUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSignUp.Location = new System.Drawing.Point(28, 257);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(246, 49);
            this.buttonSignUp.TabIndex = 6;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TravelPlanner.Properties.Resources.bgSingUp;
            this.ClientSize = new System.Drawing.Size(312, 568);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.comboLocation);
            this.Controls.Add(this.boxPassword);
            this.Controls.Add(this.boxUsername);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelName);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.TextBox boxUsername;
        private System.Windows.Forms.TextBox boxPassword;
        private System.Windows.Forms.ComboBox comboLocation;
        private System.Windows.Forms.Button buttonSignUp;
    }
}