namespace Assignment9
{
    partial class AddFlightForm
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
            this.flightIDBox = new System.Windows.Forms.TextBox();
            this.originBox = new System.Windows.Forms.MaskedTextBox();
            this.destinationBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.airlineBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.companyBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flightIDBox
            // 
            this.flightIDBox.Location = new System.Drawing.Point(281, 49);
            this.flightIDBox.Name = "flightIDBox";
            this.flightIDBox.Size = new System.Drawing.Size(265, 26);
            this.flightIDBox.TabIndex = 0;
            // 
            // originBox
            // 
            this.originBox.Location = new System.Drawing.Point(281, 109);
            this.originBox.Name = "originBox";
            this.originBox.Size = new System.Drawing.Size(264, 26);
            this.originBox.TabIndex = 1;
            // 
            // destinationBox
            // 
            this.destinationBox.Location = new System.Drawing.Point(281, 181);
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(264, 26);
            this.destinationBox.TabIndex = 2;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(281, 251);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(264, 26);
            this.dateBox.TabIndex = 3;
            // 
            // airlineBox
            // 
            this.airlineBox.Location = new System.Drawing.Point(281, 324);
            this.airlineBox.Name = "airlineBox";
            this.airlineBox.Size = new System.Drawing.Size(264, 26);
            this.airlineBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Flight ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Origin: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Destination: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date: ";
            // 
            // companyBox
            // 
            this.companyBox.AutoSize = true;
            this.companyBox.Location = new System.Drawing.Point(37, 314);
            this.companyBox.Name = "companyBox";
            this.companyBox.Size = new System.Drawing.Size(197, 30);
            this.companyBox.TabIndex = 10;
            this.companyBox.Text = "Airline Company: ";
            // 
            // AddFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.companyBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.airlineBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.destinationBox);
            this.Controls.Add(this.originBox);
            this.Controls.Add(this.flightIDBox);
            this.Name = "AddFlightForm";
            this.Text = "AddFlightForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox flightIDBox;
        private System.Windows.Forms.MaskedTextBox originBox;
        private System.Windows.Forms.TextBox destinationBox;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.TextBox airlineBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label companyBox;
    }
}