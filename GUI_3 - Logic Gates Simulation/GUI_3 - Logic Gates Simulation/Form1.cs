namespace GUI_3___Logic_Gates_Simulation
{
    public partial class Form1 : Form
    {
        // Declare variables at class level
        int inputA1, inputA2, inputA3, inputA4;
        int inputB1, inputB2, inputB3, inputB4;

        int output01, output02, output03, output04;

        public Form1()
        {
            InitializeComponent();
            input11.Text = Convert.ToString(0);
            input12.Text = Convert.ToString(0);
            input13.Text = Convert.ToString(1);
            input14.Text = Convert.ToString(1);

            input21.Text = Convert.ToString(0);
            input22.Text = Convert.ToString(1);
            input23.Text = Convert.ToString(0);
            input24.Text = Convert.ToString(1);
        }

        // AND Gate
        private void button1_Click(object sender, EventArgs e)
        {
            inputA1 = Convert.ToInt32(input11.Text);
            inputA2 = Convert.ToInt32(input12.Text);
            inputA3 = Convert.ToInt32(input13.Text);
            inputA4 = Convert.ToInt32(input14.Text);

            inputB1 = Convert.ToInt32(input21.Text);
            inputB2 = Convert.ToInt32(input22.Text);
            inputB3 = Convert.ToInt32(input23.Text);
            inputB4 = Convert.ToInt32(input24.Text);

            //output01 = Convert.ToInt32(output1.Text);
            //output02 = Convert.ToInt32(output2.Text);
            //output03 = Convert.ToInt32(output3.Text);
            //output04 = Convert.ToInt32(output4.Text);

            output1.Text = Convert.ToString(inputA1 * inputB1);
            output2.Text = Convert.ToString(inputA2 * inputB2);
            output3.Text = Convert.ToString(inputA3 * inputB3);
            output4.Text = Convert.ToString(inputA4 * inputB4);
        }

        // OR Gate
        private void button2_Click(object sender, EventArgs e)
        {
            output1.Text = Convert.ToString(inputA1 + inputB1);
            output2.Text = Convert.ToString(inputA2 + inputB2);
            output3.Text = Convert.ToString(inputA3 + inputB3);
            if (inputA4 + inputB4 > 1)
            {
                output4.Text = Convert.ToString(1);
            }
            else
            {
                output4.Text = Convert.ToString(0);
            }
        }

        // NOT Gate
        private void button3_Click(object sender, EventArgs e)
        {
            output1.Text = Convert.ToString("Not Applicable for two Bits");
            output2.Text = Convert.ToString("Not Applicable for two Bits");
            output3.Text = Convert.ToString("Not Applicable for two Bits");
            output4.Text = Convert.ToString("Not Applicable for two Bits");
        }

        // NAND Gate
        private void button4_Click(object sender, EventArgs e)
        {
            int out1 = !(Convert.ToBoolean(inputA1) && Convert.ToBoolean(inputB1)) ? 1 : 0;
            int out2 = !(Convert.ToBoolean(inputA2) && Convert.ToBoolean(inputB2)) ? 1 : 0;
            int out3 = !(Convert.ToBoolean(inputA3) && Convert.ToBoolean(inputB3)) ? 1 : 0;
            int out4 = !(Convert.ToBoolean(inputA4) && Convert.ToBoolean(inputB4)) ? 1 : 0;

            // Show output in TextBoxes
            output1.Text = out1.ToString();
            output2.Text = out2.ToString();
            output3.Text = out3.ToString();
            output4.Text = out4.ToString();

            //if (inputA1*inputB1 == 0)
            //{
            //    output1.Text = Convert.ToString(~inputA1 * inputB1);
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int out1 = !(Convert.ToBoolean(inputA1) || Convert.ToBoolean(inputB1)) ? 1 : 0;
            int out2 = !(Convert.ToBoolean(inputA2) || Convert.ToBoolean(inputB2)) ? 1 : 0;
            int out3 = !(Convert.ToBoolean(inputA3) || Convert.ToBoolean(inputB3)) ? 1 : 0;
            int out4 = !(Convert.ToBoolean(inputA4) || Convert.ToBoolean(inputB4)) ? 1 : 0;

            // Show output in TextBoxes
            output1.Text = out1.ToString();
            output2.Text = out2.ToString();
            output3.Text = out3.ToString();
            output4.Text = out4.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int out1 = inputA1 ^ inputB1;
            int out2 = inputA2 ^ inputB2;
            int out3 = inputA3 ^ inputB3;
            int out4 = inputA4 ^ inputB4;

            // Display results
            output1.Text = out1.ToString();
            output2.Text = out2.ToString();
            output3.Text = out3.ToString();
            output4.Text = out4.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int out1 = (inputA1 ^ inputB1) == 0 ? 1 : 0;
            int out2 = (inputA2 ^ inputB2) == 0 ? 1 : 0;
            int out3 = (inputA3 ^ inputB3) == 0 ? 1 : 0;
            int out4 = (inputA4 ^ inputB4) == 0 ? 1 : 0;

            // Show output
            output1.Text = out1.ToString();
            output2.Text = out2.ToString();
            output3.Text = out3.ToString();
            output4.Text = out4.ToString();
        }
    }
}
