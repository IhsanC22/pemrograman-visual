namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtsuhu.Text = String.Empty;
            tbhasil.Text = String.Empty;
            cbsuhu.SelectedIndex = -1;
            cbsuhu2.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtsuhu.Focus();
            tbhasil.ReadOnly = true;
            cbsuhu.Items.Add("celcius");
            cbsuhu.Items.Add("fahrenheit");
            cbsuhu.Items.Add("reamur");
            cbsuhu2.Items.Add("celcius");
            cbsuhu2.Items.Add("fahrenheit");
            cbsuhu2.Items.Add("reamur");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hasil = 0;


            if (cbsuhu.SelectedItem == "celcius" && cbsuhu2.SelectedItem == "reamur")
            {
                hasil = int.Parse(txtsuhu.Text) * 4 / 5;
                tbhasil.Text = hasil.ToString();
            }
            if (cbsuhu.SelectedItem == "celcius" && cbsuhu2.SelectedItem == "fahrenheit")
            {
                hasil = int.Parse(txtsuhu.Text) * 9 / 4 + 32;
                tbhasil.Text = hasil.ToString();
            }
            if (cbsuhu.SelectedItem == "reamur" && cbsuhu2.SelectedItem == "celcius")
            {
                hasil = int.Parse(txtsuhu.Text) * 5 / 4;
                tbhasil.Text = hasil.ToString();
            }
            if (cbsuhu.SelectedItem == "reamur" && cbsuhu2.SelectedItem == "fahrenheit")
            {
                hasil = int.Parse(txtsuhu.Text) * 9 / 4 + 32;
                tbhasil.Text = hasil.ToString();
            }
            if (cbsuhu.SelectedItem == "fahrenheit" && cbsuhu2.SelectedItem == "celcius")
            {
                hasil = (int.Parse(txtsuhu.Text) - 32)* 4 / 9;
                tbhasil.Text = hasil.ToString();
            }
            if (cbsuhu.SelectedItem == "fahrenheit" && cbsuhu2.SelectedItem == "reamur")
            {
                hasil = (int.Parse(txtsuhu.Text) - 32) * 5 / 9;
                tbhasil.Text = hasil.ToString();
            }

            if (cbsuhu.SelectedItem == "celcius" && cbsuhu2.SelectedItem == "celcius")
            {
                tbhasil.Text = "Mohon isinya beda";
            }
            if (cbsuhu.SelectedItem == "reamur" && cbsuhu2.SelectedItem == "reamur")
            {
                tbhasil.Text = "Mohon isinya beda";
            }
            if (cbsuhu.SelectedItem == "fahrenheit" && cbsuhu2.SelectedItem == "fahrenheit")
            {
                tbhasil.Text = "Mohon isinya beda";
            }
        }
    }
}
