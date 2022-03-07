using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_MakarovDV.AllData
{
    public static class DataAddjustmentTypes
    {
        // Создание новой таблицы
        public static void NewTableCreation()
        {
            Program.TableMode = 1;
            CurrentTable.TableName = "";
            CurrentTable.AllColumns = new List<CurrentColumn>();
        }

        // Изменение существующей таблицы
        public static void CurrentTableAddjustment(string name)
        {
            Program.TableMode = 0;
            CurrentTable.TableName = name;
            CurrentTable.GetColumns();
        }

        // Создание нового поля
        public static void NewColumnCreation()
        {
            Program.ColumnMode = 1;
            Program.column.ColumnName = "";
            Program.column.ColumnType = "int";
            Program.column.PrimaryKey = 0;
        }

        // Изменение существующего поля
        public static void CurrentColumnAddjustment(string name)
        {
            Program.ColumnMode = 0;
            foreach (CurrentColumn el in CurrentTable.AllColumns)
            {
                if (el.ColumnName == name)
                {
                    Program.column.ColumnName = el.ColumnName;
                    Program.column.ColumnType = el.ColumnType;
                    Program.column.PrimaryKey = el.PrimaryKey;
                }
            }
        }
    }
}
