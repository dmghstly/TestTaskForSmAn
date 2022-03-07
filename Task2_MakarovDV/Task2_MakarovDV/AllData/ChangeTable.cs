using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Task2_MakarovDV.AllData
{
    public static class ChangeTable
    {
        // Удаление колонки
        public static void DeleteColumn()
        {
            string SqlExpr = "ALTER TABLE "+CurrentTable.TableName+
                " DROP COLUMN "+Program.column.ColumnName;
            QueriesTypes.QueryUpdate(SqlExpr);
        }

        // Переименование таблицы
        public static void TableNameChange(string NewName)
        {
            string SqlExpr = "RENAME TABLE " + CurrentTable.TableName + 
                " TO " + NewName;
            QueriesTypes.QueryUpdate(SqlExpr);
        }

        // Создание таблицы
        public static void CreateNewTable(string NewName)
        {
            string SqlExpr = "CREATE TABLE " + NewName +
                " ( id int not null )";
            QueriesTypes.QueryUpdate(SqlExpr);
        }

        // Удаление таблицы
        public static void DeleteTable(string Name)
        {
            string SqlExpr = "DROP TABLE " + Name;
            QueriesTypes.QueryUpdate(SqlExpr);
        }

        // Создание поля
        public static void CreateNewColumn(string NewName, string type, int pk)
        {
            if (type == "nvarchar")
                type += "(max)";
            string SqlExpr = "ALTER TABLE " + CurrentTable.TableName + 
                " ADD " + NewName + " " + type;
            if (pk == 1)
                SqlExpr += " NOT NULL";
            else
                SqlExpr += " NULL";
            QueriesTypes.QueryUpdate(SqlExpr);
            if (pk == 1)
            {
                SqlExpr = "ALTER TABLE " + CurrentTable.TableName +
                    " ADD PRIMARY KEY (" + NewName + ")";
                QueriesTypes.QueryUpdate(SqlExpr);
            }           
        }

        // Редактирование поля
        public static void EditColumn(string NewName, int pk)
        {
            string SqlExpr = "EXEC sp_rename '" + CurrentTable.TableName + "." + Program.column.ColumnName + "', '" +
                NewName + "', 'COLUMN'";
            QueriesTypes.QueryUpdate(SqlExpr);
            if (pk == 1 && Program.column.PrimaryKey == 0)
            {
                SqlExpr = "ALTER TABLE " + CurrentTable.TableName +
                    " ADD PRIMARY KEY (" + NewName + ")";
                QueriesTypes.QueryUpdate(SqlExpr);
            }
            else if (pk == 0 && Program.column.PrimaryKey == 1)
            {
                SqlExpr = "ALTER TABLE " + CurrentTable.TableName +
                    " DROP PRIMARY KEY";
                QueriesTypes.QueryUpdate(SqlExpr);
            }
        }
    }
}
