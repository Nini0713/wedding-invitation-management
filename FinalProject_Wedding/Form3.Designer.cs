namespace FinalProject_Wedding
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            tbxFName = new TextBox();
            label2 = new Label();
            tbxLName = new TextBox();
            label3 = new Label();
            tbxPNumber = new TextBox();
            tbxEmail = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnSubmit = new Button();
            form3BindingSource = new BindingSource(components);
            lbxTable = new ListBox();
            ((System.ComponentModel.ISupportInitialize)form3BindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(63, 48);
            label1.Name = "label1";
            label1.Size = new Size(151, 28);
            label1.TabIndex = 0;
            label1.Text = "* FIRST NAME";
            // 
            // tbxFName
            // 
            tbxFName.BackColor = Color.Lavender;
            tbxFName.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxFName.ForeColor = SystemColors.ActiveCaptionText;
            tbxFName.Location = new Point(86, 77);
            tbxFName.Name = "tbxFName";
            tbxFName.Size = new Size(257, 34);
            tbxFName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(430, 48);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 2;
            label2.Text = "* LAST NAME";
            // 
            // tbxLName
            // 
            tbxLName.BackColor = Color.Lavender;
            tbxLName.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxLName.ForeColor = Color.Black;
            tbxLName.Location = new Point(453, 77);
            tbxLName.Name = "tbxLName";
            tbxLName.Size = new Size(257, 34);
            tbxLName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(67, 137);
            label3.Name = "label3";
            label3.Size = new Size(195, 28);
            label3.TabIndex = 4;
            label3.Text = "* PHONE NUMBER";
            // 
            // tbxPNumber
            // 
            tbxPNumber.BackColor = Color.Lavender;
            tbxPNumber.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxPNumber.ForeColor = SystemColors.ActiveCaptionText;
            tbxPNumber.Location = new Point(86, 166);
            tbxPNumber.Name = "tbxPNumber";
            tbxPNumber.Size = new Size(257, 34);
            tbxPNumber.TabIndex = 5;
            // 
            // tbxEmail
            // 
            tbxEmail.BackColor = Color.Lavender;
            tbxEmail.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxEmail.ForeColor = Color.Black;
            tbxEmail.Location = new Point(86, 261);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(257, 34);
            tbxEmail.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(67, 232);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 7;
            label4.Text = "* EMAIL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(434, 137);
            label5.Name = "label5";
            label5.Size = new Size(186, 28);
            label5.TabIndex = 9;
            label5.Text = "* TABLE NUMBER";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.HotPink;
            btnSubmit.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.Black;
            btnSubmit.Location = new Point(343, 344);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(111, 45);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // form3BindingSource
            // 
            form3BindingSource.DataSource = typeof(Form3);
            // 
            // lbxTable
            // 
            lbxTable.BackColor = Color.Lavender;
            lbxTable.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbxTable.FormattingEnabled = true;
            lbxTable.ItemHeight = 23;
            lbxTable.Location = new Point(453, 166);
            lbxTable.Name = "lbxTable";
            lbxTable.Size = new Size(150, 119);
            lbxTable.TabIndex = 12;
            lbxTable.SelectedIndexChanged += lbxTable_SelectedIndexChanged_1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lbxTable);
            Controls.Add(btnSubmit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbxEmail);
            Controls.Add(tbxPNumber);
            Controls.Add(label3);
            Controls.Add(tbxLName);
            Controls.Add(label2);
            Controls.Add(tbxFName);
            Controls.Add(label1);
            Name = "Form3";
            Text = "RESERVE";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)form3BindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxFName;
        private Label label2;
        private TextBox tbxLName;
        private Label label3;
        private TextBox tbxPNumber;
        private TextBox tbxEmail;
        private Label label4;
        private Label label5;
        private Button btnSubmit;
        private BindingSource form3BindingSource;
        private ListBox lbxTable;
    }
}