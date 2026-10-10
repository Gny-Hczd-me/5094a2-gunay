using System;
using System.Windows.Forms;

namespace Money
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Əvvəlki nəticələri gizlət
            pictureBox1.Visible = false; label1.Visible = false;
            pictureBox2.Visible = false; label2.Visible = false;
            pictureBox3.Visible = false; label3.Visible = false;
            pictureBox4.Visible = false; label4.Visible = false;
            pictureBox5.Visible = false; label5.Visible = false;
            pictureBox6.Visible = false; label6.Visible = false;
            pictureBox7.Visible = false; label7.Visible = false;
            pictureBox8.Visible = false; label8.Visible = false;

            // Xana boşdursa, ErrorProvider mesajı göstər
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Məbləğ daxil edin");
                textBox1.Focus();
                return;
            }

            errorProvider1.SetError(textBox1, "");

            int mebleg;
            if (!int.TryParse(textBox1.Text, out mebleg))
            {
                MessageBox.Show(
                    "Düzgün tam məbləğ daxil edin.",
                    "Diqqət",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (mebleg <= 0)
            {
                MessageBox.Show(
                    "Mənfi və ya sıfır məbləğ xırdalanmaz",
                    "Diqqət",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int say;

            // 500 manat
            say = mebleg / 500;
            if (say > 0)
            {
                pictureBox8.Visible = true;
                label8.Visible = true;
                label8.Text = say.ToString();
                mebleg %= 500;
            }

            // 200 manat
            say = mebleg / 200;
            if (say > 0)
            {
                pictureBox7.Visible = true;
                label7.Visible = true;
                label7.Text = say.ToString();
                mebleg %= 200;
            }

            // 100 manat
            say = mebleg / 100;
            if (say > 0)
            {
                pictureBox6.Visible = true;
                label6.Visible = true;
                label6.Text = say.ToString();
                mebleg %= 100;
            }

            // 50 manat
            say = mebleg / 50;
            if (say > 0)
            {
                pictureBox5.Visible = true;
                label5.Visible = true;
                label5.Text = say.ToString();
                mebleg %= 50;
            }

            // 20 manat
            say = mebleg / 20;
            if (say > 0)
            {
                pictureBox4.Visible = true;
                label4.Visible = true;
                label4.Text = say.ToString();
                mebleg %= 20;
            }

            // 10 manat
            say = mebleg / 10;
            if (say > 0)
            {
                pictureBox3.Visible = true;
                label3.Visible = true;
                label3.Text = say.ToString();
                mebleg %= 10;
            }

            // 5 manat
            say = mebleg / 5;
            if (say > 0)
            {
                pictureBox2.Visible = true;
                label2.Visible = true;
                label2.Text = say.ToString();
                mebleg %= 5;
            }

            // 1 manat
            say = mebleg;
            if (say > 0)
            {
                pictureBox1.Visible = true;
                label1.Visible = true;
                label1.Text = say.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                errorProvider1.SetError(textBox1, "Məbləğ daxil edin");
            else
                errorProvider1.SetError(textBox1, "");
        }
    }
}
