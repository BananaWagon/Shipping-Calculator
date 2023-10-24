namespace ShippingCalculator___NestorMonteagudo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.packageWeightInputTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalShippingOutputLabel = new System.Windows.Forms.Label();
            this.weightCostOutputLabel = new System.Windows.Forms.Label();
            this.zoneCostOutPutLabel = new System.Windows.Forms.Label();
            this.poundRateOutputLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.priceCappedImageBox = new System.Windows.Forms.PictureBox();
            this.priceCappedLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.nRadioButton = new System.Windows.Forms.RadioButton();
            this.sRadioButton = new System.Windows.Forms.RadioButton();
            this.eRadioButton = new System.Windows.Forms.RadioButton();
            this.wRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceCappedImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Package Weight";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // packageWeightInputTextBox
            // 
            this.packageWeightInputTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.packageWeightInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageWeightInputTextBox.Location = new System.Drawing.Point(116, 28);
            this.packageWeightInputTextBox.Name = "packageWeightInputTextBox";
            this.packageWeightInputTextBox.Size = new System.Drawing.Size(75, 20);
            this.packageWeightInputTextBox.TabIndex = 1;
            this.packageWeightInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shipping Zone";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.wRadioButton);
            this.groupBox1.Controls.Add(this.eRadioButton);
            this.groupBox1.Controls.Add(this.sRadioButton);
            this.groupBox1.Controls.Add(this.nRadioButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.packageWeightInputTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(54, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Package Info";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.totalShippingOutputLabel);
            this.groupBox2.Controls.Add(this.weightCostOutputLabel);
            this.groupBox2.Controls.Add(this.zoneCostOutPutLabel);
            this.groupBox2.Controls.Add(this.poundRateOutputLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(313, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 123);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shipping Cost";
            // 
            // totalShippingOutputLabel
            // 
            this.totalShippingOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalShippingOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalShippingOutputLabel.Location = new System.Drawing.Point(112, 76);
            this.totalShippingOutputLabel.Name = "totalShippingOutputLabel";
            this.totalShippingOutputLabel.Size = new System.Drawing.Size(79, 20);
            this.totalShippingOutputLabel.TabIndex = 13;
            this.totalShippingOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weightCostOutputLabel
            // 
            this.weightCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightCostOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightCostOutputLabel.Location = new System.Drawing.Point(112, 30);
            this.weightCostOutputLabel.Name = "weightCostOutputLabel";
            this.weightCostOutputLabel.Size = new System.Drawing.Size(79, 20);
            this.weightCostOutputLabel.TabIndex = 11;
            this.weightCostOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zoneCostOutPutLabel
            // 
            this.zoneCostOutPutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zoneCostOutPutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoneCostOutPutLabel.Location = new System.Drawing.Point(112, 53);
            this.zoneCostOutPutLabel.Name = "zoneCostOutPutLabel";
            this.zoneCostOutPutLabel.Size = new System.Drawing.Size(79, 20);
            this.zoneCostOutPutLabel.TabIndex = 12;
            this.zoneCostOutPutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // poundRateOutputLabel
            // 
            this.poundRateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.poundRateOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poundRateOutputLabel.Location = new System.Drawing.Point(112, 99);
            this.poundRateOutputLabel.Name = "poundRateOutputLabel";
            this.poundRateOutputLabel.Size = new System.Drawing.Size(79, 20);
            this.poundRateOutputLabel.TabIndex = 14;
            this.poundRateOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Shipping Cost";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Weight Cost";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Zone Cost";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Per Pound Rate";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(542, 123);
            this.label11.TabIndex = 5;
            this.label11.Text = "NestCo\'s Shipping Calculator";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // priceCappedImageBox
            // 
            this.priceCappedImageBox.BackColor = System.Drawing.Color.Transparent;
            this.priceCappedImageBox.Image = ((System.Drawing.Image)(resources.GetObject("priceCappedImageBox.Image")));
            this.priceCappedImageBox.Location = new System.Drawing.Point(60, 284);
            this.priceCappedImageBox.Name = "priceCappedImageBox";
            this.priceCappedImageBox.Size = new System.Drawing.Size(182, 71);
            this.priceCappedImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.priceCappedImageBox.TabIndex = 6;
            this.priceCappedImageBox.TabStop = false;
            this.priceCappedImageBox.Visible = false;
            // 
            // priceCappedLabel
            // 
            this.priceCappedLabel.BackColor = System.Drawing.Color.Transparent;
            this.priceCappedLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceCappedLabel.Image = ((System.Drawing.Image)(resources.GetObject("priceCappedLabel.Image")));
            this.priceCappedLabel.Location = new System.Drawing.Point(85, 305);
            this.priceCappedLabel.Name = "priceCappedLabel";
            this.priceCappedLabel.Size = new System.Drawing.Size(139, 25);
            this.priceCappedLabel.TabIndex = 7;
            this.priceCappedLabel.Text = "PRICE CAPPED";
            this.priceCappedLabel.Visible = false;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(63, 236);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(182, 42);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate Shipping Cost";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // nRadioButton
            // 
            this.nRadioButton.AutoSize = true;
            this.nRadioButton.Location = new System.Drawing.Point(116, 53);
            this.nRadioButton.Name = "nRadioButton";
            this.nRadioButton.Size = new System.Drawing.Size(34, 17);
            this.nRadioButton.TabIndex = 3;
            this.nRadioButton.TabStop = true;
            this.nRadioButton.Text = "N";
            this.nRadioButton.UseVisualStyleBackColor = true;
            // 
            // sRadioButton
            // 
            this.sRadioButton.AutoSize = true;
            this.sRadioButton.Location = new System.Drawing.Point(154, 53);
            this.sRadioButton.Name = "sRadioButton";
            this.sRadioButton.Size = new System.Drawing.Size(33, 17);
            this.sRadioButton.TabIndex = 4;
            this.sRadioButton.TabStop = true;
            this.sRadioButton.Text = "S";
            this.sRadioButton.UseVisualStyleBackColor = true;
            // 
            // eRadioButton
            // 
            this.eRadioButton.AutoSize = true;
            this.eRadioButton.Location = new System.Drawing.Point(116, 73);
            this.eRadioButton.Name = "eRadioButton";
            this.eRadioButton.Size = new System.Drawing.Size(33, 17);
            this.eRadioButton.TabIndex = 5;
            this.eRadioButton.TabStop = true;
            this.eRadioButton.Text = "E";
            this.eRadioButton.UseVisualStyleBackColor = true;
            // 
            // wRadioButton
            // 
            this.wRadioButton.AutoSize = true;
            this.wRadioButton.Location = new System.Drawing.Point(154, 73);
            this.wRadioButton.Name = "wRadioButton";
            this.wRadioButton.Size = new System.Drawing.Size(37, 17);
            this.wRadioButton.TabIndex = 6;
            this.wRadioButton.TabStop = true;
            this.wRadioButton.Text = "W";
            this.wRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 380);
            this.Controls.Add(this.priceCappedLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.priceCappedImageBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Shipping Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.priceCappedImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox packageWeightInputTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label totalShippingOutputLabel;
        private System.Windows.Forms.Label weightCostOutputLabel;
        private System.Windows.Forms.Label zoneCostOutPutLabel;
        private System.Windows.Forms.Label poundRateOutputLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox priceCappedImageBox;
        private System.Windows.Forms.Label priceCappedLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.RadioButton wRadioButton;
        private System.Windows.Forms.RadioButton eRadioButton;
        private System.Windows.Forms.RadioButton sRadioButton;
        private System.Windows.Forms.RadioButton nRadioButton;
    }
}

