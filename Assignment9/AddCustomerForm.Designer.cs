namespace Assignment9
{
    partial class AddCustomerForm
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
            this.customerIDBox = new System.Windows.Forms.TextBox();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.flightIDBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerIDBox
            // 
            this.customerIDBox.Location = new System.Drawing.Point(216, 73);
            this.customerIDBox.Name = "customerIDBox";
            this.customerIDBox.Size = new System.Drawing.Size(332, 26);
            this.customerIDBox.TabIndex = 0;
            // 
            // customerNameBox
            // 
            this.customerNameBox.Location = new System.Drawing.Point(216, 147);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(331, 26);
            this.customerNameBox.TabIndex = 1;
            // 
            // flightIDBox
            // 
            this.flightIDBox.Location = new System.Drawing.Point(216, 228);
            this.flightIDBox.Name = "flightIDBox";
            this.flightIDBox.Size = new System.Drawing.Size(330, 26);
            this.flightIDBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Flight ID: ";
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flightIDBox);
            this.Controls.Add(this.customerNameBox);
            this.Controls.Add(this.customerIDBox);
            this.Name = "AddCustomerForm";
            this.Text = "AddCustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerIDBox;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.TextBox flightIDBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}