using System.ComponentModel;
using System.Xml;

namespace modul3_1302210110
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int ang1, ang2, jml;

        private void button3_Click(object sender, EventArgs e)
        {
            string dua = "2";
            label1.Text = label1.Text + dua;


        }

        private void button9_Click(object sender, EventArgs e)
        {
            string del = "8";
            label1.Text = label1.Text + del;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            ang2 = Int32.Parse(label1.Text);
            jml = ang1 + ang2;
            label1.Text = jml.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nol = "0";
            label1.Text = label1.Text + nol;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string satu = "1";
            label1.Text = label1.Text + satu;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string tiga = "3";
            label1.Text = label1.Text + tiga;

        }
        private void button5_Click(object sender, EventArgs e)
        {
            string empat = "4";
            label1.Text = label1.Text + empat;

        }
        private void button6_Click(object sender, EventArgs e)
        {
            string lima = "5";
            label1.Text = label1.Text + lima;


        }
        private void button7_Click(object sender, EventArgs e)
        {
            string enam = "6";
            label1.Text = label1.Text + enam;

        }
        private void button8_Click(object sender, EventArgs e)
        {
            string tuju = "7";
            label1.Text = label1.Text + tuju;

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string tiga = "3";
            label1.Text = label1.Text + tiga;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string satu = "1";
            label1.Text += satu;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string empat = "4";
            label1.Text = empat;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string lima = "5";
            label1.Text = label1.Text + lima;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            string enam = "6";
            label1.Text = label1.Text + enam;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            string tuj = "7";
            label1.Text = label1.Text + tuj;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            string sem = "9";
            label1.Text = label1.Text + sem;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            
            ang1 = Int32.Parse(label1.Text);
            label1.Text = "      ";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string sem = "9";
            label1.Text = label1.Text + sem;

        }
    }
        
}