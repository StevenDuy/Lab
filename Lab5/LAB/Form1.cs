namespace LAB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double num2 = double.Parse(txtNum2.Text);
        }

        private void Tru_Click(object sender, EventArgs e)
        {
            Cong.BackColor = Color.White;
            Tru.BackColor = Color.Green;
            Nhan.BackColor = Color.White;
            Chia.BackColor = Color.White;
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            txtAnswer.Text = (num1 - num2).ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
        }

        private void Cong_Click(object sender, EventArgs e)
        {
            Cong.BackColor = Color.Green;
            Tru.BackColor = Color.White;
            Nhan.BackColor = Color.White;
            Chia.BackColor = Color.White;
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            txtAnswer.Text = (num1 + num2).ToString();
        }

        private void Nhan_Click(object sender, EventArgs e)
        {
            Cong.BackColor = Color.White;
            Tru.BackColor = Color.White;
            Nhan.BackColor = Color.Green;
            Chia.BackColor = Color.White;
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            txtAnswer.Text = (num1 * num2).ToString();
        }

        private void Chia_Click(object sender, EventArgs e)
        {
            Cong.BackColor = Color.White;
            Tru.BackColor = Color.White;
            Nhan.BackColor = Color.White;
            Chia.BackColor = Color.Green;
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            txtAnswer.Text = (num1 / num2).ToString();
        }
    }
}
