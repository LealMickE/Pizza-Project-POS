//Michael Leal
//Final Project
//ITSE 2353

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

//Incomplete...I tired!

namespace PizzaData
{
    public partial class frmMain : Form
    {
        private OleDbDataAdapter customerDataAdapter;
        private DataSet customerDataSet;
        private OleDbCommand dbCommand;
        private OleDbConnection dbConnection;

        public static List<pizza> cart = new List<pizza>();

        //public static customer Customer = new customer();
        //public static newPizza newPizza = new newPizza();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (radExisting.Checked)
            {
                AddPizza f2 = new AddPizza();
                f2.Show();
            }

            if (radNew.Checked)
            {
                AddNew f2 = new AddNew();
                f2.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizzaDBDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.pizzaDBDataSet.Customers);

            radExisting.Checked = true;

            try
            {   //set up connection object
                dbConnection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = PizzaDB.accdb");

                //create a dbCommand
                dbCommand = new OleDbCommand();
                //query to retrieve  entire customer table
                dbCommand.CommandText = "SELECT * FROM Customers ORDER BY LastName ASC;";

                //Tie the commands objects to the connection objects
                dbCommand.Connection = dbConnection;

                //Create a DataAdapter and set the select command
                customerDataAdapter = new OleDbDataAdapter();
                customerDataAdapter.SelectCommand = dbCommand;

                //Create and fill the data set
                customerDataSet = new DataSet();
                customerDataAdapter.Fill(customerDataSet, "Customers");

                ////Populate the data grid view using data from the data set
                dataGridView1.DataSource = customerDataSet;
                dataGridView1.DataMember = "Customers";

            }
            catch (Exception ex)
            {   
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (radSearchLast.Checked)
            {

                //query to retrieve lastname customer table
                dbCommand.CommandText = "SELECT * FROM Customers WHERE LastName = '" + txtSearch.Text + "';";

                //Tie the commands objects to the connection objects
                dbCommand.Connection = dbConnection;

                //Create a DataAdapter and set the select command
                customerDataAdapter = new OleDbDataAdapter();
                customerDataAdapter.SelectCommand = dbCommand;

                //Create and fill the data set
                customerDataSet = new DataSet();
                customerDataAdapter.Fill(customerDataSet, "Customers");

                ////Populate the data grid view using data from the data set
                dataGridView1.DataSource = customerDataSet;
                dataGridView1.DataMember = "Customers";
            }

            else if (radSearchPhone.Checked)
            {
                dbCommand.CommandText = "SELECT * FROM Customers WHERE Phone = '" + txtSearch.Text + "';";

                //Tie the commands objects to the connection objects
                dbCommand.Connection = dbConnection;

                //Create a DataAdapter and set the select command
                customerDataAdapter = new OleDbDataAdapter();
                customerDataAdapter.SelectCommand = dbCommand;

                //Create and fill the data set
                customerDataSet = new DataSet();
                customerDataAdapter.Fill(customerDataSet, "Customers");

                ////Populate the data grid view using data from the data set
                dataGridView1.DataSource = customerDataSet;
                dataGridView1.DataMember = "Customers";

            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radSearchPhone.Checked)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }

    public class pizza
    {
        

        public enum crustType { THIN, HANDTOSSED, PAN } //possible values for crust type
        public enum sizeType { SMALL, MEDUM, LARGE } //possible values for size
        public enum toppingType { SAUCE, CHEESE, PEPPERONI, SAUSAGE, BACON, BEEF, CHICKEN, OLIVES, ONIONS, GREENPEPPERS, SPINACH } //possible values for toppings

        public crustType Crust { get; set; } //Crust can only store one of the values in crustType
        public sizeType Size { get; set; } //Size can only store one of the values in sizeType
        public List<toppingType> Toppings { get; set; } //Toppings is a list that only stores values from toppingType
        public double Cost { get; set; } //stores the cost of the pizza

        //pizza class constructor
        public pizza()
        {
            Toppings = new List<toppingType>(); //initialize the Toppings list
        }


        public override string ToString()
        {
            string newToppings = string.Join(", ", Toppings);

            return Size + " / " + Crust +  " / " +  newToppings;
        }

    //this method calculates the cost of the pizza based on the values stored
    //in Size and Toppings.  You can modify this to calculate cost however you want.
    public void Calculate()
        {
            double total = 0;

            if (Size == sizeType.SMALL)
                total += 10.00;
            if (Size == sizeType.MEDUM)
                total += 12.00;
            if (Size == sizeType.LARGE)
                total += 14.00;

            if (Toppings.Count > 2)
                total += (Toppings.Count - 2) * 0.49;

            Cost = total;
        }
    }
}
