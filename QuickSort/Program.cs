using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 100;
            int[] a = new int[N];
            Random r = new Random();
            for (int i = 0; i < N; i++)
            {
                a[i] = r.Next(1, N + 1);
            }

            // display unsorted list
            WriteLine("Unsorted: ");
            foreach (int i in a)
            {
                Write(i + " ");
            }
            WriteLine();

            // call sort routine        
            QuickSort(a, 0, N-1);
            //SpecialInsertionSort(testArray, N, testArray[0], testArray[N-1]);

            // display sorted list
            WriteLine("Sorted: ");
            foreach (int i in a)
            {
                Write(i + " ");
            }
            WriteLine();
            ReadLine();
        }

        static void QuickSort(int[] list, int first, int last)
            // list: the elements to be put in order
            // first: the index of the first element in the part of the list to sort
            // last: the index of the last element in the part of the list to sort
        {
            if(first < last)
            {
                int pivot = PivotList(list, first, last);
                QuickSort(list, first, (pivot));
                QuickSort(list, (pivot+1), last);
            }   // end if
        }

        static int PivotList(int[] list, int first, int last)
            // list: the elements to work with
            // first: the index of the first element
            // last: the index of the last element
        {
            int PivotValue = list[first];
            int PivotPoint = first;

            for(int index = (first+1); index <= last; index++)
            {
                if(list[index] < PivotValue)
                {
                    PivotPoint = PivotPoint + 1;
                    Swap(list, PivotPoint, index);
                }   // end if
            }   // end for

            // move pivot value into correct place
            Swap(list, first, PivotPoint);
            return PivotPoint;
        }

        static void Swap(int[] list, int i, int j)
        {
            int temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
