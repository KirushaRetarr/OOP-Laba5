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
            int[,] matrix = { { 5, 1, -2, -5 }, { 6, -4, -5, 8 } };
            int product = 1;

            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                for (int j = 0; j < matrix.GetLength(1); j++) 
                {
                    if (matrix[i, j] > 0) 
                    {
                        product *= matrix[i, j];
                    }
                }
            }
            textBox1.Text = product.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] matrix = { { 5, 1, -2, -5 }, { 6, -4, -5, 8 } };

            dataGridView1.ColumnCount = matrix.GetLength(1); 
            dataGridView1.RowCount = matrix.GetLength(0); 

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }
    }
}
