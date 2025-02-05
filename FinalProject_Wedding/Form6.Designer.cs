namespace FinalProject_Wedding
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            tbxSTable = new TextBox();
            btnView = new Button();
            btnClear = new Button();
            dgvViewList = new DataGridView();
            FirstName = new DataGridViewButtonColumn();
            LastName = new DataGridViewButtonColumn();
            PhoneNumber = new DataGridViewButtonColumn();
            Email = new DataGridViewButtonColumn();
            TableNumber = new DataGridViewButtonColumn();
            btnViewAll = new Button();
            label2 = new Label();
            tbxSFName = new TextBox();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvViewList).BeginInit();
            SuspendLayout();
            // 
            // tbxSTable
            // 
            tbxSTable.BackColor = Color.Lavender;
            tbxSTable.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxSTable.Location = new Point(264, 88);
            tbxSTable.Name = "tbxSTable";
            tbxSTable.Size = new Size(191, 30);
            tbxSTable.TabIndex = 71;
            // 
            // btnView
            // 
            btnView.BackColor = Color.HotPink;
            btnView.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnView.ForeColor = Color.Black;
            btnView.Location = new Point(510, 19);
            btnView.Name = "btnView";
            btnView.Size = new Size(111, 45);
            btnView.TabIndex = 70;
            btnView.Text = "VIEW";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.HotPink;
            btnClear.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(510, 70);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(111, 45);
            btnClear.TabIndex = 69;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvViewList
            // 
            dgvViewList.AllowUserToOrderColumns = true;
            dgvViewList.BackgroundColor = Color.Lavender;
            dgvViewList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewList.Columns.AddRange(new DataGridViewColumn[] { FirstName, LastName, PhoneNumber, Email, TableNumber });
            dgvViewList.Location = new Point(53, 154);
            dgvViewList.Name = "dgvViewList";
            dgvViewList.RowHeadersWidth = 51;
            dgvViewList.Size = new Size(686, 219);
            dgvViewList.TabIndex = 72;
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
            // btnViewAll
            // 
            btnViewAll.BackColor = Color.HotPink;
            btnViewAll.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnViewAll.ForeColor = Color.Black;
            btnViewAll.Location = new Point(325, 379);
            btnViewAll.Name = "btnViewAll";
            btnViewAll.Size = new Size(120, 45);
            btnViewAll.TabIndex = 73;
            btnViewAll.Text = "VIEW ALL";
            btnViewAll.UseVisualStyleBackColor = false;
            btnViewAll.Click += btnViewAll_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(185, 10);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 78;
            label2.Text = "SEARCH";
            // 
            // tbxSFName
            // 
            tbxSFName.BackColor = Color.Lavender;
            tbxSFName.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxSFName.Location = new Point(26, 88);
            tbxSFName.Name = "tbxSFName";
            tbxSFName.Size = new Size(191, 30);
            tbxSFName.TabIndex = 76;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(269, 47);
            label1.Name = "label1";
            label1.Size = new Size(164, 28);
            label1.TabIndex = 75;
            label1.Text = "BY TABLE NUM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(60, 47);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 74;
            label3.Text = "BY NAME";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(tbxSFName);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(btnViewAll);
            Controls.Add(dgvViewList);
            Controls.Add(tbxSTable);
            Controls.Add(btnView);
            Controls.Add(btnClear);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Form6";
            Text = "VIEW";
            ((System.ComponentModel.ISupportInitialize)dgvViewList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxSTable;
        private Button btnView;
        private Button btnClear;
        private DataGridView dgvViewList;
        private DataGridViewButtonColumn FirstName;
        private DataGridViewButtonColumn LastName;
        private DataGridViewButtonColumn PhoneNumber;
        private DataGridViewButtonColumn Email;
        private DataGridViewButtonColumn TableNumber;
        private Button btnViewAll;
        private Label label2;
        private TextBox tbxSFName;
        private Label label1;
        private Label label3;
    }
}