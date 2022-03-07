using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Task2_MakarovDV.AllData
{
    // Текущая таблица, с которой ведётся работа
    public class CurrentTable
    {
        // Имя таблицы
        public static string TableName;
        // Все столбцы
        public static List<CurrentColumn> AllColumns;

        // Получить все столбцы
        public static void GetColumns()
        {
            AllColumns = new List<CurrentColumn>();
            string SqlExpr = "SELECT * " +
                "FROM INFORMATION_SCHEMA.COLUMNS " +
                "WHERE TABLE_NAME = '"+TableName+"'";
            using (var connection = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=" + 
                CurrentDB.DBName + ";Trusted_Connection=True"))
            {
                connection.Open();

                using (SqlDataReader reader = new SqlCommand(SqlExpr, connection).ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CurrentColumn column =
                                new CurrentColumn(reader["COLUMN_NAME"].ToString(), reader["DATA_TYPE"].ToString());
                            AllColumns.Add(column);
                        }
                    }
                }
                SqlExpr = "EXEC sp_pkeys " + TableName;
                using (SqlDataReader reader = new SqlCommand(SqlExpr, connection).ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            foreach (CurrentColumn el in AllColumns)
                                if (el.ColumnName == reader["COLUMN_NAME"].ToString())
                                    el.PrimaryKey = 1;
                        }
                    }
                }
            }
        }
    }
}
