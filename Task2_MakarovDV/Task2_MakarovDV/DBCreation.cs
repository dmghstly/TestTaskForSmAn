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
    public partial class DBCreation : Form
    {
        // Высплывающие подсказки
        private void Tips()
        {
            ToolTip toolTip = new ToolTip();

            toolTip.AutoPopDelay = 4000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(name, "Вводить можно только латинские букы и цифры. \n" +
                "При попытке создать существующую БД высветится предупреждение.");
            toolTip.SetToolTip(Create, "Создаёт новую базу данных.");
        }

        // Проверка текста
        private void CheckText()
        {
            if (name.Text != null && name.Text != "")
            {
                Create.Enabled = true;
            }
        }

        public DBCreation()
        {
            InitializeComponent();
            Create.Enabled = false;
            Tips();
        }

        // Обработка кнопки создания БД
        private void Create_Click(object sender, EventArgs e)
        {
            if (AllData.IdentityCheck.MainCheck(0, (name.Text).Replace(' ', '_')))
            {
                AllData.CurrentDB.DBName = (name.Text).Replace(' ', '_');
                AllData.AllDBsChange.AddDB((name.Text).Replace(' ', '_'));
                MainOperatingWindow main = new MainOperatingWindow();
                main.Show();
                this.Close();
            }
            else
                MessageBox.Show("Такая БД уже существует. " +
                    "Выберете другое имя для вашей БД.",
                    "Повтор имени", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Проверка ввода
        private void name_TextChanged(object sender, EventArgs e)
        {
            CheckText();
        }

        // Ввод латиницы и цифр
        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            int c = (int)e.KeyChar;
            if (!((c >= 65 && c <= 90) || (c >= 97 && c <= 122) || c == 8 || c == 46 || Char.IsDigit(e.KeyChar)))
                e.Handled = true;
        }
    }
}
