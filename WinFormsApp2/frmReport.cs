using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace WinFormsApp2
{
    public partial class Report : Form
    {
        private string connStr = "Data Source=LAPTOP-JL31KL2H\\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True";
        public Report()
        {
            InitializeComponent();
            LoadBrands();

            comboBoxBrand.SelectedIndexChanged += comboBoxBrand_SelectedIndexChanged;
            comboBoxModel.SelectedIndexChanged += comboBoxModel_SelectedIndexChanged_1;
            comboBoxSno.SelectedIndexChanged += comboBoxSno_SelectedIndexChanged;

            // Reset selections and clear data grid
            comboBoxSno.DataSource = null;
            comboBoxModel.SelectedIndex = -1;
            dataGridView.DataSource = null;

        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files|*.xlsx";
                sfd.Title = "Save Excel File";
                sfd.FileName = "Report.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add("Report");

                        // Adding headers
                        for (int i = 0; i < dataGridView.Columns.Count; i++)
                        {
                            ws.Cell(1, i + 1).Value = dataGridView.Columns[i].HeaderText;
                        }

                        // Adding data
                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView.Columns.Count; j++)
                            {
                                ws.Cell(i + 2, j + 1).Value = dataGridView.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        wb.SaveAs(sfd.FileName);
                        MessageBox.Show("Data exported successfully!");

                        var result = MessageBox.Show("Do you want to open the Excel file?",
                                                    "Open File?",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            // Open the file
                            Process.Start(new ProcessStartInfo
                            {
                                FileName = sfd.FileName,
                                UseShellExecute = true // Important for opening files with their associated application
                            });
                        }
                    }
                }
            }
        }
        private void LoadBrands()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT Brand_Id, Brand_Name FROM Brand;";
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
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBrand.SelectedItem != null && comboBoxBrand.SelectedValue is int brandId)
            {
                LoadModels(brandId.ToString());
            }
            else
            {
                comboBoxModel.DataSource = null;
                comboBoxSno.DataSource = null;
            }
        }

        private void LoadModels(string brandId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT Model_Id, Model_Name FROM Model WHERE Brand_Id = @BrandId;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BrandId", brandId);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            comboBoxModel.DataSource = dt;
                            comboBoxModel.DisplayMember = "Model_Name";
                            comboBoxModel.ValueMember = "Model_Id";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading models: " + ex.Message);
            }
        }
        private void LoadSerialNumbers(string modelId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT Serial_No FROM SerialNo WHERE Model_Id = @ModelId;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ModelId", modelId);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            comboBoxSno.DataSource = dt;
                            comboBoxSno.DisplayMember = "Serial_No"; // Assuming Serial_No is a column in SerialNo table
                            comboBoxSno.ValueMember = "Serial_No";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading serial numbers: " + ex.Message);
            }
        }

        private void FetchData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string brandId = comboBoxBrand.SelectedValue.ToString();
                    string modelId = comboBoxModel.SelectedValue.ToString();


                    string query = @"
                        SELECT 
                            b.Brand_Name, 
                            m.Model_Name, 
                            s.Serial_No 
                        FROM 
                            Brand b
                        JOIN 
                            Model m ON b.Brand_Id = m.Brand_Id
                        JOIN 
                            SerialNo s ON m.Model_Id = s.Model_Id
                        WHERE 
                            b.Brand_Id = @BrandId 
                            AND m.Model_Id = @ModelId;";




                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BrandId", brandId);
                        cmd.Parameters.AddWithValue("@ModelId", modelId);

                        DataTable dt = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                            dataGridView.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching data: " + ex.Message);
            }
        }

        private void comboBoxModel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBoxSno.DataSource = null; // Clear previous serial numbers
            if (comboBoxModel.SelectedItem != null && comboBoxModel.SelectedValue is int modelId)
            {
                LoadSerialNumbers(modelId.ToString());
            }
        }

        private void buttonFetch_Click(object sender, EventArgs e)
        {
            FetchData();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxSno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxModel.SelectedValue is string modelId)
            {
                LoadSerial(modelId);
            }
            else
            {
                comboBoxSno.DataSource = null; // Clear if no model is selected
            }
        }
        private void LoadSerial(string modelId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT Serial_No FROM SerialNo WHERE Model_Id = @ModelId;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ModelId", modelId);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                comboBoxSno.DataSource = dt;
                                comboBoxSno.DisplayMember = "Serial_No"; // Assuming Serial_No is a column in SerialNo table
                                comboBoxSno.ValueMember = "Serial_No";
                            }
                            else
                            {
                                comboBoxSno.DataSource = null; // Clear if no data
                                MessageBox.Show("No serial numbers found for the selected model.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading serial numbers: " + ex.Message);
            }
        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
