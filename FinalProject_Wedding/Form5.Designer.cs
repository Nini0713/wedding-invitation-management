namespace FinalProject_Wedding
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            btnRemove = new Button();
            btnChoose = new Button();
            LbxName = new ListBox();
            LblLName = new Label();
            LblFName = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnAdd = new Button();
            label2 = new Label();
            tbxSTable = new TextBox();
            tbxSFName = new TextBox();
            dgvDeleteList = new DataGridView();
            FirstName = new DataGridViewButtonColumn();
            LastName = new DataGridViewButtonColumn();
            PhoneNumber = new DataGridViewButtonColumn();
            Email = new DataGridViewButtonColumn();
            TableNumber = new DataGridViewButtonColumn();
            btnSearch = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            label5 = new Label();
            label1 = new Label();
            LblPNumber = new Label();
            LblEmail = new Label();
            LblTable = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDeleteList).BeginInit();
            SuspendLayout();
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.HotPink;
            btnRemove.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.Black;
            btnRemove.Location = new Point(1012, 444);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(111, 45);
            btnRemove.TabIndex = 82;
            btnRemove.Text = "REMOVE";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnChoose
            // 
            btnChoose.BackColor = Color.HotPink;
            btnChoose.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnChoose.ForeColor = Color.Black;
            btnChoose.Location = new Point(705, 148);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(111, 45);
            btnChoose.TabIndex = 81;
            btnChoose.Text = "CHOOSE";
            btnChoose.UseVisualStyleBackColor = false;
            btnChoose.Click += btnChoose_Click;
            // 
            // LbxName
            // 
            LbxName.BackColor = Color.Lavender;
            LbxName.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbxName.FormattingEnabled = true;
            LbxName.Location = new Point(687, 17);
            LbxName.Name = "LbxName";
            LbxName.Size = new Size(150, 124);
            LbxName.TabIndex = 80;
            // 
            // LblLName
            // 
            LblLName.BackColor = Color.Lavender;
            LblLName.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblLName.Location = new Point(315, 189);
            LblLName.Name = "LblLName";
            LblLName.Size = new Size(223, 28);
            LblLName.TabIndex = 79;
            // 
            // LblFName
            // 
            LblFName.BackColor = Color.Lavender;
            LblFName.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFName.Location = new Point(40, 189);
            LblFName.Name = "LblFName";
            LblFName.Size = new Size(223, 28);
            LblFName.TabIndex = 78;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(296, 244);
            label3.Name = "label3";
            label3.Size = new Size(186, 28);
            label3.TabIndex = 76;
            label3.Text = "* TABLE NUMBER";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(21, 341);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 75;
            label4.Text = "* EMAIL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(21, 246);
            label6.Name = "label6";
            label6.Size = new Size(195, 28);
            label6.TabIndex = 72;
            label6.Text = "* PHONE NUMBER";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(292, 157);
            label7.Name = "label7";
            label7.Size = new Size(145, 28);
            label7.TabIndex = 71;
            label7.Text = "* LAST NAME";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(17, 157);
            label8.Name = "label8";
            label8.Size = new Size(151, 28);
            label8.TabIndex = 70;
            label8.Text = "* FIRST NAME";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.HotPink;
            btnAdd.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(222, 444);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 45);
            btnAdd.TabIndex = 69;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(231, 17);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 68;
            label2.Text = "SEARCH";
            // 
            // tbxSTable
            // 
            tbxSTable.BackColor = Color.Lavender;
            tbxSTable.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxSTable.Location = new Point(303, 95);
            tbxSTable.Name = "tbxSTable";
            tbxSTable.Size = new Size(191, 30);
            tbxSTable.TabIndex = 67;
            // 
            // tbxSFName
            // 
            tbxSFName.BackColor = Color.Lavender;
            tbxSFName.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxSFName.Location = new Point(72, 95);
            tbxSFName.Name = "tbxSFName";
            tbxSFName.Size = new Size(191, 30);
            tbxSFName.TabIndex = 66;
            // 
            // dgvDeleteList
            // 
            dgvDeleteList.AllowUserToOrderColumns = true;
            dgvDeleteList.BackgroundColor = Color.Lavender;
            dgvDeleteList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeleteList.Columns.AddRange(new DataGridViewColumn[] { FirstName, LastName, PhoneNumber, Email, TableNumber });
            dgvDeleteList.Location = new Point(634, 219);
            dgvDeleteList.Name = "dgvDeleteList";
            dgvDeleteList.RowHeadersWidth = 51;
            dgvDeleteList.Size = new Size(686, 219);
            dgvDeleteList.TabIndex = 65;
            // 
            // FirstName
            // 
            FirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FirstName.HeaderText = "FIRST NAME";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            LastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LastName.HeaderText = "LAST NAME";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PhoneNumber.HeaderText = "PHONE NUMBER";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Email.HeaderText = "EMAIL";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 57;
            // 
            // TableNumber
            // 
            TableNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TableNumber.HeaderText = "TABLE NUMBER";
            TableNumber.MinimumWidth = 6;
            TableNumber.Name = "TableNumber";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.HotPink;
            btnSearch.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(522, 26);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(111, 45);
            btnSearch.TabIndex = 64;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.HotPink;
            btnClear.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(522, 77);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(111, 45);
            btnClear.TabIndex = 63;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.HotPink;
            btnDelete.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(895, 444);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 45);
            btnDelete.TabIndex = 62;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(315, 54);
            label5.Name = "label5";
            label5.Size = new Size(164, 28);
            label5.TabIndex = 61;
            label5.Text = "BY TABLE NUM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(106, 54);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 60;
            label1.Text = "BY NAME";
            // 
            // LblPNumber
            // 
            LblPNumber.BackColor = Color.Lavender;
            LblPNumber.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPNumber.Location = new Point(40, 273);
            LblPNumber.Name = "LblPNumber";
            LblPNumber.Size = new Size(223, 28);
            LblPNumber.TabIndex = 83;
            // 
            // LblEmail
            // 
            LblEmail.BackColor = Color.Lavender;
            LblEmail.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblEmail.Location = new Point(40, 369);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(223, 28);
            LblEmail.TabIndex = 84;
            // 
            // LblTable
            // 
            LblTable.BackColor = Color.Lavender;
            LblTable.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTable.Location = new Point(315, 273);
            LblTable.Name = "LblTable";
            LblTable.Size = new Size(223, 28);
            LblTable.TabIndex = 85;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1355, 506);
            Controls.Add(LblTable);
            Controls.Add(LblEmail);
            Controls.Add(LblPNumber);
            Controls.Add(btnRemove);
            Controls.Add(btnChoose);
            Controls.Add(LbxName);
            Controls.Add(LblLName);
            Controls.Add(LblFName);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(tbxSTable);
            Controls.Add(tbxSFName);
            Controls.Add(dgvDeleteList);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "Form5";
            Text = "DELETE";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDeleteList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRemove;
        private Button btnChoose;
        private ListBox LbxName;
        private Label LblLName;
        private Label LblFName;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnAdd;
        private Label label2;
        private TextBox tbxSTable;
        private TextBox tbxSFName;
        private DataGridView dgvDeleteList;
        private DataGridViewButtonColumn FirstName;
        private DataGridViewButtonColumn LastName;
        private DataGridViewButtonColumn PhoneNumber;
        private DataGridViewButtonColumn Email;
        private DataGridViewButtonColumn TableNumber;
        private Button btnSearch;
        private Button btnClear;
        private Button btnDelete;
        private Label label5;
        private Label label1;
        private Label LblPNumber;
        private Label LblEmail;
        private Label LblTable;
    }
}