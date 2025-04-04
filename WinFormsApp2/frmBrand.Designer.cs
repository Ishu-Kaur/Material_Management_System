namespace WinFormsApp2
{
    partial class frmBrand
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            brandInput = new TextBox();
            dataGridView1 = new DataGridView();
            b1f = new Button();
            b3r = new Button();
            b2s = new Button();
            label1 = new Label();
            b4i = new Button();
            Bexit = new Button();
            Bdelete = new Button();
            groupBox1 = new GroupBox();
            buttonUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // brandInput
            // 
            brandInput.ForeColor = SystemColors.ControlText;
            brandInput.Location = new Point(20, 52);
            brandInput.Name = "brandInput";
            brandInput.Size = new Size(279, 23);
            brandInput.TabIndex = 1;
            brandInput.TextChanged += brandInput_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(257, 327);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // b1f
            // 
            b1f.BackColor = Color.SpringGreen;
            b1f.ForeColor = SystemColors.WindowText;
            b1f.Location = new Point(283, 124);
            b1f.Name = "b1f";
            b1f.Size = new Size(75, 23);
            b1f.TabIndex = 3;
            b1f.Text = "Fetch";
            b1f.UseVisualStyleBackColor = false;
            b1f.Click += b1f_Click;
            // 
            // b3r
            // 
            b3r.BackColor = Color.SpringGreen;
            b3r.Location = new Point(283, 341);
            b3r.Name = "b3r";
            b3r.Size = new Size(75, 23);
            b3r.TabIndex = 5;
            b3r.Text = "Reset";
            b3r.UseVisualStyleBackColor = false;
            b3r.Click += b3r_Click;
            // 
            // b2s
            // 
            b2s.BackColor = Color.SpringGreen;
            b2s.Location = new Point(283, 296);
            b2s.Name = "b2s";
            b2s.Size = new Size(75, 23);
            b2s.TabIndex = 6;
            b2s.Text = "Save";
            b2s.UseVisualStyleBackColor = false;
            b2s.Click += b2s_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(20, 19);
            label1.Name = "label1";
            label1.Size = new Size(158, 29);
            label1.TabIndex = 7;
            label1.Text = "Brand Master";
            label1.Click += label1_Click;
            // 
            // b4i
            // 
            b4i.BackColor = Color.SpringGreen;
            b4i.Location = new Point(283, 169);
            b4i.Name = "b4i";
            b4i.Size = new Size(75, 23);
            b4i.TabIndex = 8;
            b4i.Text = "Insert";
            b4i.UseVisualStyleBackColor = false;
            b4i.Click += b4i_Click;
            // 
            // Bexit
            // 
            Bexit.BackColor = Color.Red;
            Bexit.Location = new Point(283, 385);
            Bexit.Name = "Bexit";
            Bexit.Size = new Size(75, 23);
            Bexit.TabIndex = 9;
            Bexit.Text = "Exit";
            Bexit.UseVisualStyleBackColor = false;
            Bexit.Click += Bexit_Click;
            // 
            // Bdelete
            // 
            Bdelete.BackColor = Color.SpringGreen;
            Bdelete.Location = new Point(283, 251);
            Bdelete.Name = "Bdelete";
            Bdelete.Size = new Size(75, 23);
            Bdelete.TabIndex = 10;
            Bdelete.Text = "Delete";
            Bdelete.UseVisualStyleBackColor = false;
            Bdelete.Click += Bdelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(buttonUpdate);
            groupBox1.Controls.Add(Bdelete);
            groupBox1.Controls.Add(Bexit);
            groupBox1.Controls.Add(b4i);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(b2s);
            groupBox1.Controls.Add(b3r);
            groupBox1.Controls.Add(b1f);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(brandInput);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Brand";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.SpringGreen;
            buttonUpdate.Location = new Point(283, 208);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 11;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // frmBrand
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 450);
            Controls.Add(groupBox1);
            Name = "frmBrand";
            Text = "Brand";
            Load += Brand_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox brandInput;
        private DataGridView dataGridView1;
        private Button b1f;
        private Button b3r;
        private Button b2s;
        private Label label1;
        private Button b4i;
        private Button Bexit;
        private Button Bdelete;
        private GroupBox groupBox1;
        private Button buttonUpdate;
    }
}