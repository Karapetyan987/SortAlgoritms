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
    public class MerSort : Abs, IShow
    {
        public TimeSpan s;
        public Stopwatch stopWatch = new Stopwatch(); 
        public override int[] Sort(int[] M)
        {
            stopWatch.Start();
            return MergeSortRecursive(M, 0, M.Length - 1);
        }
        private int[] MergeSortRecursive(int[] data, int left, int right)
        {
           

            if (left < right)
            {
                int m = left + (right - left) / 2;

                MergeSortRecursive(data, left, m);
                MergeSortRecursive(data, m + 1, right);
                Merge(data, left, m, right);
            }
            stopWatch.Stop();
            s = stopWatch.Elapsed;
            return data;
        }



        private void Merge(int[] data, int left, int mid, int right)
        {
            int i, j, k;
            int n1 = mid - left + 1;
            int n2 = right - mid;
            int[] L = new int[n1];
            int[] R = new int[n2];

            for (i = 0; i < n1; i++)
                L[i] = data[left + i];

            for (j = 0; j < n2; j++)
                R[j] = data[mid + 1 + j];

            i = 0;
            j = 0;
            k = left;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    data[k] = L[i];
                    i++;
                }
                else
                {
                    data[k] = R[j];
                    j++;
                }

                k++;
            }

            while (i < n1)
            {
                data[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                data[k] = R[j];
                j++;
                k++;
            }
        }

        public void Show(int[] A)
        {
            ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"MergeSort\n{s}"); 
            //MerSort i = new MerSort();
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
        //    MerSort b = new MerSort();
        //    int p = (int)GC.GetTotalMemory(false);
        //    b.Sort(M);
        //    int w = (int)GC.GetTotalMemory(false);
        //    Console.WriteLine(w - p);
        //}
    }
}
