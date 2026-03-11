namespace Modul3_103022400053
{
    public partial class Form1 : Form
    {
        private string satuanAwal;
        private string satuanAkhir;
        private int nilaiAwal;
        private double hasilKonversi;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu");
                return;
            } else if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Masukkan angka yang valid");
                return;
            }

            if (comboBox1.SelectedIndex == 0) satuanAwal = "Celcius";
            if (comboBox1.SelectedIndex == 1) satuanAwal = "Fahrenheit";
            if (comboBox1.SelectedIndex == 2) satuanAwal = "Kelvin";
            if (comboBox1.SelectedIndex == 3) satuanAwal = "Reamur";

            if (comboBox2.SelectedIndex == 0) satuanAkhir = "Celcius";
            if (comboBox2.SelectedIndex == 1) satuanAkhir = "Fahrenheit";
            if (comboBox2.SelectedIndex == 2) satuanAkhir = "Kelvin";
            if (comboBox2.SelectedIndex == 3) satuanAkhir = "Reamur";

            int nilai = int.Parse(textBox1.Text);

            if (satuanAwal == "Celcius" && satuanAkhir == "Fahrenheit")
            {
                hasilKonversi = (nilai * 9 / 5) + 32;
            }
            else if (satuanAwal == "Celcius" && satuanAkhir == "Kelvin")
            {
                hasilKonversi = nilai + 273.15;
            }
            else if (satuanAwal == "Celcius" && satuanAkhir == "Reamur")
            {
                hasilKonversi = nilai * 4 / 5;
            }
            else if (satuanAwal == "Fahrenheit" && satuanAkhir == "Celcius")
            {
                hasilKonversi = (nilai - 32) * 5 / 9;
            }
            else if (satuanAwal == "Fahrenheit" && satuanAkhir == "Kelvin")
            {
                hasilKonversi = (nilai - 32) * 5 / 9 + 273.15;
            }
            else if (satuanAwal == "Fahrenheit" && satuanAkhir == "Reamur")
            {
                hasilKonversi = (nilai - 32) * 4 / 9;
            }
            else if (satuanAwal == "Kelvin" && satuanAkhir == "Celcius")
            {
                hasilKonversi = nilai - 273.15;
            }
            else if (satuanAwal == "Kelvin" && satuanAkhir == "Fahrenheit")
            {
                hasilKonversi = (nilai - 273.15) * 9 / 5 + 32;
            }
            else if (satuanAwal == "Kelvin" && satuanAkhir == "Reamur")
            {
                hasilKonversi = (nilai - 273.15) * 4 / 5;
            }
            else if (satuanAwal == "Reamur" && satuanAkhir == "Celcius")
            {
                hasilKonversi = nilai * 5 / 4;
            }
            else if (satuanAwal == "Reamur" && satuanAkhir == "Fahrenheit")
            {
                hasilKonversi = (nilai * 9 / 4) + 32;
            }
            else if (satuanAwal == "Reamur" && satuanAkhir == "Kelvin")
            {
                hasilKonversi = (nilai * 5 / 4) + 273.15;
            }
            textBox2.Text = hasilKonversi.ToString();
        }
    }
}
