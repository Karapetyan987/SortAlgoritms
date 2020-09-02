using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using static System.Console;

namespace SS3
{
    public class BubSort : Abs,IShow
    {
        public TimeSpan s;
        public override int[] Sort(int[] M)
        {
        Stopwatch stopWatch = new Stopwatch(); stopWatch.Start();
            
            for (int j = 0; j < M.Length; j++)
            {
                for (int i = 0; i < M.Length - j - 1; i++)
                {
                    if (M[i] > M[i + 1])
                    {
                        int temp = M[i + 1];
                        M[i + 1] = M[i];
                        M[i] = temp;
                    }

                }
            }
            stopWatch.Stop();
            
            s = stopWatch.Elapsed;

            
            return M;
        }
        public void Show(int[] A)
        {
            ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"BubbleSort\n{s}");
            //BubSort i = new BubSort();
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
        //    BubSort b = new BubSort();
        //    int p = (int)GC.GetTotalMemory(false);
        //    b.Sort(M);
        //    int w = (int)GC.GetTotalMemory(false);
        //    Console.WriteLine(w-p);
        //}
    }
}
