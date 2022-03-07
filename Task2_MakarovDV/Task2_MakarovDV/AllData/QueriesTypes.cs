using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Task2_MakarovDV.AllData
{
    // Запросы
    public static class QueriesTypes
    {
        // Запрос на обновление данных
        public static void QueryUpdate(string SqlExpr)
        {
            using (var connection = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=" + 
                CurrentDB.DBName + ";Trusted_Connection=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(SqlExpr, connection);
                int number = command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
