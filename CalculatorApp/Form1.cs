using System.Data;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Number buttons
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        // Plus button
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        // Multiply button
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        // Divide button
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        // Minus button
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        // Equals button
        public void button12_Click(object sender, EventArgs e)
        {
            // Evaluate the expression and display the result
            try
            {
                new DataTable().Compute(textBox1.Text, null);
            }
            catch (Exception SyntaxErrorException)
            {
                textBox1.Text = "Invalid expression";
                return;
            }

            // Recalculate the result
            var result = new DataTable().Compute(textBox1.Text, null);

            // Print the results
            if (result.ToString() == "∞")
            {
                textBox1.Text = "Cannot divide by zero";
            }
            else
            {
                textBox1.Text = result.ToString();
            }
        }

        // Easter Egg UWU
        private void label3_Click(object sender, EventArgs e)
        {
            label4.Text = "Gerald Kase";
        }

        // LMAO
        private void label4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.GeraldoBTD69;
        }

        // AC Button
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
