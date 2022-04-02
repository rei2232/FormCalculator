using DLLCalculator;
namespace FormCalculator
{
    public partial class Form1 : Form
    {
        Calculator calc = new Calculator();
        private Decimal d1;
        private Decimal d2;
        private string number = "";
        private string operand = "";
        private int memory_y = 15;
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
            calc.AddMemoryItem(Convert.ToDecimal(number));
            Label memory_label = new Label();
            Memory_result_panel.Controls.Add(memory_label);
            memory_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            memory_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            memory_label.Location = new System.Drawing.Point(118, memory_y);
            memory_label.Name = "label1";
            memory_label.Size = new System.Drawing.Size(101, 34);
            memory_label.TabIndex = 0;
            memory_label.Text = number;
            memory_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            memory_y += 50;
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
            d2 = Convert.ToDecimal(number);
            switch(operand)
            {
                case "+":
                    calc.add(d1, d2);
                    break;
                case "-":
                    calc.minus(d1, d2);
                    break;
                case "*":
                    calc.multiply(d1, d2);
                    break;
                case "/":
                    calc.divide(d1, d2);
                    break;
                default:
                    break;
            }
            Result_pre_label.Text = Convert.ToString(d1) + operand + Convert.ToString(d2);
            Result_label.Text = Convert.ToString(calc.Result);
            number = Convert.ToString(calc.Result);
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
            Result_pre_label.Text = "";
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (number != "")
            {
                d1 = Convert.ToDecimal(number);
                Result_pre_label.Text = Convert.ToString(d1) + '+';
                number = "";
                operand = "+";
            }
           
        }

        private void Minus_btn_Click(object sender, EventArgs e)
        {
            if (number != "")
            {
                d1 = Convert.ToDecimal(number);
                Result_pre_label.Text = Convert.ToString(d1) + '-';
                number = "";
                operand = "-";
            }
        }

        private void Multiply_btn_Click(object sender, EventArgs e)
        {
            if (number != "")
            {
                d1 = Convert.ToDecimal(number);
                Result_pre_label.Text = Convert.ToString(d1) + '*';
                number = "";
                operand = "*";
            }
        }

        private void Divide_btn_Click(object sender, EventArgs e)
        {
            if (number != "")
            {
                d1 = Convert.ToDecimal(number);
                Result_pre_label.Text = Convert.ToString(d1) + '/';
                number = "";
                operand = "/";
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}