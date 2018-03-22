namespace SchoolFormsApp
{
    partial class Form1
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
            this.fieldName = new System.Windows.Forms.Label();
            this.fieldAddress = new System.Windows.Forms.Label();
            this.fieldCity = new System.Windows.Forms.Label();
            this.fieldState = new System.Windows.Forms.Label();
            this.fieldZip = new System.Windows.Forms.Label();
            this.fieldPhone = new System.Windows.Forms.Label();
            this.fieldTwitter = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTwitter = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnPushToTest = new System.Windows.Forms.Button();
            this.btnTestTeacher = new System.Windows.Forms.Button();
            this.btnTestStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fieldName
            // 
            this.fieldName.AutoSize = true;
            this.fieldName.Location = new System.Drawing.Point(56, 30);
            this.fieldName.Name = "fieldName";
            this.fieldName.Size = new System.Drawing.Size(90, 17);
            this.fieldName.TabIndex = 0;
            this.fieldName.Text = "School name";
            this.fieldName.Click += new System.EventHandler(this.label1_Click);
            // 
            // fieldAddress
            // 
            this.fieldAddress.AutoSize = true;
            this.fieldAddress.Location = new System.Drawing.Point(56, 77);
            this.fieldAddress.Name = "fieldAddress";
            this.fieldAddress.Size = new System.Drawing.Size(106, 17);
            this.fieldAddress.TabIndex = 1;
            this.fieldAddress.Text = "School address";
            // 
            // fieldCity
            // 
            this.fieldCity.AutoSize = true;
            this.fieldCity.Location = new System.Drawing.Point(56, 119);
            this.fieldCity.Name = "fieldCity";
            this.fieldCity.Size = new System.Drawing.Size(31, 17);
            this.fieldCity.TabIndex = 2;
            this.fieldCity.Text = "City";
            // 
            // fieldState
            // 
            this.fieldState.AutoSize = true;
            this.fieldState.Location = new System.Drawing.Point(56, 156);
            this.fieldState.Name = "fieldState";
            this.fieldState.Size = new System.Drawing.Size(41, 17);
            this.fieldState.TabIndex = 3;
            this.fieldState.Text = "State";
            this.fieldState.Click += new System.EventHandler(this.label4_Click);
            // 
            // fieldZip
            // 
            this.fieldZip.AutoSize = true;
            this.fieldZip.Location = new System.Drawing.Point(56, 198);
            this.fieldZip.Name = "fieldZip";
            this.fieldZip.Size = new System.Drawing.Size(28, 17);
            this.fieldZip.TabIndex = 4;
            this.fieldZip.Text = "Zip";
            // 
            // fieldPhone
            // 
            this.fieldPhone.AutoSize = true;
            this.fieldPhone.Location = new System.Drawing.Point(56, 242);
            this.fieldPhone.Name = "fieldPhone";
            this.fieldPhone.Size = new System.Drawing.Size(101, 17);
            this.fieldPhone.TabIndex = 5;
            this.fieldPhone.Text = "Phone number";
            // 
            // fieldTwitter
            // 
            this.fieldTwitter.AutoSize = true;
            this.fieldTwitter.Location = new System.Drawing.Point(56, 289);
            this.fieldTwitter.Name = "fieldTwitter";
            this.fieldTwitter.Size = new System.Drawing.Size(105, 17);
            this.fieldTwitter.TabIndex = 6;
            this.fieldTwitter.Text = "Twitter adderss";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(168, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 7;
            // 
            // txtTwitter
            // 
            this.txtTwitter.Location = new System.Drawing.Point(168, 284);
            this.txtTwitter.Name = "txtTwitter";
            this.txtTwitter.Size = new System.Drawing.Size(100, 22);
            this.txtTwitter.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(168, 242);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 9;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(168, 193);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 22);
            this.txtZip.TabIndex = 10;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(168, 153);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 22);
            this.txtState.TabIndex = 11;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(168, 114);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 22);
            this.txtCity.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(168, 72);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 22);
            this.txtAddress.TabIndex = 13;
            // 
            // btnPushToTest
            // 
            this.btnPushToTest.Location = new System.Drawing.Point(150, 340);
            this.btnPushToTest.Name = "btnPushToTest";
            this.btnPushToTest.Size = new System.Drawing.Size(118, 23);
            this.btnPushToTest.TabIndex = 14;
            this.btnPushToTest.Text = " Push to test";
            this.btnPushToTest.UseVisualStyleBackColor = true;
            this.btnPushToTest.Click += new System.EventHandler(this.btnPushToTest_Click);
            // 
            // btnTestTeacher
            // 
            this.btnTestTeacher.Location = new System.Drawing.Point(150, 379);
            this.btnTestTeacher.Name = "btnTestTeacher";
            this.btnTestTeacher.Size = new System.Drawing.Size(118, 23);
            this.btnTestTeacher.TabIndex = 15;
            this.btnTestTeacher.Text = "Test Teacher";
            this.btnTestTeacher.UseVisualStyleBackColor = true;
            this.btnTestTeacher.Click += new System.EventHandler(this.btnTestTeacher_Click);
            // 
            // btnTestStudent
            // 
            this.btnTestStudent.Location = new System.Drawing.Point(150, 418);
            this.btnTestStudent.Name = "btnTestStudent";
            this.btnTestStudent.Size = new System.Drawing.Size(118, 23);
            this.btnTestStudent.TabIndex = 16;
            this.btnTestStudent.Text = "Test Student";
            this.btnTestStudent.UseVisualStyleBackColor = true;
            this.btnTestStudent.Click += new System.EventHandler(this.btnTestStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 515);
            this.Controls.Add(this.btnTestStudent);
            this.Controls.Add(this.btnTestTeacher);
            this.Controls.Add(this.btnPushToTest);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtTwitter);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.fieldTwitter);
            this.Controls.Add(this.fieldPhone);
            this.Controls.Add(this.fieldZip);
            this.Controls.Add(this.fieldState);
            this.Controls.Add(this.fieldCity);
            this.Controls.Add(this.fieldAddress);
            this.Controls.Add(this.fieldName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fieldName;
        private System.Windows.Forms.Label fieldAddress;
        private System.Windows.Forms.Label fieldCity;
        private System.Windows.Forms.Label fieldState;
        private System.Windows.Forms.Label fieldZip;
        private System.Windows.Forms.Label fieldPhone;
        private System.Windows.Forms.Label fieldTwitter;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTwitter;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnPushToTest;
        private System.Windows.Forms.Button btnTestTeacher;
        private System.Windows.Forms.Button btnTestStudent;
    }
}

