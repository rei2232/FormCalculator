namespace FormCalculator
{
    public partial class Form1 : Form
    {
        private Decimal d1;
        private Decimal d2;
        private string number = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Result_pre_label_Click(object sender, EventArgs e)
        {

        }

        private void Result_label_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void MS_box_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Nine_btn_Click(object sender, EventArgs e)
        {
            number += Nine_btn.Text;
            Result_label.Text = number;

        }

        private void Eight_btn_Click(object sender, EventArgs e)
        {
            number += Eight_btn.Text;
            Result_label.Text = number;
        }

        private void Seven_btn_Click(object sender, EventArgs e)
        {
            number += Seven_btn.Text;
            Result_label.Text = number;
        }

        private void Four_btn_Click(object sender, EventArgs e)
        {
            number += Four_btn.Text;
            Result_label.Text = number;
        }

        private void Five_btn_Click(object sender, EventArgs e)
        {
            number += Five_btn.Text;
            Result_label.Text = number;
        }

        private void Six_btn_Click(object sender, EventArgs e)
        {
            number += Six_btn.Text;
            Result_label.Text = number;
        }

        private void One_btn_Click(object sender, EventArgs e)
        {
            number += One_btn.Text;
            Result_label.Text = number;
        }

        private void Two_btn_Click(object sender, EventArgs e)
        {
            number += Two_btn.Text;
            Result_label.Text = number;
        }

        private void Three_btn_Click(object sender, EventArgs e)
        {
            number += Three_btn.Text;
            Result_label.Text = number;
        }

        private void Zero_btn_Click(object sender, EventArgs e)
        {
            number += Zero_btn.Text;
            Result_label.Text = number;
        }

        private void Equal_btn_Click(object sender, EventArgs e)
        {

        }

        private void Result_pre_label_Click_1(object sender, EventArgs e)
        {

        }

        private void Result_label_Click_1(object sender, EventArgs e)
        {

        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            number = "";
            Result_label.Text = "0";
        }
    }
}