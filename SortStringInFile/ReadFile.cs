using System;
using System.IO;

namespace SortStringInFile
{
    class ReadFile
    {
        public string[] Reader(string fromfile)
        {
            try
            {
                StreamReader reader = new StreamReader(@"./" + fromfile);
                string line = reader.ReadToEnd();
                reader.Close();
                if (line.Contains(" "))
                {
                    Console.WriteLine("Обрабатываемый файл содержит пробелы, что не допустимо");
                    return new string[0];
                }
                   
                string[] row = line.Split('\n');
                //Console.Write(row[1]);
                return row;
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Файл не может быть прочитан");
                Console.WriteLine(e.Message);
            }
            return new string[0];
        }
    }
}
