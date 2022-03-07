using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2_MakarovDV
{
    public partial class DBOpening : Form
    {
        // Высплывающие подсказки
        private void Tips()
        {
            ToolTip toolTip = new ToolTip();

            toolTip.AutoPopDelay = 4000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(SelectDB, "Выберете БД из списка.");
            toolTip.SetToolTip(Open, "Открывает выбранную БД.");
        }

        // Проверка наличия баз данных
        private void CheckDBs()
        {
            if (AllData.AllDBsChange.AllDBs.Count == 0)
            {
                Open.Enabled = false;
                MessageBox.Show("На данный момент не существует БД. " +
                    "Для начала создайте первую БД, нажав на начальном экране кнопку 'Создать БД'.",
                    "Нет БД", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }               
            else
                Open.Enabled = true;
        }

        public DBOpening()
        {
            InitializeComponent();
            AllData.AllDBsChange.ReadDB();
            SelectDB.DataSource = AllData.AllDBsChange.AllDBs;
            SelectDB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // Открытие БД
        private void Open_Click(object sender, EventArgs e)
        {
            AllData.CurrentDB.DBName = (SelectDB.Text).Replace(' ', '_');
            MainOperatingWindow main = new MainOperatingWindow();
            main.Show();
            this.Close();
        }

        private void DBOpening_Load(object sender, EventArgs e)
        {
            CheckDBs();
        }
    }
}
