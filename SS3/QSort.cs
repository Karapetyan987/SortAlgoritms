using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Diagnostics;
using System.Threading;

namespace SS3
{
    public class QSort : Abs,IShow
    {
        public TimeSpan s;
        public Stopwatch stopWatch = new Stopwatch();
        public override int[] Sort(int[] M)
        {
            stopWatch.Start();
            return Sort1(M, 0, M.Length - 1);
        }
        private static int Partition(int[] array, int low,
                                     int high)
        {
           
            int pivot = array[high];

            int lowIndex = (low - 1);

         
            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    lowIndex++;

                    int temp = array[lowIndex];
                    array[lowIndex] = array[j];
                    array[j] = temp;
                }
            }

            int temp1 = array[lowIndex + 1];
            array[lowIndex + 1] = array[high];
            array[high] = temp1;

            return lowIndex + 1;
        }

        private int[] Sort1(int[] array, int low, int high)
        {
           
            
            if (low < high)
            {
                int partitionIndex = Partition(array, low, high);

              
                Sort1(array, low, partitionIndex - 1);
                Sort1(array, partitionIndex + 1, high);
            }
            stopWatch.Stop();

            s = stopWatch.Elapsed;
            return array;
        }
        public void Show(int[] A)
        {
            ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"QuickSort\n{s}");
            //QSort i = new QSort();
            //i.Memor(A);
            ResetColor();
            foreach (var item in A)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        //public void Memor(int[] M)
        //{
        //    QSort b = new QSort();
        //    int p = (int)GC.GetTotalMemory(false);
        //    b.Sort(M);
        //    int w = (int)GC.GetTotalMemory(false);
        //    Console.WriteLine(w - p);
        //}


    }
}
