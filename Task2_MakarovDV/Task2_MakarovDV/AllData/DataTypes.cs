using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_MakarovDV.AllData
{
    public static class DataTypes
    {
        // Типы данных для SQL запросов
        public static Dictionary<string, string> SqlDataTypes = new Dictionary<string, string>()
        {
            { "целочисленный", "int" },
            { "вещественный", "float" },
            { "текстовый", "nvarchar" },
            { "дата/время", "datetime" }
        };

        // Перевертыш
        public static Dictionary<string, string> SqlDataTypesReverse = new Dictionary<string, string>()
        {
            { "int", "целочисленный" },
            { "float", "вещественный" },
            { "nvarchar", "текстовый" },
            { "datetime", "дата/время" }
        };

        // Пазделители
        


        public static Dictionary<string, string> DevideEls = new Dictionary<string, string>()
        {
            { "Запятая", "," },
            { "Точка с запятой", ";" },
            { "Tab", "\t" }
        };
    }
}
