namespace GUI_1___First_GUI_Windows_Form_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Two Numbers Addition GUI\n Made By Abhinav");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String num1_str = textBox1.Text;
            int num1 = Convert.ToInt32(num1_str);
            
            String num2_str = textBox2.Text;
            int num2 = Convert.ToInt32(num2_str);

            int result = num1 + num2;
            // int to String
            ResultBox.Text = Convert.ToString(result);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
        }
    }
}
