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
    public class InsSort:Abs,IShow
    {
        public TimeSpan s1;

        public override int[] Sort(int[] M)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 1; i < M.Length; i++)
            {
                
                int temp = M[i];
                for (int j = i-1; j >= 0; j--)
                {
                    if (temp>M[j])
                    {
                        M[j + 1] = temp;
                        break;
                    }
                    else
                    {
                        M[j + 1] = M[j];
                        if (j==0)
                        {
                            M[j] = temp;
                        }
                    }
                }
                
            }
            stopWatch.Stop();

            s1 = stopWatch.Elapsed;
            return M;
        }
        public void Show(int[] A)
        {
            ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"InsertionSort\n{s1}");
            //InsSort i = new InsSort();
            //i.Memor(A);
            ResetColor();
            foreach (var item in A)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
        // public void Memor(int[] M)
        //{
        //   InsSort b = new InsSort();
        //    int p = (int)GC.GetTotalMemory(false);
        //    b.Sort(M);
        //    int w = (int)GC.GetTotalMemory(false);
        //    Console.WriteLine(w - p);
        //}
    }
}
