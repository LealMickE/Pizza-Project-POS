using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PizzaData
{
    
    public partial class AddNew : Form
    {
        private OleDbDataAdapter customerDataAdapter;
        private OleDbConnection dbConnection;
        private OleDbCommand dbCommand;

        public AddNew()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMain f2 = new frmMain();
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string FirstName = txtFName.Text;
            string LastName = txtLName.Text;
            string Address1 = txtAddress1.Text;
            string Address2 = txtAddress2.Text;
            string City = txtCity.Text;
            string State = cboState.SelectedItem.ToString();
            string ZipCode = txtZip.Text;
            string Phone = txtPhone.Text;
            string Notes = txtNotes.Text;

            string InsertQuery = "INSERT INTO Customers(FirstName, LastName, Address1, Address2, City, State, ZipCode, Phone, Notes) " +
                "Values ('" + FirstName + "', '" + LastName + "', '" + Address1 + "', '" + Address2 + "', '" + City + "', '" + State + "', '" + ZipCode + "', '" + Phone + "', '" + Notes + "')";



            dbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=PizzaDB.accdb");
            dbConnection.Open();

            customerDataAdapter = new OleDbDataAdapter();
            customerDataAdapter.SelectCommand = dbCommand;

            customerDataAdapter = new OleDbDataAdapter();
            customerDataAdapter.InsertCommand = new OleDbCommand(InsertQuery, dbConnection);

            MessageBox.Show(InsertQuery);

           
            frmMain f2 = new frmMain();
            Close();
        }

        private void AddNew_Load(object sender, EventArgs e)
        {
            cboState.SelectedIndex = 42;
        }
    }
}
