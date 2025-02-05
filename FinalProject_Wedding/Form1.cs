namespace FinalProject_Wedding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Begin_Click(object sender, EventArgs e)
        {
            Form2 table_properties = new Form2();
            table_properties.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
