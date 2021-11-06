namespace PizzaData
{
    partial class AddPizza
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpSubtotal = new System.Windows.Forms.GroupBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblCrust = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbCustomer = new System.Windows.Forms.GroupBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkSpinach = new System.Windows.Forms.CheckBox();
            this.chkGreenPepper = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkOlive = new System.Windows.Forms.CheckBox();
            this.chkChicken = new System.Windows.Forms.CheckBox();
            this.chkBeef = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.chkSauce = new System.Windows.Forms.CheckBox();
            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.radPan = new System.Windows.Forms.RadioButton();
            this.radHandTossed = new System.Windows.Forms.RadioButton();
            this.radThin = new System.Windows.Forms.RadioButton();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSubtotal.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.grbCustomer.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpCrust.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(297, 341);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(485, 44);
            this.btnRemove.TabIndex = 49;
            this.btnRemove.Text = "Remove Pizza";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(297, 498);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(485, 44);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Cancel Order";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.Lime;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(297, 448);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(485, 44);
            this.btnCheckout.TabIndex = 47;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(19, 477);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(256, 65);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "Add Pizza to Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpSubtotal
            // 
            this.grpSubtotal.Controls.Add(this.lblSubtotal);
            this.grpSubtotal.Location = new System.Drawing.Point(297, 391);
            this.grpSubtotal.Name = "grpSubtotal";
            this.grpSubtotal.Size = new System.Drawing.Size(485, 51);
            this.grpSubtotal.TabIndex = 45;
            this.grpSubtotal.TabStop = false;
            this.grpSubtotal.Text = "Subtotal";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(191, 16);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(111, 29);
            this.lblSubtotal.TabIndex = 5;
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.Location = new System.Drawing.Point(297, 121);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(485, 95);
            this.lstCart.TabIndex = 44;
            this.lstCart.SelectedIndexChanged += new System.EventHandler(this.lstCart_SelectedIndexChanged);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.lblCost);
            this.grpDetails.Controls.Add(this.lblToppings);
            this.grpDetails.Controls.Add(this.lblCrust);
            this.grpDetails.Controls.Add(this.lblSize);
            this.grpDetails.Controls.Add(this.label5);
            this.grpDetails.Controls.Add(this.label4);
            this.grpDetails.Controls.Add(this.label3);
            this.grpDetails.Controls.Add(this.label2);
            this.grpDetails.Location = new System.Drawing.Point(297, 226);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(485, 109);
            this.grpDetails.TabIndex = 43;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Pizza Detail";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(86, 78);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(0, 13);
            this.lblCost.TabIndex = 7;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(86, 60);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(0, 13);
            this.lblToppings.TabIndex = 6;
            // 
            // lblCrust
            // 
            this.lblCrust.AutoSize = true;
            this.lblCrust.Location = new System.Drawing.Point(86, 40);
            this.lblCrust.Name = "lblCrust";
            this.lblCrust.Size = new System.Drawing.Size(0, 13);
            this.lblCrust.TabIndex = 5;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(86, 20);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(0, 13);
            this.lblSize.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Toppings:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Crust:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size:";
            // 
            // grbCustomer
            // 
            this.grbCustomer.Controls.Add(this.lblCustomer);
            this.grbCustomer.Location = new System.Drawing.Point(19, 58);
            this.grbCustomer.Name = "grbCustomer";
            this.grbCustomer.Size = new System.Drawing.Size(763, 50);
            this.grbCustomer.TabIndex = 42;
            this.grbCustomer.TabStop = false;
            this.grbCustomer.Text = "Customer";
            // 
            // lblCustomer
            // 
            this.lblCustomer.Location = new System.Drawing.Point(6, 16);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(243, 23);
            this.lblCustomer.TabIndex = 0;
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.chkSpinach);
            this.grpToppings.Controls.Add(this.chkGreenPepper);
            this.grpToppings.Controls.Add(this.chkOnion);
            this.grpToppings.Controls.Add(this.chkOlive);
            this.grpToppings.Controls.Add(this.chkChicken);
            this.grpToppings.Controls.Add(this.chkBeef);
            this.grpToppings.Controls.Add(this.chkBacon);
            this.grpToppings.Controls.Add(this.chkSausage);
            this.grpToppings.Controls.Add(this.chkPepperoni);
            this.grpToppings.Controls.Add(this.chkCheese);
            this.grpToppings.Controls.Add(this.chkSauce);
            this.grpToppings.Location = new System.Drawing.Point(19, 226);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(256, 229);
            this.grpToppings.TabIndex = 41;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // chkSpinach
            // 
            this.chkSpinach.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSpinach.Location = new System.Drawing.Point(147, 139);
            this.chkSpinach.Name = "chkSpinach";
            this.chkSpinach.Size = new System.Drawing.Size(102, 30);
            this.chkSpinach.TabIndex = 10;
            this.chkSpinach.Text = "Spinach";
            this.chkSpinach.UseVisualStyleBackColor = true;
            // 
            // chkGreenPepper
            // 
            this.chkGreenPepper.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkGreenPepper.Location = new System.Drawing.Point(147, 109);
            this.chkGreenPepper.Name = "chkGreenPepper";
            this.chkGreenPepper.Size = new System.Drawing.Size(102, 30);
            this.chkGreenPepper.TabIndex = 9;
            this.chkGreenPepper.Text = "Green Pepper";
            this.chkGreenPepper.UseVisualStyleBackColor = true;
            // 
            // chkOnion
            // 
            this.chkOnion.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkOnion.Location = new System.Drawing.Point(147, 79);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(102, 30);
            this.chkOnion.TabIndex = 8;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            // 
            // chkOlive
            // 
            this.chkOlive.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkOlive.Location = new System.Drawing.Point(147, 49);
            this.chkOlive.Name = "chkOlive";
            this.chkOlive.Size = new System.Drawing.Size(102, 30);
            this.chkOlive.TabIndex = 7;
            this.chkOlive.Text = "Olive";
            this.chkOlive.UseVisualStyleBackColor = true;
            // 
            // chkChicken
            // 
            this.chkChicken.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkChicken.Location = new System.Drawing.Point(6, 169);
            this.chkChicken.Name = "chkChicken";
            this.chkChicken.Size = new System.Drawing.Size(102, 30);
            this.chkChicken.TabIndex = 6;
            this.chkChicken.Text = "Chicken";
            this.chkChicken.UseVisualStyleBackColor = true;
            // 
            // chkBeef
            // 
            this.chkBeef.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBeef.Location = new System.Drawing.Point(6, 139);
            this.chkBeef.Name = "chkBeef";
            this.chkBeef.Size = new System.Drawing.Size(102, 30);
            this.chkBeef.TabIndex = 5;
            this.chkBeef.Text = "Beef";
            this.chkBeef.UseVisualStyleBackColor = true;
            // 
            // chkBacon
            // 
            this.chkBacon.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBacon.Location = new System.Drawing.Point(6, 109);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(102, 30);
            this.chkBacon.TabIndex = 4;
            this.chkBacon.Text = "Bacon";
            this.chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkSausage
            // 
            this.chkSausage.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSausage.Location = new System.Drawing.Point(6, 79);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(102, 30);
            this.chkSausage.TabIndex = 3;
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPepperoni.Location = new System.Drawing.Point(6, 49);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(102, 30);
            this.chkPepperoni.TabIndex = 2;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            this.chkCheese.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCheese.Location = new System.Drawing.Point(147, 19);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(102, 30);
            this.chkCheese.TabIndex = 1;
            this.chkCheese.Text = "Cheese";
            this.chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkSauce
            // 
            this.chkSauce.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSauce.Location = new System.Drawing.Point(6, 19);
            this.chkSauce.Name = "chkSauce";
            this.chkSauce.Size = new System.Drawing.Size(102, 30);
            this.chkSauce.TabIndex = 0;
            this.chkSauce.Text = "Sauce";
            this.chkSauce.UseVisualStyleBackColor = true;
            // 
            // grpCrust
            // 
            this.grpCrust.Controls.Add(this.radPan);
            this.grpCrust.Controls.Add(this.radHandTossed);
            this.grpCrust.Controls.Add(this.radThin);
            this.grpCrust.Location = new System.Drawing.Point(150, 114);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Size = new System.Drawing.Size(125, 106);
            this.grpCrust.TabIndex = 40;
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "Crust";
            // 
            // radPan
            // 
            this.radPan.Appearance = System.Windows.Forms.Appearance.Button;
            this.radPan.Location = new System.Drawing.Point(6, 73);
            this.radPan.Name = "radPan";
            this.radPan.Size = new System.Drawing.Size(112, 27);
            this.radPan.TabIndex = 3;
            this.radPan.TabStop = true;
            this.radPan.Text = "Pan";
            this.radPan.UseVisualStyleBackColor = true;
            // 
            // radHandTossed
            // 
            this.radHandTossed.Appearance = System.Windows.Forms.Appearance.Button;
            this.radHandTossed.Location = new System.Drawing.Point(6, 46);
            this.radHandTossed.Name = "radHandTossed";
            this.radHandTossed.Size = new System.Drawing.Size(112, 27);
            this.radHandTossed.TabIndex = 2;
            this.radHandTossed.TabStop = true;
            this.radHandTossed.Text = "Hand Tossed";
            this.radHandTossed.UseVisualStyleBackColor = true;
            // 
            // radThin
            // 
            this.radThin.Appearance = System.Windows.Forms.Appearance.Button;
            this.radThin.Location = new System.Drawing.Point(6, 19);
            this.radThin.Name = "radThin";
            this.radThin.Size = new System.Drawing.Size(112, 27);
            this.radThin.TabIndex = 1;
            this.radThin.TabStop = true;
            this.radThin.Text = "Thin";
            this.radThin.UseVisualStyleBackColor = true;
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.radLarge);
            this.grpSize.Controls.Add(this.radMedium);
            this.grpSize.Controls.Add(this.radSmall);
            this.grpSize.Location = new System.Drawing.Point(19, 114);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(125, 106);
            this.grpSize.TabIndex = 39;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // radLarge
            // 
            this.radLarge.Appearance = System.Windows.Forms.Appearance.Button;
            this.radLarge.Location = new System.Drawing.Point(6, 73);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(113, 27);
            this.radLarge.TabIndex = 2;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "Large";
            this.radLarge.UseVisualStyleBackColor = true;
            // 
            // radMedium
            // 
            this.radMedium.Appearance = System.Windows.Forms.Appearance.Button;
            this.radMedium.Location = new System.Drawing.Point(6, 46);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(113, 27);
            this.radMedium.TabIndex = 1;
            this.radMedium.TabStop = true;
            this.radMedium.Text = "Medium";
            this.radMedium.UseVisualStyleBackColor = true;
            // 
            // radSmall
            // 
            this.radSmall.Appearance = System.Windows.Forms.Appearance.Button;
            this.radSmall.Location = new System.Drawing.Point(6, 19);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(113, 27);
            this.radSmall.TabIndex = 0;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "Small";
            this.radSmall.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 55);
            this.label1.TabIndex = 38;
            this.label1.Text = "Micky\'s Pizza";
            // 
            // AddPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 569);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpSubtotal);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grbCustomer);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpCrust);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.label1);
            this.Name = "AddPizza";
            this.Text = "AddPizza";
            this.Load += new System.EventHandler(this.AddPizza_Load);
            this.grpSubtotal.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grbCustomer.ResumeLayout(false);
            this.grpToppings.ResumeLayout(false);
            this.grpCrust.ResumeLayout(false);
            this.grpSize.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblCrust;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox chkSpinach;
        private System.Windows.Forms.CheckBox chkGreenPepper;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkOlive;
        private System.Windows.Forms.CheckBox chkChicken;
        private System.Windows.Forms.CheckBox chkBeef;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.CheckBox chkSauce;
        private System.Windows.Forms.GroupBox grpCrust;
        private System.Windows.Forms.RadioButton radPan;
        private System.Windows.Forms.RadioButton radHandTossed;
        private System.Windows.Forms.RadioButton radThin;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.Label label1;
    }
}