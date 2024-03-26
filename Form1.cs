namespace SimpleCalculatorApp
{
    public partial class Form1 : Form
    {
        double Number1;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }
        // 0
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }
        // 1
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }
        // 2
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }
        // 3
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }
        // 4
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }
        // 5
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }
        // 6
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }
        // 7
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }
        // 8
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }
        // 9
        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }
        // Back Current
        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "0";
            }
            else
            {
                string str = textBox1.Text;
                textBox1.Text = str.Remove(str.Length - 1);
            }

        }
        // Clear All
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
        }
        // Addition
        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            Number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";
        }
        // Subtraction
        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            Number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";
        }
        // Multiply
        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            Number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "*";
        }
        // Devide
        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            Number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "/";
        }
        // Comma
        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
        // Equels
        private void button19_Click(object sender, EventArgs e)
        {
            double Number2;
            double Results;

            Number2 = Convert.ToDouble(textBox1.Text);

                if (Operation == "+")
                {
                    Results = (Number1 + Number2);
                    textBox2.Text = Convert.ToString(Results);
                    textBox1.Text = "0";
                }
                else if (Operation == "-")
                {
                    Results = (Number1 - Number2);
                    textBox2.Text = Convert.ToString(Results);
                    textBox1.Text = "0";

                }
                else if (Operation == "*")
                {
                    Results = (Number1 * Number2);
                    textBox2.Text = Convert.ToString(Results);
                    textBox1.Text = "0";
                }
                else if (Operation == "/")
                {
                    if (Number2 == 0)
                    {
                        textBox2.Text = "Cannot devide by Zero";
                    }
                    else
                    {
                        Results = (Number1 / Number2);
                        textBox2.Text = Convert.ToString(Results);
                        textBox1.Text = "0";
                    }
                }
            
        }
    }
}
