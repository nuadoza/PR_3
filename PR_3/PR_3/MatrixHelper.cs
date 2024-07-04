using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_3
{
    internal class MatrixHelper<T>
    {
        /// <summary>
        /// Проверяет и создаёт матрицу на основе введённых пользователем данных.
        /// </summary>
        public static bool CreateMatrix(DataGridView dataGridView, TextBox txtRows, TextBox txtCols, out string errorMessage)
        {
            int rowCount;
            int colCount;
            errorMessage = null;

            if (!Int32.TryParse(txtRows.Text, out rowCount) || !Int32.TryParse(txtCols.Text, out colCount) || rowCount <= 0 || colCount <= 0)
            {
                errorMessage = "Введите положительные целочисленные значения для размеров матрицы.";
                return false;
            }

            dataGridView.RowCount = rowCount;
            dataGridView.ColumnCount = colCount;
            return true;
        }
        /// <summary>
        /// Подсчитывает количество отрицательных элементов в матрице.
        /// </summary>
        public static int CountNegativeElements(T[,] matrix)
        {
            int count = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool hasZero = false;
                int negativeCountInRow = 0;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // Для обобщённого класса нельзя прямо сравнивать с нулём или отрицательным значением,
                    // поэтому используем операторы сравнения для числовых типов
                    if (Comparer<T>.Default.Compare(matrix[i, j], default(T)) == 0)
                    {
                        hasZero = true;
                    }
                    if (Comparer<T>.Default.Compare(matrix[i, j], default(T)) < 0)
                    {
                        negativeCountInRow++;
                    }
                }
                if (hasZero)
                {
                    count += negativeCountInRow;
                }
            }
            return count;
        }
    }
}


