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
    public partial class ColumnConstruct : Form
    {
        // Проверка текста
        private void TextCheck()
        {
            if (ColumnName.Text == " " || ColumnName.Text == "")
            {
                Save.Enabled = false;
            }
            else
            {
                Save.Enabled = true;
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
            toolTip.SetToolTip(ColumnName, "Имя поля.");
            toolTip.SetToolTip(TypeName, "Выбрать тип данных. \n" +
                "Для избежания проблем с типами данных запрещено при редоктировании поля менять его тип. \n" +
                "Альтернативой может стать пересоздание поля заново с удалением текущего.");
            toolTip.SetToolTip(IsPrimaryKey, "Является ли поле первичным ключом. \n" +
                "Если поле не доступно значит данные, содержащиеся в этом столбце не соответствуют: \n" +
                "Без значений 'null' и без повоторений данных.");
            toolTip.SetToolTip(Abort, "Отмена изменений.");
            toolTip.SetToolTip(Save, "Сохранение поля.");
        }

        // Вставка данных
        private void DataInsert()
        {
            ColumnName.Text = Program.column.ColumnName;
            TypeName.Text = AllData.DataTypes.SqlDataTypesReverse[Program.column.ColumnType];
            if (Program.column.PrimaryKey == 1)
                IsPrimaryKey.Checked = true;
        }

        public ColumnConstruct()
        {
            InitializeComponent();          
            TypeName.DropDownStyle = ComboBoxStyle.DropDownList;
            DataInsert();
            Tips();
            TextCheck();
            if (Program.ColumnMode == 0)
            {
                if (!AllData.IdentityCheck.AvailableForPrimary())
                {
                    IsPrimaryKey.Enabled = false;
                    IsPrimaryKey.Checked = false;
                }
                TypeName.Enabled = false;
            }
        }

        // Отмена
        private void Abort_Click(object sender, EventArgs e)
        {
            TableConstruct columnConstruct = new TableConstruct();
            columnConstruct.Show();
            this.Close();
        }

        // Ввод английского и цифр
        private void ColumnName_KeyPress(object sender, KeyPressEventArgs e)
        {
            int c = (int)e.KeyChar;
            if (!((c >= 65 && c <= 90) || (c >= 97 && c <= 122) || c == 8 || c == 46 || Char.IsDigit(e.KeyChar)))
                e.Handled = true;
        }

        // Обработка пустого поля
        private void ColumnName_TextChanged(object sender, EventArgs e)
        {
            TextCheck();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            bool check = IsPrimaryKey.Checked;
            int pk;
            if (check)
                pk = 1;
            else
                pk = 0;
            if (AllData.IdentityCheck.MainCheck(2, (ColumnName.Text).Replace(' ', '_')))
            {
                if (Program.ColumnMode == 0)
                {
                    AllData.ChangeTable.EditColumn(ColumnName.Text.Replace(' ', '_'), pk);                   
                }
                else
                {
                    AllData.ChangeTable.CreateNewColumn(ColumnName.Text.Replace(' ', '_'), 
                        AllData.DataTypes.SqlDataTypes[TypeName.Text], pk);
                }
                AllData.CurrentTable.GetColumns();
                TableConstruct table = new TableConstruct();
                table.Show();
                this.Close();
            }
            else
                MessageBox.Show("Такое поле в текущей таблице уже существует. " +
                        "Выберете другое имя для поля.",
                        "Повтор имени", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
