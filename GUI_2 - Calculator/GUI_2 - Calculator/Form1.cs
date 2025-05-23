namespace GUI_2___Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string add_num_1_str = sum_num1.Text;
                string add_num_2_str = sum_num2.Text;
                long num1 = Convert.ToInt64(add_num_1_str);
                long num2 = Convert.ToInt64(add_num_2_str);
                long result = num1 + num2;
                sum_result.Text = result.ToString();
            }
            catch (Exception f)
            {
                Error.Text = Convert.ToString(f);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sub_num_1_str = sub_num_1.Text;
                string sub_num_2_str = sub_num_2.Text;
                long num1 = Convert.ToInt64(sub_num_1_str);
                long num2 = Convert.ToInt64(sub_num_2_str);
                long result = num1 - num2;
                sub_result.Text = result.ToString();
            }
            catch (Exception f)
            {
                Error.Text = Convert.ToString(f);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string mul_num_1_str = mul_num1.Text;
                string mul_num_2_str = mul_num2.Text;
                long num1 = Convert.ToInt64(mul_num_1_str);
                long num2 = Convert.ToInt64(mul_num_2_str);
                long result = num1 * num2;
                mul_result.Text = result.ToString();
            }
            catch (Exception f)
            {
                Error.Text = Convert.ToString(f);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string div_num_1_str = div_num1.Text;
                string div_num_2_str = div_num2.Text;
                long num1 = Convert.ToInt64(div_num_1_str);
                long num2 = Convert.ToInt64(div_num_2_str);
                long result = num1 / num2;
                div_result.Text = result.ToString();
            }
            catch (Exception f)
            {
                Error.Text = Convert.ToString(f);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            try
            {
                sum_num1.Text = "";
                sum_num2.Text = "";
                sum_result.Text = "";
                Error.Text = "";
            }
            catch (Exception f)
            {
                Error.Text = Convert.ToString(f);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            try
            {
                sub_num_1.Text = "";
                sub_num_2.Text = "";
                sub_result.Text = "";
                Error.Text = "";
            }
            catch (Exception f)
            {
                Error.Text = Convert.ToString(f);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            try
            {
                mul_num1.Text = "";
                mul_num2.Text = "";
                mul_result.Text = "";
                Error.Text = "";
            }
            catch (Exception f)
            {
                Error.Text = Convert.ToString(f);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            try
            {
                div_num1.Text = "";
                div_num2.Text = "";
                div_result.Text = "";
                Error.Text = "";
            }
            catch (Exception f)
            {
                Error.Text = Convert.ToString(f);
            }
        }
    }
}
