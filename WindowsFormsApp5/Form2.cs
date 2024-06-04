using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {   
        public Form2()
        {
            InitializeComponent();
        }
      

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Получаем введенный текст 
            string inputText = textBox1.Text;
            string inOneCase = inputText.ToLower();

            //Проверка являются ли кириллицей введеный текст через регулярные выражения 
            if (!Regex.IsMatch(inOneCase, @"\P{IsCyrillic} "))
            {
                //Сортируем по алфавиту 
                string sortedText = string.Join("", inOneCase.OrderBy(c => c));
                //Добавляет в лейбл отстортированный текст 
                label1.Text = sortedText;
            }
            else
            {
                MessageBox.Show("Нет кириллицы");
            }
        }
    }
}
