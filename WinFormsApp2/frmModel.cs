using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class frmModel : Form
    {
        string connStr = "Data Source=LAPTOP-JL31KL2H\\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True";
        public frmModel()
        {
            InitializeComponent();
            LoadBrandData();
        }

        private void LoadBrandData()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT brand_id, brand_name FROM brand", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind DataTable to ComboBox
                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "brand_name";
                    comboBox1.ValueMember = "brand_id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading brands: " + ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void b2add_Click(object sender, EventArgs e)
        {
            AddModel();
        }

        private void b3update_Click(object sender, EventArgs e)
        {
            UpdateModel();
        }

        private void UpdateModel()
        {
            if (string.IsNullOrWhiteSpace(textBoxModelId.Text) || string.IsNullOrWhiteSpace(textBoxModelName.Text))
            {
                MessageBox.Show("Please enter both Model ID and Model Name to update the record.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connStr))
            {
                try
                {
                    con.Open();

                    // Define the update query with parameters
                    SqlCommand cmd = new SqlCommand("UPDATE model SET model_name = @model_name, brand_id = @brand_id WHERE model_id = @model_id", con);

                    // Add parameters with form values
                    cmd.Parameters.AddWithValue("@model_id", textBoxModelId.Text);
                    cmd.Parameters.AddWithValue("@model_name", textBoxModelName.Text);
                    cmd.Parameters.AddWithValue("@brand_id", comboBox1.SelectedValue);

                    // Execute the update command
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Show success or failure message based on result
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Model updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No records were updated. Please check the Model ID.");
                    }
                }
                catch (Exception ex)
                {
                    // Display any exceptions that occur during the update
                    MessageBox.Show("Error updating model: " + ex.Message);
                }
            }
        }


        private void UpdateModel(string brandId, string modelId, string modelName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "UPDATE Model SET Model_Name = @ModelName WHERE Brand_Id = @BrandId AND Model_Id = @ModelId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BrandId", brandId);
                        cmd.Parameters.AddWithValue("@ModelId", modelId);
                        cmd.Parameters.AddWithValue("@ModelName", modelName);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Model updated successfully.");

                        }
                        else
                        {
                            MessageBox.Show("No records were updated. Please check the Model Code.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the model: " + ex.Message);
            }
        }

        private void b5exit_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void b4reset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }
        private void ResetFields()
        {
            textBoxModelId.Clear();
            textBoxModelName.Clear();
            comboBox1.SelectedIndex = -1;
            textBoxModelId.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void AddModel()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO model (model_id, model_name, brand_id) VALUES (@model_id, @model_name, @brand_id)", con);
                    cmd.Parameters.AddWithValue("@model_id", textBoxModelId.Text);
                    cmd.Parameters.AddWithValue("@model_name", textBoxModelName.Text);
                    cmd.Parameters.AddWithValue("@brand_id", comboBox1.SelectedValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Model added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured: " + ex.Message);
                }
            }
        }

        private void SaveModel(string brandId, string modelId, string modelName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "INSERT INTO Model (Model_Id ,Brand_Id,  Model_Name) VALUES (@ModelId ,@BrandId, @ModelName)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Use parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@BrandId", brandId);
                        cmd.Parameters.AddWithValue("@ModelId", modelId);
                        cmd.Parameters.AddWithValue("@ModelName", modelName);

                        int rowsAffected = cmd.ExecuteNonQuery(); // Execute the insert command

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Model added successfully.");
                            // Optionally, you could refresh the model data display here
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the model.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the model: " + ex.Message);
            }
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            DeleteModel();
        }

        private void DeleteModel()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM model WHERE model_id=@model_id", con);
                    cmd.Parameters.AddWithValue("@model_id", textBoxModelId.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Model deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Model ID not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting model: " + ex.Message);
                }
            }
        }
        private void BindButtonEvents()
        {
            b3update.Click += b3update_Click;
            b2add.Click += b2add_Click;
            buttondelete.Click += buttondelete_Click;
            b4reset.Click += b4reset_Click;
            b5exit.Click += b5exit_Click;
        }
    }
}
