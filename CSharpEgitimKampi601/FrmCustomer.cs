using CSharpEgitimKampi601.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }
        string connectionString = "Server=;;Database=;user Id=postgres;Password;";

        void GetAllCustomers()
        {
            var connection=new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Customers ";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataTable.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            GetAllCustomers();
        }
        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string customerCity = txtCustomerCity.Text;
            string customerSurname = txtCustomerSurname.Text;
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Insert into Customers(CustomerName,CustomeerSurname,CustomerCity) values (@customerName,@customerSurname,@customerCity)";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerName", customerName);
            command.Parameters.AddWithValue("@customerSurname", customerSurname);
            command.Parameters.AddWithValue("@customerCity", customerCity);
            command.ExecuteNonQuery();
            MessageBox.Show("Ekleme işlemi tamamlandı");
            connection.Close(); 
            GetAllCustomers();
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCustomerId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "delete from Customers where CustomerId=@customerId";
            var command= new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@txtCustomerId", id);
            command.ExecuteNonQuery();
            MessageBox.Show("Silme işlemi başarılı");
            connection.Close();
            GetAllCustomers();
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string customerSurname = txtCustomerSurname.Text;
            string customerCity = txtCustomerCity.Text;
            int id=int.Parse(txtCustomerId.Text);
            var connection = new NpgsqlConnection( connectionString);
            connection.Open();
            string query = "Update Customers Set CustomerName=@customerName,CustomerSurname=@customerSurname,CustomerCity=@customerCity where CustomerId=@customerId";
             var command=new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("customerName", customerName);
            command.Parameters.AddWithValue("customerSurname", customerSurname);
            command.Parameters.AddWithValue("customerCity", customerCity);
            command.Parameters.AddWithValue("customerId", id);
            command.ExecuteNonQuery();
            MessageBox.Show("Güncelleme işlemi başarılı");
            connection.Close();
            GetAllCustomers();
        }
    }
}
