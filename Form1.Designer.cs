namespace Entekhab_Vahed
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtname = new TextBox();
            txtlastname = new TextBox();
            txtstdid = new TextBox();
            btnexit = new Button();
            btnenter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 102);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 5;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 167);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 6;
            label2.Text = "Lastname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 231);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 7;
            label3.Text = "Student ID:";
            // 
            // txtname
            // 
            txtname.Location = new Point(192, 99);
            txtname.Margin = new Padding(3, 4, 3, 4);
            txtname.Name = "txtname";
            txtname.Size = new Size(195, 27);
            txtname.TabIndex = 0;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(192, 164);
            txtlastname.Margin = new Padding(3, 4, 3, 4);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(195, 27);
            txtlastname.TabIndex = 1;
            // 
            // txtstdid
            // 
            txtstdid.Location = new Point(192, 228);
            txtstdid.Margin = new Padding(3, 4, 3, 4);
            txtstdid.Name = "txtstdid";
            txtstdid.Size = new Size(195, 27);
            txtstdid.TabIndex = 2;
            txtstdid.TextChanged += txtstdid_TextChanged;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.Snow;
            btnexit.Location = new Point(302, 291);
            btnexit.Margin = new Padding(3, 4, 3, 4);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(86, 45);
            btnexit.TabIndex = 4;
            btnexit.Text = "E&xit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // btnenter
            // 
            btnenter.Location = new Point(192, 291);
            btnenter.Margin = new Padding(3, 4, 3, 4);
            btnenter.Name = "btnenter";
            btnenter.Size = new Size(86, 45);
            btnenter.TabIndex = 3;
            btnenter.Text = "Enter";
            btnenter.UseVisualStyleBackColor = true;
            btnenter.Click += btnenter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(550, 431);
            Controls.Add(btnenter);
            Controls.Add(btnexit);
            Controls.Add(txtstdid);
            Controls.Add(txtlastname);
            Controls.Add(txtname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtname;
        private TextBox txtlastname;
        private TextBox txtstdid;
        private Button btnexit;
        private Button btnenter;
    }
}