using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_2
{
    class Program
    {
        

        
        static void Main(string[] args)
        {
            List<int> tab1 = new List<int>();
            List<int> tab2 = new List<int>();
            List<int> tab12 = new List<int>();

            int n, m;
            Console.WriteLine("length of the first array?");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("length of the second array?");
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Array 1");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((i+1) +"_ : ");
                tab1.Add( Convert.ToInt32(Console.ReadLine()));

            }

            Console.WriteLine("Array 2");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine((i + 1) + "_ : ");
                tab2.Add(Convert.ToInt32(Console.ReadLine()));

            }
            sortTab(tab1, n);
            sortTab(tab2, m);
            mergeAndSort(tab1, tab2, 0, n, 0, m,tab12);

            for (int i = 0; i < tab12.Count; i++)
            {
                Console.WriteLine("elem "+(i+1)+" "+tab12[i]);
                

            }
            Console.ReadLine();
        }

        private static void sortTab(List<int> tab, int end)
        {
            int intermediate;
            startSorting:
            bool isSorted = true;
            for(int i = 1; i < end; i++)
            {
                if (tab[i] < tab[i - 1])
                {
                    intermediate = tab[i-1];
                    tab[i - 1] = tab[i];
                    tab[i] = intermediate;
                    isSorted = false;
                }

            }
            if (isSorted == false)
            {
                goto startSorting;
            }


        }

        private static void mergeAndSort(List<int> tab1, List<int> tab2,int start1, int end1, int start2, int end2,List<int>tab12)
        {
            //if (tab1[end1/2]< tab2[end2 / 2])
            //{
            //    mergeAndSort(tab1, tab2, start1, end1, start2, end2);

            //}

            if (start1 < end1 && start2 < end2)
            {
                if (tab1[start1] < tab2[start2])
                {
                    tab12.Add(tab1[start1]);
                    mergeAndSort(tab1, tab2, start1 + 1, end1, start2, end2, tab12);
                }
                else
                {
                    tab12.Add(tab2[start2]);
                    mergeAndSort(tab1, tab2, start1, end1, start2 +1 , end2, tab12);
                }


            }

            
                if (end1 > end2 && start1 < end1)
            {
                tab12.Add(tab1[start1]);
                mergeAndSort(tab1, tab2, start1 + 1, end1, start2, end2, tab12);

            }else
                if (end2 > end1 && start2 < end2)
            {
                tab12.Add(tab2[start2]);
                mergeAndSort(tab1, tab2, start1, end1, start2 + 1, end2, tab12);
            }

            
        }
    }
}
