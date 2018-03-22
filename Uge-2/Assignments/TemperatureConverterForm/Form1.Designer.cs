namespace TemperatureConverterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.btnToCelcius = new System.Windows.Forms.Button();
            this.btnToFarenheit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(67, 82);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(100, 22);
            this.txtTemperature.TabIndex = 1;
            // 
            // btnToCelcius
            // 
            this.btnToCelcius.Location = new System.Drawing.Point(67, 123);
            this.btnToCelcius.Name = "btnToCelcius";
            this.btnToCelcius.Size = new System.Drawing.Size(100, 23);
            this.btnToCelcius.TabIndex = 2;
            this.btnToCelcius.Text = "To Celcius";
            this.btnToCelcius.UseVisualStyleBackColor = true;
            this.btnToCelcius.Click += new System.EventHandler(this.btnToCelcius_Click);
            // 
            // btnToFarenheit
            // 
            this.btnToFarenheit.Location = new System.Drawing.Point(176, 123);
            this.btnToFarenheit.Name = "btnToFarenheit";
            this.btnToFarenheit.Size = new System.Drawing.Size(102, 23);
            this.btnToFarenheit.TabIndex = 3;
            this.btnToFarenheit.Text = "To Farenheit";
            this.btnToFarenheit.UseVisualStyleBackColor = true;
            this.btnToFarenheit.Click += new System.EventHandler(this.btnToFarenheit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 253);
            this.Controls.Add(this.btnToFarenheit);
            this.Controls.Add(this.btnToCelcius);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Button btnToCelcius;
        private System.Windows.Forms.Button btnToFarenheit;
    }
}

