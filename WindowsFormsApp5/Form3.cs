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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            // Добавить элементы в ComboBox рандомно с помощью кода
            Random random = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                numbers.Add(random.Next(1, 10));
            }
            comboBox1.Items.Insert(0, numbers[0]);
            comboBox2.Items.Insert(0, 6);
            if (numbers[0]%2 == 0)
            {
                comboBox3.Items.Insert(0, (numbers[0]/2));
            }
            else
            {
                comboBox3.Items.Insert(0, 3);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedValue1 = (int)comboBox1.SelectedItem;
            int selectedValue2 = (int)comboBox2.SelectedItem;
            int selectedValue3 = (int)comboBox3.SelectedItem;
            int max = selectedValue1;
            if (selectedValue2 > max)
            {
                max = selectedValue2;
            }
            if (selectedValue3 > max)
            {
                max = selectedValue3;
                
            }
            Console.WriteLine("Максимальное число: " + max);

        }

       
    }
}
