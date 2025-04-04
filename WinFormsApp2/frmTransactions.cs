using DocumentFormat.OpenXml.Office.Word;
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

namespace WinFormsApp2
{
    public partial class Transactions : Form
    {
        string connStr = "Data Source=LAPTOP-JL31KL2H\\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True";
        public Transactions()
        {
            InitializeComponent();
            LoadBrands();
            SubscribeToEvents();
            comboBoxBrand.SelectedIndex = -1;
        }
        private void SubscribeToEvents()
        {
            comboBoxBrand.SelectedIndexChanged += comboBoxBrand_SelectedIndexChanged;
            comboBoxModel.SelectedIndexChanged += comboBoxModel_SelectedIndexChanged;
            buttonReset.Click += buttonReset_Click;
            buttonAdd.Click += buttonAdd_Click;
            buttondelete.Click += buttondelete_Click;
            buttonupdate.Click += buttonupdate_Click;
        }
        private void LoadBrands()
        {
            try
            {
                comboBoxBrand.SelectedIndexChanged -= comboBoxBrand_SelectedIndexChanged;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT distinct Brand_Name, Brand_Id FROM Brand;";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        comboBoxBrand.DataSource = dt;
                        comboBoxBrand.DisplayMember = "Brand_Name";
                        comboBoxBrand.ValueMember = "Brand_Id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading brands: " + ex.Message);
            }
            finally
            {
                comboBoxBrand.SelectedIndexChanged += comboBoxBrand_SelectedIndexChanged;
            }
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBrand.SelectedIndex != -1 && comboBoxBrand.SelectedValue != null)
            {
                LoadModels(comboBoxBrand.SelectedValue.ToString());
            }
        }
        private void LoadModels(string Brand_Id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT Model_Name ,Model_Id FROM Model WHERE Brand_Id = @Brand_Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("Brand_Id", Brand_Id);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            cmd.Parameters.AddWithValue("Brand_Id", Brand_Id);
                            comboBoxModel.DataSource = dt;
                            comboBoxModel.DisplayMember = "Model_Name";
                            comboBoxModel.ValueMember = "Model_Id";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading models: " + ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddSerialNumber();
        }

        private void DeleteSerialNumber()
        {
            string serialNo = textBoxSno.Text.Trim();
            if (string.IsNullOrEmpty(serialNo))
            {
                MessageBox.Show("Please enter a serial number to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this serial number?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult != DialogResult.Yes) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "DELETE FROM SerialNo WHERE Serial_No = @SerialNo";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SerialNo", serialNo);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected > 0 ? "Serial number deleted successfully." : "Failed to delete serial number. It may not exist.");
                        textBoxSno.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting serial number: " + ex.Message);
            }
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            DeleteSerialNumber();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to exit?",
                                          "Confirm Exit",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close(); // Close the form
            }
        }
        private void ResetFields()
        {
            comboBoxBrand.SelectedIndex = -1;
            comboBoxModel.DataSource = null;
            comboBoxModel.SelectedIndex = -1;
            textBoxSno.Clear();
        }


        private void buttonupdate_Click(object sender, EventArgs e)
        {
            UpdateSerialNumber();
        }

        private void textBoxSno_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxModel.SelectedValue != null)
            {
                FetchTransactions();
            }
        }
        private void FetchTransactions()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string brandId = comboBoxBrand.SelectedValue?.ToString();
                    string modelId = comboBoxModel.SelectedValue?.ToString();

                    if (string.IsNullOrEmpty(brandId) || string.IsNullOrEmpty(modelId))
                        return;

                    string query = @"
                        SELECT 
                            t.Transaction_Id, 
                            b.Brand_Name, 
                            m.Model_Name, 
                            t.Transaction_Date, 
                            t.Quantity 
                        FROM 
                             dbo.Transactions t
                        JOIN 
                            dbo.Brand b ON t.Brand_Id = b.Brand_Id
                        JOIN 
                            dbo.Model m ON t.Model_Id = m.Model_Id
                        WHERE 
                            t.Brand_Id = @BrandId 
                            AND t.Model_Id = @ModelId;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BrandId", brandId);
                        cmd.Parameters.AddWithValue("@ModelId", modelId);

                        DataTable dt = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching transactions: " + ex.Message);
            }
        }

        private void AddSerialNumber()
        {
            string serialNo = textBoxSno.Text.Trim();
            if (string.IsNullOrEmpty(serialNo))
            {
                MessageBox.Show("Please enter a serial number.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "INSERT INTO SerialNo (Serial_No, Model_Id) VALUES (@SerialNo, @ModelId)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SerialNo", serialNo);
                        cmd.Parameters.AddWithValue("@ModelId", comboBoxModel.SelectedValue ?? DBNull.Value);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected > 0 ? "Serial number added successfully." : "Failed to add the serial number.");
                        textBoxSno.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding serial number: " + ex.Message);
            }
        }

        private void UpdateSerialNumber()
        {
            string newSerialNo = textBoxSno.Text.Trim();
            if (comboBoxModel.SelectedIndex == -1 || comboBoxModel.SelectedValue == null || string.IsNullOrEmpty(newSerialNo))
            {
                MessageBox.Show("Please select a model and enter a new serial number.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to update the serial number?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult != DialogResult.Yes) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string modelId = comboBoxModel.SelectedValue?.ToString();
                    string query = "UPDATE SerialNo SET Serial_No = @NewSerialNo WHERE Model_Id = @ModelId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewSerialNo", newSerialNo);
                        cmd.Parameters.AddWithValue("@ModelId", modelId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected > 0 ? "Serial number updated successfully." : "Failed to update serial number.");
                        textBoxSno.Clear();
                        FetchTransactions();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating serial number: " + ex.Message);
            }
        }
    }
}

