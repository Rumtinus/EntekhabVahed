namespace Entekhab_Vahed
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            cmbmajor = new ComboBox();
            cmblesson = new ComboBox();
            btnback2 = new Button();
            btnsave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 56);
            label1.Name = "label1";
            label1.Size = new Size(182, 20);
            label1.TabIndex = 0;
            label1.Text = "Please choose your major:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 56);
            label2.Name = "label2";
            label2.Size = new Size(183, 20);
            label2.TabIndex = 1;
            label2.Text = "Please choose your lesson:";
            // 
            // cmbmajor
            // 
            cmbmajor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbmajor.FormattingEnabled = true;
            cmbmajor.Items.AddRange(new object[] { "AI", "Architecture", "Chemical Engineering", "Computer Engineering", "Mechanical Engineering", "Math Engineering", "System Engineering" });
            cmbmajor.Location = new Point(35, 91);
            cmbmajor.Name = "cmbmajor";
            cmbmajor.Size = new Size(187, 28);
            cmbmajor.TabIndex = 2;
            // 
            // cmblesson
            // 
            cmblesson.DropDownStyle = ComboBoxStyle.DropDownList;
            cmblesson.FormattingEnabled = true;
            cmblesson.Items.AddRange(new object[] { "Electric Circut", "Logical CirCut", "Physic", "Math", "Data Base", "Topography" });
            cmblesson.Location = new Point(273, 91);
            cmblesson.Name = "cmblesson";
            cmblesson.Size = new Size(183, 28);
            cmblesson.TabIndex = 3;
            // 
            // btnback2
            // 
            btnback2.Location = new Point(381, 202);
            btnback2.Name = "btnback2";
            btnback2.Size = new Size(75, 35);
            btnback2.TabIndex = 4;
            btnback2.Text = "Back";
            btnback2.UseVisualStyleBackColor = true;
            btnback2.Click += btnback2_Click;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(147, 202);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(75, 35);
            btnsave.TabIndex = 5;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(509, 267);
            Controls.Add(btnsave);
            Controls.Add(btnback2);
            Controls.Add(cmblesson);
            Controls.Add(cmbmajor);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            KeyDown += Form3_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbmajor;
        private ComboBox cmblesson;
        private Button btnback2;
        private Button btnsave;
    }
}