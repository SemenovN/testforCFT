using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStringInFile
{
    class InsertionSorting
    {
        public string[] SortUpString(string[] lane)
        {
            string temp;
            int j;
            for (int i = 1; i <= lane.Length - 1; i++)
            {
                temp = lane[i];
                j = i - 1;
                while (j >= 0 && String.Compare(lane[j], temp) > 0)
                {
                    lane[j + 1] = lane[j];
                    j--;
                }
                lane[j + 1] = temp;
            }
            return lane;
        }
        public int[] SortUpInt(string[] lane)
        {
                try
                {
                    int[] intline = Array.ConvertAll(lane, int.Parse);
                    int temp,j;
                    for (int i = 1; i <= intline.Length - 1; i++)
                    {
                        temp = intline[i];
                        j = i - 1;
                        while (j >= 0 && intline[j] > temp)
                        {
                            intline[j + 1] = intline[j];
                            j--;
                        }
                        intline[j + 1] = temp;
                    }
                    return intline;

                }
                catch (Exception e)
                {
                    Console.WriteLine("Файл не может быть отсортирован");
                    Console.WriteLine(e.Message);
                }
            return new int[0];
            }

        public int[] SortDownInt(string[] lane)
        {
         
                try
                {
                    int[] intline = Array.ConvertAll(lane, int.Parse);
                    int temp, j;
                    for (int i = 1; i <= intline.Length - 1; i++)
                    {
                        temp = intline[i];
                        j = i - 1;
                        while (j >= 0 && intline[j] < temp)
                        {
                            intline[j + 1] = intline[j];
                            j--;
                        }
                        intline[j + 1] = temp;
                    }
                    return intline;

                }
                catch (Exception e)
                {
                    Console.WriteLine("Файл не может быть отсортирован");
                    Console.WriteLine(e.Message);
                }
                return new int[0];
            }
    }
}
