using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Drawing.Drawing2D;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp2
{
    public partial class frmBrand : Form
    {
        string connStr = "Data Source=LAPTOP-JL31KL2H\\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True";

        public frmBrand()
        {
            InitializeComponent();
            b2s.Click -= b2s_Click;
            b2s.Click += b2s_Click;

            buttonUpdate.Click -= buttonUpdate_Click;
            buttonUpdate.Click += buttonUpdate_Click;

            b4i.Click -= b4i_Click;
            b4i.Click += b4i_Click;

            brandInput.TextChanged -= brandInput_TextChanged;
            brandInput.TextChanged += brandInput_TextChanged;

            Bexit.Click -= Bexit_Click;
            Bexit.Click += Bexit_Click;

            buttonUpdate.Click -= buttonUpdate_Click;
            buttonUpdate.Click += buttonUpdate_Click;

        }
        private void brandInput_TextChanged(object sender, EventArgs e)
        {
            b2s.Enabled = !string.IsNullOrEmpty(brandInput.Text);
        }

        private void FetchBrand()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("Select * from Brand", conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void b1f_Click(object sender, EventArgs e)
        {
            if (b1f.Text == "Fetch")
            {
                FetchBrand();

            }
        }

        //INSERTION IN THE BRAND 
        private void LoadBrands()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT Brand_Name FROM Brand;";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading brands: {ex.Message}");
            }
        }

        private void CreateBrand()
        {
            string BName = brandInput.Text.Trim();
            if (!string.IsNullOrEmpty(BName))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        string checkQuery = "SELECT COUNT(*) FROM Brand WHERE Brand_Name = @Brand_Name;";
                        using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.Add("@Brand_Name", SqlDbType.NVarChar).Value = BName;
                            int count = (int)checkCmd.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show("Brand already exists!");
                                return;
                            }
                        }
                        string insertQuery = "INSERT INTO Brand(Brand_Name) VALUES (@Brand_Name);";
                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.Add("@Brand_Name", SqlDbType.NVarChar).Value = BName;
                            int result = insertCmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Brand inserted successfully");
                            }
                            else
                            {
                                MessageBox.Show("Failed to insert Brand.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Brand name can't be empty.");
            }
        }

        private void b2s_Click(object sender, EventArgs e)
        {
            Console.WriteLine("b2s_Click triggered");
            CreateBrand();
            FetchBrand();
            brandInput.Clear();
        }


        private void b4i_Click(object sender, EventArgs e)
        {
            Console.WriteLine("b4i_Click triggered");
            if (string.IsNullOrWhiteSpace(brandInput.Text))
            {
                MessageBox.Show("Please enter a brand name before inserting.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CreateBrand();
            FetchBrand();
        }


        public void UpdateBrand()
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var row = dataGridView1.SelectedRows[0];
                string BName = brandInput.Text;
                int BId = Convert.ToInt32(row.Cells["Brand_Id"].Value);
                try
                {
                    // Update query
                    string query = "UPDATE Brand SET Brand_Name = @Brand_Name WHERE Brand_Id = @Brand_Id";
                    using (SqlConnection conn = new SqlConnection(connStr))
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Brand_Name", BName);
                        cmd.Parameters.AddWithValue("@Brand_Id", BId);
                        conn.Open();
                        int result = cmd.ExecuteNonQuery(); // Execute update

                        if (result > 0)
                        {
                            MessageBox.Show("Brand updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update brand.");
                        }
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Brand already Exists");
                }
                brandInput.Clear(); // Clear the input field
                dataGridView1.ClearSelection(); // Deselect any selected rows in the grid
                buttonUpdate.Enabled = false; // Optionally, disable the update button to prevent confusion
            }
            else
            {
                MessageBox.Show("Please select a brand to update."); // Inform user if no brand is selected
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string brandName = row.Cells["Brand_Name"].Value.ToString();
                brandInput.Text = brandName;
                buttonUpdate.Enabled = true;
            }
        }

        private void b3r_Click(object sender, EventArgs e)
        {
            b2s.Text = "Save";
            brandInput.Clear();
            dataGridView1.ClearSelection();
            b2s.Enabled = false;
        }
        private void DeleteBrand(int brandId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string deleteQuery = "DELETE FROM Brand WHERE Brand_Id = @Brand_Id";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Brand_Id", brandId);
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Brand deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete Brand.");
                        }
                    }
                }
                FetchBrand();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bdelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var row = dataGridView1.SelectedRows[0];
                if (row.Cells["Brand_Id"].Value != null && int.TryParse(row.Cells["Brand_Id"].Value.ToString(), out int BId))
                {
                    var confirmResult = MessageBox.Show("Are you sure you want to delete this brand?",
                                                        "Confirm Delete",
                                                        MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        DeleteBrand(BId);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a brand to delete.");
                }
            }
            else
            {
                MessageBox.Show("Please select a brand to delete.");
            }
        }

        private void Bexit_Click(object sender, EventArgs e)
        {
                var confirmResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    this.Close();
                }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("buttonUpdate_Click triggered");
            if (string.IsNullOrWhiteSpace(brandInput.Text))
            {
                MessageBox.Show("Please enter a brand name before updating.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit after showing the message
            }

            UpdateBrand();
            FetchBrand();
            brandInput.Clear();
            buttonUpdate.Enabled = false;
        }

        private void Brand_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

