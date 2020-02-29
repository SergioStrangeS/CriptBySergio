using System;
using System.Windows.Forms;

namespace EncryptString {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public string encrypt;
        public int key = 2019;                                          //Указываем переменную ключа.

        private void button1_Click(object sender, EventArgs e)
        {
            char[] arr = textBox1.Text.ToCharArray();                   //Разбираем строку на символы и записываем в массив.
            encrypt = "";
            for (int i = 0; i < arr.Length; i++)
            {
                encrypt += ((int)arr[i] * key).ToString() + '-';        //Приводим символ к типу int,умножаем на (переменная key) и разделяем каждый "шифрованный символ символом '-'. 
            }

            textBox2.Text = encrypt;                                    //заполняем textBox2
            textBox1.Clear();                                           //Очистка textBox'ов
            textBox3.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e) {
            string[] arr = textBox2.Text.Split('-');                    //Наши "символы же разделены '-', вот и ищем их.
            for (int i = 0; i < arr.Length; i++) {
                try {
                    textBox3.Text += ((char)(Convert.ToInt32(arr[i]) / key)).ToString();//Тут вот муть какая-то, обернул в try, catch. Делим обратно на 2019 и приводим к типу char.
                }

                catch {
                }
            }
            textBox2.Clear();                                           //Очистка textBox'ов
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            key = int.Parse(textBox4.Text);
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
