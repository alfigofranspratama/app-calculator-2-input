namespace latihan2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int angkaPertama = 0;
            int angkaKedua = 0;
            bool isAngkaPertamaNumber = int.TryParse(txtAngkaPertama.Text, out angkaPertama);
            bool isAngkaKeduaNumber = int.TryParse(txtAngkaKedua.Text, out angkaKedua);

            if (isAngkaPertamaNumber && isAngkaKeduaNumber)
            {
                labelHasil.Visible = true;
                txtHasil.Visible = true;
                btnReset.Visible = true;

                int hasil = angkaPertama - angkaKedua;
                txtHasil.Text = hasil.ToString();
            }
            else
            {
                MessageBox.Show("Hanya diperbolehkan angka !", "Error!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            int angkaPertama = 0;
            int angkaKedua = 0;
            bool isAngkaPertamaNumber = int.TryParse(txtAngkaPertama.Text, out angkaPertama);
            bool isAngkaKeduaNumber = int.TryParse(txtAngkaKedua.Text, out angkaKedua);

            if (isAngkaPertamaNumber && isAngkaKeduaNumber)
            {
                labelHasil.Visible = true;
                txtHasil.Visible = true;
                btnReset.Visible = true;

                int hasil = angkaPertama / angkaKedua;
                txtHasil.Text = hasil.ToString();
            }
            else
            {
                MessageBox.Show("Hanya diperbolehkan angka !", "Error!");
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            int angkaPertama = 0;
            int angkaKedua = 0;
            bool isAngkaPertamaNumber = int.TryParse(txtAngkaPertama.Text, out angkaPertama);
            bool isAngkaKeduaNumber = int.TryParse(txtAngkaKedua.Text, out angkaKedua);

            if (isAngkaPertamaNumber && isAngkaKeduaNumber)
            {
                labelHasil.Visible = true;
                txtHasil.Visible = true;
                btnReset.Visible = true;

                int hasil = angkaPertama + angkaKedua;
                txtHasil.Text = hasil.ToString();
            }
            else
            {
                MessageBox.Show("Hanya diperbolehkan angka !", "Error!");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSisaBagi_Click(object sender, EventArgs e)
        {
            int angkaPertama = 0;
            int angkaKedua = 0;
            bool isAngkaPertamaNumber = int.TryParse(txtAngkaPertama.Text, out angkaPertama);
            bool isAngkaKeduaNumber = int.TryParse(txtAngkaKedua.Text, out angkaKedua);

            if (isAngkaPertamaNumber && isAngkaKeduaNumber)
            {
                labelHasil.Visible = true;
                txtHasil.Visible = true;
                btnReset.Visible = true;

                int hasil = angkaPertama % angkaKedua;
                txtHasil.Text = hasil.ToString();
            }
            else
            {
                MessageBox.Show("Hanya diperbolehkan angka !", "Error!");
            }
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            int angkaPertama = 0;
            int angkaKedua = 0;
            bool isAngkaPertamaNumber = int.TryParse(txtAngkaPertama.Text, out angkaPertama);
            bool isAngkaKeduaNumber = int.TryParse(txtAngkaKedua.Text, out angkaKedua);

            if (isAngkaPertamaNumber && isAngkaKeduaNumber)
            {
                labelHasil.Visible = true;
                txtHasil.Visible = true;
                btnReset.Visible = true;

                int hasil = angkaPertama * angkaKedua;
                txtHasil.Text = hasil.ToString();
            }
            else
            {
                MessageBox.Show("Hanya diperbolehkan angka !", "Error!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            labelHasil.Visible = false;
            txtHasil.Visible = false;
            btnReset.Visible = false;

            txtAngkaPertama.Text = "";
            txtAngkaKedua.Text = "";
        }
    }
}