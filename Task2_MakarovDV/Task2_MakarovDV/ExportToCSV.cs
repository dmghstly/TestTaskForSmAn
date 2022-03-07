using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2_MakarovDV
{
    public partial class ExportToCSV : Form
    {
        private DataTable data;

        // Проверка данных
        private void TextBoxCheck()
        {
            if (FileName.Text == "" || FileName.Text == null ||
                path.Text == "" || path.Text == null)
                Export.Enabled = false;
            else
                Export.Enabled = true;
        }

        // Собирание данных
        private void CollectData()
        {
            string sqlCommand = "SELECT * FROM " + AllData.CurrentTable.TableName;
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=" +
                AllData.CurrentDB.DBName + ";Trusted_Connection=True";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand, connectionString);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            data = new DataTable
            {
                Locale = CultureInfo.InvariantCulture
            };
            dataAdapter.Fill(data);
        }

        // Экспорт в CSV
        private void ToCSV(string strFilePath)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);
            //headers    
            for (int i = 0; i < data.Columns.Count; i++)
            {
                sw.Write(data.Columns[i]);
                if (i < data.Columns.Count - 1)
                    sw.Write(AllData.DataTypes.DevideEls[DevideElem.Text]);
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in data.Rows)
            {
                for (int i = 0; i < data.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < data.Columns.Count - 1)
                    {
                        sw.Write(AllData.DataTypes.DevideEls[DevideElem.Text]);
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }

        public ExportToCSV()
        {
            InitializeComponent();
            path.Enabled = false;
            DevideElem.DropDownStyle = ComboBoxStyle.DropDownList;
            CollectData();
            TextBoxCheck();
        }

        // Назад
        private void Back_Click(object sender, EventArgs e)
        {
            MainOperatingWindow main = new MainOperatingWindow();
            main.Show();
            this.Close();
        }

        // Проверка данных
        private void FileName_TextChanged(object sender, EventArgs e)
        {
            TextBoxCheck();
        }

        // Проверка данных
        private void path_TextChanged(object sender, EventArgs e)
        {
            TextBoxCheck();
        }

        // Выбор директории
        private void FindDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                path.Text = dialog.SelectedPath;
        }

        // Обработка кнопки Экспорта
        private void Export_Click(object sender, EventArgs e)
        {
            ToCSV(path.Text + "\\" + FileName.Text + ".csv");
            MainOperatingWindow main = new MainOperatingWindow();
            main.Show();
            this.Close();
        }
    }
}
