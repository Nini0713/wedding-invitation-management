using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalProject_Wedding
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string name = tbxSFName.Text.Trim();
            string tableNumber = tbxSTable.Text.Trim();

            // Check if both name and table number are empty
            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(tableNumber))
            {
                MessageBox.Show("Please enter a name or table number to search.");
                return;
            }

            string query = "SELECT * FROM [INVITEES] WHERE ";

            // Add conditions for name search
            if (!string.IsNullOrEmpty(name))
            {
                query += "[FirstName] LIKE @FirstName OR [LastName] LIKE @LastName";
            }

            // Add conditions for table number search
            if (!string.IsNullOrEmpty(tableNumber))
            {
                if (!string.IsNullOrEmpty(name))
                {
                    query += " OR ";
                }
                query += "[TableNumber] = @TableNumber";
            }

            using (SqlConnection conn = new SqlConnection(@"Data Source=desktop-3qat1ur\sqlexpress;Initial Catalog=weddingInv;Integrated Security=True;Pooling=False;Encrypt=False"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameters for name search
                if (!string.IsNullOrEmpty(name))
                {
                    cmd.Parameters.AddWithValue("@FirstName", "%" + name + "%");
                    cmd.Parameters.AddWithValue("@LastName", "%" + name + "%");
                }

                // Add parameters for table number search
                if (!string.IsNullOrEmpty(tableNumber))
                {
                    cmd.Parameters.AddWithValue("@TableNumber", tableNumber);
                }

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dgvViewList.Rows.Clear(); // Clear previous search results

                    while (reader.Read())
                    {
                        string firstName = reader["FirstName"].ToString();
                        string lastName = reader["LastName"].ToString();
                        string phoneNumber = reader["PhoneNumber"].ToString();
                        string email = reader["Email"].ToString();
                        string table = reader["TableNumber"].ToString();

                        dgvViewList.Rows.Add(firstName, lastName, phoneNumber, email, table);
                    }

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("No records found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving records: " + ex.Message);
                }
            }
        }

        private void PopulateDataGridView(string tableNumber)
        {
            // Clear existing data in the DataGridView
            dgvViewList.Rows.Clear();

            string connect = @"Data Source=desktop-3qat1ur\sqlexpress;Initial Catalog=weddingInv;Integrated Security=True;Pooling=False;Encrypt=False";
            string query = "SELECT * FROM [INVITEES] WHERE [TableNumber] = @TableNumber";

            using (SqlConnection conn = new SqlConnection(connect))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TableNumber", tableNumber);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string firstName = reader["FirstName"].ToString();
                        string lastName = reader["LastName"].ToString();
                        string phoneNumber = reader["PhoneNumber"].ToString();
                        string email = reader["Email"].ToString();
                        string table = reader["TableNumber"].ToString();

                        dgvViewList.Rows.Add(firstName, lastName, phoneNumber, email, table);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving data: " + ex.Message);
                }
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            PopulateDataGridViewAll();
        }

        private void PopulateDataGridViewAll()
        {
            dgvViewList.Rows.Clear();

            string connect = @"Data Source=desktop-3qat1ur\sqlexpress;Initial Catalog=weddingInv;Integrated Security=True;Pooling=False;Encrypt=False";
            string query = "SELECT * FROM [INVITEES]";

            using (SqlConnection conn = new SqlConnection(connect))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string firstName = reader["FirstName"].ToString();
                        string lastName = reader["LastName"].ToString();
                        string phoneNumber = reader["PhoneNumber"].ToString();
                        string email = reader["Email"].ToString();
                        string table = reader["TableNumber"].ToString();

                        dgvViewList.Rows.Add(firstName, lastName, phoneNumber, email, table);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving data: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxSFName.Clear();
            tbxSTable.Clear();
            dgvViewList.Rows.Clear();
        }
    }
}