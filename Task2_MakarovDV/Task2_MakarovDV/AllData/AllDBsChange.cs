using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Task2_MakarovDV.AllData
{
    // Используется для получения всех БД, связанных с этим редактором
    public static class AllDBsChange
    {
        // Путь до файла с БД
        private static string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AllDBs.txt");
        // Все БД
        public static List<string> AllDBs;

        // Добавление в SQL server
        public static void AddToSqlServer(string DBName)
        {
            SqlConnection connection = new SqlConnection("Server = (localdb)\\mssqllocaldb;Integrated security=SSPI;database=master");
            SqlCommand command = new SqlCommand("CREATE DATABASE "+DBName, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        // Добавить БД в файл
        public static void AddDB(string DBName)
        {
            AddToSqlServer(DBName);
            if (!File.Exists(FilePath))
                File.Create(FilePath);
            using (StreamWriter writer = new StreamWriter(FilePath, true))
            {
                writer.WriteLine(DBName);
            }
        }

        // Чтение всех БД
        public static void ReadDB()
        {
            if (!File.Exists(FilePath))
                File.Create(FilePath);
            AllDBs = new List<string>();
            using (StreamReader reader = new StreamReader(FilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    AllDBs.Add(line);
                }
            }
        }
    }
}