namespace CurrencyCalculaterForm
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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnToEuro = new System.Windows.Forms.Button();
            this.btnToDkk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(65, 68);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnToEuro
            // 
            this.btnToEuro.Location = new System.Drawing.Point(65, 111);
            this.btnToEuro.Name = "btnToEuro";
            this.btnToEuro.Size = new System.Drawing.Size(75, 23);
            this.btnToEuro.TabIndex = 1;
            this.btnToEuro.Text = "To Euro";
            this.btnToEuro.UseVisualStyleBackColor = true;
            this.btnToEuro.Click += new System.EventHandler(this.btnToEuro_Click);
            // 
            // btnToDkk
            // 
            this.btnToDkk.Location = new System.Drawing.Point(164, 111);
            this.btnToDkk.Name = "btnToDkk";
            this.btnToDkk.Size = new System.Drawing.Size(75, 23);
            this.btnToDkk.TabIndex = 2;
            this.btnToDkk.Text = "To DKK";
            this.btnToDkk.UseVisualStyleBackColor = true;
            this.btnToDkk.Click += new System.EventHandler(this.btnToDkk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnToDkk);
            this.Controls.Add(this.btnToEuro);
            this.Controls.Add(this.txtAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnToEuro;
        private System.Windows.Forms.Button btnToDkk;
        private System.Windows.Forms.Label label1;
    }
}

