namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            Stb = new TextBox();
            Bcmb = new ComboBox();
            Mcmb = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Lavender;
            groupBox1.Controls.Add(Stb);
            groupBox1.Controls.Add(Bcmb);
            groupBox1.Controls.Add(Mcmb);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.MidnightBlue;
            groupBox1.Location = new Point(70, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(665, 384);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Box";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Stb
            // 
            Stb.Location = new Point(91, 162);
            Stb.Name = "Stb";
            Stb.Size = new Size(328, 23);
            Stb.TabIndex = 6;
            // 
            // Bcmb
            // 
            Bcmb.FormattingEnabled = true;
            Bcmb.Location = new Point(91, 97);
            Bcmb.Name = "Bcmb";
            Bcmb.Size = new Size(121, 23);
            Bcmb.TabIndex = 5;
            Bcmb.SelectedIndexChanged += Bcmb_SelectedIndexChanged;
            // 
            // Mcmb
            // 
            Mcmb.FormattingEnabled = true;
            Mcmb.Location = new Point(298, 97);
            Mcmb.Name = "Mcmb";
            Mcmb.Size = new Size(121, 23);
            Mcmb.TabIndex = 4;
            Mcmb.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(298, 70);
            label3.Name = "label3";
            label3.Size = new Size(66, 24);
            label3.TabIndex = 2;
            label3.Text = "Model";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(91, 135);
            label2.Name = "label2";
            label2.Size = new Size(97, 24);
            label2.TabIndex = 1;
            label2.Text = "Serial No.";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 70);
            label1.Name = "label1";
            label1.Size = new Size(66, 24);
            label1.TabIndex = 0;
            label1.Text = "Brand";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox Bcmb;
        private ComboBox Mcmb;
        private TextBox Stb;
    }
}
