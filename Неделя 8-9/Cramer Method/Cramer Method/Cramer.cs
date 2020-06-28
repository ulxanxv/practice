using System;
using System.Data;
using System.Windows.Forms;

namespace Cramer_Method {
    public partial class Cramer : Form {

        public Cramer() {
            InitializeComponent();

            createColumn();

            // Запрет на создание новых строк
            linearSystem.AllowUserToAddRows = false;

            // Обработка события изменения размерности уравнения
            amountEquation.ValueChanged += AmountEquation_ValueChanged;

            // Обработка неправильного ввода
            linearSystem.DataError += LinearSystem_DataError;

            // Обработка кнопки решения
            solveButton.Click += SolveButton_Click;

            // Кнопка сброса результата
            resetResult.Click += ResetResult_Click;

            // Кнопка сброса систем уравнений
            resetEquation.Click += ResetEquation_Click;
        }
        
        private void SolveButton_Click(object sender, EventArgs e) {
            startCount();
        }

        private void AmountEquation_ValueChanged(object sender, EventArgs e) {
            createColumn();
        }

        private void ResetEquation_Click(object sender, EventArgs e) {
            createColumn();
        }

        private void ResetResult_Click(object sender, EventArgs e) {
            roots.DataSource = null;
            roots.Refresh();
        }

        /// <summary>
        /// Заполнений матриц
        /// </summary>
        private void startCount() {
            int         dimension = Convert.ToInt32(amountEquation.Value);
            Matrix[]    matrices = new Matrix[dimension + 1];

            if (!checkFields()) {
                MessageBox.Show("Некоторые поля в системе уравнений не заполнены", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Инициализация массива
            for (int i = 0; i <= dimension; ++i) {
                matrices[i] = new Matrix(dimension);
            }

            // Заполнение главной матрицы
            matrices[0].fillMatrix(linearSystem);

            // Заполнение второстепенных матриц
            for (int i = 1; i <= dimension; ++i) {
                matrices[i].fillMatrix(linearSystem, matrices[0].getMatrix, i - 1);
            }

            countRoots(matrices);
        }

        /// <summary>
        /// Подсчет корней
        /// </summary>
        private void countRoots(Matrix[] matrices) {
            roots.Columns.Clear();

            DataTable   dataTable = new DataTable();
            double      mainDet = matrices[0].getDeterminant();

            // Детерминант главной матрицы не может быть равен нулю
            if (mainDet == 0) {
                MessageBox.Show("Детерминант главной матрицы равен нулю.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Вывод в DataGridView — roots
            dataTable.Columns.Add("x", typeof(string));
            dataTable.Columns.Add("answer", typeof(double));
            for (int i = 1; i <= amountEquation.Value; ++i) {
                double secDet = matrices[i].getDeterminant();
                dataTable.Rows.Add("x" + (i), secDet == 0 ? 0 : secDet / mainDet);
            }

            roots.DataSource = dataTable;
        }

        /// <summary>
        /// Создание нужного количества столбцов и строк в поле для систем уравнений
        /// </summary>
        private void createColumn() {
            DataTable data = new DataTable();

            // Очистка всех столбцов
            linearSystem.Columns.Clear();

            // Добавление
            for (int i = 0; i < amountEquation.Value; ++i) {
                data.Columns.Add("a_" + i.ToString(), typeof(int));
                data.Rows.Add();
            }

            data.Columns.Add("equals", typeof(int));

            // Смена источника данных
            linearSystem.DataSource = data;
        }

        /// <summary>
        /// Проверка на зполнение всех полей
        /// </summary>
        private bool checkFields() {
            int dimension = Convert.ToInt32(amountEquation.Value);

            for (int i = 0; i < dimension; ++i) {
                for (int j = 0; j < dimension; ++j) {
                    if (linearSystem.Rows[i].Cells[j].Value.ToString() == "") {
                        return false;
                    }
                }
            }

            return true;
        }

        private void LinearSystem_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            MessageBox.Show("Вы пытаетесь ввести некорректные данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
