using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaData
{
    public partial class AddPizza : Form
    {
        public AddPizza()
        {
            InitializeComponent();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            pizza pizza = new pizza();
            pizza.Toppings = new List<pizza.toppingType>();


            if (radSmall.Checked)
                pizza.Size = pizza.sizeType.SMALL;
            else if (radMedium.Checked)
                pizza.Size = pizza.sizeType.MEDUM;
            else if (radLarge.Checked)
                pizza.Size = pizza.sizeType.LARGE;
            if (radThin.Checked)
                pizza.Crust = pizza.crustType.THIN;
            else if (radHandTossed.Checked)
                pizza.Crust = pizza.crustType.HANDTOSSED;
            else if (radPan.Checked)
                pizza.Crust = pizza.crustType.PAN;
            if (chkSauce.Checked)
                pizza.Toppings.Add(pizza.toppingType.SAUCE);
            if (chkCheese.Checked)
                pizza.Toppings.Add(pizza.toppingType.CHEESE);
            if (chkPepperoni.Checked)
                pizza.Toppings.Add(pizza.toppingType.PEPPERONI);
            if (chkSausage.Checked)
                pizza.Toppings.Add(pizza.toppingType.SAUSAGE);
            if (chkBacon.Checked)
                pizza.Toppings.Add(pizza.toppingType.BACON);
            if (chkBeef.Checked)
                pizza.Toppings.Add(pizza.toppingType.BEEF);
            if (chkChicken.Checked)
                pizza.Toppings.Add(pizza.toppingType.CHICKEN);
            if (chkOlive.Checked)
                pizza.Toppings.Add(pizza.toppingType.OLIVES);
            if (chkOnion.Checked)
                pizza.Toppings.Add(pizza.toppingType.ONIONS);
            if (chkGreenPepper.Checked)
                pizza.Toppings.Add(pizza.toppingType.GREENPEPPERS);
            if (chkSpinach.Checked)
                pizza.Toppings.Add(pizza.toppingType.SPINACH);

            
            //will call from frmMain to calculate pizza
            pizza.Calculate();
            frmMain.cart.Add(pizza);

            MessageBox.Show("Pizza has been added to cart.");

            //lstCart.Items.Add(pizza);
            listCart();

            //will call to reset form
            ResetForm();
        }

        private void listCart()
        {
            pizza pizza = new pizza();
            pizza.Toppings = new List<pizza.toppingType>();
            int num = 0;

            lstCart.Items.Clear();
            foreach (pizza P in frmMain.cart)
            {
                num++;
                lstCart.Items.Add(P);
            }
        }

        private void lstCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (pizza P in lstCart.SelectedItems)
            {
                lblSize.Text = P.Size.ToString();
                lblCrust.Text = P.Crust.ToString();
                lblCost.Text = P.Cost.ToString("C2");

                foreach (pizza.toppingType topping in P.Toppings)
                    lblToppings.Text += topping.ToString();
            }
        }

        private void ResetForm()
        {
            radSmall.Checked = true;
            radThin.Checked = true;
            chkSauce.Checked = true;
            chkCheese.Checked = true;
            chkPepperoni.Checked = false;
            chkSausage.Checked = false;
            chkBacon.Checked = false;
            chkBeef.Checked = false;
            chkChicken.Checked = false;
            chkOlive.Checked = false;
            chkOnion.Checked = false;
            chkGreenPepper.Checked = false;
            chkSpinach.Checked = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMain.cart.Clear();
            Close();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Checkout f2 = new Checkout();
            Close();
            f2.Show();
        }

        private void AddPizza_Load(object sender, EventArgs e)
        {
            label();

            radSmall.Checked = true;
            radThin.Checked = true;
            chkSauce.Checked = true;
            chkCheese.Checked = true;
            chkPepperoni.Checked = false;
            chkSausage.Checked = false;
            chkBacon.Checked = false;
            chkBeef.Checked = false;
            chkChicken.Checked = false;
            chkOlive.Checked = false;
            chkOnion.Checked = false;
            chkGreenPepper.Checked = false;
            chkSpinach.Checked = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstCart.Items.Remove(lstCart.SelectedItem);
        }
        private void label()
        {
            frmMain frm = new frmMain();

            lblCustomer.Text = frm.ToString();
        }
    }
}
