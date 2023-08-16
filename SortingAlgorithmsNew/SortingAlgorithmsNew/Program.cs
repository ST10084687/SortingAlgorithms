using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers();

            bubbleSort();

            insertionSort();

            QuickSort();

            selectionSort();

        }
        public static void Numbers()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Numbers to be sorted:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("56, 83, 72, 41, 33, 22, 18, 6, 95, 176");
            Console.ReadLine();
        }
        public static void bubbleSort()
        {
            int[] arr = { 56, 83, 72, 41, 33, 22, 18, 6, 95, 176 };
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Bubble Sort:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (int p in arr)
                Console.Write(p + " ");
            Console.ReadLine();
        }
        public static void insertionSort()
        {
            int[] arr = { 56, 83, 72, 41, 33, 22, 18, 6, 95, 176 };
            int n = 10, i, j, val, flag;


            for (i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Insertion Sort:\n");
            Console.ForegroundColor = ConsoleColor.White;
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }


        static public int Partition(int[] arr, int left, int right)
        {
            int pivot;
            pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        static public void quickSort(int[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    quickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSort(arr, pivot + 1, right);
                }
            }
        }
        static void QuickSort()
        {
            int[] arr = { 56, 83, 72, 41, 33, 22, 18, 6, 95, 176 };
            int n = 10, i;
            
            quickSort(arr, 0, 9);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Quick Sort:");
            Console.ForegroundColor = ConsoleColor.White;
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }
    


        public static void selectionSort()
        {
            int[] arr = new int[10] { 56, 83, 72, 41, 33, 22, 18, 6, 95, 176 };
            int n = 10;
           
            int temp, smallest;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Selection sort:");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }
    }
      



    }

