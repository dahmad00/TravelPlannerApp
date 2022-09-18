
namespace TravelPlanner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainHeading = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.GroupBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.boxName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.LoginBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainHeading
            // 
            this.MainHeading.AutoSize = true;
            this.MainHeading.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MainHeading.Font = new System.Drawing.Font("Forte", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainHeading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainHeading.Location = new System.Drawing.Point(1, 0);
            this.MainHeading.Name = "MainHeading";
            this.MainHeading.Size = new System.Drawing.Size(1033, 94);
            this.MainHeading.TabIndex = 0;
            this.MainHeading.Text = "Welcome to Travel Planner";
            this.MainHeading.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginBox
            // 
            this.LoginBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LoginBox.Controls.Add(this.btnSignUp);
            this.LoginBox.Controls.Add(this.buttonLogin);
            this.LoginBox.Controls.Add(this.boxPassword);
            this.LoginBox.Controls.Add(this.boxName);
            this.LoginBox.Controls.Add(this.labelPassword);
            this.LoginBox.Controls.Add(this.labelName);
            this.LoginBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LoginBox.Location = new System.Drawing.Point(278, 159);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginBox.Size = new System.Drawing.Size(418, 322);
            this.LoginBox.TabIndex = 1;
            this.LoginBox.TabStop = false;
            this.LoginBox.Enter += new System.EventHandler(this.LoginBox_Enter);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.Font = new System.Drawing.Font("Cambria", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSignUp.Location = new System.Drawing.Point(-6, 285);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(435, 37);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "Click Here to Sign up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogin.Location = new System.Drawing.Point(76, 207);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(238, 46);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Sign In";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // boxPassword
            // 
            this.boxPassword.Location = new System.Drawing.Point(76, 159);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.Size = new System.Drawing.Size(238, 30);
            this.boxPassword.TabIndex = 3;
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(76, 76);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(238, 30);
            this.boxName.TabIndex = 2;
            this.boxName.TextChanged += new System.EventHandler(this.boxName_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Cambria", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.ForeColor = System.Drawing.Color.Black;
            this.labelPassword.Location = new System.Drawing.Point(76, 126);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(79, 20);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(76, 44);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(81, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Username";
            this.labelName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TravelPlanner.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1016, 594);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.MainHeading);
            this.Name = "Form1";
            this.Text = "Travel Planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginBox.ResumeLayout(false);
            this.LoginBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainHeading;
        private System.Windows.Forms.GroupBox LoginBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.TextBox boxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button btnSignUp;
    }
}

