using CriptBySergo;
using System;
using System.Windows.Forms;

namespace EncryptString {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }


        public void Clear()
        {
            textBox1.Clear();
            textBox3.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text;
            var key = int.Parse(textBox4.Text);

            var encoding = Cript.Encode(text, key);
            textBox2.Text = encoding;

            Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var key = int.Parse(textBox4.Text);
            var text = textBox2.Text;
            var decoding = Cript.Decode(text, key);
            textBox3.Text = decoding;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            /**/
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
