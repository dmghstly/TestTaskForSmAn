using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_MakarovDV.AllData
{
    public class CurrentDB
    {
        // Имя БД
        public static string DBName;
        // Таблицы в БД
        public static List<string> AllTables;

        // Получить все таблицы
        public static void GetTables()
        {
            AllTables = new List<string>();
            string SqlExpr = "SELECT TABLE_NAME AS [name] " +
                "FROM INFORMATION_SCHEMA.TABLES";
            using (var connection = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=" + 
                DBName + ";Trusted_Connection=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(SqlExpr, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            object name = reader.GetValue(0);

                            AllTables.Add(name.ToString());
                        }
                    }
                }
            }
        }
    }
}
