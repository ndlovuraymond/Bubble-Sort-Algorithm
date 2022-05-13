using System;

namespace My_Bubble_Sort_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }
        public static int[] BubbleSort(int[] array)
        {
            int sortcounter = 0;
            do
            {
                sortcounter = 0;
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int record = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = record;
                        sortcounter += 1;
                    }
                }
            } while (sortcounter != 0);
            return array;
            }
        }
    }

