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
            // Bütün şəkilləri və yazıları başlanğıcda gizlədirik
            pictureBox1.Visible = false; label1.Visible = false;
            pictureBox2.Visible = false; label2.Visible = false;
            pictureBox3.Visible = false; label3.Visible = false;
            pictureBox4.Visible = false; label4.Visible = false;
            pictureBox5.Visible = false; label5.Visible = false;
            pictureBox6.Visible = false; label6.Visible = false;
            pictureBox7.Visible = false; label7.Visible = false;
            pictureBox8.Visible = false; label8.Visible = false;

            // Xana boşdursa xəbərdarlıq edirik
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Məbləğ daxil edin");
            }
            // Daxil edilən məlumatın rəqəm olub-olmadığını yoxlayırıq və rəqəmdirsə 'mebleg' dəyişəninə mənimsədirik
            else if (!int.TryParse(textBox1.Text, out int mebleg))
            {
                errorProvider1.SetError(textBox1, "Zəhmət olmasa düzgün rəqəm daxil edin");
            }
            else
            {
                // Əgər hər şey qaydasındadırsa, xəta mesajını təmizləyirik
                errorProvider1.SetError(textBox1, "");

                // Mənfi və sıfır yoxlaması
                if (mebleg <= 0)
                {
                    MessageBox.Show("Mənfi və ya sıfır məbləğ xırdalanmaz", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // 500-lük
                    if (mebleg >= 500)
                    {
                        pictureBox8.Visible = true;
                        label8.Visible = true;
                        label8.Text = (mebleg / 500).ToString();
                        mebleg = mebleg % 500;
                    }
                    // 200-lük
                    if (mebleg >= 200)
                    {
                        pictureBox7.Visible = true;
                        label7.Visible = true;
                        label7.Text = (mebleg / 200).ToString();
                        mebleg = mebleg % 200;
                    }
                    // 100-lük
                    if (mebleg >= 100)
                    {
                        pictureBox6.Visible = true;
                        label6.Visible = true;
                        label6.Text = (mebleg / 100).ToString();
                        mebleg = mebleg % 100;
                    }
                    // 50-lik
                    if (mebleg >= 50)
                    {
                        pictureBox5.Visible = true;
                        label5.Visible = true;
                        label5.Text = (mebleg / 50).ToString();
                        mebleg = mebleg % 50;
                    }
                    // 20-lik
                    if (mebleg >= 20)
                    {
                        pictureBox4.Visible = true;
                        label4.Visible = true;
                        label4.Text = (mebleg / 20).ToString();
                        mebleg = mebleg % 20;
                    }
                    // 10-luq
                    if (mebleg >= 10)
                    {
                        pictureBox3.Visible = true;
                        label3.Visible = true;
                        label3.Text = (mebleg / 10).ToString();
                        mebleg = mebleg % 10;
                    }
                    // 5-lik
                    if (mebleg >= 5)
                    {
                        pictureBox2.Visible = true;
                        label2.Visible = true;
                        label2.Text = (mebleg / 5).ToString();
                        mebleg = mebleg % 5;
                    }
                    // 1-lik
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
