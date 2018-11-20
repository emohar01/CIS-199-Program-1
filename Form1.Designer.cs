namespace Project__1_
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
            this.components = new System.ComponentModel.Container();
            this.submitButton = new System.Windows.Forms.Button();
            this.wallSpaceLabel = new System.Windows.Forms.Label();
            this.coatsLabel = new System.Windows.Forms.Label();
            this.pricePerGallonLabel = new System.Windows.Forms.Label();
            this.pricePerGallonTextBox = new System.Windows.Forms.TextBox();
            this.coatsTextBox = new System.Windows.Forms.TextBox();
            this.wallSpaceTextBox = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.totalSqFtLabel = new System.Windows.Forms.Label();
            this.gallonsLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.paintPriceLabel = new System.Windows.Forms.Label();
            this.laborPriceLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.totalSqFtOutputLabel = new System.Windows.Forms.Label();
            this.gallonsOutputLabel = new System.Windows.Forms.Label();
            this.hoursOutputLabel = new System.Windows.Forms.Label();
            this.paintPriceOutputLabel = new System.Windows.Forms.Label();
            this.laborPriceOutputLabel = new System.Windows.Forms.Label();
            this.totalPriceOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(219, 257);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // wallSpaceLabel
            // 
            this.wallSpaceLabel.AutoSize = true;
            this.wallSpaceLabel.Location = new System.Drawing.Point(54, 55);
            this.wallSpaceLabel.Name = "wallSpaceLabel";
            this.wallSpaceLabel.Size = new System.Drawing.Size(138, 13);
            this.wallSpaceLabel.TabIndex = 1;
            this.wallSpaceLabel.Text = "Square Feet of Wall Space:";
            // 
            // coatsLabel
            // 
            this.coatsLabel.AutoSize = true;
            this.coatsLabel.Location = new System.Drawing.Point(155, 93);
            this.coatsLabel.Name = "coatsLabel";
            this.coatsLabel.Size = new System.Drawing.Size(37, 13);
            this.coatsLabel.TabIndex = 2;
            this.coatsLabel.Text = "Coats:";
            // 
            // pricePerGallonLabel
            // 
            this.pricePerGallonLabel.AutoSize = true;
            this.pricePerGallonLabel.Location = new System.Drawing.Point(119, 131);
            this.pricePerGallonLabel.Name = "pricePerGallonLabel";
            this.pricePerGallonLabel.Size = new System.Drawing.Size(86, 13);
            this.pricePerGallonLabel.TabIndex = 3;
            this.pricePerGallonLabel.Text = "Price Per Gallon:";
            // 
            // pricePerGallonTextBox
            // 
            this.pricePerGallonTextBox.Location = new System.Drawing.Point(219, 128);
            this.pricePerGallonTextBox.Name = "pricePerGallonTextBox";
            this.pricePerGallonTextBox.Size = new System.Drawing.Size(100, 20);
            this.pricePerGallonTextBox.TabIndex = 4;
            // 
            // coatsTextBox
            // 
            this.coatsTextBox.Location = new System.Drawing.Point(219, 86);
            this.coatsTextBox.Name = "coatsTextBox";
            this.coatsTextBox.Size = new System.Drawing.Size(100, 20);
            this.coatsTextBox.TabIndex = 5;
            // 
            // wallSpaceTextBox
            // 
            this.wallSpaceTextBox.Location = new System.Drawing.Point(219, 48);
            this.wallSpaceTextBox.Name = "wallSpaceTextBox";
            this.wallSpaceTextBox.Size = new System.Drawing.Size(100, 20);
            this.wallSpaceTextBox.TabIndex = 6;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // totalSqFtLabel
            // 
            this.totalSqFtLabel.AutoSize = true;
            this.totalSqFtLabel.Location = new System.Drawing.Point(359, 32);
            this.totalSqFtLabel.Name = "totalSqFtLabel";
            this.totalSqFtLabel.Size = new System.Drawing.Size(95, 13);
            this.totalSqFtLabel.TabIndex = 7;
            this.totalSqFtLabel.Text = "Total Square Feet:";
            // 
            // gallonsLabel
            // 
            this.gallonsLabel.AutoSize = true;
            this.gallonsLabel.Location = new System.Drawing.Point(409, 76);
            this.gallonsLabel.Name = "gallonsLabel";
            this.gallonsLabel.Size = new System.Drawing.Size(45, 13);
            this.gallonsLabel.TabIndex = 9;
            this.gallonsLabel.Text = "Gallons:";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(416, 128);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(38, 13);
            this.hoursLabel.TabIndex = 11;
            this.hoursLabel.Text = "Hours:";
            // 
            // paintPriceLabel
            // 
            this.paintPriceLabel.AutoSize = true;
            this.paintPriceLabel.Location = new System.Drawing.Point(366, 166);
            this.paintPriceLabel.Name = "paintPriceLabel";
            this.paintPriceLabel.Size = new System.Drawing.Size(88, 13);
            this.paintPriceLabel.TabIndex = 13;
            this.paintPriceLabel.Text = "Paint Price Total:";
            // 
            // laborPriceLabel
            // 
            this.laborPriceLabel.AutoSize = true;
            this.laborPriceLabel.Location = new System.Drawing.Point(390, 219);
            this.laborPriceLabel.Name = "laborPriceLabel";
            this.laborPriceLabel.Size = new System.Drawing.Size(64, 13);
            this.laborPriceLabel.TabIndex = 14;
            this.laborPriceLabel.Text = "Labor Price:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(390, 267);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(61, 13);
            this.totalPriceLabel.TabIndex = 17;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // totalSqFtOutputLabel
            // 
            this.totalSqFtOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSqFtOutputLabel.Location = new System.Drawing.Point(513, 31);
            this.totalSqFtOutputLabel.Name = "totalSqFtOutputLabel";
            this.totalSqFtOutputLabel.Size = new System.Drawing.Size(95, 25);
            this.totalSqFtOutputLabel.TabIndex = 18;
            // 
            // gallonsOutputLabel
            // 
            this.gallonsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gallonsOutputLabel.Location = new System.Drawing.Point(513, 75);
            this.gallonsOutputLabel.Name = "gallonsOutputLabel";
            this.gallonsOutputLabel.Size = new System.Drawing.Size(95, 25);
            this.gallonsOutputLabel.TabIndex = 19;
            // 
            // hoursOutputLabel
            // 
            this.hoursOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoursOutputLabel.Location = new System.Drawing.Point(513, 127);
            this.hoursOutputLabel.Name = "hoursOutputLabel";
            this.hoursOutputLabel.Size = new System.Drawing.Size(95, 25);
            this.hoursOutputLabel.TabIndex = 20;
            // 
            // paintPriceOutputLabel
            // 
            this.paintPriceOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintPriceOutputLabel.Location = new System.Drawing.Point(513, 165);
            this.paintPriceOutputLabel.Name = "paintPriceOutputLabel";
            this.paintPriceOutputLabel.Size = new System.Drawing.Size(95, 25);
            this.paintPriceOutputLabel.TabIndex = 21;
            // 
            // laborPriceOutputLabel
            // 
            this.laborPriceOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborPriceOutputLabel.Location = new System.Drawing.Point(513, 218);
            this.laborPriceOutputLabel.Name = "laborPriceOutputLabel";
            this.laborPriceOutputLabel.Size = new System.Drawing.Size(95, 25);
            this.laborPriceOutputLabel.TabIndex = 22;
            // 
            // totalPriceOutputLabel
            // 
            this.totalPriceOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceOutputLabel.Location = new System.Drawing.Point(513, 261);
            this.totalPriceOutputLabel.Name = "totalPriceOutputLabel";
            this.totalPriceOutputLabel.Size = new System.Drawing.Size(95, 25);
            this.totalPriceOutputLabel.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 292);
            this.Controls.Add(this.totalPriceOutputLabel);
            this.Controls.Add(this.laborPriceOutputLabel);
            this.Controls.Add(this.paintPriceOutputLabel);
            this.Controls.Add(this.hoursOutputLabel);
            this.Controls.Add(this.gallonsOutputLabel);
            this.Controls.Add(this.totalSqFtOutputLabel);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.laborPriceLabel);
            this.Controls.Add(this.paintPriceLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.gallonsLabel);
            this.Controls.Add(this.totalSqFtLabel);
            this.Controls.Add(this.wallSpaceTextBox);
            this.Controls.Add(this.coatsTextBox);
            this.Controls.Add(this.pricePerGallonTextBox);
            this.Controls.Add(this.pricePerGallonLabel);
            this.Controls.Add(this.coatsLabel);
            this.Controls.Add(this.wallSpaceLabel);
            this.Controls.Add(this.submitButton);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label wallSpaceLabel;
        private System.Windows.Forms.Label coatsLabel;
        private System.Windows.Forms.Label pricePerGallonLabel;
        private System.Windows.Forms.TextBox pricePerGallonTextBox;
        private System.Windows.Forms.TextBox coatsTextBox;
        private System.Windows.Forms.TextBox wallSpaceTextBox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label totalSqFtLabel;
        private System.Windows.Forms.Label gallonsLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label paintPriceLabel;
        private System.Windows.Forms.Label laborPriceLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label totalSqFtOutputLabel;
        private System.Windows.Forms.Label gallonsOutputLabel;
        private System.Windows.Forms.Label hoursOutputLabel;
        private System.Windows.Forms.Label paintPriceOutputLabel;
        private System.Windows.Forms.Label laborPriceOutputLabel;
        private System.Windows.Forms.Label totalPriceOutputLabel;
    }
}

