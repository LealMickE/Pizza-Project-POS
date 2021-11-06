namespace PizzaData
{
    partial class Checkout
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.grpTotal = new System.Windows.Forms.GroupBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.grpCardInfo = new System.Windows.Forms.GroupBox();
            this.txtCRV = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtNameCard = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpPayInfo = new System.Windows.Forms.GroupBox();
            this.radCheck = new System.Windows.Forms.RadioButton();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.radCredit = new System.Windows.Forms.RadioButton();
            this.grpNotes = new System.Windows.Forms.GroupBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblCityStateZip = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpSummay = new System.Windows.Forms.GroupBox();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTotal.SuspendLayout();
            this.grpCardInfo.SuspendLayout();
            this.grpPayInfo.SuspendLayout();
            this.grpNotes.SuspendLayout();
            this.grpCustomerInfo.SuspendLayout();
            this.grpSummay.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(227, 448);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(496, 56);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancel Check Out";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.Lime;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(227, 386);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(496, 56);
            this.btnCheckout.TabIndex = 42;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // grpTotal
            // 
            this.grpTotal.Controls.Add(this.lblBalance);
            this.grpTotal.Controls.Add(this.label15);
            this.grpTotal.Controls.Add(this.label14);
            this.grpTotal.Controls.Add(this.lblTax);
            this.grpTotal.Controls.Add(this.label13);
            this.grpTotal.Controls.Add(this.label12);
            this.grpTotal.Controls.Add(this.lblDelivery);
            this.grpTotal.Controls.Add(this.lblSubtotal);
            this.grpTotal.Location = new System.Drawing.Point(502, 261);
            this.grpTotal.Name = "grpTotal";
            this.grpTotal.Size = new System.Drawing.Size(222, 119);
            this.grpTotal.TabIndex = 41;
            this.grpTotal.TabStop = false;
            this.grpTotal.Text = "Order Totals";
            // 
            // lblBalance
            // 
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBalance.Location = new System.Drawing.Point(123, 98);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(84, 17);
            this.lblBalance.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Balance:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Tax:";
            // 
            // lblTax
            // 
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTax.Location = new System.Drawing.Point(123, 70);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(84, 17);
            this.lblTax.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Delivery charge:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Subtotal:";
            // 
            // lblDelivery
            // 
            this.lblDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDelivery.Location = new System.Drawing.Point(123, 45);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(84, 17);
            this.lblDelivery.TabIndex = 6;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.Location = new System.Drawing.Point(123, 21);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(84, 17);
            this.lblSubtotal.TabIndex = 5;
            // 
            // grpCardInfo
            // 
            this.grpCardInfo.Controls.Add(this.txtCRV);
            this.grpCardInfo.Controls.Add(this.txtYear);
            this.grpCardInfo.Controls.Add(this.txtMonth);
            this.grpCardInfo.Controls.Add(this.txtCardNumber);
            this.grpCardInfo.Controls.Add(this.txtNameCard);
            this.grpCardInfo.Controls.Add(this.label11);
            this.grpCardInfo.Controls.Add(this.label10);
            this.grpCardInfo.Controls.Add(this.label9);
            this.grpCardInfo.Controls.Add(this.label8);
            this.grpCardInfo.Controls.Add(this.label7);
            this.grpCardInfo.Location = new System.Drawing.Point(227, 261);
            this.grpCardInfo.Name = "grpCardInfo";
            this.grpCardInfo.Size = new System.Drawing.Size(269, 119);
            this.grpCardInfo.TabIndex = 40;
            this.grpCardInfo.TabStop = false;
            this.grpCardInfo.Text = "Credit Card Info";
            // 
            // txtCRV
            // 
            this.txtCRV.Location = new System.Drawing.Point(90, 90);
            this.txtCRV.Name = "txtCRV";
            this.txtCRV.Size = new System.Drawing.Size(59, 20);
            this.txtCRV.TabIndex = 36;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(198, 65);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(65, 20);
            this.txtYear.TabIndex = 36;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(90, 66);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(43, 20);
            this.txtMonth.TabIndex = 35;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(90, 40);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(173, 20);
            this.txtCardNumber.TabIndex = 36;
            // 
            // txtNameCard
            // 
            this.txtNameCard.Location = new System.Drawing.Point(90, 15);
            this.txtNameCard.Name = "txtNameCard";
            this.txtNameCard.Size = new System.Drawing.Size(173, 20);
            this.txtNameCard.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(139, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Exp Year:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "CRV Code:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Exp Month:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "CC Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Name on Card:";
            // 
            // grpPayInfo
            // 
            this.grpPayInfo.Controls.Add(this.radCheck);
            this.grpPayInfo.Controls.Add(this.radCash);
            this.grpPayInfo.Controls.Add(this.radCredit);
            this.grpPayInfo.Location = new System.Drawing.Point(227, 190);
            this.grpPayInfo.Name = "grpPayInfo";
            this.grpPayInfo.Size = new System.Drawing.Size(497, 65);
            this.grpPayInfo.TabIndex = 39;
            this.grpPayInfo.TabStop = false;
            this.grpPayInfo.Text = "Payment Infomation";
            // 
            // radCheck
            // 
            this.radCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.radCheck.Location = new System.Drawing.Point(354, 19);
            this.radCheck.Name = "radCheck";
            this.radCheck.Size = new System.Drawing.Size(107, 33);
            this.radCheck.TabIndex = 2;
            this.radCheck.TabStop = true;
            this.radCheck.Text = "Check";
            this.radCheck.UseVisualStyleBackColor = true;
            // 
            // radCash
            // 
            this.radCash.Appearance = System.Windows.Forms.Appearance.Button;
            this.radCash.Location = new System.Drawing.Point(198, 19);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(107, 33);
            this.radCash.TabIndex = 1;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            // 
            // radCredit
            // 
            this.radCredit.Appearance = System.Windows.Forms.Appearance.Button;
            this.radCredit.Location = new System.Drawing.Point(42, 19);
            this.radCredit.Name = "radCredit";
            this.radCredit.Size = new System.Drawing.Size(107, 33);
            this.radCredit.TabIndex = 0;
            this.radCredit.TabStop = true;
            this.radCredit.Text = "Credit Card";
            this.radCredit.UseVisualStyleBackColor = true;
            // 
            // grpNotes
            // 
            this.grpNotes.Controls.Add(this.lblNotes);
            this.grpNotes.Location = new System.Drawing.Point(465, 58);
            this.grpNotes.Name = "grpNotes";
            this.grpNotes.Size = new System.Drawing.Size(259, 126);
            this.grpNotes.TabIndex = 38;
            this.grpNotes.TabStop = false;
            this.grpNotes.Text = "Notes";
            // 
            // lblNotes
            // 
            this.lblNotes.Location = new System.Drawing.Point(6, 19);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(247, 97);
            this.lblNotes.TabIndex = 1;
            // 
            // grpCustomerInfo
            // 
            this.grpCustomerInfo.Controls.Add(this.lblNumber);
            this.grpCustomerInfo.Controls.Add(this.lblCityStateZip);
            this.grpCustomerInfo.Controls.Add(this.lblAddress);
            this.grpCustomerInfo.Controls.Add(this.lblName);
            this.grpCustomerInfo.Location = new System.Drawing.Point(227, 58);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Size = new System.Drawing.Size(232, 126);
            this.grpCustomerInfo.TabIndex = 37;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Customer Infomation";
            // 
            // lblNumber
            // 
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumber.Location = new System.Drawing.Point(6, 103);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(220, 13);
            this.lblNumber.TabIndex = 3;
            // 
            // lblCityStateZip
            // 
            this.lblCityStateZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCityStateZip.Location = new System.Drawing.Point(6, 75);
            this.lblCityStateZip.Name = "lblCityStateZip";
            this.lblCityStateZip.Size = new System.Drawing.Size(220, 13);
            this.lblCityStateZip.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddress.Location = new System.Drawing.Point(6, 47);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(220, 13);
            this.lblAddress.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Location = new System.Drawing.Point(6, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(220, 15);
            this.lblName.TabIndex = 0;
            // 
            // grpSummay
            // 
            this.grpSummay.Controls.Add(this.lstCart);
            this.grpSummay.Location = new System.Drawing.Point(15, 58);
            this.grpSummay.Name = "grpSummay";
            this.grpSummay.Size = new System.Drawing.Size(206, 446);
            this.grpSummay.TabIndex = 36;
            this.grpSummay.TabStop = false;
            this.grpSummay.Text = "Order Summary";
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.Location = new System.Drawing.Point(6, 19);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(194, 420);
            this.lstCart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 55);
            this.label1.TabIndex = 35;
            this.label1.Text = "Micky\'s Pizza";
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 527);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.grpTotal);
            this.Controls.Add(this.grpCardInfo);
            this.Controls.Add(this.grpPayInfo);
            this.Controls.Add(this.grpNotes);
            this.Controls.Add(this.grpCustomerInfo);
            this.Controls.Add(this.grpSummay);
            this.Controls.Add(this.label1);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.grpTotal.ResumeLayout(false);
            this.grpTotal.PerformLayout();
            this.grpCardInfo.ResumeLayout(false);
            this.grpCardInfo.PerformLayout();
            this.grpPayInfo.ResumeLayout(false);
            this.grpNotes.ResumeLayout(false);
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpSummay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.GroupBox grpTotal;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.GroupBox grpCardInfo;
        private System.Windows.Forms.TextBox txtCRV;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtNameCard;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpPayInfo;
        private System.Windows.Forms.RadioButton radCheck;
        private System.Windows.Forms.RadioButton radCash;
        private System.Windows.Forms.RadioButton radCredit;
        private System.Windows.Forms.GroupBox grpNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.GroupBox grpCustomerInfo;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblCityStateZip;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpSummay;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Label label1;
    }
}