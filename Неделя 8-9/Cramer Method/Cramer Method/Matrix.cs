using System;
using System.Windows.Forms;

namespace Cramer_Method {
    class Matrix {

        private int[,] matrix;

        public Matrix() {}

        public Matrix(int dimension) {
            this.matrix = new int[dimension, dimension];
        }

        /// <summary>
        /// Получить матрицу из класса
        /// </summary>
        public int[,] getMatrix { get => matrix; }

        /// <summary>
        /// Получение детерминанта матрицы
        /// </summary>
        public double getDeterminant() {
            return countDeterminant(matrix, matrix.GetLength(0));
        }

        /// <summary>
        /// Заполненение первичной матрицы
        /// </summary>
        public void fillMatrix(DataGridView data) {
            for (int i = 0; i < matrix.GetLength(0); ++i) {
                for (int j = 0; j < matrix.GetLength(1); ++j) {
                    matrix[i, j] = Convert.ToInt32(data.Rows[i].Cells[j].Value.ToString());
                }
            }
        }

        /// <summary>
        /// Заполнение вторичной матрицы
        /// </summary>
        public void fillMatrix(DataGridView data, int[,] originalArray, int whichColumn) {
            matrix = (int[,])originalArray.Clone();

            for (int i = 0; i < matrix.GetLength(0); ++i) {
                matrix[i, whichColumn] = Convert.ToInt32(data.Rows[i].Cells[matrix.GetLength(0)].Value.ToString());
            }
        }

        /// <summary>
        /// Рекурсивный подсчет детерминанта матрицы
        /// </summary>
        /// <returns>Детерминант</returns>
        private double countDeterminant(int[,] localMatrix, int length) {
            double determinant = 0;

            if (length == 1) {
                return (localMatrix[0, 0]);
            }

            for (int i = 0; i < length; i++) {
                determinant += Math.Pow(-1.0, (i + 1)) * localMatrix[i, 0] * countDeterminant(getNewMatrix(localMatrix, length, i), length - 1);
            }

            return determinant;
        }

        /// <summary>
        /// Нужно для рекурсивной функции
        /// </summary>
        private int[,] getNewMatrix(int[,] localMatrix, int length, int row) {
            int[,] newMatrix = new int[length, length];

            for (int k, i = 0, l = 0; i < (length - 1); i++) {
                k = 1;

                if (l == row) {
                    l++;
                }

                for (int j = 0; j < (length - 1); j++) {
                    newMatrix[i, j] = localMatrix[l, k];
                    k++;
                }

                l++;
            }

            return newMatrix;
        }

    }
}
