namespace FinalProject_Wedding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            btn_Reserve = new Button();
            btn_Update = new Button();
            btn_View = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Linen;
            label1.Location = new Point(241, 91);
            label1.Name = "label1";
            label1.Size = new Size(405, 292);
            label1.TabIndex = 2;
            label1.Text = "     LETS SAVE\r\n     THE DATE \r\n         AND \r\nJOIN THE TABLE";
            // 
            // btn_Reserve
            // 
            btn_Reserve.BackColor = Color.HotPink;
            btn_Reserve.BackgroundImageLayout = ImageLayout.Center;
            btn_Reserve.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Reserve.ForeColor = Color.Black;
            btn_Reserve.Location = new Point(190, 431);
            btn_Reserve.Name = "btn_Reserve";
            btn_Reserve.Size = new Size(114, 45);
            btn_Reserve.TabIndex = 4;
            btn_Reserve.Text = "RESERVE";
            btn_Reserve.UseVisualStyleBackColor = false;
            btn_Reserve.Click += btn_Reserve_Click;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.HotPink;
            btn_Update.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Update.ForeColor = Color.Black;
            btn_Update.Location = new Point(310, 431);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(114, 45);
            btn_Update.TabIndex = 5;
            btn_Update.Text = "UPDATE";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_View
            // 
            btn_View.BackColor = Color.HotPink;
            btn_View.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_View.ForeColor = Color.Black;
            btn_View.Location = new Point(550, 431);
            btn_View.Name = "btn_View";
            btn_View.Size = new Size(114, 45);
            btn_View.TabIndex = 6;
            btn_View.Text = "VIEW";
            btn_View.UseVisualStyleBackColor = false;
            btn_View.Click += btn_View_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.HotPink;
            btnDelete.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(430, 431);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 45);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(836, 506);
            Controls.Add(btnDelete);
            Controls.Add(btn_View);
            Controls.Add(btn_Update);
            Controls.Add(btn_Reserve);
            Controls.Add(label1);
            Name = "Form2";
            Text = "TABLE PROPERTIES";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btn_Reserve;
        private Button btn_Update;
        private Button btn_View;
        private Button btnDelete;
    }
}