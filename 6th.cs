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
            pictureBox1.Visible = false; label1.Visible = false;
            pictureBox2.Visible = false; label2.Visible = false;
            pictureBox3.Visible = false; label3.Visible = false;
            pictureBox4.Visible = false; label4.Visible = false;
            pictureBox5.Visible = false; label5.Visible = false;
            pictureBox6.Visible = false; label6.Visible = false;
            pictureBox7.Visible = false; label7.Visible = false;
            pictureBox8.Visible = false; label8.Visible = false;

            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Məbləğ daxil edin");
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
                int mebleg = int.Parse(textBox1.Text);

                if (mebleg <= 0)
                {
                    MessageBox.Show("Mənfi və ya sıfır məbləğ xırdalanmaz", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (mebleg >= 500)
                    {
                        pictureBox8.Visible = true;
                        label8.Visible = true;
                        label8.Text = (mebleg / 500).ToString();
                        mebleg = mebleg % 500;
                    }
                    if (mebleg >= 200)
                    {
                        pictureBox7.Visible = true;
                        label7.Visible = true;
                        label7.Text = (mebleg / 200).ToString();
                        mebleg = mebleg % 200;
                    }
                    if (mebleg >= 100)
                    {
                        pictureBox6.Visible = true;
                        label6.Visible = true;
                        label6.Text = (mebleg / 100).ToString();
                        mebleg = mebleg % 100;
                    }
                    if (mebleg >= 50)
                    {
                        pictureBox5.Visible = true;
                        label5.Visible = true;
                        label5.Text = (mebleg / 50).ToString();
                        mebleg = mebleg % 50;
                    }
                    if (mebleg >= 20)
                    {
                        pictureBox4.Visible = true;
                        label4.Visible = true;
                        label4.Text = (mebleg / 20).ToString();
                        mebleg = mebleg % 20;
                    }
                    if (mebleg >= 10)
                    {
                        pictureBox3.Visible = true;
                        label3.Visible = true;
                        label3.Text = (mebleg / 10).ToString();
                        mebleg = mebleg % 10;
                    }
                    if (mebleg >= 5)
                    {
                        pictureBox2.Visible = true;
                        label2.Visible = true;
                        label2.Text = (mebleg / 5).ToString();
                        mebleg = mebleg % 5;
                    }
                    if (mebleg >= 1)
                    {
                        pictureBox1.Visible = true;
                        label1.Visible = true;
                        label1.Text = mebleg.ToString();
                    }
                }
            }
        }
    }
}