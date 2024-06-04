using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {   //Список для хранения данных таблицы
        private List<FactorialData> data = new List<FactorialData>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Настроить поля ввода для приема только цифр
            txtNumber1.KeyPress += new KeyPressEventHandler(OnlyNumeric);
            txtNumber2.KeyPress += new KeyPressEventHandler(OnlyNumeric);
            txtNumber3.KeyPress += new KeyPressEventHandler(OnlyNumeric);

            // Создать столбцы в таблице
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add( "Number1", "Число 1");
            dataGridView1.Columns.Add("Number2", "Число 2");
            dataGridView1.Columns.Add("Number1", "Число 3");
            dataGridView1.Columns.Add("Number1", "Факториал 1");
            dataGridView1.Columns.Add("Factorial2", "Факториал 2");
            dataGridView1.Columns.Add("Factorial3", "Факториал 3");
        }

        private void OnlyNumeric(object sender, KeyPressEventArgs e)
        {
            // Разрешить ввод только цифр и клавиши Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

      

        private int CalculateFactorial(int number)
        {
            // Рассчитать факториал числа
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        // Класс для хранения данных таблицы
        public class FactorialData
        {
            public int Number1 { get; set; }
            public int Number2 { get; set; }
            public int Number3 { get; set; }
            public int Factorial1 { get; set; }
            public int Factorial2 { get; set; }
            public int Factorial3 { get; set; }
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        { // Проверить, заполнены ли все поля ввода
            if (string.IsNullOrEmpty(txtNumber1.Text) || string.IsNullOrEmpty(txtNumber2.Text) || string.IsNullOrEmpty(txtNumber3.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля ввода!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Получить значения из полей ввода
            int number1 = int.Parse(txtNumber1.Text);
            int number2 = int.Parse(txtNumber2.Text);
            int number3 = int.Parse(txtNumber3.Text);

            // Рассчитать факториалы чисел
            int factorial1 = CalculateFactorial(number1);
            int factorial2 = CalculateFactorial(number2);
            int factorial3 = CalculateFactorial(number3);

            // Добавить данные в список
            data.Add(new FactorialData { Number1 = number1, Number2 = number2, Number3 = number3, Factorial1 = factorial1, Factorial2 = factorial2, Factorial3 = factorial3 });

            // Отобразить данные в таблице
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;

            // Очистить поля ввода
            txtNumber1.Clear();
            txtNumber2.Clear();
            txtNumber3.Clear();

            // Вывести сообщение об успешном сохранении данных
            MessageBox.Show("Данные сохранены успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
