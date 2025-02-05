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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            LbxName.Visible = false;
            btnChoose.Visible = false;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

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
                            LblPNumber.Text = reader["PhoneNumber"].ToString();
                            LblEmail.Text = reader["Email"].ToString();
                            LblTable.Text = reader["TableNumber"].ToString();
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
                    throw new Exception("Error retrieving records: " + ex.Message);
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
                            LblPNumber.Text = reader["PhoneNumber"].ToString();
                            LblEmail.Text = reader["Email"].ToString();
                            LblTable.Text = reader["TableNumber"].ToString();
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
            LblPNumber.ResetText();
            LblEmail.ResetText();
            LblLName.ResetText();
            LblFName.ResetText();
            LbxName.Visible = false;
            btnChoose.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(LblFName.Text) || string.IsNullOrWhiteSpace(LblLName.Text) ||
                    string.IsNullOrWhiteSpace(LblPNumber.Text) || string.IsNullOrWhiteSpace(LblEmail.Text) ||
                    string.IsNullOrWhiteSpace(LblTable.Text))
                {
                    MessageBox.Show("Search First To Add The Data");
                    return;
                }

                // Check if the name already exists in the DataGridView
                foreach (DataGridViewRow row in dgvDeleteList.Rows)
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
                dgvDeleteList.Rows.Add(LblFName.Text, LblLName.Text, LblPNumber.Text, LblEmail.Text, LblTable.Text);

                // Clear the text boxes after adding the data
                LblFName.ResetText();
                LblLName.ResetText();
                LblPNumber.ResetText();
                LblEmail.ResetText();
                LblTable.ResetText();
                tbxSFName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding row to DataGridView: " + ex.Message);
            }
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
                            LblPNumber.Text = reader["PhoneNumber"].ToString();
                            LblEmail.Text = reader["Email"].ToString();
                            LblTable.Text = reader["TableNumber"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving record: " + ex.Message);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> firstNamesToDelete = new List<string>();

                // Check if any rows are selected
                if (dgvDeleteList.SelectedRows.Count > 0)
                {
                    // Delete selected rows
                    foreach (DataGridViewRow row in dgvDeleteList.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            string firstName = row.Cells["FirstName"].Value.ToString();
                            firstNamesToDelete.Add(firstName);
                        }
                    }
                }
                else
                {
                    // Delete all rows
                    foreach (DataGridViewRow row in dgvDeleteList.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string firstName = row.Cells["FirstName"].Value.ToString();
                            firstNamesToDelete.Add(firstName);
                        }
                    }
                }

                if (firstNamesToDelete.Count > 0)
                {
                    string query = "DELETE FROM [INVITEES] WHERE [FirstName] IN (" +
                                   string.Join(",", firstNamesToDelete.Select(fn => $"@FirstName_{fn}")) + ")";

                    using (SqlConnection conn = new SqlConnection(@"Data Source=desktop-3qat1ur\sqlexpress;Initial Catalog=weddingInv;Integrated Security=True;Pooling=False;Encrypt=False"))
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand(query, conn);
                        foreach (string firstName in firstNamesToDelete)
                        {
                            cmd.Parameters.AddWithValue($"@FirstName_{firstName}", firstName);
                        }

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            foreach (string firstName in firstNamesToDelete)
                            {
                                foreach (DataGridViewRow row in dgvDeleteList.Rows.Cast<DataGridViewRow>().ToList())
                                {
                                    if (!row.IsNewRow && row.Cells["FirstName"].Value.ToString() == firstName)
                                    {
                                        dgvDeleteList.Rows.Remove(row);
                                        break;
                                    }
                                }
                            }
                            MessageBox.Show("Selected records deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No records found to delete.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No records selected for deletion.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting records: " + ex.Message);
            }

            LbxName.Visible = false;
            btnChoose.Visible = false;
            tbxSTable.Clear();
        }








        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvDeleteList.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDeleteList.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgvDeleteList.Rows.Remove(row);
                    }
                }
            }
            else
            {
                dgvDeleteList.Rows.Clear();
            }
        }
    }
}
