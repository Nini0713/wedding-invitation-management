using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject_Wedding
{
    public partial class Form3 : Form
    {
        private const int MaxPeoplePerTable = 10;
        public Form3()
        {
            InitializeComponent();
            FillListBox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbxTable_SelectedIndexChanged_1(object sender, EventArgs e)
        {

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
                            lbxTable.Items.Add(tableNumber);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error inserting record: " + ex.Message);
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=desktop-3qat1ur\sqlexpress;Initial Catalog=weddingInv;Integrated Security=True;Pooling=False;Encrypt=False";
            string query = "INSERT INTO [INVITEES] VALUES (@FirstName, @LastName, @PhoneNumber, @Email, @TableNumber)";

            // Check if any of the required fields are empty
            if (string.IsNullOrWhiteSpace(tbxFName.Text) || string.IsNullOrWhiteSpace(tbxLName.Text) ||
                string.IsNullOrWhiteSpace(tbxPNumber.Text) || string.IsNullOrWhiteSpace(tbxEmail.Text) ||
                string.IsNullOrWhiteSpace(lbxTable.Text))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return; // Exit the method if any required field is empty
            }

            // Check if the selected table has less than 10 people
            int currentTableCount = GetTableCount(lbxTable.Text);
            if (currentTableCount >= MaxPeoplePerTable)
            {
                MessageBox.Show("The selected table is full. Please choose another table.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connect))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FirstName", tbxFName.Text);
                    cmd.Parameters.AddWithValue("@LastName", tbxLName.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", tbxPNumber.Text);
                    cmd.Parameters.AddWithValue("@Email", tbxEmail.Text);
                    cmd.Parameters.AddWithValue("@TableNumber", lbxTable.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("DATA HAS BEEN ADDED TO THE SYSTEM");
                }
                catch (Exception ex)
                {
                    throw new Exception("Error inserting record: " + ex.Message);
                }

                tbxFName.Clear();
                tbxLName.Clear();
                tbxPNumber.Clear();
                tbxEmail.Clear();
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
