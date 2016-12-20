// SortStringInFile.cs
// arguments: in.txt out.txt -i -a
using System;
using System.IO;

namespace SortStringInFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //string fromfile = "in.txt";
            //string tofile = "out.txt";
            //string typedata = "-i";
            //string sortingmode = "-d";
            if (args.Length < 4)
            {
                Console.WriteLine("Введены не все входные параметры");
                Console.WriteLine("После имени исполняемога файла строка должна иметь вид: имя обрабатываемого файла, имя обработанного файла, -i/-s - тип данных, -a/-d - режим сортировки");
            }
            else
            {
                string fromfile = args[0];
                string tofile = args[1];
                string typedata = args[2];
                string sortingmode = args[3];
                ReadFile reader = new ReadFile();
                string[] beforesorting = reader.Reader(fromfile);

                InsertionSorting sorting = new InsertionSorting();
                if (typedata.Equals("-i"))
                {
                    switch (sortingmode)
                    {
                        case "-a": int[] sortupint = sorting.SortUpInt(beforesorting);
                            string[] stringup = new string[6];
                            for (int i = 0; i <= sortupint.Length - 1; i++)
                            {
                                stringup[i] = sortupint[i].ToString();
                            }
                            WriteFile writerup = new WriteFile();
                            writerup.Writer(stringup, tofile);
                            break;
                        case "-d": int[] sortdownint = sorting.SortDownInt(beforesorting);
                            string[] stringdown = new string[6];
                            for (int i = 0; i <= sortdownint.Length - 1; i++)
                            {
                                stringdown[i] = sortdownint[i].ToString();
                            }
                            WriteFile writerdown = new WriteFile();
                            writerdown.Writer(stringdown, tofile);
                            break;
                        default:
                            Console.WriteLine("Вы задали не существующим режим сортировки");
                            break;
                    }
                }
                else if (typedata.Equals("-s"))
                {
                    string[] aftersorting = sorting.SortUpString(beforesorting);
                    WriteFile writer = new WriteFile();
                    writer.Writer(aftersorting, tofile);
                }
                else Console.WriteLine("Задан не обрабатываемый тип данных");
            }
            
            
        }
    }
}
