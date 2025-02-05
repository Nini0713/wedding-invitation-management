namespace FinalProject_Wedding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            btnUpdate = new Button();
            label5 = new Label();
            label1 = new Label();
            btnClear = new Button();
            btnSearch = new Button();
            dgvUpdateList = new DataGridView();
            FirstName = new DataGridViewButtonColumn();
            LastName = new DataGridViewButtonColumn();
            PhoneNumber = new DataGridViewButtonColumn();
            Email = new DataGridViewButtonColumn();
            TableNumber = new DataGridViewButtonColumn();
            tbxSFName = new TextBox();
            tbxSTable = new TextBox();
            label2 = new Label();
            btnAdd = new Button();
            label3 = new Label();
            label4 = new Label();
            tbxEmail = new TextBox();
            tbxPNumber = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            LblFName = new Label();
            LblLName = new Label();
            LbxName = new ListBox();
            btnChoose = new Button();
            btnRemove = new Button();
            cbxTable = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvUpdateList).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.HotPink;
            btnUpdate.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(903, 450);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(111, 45);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(323, 60);
            label5.Name = "label5";
            label5.Size = new Size(164, 28);
            label5.TabIndex = 21;
            label5.Text = "BY TABLE NUM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(114, 60);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 13;
            label1.Text = "BY NAME";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.HotPink;
            btnClear.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(530, 83);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(111, 45);
            btnClear.TabIndex = 36;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.HotPink;
            btnSearch.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(530, 32);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(111, 45);
            btnSearch.TabIndex = 37;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvUpdateList
            // 
            dgvUpdateList.AllowUserToOrderColumns = true;
            dgvUpdateList.BackgroundColor = Color.Lavender;
            dgvUpdateList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpdateList.Columns.AddRange(new DataGridViewColumn[] { FirstName, LastName, PhoneNumber, Email, TableNumber });
            dgvUpdateList.Location = new Point(642, 225);
            dgvUpdateList.Name = "dgvUpdateList";
            dgvUpdateList.RowHeadersWidth = 51;
            dgvUpdateList.Size = new Size(686, 219);
            dgvUpdateList.TabIndex = 38;
            dgvUpdateList.CellContentClick += dgvUpdateList_CellContentClick;
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
            // tbxSFName
            // 
            tbxSFName.BackColor = Color.Lavender;
            tbxSFName.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxSFName.Location = new Point(80, 101);
            tbxSFName.Name = "tbxSFName";
            tbxSFName.Size = new Size(191, 30);
            tbxSFName.TabIndex = 39;
            // 
            // tbxSTable
            // 
            tbxSTable.BackColor = Color.Lavender;
            tbxSTable.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxSTable.Location = new Point(311, 101);
            tbxSTable.Name = "tbxSTable";
            tbxSTable.Size = new Size(191, 30);
            tbxSTable.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(239, 23);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 41;
            label2.Text = "SEARCH";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.HotPink;
            btnAdd.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(230, 450);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 45);
            btnAdd.TabIndex = 42;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(304, 252);
            label3.Name = "label3";
            label3.Size = new Size(186, 28);
            label3.TabIndex = 51;
            label3.Text = "* TABLE NUMBER";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 347);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 50;
            label4.Text = "* EMAIL";
            // 
            // tbxEmail
            // 
            tbxEmail.BackColor = Color.Lavender;
            tbxEmail.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxEmail.ForeColor = Color.Black;
            tbxEmail.Location = new Point(48, 376);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(223, 30);
            tbxEmail.TabIndex = 49;
            // 
            // tbxPNumber
            // 
            tbxPNumber.BackColor = Color.Lavender;
            tbxPNumber.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxPNumber.ForeColor = Color.Black;
            tbxPNumber.Location = new Point(48, 281);
            tbxPNumber.Name = "tbxPNumber";
            tbxPNumber.Size = new Size(223, 30);
            tbxPNumber.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(29, 252);
            label6.Name = "label6";
            label6.Size = new Size(195, 28);
            label6.TabIndex = 47;
            label6.Text = "* PHONE NUMBER";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(304, 163);
            label7.Name = "label7";
            label7.Size = new Size(145, 28);
            label7.TabIndex = 45;
            label7.Text = "* LAST NAME";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(25, 163);
            label8.Name = "label8";
            label8.Size = new Size(151, 28);
            label8.TabIndex = 43;
            label8.Text = "* FIRST NAME";
            // 
            // LblFName
            // 
            LblFName.BackColor = Color.Lavender;
            LblFName.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFName.ForeColor = Color.Black;
            LblFName.Location = new Point(48, 195);
            LblFName.Name = "LblFName";
            LblFName.Size = new Size(223, 28);
            LblFName.TabIndex = 54;
            // 
            // LblLName
            // 
            LblLName.BackColor = Color.Lavender;
            LblLName.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblLName.ForeColor = Color.Black;
            LblLName.Location = new Point(311, 195);
            LblLName.Name = "LblLName";
            LblLName.Size = new Size(223, 28);
            LblLName.TabIndex = 55;
            // 
            // LbxName
            // 
            LbxName.BackColor = Color.Lavender;
            LbxName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LbxName.FormattingEnabled = true;
            LbxName.ItemHeight = 25;
            LbxName.Location = new Point(695, 23);
            LbxName.Name = "LbxName";
            LbxName.Size = new Size(272, 104);
            LbxName.TabIndex = 56;
            // 
            // btnChoose
            // 
            btnChoose.BackColor = Color.HotPink;
            btnChoose.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnChoose.ForeColor = Color.Black;
            btnChoose.Location = new Point(780, 155);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(111, 45);
            btnChoose.TabIndex = 57;
            btnChoose.Text = "CHOOSE";
            btnChoose.UseVisualStyleBackColor = false;
            btnChoose.Click += btnChoose_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.HotPink;
            btnRemove.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.Black;
            btnRemove.Location = new Point(1020, 450);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(111, 45);
            btnRemove.TabIndex = 59;
            btnRemove.Text = "REMOVE";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // cbxTable
            // 
            cbxTable.BackColor = Color.Lavender;
            cbxTable.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbxTable.FormattingEnabled = true;
            cbxTable.Location = new Point(311, 282);
            cbxTable.Name = "cbxTable";
            cbxTable.Size = new Size(223, 28);
            cbxTable.TabIndex = 60;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1340, 532);
            Controls.Add(cbxTable);
            Controls.Add(btnRemove);
            Controls.Add(btnChoose);
            Controls.Add(LbxName);
            Controls.Add(LblLName);
            Controls.Add(LblFName);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(tbxEmail);
            Controls.Add(tbxPNumber);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(tbxSTable);
            Controls.Add(tbxSFName);
            Controls.Add(dgvUpdateList);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(label5);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "Form4";
            Text = "UPDATE";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUpdateList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnUpdate;
        private Label label5;
        private Label label1;
        private Button btnClear;
        private Button btnSearch;
        private DataGridView dgvUpdateList;
        private TextBox tbxSFName;
        private TextBox tbxSTable;
        private Label label2;
        private Button btnAdd;
        private Label label3;
        private Label label4;
        private TextBox tbxEmail;
        private TextBox tbxPNumber;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridViewButtonColumn FirstName;
        private DataGridViewButtonColumn LastName;
        private DataGridViewButtonColumn PhoneNumber;
        private DataGridViewButtonColumn Email;
        private DataGridViewButtonColumn TableNumber;
        private Label LblFName;
        private Label LblLName;
        private ListBox LbxName;
        private Button btnChoose;
        private Button btnRemove;
        private ComboBox cbxTable;
    }
}