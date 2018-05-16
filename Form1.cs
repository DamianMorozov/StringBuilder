using System;
using System.Globalization;
using System.Windows.Forms;

namespace StringBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearGui()
        {
            label1.Text = @"Execute timeout: ";
            label2.Text = @"Fill timeout: ";
            richTextBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearGui();

            var dtStart = DateTime.Now;
            var max = Convert.ToInt64(numericUpDown1.Value);
            var strNew = @"";

            for (var i = 0; i < max; i++)
            {
                strNew += "0";
            }

            label1.Text = @"Execute timeout: " + Convert.ToString(DateTime.Now - dtStart);
            richTextBox1.Text = strNew;
            label2.Text = @"Fill timeout: " + Convert.ToString(DateTime.Now - dtStart);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearGui();

            var dtStart = DateTime.Now;
            var max = Convert.ToInt64(numericUpDown1.Value);
            var sb = new System.Text.StringBuilder();

            for (var i = 0; i < max; i++)
            {
                sb.Append("0");
            }

            label1.Text = @"Execute timeout: " + Convert.ToString(DateTime.Now - dtStart);
            richTextBox1.Text = sb.ToString();
            label2.Text = @"Fill timeout: " + Convert.ToString(DateTime.Now - dtStart);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearGui();

            var ruRu = CultureInfo.CreateSpecificCulture("ru-RU");
            var dtStart = DateTime.Now;
            var max = Convert.ToInt64(numericUpDown1.Value);
            var sb = new System.Text.StringBuilder();

            for (var i = 0; i < max; i++)
            {
                sb.AppendFormat(ruRu, "Date and Time: {0:d} at {0:t}" + Environment.NewLine, DateTime.Now);
            }

            label1.Text = @"Execute timeout: " + Convert.ToString(DateTime.Now - dtStart);
            richTextBox1.Text = sb.ToString();
            label2.Text = @"Fill timeout: " + Convert.ToString(DateTime.Now - dtStart);
        }
    }
}
