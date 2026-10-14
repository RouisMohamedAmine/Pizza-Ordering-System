namespace Pizza_Project
{
    partial class Frm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm2));
            this.label1 = new System.Windows.Forms.Label();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedum = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.rbThink = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.grpWheretoEat = new System.Windows.Forms.GroupBox();
            this.rbEatOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.cbPeppers = new System.Windows.Forms.CheckBox();
            this.cbOnion = new System.Windows.Forms.CheckBox();
            this.cbTomatoes = new System.Windows.Forms.CheckBox();
            this.cbOlives = new System.Windows.Forms.CheckBox();
            this.cbMushrooms = new System.Windows.Forms.CheckBox();
            this.cbExtraChees = new System.Windows.Forms.CheckBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblWheretoEat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCrust = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.Summary = new System.Windows.Forms.Label();
            this.grpSize.SuspendLayout();
            this.grpCrust.SuspendLayout();
            this.grpWheretoEat.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(349, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(934, 219);
            this.label1.TabIndex = 2;
            this.label1.Text = "PIZZARO";
            // 
            // grpSize
            // 
            this.grpSize.BackColor = System.Drawing.Color.Transparent;
            this.grpSize.Controls.Add(this.rbLarge);
            this.grpSize.Controls.Add(this.rbMedum);
            this.grpSize.Controls.Add(this.rbSmall);
            this.grpSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grpSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpSize.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSize.ForeColor = System.Drawing.Color.PeachPuff;
            this.grpSize.Location = new System.Drawing.Point(89, 307);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(244, 209);
            this.grpSize.TabIndex = 4;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(18, 144);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(120, 36);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "20";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedum
            // 
            this.rbMedum.AutoSize = true;
            this.rbMedum.Location = new System.Drawing.Point(18, 93);
            this.rbMedum.Name = "rbMedum";
            this.rbMedum.Size = new System.Drawing.Size(141, 36);
            this.rbMedum.TabIndex = 1;
            this.rbMedum.TabStop = true;
            this.rbMedum.Tag = "15";
            this.rbMedum.Text = "Medum";
            this.rbMedum.UseVisualStyleBackColor = true;
            this.rbMedum.CheckedChanged += new System.EventHandler(this.rbMedum_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(19, 45);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(120, 36);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "10";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // grpCrust
            // 
            this.grpCrust.BackColor = System.Drawing.Color.Transparent;
            this.grpCrust.Controls.Add(this.rbThink);
            this.grpCrust.Controls.Add(this.rbThin);
            this.grpCrust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grpCrust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpCrust.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCrust.ForeColor = System.Drawing.Color.PeachPuff;
            this.grpCrust.Location = new System.Drawing.Point(89, 619);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Size = new System.Drawing.Size(244, 134);
            this.grpCrust.TabIndex = 5;
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "Crust Type";
            // 
            // rbThink
            // 
            this.rbThink.AutoSize = true;
            this.rbThink.Location = new System.Drawing.Point(18, 93);
            this.rbThink.Name = "rbThink";
            this.rbThink.Size = new System.Drawing.Size(200, 36);
            this.rbThink.TabIndex = 1;
            this.rbThink.TabStop = true;
            this.rbThink.Tag = "5";
            this.rbThink.Text = "Think Crust";
            this.rbThink.UseVisualStyleBackColor = true;
            this.rbThink.CheckedChanged += new System.EventHandler(this.rbThink_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Location = new System.Drawing.Point(18, 45);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(185, 36);
            this.rbThin.TabIndex = 0;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "Thin Crust";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // grpWheretoEat
            // 
            this.grpWheretoEat.BackColor = System.Drawing.Color.Transparent;
            this.grpWheretoEat.Controls.Add(this.rbEatOut);
            this.grpWheretoEat.Controls.Add(this.rbEatIn);
            this.grpWheretoEat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grpWheretoEat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpWheretoEat.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpWheretoEat.ForeColor = System.Drawing.Color.PeachPuff;
            this.grpWheretoEat.Location = new System.Drawing.Point(454, 630);
            this.grpWheretoEat.Name = "grpWheretoEat";
            this.grpWheretoEat.Size = new System.Drawing.Size(556, 118);
            this.grpWheretoEat.TabIndex = 6;
            this.grpWheretoEat.TabStop = false;
            this.grpWheretoEat.Text = "Where to Eat";
            // 
            // rbEatOut
            // 
            this.rbEatOut.AutoSize = true;
            this.rbEatOut.Location = new System.Drawing.Point(230, 45);
            this.rbEatOut.Name = "rbEatOut";
            this.rbEatOut.Size = new System.Drawing.Size(161, 36);
            this.rbEatOut.TabIndex = 1;
            this.rbEatOut.TabStop = true;
            this.rbEatOut.Text = "Take Out";
            this.rbEatOut.UseVisualStyleBackColor = true;
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(40, 45);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(120, 36);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            // 
            // grpToppings
            // 
            this.grpToppings.BackColor = System.Drawing.Color.Transparent;
            this.grpToppings.Controls.Add(this.cbPeppers);
            this.grpToppings.Controls.Add(this.cbOnion);
            this.grpToppings.Controls.Add(this.cbTomatoes);
            this.grpToppings.Controls.Add(this.cbOlives);
            this.grpToppings.Controls.Add(this.cbMushrooms);
            this.grpToppings.Controls.Add(this.cbExtraChees);
            this.grpToppings.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpToppings.ForeColor = System.Drawing.Color.PeachPuff;
            this.grpToppings.Location = new System.Drawing.Point(473, 307);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(552, 242);
            this.grpToppings.TabIndex = 7;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // cbPeppers
            // 
            this.cbPeppers.AutoSize = true;
            this.cbPeppers.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPeppers.Location = new System.Drawing.Point(291, 161);
            this.cbPeppers.Name = "cbPeppers";
            this.cbPeppers.Size = new System.Drawing.Size(241, 36);
            this.cbPeppers.TabIndex = 6;
            this.cbPeppers.Tag = "2";
            this.cbPeppers.Text = "Green Peppers";
            this.cbPeppers.UseVisualStyleBackColor = true;
            this.cbPeppers.CheckedChanged += new System.EventHandler(this.cbPeppers_CheckedChanged);
            // 
            // cbOnion
            // 
            this.cbOnion.AutoSize = true;
            this.cbOnion.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOnion.Location = new System.Drawing.Point(291, 49);
            this.cbOnion.Name = "cbOnion";
            this.cbOnion.Size = new System.Drawing.Size(126, 36);
            this.cbOnion.TabIndex = 5;
            this.cbOnion.Tag = "1";
            this.cbOnion.Text = "Onion";
            this.cbOnion.UseVisualStyleBackColor = true;
            this.cbOnion.CheckedChanged += new System.EventHandler(this.cbOnion_CheckedChanged);
            // 
            // cbTomatoes
            // 
            this.cbTomatoes.AutoSize = true;
            this.cbTomatoes.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTomatoes.Location = new System.Drawing.Point(21, 161);
            this.cbTomatoes.Name = "cbTomatoes";
            this.cbTomatoes.Size = new System.Drawing.Size(176, 36);
            this.cbTomatoes.TabIndex = 3;
            this.cbTomatoes.Tag = "2";
            this.cbTomatoes.Text = "Tomatoes";
            this.cbTomatoes.UseVisualStyleBackColor = true;
            this.cbTomatoes.CheckedChanged += new System.EventHandler(this.cbTomatoes_CheckedChanged);
            // 
            // cbOlives
            // 
            this.cbOlives.AutoSize = true;
            this.cbOlives.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOlives.Location = new System.Drawing.Point(291, 105);
            this.cbOlives.Name = "cbOlives";
            this.cbOlives.Size = new System.Drawing.Size(128, 36);
            this.cbOlives.TabIndex = 2;
            this.cbOlives.Tag = "2";
            this.cbOlives.Text = "Olives";
            this.cbOlives.UseVisualStyleBackColor = true;
            this.cbOlives.CheckedChanged += new System.EventHandler(this.cbOlives_CheckedChanged);
            // 
            // cbMushrooms
            // 
            this.cbMushrooms.AutoSize = true;
            this.cbMushrooms.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMushrooms.Location = new System.Drawing.Point(21, 106);
            this.cbMushrooms.Name = "cbMushrooms";
            this.cbMushrooms.Size = new System.Drawing.Size(202, 36);
            this.cbMushrooms.TabIndex = 1;
            this.cbMushrooms.Tag = "3";
            this.cbMushrooms.Text = "Mushrooms";
            this.cbMushrooms.UseVisualStyleBackColor = true;
            this.cbMushrooms.CheckedChanged += new System.EventHandler(this.cbMushrooms_CheckedChanged);
            // 
            // cbExtraChees
            // 
            this.cbExtraChees.AutoSize = true;
            this.cbExtraChees.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExtraChees.Location = new System.Drawing.Point(21, 51);
            this.cbExtraChees.Name = "cbExtraChees";
            this.cbExtraChees.Size = new System.Drawing.Size(204, 36);
            this.cbExtraChees.TabIndex = 0;
            this.cbExtraChees.Tag = "3";
            this.cbExtraChees.Text = "Extra Chees";
            this.cbExtraChees.UseVisualStyleBackColor = true;
            this.cbExtraChees.CheckedChanged += new System.EventHandler(this.cbExtraChees_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.IndianRed;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnOrder.Location = new System.Drawing.Point(464, 941);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(234, 74);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnReset.Location = new System.Drawing.Point(764, 941);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(234, 74);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpOrderSummary
            // 
            this.grpOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.grpOrderSummary.Controls.Add(this.lblToppings);
            this.grpOrderSummary.Controls.Add(this.lblWheretoEat);
            this.grpOrderSummary.Controls.Add(this.label5);
            this.grpOrderSummary.Controls.Add(this.lblCrust);
            this.grpOrderSummary.Controls.Add(this.label4);
            this.grpOrderSummary.Controls.Add(this.label3);
            this.grpOrderSummary.Controls.Add(this.lblPrice);
            this.grpOrderSummary.Controls.Add(this.label2);
            this.grpOrderSummary.Controls.Add(this.lblSize);
            this.grpOrderSummary.Controls.Add(this.Summary);
            this.grpOrderSummary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderSummary.ForeColor = System.Drawing.Color.PeachPuff;
            this.grpOrderSummary.Location = new System.Drawing.Point(1086, 307);
            this.grpOrderSummary.Name = "grpOrderSummary";
            this.grpOrderSummary.Size = new System.Drawing.Size(299, 708);
            this.grpOrderSummary.TabIndex = 10;
            this.grpOrderSummary.TabStop = false;
            this.grpOrderSummary.Text = "Order Summary";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(20, 221);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(208, 37);
            this.lblToppings.TabIndex = 9;
            this.lblToppings.Text = "No Toppings";
            // 
            // lblWheretoEat
            // 
            this.lblWheretoEat.AutoSize = true;
            this.lblWheretoEat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWheretoEat.Location = new System.Drawing.Point(224, 409);
            this.lblWheretoEat.Name = "lblWheretoEat";
            this.lblWheretoEat.Size = new System.Drawing.Size(44, 37);
            this.lblWheretoEat.TabIndex = 8;
            this.lblWheretoEat.Text = "In";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-4, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "Where To Eat :";
            // 
            // lblCrust
            // 
            this.lblCrust.AutoSize = true;
            this.lblCrust.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrust.Location = new System.Drawing.Point(185, 323);
            this.lblCrust.Name = "lblCrust";
            this.lblCrust.Size = new System.Drawing.Size(98, 37);
            this.lblCrust.TabIndex = 6;
            this.lblCrust.Text = " Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-7, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Crust Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-4, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Price :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblPrice.Location = new System.Drawing.Point(-9, 558);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(266, 51);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Total Price :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Toppings :";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(113, 93);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(82, 37);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Size";
            // 
            // Summary
            // 
            this.Summary.AutoSize = true;
            this.Summary.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Summary.Location = new System.Drawing.Point(-4, 93);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(101, 37);
            this.Summary.TabIndex = 0;
            this.Summary.Text = "Size :";
            // 
            // Frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1433, 1147);
            this.Controls.Add(this.grpOrderSummary);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpWheretoEat);
            this.Controls.Add(this.grpCrust);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm2";
            this.Text = "Form2";
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpCrust.ResumeLayout(false);
            this.grpCrust.PerformLayout();
            this.grpWheretoEat.ResumeLayout(false);
            this.grpWheretoEat.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpOrderSummary.ResumeLayout(false);
            this.grpOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedum;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox grpCrust;
        private System.Windows.Forms.RadioButton rbThink;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.GroupBox grpWheretoEat;
        private System.Windows.Forms.RadioButton rbEatOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox cbOnion;
        private System.Windows.Forms.CheckBox cbTomatoes;
        private System.Windows.Forms.CheckBox cbOlives;
        private System.Windows.Forms.CheckBox cbMushrooms;
        private System.Windows.Forms.CheckBox cbExtraChees;
        private System.Windows.Forms.CheckBox cbPeppers;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpOrderSummary;
        private System.Windows.Forms.Label Summary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCrust;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWheretoEat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblToppings;
    }
}