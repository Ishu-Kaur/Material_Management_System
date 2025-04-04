namespace WinFormsApp2
{
    partial class frmModel
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
            buttondelete = new Button();
            labelBrandName = new Label();
            comboBox1 = new ComboBox();
            textBoxModelId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            b5exit = new Button();
            b4reset = new Button();
            b3update = new Button();
            b2add = new Button();
            textBoxModelName = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(buttondelete);
            groupBox1.Controls.Add(labelBrandName);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBoxModelId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(b5exit);
            groupBox1.Controls.Add(b4reset);
            groupBox1.Controls.Add(b3update);
            groupBox1.Controls.Add(b2add);
            groupBox1.Controls.Add(textBoxModelName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(362, 193);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Model";
            // 
            // buttondelete
            // 
            buttondelete.BackColor = Color.SpringGreen;
            buttondelete.Location = new Point(271, 96);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(75, 23);
            buttondelete.TabIndex = 16;
            buttondelete.Text = "Delete";
            buttondelete.UseVisualStyleBackColor = false;
            buttondelete.Click += buttondelete_Click;
            // 
            // labelBrandName
            // 
            labelBrandName.AutoSize = true;
            labelBrandName.Location = new Point(6, 67);
            labelBrandName.Name = "labelBrandName";
            labelBrandName.Size = new Size(44, 15);
            labelBrandName.TabIndex = 13;
            labelBrandName.Text = "Brand :";
            labelBrandName.Click += label5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(98, 59);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBoxModelId
            // 
            textBoxModelId.Location = new Point(98, 107);
            textBoxModelId.Name = "textBoxModelId";
            textBoxModelId.Size = new Size(100, 23);
            textBoxModelId.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 107);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 9;
            label3.Text = "Model Code :";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 153);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 8;
            label2.Text = "Model Name";
            label2.Click += label2_Click;
            // 
            // b5exit
            // 
            b5exit.BackColor = Color.Red;
            b5exit.Location = new Point(271, 154);
            b5exit.Name = "b5exit";
            b5exit.Size = new Size(75, 23);
            b5exit.TabIndex = 7;
            b5exit.Text = "Exit";
            b5exit.UseVisualStyleBackColor = false;
            b5exit.Click += b5exit_Click;
            // 
            // b4reset
            // 
            b4reset.BackColor = Color.SpringGreen;
            b4reset.Location = new Point(271, 125);
            b4reset.Name = "b4reset";
            b4reset.Size = new Size(75, 23);
            b4reset.TabIndex = 6;
            b4reset.Text = "Reset";
            b4reset.UseVisualStyleBackColor = false;
            b4reset.Click += b4reset_Click;
            // 
            // b3update
            // 
            b3update.BackColor = Color.SpringGreen;
            b3update.Location = new Point(271, 38);
            b3update.Name = "b3update";
            b3update.Size = new Size(75, 23);
            b3update.TabIndex = 5;
            b3update.Text = "Update";
            b3update.UseVisualStyleBackColor = false;
            b3update.Click += b3update_Click;
            // 
            // b2add
            // 
            b2add.BackColor = Color.SpringGreen;
            b2add.Location = new Point(271, 67);
            b2add.Name = "b2add";
            b2add.Size = new Size(75, 23);
            b2add.TabIndex = 4;
            b2add.Text = "Add";
            b2add.UseVisualStyleBackColor = false;
            b2add.Click += b2add_Click;
            // 
            // textBoxModelName
            // 
            textBoxModelName.Location = new Point(98, 153);
            textBoxModelName.Name = "textBoxModelName";
            textBoxModelName.Size = new Size(98, 23);
            textBoxModelName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(159, 29);
            label1.TabIndex = 0;
            label1.Text = "Master Model";
            // 
            // frmModel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 217);
            Controls.Add(groupBox1);
            Name = "frmModel";
            Text = "Model";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBoxModelName;
        private Button b5exit;
        private Button b4reset;
        private Button b3update;
        private Button b2add;
        private TextBox textBoxModelId;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private Label labelBrandName;
        private Button buttondelete;
    }
}