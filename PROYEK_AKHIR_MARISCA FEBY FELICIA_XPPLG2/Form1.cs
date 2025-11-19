using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;

namespace PROYEK_AKHIR_MARISCA_XPPLG2
{
    public partial class tbKembalian : Form
    {
        public tbKembalian()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Menghitung kembalian
            if (!string.IsNullOrEmpty(tbBayar.Text))
            {
                if (Convert.ToDouble(tbBayar.Text) < Convert.ToDouble(tbTotal.Text))
                {
                    MessageBox.Show("uangnya kurang ya ga boleh ngutang");
                    return;
                }

                double kembalian = double.Parse(tbBayar.Text) - double.Parse(tbTotal.Text);
                txtKembalian.Text = $"{kembalian}";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int jenismakanan = 0;
            int jenisminuman = 0;
            if (cbMakanan.SelectedIndex == 0) jenismakanan = 12000;
            {

            }
            if (cbMinuman.SelectedIndex == 0) jenisminuman = 10000;
            {
                tbTotal.Text = $"{jenismakanan + jenisminuman}";
            }
        }

        private void bntPilih_Click(object sender, EventArgs e)
        {
           
        }
    }
}





















