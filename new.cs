using System;
using System.Data;
using System.Windows.Forms;

namespace Complex_Calculator
{
    public partial class Form1 : Form
    {
        double number1 = 0;
        double number2 = 0;
        string operation = "";
        bool click = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
        }

  
        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (click || richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
                click = false;
            }

            richTextBox1.Text += btn.Text;
        }

 
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "0";
                click = false;
            }

            if (!richTextBox1.Text.Contains("."))
            {
                richTextBox1.Text += ".";
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            if (double.TryParse(richTextBox1.Text, out number1))
            {
                operation = btn.Text;
                click = true;
            }
        }

   
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (double.TryParse(richTextBox1.Text, out number2) && !string.IsNullOrEmpty(operation))
            {
                double result = 0;
                bool validOperation = true;

                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        if (number2 != 0)
                            result = number1 / number2;
                        else
                        {
                            MessageBox.Show("Sıfıra bölmək olmaz!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            validOperation = false;
                        }
                        break;
                }

                if (validOperation)
                {
                    string history = $"{number1} {operation} {number2} = {result}";
                    listBox1.Items.Add(history);
                    richTextBox1.Text = result.ToString();
                    operation = "";
                    click = true;
                }
            }
        }

        // Kvadrat kök (Sqrt)
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (double.TryParse(richTextBox1.Text, out double num))
            {
                if (num >= 0)
                {
                    double result = Math.Sqrt(num);
                    listBox1.Items.Add($"√({num}) = {result}");
                    richTextBox1.Text = result.ToString();
                    click = true;
                }
                else
                {
                    MessageBox.Show("Mənfi ədədin kvadrat kökü yoxdur!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Kvadratı (x^2)
        private void btnSquare_Click(object sender, EventArgs e)
        {
            if (double.TryParse(richTextBox1.Text, out double num))
            {
                double result = Math.Pow(num, 2);
                listBox1.Items.Add($"{num}^2 = {result}");
                richTextBox1.Text = result.ToString();
                click = true;
            }
        }

 
        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
            number1 = 0;
            number2 = 0;
            operation = "";
            click = false;
        }


        private void button20_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 1)
            {
                richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
            }
            else
            {
                richTextBox1.Text = "0";
            }
        }
    }
}