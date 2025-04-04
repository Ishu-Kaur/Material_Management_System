namespace WinFormsApp2
{
    partial class Transactions
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
            gb1 = new GroupBox();
            buttonupdate = new Button();
            buttonExit = new Button();
            buttonReset = new Button();
            buttondelete = new Button();
            buttonAdd = new Button();
            textBoxSno = new TextBox();
            comboBoxModel = new ComboBox();
            comboBoxBrand = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gb1.SuspendLayout();
            SuspendLayout();
            // 
            // gb1
            // 
            gb1.BackColor = SystemColors.ActiveCaption;
            gb1.Controls.Add(buttonupdate);
            gb1.Controls.Add(buttonExit);
            gb1.Controls.Add(buttonReset);
            gb1.Controls.Add(buttondelete);
            gb1.Controls.Add(buttonAdd);
            gb1.Controls.Add(textBoxSno);
            gb1.Controls.Add(comboBoxModel);
            gb1.Controls.Add(comboBoxBrand);
            gb1.Controls.Add(label3);
            gb1.Controls.Add(label2);
            gb1.Controls.Add(label1);
            gb1.Location = new Point(12, 12);
            gb1.Name = "gb1";
            gb1.Size = new Size(367, 170);
            gb1.TabIndex = 0;
            gb1.TabStop = false;
            gb1.Text = "Transactions";
            // 
            // buttonupdate
            // 
            buttonupdate.BackColor = Color.SpringGreen;
            buttonupdate.Location = new Point(265, 79);
            buttonupdate.Name = "buttonupdate";
            buttonupdate.Size = new Size(75, 23);
            buttonupdate.TabIndex = 10;
            buttonupdate.Text = "Update";
            buttonupdate.UseVisualStyleBackColor = false;
            buttonupdate.Click += buttonupdate_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Red;
            buttonExit.Location = new Point(265, 141);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 9;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.SpringGreen;
            buttonReset.Location = new Point(265, 108);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(75, 23);
            buttonReset.TabIndex = 8;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttondelete
            // 
            buttondelete.BackColor = Color.SpringGreen;
            buttondelete.Location = new Point(265, 51);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(75, 23);
            buttondelete.TabIndex = 7;
            buttondelete.Text = "Delete";
            buttondelete.UseVisualStyleBackColor = false;
            buttondelete.Click += buttondelete_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.SpringGreen;
            buttonAdd.Location = new Point(265, 22);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxSno
            // 
            textBoxSno.Location = new Point(89, 116);
            textBoxSno.Name = "textBoxSno";
            textBoxSno.Size = new Size(100, 23);
            textBoxSno.TabIndex = 5;
            textBoxSno.TextChanged += textBoxSno_TextChanged;
            // 
            // comboBoxModel
            // 
            comboBoxModel.FormattingEnabled = true;
            comboBoxModel.Location = new Point(89, 70);
            comboBoxModel.Name = "comboBoxModel";
            comboBoxModel.Size = new Size(121, 23);
            comboBoxModel.TabIndex = 4;
            comboBoxModel.SelectedIndexChanged += comboBoxModel_SelectedIndexChanged;
            // 
            // comboBoxBrand
            // 
            comboBoxBrand.FormattingEnabled = true;
            comboBoxBrand.Location = new Point(89, 27);
            comboBoxBrand.Name = "comboBoxBrand";
            comboBoxBrand.Size = new Size(121, 23);
            comboBoxBrand.TabIndex = 3;
            comboBoxBrand.SelectedIndexChanged += comboBoxBrand_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 124);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Serial No. :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 78);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Model :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 35);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Brand :";
            // 
            // Transactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 197);
            Controls.Add(gb1);
            Name = "Transactions";
            Text = "Transactions";
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb1;
        private Button buttonExit;
        private Button buttonReset;
        private Button buttondelete;
        private Button buttonAdd;
        private TextBox textBoxSno;
        private ComboBox comboBoxModel;
        private ComboBox comboBoxBrand;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonupdate;
    }
}