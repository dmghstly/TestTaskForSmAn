using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2_MakarovDV
{
    static class Program
    {
        // Изменение таблицы для столбца. 0 редактирование, 1 создание.
        public static int ColumnMode;
        // Изменение самой таблицы. 0 редактирование, 1 создание
        public static int TableMode;
        // Выбранный столбец  
        public static AllData.CurrentColumn column;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DBEditor());
        }
    }
}
