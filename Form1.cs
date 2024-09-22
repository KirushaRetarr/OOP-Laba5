using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_Laba5
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rows = comboBox1.SelectedIndex + 1;
            int cols = comboBox1.SelectedIndex + 1;

            int[,] array = GenerateRandomArray(rows, cols);

            DisplayArrayInGrid(array, rows, cols);

            textBox1.Clear();

            for (int i = 0; i < rows; i++)
            {
                bool negativeFlag = false;
                int multi = 1;

                for (int j = 0; j < cols; j++)
                {
                    if (array[i, j] < 0)
                    {
                        negativeFlag = true;
                        break;
                    }         
                }
                if (!negativeFlag)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        multi *= array[i, j];
                    }
                    textBox1.AppendText($"Произведение в строке {i + 1}: {multi}\r\n");
                }
                else 
                {
                    textBox1.AppendText($"В строке {i + 1} есть отрицательные элементы.\r\n");
                }
            }
        }

        private int[,] GenerateRandomArray(int rows, int cols)
        {
            int[,] array = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = random.Next(-10, 10);
                }
            }
            return array;
        }

        private void DisplayArrayInGrid(int[,] array, int rows, int cols)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            for (int i = 0; i < rows; i++)
            {
                dataGridView1.Columns.Add($"Col{i}", $"Столбец {i + 1}");
            }

            for (int i = 0; i < rows; i++)
            {
                string[] rowValues = new string[cols];
                for (int j = 0; j < cols; j++)
                {
                    rowValues[j] = array[i, j].ToString();
                }
                dataGridView1.Rows.Add(rowValues);
            }
        }
    }
}
