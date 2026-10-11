namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private decimal totalRevenue;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            string flowerName = textBox1.Text.Trim();
            string countText = textBox2.Text.Trim();
            string priceText = textBox3.Text.Trim();

            if (string.IsNullOrWhiteSpace(flowerName) || string.IsNullOrWhiteSpace(countText) || string.IsNullOrWhiteSpace(priceText))
            {
                MessageBox.Show("Zəhmət olmasa bütün xanaları doldurun.", "Məlumat çatışmır", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(countText, out int count) || count <= 0)
            {
                MessageBox.Show("Say müsbət tam ədəd olmalıdır. Mənfi və sıfır say qəbul edilmir.", "Yanlış say", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                textBox2.SelectAll();
                return;
            }

            string normalizedPrice = priceText.Replace(',', '.');
            if (!decimal.TryParse(normalizedPrice, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.InvariantCulture, out decimal price) || price <= 0)
            {
                MessageBox.Show("Qiymət müsbət ədəd olmalıdır. Mənfi və sıfır qiymət qəbul edilmir.", "Yanlış qiymət", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                textBox3.SelectAll();
                return;
            }

            decimal result = count * price;
            totalRevenue += result;

            dataGridView1.Rows.Add(textBox1.Text.Trim(), count.ToString(), price.ToString("F2"), result.ToString("F2"));
            totalValueLabel.Text = totalRevenue.ToString("F2");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıxış edilsinmi?", "Çıxış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
