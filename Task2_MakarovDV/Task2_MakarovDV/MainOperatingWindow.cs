using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2_MakarovDV
{
    public partial class MainOperatingWindow : Form
    {
        // Адаптер для работы с данными
        private SqlDataAdapter dataAdapter;

        // Проверка доступности кнопок первой группы
        private void ButtonsCheckGroup1()
        {
            if (AllData.CurrentDB.AllTables.Count == 0)
            {
                EditTable.Enabled = false;
                DeleteTable.Enabled = false;
                ToCSV.Enabled = false;
            }
            else
            {
                EditTable.Enabled = true;
                DeleteTable.Enabled = true;
                ToCSV.Enabled = true;
            }
        }

        // Проверка на необходимость редактирования данных
        private void ButtonsCheckGroup2()
        {
            AllData.CurrentTable.GetColumns();
            if (AllData.CurrentTable.AllColumns.Count == 0)
            {
                EditData.Enabled = false;
            }
            else
                EditData.Enabled = true;
        }

        // Высплывающие подсказки
        private void Tips()
        {
            ToolTip toolTip = new ToolTip();

            toolTip.AutoPopDelay = 4000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            // Подсказки для работы с таблицами
            toolTip.SetToolTip(NewTable, "Создаёт новую таблицу в текщей БД.");
            toolTip.SetToolTip(EditTable, "Просмотр и редактирование данных выбранной таблицы.");
            toolTip.SetToolTip(DeleteTable, "Удаление таблицы из текущей БД.");

            // Подсказки для редактирования таблицы
            toolTip.SetToolTip(EditTable, "Просмотр и редактирование данных выбранной таблицы.");
            toolTip.SetToolTip(DeleteTable, "Удаление таблицы из текущей БД.");

            // Подсказки для редактирования данных
            toolTip.SetToolTip(EditTable, "Просмотр и редактирование данных выбранной таблицы.");
            toolTip.SetToolTip(DeleteTable, "Удаление таблицы из текущей БД.");
        }

        public MainOperatingWindow()
        {
            InitializeComponent();
            Tips();
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            AllData.CurrentDB.GetTables();
            ButtonsCheckGroup1();
            SelectTable.DataSource = AllData.CurrentDB.AllTables;
            SelectTable.DropDownStyle = ComboBoxStyle.DropDownList;
            dataAdapter = new SqlDataAdapter();
        }

        // Создание БД
        private void новваяБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBCreation dBCreation = new DBCreation();
            dBCreation.Show();
            this.Close();
        }

        // Окрытие БД
        private void открытьБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBOpening dBOpening = new DBOpening();
            dBOpening.Show();
            this.Close();
        }

        // Новая таблица
        private void NewTable_Click(object sender, EventArgs e)
        {
            AllData.DataAddjustmentTypes.NewTableCreation();
            TableConstruct table = new TableConstruct();
            table.Show();
            this.Close();
        }

        // Редактирование таблицы
        private void EditTable_Click(object sender, EventArgs e)
        {
            AllData.DataAddjustmentTypes.CurrentTableAddjustment(SelectTable.Text);
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
            ButtonsCheckGroup2();
            groupBox3.Text = "Таблица: " + SelectTable.Text;
        }

        // Удаление таблицы
        private void DeleteTable_Click(object sender, EventArgs e)
        {
            AllData.ChangeTable.DeleteTable(SelectTable.Text);
            AllData.CurrentDB.GetTables();
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            ButtonsCheckGroup1();
            SelectTable.DataSource = AllData.CurrentDB.AllTables;
            SelectTable.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void TableStructure_Click(object sender, EventArgs e)
        {
            TableConstruct table = new TableConstruct();
            table.Show();
            this.Close();
        }
        
        // Привязка данных к DataGridView
        private void GetData(string selectCommand)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=" +
                AllData.CurrentDB.DBName + ";Trusted_Connection=True";
            
            dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            DataTable table = new DataTable
            {
                Locale = CultureInfo.InvariantCulture
            };
            dataAdapter.Fill(table);
            bindingSource1.DataSource = table;

            TableData.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        // Работа с данными
        private void EditData_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;        
            TableData.DataSource = bindingSource1;
            GetData("SELECT * FROM " + AllData.CurrentTable.TableName);
        }

        // Сохранение изменений
        private void SaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                dataAdapter.Update((DataTable)bindingSource1.DataSource);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Были обнаружены ошибки в соблюдении ввода данных." +
                    "Возможно это связано с тем, что были нарушены условия ключевых полей. \n" +
                    "Полный текст ошибки: " + ex.Message,
                     "Неверный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Сброс данных
        private void DataUpdate_Click(object sender, EventArgs e)
        {
            GetData(dataAdapter.SelectCommand.CommandText);
        }

        // Реагирование на ошибки ввода
        private void TableData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;

            MessageBox.Show("Error with " +
                TableData.Columns[e.ColumnIndex].HeaderText +
                "\n\n" + e.Exception.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            e.Cancel = false;
        }

        private void ToCSV_Click(object sender, EventArgs e)
        {
            AllData.DataAddjustmentTypes.CurrentTableAddjustment(SelectTable.Text);
            ExportToCSV export = new ExportToCSV();
            export.Show();
            this.Close();
        }
    }
}
