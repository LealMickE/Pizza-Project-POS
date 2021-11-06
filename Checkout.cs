using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PizzaData
{
    public partial class Checkout : Form
    {

        public Checkout()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMain.cart.Clear();
            Close();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            PizzaCheckout();
        }

        class NegativeException : ApplicationException
        {
            public NegativeException(string message) : base(message)
            {

            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string name = txtNameCard.Text;
            string number = txtCardNumber.Text;
            string month = txtMonth.Text;
            string year = txtYear.Text;
            string code = txtCRV.Text;

            try
            {
                if (radCredit.Checked)
                {
                    if (name.Equals(""))
                        throw new NegativeException("Account NAME can not be empty!");
                    if (number.Equals(""))
                        throw new NegativeException("Account NUMBER can not be empty!");
                    if (month.Equals(""))
                        throw new NegativeException("Account MONTH can not be empty!");
                    if (year.Equals(""))
                        throw new NegativeException("Account YEAR can not be empty!");
                    if (code.Equals(""))
                        throw new NegativeException("Account CVV can not be empty!");
                    else
                        MessageBox.Show("Order received! Thank you for your purchase!");
                }
                else
                    MessageBox.Show("Order received!");

            }

            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void PizzaCheckout()
        {
            int num = 0;
            foreach (pizza p in frmMain.cart)
            {
                num++;         
                lstCart.Items.Add(("Pizza #" + num.ToString()));
                lstCart.Items.Add((p.Size.ToString() + " " + p.Crust.ToString()));
                lstCart.Items.Add("Toppings:");

                foreach (pizza.toppingType topping in p.Toppings)
                    lstCart.Items.Add(topping.ToString());
                lstCart.Items.Add(("Item cost: " + p.Cost.ToString("C2")));
                lstCart.Items.Add(" ");
            }

            double delivery = 5.0;
            double totalPizza = 0.0;


            //loops and counts pizza total 
            foreach (pizza pizza in frmMain.cart)
                totalPizza += pizza.Cost;

            double tax = 8.25;
            double totalOrder = (totalPizza * tax) / 100;


            //displays results on labels 
            lblSubtotal.Text = totalPizza.ToString("C2");
            lblDelivery.Text = delivery.ToString("C2");
            lblTax.Text = totalOrder.ToString("C2");
            lblBalance.Text = (totalPizza + totalOrder + delivery).ToString("C2");
        }       
    }
}
