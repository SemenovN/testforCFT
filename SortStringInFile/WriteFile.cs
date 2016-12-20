using System;
using System.IO;

namespace SortStringInFile
{
    class WriteFile
    {
        public void Writer(string[] aftersorting, string tofile)
        {
            try
            {
                StreamWriter writer = new StreamWriter(@"./" + tofile);
                for (int i = 0; i <= aftersorting.Length-1; i++)
                {
                    writer.WriteLine(aftersorting[i]);
                }
                writer.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("Файл не может быть записан");
                Console.WriteLine(e.Message);
            }
        }
    }
}
