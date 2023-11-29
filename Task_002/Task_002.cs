using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_002
{
    public class Task_002
    {
        public const int STR = 3;
        public const int COL = 4;
        public const int MIN = 1;
        public const int MAX = 100;
        public static void Main(string[] args) {
            int[][] multiArray = GetMultiArrayWithRandomValue(STR, COL);

            System.Console.WriteLine("Оригинальный массив: ");
            PrintMultiArray(multiArray);

            int[] diogonalElements = GetDiogonalElements(multiArray);

            System.Console.WriteLine("Сумма элементов по диогонали равна: ");
            System.Console.WriteLine(GetSum(diogonalElements));
        }

        public static int[][] GetMultiArrayWithRandomValue(int stringCount, int columnCount) {
            int[][] jaggedArray = new int[stringCount][];
            for(int i = 0; i < stringCount; i++) {
                jaggedArray[i] = GetArrayWithRandomValue(columnCount);
            }
            return jaggedArray;
        }

        public static int[] GetArrayWithRandomValue(int size) {
            int[] array = new int[size];
            for(int i = 0; i < size; i++) {
                array[i] = new Random().Next(MIN, MAX);
            }
            return array;
        }

        public static string PrintArray(int[] array) {
            string result = "";
            foreach(int item in array) {
                result = result + item + " ";
            }
            return result;
        }

        public static void PrintMultiArray(int[][] array) {
            for(int i = 0; i < array.Length; i++) {
                System.Console.WriteLine(PrintArray(array[i]));
            }
        }

        public static int[] GetDiogonalElements(int[][] originArray) {
            int[] array = new int[originArray.Length];
            for(int i = 0; i < originArray.Length; i++) {
                array[i] = GetElement(i, originArray[i]);
            }
            return array;
        }

        public static int GetElement(int step, int[] array) {
            if(step < array.Length) {
                return array[step];
            }
            return 0;
        }

        public static int GetSum(int[] array) {
            int sum = 0;
            foreach(int item in array) {
                sum += item;
            }
            return sum;
        }
    }
}