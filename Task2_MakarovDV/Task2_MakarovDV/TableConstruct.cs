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
    public partial class TableConstruct : Form
    {
        // Проверка текста
        private void TextCheck()
        {
            if (TableName.Text == " " || TableName.Text == "")
            {
                Save.Enabled = false;
            }
            else
            {
                Save.Enabled = true;
            }
        }

        // Проверка доступности кнопок
        private void ButtonsCheck()
        {
            if (AllData.CurrentTable.AllColumns.Count != 0 && Columns.SelectedItems.Count == 1)
            {
                Change.Enabled = true;
                Delete.Enabled = true;
            }
            else
            {
                Change.Enabled = false;
                Delete.Enabled = false;
            }
        }

        // Высплывающие подсказки
        private void Tips()
        {
            ToolTip toolTip = new ToolTip();

            toolTip.AutoPopDelay = 4000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            // Подсказки для работы с полями
            toolTip.SetToolTip(Add, "Создание нового поля.");
            toolTip.SetToolTip(Change, "Редактирование поля.");
            toolTip.SetToolTip(Delete, "Удаление поля из текущей таблицы.");
            toolTip.SetToolTip(TableName, "Вводить можно только латинские букы и цифры. \n" +
                "При попытке создания или изменения имени уже существующей таблицы высветится предупреждение.");
            toolTip.SetToolTip(Columns, "Для работы с полем необходимо выбрать его.");
            toolTip.SetToolTip(Save, "Сохранение имени. \n" +
                "При создании новой таблицы после созранения откроется пространство для работы с полями. \n" +
                "Также автоматически создается поле id для новой таблицы.");
            toolTip.SetToolTip(Back, "Возвращает обратно.");
        }

        // Вставка данных
        private void DataInsert()
        {
            Columns.Items.Clear();
            TableName.Text = AllData.CurrentTable.TableName;
            int i = 0;
            foreach (AllData.CurrentColumn el in AllData.CurrentTable.AllColumns)
            {
                Columns.Items.Insert(i, el.ColumnName);
                i++;
            }               
        }

        public TableConstruct()
        {
            InitializeComponent();
            Tips();            
            DataInsert();
            ButtonsCheck();
            TextCheck();           
            if (Program.TableMode == 1)
                groupBox1.Visible = false;
        }

        // Ввод латиницы и цифр
        private void TableName_KeyPress(object sender, KeyPressEventArgs e)
        {
            int c = (int)e.KeyChar;
            if (!((c >= 65 && c <= 90) || (c >= 97 && c <= 122) || c == 8 || c == 46 || Char.IsDigit(e.KeyChar)))
                e.Handled = true;
        }

        // Сохранение всего
        private void Save_Click(object sender, EventArgs e)
        {
            if (AllData.IdentityCheck.MainCheck(1, (TableName.Text).Replace(' ', '_')))
            {
                if (Program.TableMode == 0)
                    AllData.ChangeTable.TableNameChange((TableName.Text).Replace(' ', '_'));
                else
                    AllData.ChangeTable.CreateNewTable((TableName.Text).Replace(' ', '_'));
                AllData.CurrentTable.TableName = (TableName.Text).Replace(' ', '_');
                AllData.DataAddjustmentTypes.CurrentTableAddjustment((TableName.Text).Replace(' ', '_'));
                DataInsert();
                groupBox1.Visible = true;
            }
            else
            {
                MessageBox.Show("Такая таблица в текущей БД уже существует. " +
                    "Выберете другое имя для вашей таблицы.",
                    "Повтор имени", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Проверка списка
        private void Columns_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonsCheck();
        }

        // Проверка имени таблицы
        private void TableName_TextChanged(object sender, EventArgs e)
        {
            TextCheck();
        }

        // Изменить столбец
        private void Change_Click(object sender, EventArgs e)
        {
            AllData.DataAddjustmentTypes.CurrentColumnAddjustment(Columns.SelectedItem.ToString());
            ColumnConstruct column = new ColumnConstruct();
            column.Show();
            this.Close();
        }

        // Удалить столбец
        private void Delete_Click(object sender, EventArgs e)
        {
            AllData.DataAddjustmentTypes.CurrentColumnAddjustment(Columns.SelectedItem.ToString());
            AllData.ChangeTable.DeleteColumn();
            AllData.CurrentTable.GetColumns();
            DataInsert();
            ButtonsCheck();
        }

        // Вернуться обратно
        private void Back_Click(object sender, EventArgs e)
        {
            MainOperatingWindow main = new MainOperatingWindow();
            main.Show();
            this.Close();
        }

        // Добавить столбец
        private void Add_Click(object sender, EventArgs e)
        {
            AllData.DataAddjustmentTypes.NewColumnCreation();
            ColumnConstruct column = new ColumnConstruct();
            column.Show();
            this.Close();
        }
    }
}
