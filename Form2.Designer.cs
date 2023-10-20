namespace Entekhab_Vahed
{
    partial class Form2
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
            lblwelcome = new Label();
            cmbterm = new ComboBox();
            btnnext = new Button();
            btnback = new Button();
            lblwell = new Label();
            SuspendLayout();
            // 
            // lblwelcome
            // 
            lblwelcome.AutoSize = true;
            lblwelcome.Location = new Point(87, 81);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(177, 20);
            lblwelcome.TabIndex = 0;
            lblwelcome.Text = " Please choose your term:";
            // 
            // cmbterm
            // 
            cmbterm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbterm.FormattingEnabled = true;
            cmbterm.Items.AddRange(new object[] { "139801", "139802", "139803", "139901", "139902", "139903", "140001", "140002", "140003", "140101", "140102", "140103", "140201" });
            cmbterm.Location = new Point(275, 78);
            cmbterm.Name = "cmbterm";
            cmbterm.Size = new Size(121, 28);
            cmbterm.TabIndex = 1;
            // 
            // btnnext
            // 
            btnnext.Location = new Point(87, 136);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(80, 31);
            btnnext.TabIndex = 2;
            btnnext.Text = "Next";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // btnback
            // 
            btnback.Location = new Point(189, 136);
            btnback.Name = "btnback";
            btnback.Size = new Size(75, 31);
            btnback.TabIndex = 3;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // lblwell
            // 
            lblwell.AutoSize = true;
            lblwell.Location = new Point(45, 28);
            lblwell.Name = "lblwell";
            lblwell.Size = new Size(0, 20);
            lblwell.TabIndex = 4;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(494, 211);
            Controls.Add(lblwell);
            Controls.Add(btnback);
            Controls.Add(btnnext);
            Controls.Add(cmbterm);
            Controls.Add(lblwelcome);
            Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            KeyDown += Form2_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblwelcome;
        private ComboBox cmbterm;
        private Button btnnext;
        private Button btnback;
        private Label lblwell;
    }
}