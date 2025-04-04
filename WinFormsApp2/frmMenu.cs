using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class frmMenu : Form
    {
        string connStr = "Data Source=LAPTOP-JL31KL2H\\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True";
        public frmMenu()
        {
            InitializeComponent();
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmBrand brandForm = new frmBrand();
            brandForm.MdiParent = this;
            brandForm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmModel modelForm = new frmModel();
            modelForm.MdiParent = this;
            modelForm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Transactions transactionsForm = new Transactions();
            transactionsForm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to Log Out?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void reportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Report reportForm = new Report();
            reportForm.MdiParent = this;
            reportForm.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }

}
