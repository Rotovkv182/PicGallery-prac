using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicGallery
{
    public partial class afishaform : Form
    {
        public afishaform()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;user id=root;database=pg_afisha;password=root;"); // подключение к бд
        private void afishaform_Load(object sender, EventArgs e)
        {
            dgvData();
        }
        public void dgvData()
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT id as id, date as Дата, name as Название_выставки, time as Время_проведения, genre as Жанр FROM `afisha`", connection);
            adp.Fill(table); // заполняем таблицу
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = table;
        }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public void executeMyQuery(string query) // метод выполнения запросов
        {
            try
            {
                openConnection();
                MySqlCommand command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запрос выполнен");
                }
                else
                {
                    MessageBox.Show("Запрос не выполнен");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            tb_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_date.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_name.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tb_time.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_genre.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string insertQuery = $"INSERT INTO `afisha`(`date`, `name`, `time`, `genre`) VALUES ('{tb_date.Text}', '{tb_name.Text}', '{tb_time.Text}', '{tb_genre.Text}')";
            executeMyQuery(insertQuery);
            dgvData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string deleteQuery = $"DELETE FROM `afisha` WHERE id = '{tb_id.Text}'";
            executeMyQuery(deleteQuery);
            dgvData();
        }

        private void btn_upd_Click(object sender, EventArgs e)
        {
            string updateQuery = $"UPDATE `afisha` SET date ='{tb_date.Text}', name ='{tb_name.Text}', time ='{tb_time.Text}', genre ='{tb_genre.Text}' WHERE id = '{tb_id.Text}' ";
            executeMyQuery(updateQuery);
            dgvData();
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }
    }
}
