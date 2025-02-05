using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_Wedding
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Reserve_Click(object sender, EventArgs e)
        {
            Form3 reserve = new Form3();
            reserve.Show();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Form4 update = new Form4();
            update.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Form5 delete = new Form5();
            delete.Show();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            Form6 view = new Form6();
            view.Show();
        }
    }
}
