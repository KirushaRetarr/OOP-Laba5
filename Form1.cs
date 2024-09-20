using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Laba5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] nums2 = { { 5, 1, -2, -5 }, { 6, -4, -5, 8 } };
            int product = 1; // Инициализация произведения

            // Перебор элементов массива
            for (int i = 0; i < nums2.GetLength(0); i++) // Перебор строк
            {
                for (int j = 0; j < nums2.GetLength(1); j++) // Перебор столбцов
                {
                    if (nums2[i, j] > 0) // Проверка на положительность
                    {
                        product *= nums2[i, j]; // Умножаем положительное число
                    }
                }
            }
            textBox1.Text = product.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] nums2 = { { 5, 1, -2, -5 }, { 6, -4, -5, 8 } };

            // Настройка DataGridView
            dataGridView1.ColumnCount = nums2.GetLength(1); // Устанавливаем количество колонок
            dataGridView1.RowCount = nums2.GetLength(0); // Устанавливаем количество строк

            // Заполнение DataGridView
            for (int i = 0; i < nums2.GetLength(0); i++)
            {
                for (int j = 0; j < nums2.GetLength(1); j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = nums2[i, j]; // Заполняем значение
                }
            }
        }
    }
}
