using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace SS3
{
    class Program
    {
        
       public static void Main(string[] args)
        {
            BubSort b = new BubSort();
            InsSort i = new InsSort();
            MerSort m = new MerSort();
            QSort q = new QSort();         
            Random rd = new Random();
            Console.Write("Enter the size of the array...");      
            int size = int.Parse(ReadLine());        
            int[] a = new int[size];
            int[] A;
            for (int j = 0; j < size; j++)
            {
                a[j] = rd.Next(-1000, 1001);
            }
            Console.WriteLine("Choose one of the following algorithms... \n1 - BubbleSort  \n2 - InsertionSort \n3 - MergeSort \n4 - QuickSort \n5 - All algorithms ");
            string alg = ReadLine();
            if (alg.Length == 1)
            {
                switch (alg)
                {
                    case "1":                        
                        A = b.Sort(a);
                        b.Show(A);
                        break;
                    case "2":
                        A = i.Sort(a);
                        i.Show(A);
                        break;
                    case "3":
                        A = m.Sort(a);
                        m.Show(A);
                        break;
                    case "4":
                        A = q.Sort(a);
                        q.Show(A);
                        break;
                    case "5":
                        A = b.Sort(a);
                        b.Show(A);
                        A = i.Sort(a);
                        i.Show(A);
                        A = m.Sort(a);
                        m.Show(A);
                        A = q.Sort(a);
                        q.Show(A);
                        break;
                    default:
                        break;
                }
            }
            else if (alg[1] == '-')
            {
                int k = (int)alg[0];
                while (k <= (int)alg[2])
                {

                    switch (k)
                    {
                        case '1':
                            A = b.Sort(a);
                           
                            b.Show(A);

                            break;
                        case '2':
                            A = i.Sort(a);
                            i.Show(A);
                            break;
                        case '3':
                            A = m.Sort(a);
                            m.Show(A);
                            break;
                        case '4':
                            A = q.Sort(a);
                            q.Show(A);
                            break;
                        default:
                            break;
                    }
                    k++;
                }
            }
            else if (alg[1] == ',')
            {
                for (int z = 0; z <= alg.Length; z += 2)
                {
                    int k = (int)alg[z];
                    switch (k)
                    {
                        case '1':
                            A = b.Sort(a);
                            b.Show(A);
                            break;
                        case '2':
                            A = i.Sort(a);
                            i.Show(A);
                            break;
                        case '3':
                            A = m.Sort(a);
                            m.Show(A);
                            break;
                        case '4':
                            A = q.Sort(a);
                            q.Show(A);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
