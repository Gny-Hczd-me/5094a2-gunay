using System;
using System.Windows.Forms;

namespace Travel_Ticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Proqramdan çıxış edilsinmi?", "Bildiriş", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }
        private void btnDeyis_Click(object sender, EventArgs e)
        {
           
            string kecici = cmbHaradan.Text;
            cmbHaradan.Text = cmbHaraya.Text;
            cmbHaraya.Text = kecici;
        }
        private void btnBiletAl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text) || string.IsNullOrWhiteSpace(cmbHaradan.Text))
            {
                MessageBox.Show("Zəhmət olmasa, əsas xanaları (Ad, Soyad və İstiqamət) doldurun!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string biletMelumati = $"Sərnişin: {txtAdSoyad.Text} | FIN: {txtFIN.Text} | Marşrut: {cmbHaradan.Text} -> {cmbHaraya.Text} | Tarix/Saat: {mskdpTarix.Text} {mskdpSaat.Text} | Yer: {txtYer.Text} | Tel: {mskdTelefon.Text}";

            listBox1.Items.Add(biletMelumati);

            
        }

        private void btnBiletiSil_Click(object sender, EventArgs e)
        {
           
            if (listBox1.SelectedIndex != -1)
            {
                
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Silmək üçün aşağıdakı siyahıdan bir bilet seçin!", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
