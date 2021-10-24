
namespace Phumla_Kamnandi_Hotel.Presentation
{
    partial class LoginForm
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
            this.lblHeader2 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.employeeIDTxt = new System.Windows.Forms.TextBox();
            this.lbDStaffID = new System.Windows.Forms.Label();
            this.lblHeader1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader2
            // 
            this.lblHeader2.AutoSize = true;
            this.lblHeader2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblHeader2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader2.Location = new System.Drawing.Point(52, 85);
            this.lblHeader2.Name = "lblHeader2";
            this.lblHeader2.Size = new System.Drawing.Size(405, 20);
            this.lblHeader2.TabIndex = 22;
            this.lblHeader2.Text = "Please enter your Employee Credentials Below";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPassword.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(175, 217);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 22);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLogin.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(313, 298);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 42);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(407, 212);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(221, 27);
            this.passwordTxt.TabIndex = 19;
            // 
            // employeeIDTxt
            // 
            this.employeeIDTxt.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDTxt.Location = new System.Drawing.Point(407, 152);
            this.employeeIDTxt.Name = "employeeIDTxt";
            this.employeeIDTxt.Size = new System.Drawing.Size(221, 27);
            this.employeeIDTxt.TabIndex = 18;
            // 
            // lbDStaffID
            // 
            this.lbDStaffID.AutoSize = true;
            this.lbDStaffID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDStaffID.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDStaffID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDStaffID.Location = new System.Drawing.Point(165, 154);
            this.lbDStaffID.Name = "lbDStaffID";
            this.lbDStaffID.Size = new System.Drawing.Size(100, 22);
            this.lbDStaffID.TabIndex = 17;
            this.lbDStaffID.Text = "Staff ID ";
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblHeader1.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader1.Location = new System.Drawing.Point(52, 34);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(428, 23);
            this.lblHeader1.TabIndex = 16;
            this.lblHeader1.Text = "Welcome to Phumla Kamnandi Hotel Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Phumla_Kamnandi_Hotel.Properties.Resources.Belmond_Hotel_Caruso_in_Ravello_Italy;
            this.pictureBox1.Location = new System.Drawing.Point(-22, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(763, 409);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 387);
            this.Controls.Add(this.lblHeader2);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.employeeIDTxt);
            this.Controls.Add(this.lbDStaffID);
            this.Controls.Add(this.lblHeader1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox employeeIDTxt;
        private System.Windows.Forms.Label lbDStaffID;
        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}