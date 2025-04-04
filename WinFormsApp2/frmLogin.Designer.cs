namespace WinFormsApp2
{
    partial class Login
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
            Button_reset = new Button();
            checkBox1 = new CheckBox();
            textBoxPass = new TextBox();
            textBoxUser = new TextBox();
            labelPass = new Label();
            labelUser = new Label();
            label1 = new Label();
            buttonExit = new Button();
            buttonLogin = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(Button_reset);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(textBoxPass);
            groupBox1.Controls.Add(textBoxUser);
            groupBox1.Controls.Add(labelPass);
            groupBox1.Controls.Add(labelUser);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonExit);
            groupBox1.Controls.Add(buttonLogin);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 227);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login ";
            // 
            // Button_reset
            // 
            Button_reset.BackColor = Color.SpringGreen;
            Button_reset.ForeColor = SystemColors.ActiveCaptionText;
            Button_reset.Location = new Point(181, 166);
            Button_reset.Name = "Button_reset";
            Button_reset.Size = new Size(75, 23);
            Button_reset.TabIndex = 8;
            Button_reset.Text = "Reset";
            Button_reset.UseVisualStyleBackColor = false;
            Button_reset.Click += Button_reset_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(381, 124);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 7;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(181, 120);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(183, 23);
            textBoxPass.TabIndex = 6;
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(181, 81);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(183, 23);
            textBoxUser.TabIndex = 5;
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPass.ForeColor = Color.GhostWhite;
            labelPass.Location = new Point(62, 120);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(91, 25);
            labelPass.TabIndex = 4;
            labelPass.Text = "Password";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUser.ForeColor = Color.GhostWhite;
            labelUser.Location = new Point(46, 81);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(110, 25);
            labelUser.TabIndex = 3;
            labelUser.Text = "User_Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(0, 19);
            label1.Name = "label1";
            label1.Size = new Size(153, 29);
            label1.TabIndex = 2;
            label1.Text = "Master Login";
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Red;
            buttonExit.ForeColor = Color.Black;
            buttonExit.Location = new Point(289, 166);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 1;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.SpringGreen;
            buttonLogin.ForeColor = Color.Black;
            buttonLogin.Location = new Point(62, 166);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 251);
            Controls.Add(groupBox1);
            Name = "Login";
            Text = "Login";
            Load += frmLogin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonExit;
        private Button buttonLogin;
        private Label label1;
        private TextBox textBoxPass;
        private TextBox textBoxUser;
        private Label labelPass;
        private Label labelUser;
        private CheckBox checkBox1;
        private Button Button_reset;
    }
}