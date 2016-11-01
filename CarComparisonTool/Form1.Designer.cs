namespace CarComparisonTool
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
            this.txtCars = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdResult = new System.Windows.Forms.DataGridView();
            this.btnAddCars = new System.Windows.Forms.Button();
            this.btnNewestVehicles = new System.Windows.Forms.Button();
            this.btnAlphabetizedList = new System.Windows.Forms.Button();
            this.btnVehiclesbyPrice = new System.Windows.Forms.Button();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.Distance = new System.Windows.Forms.Label();
            this.btnFuelConsumption = new System.Windows.Forms.Button();
            this.btnRandomCar = new System.Windows.Forms.Button();
            this.btnAvgMiles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCars
            // 
            this.txtCars.Location = new System.Drawing.Point(56, 29);
            this.txtCars.Multiline = true;
            this.txtCars.Name = "txtCars";
            this.txtCars.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCars.Size = new System.Drawing.Size(368, 71);
            this.txtCars.TabIndex = 0;
            this.txtCars.Text = resources.GetString("txtCars.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cars";
            // 
            // grdResult
            // 
            this.grdResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResult.Location = new System.Drawing.Point(56, 201);
            this.grdResult.Name = "grdResult";
            this.grdResult.Size = new System.Drawing.Size(729, 150);
            this.grdResult.TabIndex = 2;
            // 
            // btnAddCars
            // 
            this.btnAddCars.Location = new System.Drawing.Point(430, 29);
            this.btnAddCars.Name = "btnAddCars";
            this.btnAddCars.Size = new System.Drawing.Size(75, 23);
            this.btnAddCars.TabIndex = 3;
            this.btnAddCars.Text = "Add Cars";
            this.btnAddCars.UseVisualStyleBackColor = true;
            this.btnAddCars.Click += new System.EventHandler(this.btnAddCars_Click);
            // 
            // btnNewestVehicles
            // 
            this.btnNewestVehicles.Location = new System.Drawing.Point(56, 107);
            this.btnNewestVehicles.Name = "btnNewestVehicles";
            this.btnNewestVehicles.Size = new System.Drawing.Size(103, 23);
            this.btnNewestVehicles.TabIndex = 4;
            this.btnNewestVehicles.Text = "Newest vehicles";
            this.btnNewestVehicles.UseVisualStyleBackColor = true;
            this.btnNewestVehicles.Click += new System.EventHandler(this.btnNewestVehicles_Click);
            // 
            // btnAlphabetizedList
            // 
            this.btnAlphabetizedList.Location = new System.Drawing.Point(166, 107);
            this.btnAlphabetizedList.Name = "btnAlphabetizedList";
            this.btnAlphabetizedList.Size = new System.Drawing.Size(99, 23);
            this.btnAlphabetizedList.TabIndex = 5;
            this.btnAlphabetizedList.Text = "Alphabetized List";
            this.btnAlphabetizedList.UseVisualStyleBackColor = true;
            this.btnAlphabetizedList.Click += new System.EventHandler(this.btnAlphabetizedList_Click);
            // 
            // btnVehiclesbyPrice
            // 
            this.btnVehiclesbyPrice.Location = new System.Drawing.Point(272, 106);
            this.btnVehiclesbyPrice.Name = "btnVehiclesbyPrice";
            this.btnVehiclesbyPrice.Size = new System.Drawing.Size(100, 23);
            this.btnVehiclesbyPrice.TabIndex = 6;
            this.btnVehiclesbyPrice.Text = "Vehicles by Price";
            this.btnVehiclesbyPrice.UseVisualStyleBackColor = true;
            this.btnVehiclesbyPrice.Click += new System.EventHandler(this.btnVehiclesbyPrice_Click);
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(56, 146);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 20);
            this.txtDistance.TabIndex = 7;
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Location = new System.Drawing.Point(10, 149);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(31, 13);
            this.Distance.TabIndex = 8;
            this.Distance.Text = "Miles";
            // 
            // btnFuelConsumption
            // 
            this.btnFuelConsumption.Location = new System.Drawing.Point(163, 146);
            this.btnFuelConsumption.Name = "btnFuelConsumption";
            this.btnFuelConsumption.Size = new System.Drawing.Size(163, 23);
            this.btnFuelConsumption.TabIndex = 9;
            this.btnFuelConsumption.Text = "Calculate Fuel Consumption";
            this.btnFuelConsumption.UseVisualStyleBackColor = true;
            this.btnFuelConsumption.Click += new System.EventHandler(this.btnFuelConsumption_Click);
            // 
            // btnRandomCar
            // 
            this.btnRandomCar.Location = new System.Drawing.Point(379, 105);
            this.btnRandomCar.Name = "btnRandomCar";
            this.btnRandomCar.Size = new System.Drawing.Size(75, 23);
            this.btnRandomCar.TabIndex = 10;
            this.btnRandomCar.Text = "Random Car";
            this.btnRandomCar.UseVisualStyleBackColor = true;
            this.btnRandomCar.Click += new System.EventHandler(this.btnRandomCar_Click);
            // 
            // btnAvgMiles
            // 
            this.btnAvgMiles.Location = new System.Drawing.Point(332, 146);
            this.btnAvgMiles.Name = "btnAvgMiles";
            this.btnAvgMiles.Size = new System.Drawing.Size(75, 23);
            this.btnAvgMiles.TabIndex = 11;
            this.btnAvgMiles.Text = "Avg MPG";
            this.btnAvgMiles.UseVisualStyleBackColor = true;
            this.btnAvgMiles.Click += new System.EventHandler(this.btnAvgMiles_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Result";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Best value";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(97, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 428);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAvgMiles);
            this.Controls.Add(this.btnRandomCar);
            this.Controls.Add(this.btnFuelConsumption);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.btnVehiclesbyPrice);
            this.Controls.Add(this.btnAlphabetizedList);
            this.Controls.Add(this.btnNewestVehicles);
            this.Controls.Add(this.btnAddCars);
            this.Controls.Add(this.grdResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCars);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdResult;
        private System.Windows.Forms.Button btnAddCars;
        private System.Windows.Forms.Button btnNewestVehicles;
        private System.Windows.Forms.Button btnAlphabetizedList;
        private System.Windows.Forms.Button btnVehiclesbyPrice;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label Distance;
        private System.Windows.Forms.Button btnFuelConsumption;
        private System.Windows.Forms.Button btnRandomCar;
        private System.Windows.Forms.Button btnAvgMiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

