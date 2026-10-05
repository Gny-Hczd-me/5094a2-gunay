namespace Cafe_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double total = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Burger - 6.3");
            total += 6.3;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) // Əgər nəsə seçilibsə
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                string[] parts = selectedItem.Split('-'); 
                string foodName = parts[0].Trim(); 
                double price = Convert.ToDouble(parts[1].Trim());
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                total -= price;
                MessageBox.Show($"{foodName} səbətdən silindi.", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silmək üçün səbətdən yemək seçin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnYenile_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xanalar sıfırlansınmı?", "Təsdiq", MessageBoxButtons.YesNo, MessageBoxIcon.Question);          
            if (dialog == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                txtHesab.Clear();
                txtMebleg.Clear();
                txtQaliq.Clear();
                total = 0;
            }
        }
        private void btnYekunHesab_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0) // Səbətdə yemək varsa
            {
                txtHesab.Text = total.ToString("0.00"); 
            }
            else
            {
                MessageBox.Show("Səbətdə yemək yoxdur!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnHesabla_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMebleg.Text, out double mebleg))
            {
                if (mebleg >= total)
                {
                    double qaliq = mebleg - total;
                    txtQaliq.Text = qaliq.ToString("0.00"); 
                }
                else
                {
                    MessageBox.Show("Daxil edilən məbləğ hesabdan azdır!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa düzgün məbləğ daxil edin!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtMebleg.Clear();
            txtQaliq.Clear();
        }
    }
}
