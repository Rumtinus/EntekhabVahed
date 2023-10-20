namespace Entekhab_Vahed
{
    partial class Form4
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
            dataGridView1 = new DataGridView();
            lblresult = new Label();
            btnback3 = new Button();
            btnexit2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(175, 31);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(655, 201);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Location = new Point(26, 31);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(117, 20);
            lblresult.TabIndex = 1;
            lblresult.Text = "Here's the result:";
            // 
            // btnback3
            // 
            btnback3.Location = new Point(68, 97);
            btnback3.Name = "btnback3";
            btnback3.Size = new Size(75, 33);
            btnback3.TabIndex = 2;
            btnback3.Text = "Back";
            btnback3.UseVisualStyleBackColor = true;
            btnback3.Click += btnback3_Click;
            // 
            // btnexit2
            // 
            btnexit2.Location = new Point(68, 170);
            btnexit2.Name = "btnexit2";
            btnexit2.Size = new Size(75, 33);
            btnexit2.TabIndex = 3;
            btnexit2.Text = "E&xit";
            btnexit2.UseVisualStyleBackColor = true;
            btnexit2.Click += btnexit2_Click_1;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(864, 253);
            Controls.Add(btnexit2);
            Controls.Add(btnback3);
            Controls.Add(lblresult);
            Controls.Add(dataGridView1);
            Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblresult;
        private Button btnback3;
        private Button btnexit2;
    }
}