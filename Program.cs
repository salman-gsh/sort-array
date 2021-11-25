using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[] { 4, 5, -3, 24, 22 }; //Array
            int pivot = array.Length / 2;
            Sort(array, 0, array.Length - 1);

            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.ReadKey();
        }
        static void Sort(int[] array, int left, int right)
        {
            int i = left;
            int j = right;

            int pivot = array[(left + right) / 2];  //Setzt den (ungefaehren) Median als Pivot-Element fest

            while (i <= j)
            {
                while (array[i] < pivot)     //Suche nach groesseren Zahlen
                {
                    i++;
                }

                while (array[j] > pivot)     //Suche nach kleineren Zahlen
                {
                    j--;
                }

                if (i <= j)          //Austauschen der Zahlen
                {
                    int temp = array[i];        //Sichern von array[i]
                    array[i] = array[j];
                    array[j] = temp;

                    i++;        //Beide, weil es sonst nicht weitergehen wuerde
                    j--;
                }

                if (left < j)        //Die Variable, die das rechte Ende linken Array-teiles festgelegt 
                {
                    Sort(array, left, j);
                }

                if (i < right)     //Andersrum 
                {
                    Sort(array, i, right);
                }
            }
        }
    }
}