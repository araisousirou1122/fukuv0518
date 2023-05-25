namespace fukuv0518
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            namebtn.Text = "arai";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Left = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            namebtn.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            checkBox1.Visible = false;
            BackColor = Color.Red;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
