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

namespace FinalProject_Wedding
{
    public partial class Form4 : Form
    {
        private const int MaxPeoplePerTable = 10;
        public Form4()
        {
            InitializeComponent();
            FillListBox();
            LbxName.Visible = false;
            btnChoose.Visible = false;
        }
        void FillListBox()
        {
            string connect = @"Data Source=desktop-3qat1ur\sqlexpress;Initial Catalog=weddingInv;Integrated Security=True;Pooling=False;Encrypt=False";
            string query = "SELECT [TableNumber] FROM [TBL]";

            using (SqlConnection conn = new SqlConnection(connect))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    SqlDataReader myReader = cmd.ExecuteReader();

                    while (myReader.Read())
                    {
                        if (!myReader.IsDBNull(0))
                        {
                            string tableNumber = myReader["TableNumber"].ToString();
                            cbxTable.Items.Add(tableNumber);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int totalRecordsUpdated = 0;

                using (SqlConnection conn = new SqlConnection(@"Data Source=desktop-3qat1ur\sqlexpress;Initial Catalog=weddingInv;Integrated Security=True;Pooling=False;Encrypt=False"))
                {
                    conn.Open();
                    foreach (DataGridViewRow row in dgvUpdateList.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string firstName = row.Cells["FirstName"].Value?.ToString();
                            string lastName = row.Cells["LastName"].Value?.ToString();
                            string phoneNumber = row.Cells["PhoneNumber"].Value?.ToString();
                            string email = row.Cells["Email"].Value?.ToString();
                            string tableNumber = row.Cells["TableNumber"].Value?.ToString();

                            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) &&
                                !string.IsNullOrEmpty(phoneNumber) && !string.IsNullOrEmpty(email) &&
                                !string.IsNullOrEmpty(tableNumber))
                            {
                                // Check if the table number has changed
                                string previousTableNumber = GetPreviousTableNumber(firstName, lastName);
                                bool tableNumberChanged = !string.Equals(tableNumber, previousTableNumber);

                                if (tableNumberChanged)
                                {
                                    // Check if the new table has reached its maximum capacity
                                    int currentTableCount = GetTableCount(tableNumber);
                                    if (currentTableCount >= MaxPeoplePerTable)
                                    {
                                        MessageBox.Show("The selected table is full. Please choose another table.");
                                        return;
                                    }
                                }
                                else
                                {
                                    // If the table number remains the same, no need to check the maximum capacity
                                    totalRecordsUpdated += UpdateInvitee(firstName, lastName, phoneNumber, email, tableNumber, conn);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please fill in all fields for each row.");
                                return; // Exit the method if any row is incomplete
                            }
                        }
                    }
                }

                MessageBox.Show("Total " + totalRecordsUpdated + " records updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating records: " + ex.Message);
            }

            // Clear the text boxes after adding the data
            LblFName.ResetText();
            LblLName.ResetText();
            tbxPNumber.Clear();
            tbxEmail.Clear();
            tbxSFName.Clear();
            dgvUpdateList.Rows.Clear();
            LbxName.Visible = false;
            btnChoose.Visible = false;
        }

        private string GetPreviousTableNumber(string firstName, string lastName)
        {
            string connect = @"Data Source=desktop-3qat1ur\sqlexpress;Initial Catalog=weddingInv;Integrated Security=True;Pooling=False;Encrypt=False";
            string query = "SELECT [TableNumber] FROM [INVITEES] WHERE [FirstName] = @FirstName AND [LastName] = @LastName";

            using (SqlConnection conn = new SqlConnection(connect))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result == null ? null : result.ToString();
            }
        }

        private int GetTableCount(string tableNumber)
        {
            string connect = @"Data Source=desktop-3qat1ur\sqlexpress;Initial Catalog=weddingInv;Integrated Security=True;Pooling=False;Encrypt=False";
            string query = "SELECT COUNT(*) FROM [INVITEES] WHERE [TableNumber] = @TableNumber";

            using (SqlConnection conn = new SqlConnection(connect))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TableNumber", tableNumber);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        private int UpdateInvitee(string firstName, string lastName, string phoneNumber, string email, string tableNumber, SqlConnection conn)
        {
            string query = @"UPDATE [INVITEES] 
                     SET [PhoneNumber] = @PhoneNumber, 
                         [Email] = @Email, 
                         [TableNumber] = @TableNumber 
                     WHERE [FirstName] = @FirstName AND [LastName] = @LastName";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@TableNumber", tableNumber);

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0 ? 1 : 0;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                    LbxName.Items.Clear(); // Clear previous search results

                    if (!string.IsNullOrEmpty(name))
                    {
                        // If searching by name, display results in labels
                        if (reader.Read())
                        {
                            LblFName.Text = reader["FirstName"].ToString();
                            LblLName.Text = reader["LastName"].ToString();
                            tbxPNumber.Text = reader["PhoneNumber"].ToString();
                            tbxEmail.Text = reader["Email"].ToString();
                            cbxTable.Text = reader["TableNumber"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No records found with the provided name.");
                        }
                    }
                    else
                    {
                        // If searching by table number, display results in list box
                        while (reader.Read())
                        {
                            string fullName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                            LbxName.Items.Add(fullName);
                        }

                        // Show the list of names and the choose button
                        LbxName.Visible = true;
                        btnChoose.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving records: " + ex.Message);
                }
            }
        }



        private void LbxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbxName.SelectedIndex != -1) // Check if an item is selected
            {
                string selectedName = LbxName.SelectedItem.ToString();

                // Retrieve details of the selected name and display in respective textboxes and labels
                string[] nameParts = selectedName.Split(' ');
                string firstName = nameParts[0];
                string lastName = nameParts[1];

                string query = "SELECT * FROM [INVITEES] WHERE [FirstName] = @FirstName AND [LastName] = @LastName";

                using (SqlConnection conn = new SqlConnection(@"Data Source=desktop-3qat1ur\sqlexpress;Initial Catalog=weddingInv;Integrated Security=True;Pooling=False;Encrypt=False"))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            LblFName.Text = reader["FirstName"].ToString();
                            LblLName.Text = reader["LastName"].ToString();
                            tbxPNumber.Text = reader["PhoneNumber"].ToString();
                            tbxEmail.Text = reader["Email"].ToString();
                            cbxTable.Text = reader["TableNumber"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving record: " + ex.Message);
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxSFName.Clear();
            tbxSTable.Clear();
            tbxPNumber.Clear();
            tbxEmail.Clear();
            LblLName.ResetText();
            LblFName.ResetText();
            LbxName.Visible = false;
            btnChoose.Visible = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(LblFName.Text) || string.IsNullOrWhiteSpace(LblLName.Text) ||
                    string.IsNullOrWhiteSpace(tbxPNumber.Text) || string.IsNullOrWhiteSpace(tbxEmail.Text) ||
                    string.IsNullOrWhiteSpace(cbxTable.Text))
                {
                    MessageBox.Show("Please fill in all the fields.");
                    return;
                }

                bool tableNumberChanged = true;
                // Check if the table number has changed
                string previousTableNumber = GetPreviousTableNumber(LblFName.Text, LblLName.Text);
                if (!string.IsNullOrEmpty(previousTableNumber))
                {
                    tableNumberChanged = !string.Equals(cbxTable.Text, previousTableNumber);
                }

                if (tableNumberChanged)
                {
                    // Check if the selected table has less than 10 people
                    int currentTableCount = GetTableCount(cbxTable.Text);
                    if (currentTableCount >= MaxPeoplePerTable)
                    {
                        MessageBox.Show("The selected table is full. Please choose another table.");
                        return;
                    }
                }

                // Check if the name already exists in the DataGridView
                foreach (DataGridViewRow row in dgvUpdateList.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string existingFirstName = row.Cells["FirstName"].Value?.ToString();
                        string existingLastName = row.Cells["LastName"].Value?.ToString();

                        if (existingFirstName == LblFName.Text && existingLastName == LblLName.Text)
                        {
                            MessageBox.Show("The name already exists in the list. Please update the existing entry instead of adding a new one.");
                            return;
                        }
                    }
                }

                // Add the retrieved data to the DataGridView
                dgvUpdateList.Rows.Add(LblFName.Text, LblLName.Text, tbxPNumber.Text, tbxEmail.Text, cbxTable.Text);

                // Clear the text boxes after adding the data
                LblFName.ResetText();
                LblLName.ResetText();
                tbxPNumber.Clear();
                tbxEmail.Clear();
                tbxSFName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding row to DataGridView: " + ex.Message);
            }
        }





        private void dgvUpdateList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (LbxName.SelectedIndex != -1) // Check if an item is selected
            {
                string selectedName = LbxName.SelectedItem.ToString();

                // Retrieve details of the selected name and display in respective textboxes and labels
                string[] nameParts = selectedName.Split(' ');
                string firstName = nameParts[0];
                string lastName = nameParts[1];

                string query = "SELECT * FROM [INVITEES] WHERE [FirstName] = @FirstName AND [LastName] = @LastName";

                using (SqlConnection conn = new SqlConnection(@"Data Source=desktop-3qat1ur\sqlexpress;Initial Catalog=weddingInv;Integrated Security=True;Pooling=False;Encrypt=False"))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            LblFName.Text = reader["FirstName"].ToString();
                            LblLName.Text = reader["LastName"].ToString();
                            tbxPNumber.Text = reader["PhoneNumber"].ToString();
                            tbxEmail.Text = reader["Email"].ToString();
                            cbxTable.Text = reader["TableNumber"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving record: " + ex.Message);
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvUpdateList.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvUpdateList.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgvUpdateList.Rows.Remove(row);
                    }
                }
            }
            else
            {
                dgvUpdateList.Rows.Clear();
            }
        }
    }
}