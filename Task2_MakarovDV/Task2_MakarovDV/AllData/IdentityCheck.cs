using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Task2_MakarovDV.AllData
{
    // Проверка идентичности
    public static class IdentityCheck
    {
        // Проверка имени новой БД
        private static bool CheckDB(string name)
        {
            bool res = true;
            AllDBsChange.ReadDB();
            foreach (string el in AllDBsChange.AllDBs)
            {
                if (el == name)
                    res = false;
            }
            return res;
        }

        // Проверка имени новой таблицы
        private static bool CheckTables(string name)
        {
            bool res = true;
            foreach (string el in CurrentDB.AllTables)
            {
                if (el == name)
                    res = false;
            }
            if (name == CurrentTable.TableName)
                res = true;
            return res;
        }

        // Проверка имени нового поля
        private static bool CheckColumns(string name)
        {
            bool res = true;
            foreach (CurrentColumn el in CurrentTable.AllColumns)
            {
                if (el.ColumnName == name)
                    res = false;
            }
            if (name == Program.column.ColumnName)
                res = true;
            return res;
        }

        // Проверка идентичности данных
        public static bool MainCheck(int mode, string name)
        {
            bool res = true;
            switch (mode)
            {
                case 0:
                    res = CheckDB(name);
                    break;
                case 1:
                    res = CheckTables(name);
                    break;
                case 2:
                    res = CheckColumns(name);
                    break;
            }
            return res;
        }

        // Проверка идентичности данных
        public static bool AvailableForPrimary()
        {
            List<string> check = new List<string>();
            bool res = true;
            string SqlExpr = "SELECT " + Program.column.ColumnName +
                " FROM " + CurrentTable.TableName;
            using (var connection = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=" + 
                CurrentDB.DBName + ";Trusted_Connection=True"))
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

                            if (name == null)
                                res = false;
                            else
                            {
                                foreach (string el in check)
                                {
                                    if (el == name.ToString())
                                        res = false;
                                }
                                check.Add(name.ToString());
                            }
                        }
                    }
                }
            }
            return res;
        }
    }
}
