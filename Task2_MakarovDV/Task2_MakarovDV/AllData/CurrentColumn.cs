using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_MakarovDV.AllData
{
    public class CurrentColumn
    {
        // Имя столбца
        private string columnName;
        // Тип данных
        private string columnType;
        // Первичный ключ
        private int primaryKey;

        // Создние элемента класса
        public CurrentColumn(string cn, string t)
        {
            columnName = cn;
            columnType = t;
            primaryKey = 0;
        }

        public string ColumnName
        {
            get => columnName;
            set => columnName = value;
        }

        public string ColumnType
        {
            get => columnType;
            set => columnType = value;
        }

        public int PrimaryKey
        {
            get => primaryKey;
            set => primaryKey = value;
        }
    }
}
