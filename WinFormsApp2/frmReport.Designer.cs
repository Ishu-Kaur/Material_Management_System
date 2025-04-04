namespace WinFormsApp2
{
    partial class Report
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
            groupBox1 = new GroupBox();
            comboBoxSno = new ComboBox();
            label1 = new Label();
            dataGridView = new DataGridView();
            buttonExit = new Button();
            buttonExcel = new Button();
            buttonFetch = new Button();
            comboBoxModel = new ComboBox();
            comboBoxBrand = new ComboBox();
            labelSerial = new Label();
            labelModel = new Label();
            labelBrand = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(comboBoxSno);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Controls.Add(buttonExit);
            groupBox1.Controls.Add(buttonExcel);
            groupBox1.Controls.Add(buttonFetch);
            groupBox1.Controls.Add(comboBoxModel);
            groupBox1.Controls.Add(comboBoxBrand);
            groupBox1.Controls.Add(labelSerial);
            groupBox1.Controls.Add(labelModel);
            groupBox1.Controls.Add(labelBrand);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(601, 341);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Report";
            // 
            // comboBoxSno
            // 
            comboBoxSno.FormattingEnabled = true;
            comboBoxSno.Location = new Point(465, 55);
            comboBoxSno.Name = "comboBoxSno";
            comboBoxSno.Size = new Size(121, 23);
            comboBoxSno.TabIndex = 11;
            comboBoxSno.SelectedIndexChanged += comboBoxSno_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(0, 19);
            label1.Name = "label1";
            label1.Size = new Size(167, 29);
            label1.TabIndex = 10;
            label1.Text = "Master Report";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(15, 139);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(567, 181);
            dataGridView.TabIndex = 9;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Red;
            buttonExit.Location = new Point(396, 98);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 8;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonExcel
            // 
            buttonExcel.BackColor = Color.SpringGreen;
            buttonExcel.Location = new Point(234, 98);
            buttonExcel.Name = "buttonExcel";
            buttonExcel.Size = new Size(104, 23);
            buttonExcel.TabIndex = 7;
            buttonExcel.Text = "Express in Excel";
            buttonExcel.UseVisualStyleBackColor = false;
            buttonExcel.Click += buttonExcel_Click;
            // 
            // buttonFetch
            // 
            buttonFetch.BackColor = Color.SpringGreen;
            buttonFetch.Location = new Point(111, 98);
            buttonFetch.Name = "buttonFetch";
            buttonFetch.Size = new Size(75, 23);
            buttonFetch.TabIndex = 6;
            buttonFetch.Text = "Fetch";
            buttonFetch.UseVisualStyleBackColor = false;
            buttonFetch.Click += buttonFetch_Click;
            // 
            // comboBoxModel
            // 
            comboBoxModel.FormattingEnabled = true;
            comboBoxModel.Location = new Point(255, 55);
            comboBoxModel.Name = "comboBoxModel";
            comboBoxModel.Size = new Size(121, 23);
            comboBoxModel.TabIndex = 4;
            comboBoxModel.SelectedIndexChanged += comboBoxModel_SelectedIndexChanged_1;
            // 
            // comboBoxBrand
            // 
            comboBoxBrand.FormattingEnabled = true;
            comboBoxBrand.Location = new Point(65, 55);
            comboBoxBrand.Name = "comboBoxBrand";
            comboBoxBrand.Size = new Size(121, 23);
            comboBoxBrand.TabIndex = 3;
            comboBoxBrand.SelectedIndexChanged += comboBoxBrand_SelectedIndexChanged;
            // 
            // labelSerial
            // 
            labelSerial.AutoSize = true;
            labelSerial.Location = new Point(396, 60);
            labelSerial.Name = "labelSerial";
            labelSerial.Size = new Size(63, 15);
            labelSerial.TabIndex = 2;
            labelSerial.Text = "Serial No. :";
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Location = new Point(202, 60);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(47, 15);
            labelModel.TabIndex = 1;
            labelModel.Text = "Model :";
            // 
            // labelBrand
            // 
            labelBrand.AutoSize = true;
            labelBrand.Location = new Point(15, 58);
            labelBrand.Name = "labelBrand";
            labelBrand.Size = new Size(44, 15);
            labelBrand.TabIndex = 0;
            labelBrand.Text = "Brand :";
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 370);
            Controls.Add(groupBox1);
            Name = "Report";
            Text = "Report";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelSerial;
        private Label labelModel;
        private Label labelBrand;
        private ComboBox comboBoxModel;
        private ComboBox comboBoxBrand;
        private Button buttonExcel;
        private Button buttonFetch;
        private Label label1;
        private DataGridView dataGridView;
        private Button buttonExit;
        private ComboBox comboBoxSno;
    }
}