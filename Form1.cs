using System;
using System.Windows.Forms;



namespace Matrix_Calc
{
    public partial class Form1 : Form
    {

    #region Объявление общих переменных

        int n = 0;
        int i = 0;
        int j = 0;
        int k = 0;
        int q = 0;
        int p = 0;
        int r = 0;
        int s = 0;
        decimal a = 0;
        int b = 0;
        int c = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        #endregion

    #region Начальный вид формы

        private void Form1_Load(object sender, EventArgs e)
        {
            button6.Hide();
            button8.Hide();
            panel3.Hide();
            dataGridView1.Hide();
            dataGridView2.Hide();
            Ans_Grid.Hide();
        }

    #endregion

    #region Кнопки Матрицы 1

        #region Создание формы матрицы
        public void btn_createMatrix_Click(object sender, EventArgs e)
        {
            //Анализируем ввод данных
            if (txt_Row1.Text != "" & txt_Columns.Text != "")
            {
                //Проверяем введённые значения строк
                try
                {
                    dataGridView1.RowCount = Convert.ToInt32(txt_Row1.Text);
                    dataGridView1.ColumnCount = Convert.ToInt32(txt_Columns.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Некорректные значения!");
                    button6.Hide();
                    dataGridView1.Hide();
                    dataGridView1.Rows.Clear();
                    panel3.Hide();
                    return;
                }

                //Создаём строки
                q = dataGridView1.RowCount;
                dataGridView1.AutoResizeRows();

                //Создаём столбцы
                p = dataGridView1.ColumnCount;
                dataGridView1.AutoResizeColumns();

                //Показываем кнопки
                button6.Show();
                dataGridView1.Show();
            }
            else
                MessageBox.Show("Задайте размер матрицы!");

        }
        #endregion

        #region Транспонирование
        private void button6_Click(object sender, EventArgs e)
        {
            //Запихиваем всё в 1-ую матрицу
            double[,] Matrix1 = new double[dataGridView1.RowCount, dataGridView1.ColumnCount];
            try
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        //Преобразуем значения из ячеек в числа и пишем в массив
                        //Если не число то происходит вызов исключения и его обработка
                        Matrix1[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                    }
                }

                //Создаём транпонированную матрицу
                double[,] Matrix1Trans = new double[Matrix1.GetLength(1), Matrix1.GetLength(0)];
                //GetLength(1) возвращает кол-во столбцов , а GetLength(0) - кол-во строк
                for (int x = 0; x < Matrix1.GetLength(1); x++)
                {
                    for (int y = 0; y < Matrix1.GetLength(0); y++)
                    {
                        Matrix1Trans[x, y] += Matrix1[y, x];
                    }
                }

                //Генерируем форму для транспонированной матрицы
                dataGridView1.Rows.Clear();
                //Создаём строки
                dataGridView1.RowCount = Matrix1Trans.GetLength(0);
                dataGridView1.AutoResizeRows();
                //Создаём столбцы
                dataGridView1.ColumnCount = Matrix1Trans.GetLength(1);
                p = dataGridView1.ColumnCount;
                dataGridView1.AutoResizeColumns();
                //Показываем форму
                dataGridView1.Show();

                //Заполняем форму
                for (i = 0; i < Matrix1Trans.GetLength(0); ++i)
                {
                    for (j = 0; j < Matrix1Trans.GetLength(1); ++j)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = Matrix1Trans[i, j];
                    }
                }

            }
            catch (System.FormatException)
            {
                MessageBox.Show("Некорректный тип данных!");
                return;
            }
        }
        #endregion

    #endregion

    #region Кнопки Матрицы 2

        #region Создание формы матрицы
        private void button5_Click(object sender, EventArgs e)
        {
            //Анализируем ввод данных
            if (txt_row2.Text != "" & txt_Col2.Text != "")
            {
                //Проверяем введённые значения строк
                try
                {
                    dataGridView2.RowCount = Convert.ToInt32(txt_row2.Text);
                    dataGridView2.ColumnCount = Convert.ToInt32(txt_Col2.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Некорректные значения!");
                    button8.Hide();
                    dataGridView2.Hide();
                    dataGridView2.Rows.Clear();
                    panel3.Hide();
                    return;
                }

                //Создаём строки
                r = dataGridView2.RowCount;
                dataGridView2.AutoResizeRows();

                //Создаём столбцы
                s = dataGridView2.ColumnCount;
                dataGridView2.AutoResizeColumns();

                //Показываем кнопки
                button6.Show();
                dataGridView2.Show();
                panel3.Show();
                button8.Show();
            }
            else
                MessageBox.Show("Задайте размер матрицы!");
        }

        #endregion

        #region Транспонирование
        private void button8_Click(object sender, EventArgs e)
        {
            //Запихиваем всё во 2-ую матрицу
            double[,] Matrix2 = new double[dataGridView2.RowCount, dataGridView2.ColumnCount];
            try
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        //Преобразуем значения из ячеек в числа и пишем в массив
                        //Если не число то происходит вызов исключения и его обработка
                        Matrix2[i, j] = Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value);
                    }
                }

                //Создаём транпонированную матрицу
                double[,] Matrix2Trans = new double[Matrix2.GetLength(1), Matrix2.GetLength(0)];
                //GetLength(1) возвращает кол-во столбцов , а GetLength(0) - кол-во строк
                for (int x = 0; x < Matrix2.GetLength(1); x++)
                {
                    for (int y = 0; y < Matrix2.GetLength(0); y++)
                    {
                        Matrix2Trans[x, y] += Matrix2[y, x];
                    }
                }

                //Генерируем форму для транспонированной матрицы
                dataGridView2.Rows.Clear();
                //Создаём строки
                dataGridView2.RowCount = Matrix2Trans.GetLength(0);
                dataGridView2.AutoResizeRows();
                //Создаём столбцы
                dataGridView2.ColumnCount = Matrix2Trans.GetLength(1);
                s = dataGridView2.ColumnCount;
                dataGridView2.AutoResizeColumns();
                //Показываем форму
                dataGridView2.Show();

                //Заполняем форму
                for (i = 0; i < Matrix2Trans.GetLength(0); ++i)
                {
                    for (j = 0; j < Matrix2Trans.GetLength(1); ++j)
                    {
                        dataGridView2.Rows[i].Cells[j].Value = Matrix2Trans[i, j];
                    }
                }

            }
            catch (System.FormatException)
            {
                MessageBox.Show("Некорректный тип данных!");
                return;
            }
        }
        #endregion

    #endregion

    #region Кнопки операций

        #region Умножение
        private void button7_Click(object sender, EventArgs e)
        {
            double[,] Matrix1 = new double[dataGridView1.RowCount, dataGridView1.ColumnCount];
            double[,] Matrix2 = new double[dataGridView2.RowCount, dataGridView2.ColumnCount];
            try
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        //Преобразуем значения из ячеек в числа и пишем в массив
                        //Если не число то происходит вызов исключения и его обработка
                        Matrix1[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                    }
                }
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        //Преобразуем значения из ячеек в числа и пишем в массив
                        //Если не число то происходит вызов исключения и его обработка
                        Matrix2[i, j] = Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный тип данных!");
                return;
            }

            //Проверяем равность столбцов 1 матрицы строкам 2 матрицы
            if (Matrix1.GetLength(1) == Matrix2.GetLength(0))
            {
                //Генерируем форму матрицы-результата
                double[,] MatrixResult = new double[Matrix1.GetLength(0), Matrix2.GetLength(1)];
                Ans_Grid.RowCount = dataGridView1.RowCount;
                Ans_Grid.ColumnCount = dataGridView2.ColumnCount;
                Ans_Grid.AutoResizeColumns();

                //производим умножение элементов
                try
                {
                    for (int i = 0; i < Matrix1.GetLength(0); i++)
                    {
                        // Идём по столбцам 2 матрицы
                        for (int j = 0; j < Matrix2.GetLength(1); j++)
                        {
                            //Идём по строкам 2 матрицы
                            for (int k = 0; k < Matrix2.GetLength(0); k++)
                            {
                                MatrixResult[i, j] += Matrix1[i, k] * Matrix2[k, j];
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректный тип данных!");
                    Ans_Grid.Hide();
                    return;
                }

                //Показываем результат при удачном исходе
                for (i = 0; i < MatrixResult.GetLength(0); i++)
                {
                    for (j = 0; j < MatrixResult.GetLength(1); j++)
                    {
                        Ans_Grid.Rows[i].Cells[j].Value = MatrixResult[i, j];
                    }
                }
                Ans_Grid.Show();

                //и расширяем по размеру
                for (int ansco = 1; ansco <= s; ansco++)
                Ans_Grid.Columns[ansco - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            else
            {
                MessageBox.Show("Количество столбцов 1-ой матрицы должно быть равно количеству строк 2-ой матрицы!");
                Ans_Grid.Hide();
                return;
            }
        }
        #endregion

        #region Сложение
        private void btn_plus_Click(object sender, EventArgs e)
        {
            //Проверяем равность строк и столбцов
            if ((dataGridView1.RowCount == dataGridView2.RowCount) & (dataGridView1.ColumnCount == dataGridView2.ColumnCount))
            {
                //Генерируем форму матрицы-результата
                Ans_Grid.RowCount = dataGridView1.RowCount;
                Ans_Grid.ColumnCount = dataGridView1.ColumnCount;
                Ans_Grid.AutoResizeColumns();
                Ans_Grid.AutoResizeRows();
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        //R1 - это будет номер строки
                        int R1 = row.Index;
                        {
                            //идём по строкам 2 матрицы
                            for (c = 0; c < dataGridView2.RowCount; c++)
                            {
                                //идём по столбцам 2 матрицы
                                for (b = 0; b < dataGridView2.ColumnCount; b++)
                                {
                                    decimal D = Convert.ToDecimal(dataGridView1.Rows[R1].Cells[b].Value);
                                    decimal E = Convert.ToDecimal(dataGridView2.Rows[R1].Cells[b].Value);
                                    decimal A = D + E;
                                    Ans_Grid.Rows[R1].Cells[b].Value = A;
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректный тип данных!");
                    Ans_Grid.Hide();
                    return;
                }

                //Показываем результат при удачном исходе
                Ans_Grid.Show();
            }
            else
            {
                MessageBox.Show("Складывать можно только матрицы одинакового размера!");
                Ans_Grid.Hide();
                return;
            }
        }
        #endregion

        #region Вычитание
        private void btn_Minus_Click(object sender, EventArgs e)
        {
            //Проверяем равность строк и столбцов
            if ((dataGridView1.RowCount == dataGridView2.RowCount) & (dataGridView1.ColumnCount == dataGridView2.ColumnCount))
            {
                //Генерируем форму матрицы-результата
                Ans_Grid.RowCount = dataGridView1.RowCount;
                Ans_Grid.ColumnCount = dataGridView1.ColumnCount;
                Ans_Grid.AutoResizeColumns();
                Ans_Grid.AutoResizeRows();
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        int R1 = row.Index;
                        {
                            //Идём по строкам 2 матрицы
                            for (c = 0; c < dataGridView2.RowCount; c++)
                            {
                                //Идём по столбцам 2 матрицы
                                for (b = 0; b < dataGridView2.ColumnCount; b++)
                                {
                                    decimal D = Convert.ToDecimal(dataGridView1.Rows[R1].Cells[b].Value);
                                    decimal E = Convert.ToDecimal(dataGridView2.Rows[R1].Cells[b].Value);
                                    decimal A = D - E;
                                    Ans_Grid.Rows[R1].Cells[b].Value = A;
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректный тип данных!");
                    Ans_Grid.Hide();
                    return;
                }

                //Показываем результат при удачном исходе
                Ans_Grid.Show();
            }
            else
            {
                MessageBox.Show("Вычитать можно только матрицы одинакового размера!");
                Ans_Grid.Hide();
                return;
            }
        }
        #endregion

        #region Очистка ВСЕХ форм
        private void btn_clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
            Ans_Grid.Columns.Clear();
            button6.Hide();
            button8.Hide();
            panel3.Hide();
            dataGridView1.Hide();
            dataGridView2.Hide();
            Ans_Grid.Hide();
        }
        #endregion

    #endregion

    #region Автоматическое масштабирование клеток при изменении значений
            private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int co = 1; co <= p; co++)
                
           dataGridView1.Columns[co-1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;  
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int co2 = 1; co2 <= s; co2++)
                dataGridView2.Columns[co2 - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        #endregion

    

    }
}
